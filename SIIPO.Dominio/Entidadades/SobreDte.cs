using System;

namespace SIIPO.Dominio.Entidadades
{
    public class SobreDte
    {
        public int SobreDteId { get; set; }
        public DateTime     FechaCreacion { get; set; }
        public string Xml { get; set; }
        public bool Disponible { get; set; }
        public int PosId { get; set; }
        public virtual Pos Pos { get; set; }
    }
}