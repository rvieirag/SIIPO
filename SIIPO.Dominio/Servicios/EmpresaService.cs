using SIIPO.Dominio.Entidadades;
using SIIPO.Dominio.Interfaces.Repositorios;
using SIIPO.Dominio.Interfaces.Servicios;

namespace SIIPO.Dominio.Servicios
{
    public class EmpresaService : ServiceBase<Empresa>, IEmpresaService
    {
        private readonly IEmpresaRepository _empresaRepository;

        public EmpresaService(IEmpresaRepository empresaRepository)
            : base(empresaRepository)
        {
            _empresaRepository = empresaRepository;
        }
    }
}