namespace core.Service
{
    public class ListarProveedoresModel
    {
        public int CodigoProveedor { get; set; }
        public string? RazonSocialProveedor { get; set; }
        public int CodigoPais { get; set; }
        public string? DescripcionPais { get; set; }
        public string? Ciudad { get; set; }
        public string? Estado { get; set; }
        public string? Direccion { get; set; }
        public string? Telefono { get; set; }
        public string? CodigoEstadoProveedor { get; set; }
        public string? DescripcionEstadoProveedor { get; set; }
        public DateTime FechaEfectividad { get; set; }
    }
    public class ResponseListarProveedoresModel
    {


            public string Message { get; set; }

            public List<ListarProveedoresModel> Content { get; set; }

            public double ElapsedMilliseconds { get; set; }

            public int? TotalRegistros { get; set; }
            public int? PaginaActual { get; set; }
        
    }
}
