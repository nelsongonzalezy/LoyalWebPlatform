namespace core.Service
{
    public class PoliciesDetailModel
    {
        public int CertificateCode { get; set; }
        public string PolicyNumber { get; set; }
        public string RequestCode { get; set; }
        public string PlanCode { get; set; }
        public string CertificateStateCode { get; set; }
        public string CódigoTipoVenta { get; set; }
        public string EffectiveStartDate { get; set; }
        public string EffectiveEndDate { get; set; }
        public string major { get; set; }
        public string CommissionablePremium { get; set; }
        public string PremiumChangeIndicator { get; set; }
        public string ExtraPremiumValue { get; set; }
        public string PrimaOriginal { get; set; }
        public string AdministrativeCost { get; set; }
        public string NumberInsured { get; set; }
        public string MaternityFlag { get; set; }
        public string TransplantIndicator { get; set; }
        public string CountryCode { get; set; }
        public string NumberDependents { get; set; }
        public string CodeFormaPago { get; set; }
        public string CodeCertificateRenewed { get; set; }
        public string CancellationReasonCode { get; set; }
        public string ExplanationCancellation { get; set; }
        public string CancellationDate { get; set; }
        public string UserCancellation { get; set; }
        public string CurrentPolicyIndicator { get; set; }
        public string EmailText { get; set; }
        public string PendingEmailText { get; set; }
        public string AffinityPolicyCode { get; set; }
        public DateTime RegistrationDate { get; set; }
        public string LogUser { get; set; }
        
    }
}
