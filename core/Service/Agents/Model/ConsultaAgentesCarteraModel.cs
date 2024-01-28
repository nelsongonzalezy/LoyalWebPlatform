namespace core.Service
{
    public class ConsultaAgentesCarteraModel
    {
        public IEnumerable<AgentsDetailModel> Agente { get; set; }
        public IEnumerable<AgenteCarteraModel> AgenteCartera { get; set; }
        public IEnumerable<AgenteCarteraPorEstadoModel> AgenteCarteraPorEstado { get; set; }
        public IEnumerable<AgenteCarteraPorProductoModel> AgenteCarteraPorProducto { get; set; }
        public IEnumerable<ListaEstructuraCarteraModel> ListaEstructuraCartera { get; set; }
    }
    public class ResponseConsultaAgentesCarteraModel
    {
        public string Message { get; set; }

        public ConsultaAgentesCarteraModel Content { get; set; }

        public double ElapsedMilliseconds { get; set; }

        public int? TotalRegistros { get; set; }
        public int? PaginaActual { get; set; }
    }
}
