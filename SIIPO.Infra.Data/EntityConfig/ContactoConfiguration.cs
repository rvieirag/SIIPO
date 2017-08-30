using System.Data.Entity.ModelConfiguration;
using SIIPO.Dominio.Entidadades;

namespace SIIPO.Infra.Data.EntityConfig
{
    public class ContactoConfiguration : EntityTypeConfiguration<Contacto>
    {
        public ContactoConfiguration()
        {
            HasKey(p => p.ContactoId);

            Property(p => p.Email)
                .IsRequired()
                .HasMaxLength(150);

            HasRequired(p => p.CLiente)
                .WithMany()
                .HasForeignKey(p => p.ClienteId);
        }
    }
}