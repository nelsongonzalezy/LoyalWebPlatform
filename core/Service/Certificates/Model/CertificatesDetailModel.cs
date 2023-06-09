namespace core.Service
{
    public class CertificatesDetailModel
    {
       public int CertificateCode { get; set; }
        public string TypeOfDocument { get; set; }
        public string Name { get; set;}
        public string Descripction { get; set;}
        public string ShippingHIstorial { get; set;}
        public DateTime RegistrationDate { get; set;}
        public DateTime ExpirationDate { get; set;}
        public string LogUser { get; set;}
    }
}
