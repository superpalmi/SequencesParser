using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SequencesParser
{
    public class DifferenceOutput
    {
        /// <summary>
        /// Oggetto per serializzare una lista di liste di differenze tra sequenze
        /// </summary>
        private List<DifferenceList> differenceLists;

        public List<DifferenceList> DifferenceLists { get => differenceLists; set => differenceLists = value; }
    }
}
