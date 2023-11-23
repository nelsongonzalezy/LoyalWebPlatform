namespace core.Service
{
    public class DetallePolizasForeCastModel
    {
        public int CodigoCertificado { get; set; }
        public string NumeroPoliza { get; set; }
        public int CodigoSolicitud { get; set; }
        public int CodigoPlan { get; set; }
        public string DescripcionPlan { get; set; }
        public int CodigoEstadoCertificado { get; set; }
        public string CodigoTipoVenta { get; set; }
        public string DescripcionTipoVenta { get; set; }
        public DateTime FechaInicioVigencia { get; set; }
        public DateTime FechaFinVigencia { get; set; }
        public decimal Prima { get; set; }
        public decimal CostoAdministrativo { get; set; }
        public int NumeroAsegurados { get; set; }
        public int IndicadorMaternidad { get; set; }
        public int IndicadorTrasplante { get; set; }
        public int CodigoPais { get; set; }
        public string DescripcionPais { get; set; }
        public int NumeroDependientes { get; set; }
        public int CodigoFormaPago { get; set; }
        public string DescripcionFormaPago { get; set; }
        public DateTime FechaCancelacion { get; set; }
        public int CodigoAgenteActual { get; set; }
        public string DescripcionEstadoCertificado { get; set; }
        public int CodigoPoliza { get; set; }
        public string DescripcionPoliza { get; set; }
    }
}
