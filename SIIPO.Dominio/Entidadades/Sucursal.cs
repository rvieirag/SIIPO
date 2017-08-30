using System.Collections.Generic;

namespace SIIPO.Dominio.Entidadades
{
    public class Sucursal
    {
        public int SucursalId { get; set; }
        public string Direccion { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public int EmpresaId { get; set; }
        public bool Estado { get; set; }
        public virtual Empresa Empresa { get; set; }
        public virtual IEnumerable<Pos> Poses { get; set; }
    }
}