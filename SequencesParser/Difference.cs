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

        private string newletter;
        private string oldletter;

        public int Position { get => position; set => position = value; }
        public string Newletter { get => newletter; set => newletter = value; }
        public string Oldletter { get => oldletter; set => oldletter = value; }
    }
}
