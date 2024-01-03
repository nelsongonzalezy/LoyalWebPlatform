using System.ComponentModel.DataAnnotations;

namespace core.Service
{
    public class CreaReclamoModel
    {
        public int CodigoReclamo { get; set; }
        public string? NumeroPoliza { get; set; }
        [Required]
        public DateTime FechaReclamo { get; set; }
        public string? CodigoEstadoReclamo { get; set; }
        public string? CodigoTipoReclamo { get; set; }
        public string? CodigoOrigen { get; set; }
        public string? DescripcionReclamo { get; set; }
        public bool AplicaDeducible { get; set; }
        public Decimal ValorDeducible { get; set; }
        public bool NotificaTitular { get; set; }
        public bool NotificaAgente { get; set; }
        public bool NotificaProveedor { get; set; }
        public int UsuarioAsignado { get; set; }
        public int UsuarioRegistro { get; set; }
    }
}
