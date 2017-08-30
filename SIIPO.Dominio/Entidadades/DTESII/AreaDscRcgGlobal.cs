using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIIPO.Dominio.Entidadades.DTESII
{
    public class AreaDscRcgGlobal
    {
        public int NroLinDR { get; set; } //positiveInteger 1-99
        public TpoMov TpoMov { get; set; }
        public string GlosaDR { get; set; } //base="xs:string" maxLength value="45"
        public TpoValor TpoValor { get; set; }
        public decimal ValorDR { get; set; } ////decimal Monto con 16 Digitos de Cuerpo y 2 Decimales
        public int IndExeDR { get; set; } //Afecta a Productos Exentos o No Afectos:1 - Afecta aProductos No Facturables:2
    }
}
