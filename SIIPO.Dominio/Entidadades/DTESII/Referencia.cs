using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIIPO.Dominio.Entidadades.DTESII
{
    public class Referencia
    {
        public int NroLinRef { get; set; } //base="xs:positiveInteger" maxInclusive value="40"
        public string CodRef { get; set; } //restriction base="xs:string" maxLength value="18"
        public string RazonRef { get; set; } //base="xs:string" maxLength value="90"
        public string CodVndor { get; set; } //base="xs:string" maxLength value="8"
        public string CodCaja { get; set; } //base="xs:string" maxLength value="8"
    }
}
