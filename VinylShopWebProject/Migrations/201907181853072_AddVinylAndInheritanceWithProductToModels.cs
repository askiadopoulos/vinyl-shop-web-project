namespace VinylShopWebProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddVinylAndInheritanceWithProductToModels : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Products", "Artist", c => c.String(maxLength: 50));
            AddColumn("dbo.Products", "Title", c => c.String(maxLength: 80));
            AddColumn("dbo.Products", "ReleaseDate", c => c.DateTime());
            AddColumn("dbo.Products", "Discriminator", c => c.String(nullable: false, maxLength: 128));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Products", "Discriminator");
            DropColumn("dbo.Products", "ReleaseDate");
            DropColumn("dbo.Products", "Title");
            DropColumn("dbo.Products", "Artist");
        }
    }
}
