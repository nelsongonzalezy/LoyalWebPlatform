namespace core.Service
{
    public class CifrasPersonasCertificadoResponseModel
    {
        public int TotalPersonas { get; set; }
        public int AdultosHombres { get; set; }
        public int AdultosMujeres { get; set; }
        public int MenoresHombres { get; set; }
        public int MenoresMujeres { get; set; }
    }
    public class ResponseCifrasPersonasCertificadoResponseModel
    {
        public string Message { get; set; }

        public List<CifrasPersonasCertificadoResponseModel>? Content { get; set; }

        public double ElapsedMilliseconds { get; set; }

        public int? TotalRegistros { get; set; }
        public int? PaginaActual { get; set; }
    }
}
