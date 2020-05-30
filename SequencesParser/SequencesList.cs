using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SequencesParser
{
    /// <summary>
    /// Oggetto per deserializzare la lista di sequenze
    /// </summary>
    public class SequencesList 
    {


        private List<Sequence> seqs;
        public AppSettings appSettings { get; set; }
        public IList<object> seqGroups { get; set; }
        public IList<object> alignAnnotation { get; set; }
        public string svid { get; set; }
        public IList<object> seqFeatures { get; set; }
    
        public List<Sequence> Seqs { get => seqs; set => seqs = value; }
        
    }
    
    public class AppSettings
    {
        public string globalColorScheme { get; set; }
        public string webStartUrl { get; set; }
        public string application { get; set; }
        public string showSeqFeatures { get; set; }
        public string version { get; set; }
    } 
}
