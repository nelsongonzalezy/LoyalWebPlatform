namespace core.Service
{
    public class ProducComponentModel
    {
        public int CantidadRegistros { get; set; } 
        public int CodigoProducto { get; set; }
        public string DescripcionProducto { get; set; } = string.Empty; 
        public string Img { get; set; } = string.Empty; 
        public string Color { get; set; } = string.Empty; 
    }
    public class ResponseProduct
    {
        public ResponseProduct() { }


        public string Message { get; set; }

        public List<ProducComponentModel> Content { get; set; }

        public double ElapsedMilliseconds { get; set; }

        public int? TotalRegistros { get; set; }
        public int? PaginaActual { get; set; }
    }
}
