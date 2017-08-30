using System;
using System.Collections.Generic;
using SIIPO.Dominio.Entidadades;

namespace SIIPO.Dominio.Interfaces.Repositorios
{
    public interface ISucursalRepository : IRepositoryBase<Sucursal>
    {
        IEnumerable<Sucursal> ObtenerSucursalesByIdEmpresa(int empresaId);
    }
}