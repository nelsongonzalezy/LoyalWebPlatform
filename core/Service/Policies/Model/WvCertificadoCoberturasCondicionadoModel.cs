namespace core.Service
{
    public class WvCertificadoCoberturasCondicionadoModel
    {
        public int CodigoCoberturaCondicionado { get; set; }
        public int CodigoSeccionCoberturaCondicionado { get; set; }
        public string? DescripcionSeccionCoberturaCondicionado { get; set; }
        public string? DescripcionCoberturaCondicionado { get; set; }
        public DateTime FechaInicioCobertura { get; set; }
    }
}
