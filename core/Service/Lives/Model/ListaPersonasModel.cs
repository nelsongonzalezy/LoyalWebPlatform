namespace core.Service
{
    public class ListaPersonasModel
    {
        public int CodigoCertificado { get; set; }
        public int CodigoSolicitud { get; set; }
        public string? NumeroPoliza { get; set; }
        public string? DescripcionEstadoCertificado { get; set; }
        public string? CodigoEstadoCertificado { get; set; }
        public string? NombreCompleto { get; set; }
        public string? DescripcionTipoPersonaCotizacion { get; set; }
        public string? Sexo { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public int Edad { get; set; }
        public decimal Peso { get; set; }
        public decimal Talla { get; set; }
        public decimal Imc { get; set; }
        public int CodigoPoliza { get; set; }
        public string? DescripcionPoliza { get; set; }
        public string? DescripcionPlan { get; set; }
        public string? DescripcionPais { get; set; }
    }
}
