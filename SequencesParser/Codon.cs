using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SequencesParser
{
   public class Codon


    {
        private string triplet;
        private int start;
        private int end;

        public string Triplet { get => triplet; set => triplet = value; }
        public int Start { get => start; set => start = value; }
        public int End { get => end; set => end = value; }
    }
}
