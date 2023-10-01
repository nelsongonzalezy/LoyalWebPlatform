namespace core.Service
{
    public class VidasResponseModel
    {
        public IEnumerable<ListaPersonasModel> ListaPersonas { get; set; }
        public IEnumerable<CifrasPersonasModel> CifrasPersonas { get; set; }
        public IEnumerable<CifrasVidasPorRangoModel> CifrasPorRangos { get; set; }

    }
    public class ResponseVidasResponseModel
    {
            public ResponseVidasResponseModel() { }
            public string Message { get; set; }
            public VidasResponseModel Content { get; set; }
            public double ElapsedMilliseconds { get; set; }
            public int? TotalRegistros { get; set; }
            public int? PaginaActual { get; set; }
      
    }
}
