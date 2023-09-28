namespace core.Service
{
    public class CifrasPersonasCertificadoResponseModel
    {
        public int TotalPersonas { get; set; }
        public int AdultosHombres { get; set; }
        public int AdultosMujeres { get; set; }
        public int MenoresHombres { get; set; }
        public int MenoresMujeres { get; set; }

        public double PorcentajeHombresTotales
        {
            get
            {
                if (TotalPersonas != 0)
                {
                    return ((double)AdultosHombres+ (double)MenoresHombres) / TotalPersonas * 1;
                }
                else
                {
                    return 0;
                }
            }
        }        
        public double PorcentajeMujeresTotales
        {
            get
            {
                if (TotalPersonas != 0)
                {
                    return ((double)AdultosMujeres+ (double)MenoresMujeres) / TotalPersonas * 1;
                }
                else
                {
                    return 0;
                }
            }
        }               
        public double PorcentajeHombres
        {
            get
            {
                if (TotalPersonas != 0)
                {
                    return ((double)AdultosHombres / TotalPersonas )* 1;
                }
                else
                {
                    return 0;
                }
            }
        }        
        public double PorcentajeMujeres
        {
            get
            {
                if (TotalPersonas != 0)
                {
                    return ((double)AdultosMujeres / TotalPersonas )* 1;
                }
                else
                {
                    return 0;
                }
            }
        }       
        public double PorcentajeMenoresHombres
        {
            get
            {
                if (TotalPersonas != 0)
                {
                    return (double)MenoresHombres / TotalPersonas * 1;
                }
                else
                {
                    return 0;
                }
            }
        }       
        public double PorcentajeMenoresMuejres
        {
            get
            {
                if (TotalPersonas != 0)
                {
                    return (double)MenoresMujeres / TotalPersonas * 1;
                }
                else
                {
                    return 0;
                }
            }
        }
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
