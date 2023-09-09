namespace core.Service
{
    public class VwNotasModel
    {
        public int CodigoNota { get; set; }
        public int CodigoTipoNota { get; set; }
        public string? DescripcionTipoNota { get; set; }
        public int CodigoUsuario { get; set; }
        public string? NombreUsuario { get; set; }
        public DateTime FechaRegistroNota { get; set; }
        public int CodigoCotizacion { get; set; }
        public int CodigoSolicitud { get; set; }
        public int CodigoCertificado { get; set; }
        public string? Nota { get; set; }
    }
}
