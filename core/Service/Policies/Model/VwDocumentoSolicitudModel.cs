namespace core.Service
{
    public class VwDocumentoSolicitudModel
    {
        public int CodigoSolicitud { get; set; }
        public int CodigoDocumento { get; set; }
        public string DescripcionClasificacionTipoDocumento { get; set; }
        public string Origen { get; set; }
        public int CodigoTipoDocumento { get; set; }
        public string DescripcionTipoDocumento { get; set; }
        public string NombreDocumento { get; set; }
        public DateTime FechaRegistro { get; set; }
    }
}
