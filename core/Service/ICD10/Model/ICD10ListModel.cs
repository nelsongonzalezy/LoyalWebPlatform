using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace core.Service
{
    public class ICD10ListModel
    {
        public int Icd10Id { get; set; }
        public string Icd10Code { get; set; }
        public string ShortDescription { get; set; }
        public string LongDescription { get; set; }
        public string Status { get; set; }
        public string Version { get; set; }
    }
}
