namespace core.Service
{
    public class VwCampanaModel
    {
        public int CodigoCampana { get; set; }
        public int CodigoSolicitud { get; set; }
        public int CodigoCertificado { get; set; }
        public string? NumeroPoliza { get; set; }
        public int CodigoTitular { get; set; }
        public string? NombreTitular { get; set; }
        public int NumeroAsegurados { get; set; }
        public string? DescripcionPais { get; set; }
        public int CodigoPoliza { get; set; }
        public string? DescripcionPoliza { get; set; }
        public string? DeduciblesTexto { get; set; }
        public DateTime FechaEfectividad { get; set; }
        public string? CodigoFormaPago { get; set; }
        public string? DescripcionFormaPago { get; set; }
        public DateTime FechaCobro { get; set; }
        public int NumeroCuota { get; set; }
        public decimal Prima { get; set; }
        public decimal CostoAdministrativo { get; set; }
        public decimal PrimaComisionable { get; set; }
        public decimal ValorCuota { get; set; }
        public Decimal ValorIntereses { get; set; }
        public string? Restricciones { get; set; }
        public string? DescripcionEstadoCertificado { get; set; }
        public string? DescripcionMotivoCancelacion { get; set; }
        public string? DescripcionTipoVenta { get; set; }
        public string? PagoAutomatico { get; set; }
        public int? Siniestralidad { get; set; }
        public string? PolizaGrupo { get; set; }
        public string? PolizaDependiente { get; set; }
        public int Notas { get; set; }
        public string? CodigoAgenteVenta { get; set; }
        public string? NombreAgenteVenta { get; set; }
        public string? NombreSubAgente { get; set; }
        public string? CodigoSubAgente { get; set; }
        public string? NombreAgente { get; set; }
        public string? CodigoAgente { get; set; }
        public string? NombreAgencia { get; set; }
        public string? CodigoAgencia { get; set; }
        public string? NombreMGA { get; set; }
        public string? CodigoMGA { get; set; }
        public string? CodigoEstadoCuota { get; set; }
        public string? CodigoEstadoCertificado { get; set; }
        public DateTime FechaPago { get; set; }
        public string? Celular { get; set; }
        public string? Correo { get; set; }
    }
}
