using System;
using System.Collections.Generic;
using SIIPO.Dominio.Entidadades;

namespace SIIPO.Dominio.Interfaces.Servicios
{
    public interface ISucursalService : IServiceBase<Sucursal>
    {
        IEnumerable<Sucursal> ObtenerSucursalesByIdEmpresa(int empresaId);
    }
}