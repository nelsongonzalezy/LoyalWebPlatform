using System.ComponentModel.DataAnnotations;

namespace core.Service
{
    public class ActivationModel
    {
        [Required]
        public int CodigoCertificado { get; set; }
        [Required]
        public int CodigoUsuario { get; set; }
    }
}
