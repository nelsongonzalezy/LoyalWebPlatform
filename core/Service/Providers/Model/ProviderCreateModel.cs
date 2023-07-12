using System.ComponentModel.DataAnnotations;

namespace core.Service
{
    public class ProviderCreateModel
    {
        public int VendorCode { get; set; }
        public int VendorBranchCode { get; set; }
        public int ProviderBranchContactCode { get; set; }
        [Required]
        public string VendorPartnerReason { get; set; } = string.Empty;
        public string City { get; set; } = string.Empty;
        public string States { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public string Title { get; set; } = string.Empty;
        public string Phone { get; set; } = string.Empty;
        public string Mail { get; set; } = string.Empty;
        public DateTime EffectiveDate { get; set; }
        public IQueryable<CountryListModel> Countries { get; set; }
    }
}
