using System.Data.Entity.ModelConfiguration;
using SIIPO.Dominio.Entidadades;

namespace SIIPO.Infra.Data.EntityConfig
{
    public class SobreDteConfiguration : EntityTypeConfiguration<SobreDte>
    {
        public SobreDteConfiguration()
        {
            HasKey(p => p.SobreDteId);

            Property(p => p.Xml)
                .IsRequired();

            HasRequired(p => p.Pos)
                .WithMany()
                .HasForeignKey(p => p.PosId);

        }
    }
}