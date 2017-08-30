using System.Data.Entity.ModelConfiguration;
using SIIPO.Dominio.Entidadades;

namespace SIIPO.Infra.Data.EntityConfig
{
    public class EmpresaConfiguration : EntityTypeConfiguration<Empresa>
    {
        public EmpresaConfiguration()
        {
            HasKey(c => c.EmpresaId);

            Property(c => c.RazonSocial)
                .IsRequired()
                .HasMaxLength(250);

            Property(c => c.Giro)
                .IsRequired()
                .HasMaxLength(250);

            Property(c => c.Rut)
                .IsRequired()
                .HasMaxLength(20);

            HasRequired(p => p.Cliente)
                .WithMany()
                .HasForeignKey(p => p.ClienteId);

        }
    }
}