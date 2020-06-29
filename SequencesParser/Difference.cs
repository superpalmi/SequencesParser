using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SequencesParser
{   /// <summary>
    /// Oggetto per serializzare una singola differenza
    /// </summary>
    public class Difference
    {
        private int position;

        private string newletter;
        private string oldletter;
        private string gene;
        private int startcds;
        private int endcds;

        public int Position { get => position; set => position = value; }
        public string Newletter { get => newletter; set => newletter = value; }
        public string Oldletter { get => oldletter; set => oldletter = value; }
        public string Gene { get => gene; set => gene = value; }
        public int Startcds { get => startcds; set => startcds = value; }
        public int Endcds { get => endcds; set => endcds = value; }
    }
}
