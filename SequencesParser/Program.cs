using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace SequencesParser
{
    /// <summary>
    /// Prende in input le sequenze allineate con la cina, la gene annotation e stampa in output un file di differenze comprendenti i geni
    /// </summary>
    public class Program
    {
        public static int[,] matrix;
        public static int indice = 0;
        static void Main(string[] args)
        {
            //prendo i file json utili alla scansione delle sequenze allineate
            var path = Directory.GetCurrentDirectory();
            // i file gff dell'annotazione genica sono stati convertiti in json tramite un tool recuperabile sul web
            var path1 = Path.Combine(Directory.GetCurrentDirectory(), "gene-annotation.json");
            //il file json delle sequenze allineate si può recuperare rapidamente da Jalview tramite Output to textbox
            var path2 = Path.Combine(Directory.GetCurrentDirectory(), "alligned-sequences.json");

            string file2 = File.ReadAllText(path1);
            //deserializzo il file dell'annotazione genica
            GenesList genesList = new GenesList();

            genesList = JsonConvert.DeserializeObject<GenesList>(file2);

          

            string file3 = File.ReadAllText(path2);
            //deserializzo file di sequenze allineate
            SequencesList list = new SequencesList();

            list = JsonConvert.DeserializeObject<SequencesList>(file3);


            //creo l'oggetto delle variazioni da stampare in output
            DifferenceOutput o = new DifferenceOutput();
            o.DifferenceLists = new List<DifferenceList>();

            


            Console.WriteLine("numero sequenze presenti: " + list.Seqs.Count);
            Sequence reference = new Sequence();
            //trova la sequenza reference
            for (int i = 0; i < list.Seqs.Count; i++)
            {

                if (list.Seqs.ElementAt(i).Name == "hCoV-19/Wuhan/IPBCAMS-WH-01/2019|EPI_ISL_402123|2019-12-24/1-29899")
                {
                    reference = list.Seqs.ElementAt(i);
                }
                else if (list.Seqs.ElementAt(i).Name == "NC_045512.2/1-29903")
                {
                    reference = list.Seqs.ElementAt(i);
                }

            }
         





            //per ogni sequenza allineata calcola le differenze con la ref
            for (int i = 0; i < list.Seqs.Count; i++)
            {


                DifferenceList diffs = new DifferenceList();
                diffs.Seq1 = reference;
                diffs.Seq2 = list.Seqs.ElementAt(i);
               //calcola le differenze tra ref e seq 2
                DifferenceCalculator(diffs);

               
                
                //aggiunge le differenze tra le due sequenze alla lista di differenze globali
                o.DifferenceLists.Add(diffs);
                
                Console.WriteLine("measuring differences of sequence: " + i);
                if (diffs.Differences.Count > 0)
                {
                    Console.WriteLine("La sequenza " + diffs.Seq2.Name + " possiede: " + diffs.Differences.Count + " variazioni rispetto alla ref");
                    for (int j = 0; j < diffs.Differences.Count; j++)
                    {
                        Console.WriteLine(diffs.Differences.ElementAt(j).Newletter + " al posto di " + diffs.Differences.ElementAt(j).Oldletter + " in posizione " + diffs.Differences.ElementAt(j).Position + " rispetto alla sequenza " + diffs.Seq1.Name + " che è la sequenza di REF");
                    }
                }

            }
            GenesList geneswithcds = new GenesList();
            geneswithcds.geneslist = new List<Gene>();
           
            //trova i geni con cds nel file gene-annotation
            for (int w = 0; w < genesList.geneslist.Count(); w++)
            {

                if (genesList.geneslist.ElementAt(w).type == "CDS")
                {
                    geneswithcds.geneslist.Add(genesList.geneslist.ElementAt(w)); 
                }
            }
            //crea la matrice
            matrix = new int[o.DifferenceLists.Count + 1, geneswithcds.geneslist.Count + 1];

            //scrive i geni corrispondenti se presente il file gene-annotation
            if (path1 != null)
            {   //per ogni lista di differenza tra sequenze
               
                
                for (int j = 1; j < o.DifferenceLists.Count; j++)
                {
                    indice++;
                    //per ogni differenza tra due sequenze
                    for (int k = 0; k < o.DifferenceLists.ElementAt(j).Differences.Count; k++)
                    {   //per ogni gene presente nel file gene-annotation
                        int cont = 0;
                        for (int w = 0; w < geneswithcds.geneslist.Count(); w++)
                        {
                            
                            if (geneswithcds.geneslist.ElementAt(w).type == "CDS")
                            {
                                
                               
                                
                                //posizione globale d'inizio del gene
                                int start = geneswithcds.geneslist.ElementAt(w).start;
                                //posizione globale di fine del gene
                                int end = geneswithcds.geneslist.ElementAt(w).end;
                                //posizione globale della differenza tra due sequenze
                                int position = o.DifferenceLists.ElementAt(j).Differences.ElementAt(k).Position;
                                //posizione relativa all'interno del gene
                                int relpos = position - start;

                                //se la posizione rientra nel range del gene allora salvo il gene associato alla differenza
                                if ((position >= start) && (position <= end))
                                {


                                    o.DifferenceLists.ElementAt(j).Differences.ElementAt(k).Gene = geneswithcds.geneslist.ElementAt(w).gene;
                                    o.DifferenceLists.ElementAt(j).Differences.ElementAt(k).Startcds = geneswithcds.geneslist.ElementAt(w).start;
                                    o.DifferenceLists.ElementAt(j).Differences.ElementAt(k).Endcds = geneswithcds.geneslist.ElementAt(w).end;
                                    

                                    int fine = (3 - ((end - start) % 3)); //posizione fine del gene
                                    if (fine == 3)
                                    fine = 0; //controllo geni divisibili per 3 (altrimenti non determinabile)
                                    String geneRef = o.DifferenceLists.ElementAt(j).Seq1.Seq.Substring(start , end - start + fine);
                                    o.DifferenceLists.ElementAt(j).Differences.ElementAt(k).Genseq = geneRef;
                                    String geneCurSeq = o.DifferenceLists.ElementAt(j).Seq2.Seq.Substring(start , end - start + fine);

                                    List<Codon> oldcodons = new List<Codon>();
                                    List<Codon> newcodons = new List<Codon>();
                                    //divido il gene in triplette e le inserisco in una lista
                                    for (int t = 0; t < end - start + fine; t += 3)
                                    {

                                        Codon old= new Codon();
                                        Codon nuovo = new Codon();
                                                 
                                        old.Triplet = geneRef[t].ToString() + geneRef[t + 1] + geneRef[t + 2];
                                        //calcolo l'amminoacido associato alla vecchia tripletta
                                        old.Aminoacid = getAminoacid(old.Triplet);
                                                
                                       
                                        old.Start = t+1;
                                                
                                        old.End = t + 3;
                                        oldcodons.Add(old);

                                                
                                        nuovo.Triplet = geneCurSeq[t].ToString() + geneCurSeq[t + 1] + geneCurSeq[t+ 2];
                                        //calcolo l'amminoacido associato alla nuova tripletta
                                        nuovo.Aminoacid = getAminoacid(nuovo.Triplet);
                                        //t+1 perché parte da 0 mentre nel file le sequenze partono da 1       
                                        nuovo.Start = t+1;
                                                
                                        nuovo.End = t + +3;
                                        newcodons.Add(nuovo);

                                        //vengono recuperati gli amminoacidi per la posizione corrente (ogni 3 basi)


                                    }
                                    // prendo la tripletta della reference associata alla differenza
                                    for (int r=0; r<oldcodons.Count; r++)
                                    {
                                        if(relpos>=oldcodons.ElementAt(r).Start && relpos <= oldcodons.ElementAt(r).End)
                                        {
                                            o.DifferenceLists.ElementAt(j).Differences.ElementAt(k).Oldcodon = oldcodons.ElementAt(r);
                                        }

                                    }
                                    //prendo la tripletta della seconda sequenza associata alla differenza
                                    for (int s=0; s<newcodons.Count; s++)
                                    {
                                        if (relpos>=newcodons.ElementAt(s).Start && relpos <= newcodons.ElementAt(s).End)
                                        {
                                            o.DifferenceLists.ElementAt(j).Differences.ElementAt(k).Newcodon = newcodons.ElementAt(s);
                                            
                                            if (o.DifferenceLists.ElementAt(j).Differences.ElementAt(k).Oldcodon.Aminoacid != o.DifferenceLists.ElementAt(j).Differences.ElementAt(k).Newcodon.Aminoacid)
                                            {
                                                //inserisce 1 nella matrice quando trova una tripletta mutata
                                                matrix[indice,cont] = 1;
                                                Console.WriteLine(o.DifferenceLists.ElementAt(j).Differences.ElementAt(k).Newcodon.Aminoacid + " al posto di " + o.DifferenceLists.ElementAt(j).Differences.ElementAt(k).Oldcodon.Aminoacid + " nella sequenza " + o.DifferenceLists.ElementAt(j).Seq2.Name + " in posizione " + o.DifferenceLists.ElementAt(j).Differences.ElementAt(k).Position);
                                            }


                                        }
                                    }


                                   

                                }



                              
                               }

                            cont++;

                        }


                        Console.WriteLine("writing genes part: " + j);
                    }
                    
                }

               
            }
            //costruisce la matrice
            createMatrix(o, geneswithcds);






            

            //serializzo l'oggetto con le differenze
            string diffJSON = JsonConvert.SerializeObject(o);
              var path3 = Path.Combine(Directory.GetCurrentDirectory(), "differences.json");
              System.IO.File.WriteAllText(path3, diffJSON);
            }
        


        

       
        //conta le differenze tra due sequenze
        public static void DifferenceCalculator(DifferenceList diffs)
        {
            diffs.Differences = new List<Difference>();


            //per la lunghezza di tutta la stringa di sequenza controllo le differenze con la ref
            for (int i = 0; i < diffs.Seq2.Seq.Length; i++)
            {
                int j = 1;
                int k = i;

                if (diffs.Seq2.Seq.ElementAt(i) != diffs.Seq1.Seq.ElementAt(i))
                {
                    string conc = diffs.Seq2.Seq.ElementAt(i).ToString();
                    string oldconc = diffs.Seq1.Seq.ElementAt(i).ToString();
                    Difference d = new Difference();
                    if (diffs.Seq2.Seq.ElementAt(i + j) != diffs.Seq1.Seq.ElementAt(i + j) && (i + j < diffs.Seq1.Seq.Length - 1))
                    {
                        while (diffs.Seq2.Seq.ElementAt(i + j) != diffs.Seq1.Seq.ElementAt(i + j) && (i + j < diffs.Seq1.Seq.Length - 1))
                        {
                            //concatena le eventuali mutazioni più lunghe di 1
                            conc = conc + "" + diffs.Seq2.Seq.ElementAt(i + j).ToString();
                            oldconc = oldconc + "" + diffs.Seq1.Seq.ElementAt(i + j).ToString();
                            d.Newletter = conc;
                            d.Oldletter = oldconc;
                            d.Position = i+1;
                            j++;


                        }
                        if (d != null)
                        {
                            diffs.Differences.Add(d);

                        }
                    }
                    else
                    {
                        Difference diff = new Difference();
                        diff.Newletter = diffs.Seq2.Seq.ElementAt(i).ToString();
                        diff.Oldletter = diffs.Seq1.Seq.ElementAt(i).ToString();
                        diff.Position = i+1;
                        diffs.Differences.Add(diff);
                    }




                    if (i < diffs.Seq2.Seq.Length - 1)
                    {
                        i = i + j;
                    }


                }




            }


            
        }

        public static void createMatrix(DifferenceOutput o, GenesList genesList)
        {
           // StreamWriter sw = new StreamWriter();
            StreamWriter sw = File.CreateText("Matrix.txt");
            for (int t = 0; t < genesList.geneslist.Count; t++)
            {
                if (genesList.geneslist.ElementAt(t).gene != null)
                {
                    sw.Write( genesList.geneslist.ElementAt(t).gene + " Start: " + genesList.geneslist.ElementAt(t).start + " End: " + genesList.geneslist.ElementAt(t).end + " | ");
                }
                else sw.Write( "null"+ " ");
            }
            sw.WriteLine("");
            for (int k = 0; k < o.DifferenceLists.Count; k++)
            {
                for (int t = 0; t < genesList.geneslist.Count; t++)
                {
                    sw.Write( matrix[k, t] + "                                          "  );
                }
                sw.Write(o.DifferenceLists.ElementAt(k).Seq2.Name + "\n");
            }
            sw.Close();
        }



        //metodo che ritorna l'amminoacido relativo alla tripletta associata
        public static string getAminoacid(string triplet)
        {
            if (triplet.Contains("N"))
            {
                return "ND - Tripletta non determinabile";
            }
            switch (triplet)
            {
                case "TTT":
                case "TTC":
                    return "F - Fenilalanina";
                case "TTA":
                case "TTG":
                case "CTT":
                case "CTC":
                case "CTA":
                case "CTG":
                    return "L - Leucina";
                case "ATT":
                case "ATC":
                case "ATA":
                    return "I - Isoleucina";
                case "ATG":
                    return "M - Metionina";
                case "GTT":
                case "GTC":
                case "GTA":
                case "GTG":
                    return "V - Valina";
                case "TCT":
                case "TCC":
                case "TCA":
                case "TCG":
                    return "S - Serina";
                case "CCT":
                case "CCC":
                case "CCA":
                case "CCG":
                    return "P - Prolina";
                case "ACT":
                case "ACC":
                case "ACA":
                case "ACG":
                    return "T - Treonina";
                case "GCT":
                case "GCC":
                case "GCA":
                case "GCG":
                    return "A - Alanina";
                case "TAT":
                case "TAC":
                    return "Y - Tirosina";
                case "TAA":
                case "TAG":
                case "TGA":
                    return "STOP";
                case "CAT":
                case "CAC":
                    return "H - Istidina";
                case "CAA":
                case "CAG":
                    return "Q - Gluttamina";
                case "AAT":
                case "AAC":
                    return "N - Asparagina";
                case "AAA":
                case "AAG":
                    return "K - Lisina";
                case "GAT":
                case "GAC":
                    return "D - Acido Aspartico";
                case "GAA":
                case "GAG":
                    return "E - Acido Gluttamico";
                case "TGT":
                case "TGC":
                    return "C - Cisteina";
                case "TGG":
                    return "W - Triptofano";
                case "CGT":
                case "CGC":
                case "CGA":
                case "CGG":
                    return "R - Arginina";
                case "AGT":
                case "AGC":
                    return "S - Serina";
                case "AGA":
                case "AGG":
                    return "R - Arginina";
                case "GGT":
                case "GGC":
                case "GGA":
                case "GGG":
                    return "G - Glicina";
                default:
                    return "Errore";
            }
        }




    }
}
