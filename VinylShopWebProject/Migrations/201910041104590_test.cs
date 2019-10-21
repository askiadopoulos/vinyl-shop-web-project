namespace VinylShopWebProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class test : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Orders", "CustomerId", "dbo.Customers");
            AlterColumn("dbo.Customers", "FirstName", c => c.String(nullable: false, maxLength: 30));
            AlterColumn("dbo.Customers", "LastName", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Formats", "Description", c => c.String(nullable: false, maxLength: 30));
            AlterColumn("dbo.Formats", "Abbreviation", c => c.String(nullable: false, maxLength: 15));
            AddForeignKey("dbo.Orders", "CustomerId", "dbo.Customers", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Orders", "CustomerId", "dbo.Customers");
            AlterColumn("dbo.Formats", "Abbreviation", c => c.String(maxLength: 15));
            AlterColumn("dbo.Formats", "Description", c => c.String(maxLength: 30));
            AlterColumn("dbo.Customers", "LastName", c => c.String(maxLength: 50));
            AlterColumn("dbo.Customers", "FirstName", c => c.String(maxLength: 30));
            AddForeignKey("dbo.Orders", "CustomerId", "dbo.Customers", "Id");
        }
    }
}
