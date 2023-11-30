namespace core.Service
{
    public class VwSolcitudConsultaModel
    {
        public int CodigoSolicitud { get; set; }
        public int CodigoCertificado { get; set; }
        public int CodigoCotizacion { get; set; }
        public DateTime FechaSolicitud { get; set; }
        public string CodigoEstadoSolicitud { get; set; }
        public string DescripcionEstadoSolicitud { get; set; }
        public int CodigoPais { get; set; }
        public string DescripcionPais { get; set; }
        public int CodigoPlan { get; set; }
        public string DescripcionPlan { get; set; }
        public int CodigoPoliza { get; set; }
        public string DescripcionPoliza { get; set; }
        public int CodigoProducto { get; set; }
        public string DescripcionProducto { get; set; }
        public string ColorPrincipal { get; set; }
        public string ColorPrincipalR { get; set; }
        public string ColorPrincipalG { get; set; }
        public string ColorPrincipalB { get; set; }
        public DateTime FechaInicioSolicitada { get; set; }
        public int CodigoFormaPago { get; set; }
        public string DescripcionFormaPago { get; set; }
        public int NumeroDependientes { get; set; }
        public int IndicadorTrasplante { get; set; }
        public int IndicadorMaternidad { get; set; }
        public DateTime FechaAprobacion { get; set; }
        public int CodigoAgente { get; set; }
        public string NumeroPoliza { get; set; }
        public string CodigoEstadoCertificado { get; set; }
        public string DescripcionEstadoCertificado { get; set; }
        public DateTime FechaInicioVigencia { get; set; }
        public DateTime FechaFinVigencia { get; set; }
        public decimal Prima { get; set; }
        public string PrimaTexto { get; set; }
        public decimal PrimaComisionable { get; set; }
        public decimal CostoAdministrativo { get; set; }
        public int NumeroAsegurados { get; set; }
        public string NombreCompleto { get; set; }
        public string NombreAgente { get; set; }
        public string DescripcionPlanesConsulta { get; set; }
        public int CodigoVinculo { get; set; }
        public string DescripcionVinculo { get; set; }
        public string CodigoEstadoCivil { get; set; }
        public string DescripcionEstadoCivil { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public int Edad { get; set; }
        public string CodigoSistemaMedida { get; set; }
        public string DescripcionSistemaMedida { get; set; }
        public int Peso { get; set; }
        public int Talla { get; set; }
        public int Imc { get; set; }
        public string Direccion { get; set; }
        public string CodigoPostal { get; set; }
        public string CodigoPaisDireccion { get; set; }
        public string DescripcionPaisDireccion { get; set; }
        public string Correo { get; set; }
        public string CodigoInternacionalCelular { get; set; }
        public string Celular { get; set; }
        public string CodigoInternacionalTelefono { get; set; }
        public string Telefono { get; set; }
        public string EvaluacionSolicitud { get; set; }
        public string CodigoRTU { get; set; }
        public string NombreCompletoConyuge { get; set; }
        public DateTime FechaNacimientoConyuge { get; set; }
        public int EdadConyuge { get; set; }
        public DateTime FechaInicioVigenciaOriginal { get; set; }
        public decimal PrimaOriginal { get; set; }
        public string CodigoTipoVenta { get; set; }
        public string DescripcionTipoVenta { get; set; }
        public int PeriodoEspera { get; set; }
        public string TextoCorreo { get; set; }
        public string DireccionPostal { get; set; }
        public int CodigoPostalPostal { get; set; }
        public int CodigoPaisDireccionPostal { get; set; }
        public string DescripcionPaisPostal { get; set; }
        public string PrimerPago { get; set; }
        public int CodigoPolizaAffinity { get; set; }
        public int CodigoTomador { get; set; }
        public int CodigoTitular { get; set; }
        public string Tomador { get; set; }
        public int CodigoPersonaSolicitudTomador { get; set; }
        public string CorreoTomador { get; set; }
        public string CelularTomador { get; set; }
        public string TelefonoTomador { get; set; }
        public DateTime FechaCancelacion { get; set; }
        public string CodigoMotivoCancelacion { get; set; }
        public string DireccionTomadorPrincipal { get; set; }
        public int CodigoPostalPostalTomadorPrincipal { get; set; }
        public int CodigoPaisDireccionTomadorPrincipal { get; set; }
        public string DescripcionPaisTomadorPrincipal { get; set; }
        public string DireccionTomadorPostal { get; set; }
        public int CodigoPostalPostalTomadorPostal { get; set; }
        public int CodigoPaisDireccionTomadorPostal { get; set; }
        public string DescripcionPaisTomadorPostal { get; set; }
        public string DireccionTomadorAlternativa { get; set; }

        public IEnumerable<WvCertificadoCoberturasCondicionadoModel> WvCertificadoCoberturasCondicionadoDbObject { get; set; }
        public IEnumerable<VwDocumentoSolicitudModel> VwDocumentoSolicitudDbObject { get; set; }
        public IEnumerable<VwAseguradosModel> VwAseguradosDbObject { get; set; }
        public IEnumerable<VwNotasModel> VwNotasDbObject { get; set; }
        public IEnumerable<VwCronogramaPagosModel> VwCronogramaPagosDbObject { get; set; }
    }

    public class ResponseVwSolcitudConsultaModel 
    {
        public string Message { get; set; }

        public VwSolcitudConsultaModel Content { get; set; }

        public double ElapsedMilliseconds { get; set; }

        public int? TotalRegistros { get; set; }
        public int? PaginaActual { get; set; }
    }
}
