namespace core.Service
{
    public class AgentsDetailModel
    {
        public int CodigoAgente { get; set; }
        public int? CodigoPersona { get; set; }
        public string Nombre { get; set; }
        public string ApellidoPaterno { get; set; }
        public string ApellidoMaterno { get; set; }
        public string NombreCompleto { get; set; }
        public string NombreAgente { get; set; }
        public string Sexo { get; set; }
        public string FechaNacimiento { get; set; }
        public int? Edad { get; set; }
        public int? CodigoAgenteDependencia { get; set; }
        public string NombreAgenteDependencia { get; set; }
        public string CodigoTipoAgente { get; set; }
        public string DescripcionTipoAgente { get; set; }
        public string CodigoNivel { get; set; }
        public int? CodigoPais { get; set; }
        public string DescripcionPais { get; set; }
        public decimal? Estatura { get; set; }
        public decimal? Peso { get; set; }
        public string CodigoCorreo { get; set; }
        public string Correo { get; set; }
        public int? CodigoCelular { get; set; }
        public string CodigoInternacionalCelular { get; set; }
        public string Celular { get; set; }
        public int? CodigoTelefono { get; set; }
        public string CodigoInternacionalTelefono { get; set; }
        public string Telefono { get; set; }
        public int? CodigoTelefonoCasa { get; set; }
        public string CodigoInternacionalTelefonoCasa { get; set; }
        public string TelefonoCasa { get; set; }
        public int? CodigoDireccionPersona { get; set; }
        public string Direccion { get; set; }
        public string Ciudad { get; set; }
        public string Provincia { get; set; }
        public string CodigoPostal { get; set; }
        public int? CodigoDireccionOficina { get; set; }
        public string DireccionOficina { get; set; }
        public string CiudadOficina { get; set; }
        public string ProvinciaOficina { get; set; }
        public string CodigoPostalOficina { get; set; }
        public int? CodigoPaisOficina { get; set; }
        public string DescripcionPaisOficina { get; set; }
        public int? CodigoDireccionPostal { get; set; }
        public string DireccionPostal { get; set; }
        public string CiudadPostal { get; set; }
        public string ProvinciaPostal { get; set; }
        public string CodigoPostalPostal { get; set; }
        public int? CodigoPaisPostal { get; set; }
        public string DescripcionPaisPostal { get; set; }
        public int? CodigoUsuario { get; set; }
        public int? CodigoAgenciaMaster { get; set; }
        public string AgenciaMaster { get; set; }
        public string Talla { get; set; }
        public int? CodigoBanco { get; set; }
        public string DescripcionBanco { get; set; }
        public string NombreTitularCuenta { get; set; }
        public string NumeroCuentaDeposito { get; set; }
        public string CodigoRouting { get; set; }
        public string DirecciónCuenta { get; set; }
        public string TipoCuentaDeposito { get; set; }
        public string TextoBusqueda { get; set; }
        public DateTime? FechaInicioContrato { get; set; }
        public decimal? Persistencia { get; set; }
        public int? ProduccionAnual { get; set; }
        public int? Total { get; set; }
        public int? Renovado { get; set; }
        public string TextoCorreoAsuntoAgente { get; set; }
        public string CodigoEstadoCivil { get; set; }
        public string DescripcionEstadoCivil { get; set; }
        public string CodigoEstadoAgente { get; set; }
        public string DescripcionEstadoAgente { get; set; }
        public string CodigoTexto { get; set; }
        public string AgenteTexto { get; set; }
        public string NombreCobranza { get; set; }
        public string IndicadorCuentaNueva { get; set; }
        public string IndicadorCuentaModificada { get; set; }
        public string HobbiesAgente { get; set; }
        public string Logo { get; set; }
        public string Foto { get; set; }
    }

    public class ResponseAgentsDetailModel
    {
        public string Message { get; set; }

        public List<AgentsDetailModel> Content { get; set; }

        public double ElapsedMilliseconds { get; set; }

        public int? TotalRegistros { get; set; }
        public int? PaginaActual { get; set; }
    }
}
