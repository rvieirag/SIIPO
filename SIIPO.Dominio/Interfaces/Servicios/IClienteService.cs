using System.Collections.Generic;
using SIIPO.Dominio.Entidadades;

namespace SIIPO.Dominio.Interfaces.Servicios
{
    public interface IClienteService : IServiceBase<Cliente>
    {
        IEnumerable<Cliente> ObtenerClientesEspeciales(IEnumerable<Cliente> clientes);
    }
}