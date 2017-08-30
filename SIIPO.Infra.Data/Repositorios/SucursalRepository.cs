using System;
using System.Linq;
using SIIPO.Dominio.Entidadades;
using SIIPO.Dominio.Interfaces.Repositorios;

namespace SIIPO.Infra.Data.Repositorios
{
    public class SucursalRepository : RepositoryBase<Sucursal>, ISucursalRepository
    {
        public System.Collections.Generic.IEnumerable<Sucursal> ObtenerSucursalesByIdEmpresa(int empresaId)
        {
            return Db.Sucursales.Where(p => p.EmpresaId == empresaId);
        }
        
    }
}