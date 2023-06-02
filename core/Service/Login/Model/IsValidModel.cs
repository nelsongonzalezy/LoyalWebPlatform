using System.ComponentModel.DataAnnotations;

namespace core.Service
{
    public class IsValidModel
    {
        public string UserId { get; set; }
        [Required]
        public int Code1 { get; set; }
        [Required]
        public int Code2 { get; set; }
        [Required]
        public int Code3 { get; set; }
        [Required]
        public int Code4 { get; set; }
    }
}
