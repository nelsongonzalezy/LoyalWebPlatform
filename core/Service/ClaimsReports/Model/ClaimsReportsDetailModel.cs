using System.ComponentModel.DataAnnotations;

namespace core.Service
{
    public class ClaimsReportsDetailModel
    {
        public int ClaimsReportsId { get; set; }
        public string ClaimsReportFormat { get; set; }
        public DateTime ReportClaimDate { get; set; }
        public string PolicyCode { get; set;}
        public int ClaimId { get; set; }
        [DisplayFormat(DataFormatString = "{0:C}")]
        public decimal ClaimValue{ get; set;}
    }
}
