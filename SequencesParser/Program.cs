using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SequencesParser
{
    class Program
    {
        static void Main(string[] args)
        {

            // String rawJSON = JsonConvert.DeserializeObject(file);
            SequencesList list = new SequencesList();
            list = JsonConvert.DeserializeObject<SequencesList>(File.ReadAllText(@"C:\Users\Riccardo\Dropbox\bioinfo\SequencesParser\SequencesParser\china JSON.json"));
           // StreamReader file = File.OpenText(@"E:\Dropbox\Dropbox\bioinfo\SequencesParser\SequencesParser\china JSON.json");
            
           //sonSerializer serializer = new JsonSerializer();
            //SequencesList list = (SequencesList)serializer.Deserialize(file, typeof(SequencesList));
            Console.WriteLine(list.Sequences.Count);

            string china = list.Sequences.ElementAt(0).Seq;
            string italy = list.Sequences.ElementAt(1).Seq;

            DifferenceList diffs = new DifferenceList();
            diffs.Differences = new List<Difference>();

            for(int i=0; i < italy.Length; i++ )
            {
                int j = 1;
                int k = i;
                
                if (italy.ElementAt(i) != china.ElementAt(i))
                {
                    string conc = italy.ElementAt(i).ToString();
                    string oldconc = china.ElementAt(i).ToString();
                    Difference d = new Difference();
                    if (italy.ElementAt(i + j) != china.ElementAt(i + j) && (i + j < china.Length - 1))
                    {
                        while (italy.ElementAt(i + j) != china.ElementAt(i + j) && (i + j < china.Length - 1))
                        {

                            conc = conc + "" + italy.ElementAt(i + j).ToString();
                            oldconc = oldconc + "" + china.ElementAt(i + j).ToString();
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
                        diff.Newletter = italy.ElementAt(i).ToString();
                        diff.Oldletter = china.ElementAt(i).ToString();
                        diff.Position = i;
                        diffs.Differences.Add(diff);
                    }

                   


                    if (i < italy.Length-1)
                    {
                        i = i + j;
                    }
                   
                    
                }
                

               

            }
           // string diffJSON = JsonConvert.SerializeObject(diffs);
            JsonSerializer serializer = new JsonSerializer();
            StreamWriter sw = new StreamWriter(@"C:\Users\Riccardo\Dropbox\bioinfo\SequencesParser\SequencesParser\differences.json");
            JsonWriter writer = new JsonTextWriter(sw);
            serializer.Serialize(writer, diffs);
            if (diffs.Differences.Count > 0)
            {
               for(int i=0; i< diffs.Differences.Count; i++)
                {
                    Console.WriteLine(diffs.Differences.ElementAt(i).Newletter + " al posto di " + diffs.Differences.ElementAt(i).Oldletter + " in posizione " + diffs.Differences.ElementAt(i).Position);
                }
            }

           // Console.Write(china);
          //  string stop = "stop";
           
           // Console.WriteLine(stop);


            

        }
    }
}
