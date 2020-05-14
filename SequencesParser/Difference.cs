using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SequencesParser
{
    public class Difference
    {
        private int position;

        private char newletter;
        private char oldletter;

        public int Position { get => position; set => position = value; }
        public char Newletter { get => newletter; set => newletter = value; }
        public char Oldletter { get => oldletter; set => oldletter = value; }
    }
}
