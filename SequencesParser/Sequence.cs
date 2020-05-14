using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SequencesParser
{
    public class Sequence
    {
        string name;
        int start;
        int end;
        int id;
        string seq;
        int order;

        public string Name { get => name; set => name = value; }
        public int Start { get => start; set => start = value; }
        public int End { get => end; set => end = value; }
        public int Id { get => id; set => id = value; }
        public string Seq { get => seq; set => seq = value; }
        public int Order { get => order; set => order = value; }

       
    
    }
}
