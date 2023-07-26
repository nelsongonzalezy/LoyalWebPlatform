namespace core.Service
{
    public class MenuModel
    {
        public int UserCode { get; set; }
        public int OptionCode { get; set; } 
        public string OptionTypeCode { get; set; } = string.Empty;
        public string NameOption { get; set; } = string.Empty;
        public int Order { get; set; }
        public string Url { get; set; } = string.Empty;
    }
}
//SELECT Usuario.CodigoUsuario, PerfilOpcionSistema.CodigoOpcion, Opcion.CodigoTipoOpcion, Opcion.NombreOpcion, Opcion.Orden
//            FROM Usuario
//            INNER JOIN UsuarioPerfil ON UsuarioPerfil.CodigoUsuario = Usuario.CodigoUsuario
//            INNER JOIN PerfilOpcionSistema ON PerfilOpcionSistema.CodigoPerfil = UsuarioPerfil.CodigoPerfil
//            INNER JOIN Opcion ON PerfilOpcionSistema.CodigoOpcion = Opcion.CodigoOpcion
//            WHERE Usuario.CodigoUsuario = 776 AND UsuarioPerfil.CodigoSistema = 2
//            GROUP BY Usuario.CodigoUsuario, Opcion.CodigoTipoOpcion, PerfilOpcionSistema.CodigoOpcion, Opcion.NombreOpcion, Opcion.Orden
//            ORDER BY Opcion.Orden 