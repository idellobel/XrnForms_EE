namespace CarService.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CarModels",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ModelNaam = c.String(nullable: false),
                        Bouwjaar = c.Int(nullable: false),
                        Prijs = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Brandstof = c.String(),
                        EersteEigenaar = c.Boolean(nullable: false),
                        MerkId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Merks", t => t.MerkId, cascadeDelete: true)
                .Index(t => t.MerkId);
            
            CreateTable(
                "dbo.Merks",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.CarModels", "MerkId", "dbo.Merks");
            DropIndex("dbo.CarModels", new[] { "MerkId" });
            DropTable("dbo.Merks");
            DropTable("dbo.CarModels");
        }
    }
}
