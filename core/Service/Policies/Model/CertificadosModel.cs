namespace core.Service
{
    public class CertificadosModel
    {
        public int CodigoSolicitud { get; set; }
        public string? NumeroPoliza { get; set; }
        public string? DescripcionTipoVenta { get; set; }
        public string? NombreCompleto { get; set; }
        public int NumeroAsegurados { get; set; }
        public string? DescripcionPoliza { get; set; }
        public string? DescripcionPais { get; set; }
        public string? CodigoEstadoCertificado { get; set; }
        public string? DescripcionEstadoCertificado { get; set; }
        public DateTime FechaInicioVigencia { get; set; }
        public string? DescripcionFormaPago { get; set; }
        public decimal Prima { get; set; }
        public decimal PrimaComisionable { get; set; }
        public string? DescripcionPlan { get; set; }
        public string? CodigoPlan { get; set; }
        public string CodigoMotivoCancelacion { get; set; }
        public string DescripcionMotivoCancelacion { get; set; }
        public int NumeroCuota { get; set; }
        public string? DescripcionEstadoCuota { get; set; }
        public int CodigoMaster { get; set; }
        public int CodigoAgencia { get; set; }
        public int odigoAgente { get; set; }
        public string? NombreAgencia { get; set; }
        public string? NombreAgente { get; set; }

    }
    public class ResponseRequestCertificadosModel
    {
    public string Message { get; set; }

    public List<CertificadosModel> Content { get; set; }

    public double ElapsedMilliseconds { get; set; }

    public int? TotalRegistros { get; set; }
    public int? PaginaActual { get; set; }
    }
}
