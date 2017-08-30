
using System.Collections.Generic;

namespace SIIPO.Dominio.Entidadades
{
    public class Empresa
    {
        public int EmpresaId { get; set; }
        public string Giro { get; set; }
        public string Rut { get; set; }
        public string RazonSocial { get; set; }
        public int Acteco { get; set; }
        public virtual IEnumerable<Sucursal> Sucursales { get; set; }
        public int ClienteId { get; set; }
        public virtual Cliente Cliente { get; set; }

    }
}
