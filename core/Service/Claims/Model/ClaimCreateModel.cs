using System.ComponentModel.DataAnnotations;

namespace core.Service
{
    public class ClaimCreateModel
    {
        public int ClaimId { get; set; }
        public string ClaimNumber { get; set; }
        public string ClaimType { get; set; }

        public string ClaimStatus { get; set; }
        public string ClaimValue { get; set;}
        [MaxLength(250)]
        public string ClaimDescription { get; set; }
        public DateTime ClaimDate { get; set; } = DateTime.Now;

    }
}
