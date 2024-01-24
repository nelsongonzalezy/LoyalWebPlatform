using System.ComponentModel.DataAnnotations;

namespace core.Service
{
    public class RecodeAgentModel
    {
        [Required]
        public int CodigoUsuario { get; set; }
        public int CodigoAgente { get; set; }
        [Required]
        public int CodigoCertificado { get; set; }
        [Required]
        public string? Nota { get; set; }
    }
}
