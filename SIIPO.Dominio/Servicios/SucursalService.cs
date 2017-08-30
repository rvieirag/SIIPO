using System;
using System.Collections.Generic;
using SIIPO.Dominio.Entidadades;
using SIIPO.Dominio.Interfaces.Repositorios;
using SIIPO.Dominio.Interfaces.Servicios;

namespace SIIPO.Dominio.Servicios
{
    public class SucursalService : ServiceBase<Sucursal>, ISucursalService
    {
        private readonly ISucursalRepository _sucursalRepository;

        public SucursalService(ISucursalRepository sucursalRepository)
            : base(sucursalRepository)
        {
            _sucursalRepository = sucursalRepository;
        }

        public IEnumerable<Sucursal> ObtenerSucursalesByIdEmpresa(int empresaId)
        {
            return _sucursalRepository.ObtenerSucursalesByIdEmpresa(empresaId);
        }
    }
}