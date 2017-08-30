using SIIPO.Dominio.Entidadades;
using SIIPO.Dominio.Interfaces.Repositorios;
using SIIPO.Dominio.Interfaces.Servicios;

namespace SIIPO.Dominio.Servicios
{
    public class PosService : ServiceBase<Pos>, IPosService
    {
        private readonly IPosRepository _posRepository;

        public PosService(IPosRepository posRepository)
            : base(posRepository)
        {
            _posRepository = posRepository;
        }
    }
}