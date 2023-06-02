using System.ComponentModel.DataAnnotations;

namespace core.Service
{
    public class RecoverModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}
