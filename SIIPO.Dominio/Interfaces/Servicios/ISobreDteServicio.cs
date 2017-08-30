using System;
using System.Collections.Generic;
using SIIPO.Dominio.Entidadades;

namespace SIIPO.Dominio.Interfaces.Servicios
{
    public interface ISobreDteService : IServiceBase<SobreDte>
    {
        IEnumerable<SobreDte> ObtenerDtePorFecha(DateTime fecha);
    }
}