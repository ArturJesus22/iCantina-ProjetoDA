namespace iCantina.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class cantina : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.QuantidadeExtras",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Quantidade = c.Int(nullable: false),
                        Extra_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Extras", t => t.Extra_ID)
                .Index(t => t.Extra_ID);
            
            CreateTable(
                "dbo.QuantidadePratoes",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Quantidade = c.Int(nullable: false),
                        Prato_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Pratoes", t => t.Prato_ID)
                .Index(t => t.Prato_ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.QuantidadePratoes", "Prato_ID", "dbo.Pratoes");
            DropForeignKey("dbo.QuantidadeExtras", "Extra_ID", "dbo.Extras");
            DropIndex("dbo.QuantidadePratoes", new[] { "Prato_ID" });
            DropIndex("dbo.QuantidadeExtras", new[] { "Extra_ID" });
            DropTable("dbo.QuantidadePratoes");
            DropTable("dbo.QuantidadeExtras");
        }
    }
}
