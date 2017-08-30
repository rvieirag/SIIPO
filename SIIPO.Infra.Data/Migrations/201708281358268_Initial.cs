namespace SIIPO.Infra.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Cliente",
                c => new
                    {
                        ClienteId = c.Int(nullable: false, identity: true),
                        Nombre = c.String(nullable: false, maxLength: 150, unicode: false),
                        Apellido = c.String(nullable: false, maxLength: 150, unicode: false),
                        Email = c.String(nullable: false, maxLength: 100, unicode: false),
                        FechaRegistro = c.DateTime(nullable: false),
                        Activo = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ClienteId);
            
            CreateTable(
                "dbo.Contacto",
                c => new
                    {
                        ContactoId = c.Int(nullable: false, identity: true),
                        Telefono = c.String(maxLength: 100, unicode: false),
                        Email = c.String(nullable: false, maxLength: 150, unicode: false),
                        Tipo = c.Int(nullable: false),
                        ClienteId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ContactoId)
                .ForeignKey("dbo.Cliente", t => t.ClienteId)
                .Index(t => t.ClienteId);
            
            CreateTable(
                "dbo.Empresa",
                c => new
                    {
                        EmpresaId = c.Int(nullable: false, identity: true),
                        Giro = c.String(nullable: false, maxLength: 250, unicode: false),
                        Rut = c.String(nullable: false, maxLength: 20, unicode: false),
                        RazonSocial = c.String(nullable: false, maxLength: 250, unicode: false),
                        Acteco = c.Int(nullable: false),
                        ClienteId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.EmpresaId)
                .ForeignKey("dbo.Cliente", t => t.ClienteId)
                .Index(t => t.ClienteId);
            
            CreateTable(
                "dbo.Pos",
                c => new
                    {
                        PosId = c.Int(nullable: false, identity: true),
                        Descripcion = c.String(nullable: false, maxLength: 250, unicode: false),
                        CafDesde = c.Int(nullable: false),
                        CafHasta = c.Int(nullable: false),
                        Caf = c.String(maxLength: 100, unicode: false),
                        SucursalId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.PosId)
                .ForeignKey("dbo.Sucursal", t => t.SucursalId)
                .Index(t => t.SucursalId);
            
            CreateTable(
                "dbo.Sucursal",
                c => new
                    {
                        SucursalId = c.Int(nullable: false, identity: true),
                        Direccion = c.String(nullable: false, maxLength: 100, unicode: false),
                        Nombre = c.String(nullable: false, maxLength: 150, unicode: false),
                        Descripcion = c.String(maxLength: 100, unicode: false),
                        EmpresaId = c.Int(nullable: false),
                        Estado = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.SucursalId)
                .ForeignKey("dbo.Empresa", t => t.EmpresaId)
                .Index(t => t.EmpresaId);
            
            CreateTable(
                "dbo.SobreDte",
                c => new
                    {
                        SobreDteId = c.Int(nullable: false, identity: true),
                        FechaCreacion = c.DateTime(nullable: false),
                        Xml = c.String(nullable: false, maxLength: 100, unicode: false),
                        Disponible = c.Boolean(nullable: false),
                        PosId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.SobreDteId)
                .ForeignKey("dbo.Pos", t => t.PosId)
                .Index(t => t.PosId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.SobreDte", "PosId", "dbo.Pos");
            DropForeignKey("dbo.Pos", "SucursalId", "dbo.Sucursal");
            DropForeignKey("dbo.Sucursal", "EmpresaId", "dbo.Empresa");
            DropForeignKey("dbo.Empresa", "ClienteId", "dbo.Cliente");
            DropForeignKey("dbo.Contacto", "ClienteId", "dbo.Cliente");
            DropIndex("dbo.SobreDte", new[] { "PosId" });
            DropIndex("dbo.Sucursal", new[] { "EmpresaId" });
            DropIndex("dbo.Pos", new[] { "SucursalId" });
            DropIndex("dbo.Empresa", new[] { "ClienteId" });
            DropIndex("dbo.Contacto", new[] { "ClienteId" });
            DropTable("dbo.SobreDte");
            DropTable("dbo.Sucursal");
            DropTable("dbo.Pos");
            DropTable("dbo.Empresa");
            DropTable("dbo.Contacto");
            DropTable("dbo.Cliente");
        }
    }
}
