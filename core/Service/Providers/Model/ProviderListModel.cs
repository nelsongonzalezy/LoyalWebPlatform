namespace core.Service
{
    public class ProviderListModel
    {
        public int ProviderCode { get; set; }
        public string ProviderCompanyName { get; set; } = string.Empty;
        public int CountryCode { get; set; }
        public string City { get; set; } = string.Empty;
        public string State { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
        public string Telephone { get; set; } = string.Empty;
        public int ProviderStateCode { get; set; }
        public string CountryDescription { get; set; } = string.Empty;
        public string ProviderStateDescription { get; set; } = string.Empty;

    }
}
