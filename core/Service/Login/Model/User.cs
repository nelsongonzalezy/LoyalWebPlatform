namespace core.Service.Login.Model
{
	public class User
	{
		public int CodigoUsuario { get; set; } //
		public bool IndicadorValidacion { get; set; }
		public string NombreCompletoUsuario { get; set; } //
		public string NombrePagina { get; set; } //
		public int CodigoPerfil { get; set; } //
		public string NombrePerfil { get; set; } //
		public string DireccionEmail { get; set; } //
		public string IndicadorCorreoVerificado { get; set; } //
		public string IndicadorCambioPassword { get; set; } //
		public string IndicadorVistaAgentes { get; set; } //
		public int CodigoEstadoUsuario { get; set; } //
	}

}
