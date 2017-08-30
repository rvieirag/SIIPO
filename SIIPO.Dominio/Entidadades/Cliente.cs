using System;
using System.Collections.Generic;

namespace SIIPO.Dominio.Entidadades
{
    public class Cliente
    {
        public int ClienteId { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Email { get; set; }
        public DateTime FechaRegistro { get; set; }
        public bool Activo { get; set; }
        public virtual IEnumerable<Contacto> Contactos { get; set; }
        public bool ClienteEspecial(Cliente cliente)
        {
            return cliente.Activo && DateTime.Now.Year - cliente.FechaRegistro.Year >= 5;
        }
        public IEnumerable<Empresa> Empresas { get; set; }
    }
}