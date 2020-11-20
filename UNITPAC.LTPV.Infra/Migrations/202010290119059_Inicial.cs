namespace UNITPAC.LTPV.Infra.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Inicial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Carros",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Modelo = c.String(nullable: false, maxLength: 50, unicode: false),
                        Marca = c.String(nullable: false, maxLength: 50, unicode: false),
                        Ano = c.Int(nullable: false),
                        km = c.Double(nullable: false),
                        Preco = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Carros");
        }
    }
}
