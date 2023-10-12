namespace core.Service
{
    public class CampanasModel
    {
        public int CodigoCampana { get; set; }
        public string? DescripcionCampana { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public DateTime FechaInicioDoble { get; set; }
        public DateTime FechaFinDoble { get; set; }

    }

    public class ResponseCampanaListModel
    {
        public string Message { get; set; }

        public List<CampanasModel> Content { get; set; }

        public double ElapsedMilliseconds { get; set; }

        public int? TotalRegistros { get; set; }
        public int? PaginaActual { get; set; }

    }
}
