namespace VinylShopWebProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddContentFileToModelAndRelateWithProduct : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ContentFiles",
                c => new
                    {
                        Id = c.Short(nullable: false, identity: true),
                        FileName = c.String(nullable: false, maxLength: 255),
                        ContentType = c.String(nullable: false, maxLength: 100),
                        Content = c.Binary(),
                        FileType = c.Int(nullable: false),
                        ProductId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Products", t => t.ProductId, cascadeDelete: true)
                .Index(t => t.ProductId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ContentFiles", "ProductId", "dbo.Products");
            DropIndex("dbo.ContentFiles", new[] { "ProductId" });
            DropTable("dbo.ContentFiles");
        }
    }
}
