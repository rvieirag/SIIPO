using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIIPO.Dominio.Entidadades.DTESII
{
   public class AreaDetalle
    {
        public int NroLinDet { get; set; } //type="xs:positiveInteger" Numero Secuencial de Linea
        public virtual CdgItem CdgItem { get; set; }
        public int IndExe { get; set; } //value="1" Servicio es Exento o No Afecto value="2"
        public int ItemEspectaculo { get; set; } // base="xs:positiveInteger"
        public string RUTMandante { get; set; } //<xs:pattern value="[0-9]+-([0-9]|K)"/>
        public string NmbItem { get; set; } // base="xs:string" maxLength value="80"
       // public InfoTicket InfoTicket { get; set; } No lo vamos a ocupar 
        public string DscItem { get; set; } //base="xs:string" <xs:maxLength value="1000"/>
        public decimal QtyItem { get; set; } //Monto con 12 Digitos de Cuerpo y 6 Decimales <xs:minExclusive value="0"/> <xs:totalDigits value="18"/>
        public string UnmdItem { get; set; } // base="xs:string" <xs:maxLength value="4"/>
        public decimal PrcItem { get; set; } //Monto con 12 Digitos de Cuerpo y 6 Decimales <xs:minExclusive value="0"/> <xs:totalDigits value="18"/>
        public decimal DescuentoPct { get; set; } // decimal entre 0.00 y 100.00
        public int DescuentoMonto { get; set; } //base="xs:nonNegativeInteger" totalDigits value="18"
        public decimal RecargoPct { get; set; } // Decimal Min:0.00 Max:100.00
        public int RecargoMonto { get; set; } //nonNegativeInteger totalDigits value="18"
        public int MontoItem { get; set; } //nonNegativeInteger totalDigits value="18"
    }
}
