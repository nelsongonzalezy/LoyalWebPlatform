using core.Service;

namespace core.Service
{
    public class LoginAuthModel
    {
        public int CodigoUsuario { get; set; }
        public bool IndicadorValidacion { get; set; }
        public string NombreCompletoUsuario { get; set; }
        public string NombrePagina { get; set; }
        public int CodigoPerfil { get; set; }
        public string NombrePerfil { get; set; }
        public string UsuarioImagen { get; set; }
        public string PasswordCorreo { get; set; }
        public string DireccionEmail { get; set; }
        public string IndicadorCorreoVerificado { get; set; }
        public string IndicadorCambioPassword { get; set; }
        public string IndicadorVistaAgentes { get; set; }
        public int CodigoEstadoUsuario { get; set; }
    }
    public class ResponseRequestLoginAuthModel
    {
        public Content Content { get;set;}
        public double ElapsedMilliseconds { get; set; }

    }
    public class Content
    {
        public string Token { get; set; }
        public LoginAuthModel User { get; set; }
    }
}
