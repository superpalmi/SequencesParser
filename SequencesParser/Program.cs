using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace SequencesParser
{
    public class Program
    {
        static void Main(string[] args)
        {

            // String rawJSON = JsonConvert.DeserializeObject(file);
            SequencesList list = new SequencesList();
            list = JsonConvert.DeserializeObject<SequencesList>(File.ReadAllText(@"C:\Users\Riccardo\Dropbox\bioinfo\SequencesParser\SequencesParser\china JSON.json"));
            // StreamReader file = File.OpenText(@"E:\Dropbox\Dropbox\bioinfo\SequencesParser\SequencesParser\seq1 JSON.json");

            //sonSerializer serializer = new JsonSerializer();


            //SequencesList list = (SequencesList)serializer.Deserialize(file, typeof(SequencesList));
            DifferenceOutput o = new DifferenceOutput();
            o.DifferenceLists = new List<DifferenceList>();
           
            Console.WriteLine(list.Sequences.Count);
            for (int i=1; i < list.Sequences.Count; i++)
            {
                string seq1 = list.Sequences.ElementAt(0).Seq;
                string seq2 = list.Sequences.ElementAt(i).Seq;

                DifferenceList diffs = new DifferenceList();
                diffs.Seq1 = list.Sequences.ElementAt(0);
                diffs.Seq2 = list.Sequences.ElementAt(i);
                diffs = DifferenceCalculator(diffs, seq1, seq2);
                o.DifferenceLists.Add(diffs);
               
                if (diffs.Differences.Count > 0)
                {
                    for (int j = 0; j < diffs.Differences.Count; j++)
                    {
                        Console.WriteLine("La sequenza " + diffs.Seq2.Name+ " possiede le seguenti differenze: " + diffs.Differences.ElementAt(i).Newletter + " al posto di " + diffs.Differences.ElementAt(i).Oldletter + " in posizione " + diffs.Differences.ElementAt(i).Position+ " rispetto alla sequenza "+ diffs.Seq1.Name + " che è la sequenza di REF");
                    }
                }
            }

            string diffJSON = JsonConvert.SerializeObject(o);
            System.IO.File.WriteAllText(@"C:\Users\Riccardo\Dropbox\bioinfo\SequencesParser\SequencesParser\differences.json", diffJSON);

            // JsonSerializer serializer = new JsonSerializer();
            //  StreamWriter sw = new StreamWriter(@"C:\Users\Riccardo\Dropbox\bioinfo\SequencesParser\SequencesParser\differences.json");
            //JsonWriter writer = new JsonTextWriter(sw);
            //serializer.Serialize(writer, diffs);


            // Console.Write(seq1);
            //  string stop = "stop";

            // Console.WriteLine(stop);




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
