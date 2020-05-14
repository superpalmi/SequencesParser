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
            list = JsonConvert.DeserializeObject<SequencesList>(File.ReadAllText(@"E:\Dropbox\Dropbox\bioinfo\SequencesParser\SequencesParser\china JSON.json"));
           // StreamReader file = File.OpenText(@"E:\Dropbox\Dropbox\bioinfo\SequencesParser\SequencesParser\china JSON.json");
            
           //sonSerializer serializer = new JsonSerializer();
            //SequencesList list = (SequencesList)serializer.Deserialize(file, typeof(SequencesList));
            Console.WriteLine(list.Sequences.Count);

            string china = list.Sequences.ElementAt(0).Seq;
            string italy = list.Sequences.ElementAt(1).Seq;

            List<Difference> diffs = new List<Difference>();

            for(int i=0; i < italy.Length; i++)
            {
                if (italy.ElementAt(i) != china.ElementAt(i))
                {
                    Difference diff = new Difference();
                    diff.Newletter = italy.ElementAt(i);
                    diff.Oldletter = china.ElementAt(i);
                    diff.Position = i;
                    diffs.Add(diff);
                }

               

            }

            if (diffs.Count > 0)
            {
               for(int i=0; i<diffs.Count; i++)
                {
                    Console.WriteLine(diffs.ElementAt(i).Newletter + " al posto di " + diffs.ElementAt(i).Oldletter + " in posizione " + diffs.ElementAt(i).Position);
                }
            }

           // Console.Write(china);
          //  string stop = "stop";
           
           // Console.WriteLine(stop);


            

        }
    }
}
