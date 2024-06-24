namespace iCantina.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Utilizadors",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        NIF = c.Int(nullable: false),
                        Saldo = c.Decimal(precision: 18, scale: 2),
                        NumEstudante = c.Int(),
                        Email = c.String(),
                        Username = c.String(),
                        Discriminator = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Extras",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Descricao = c.String(),
                        Preco = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Ativo = c.Boolean(nullable: false),
                        Menu_Id = c.Int(),
                        Reserva_Id = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Menus", t => t.Menu_Id)
                .ForeignKey("dbo.Reservas", t => t.Reserva_Id)
                .Index(t => t.Menu_Id)
                .Index(t => t.Reserva_Id);
            
            CreateTable(
                "dbo.Menus",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DataHora = c.DateTime(nullable: false),
                        PrecoEstudante = c.Decimal(nullable: false, precision: 18, scale: 2),
                        PrecoProfessor = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Pratoes",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Descricao = c.String(),
                        Tipo = c.String(),
                        Ativo = c.Boolean(nullable: false),
                        Menu_Id = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Menus", t => t.Menu_Id)
                .Index(t => t.Menu_Id);
            
            CreateTable(
                "dbo.Faturas",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Total = c.Decimal(nullable: false, precision: 18, scale: 2),
                        DataHora = c.DateTime(nullable: false),
                        Reserva_Id = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Reservas", t => t.Reserva_Id)
                .Index(t => t.Reserva_Id);
            
            CreateTable(
                "dbo.ItemFaturas",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Descricao = c.String(),
                        Preco = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Fatura_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Faturas", t => t.Fatura_ID)
                .Index(t => t.Fatura_ID);
            
            CreateTable(
                "dbo.Reservas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TotalGasto = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Cliente_Id = c.Int(),
                        Multa_ID = c.Int(),
                        Prato_ID = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Utilizadors", t => t.Cliente_Id)
                .ForeignKey("dbo.Multas", t => t.Multa_ID)
                .ForeignKey("dbo.Pratoes", t => t.Prato_ID)
                .Index(t => t.Cliente_Id)
                .Index(t => t.Multa_ID)
                .Index(t => t.Prato_ID);
            
            CreateTable(
                "dbo.Multas",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Valor = c.Decimal(nullable: false, precision: 18, scale: 2),
                        NumHoras = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Faturas", "Reserva_Id", "dbo.Reservas");
            DropForeignKey("dbo.Reservas", "Prato_ID", "dbo.Pratoes");
            DropForeignKey("dbo.Reservas", "Multa_ID", "dbo.Multas");
            DropForeignKey("dbo.Extras", "Reserva_Id", "dbo.Reservas");
            DropForeignKey("dbo.Reservas", "Cliente_Id", "dbo.Utilizadors");
            DropForeignKey("dbo.ItemFaturas", "Fatura_ID", "dbo.Faturas");
            DropForeignKey("dbo.Pratoes", "Menu_Id", "dbo.Menus");
            DropForeignKey("dbo.Extras", "Menu_Id", "dbo.Menus");
            DropIndex("dbo.Reservas", new[] { "Prato_ID" });
            DropIndex("dbo.Reservas", new[] { "Multa_ID" });
            DropIndex("dbo.Reservas", new[] { "Cliente_Id" });
            DropIndex("dbo.ItemFaturas", new[] { "Fatura_ID" });
            DropIndex("dbo.Faturas", new[] { "Reserva_Id" });
            DropIndex("dbo.Pratoes", new[] { "Menu_Id" });
            DropIndex("dbo.Extras", new[] { "Reserva_Id" });
            DropIndex("dbo.Extras", new[] { "Menu_Id" });
            DropTable("dbo.Multas");
            DropTable("dbo.Reservas");
            DropTable("dbo.ItemFaturas");
            DropTable("dbo.Faturas");
            DropTable("dbo.Pratoes");
            DropTable("dbo.Menus");
            DropTable("dbo.Extras");
            DropTable("dbo.Utilizadors");
        }
    }
}
