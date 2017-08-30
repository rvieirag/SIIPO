using System.Data.Entity.ModelConfiguration;
using SIIPO.Dominio.Entidadades;

namespace SIIPO.Infra.Data.EntityConfig
{
    public class ClienteConfiguration : EntityTypeConfiguration<Cliente>
    {
        public ClienteConfiguration()
        {
            HasKey(c => c.ClienteId);

            Property(c => c.Nombre)
                .IsRequired()
                .HasMaxLength(150);

            Property(c => c.Apellido)
                .IsRequired()
                .HasMaxLength(150);

            Property(c => c.Email)
                .IsRequired();

        }
    }
}