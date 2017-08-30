using System;
using System.Collections.Generic;
using SIIPO.Dominio.Entidadades;

namespace SIIPO.Dominio.Interfaces.Repositorios
{
    public interface ISobreDteRepository : IRepositoryBase<SobreDte>
    {
            IEnumerable<SobreDte> ObtenerDtePorFecha(DateTime Fecha);   
    }
}