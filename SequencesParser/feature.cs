using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SequencesParser
{
    public class Feature
    {


       
            public string id { get; set; }
            public string type { get; set; }
            public Range range { get; set; }
            public string note { get; set; }
            public string codon_start { get; set; }
            public string db_xref { get; set; }
            public string product { get; set; }
            public string protein_id { get; set; }
            public string gene { get; set; }
            public string translation { get; set; }
            public string locus_tag { get; set; }
            public string ribosomal_slippage { get; set; }
        }

    public class Range
        {
            public int[][] join { get; set;  }
            


        }

    
}
