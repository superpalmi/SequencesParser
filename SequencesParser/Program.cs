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
        static void Main(string[] args)
        {
            //prendo i file json utili alla scansione delle sequenze allineate
            var path = Directory.GetCurrentDirectory();
            var path1 = Path.Combine(Directory.GetCurrentDirectory(), "gene-annotation.json");
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
            /*
              //dividere ogni cds in codoni
              List<Codon> codons = new List<Codon>();
              for (int i=0; i<reference.Seq.Length; i+=3)
              {

                  string seq = reference.Seq;
                  if ((i - 3) < seq.Length)
                  {
                      Codon codon = new Codon();
                      codon.Start = i;
                      codon.End = i + 2;
                      codon.Triplet = seq.ElementAt(i).ToString() + seq.ElementAt(i + 1).ToString() + seq.ElementAt(i + 2).ToString();
                      codons.Add(codon);
                  }



              }
          */





            //per ogni sequenza allineata calcola le differenze con la ref
            for (int i = 0; i < list.Seqs.Count; i++)
            {


                DifferenceList diffs = new DifferenceList();
                diffs.Seq1 = reference;
                diffs.Seq2 = list.Seqs.ElementAt(i);
               
                DifferenceCalculator(diffs);

               
                

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
            //scrive i geni corrispondenti se presente il file gene-annotation
            
            if (path1 != null)
            {
                for (int j = 0; j < o.DifferenceLists.Count; j++)
                {
                    for (int k = 0; k < o.DifferenceLists.ElementAt(j).Differences.Count; k++)
                    {
                        for (int w = 0; w < genesList.geneslist.Count(); w++)
                        {
                            if (genesList.geneslist.ElementAt(w).type == "CDS")
                            {
                                

                                int start = genesList.geneslist.ElementAt(w).start;
                                int end = genesList.geneslist.ElementAt(w).end;
                                int position = o.DifferenceLists.ElementAt(j).Differences.ElementAt(k).Position;
                                int relpos = position - start;

                                if ((position >= start) && (position <= end))
                                {


                                    o.DifferenceLists.ElementAt(j).Differences.ElementAt(k).Gene = genesList.geneslist.ElementAt(w).gene;
                                    o.DifferenceLists.ElementAt(j).Differences.ElementAt(k).Startcds = genesList.geneslist.ElementAt(w).start;
                                    o.DifferenceLists.ElementAt(j).Differences.ElementAt(k).Endcds = genesList.geneslist.ElementAt(w).end;
                                    

                                    int fine = (3 - ((end - start) % 3)); //posizione fine del gene
                                    if (fine == 3)
                                    fine = 0; //controllo geni divisibili per 3 (altrimenti non determinabile)
                                    String geneRef = o.DifferenceLists.ElementAt(j).Seq1.Seq.Substring(start , end - start + fine);
                                    o.DifferenceLists.ElementAt(j).Differences.ElementAt(k).Genseq = geneRef;
                                    String geneCurSeq = o.DifferenceLists.ElementAt(j).Seq2.Seq.Substring(start , end - start + fine);

                                    List<Codon> oldcodons = new List<Codon>();
                                    List<Codon> newcodons = new List<Codon>();
                                    for (int t = 0; t < end - start + fine; t += 3)
                                    {

                                        Codon old= new Codon();
                                        Codon nuovo = new Codon();
                                                 
                                        old.Triplet = geneRef[t].ToString() + geneRef[t + 1] + geneRef[t + 2];
                                        old.Aminoacid = getProtein(old.Triplet);
                                                
                                        //posizione relativa al gene
                                        old.Start = t+1;
                                                
                                        old.End = t + 3;
                                        oldcodons.Add(old);

                                                
                                        nuovo.Triplet = geneCurSeq[t].ToString() + geneCurSeq[t + 1] + geneCurSeq[t+ 2];
                                        nuovo.Aminoacid = getProtein(nuovo.Triplet);
                                                
                                        nuovo.Start = t+1;
                                                
                                        nuovo.End = t + +3;
                                        newcodons.Add(nuovo);

                                        //vengono recuperati gli amminoacidi per la posizione corrente (ogni 3 basi)


                                    }

                                    for (int r=0; r<oldcodons.Count; r++)
                                    {
                                        if(relpos>=oldcodons.ElementAt(r).Start && relpos <= oldcodons.ElementAt(r).End)
                                        {
                                            o.DifferenceLists.ElementAt(j).Differences.ElementAt(k).Oldcodon = oldcodons.ElementAt(r);
                                        }

                                    }
                                    for (int s=0; s<newcodons.Count; s++)
                                    {
                                        if (relpos>=newcodons.ElementAt(s).Start && relpos <= newcodons.ElementAt(s).End)
                                        {
                                            o.DifferenceLists.ElementAt(j).Differences.ElementAt(k).Newcodon = newcodons.ElementAt(s);
                                            if (o.DifferenceLists.ElementAt(j).Differences.ElementAt(k).Oldcodon.Aminoacid != o.DifferenceLists.ElementAt(j).Differences.ElementAt(k).Newcodon.Aminoacid)
                                            {
                                                Console.WriteLine(o.DifferenceLists.ElementAt(j).Differences.ElementAt(k).Newcodon.Aminoacid + " al posto di " + o.DifferenceLists.ElementAt(j).Differences.ElementAt(k).Oldcodon.Aminoacid + " nella sequenza " + o.DifferenceLists.ElementAt(j).Seq2.Name + " in posizione " + o.DifferenceLists.ElementAt(j).Differences.ElementAt(k).Position);
                                            }


                                        }
                                    }


                                   

                                }



                              
                               }

                            Console.WriteLine("writing genes part: " + j);

                        }

                     

                }
                    
                }
                

            }






            //stampa a video le differenze


            string diffJSON = JsonConvert.SerializeObject(o);
                    var path3 = Path.Combine(Directory.GetCurrentDirectory(), "differences.json");
                    System.IO.File.WriteAllText(path3, diffJSON);
            }
        


        

       
        //conta le differenze tra due sequenze
        public static void DifferenceCalculator(DifferenceList diffs)
        {
            diffs.Differences = new List<Difference>();


            //1
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





        public static string getProtein(string tripletta)
        {
            if (tripletta.Contains("N"))
            {
                return "ND - Codone Non Determinabile";
            }
            switch (tripletta)
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
