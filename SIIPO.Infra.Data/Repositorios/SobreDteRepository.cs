using System;
using System.Linq;
using SIIPO.Dominio.Entidadades;
using SIIPO.Dominio.Interfaces.Repositorios;

namespace SIIPO.Infra.Data.Repositorios
{
    public class SobreDteRepository : RepositoryBase<SobreDte>, ISobreDteRepository
    {

        public System.Collections.Generic.IEnumerable<SobreDte> ObtenerDtePorFecha(DateTime Fecha)
        {
            return Db.SobresDtes.Where(p => p.FechaCreacion == Fecha);
        }


    }
}