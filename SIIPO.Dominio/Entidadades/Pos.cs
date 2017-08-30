using System.Collections.Generic;

namespace SIIPO.Dominio.Entidadades
{
    public class Pos
    {
        public int PosId { get; set; }
        public string Descripcion { get; set; }
        public int CafDesde { get; set; }
        public int CafHasta { get; set; }
        public string Caf { get; set; }
        public int SucursalId { get; set; }
        public virtual Sucursal Sucursal { get; set; }
        public virtual IEnumerable<SobreDte> SobresDte { get; set; }
    }
}