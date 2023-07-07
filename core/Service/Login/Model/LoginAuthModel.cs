namespace core.Service
{
    public class LoginAuthModel
    {
        public int IndicatorCode { get; set; }
        public int UserCode { get; set; } 
        public string FullNameUser { get; set; } = string.Empty;
        public string NamePage { get; set; } = string.Empty;
        public int CodeProfile { get; set; }
        public string NameProfile { get; set; } = string.Empty;
        public string UserProfile { get; set; } = string.Empty;
        public string PasswordEmail { get; set; } = string.Empty;
        public string AddressEmail { get; set; } = string.Empty;
        public int IndicatorMailVerified { get; set; }
        public int IndicatorChangePassword { get; set; }
        public int IndicatorViewAgents { get; set; }
        public string CodeStateUser { get; set; } = string.Empty;
    }
}
