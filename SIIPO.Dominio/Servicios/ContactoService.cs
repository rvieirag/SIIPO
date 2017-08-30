using SIIPO.Dominio.Entidadades;
using SIIPO.Dominio.Interfaces.Repositorios;
using SIIPO.Dominio.Interfaces.Servicios;

namespace SIIPO.Dominio.Servicios
{
    public class ContactoService : ServiceBase<Contacto>, IContactoService
    {
        private readonly IContactoRepository _contactoRepository;

        public ContactoService(IContactoRepository contactoRepository)
            : base(contactoRepository)
        {
            _contactoRepository = contactoRepository;
        }

    }
}