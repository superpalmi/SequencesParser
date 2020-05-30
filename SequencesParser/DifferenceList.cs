using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace SequencesParser
{   /// <summary>
    /// Oggetto per serializzare una lista di differenze tra due sequenze
    /// </summary>
    public class DifferenceList
    {
        private Sequence seq1;
        private Sequence seq2;
        private List<Difference> differences;
        public Sequence Seq1 { get => seq1; set => seq1 = value; }
        public Sequence Seq2 { get => seq2; set => seq2 = value; }

        public List<Difference> Differences { get => differences; set => differences = value; }
        
        //public List<Difference> Differences1 { get => differences; set => differences = value; }



    }
}
