namespace VinylShopWebProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RelateGenreAndRecordLabelWithVinyl : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Products", "GenreId", c => c.Byte());
            AddColumn("dbo.Products", "RecordLabelId", c => c.Short());
            CreateIndex("dbo.Products", "GenreId");
            CreateIndex("dbo.Products", "RecordLabelId");
            AddForeignKey("dbo.Products", "GenreId", "dbo.Genres", "Id");
            AddForeignKey("dbo.Products", "RecordLabelId", "dbo.RecordLabels", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Products", "RecordLabelId", "dbo.RecordLabels");
            DropForeignKey("dbo.Products", "GenreId", "dbo.Genres");
            DropIndex("dbo.Products", new[] { "RecordLabelId" });
            DropIndex("dbo.Products", new[] { "GenreId" });
            DropColumn("dbo.Products", "RecordLabelId");
            DropColumn("dbo.Products", "GenreId");
        }
    }
}
