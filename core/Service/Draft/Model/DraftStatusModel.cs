namespace core.Service
{
    public class DraftStatusModel
    {
        public int CantidadRegistros { get; set; }
        public string codigoEstadoSolicitud { get; set; } = string.Empty;
        public string DescripcionEstadoSolicitud { get; set; } = string.Empty;
        public string Icon { get; set; } = string.Empty;
    }
}
