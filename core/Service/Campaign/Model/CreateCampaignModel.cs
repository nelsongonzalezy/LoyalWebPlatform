using System.ComponentModel.DataAnnotations;

namespace core.Service
{
    public class CreateCampaignModel
    {
        [Required]
        public string DescripcionCampana { get; set; }
        [Required]
        public DateTime FechaInicio { get; set; }
        [Required]
        public DateTime FechaFin { get; set; }        
        public DateTime FechaInicioDoble { get; set; }
        public DateTime FechaFinDoble { get; set; }
        public bool Individual { get; set; }
        [Required]
        public decimal RangoInicial { get; set; }
        public decimal RangoFinal { get; set; }
        [Required]
        public bool FormasPagos { get; set; }
        public bool FormaAnual { get; set; }
        public bool FormaSemestral { get; set; }
        public bool FormaTrimestral { get; set; }
        public bool FormaMensual { get; set; }
        public bool Vidas { get; set; }
        public int EdadInicial { get; set; }
        public int EdadFinal { get; set; }
        public bool Productos { get; set; }
        public bool Beyond { get; set; }
        public Decimal BeyondMeta { get; set; } 
        public bool Privilege { get; set; }
        public Decimal PrivilegeMeta { get; set; }
        public bool Liberty { get; set; }
        public Decimal LibertyMeta { get; set; } 
        public bool Legacy { get; set; }
        public Decimal LegacyMeta { get; set; }

    }
}
