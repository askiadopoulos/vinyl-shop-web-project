namespace VinylShopWebProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateCategories : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Categories (Id, Description) VALUES (1, 'LP Vinyl')");
            Sql("INSERT INTO Categories (Id, Description) VALUES (2, 'CD')");
            Sql("INSERT INTO Categories (Id, Description) VALUES (3, 'MC - Audio Cassette')");
            Sql("INSERT INTO Categories (Id, Description) VALUES (4, 'Merchandise')");
            Sql("INSERT INTO Categories (Id, Description) VALUES (5, 'Accessories')");
        }
        
        public override void Down()
        {
            Sql("DELETE FROM Categories");
        }
    }
}
