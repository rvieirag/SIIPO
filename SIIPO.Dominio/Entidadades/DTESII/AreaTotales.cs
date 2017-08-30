using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIIPO.Dominio.Entidadades.DTESII
{
  public class AreaTotales
    {
        public int MntNeto { get; set; } // base="xs:nonNegativeInteger" totalDigits value="18"
        public int MntExe { get; set; } // base="xs:nonNegativeInteger" totalDigits value="18"
        public int IVA { get; set; } // base="xs:nonNegativeInteger" totalDigits value="18"
        public int MntTotal { get; set; } // base="xs:nonNegativeInteger" totalDigits value="18"
        public int MontoNF { get; set; } // base="xs:integer" totalDigits value="18" Positivo o Negativo
        public int TotalPeriodo { get; set; }  // base="xs:nonNegativeInteger" totalDigits value="18"
        public int SaldoAnterior { get; set; }  // base="xs:nonNegativeInteger" totalDigits value="18"
        public int VlrPagar { get; set; }  // base="xs:nonNegativeInteger" totalDigits value="18"
    }
}
