namespace core.Service
{
    public class RequestMonitorStatusModel
    {
        public int CodigoEstadoSolicitud { get; set; }
        public string DescripcionEstadoSolicitud  { get; set; } = string.Empty;
        public int NumeroSolicitudes { get; set; }
        public decimal PorcentajeSolicitudes { get; set; }

    }
}
