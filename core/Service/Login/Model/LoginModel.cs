using System.ComponentModel.DataAnnotations;

namespace core.Service
{
    public class LoginModel
    {
		[Required]
		public string UserName { get; set; }
      
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
