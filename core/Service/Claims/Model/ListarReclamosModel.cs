namespace core.Service
{
    public class ListarReclamosModel
    {
        public int CodigoReclamo { get; set; }
        public string? NumeroPoliza { get; set; }
        public DateTime FechaReclamo { get; set; }
        public string? CodigoEstadoReclamo { get; set; }
        public string? DescripcionEstadoReclamo { get; set; }
        public string? CodigoTipoReclamo { get; set; }
        public string? DescripcionTipoReclamo { get; set; }
        public string? CodigoOrigen { get; set; }
        public string? DescripcionOrigen { get; set; }
        public string? DescripcionReclamo { get; set; }
        public bool AplicaDeducible { get; set; }
        public Decimal ValorDeducible { get; set; }
        public bool NotificaTitular { get; set; }
        public bool NotificaAgente { get; set; }
        public bool NotificaProveedor { get; set; }
        public int CodigoAgente { get; set; }
        public int UsuarioAsignado { get; set; }
        public int UsuarioRegistro { get; set; }
        public DateTime FechaRegistro { get; set; }
    }
    public class ResposeListarReclamosModel
    {
        public string Message { get; set; }

        public List<ListarReclamosModel> Content { get; set; }

        public double ElapsedMilliseconds { get; set; }

        public int? TotalRegistros { get; set; }
        public int? PaginaActual { get; set; }
    }

}
