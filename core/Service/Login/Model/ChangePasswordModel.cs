using System.ComponentModel.DataAnnotations;

namespace core.Service
{
    public class ChangePasswordModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        public string UserId { get; set; }
        [Required]
        public string PassWordOne { get; set; } = string.Empty;
        [Required]
        [Compare(nameof(PassWordOne), ErrorMessage = "PassWordOne debe ser igual a PassWordTwo")]
        public string PassWordTwo { get; set; } = string.Empty;
    }
}
