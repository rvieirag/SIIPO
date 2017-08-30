namespace SIIPO.Dominio.Entidadades
{
    public class Contacto
    {
        public int ContactoId { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }
        public int Tipo { get; set; }
        public virtual Cliente CLiente { get; set; }
        public int ClienteId { get; set; }
    }
}