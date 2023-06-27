using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace core.Service
{
    public class ClaimCreateModel
    {
        public int ClaimId { get; set; }
        public string ClaimNumber { get; set; }
        public string ClaimType { get; set; }
        public string UserID { get; set; }
        public string UserName { get; set; }
        public string UserType { get; set; }
        public string ClaimStatus { get; set; }
        [DisplayFormat(DataFormatString = "{0:C}")]
        public decimal ClaimValue { get; set;}
        [MaxLength(250)]
        public string ClaimDescription { get; set; }
        public DateTime ClaimDate { get; set; } = DateTime.Now;
        public string PolicyNumber { get; set; }
        public string PolicyType { get; set; }
        public string CertificatStatus { get; set; }
        public string MemberName { get; set; }
        public string Dx { get; set; }
        public string Icd10 { get; set; }
        public string ServicesProcedure { get; set; }
        public string CPTCode { get; set; }
        public string Provider { get; set; }
        public string ProviderID { get; set; }

    }
}
