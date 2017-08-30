using System;
using System.Collections.Generic;

namespace SIIPO.Dominio.Entidadades.DTESII
{
    public class AreaSubTotInfo
    {
        public int NroSTI { get; set; } //base="xs:positiveInteger" <xs:maxInclusive value="99"
        public string GlosaSTI { get; set; } // base="xs:string" maxLength value="80"
        public int OrdenSTI { get; set; } //base="xs:positiveInteger" <xs:maxInclusive value="99"
        public decimal SubTotNetoSTI { get; set; } //decimal Monto con 16 Digitos de Cuerpo y 2 Decimales
        public decimal SubTotIVASTI { get; set; } //decimal Monto con 16 Digitos de Cuerpo y 2 Decimales
        public decimal SubTotAdicSTI { get; set; } //decimal Monto con 16 Digitos de Cuerpo y 2 Decimales
        public decimal SubTotExeSTI { get; set; } //decimal Monto con 16 Digitos de Cuerpo y 2 Decimales
        public decimal ValSubtotSTI { get; set; } //decimal Monto con 16 Digitos de Cuerpo y 2 Decimales
        public int LineasDeta { get; set; } //base="xs:positiveInteger" <xs:maxInclusive value="60"
    }
}
