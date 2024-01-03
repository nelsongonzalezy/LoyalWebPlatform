namespace core.Service
{
    public class CampanaRequestModel
    {
        public int CodigoCampana { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public bool FormaAnual { get; set; }
        public bool FormaSemestral { get; set; }
        public bool FormaTrimestral { get; set; }
        public bool FormaMensual { get; set; }
    }
}
