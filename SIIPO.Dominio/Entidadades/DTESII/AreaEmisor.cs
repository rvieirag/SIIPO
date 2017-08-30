using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIIPO.Dominio.Entidadades.DTESII
{
    public class AreaEmisor
    {
        public string RUTEmisor { get; set; } // base="xs:string <xs:maxLength value="10"/> <xs:minLength value="3"/> <xs:pattern value="[0-9]+-([0-9]|K)"/>
        public string RznSocEmisor { get; set; } //base="xs:string" <xs:maxLength value="100"/>
        public string GiroEmisor { get; set; } //base="xs:string" <xs:maxLength value="80"/>
        public int CdgSIISucur { get; set; } //restriction base="xs:positiveInteger" <xs:totalDigits value="9"/>
        public string DirOrigen { get; set; } // base="xs:string" maxLength value="70"
        public string CmnaOrigen { get; set; } //base="xs:string" maxLength value="20"
        public string CiudadOrigen { get; set; } //base="xs:string" maxLength value="20"
    }
}
