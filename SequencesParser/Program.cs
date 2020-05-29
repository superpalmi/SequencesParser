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
    public class Program
    {
        static void Main(string[] args)
        {
            /*
            var settings = new JsonSerializerSettings
            {
                NullValueHandling = NullValueHandling.Ignore,
                MissingMemberHandling = MissingMemberHandling.Ignore
            };*/
            string file1 = File.ReadAllText(@"C:\Users\Riccardo\Dropbox\bioinfo\SequencesParser\SequencesParser\china JSON.json");
            string file2 = File.ReadAllText(@"C:\Users\Riccardo\Dropbox\bioinfo\SequencesParser\SequencesParser\file.json");
    
                // String rawJSON = JsonConvert.DeserializeObject(file);
            SequencesList list = new SequencesList();
            
            list = JsonConvert.DeserializeObject<SequencesList>(file1);
           
            GenesList genesList= new GenesList();

            genesList = JsonConvert.DeserializeObject<GenesList>(file2);
           
            DifferenceOutput o = new DifferenceOutput();
            o.DifferenceLists = new List<DifferenceList>();
            /*
            var stringRanges = JObject.Parse(@"C:\Users\Riccardo\Dropbox\bioinfo\SequencesParser\SequencesParser\sequence.gb.json")["range"]["join"].Children();
            List<Range> ranges = stringRanges.Select(c => c.ToObject<int[]>())
                                             .Select(c => new Range(c[0], c[1])).ToList(); */

            // FeatureList features = new FeatureList();
            //features = JsonConvert.DeserializeObject<FeatureList>(File.ReadAllText(@"C:\Users\Riccardo\Dropbox\bioinfo\SequencesParser\SequencesParser\sequence.gb.json"));
            DifferenceList diffs = new DifferenceList();
            Console.WriteLine(list.Sequences.Count);
            for (int i = 1; i < list.Sequences.Count; i++)
            {
                string seq1 = list.Sequences.ElementAt(0).Seq;
                string seq2 = list.Sequences.ElementAt(i).Seq;


                diffs.Seq1 = list.Sequences.ElementAt(0);
                diffs.Seq2 = list.Sequences.ElementAt(i);
                diffs = DifferenceCalculator(diffs, seq1, seq2);
                o.DifferenceLists.Add(diffs);

            }
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
