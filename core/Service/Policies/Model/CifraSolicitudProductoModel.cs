namespace core.Service
{
    public class CifraCertificadoProductoModel
    {
        public int CantidadRegistros { get; set; }
        public int CodigoProducto { get; set; }
        public string DescripcionProducto { get; set; }
        public string Color { get; set; }
        public string Img { get; set; }
    }
    public class ResponseRequestCifraSolicitudProductoModel
    {
        public string Message { get; set; }

        public List<CifraCertificadoProductoModel> Content { get; set; }

        public double ElapsedMilliseconds { get; set; }

        public int? TotalRegistros { get; set; }
        public int? PaginaActual { get; set; }
    }
}
