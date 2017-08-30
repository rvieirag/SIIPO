using System;
using System.Collections.Generic;

namespace SIIPO.Dominio.Entidadades.DTESII
{
    public class AreaIdDoc
    {
                public int idDoc {get; set;}
                public long folio {get; set;}
                public DateTime fchEmis {get; set;}
                public TpoindServicio indServicio {get; set;}
                public double IndMntNeto { get; set; }
                public string periodoDesde {get; set;}
                public string periodoHasta {get; set;}
                public DateTime fchVenc { get; set; }
    }
}
