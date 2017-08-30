using System.Data.Entity.ModelConfiguration;
using SIIPO.Dominio.Entidadades;

namespace SIIPO.Infra.Data.EntityConfig
{
    public class SucursalConfiguration : EntityTypeConfiguration<Sucursal>
    {
        public SucursalConfiguration()
        {
            HasKey(p => p.SucursalId);

            Property(p => p.Nombre)
                .IsRequired()
                .HasMaxLength(150);

            Property(p => p.Direccion)
                .IsRequired();

            HasRequired(p => p.Empresa)
                .WithMany()
                .HasForeignKey(p => p.EmpresaId);
        }
        
    }
}