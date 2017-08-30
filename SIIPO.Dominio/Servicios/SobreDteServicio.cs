using System;
using System.Collections.Generic;
using SIIPO.Dominio.Entidadades;
using SIIPO.Dominio.Interfaces.Repositorios;
using SIIPO.Dominio.Interfaces.Servicios;

namespace SIIPO.Dominio.Servicios
{
    public class SobreDteoServicio : ServiceBase<SobreDte>, ISobreDteService
    {
        private readonly ISobreDteRepository _dteElectronicoRepository;

        public SobreDteoServicio(ISobreDteRepository dteElectronicoRepository)
            : base(dteElectronicoRepository)
        {
            _dteElectronicoRepository = dteElectronicoRepository;
        }

        public IEnumerable<SobreDte> ObtenerDtePorFecha(DateTime Fecha)
        {
            return _dteElectronicoRepository.ObtenerDtePorFecha(Fecha);
        }
    }
}