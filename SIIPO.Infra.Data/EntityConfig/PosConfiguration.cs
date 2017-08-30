using System.Data.Entity.ModelConfiguration;
using SIIPO.Dominio.Entidadades;

namespace SIIPO.Infra.Data.EntityConfig
{
    public class PosConfiguration : EntityTypeConfiguration<Pos>
    {
        public PosConfiguration()
        {
            HasKey(c => c.PosId);

            Property(c => c.Descripcion)
                .IsRequired()
                .HasMaxLength(250);



        }
    }
}