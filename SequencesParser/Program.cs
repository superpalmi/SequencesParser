using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
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
    /// Prende in input le sequenze allineate con la cina, la gene annotation e stampa in output un file di differenze
    /// </summary>
    public class Program
    {
        static void Main(string[] args)
        {
           
          
            string file2 = File.ReadAllText(@"C:\Users\Riccardo\Dropbox\bioinfo\SequencesParser\SequencesParser\gene-annotation.json");
            string file3= File.ReadAllText(@"C:\Users\Riccardo\Dropbox\bioinfo\SequencesParser\SequencesParser\alligned-sequences.json");
            SequencesList list = new SequencesList();
      
            list = JsonConvert.DeserializeObject<SequencesList>(file3);
           
            GenesList genesList= new GenesList();

            genesList = JsonConvert.DeserializeObject<GenesList>(file2);
           
            DifferenceOutput o = new DifferenceOutput();
            o.DifferenceLists = new List<DifferenceList>();
          
            DifferenceList diffs = new DifferenceList();
            Console.WriteLine(list.Seqs.Count);
            Sequence reference = new Sequence();
            //trova la sequenza reference
            for(int i=0; i<list.Seqs.Count; i++)
            {

                if (list.Seqs.ElementAt(i).Id == "224846225")
                {
                    reference = list.Seqs.ElementAt(i);
                }
                else if (list.Seqs.ElementAt(i).Name == "1916215434")
                {
                    reference = list.Seqs.ElementAt(i);
                }
                
            }
            //per ogni sequenza allineata calcola le differenze con la ref
            for (int i = 0; i < list.Seqs.Count; i++)
            {
                string seq1 = reference.Seq;
                string seq2 = list.Seqs.ElementAt(i).Seq;


                diffs.Seq1 = reference;
                diffs.Seq2 = list.Seqs.ElementAt(i);
                diffs = DifferenceCalculator(diffs, seq1, seq2);
                o.DifferenceLists.Add(diffs);
                Console.WriteLine("measuring differencese part: " + i);
            }
            //scrive i geni corrispondenti
            for (int j = 0; j < o.DifferenceLists.Count; j++)
            {
                for (int k = 0; k < o.DifferenceLists.ElementAt(j).Differences.Count; k++)
                {
                    for (int w = 0; w < genesList.geneslist.Count(); w++)
                    {
                        if (genesList.geneslist.ElementAt(w).gbkey == "Gene")
                        {
                            int start = genesList.geneslist.ElementAt(w).start;
                            int end = genesList.geneslist.ElementAt(w).end;
                            int position = o.DifferenceLists.ElementAt(j).Differences.ElementAt(k).Position;

                            if ((position >= start)&&(position <= end))
                            {
                                o.DifferenceLists.ElementAt(j).Differences.ElementAt(k).Protein = genesList.geneslist.ElementAt(w).gene;
                            }
                        }

                    }
                }
                Console.WriteLine("writing genes part" + j);

            }


            if (diffs.Differences.Count > 0)
            {
                for (int j = 0; j < diffs.Differences.Count; j++)
                {
                    Console.WriteLine("La sequenza " + diffs.Seq2.Name + " possiede le seguenti differenze: " + diffs.Differences.ElementAt(j).Newletter + " al posto di " + diffs.Differences.ElementAt(j).Oldletter + " in posizione " + diffs.Differences.ElementAt(j).Position + " rispetto alla sequenza " + diffs.Seq1.Name + " che è la sequenza di REF");
                }
            }


              string diffJSON = JsonConvert.SerializeObject(o);
             System.IO.File.WriteAllText(@"C:\Users\Riccardo\Dropbox\bioinfo\SequencesParser\SequencesParser\differences.json", diffJSON);
        


        }
        

       
        //conta le differenze tra due sequenze
        public static DifferenceList DifferenceCalculator(DifferenceList diffs, String seq1, String seq2)
        {
            diffs.Differences = new List<Difference>();

            for (int i = 0; i < seq2.Length; i++)
            {
                int j = 1;
                int k = i;

                if (seq2.ElementAt(i) != seq1.ElementAt(i))
                {
                    string conc = seq2.ElementAt(i).ToString();
                    string oldconc = seq1.ElementAt(i).ToString();
                    Difference d = new Difference();
                    if (seq2.ElementAt(i + j) != seq1.ElementAt(i + j) && (i + j < seq1.Length - 1))
                    {
                        while (seq2.ElementAt(i + j) != seq1.ElementAt(i + j) && (i + j < seq1.Length - 1))
                        {

                            conc = conc + "" + seq2.ElementAt(i + j).ToString();
                            oldconc = oldconc + "" + seq1.ElementAt(i + j).ToString();
                            d.Newletter = conc;
                            d.Oldletter = oldconc;
                            d.Position = i;
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
                        diff.Newletter = seq2.ElementAt(i).ToString();
                        diff.Oldletter = seq1.ElementAt(i).ToString();
                        diff.Position = i;
                        diffs.Differences.Add(diff);
                    }




                    if (i < seq2.Length - 1)
                    {
                        i = i + j;
                    }


                }




            }


            return diffs;
        }

       

        
    }
}
