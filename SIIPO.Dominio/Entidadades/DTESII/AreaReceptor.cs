using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIIPO.Dominio.Entidadades.DTESII
{
   public class AreaReceptor
    {
        public string RUTRecep { get; set; } // base="xs:string <xs:maxLength value="10"/> <xs:minLength value="3"/> <xs:pattern value="[0-9]+-([0-9]|K)"/>
        public string CdgIntRecep { get; set; } //base="xs:string" maxLength value="20"
        public string RznSocRecep { get; set; } //base="xs:string" maxLength value="100"
        public string Contacto { get; set; } //base="xs:string" maxLength value="80"
        public string DirRecep { get; set; } //base="xs:string" maxLength value="70"
        public string CmnaRecep { get; set; } //base="xs:string" maxLength value="20"
        public string CiudadRecep { get; set; } //base="xs:string" maxLength value="20"
        public string DirPostal { get; set; } //base="xs:string" maxLength value="70"
        public string CmnaPostal { get; set; } //base="xs:string" maxLength value="20"
        public string CiudadPostal { get; set; } //base="xs:string" maxLength value="20"

    }
}
