namespace core.Service
{
    public class ListaAgentesModel
    {
        public int CodigoAgente { get; set; }
        public string? NombreAgente { get; set; }
        public string? CodigoEstadoAgente { get; set; }
        public string? DescripcionEstadoAgente { get; set; }
        public string? CodigoTipoAgente { get; set; }
        public string? DescripcionTipoAgente { get; set; }
    }
    public class ResponseListaAgentesModel
    {
        public string Message { get; set; }

        public List<ListaAgentesModel> Content { get; set; }

        public double ElapsedMilliseconds { get; set; }

        public int? TotalRegistros { get; set; }
        public int? PaginaActual { get; set; }
    }
}
