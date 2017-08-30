using System;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using SIIPO.Dominio.Entidadades;
using SIIPO.Infra.Data.EntityConfig;

namespace SIIPO.Infra.Data.Contexto
{
    public class SiipoContexto : DbContext
    {
        public SiipoContexto()
            :base("SiiPoWeb")
        {
       
        }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<SobreDte> SobresDtes { get; set; }
        public DbSet<Contacto> Contactos { get; set; }
        public DbSet<Empresa> Empresas { get; set; }
        public DbSet<Pos> Poss { get; set; }
        public DbSet<Sucursal> Sucursales { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>(); 
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

            modelBuilder.Properties()
                .Where(p => p.Name == p.ReflectedType.Name + "Id")
                .Configure(p => p.IsKey());

            modelBuilder.Properties<string>()
                .Configure(p => p.HasColumnType("varchar"));

            modelBuilder.Properties<string>()
                .Configure(p => p.HasMaxLength(100));

            modelBuilder.Configurations.Add(new ClienteConfiguration());
            modelBuilder.Configurations.Add(new SobreDteConfiguration());
            modelBuilder.Configurations.Add(new ContactoConfiguration());
            modelBuilder.Configurations.Add(new EmpresaConfiguration());
            modelBuilder.Configurations.Add(new PosConfiguration());
            modelBuilder.Configurations.Add(new SucursalConfiguration());
        }

        public override int SaveChanges()
        {
            foreach (var entry in ChangeTracker.Entries().Where(entry => entry.Entity.GetType().GetProperty("FechaRegistro") != null))
            {
                if (entry.State == EntityState.Added)
                {
                    entry.Property("FechaRegistro").CurrentValue = DateTime.Now;
                }
                if (entry.State == EntityState.Modified)
                {
                    entry.Property("FechaRegistro").IsModified = false;
                }
            }
            return base.SaveChanges();
        }

    }
}