﻿using Newtonsoft.Json;
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
    /// Prende in input le sequenze allineate con la cina, la gene annotation e stampa in output un file di differenze comprendenti i geni
    /// </summary>
    public class Program
    {
        static void Main(string[] args)
        {
            var path = Directory.GetCurrentDirectory();
            var path1 = Path.Combine(Directory.GetCurrentDirectory(), "gene-annotation.json");
            var path2= Path.Combine(Directory.GetCurrentDirectory(), "alligned-sequences.json");
           
            string file2 = File.ReadAllText(path1);
            GenesList genesList = new GenesList();

            genesList = JsonConvert.DeserializeObject<GenesList>(file2);
           
            string file3= File.ReadAllText(path2);
            //deserializzo file di sequenze allineate
            SequencesList list = new SequencesList();
      
            list = JsonConvert.DeserializeObject<SequencesList>(file3);
            //deserializzo file dei geni
           
           //creo l'oggetto delle variazioni da stampare in output
            DifferenceOutput o = new DifferenceOutput();
            o.DifferenceLists = new List<DifferenceList>();
          
           
            Console.WriteLine("numero sequenze presenti: " + list.Seqs.Count);
            Sequence reference = new Sequence();
            //trova la sequenza reference
            for(int i=0; i<list.Seqs.Count; i++)
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
                
                DifferenceCalculator(diffs);
                o.DifferenceLists.Add(diffs);
                Console.WriteLine("measuring differences of sequence: " + i);
                if (diffs.Differences.Count > 0)
                {
                    Console.WriteLine("La sequenza " + diffs.Seq2.Name + " possiede: " + diffs.Differences.Count + " variazioni rispetto alla ref");
                    for (int j = 0; j < diffs.Differences.Count; j++)
                    {
                        Console.WriteLine( diffs.Differences.ElementAt(j).Newletter + " al posto di " + diffs.Differences.ElementAt(j).Oldletter + " in posizione " + diffs.Differences.ElementAt(j).Position + " rispetto alla sequenza " + diffs.Seq1.Name + " che è la sequenza di REF");
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
                            if (genesList.geneslist.ElementAt(w).gbkey == "Gene")
                            {
                                int start = genesList.geneslist.ElementAt(w).start;
                                int end = genesList.geneslist.ElementAt(w).end;
                                int position = o.DifferenceLists.ElementAt(j).Differences.ElementAt(k).Position;

                                if ((position >= start) && (position <= end))
                                {
                                    o.DifferenceLists.ElementAt(j).Differences.ElementAt(k).Protein = genesList.geneslist.ElementAt(w).gene;
                                }
                            }

                        }
                    }
                    Console.WriteLine("writing genes part: " + j);

                }
            }

            //stampa a video le differenze
           

              string diffJSON = JsonConvert.SerializeObject(o);
              var path3= Path.Combine(Directory.GetCurrentDirectory(), "differences.json");
              System.IO.File.WriteAllText(path3, diffJSON);
        


        }
        

       
        //conta le differenze tra due sequenze
        public static void DifferenceCalculator(DifferenceList diffs)
        {
            diffs.Differences = new List<Difference>();

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
                        diff.Newletter = diffs.Seq2.Seq.ElementAt(i).ToString();
                        diff.Oldletter = diffs.Seq1.Seq.ElementAt(i).ToString();
                        diff.Position = i;
                        diffs.Differences.Add(diff);
                    }




                    if (i < diffs.Seq2.Seq.Length - 1)
                    {
                        i = i + j;
                    }


                }




            }


            
        }

       

        
    }
}
