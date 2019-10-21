namespace VinylShopWebProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddFormatToModelAndRelatedWithVinyl : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Formats",
                c => new
                    {
                        Id = c.Byte(nullable: false),
                        Description = c.String(maxLength: 30),
                        Abbreviation = c.String(maxLength: 15),
                        Comments = c.String(maxLength: 255),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.FormatVinyls",
                c => new
                    {
                        VinylId = c.Int(nullable: false),
                        FormatId = c.Byte(nullable: false),
                    })
                .PrimaryKey(t => new { t.VinylId, t.FormatId })
                .ForeignKey("dbo.Products", t => t.VinylId, cascadeDelete: true)
                .ForeignKey("dbo.Formats", t => t.FormatId, cascadeDelete: true)
                .Index(t => t.VinylId)
                .Index(t => t.FormatId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.FormatVinyls", "FormatId", "dbo.Formats");
            DropForeignKey("dbo.FormatVinyls", "VinylId", "dbo.Products");
            DropIndex("dbo.FormatVinyls", new[] { "FormatId" });
            DropIndex("dbo.FormatVinyls", new[] { "VinylId" });
            DropTable("dbo.FormatVinyls");
            DropTable("dbo.Formats");
        }
    }
}
