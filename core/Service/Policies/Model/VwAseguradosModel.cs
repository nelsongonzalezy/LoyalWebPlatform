namespace core.Service
{
    public class VwAseguradosModel
    {
        public int CodigoCertificado { get; set; }
        public int CodigoSolicitud { get; set; }
        public int CodigoPersonaSolicitud { get; set; }
        public int CodigoPersona { get; set; }
        public string Nombre { get; set; }
        public string ApellidoPaterno { get; set; }
        public string ApellidoMaterno { get; set; }
        public string NombreCompleto { get; set; }
        public string DescripcionTipoPersonaCotizacion { get; set; }
        public int CodigoSistemaMedida { get; set; }
        public int Talla { get; set; }
        public int Peso { get; set; }
        public int Imc { get; set; }
        public string DescripcionVinculo { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public int Edad { get; set; }
        public string DescripcionEstadoCivil { get; set; }
        public string Sexo { get; set; }
        public string CodigoTipoPersonaCertificado { get; set; }
        public int IndicadorRestricciones { get; set; }
        public int CodigoTipoPeriodoTiempo { get; set; }
        public int PeriodoEspera { get; set; }
        public string DescripcionPeriodoTiempo { get; set; }
        public DateTime FechaInicioVigencia { get; set; }
        public DateTime FechaFinVigencia { get; set; }
        public string CodigoCorreo { get; set; }
        public string Correo { get; set; }
        public int CodigoCelular { get; set; }
        public string Celular { get; set; }
        public string CodigoTelefono { get; set; }
        public string Telefono { get; set; }
        public int CodigoDireccionPrincipal { get; set; }
        public string DireccionPrincipal { get; set; }
        public string CodigoPostalPrincipal { get; set; }
        public int CodigoPaisPrincipal { get; set; }
        public string DescripcionPaisPrincipal { get; set; }
        public string CodigoDireccionPostal { get; set; }
        public string DireccionPostal { get; set; }
        public int CodigoPostalPostal { get; set; }
        public int CodigoPaisPostal { get; set; }
        public string DescripcionPaisPostal { get; set; }
        public string CodigoDireccionAlternativa { get; set; }
    }
}
