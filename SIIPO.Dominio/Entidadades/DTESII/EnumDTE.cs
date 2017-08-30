using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIIPO.Dominio.Entidadades.DTESII
{
   public enum TpoindServicio
    {
        Boleta_de_Servicios_Periodicos = 1,
        Boleta_de_Servicios_Periodicos_Domiciliarios = 2,
        Boleta_de_Ventas_y_Servicio = 3,
        Boleta_de_Espectaculo_emitida_por_cuenta_de_Terceros = 4
    }
   public enum TpoMov
   {
       Descuento = 'D',
       Recargo = 'R'
   }
    public enum TpoValor
    {
        Porcentaje = '%', //El valor se Expresa como Porcentaje
        Pesos = '$' //El Valor se Expresa en Pesos
    }
}
