using System.Collections.Generic;
using System.Linq;
using SIIPO.Dominio.Entidadades;
using SIIPO.Dominio.Interfaces.Repositorios;
using SIIPO.Dominio.Interfaces.Servicios;

namespace SIIPO.Dominio.Servicios
{
    public class ClienteService : ServiceBase<Cliente>, IClienteService
    {
        private readonly IClienteRepository _clienteRepository;

        public ClienteService(IClienteRepository clienteRepository)
            : base(clienteRepository)
        {
            _clienteRepository = clienteRepository;
        }

        public IEnumerable<Cliente> ObtenerClientesEspeciales(IEnumerable<Cliente> clientes)
        {
            return clientes.Where(c => c.ClienteEspecial(c));
        }
    }
}