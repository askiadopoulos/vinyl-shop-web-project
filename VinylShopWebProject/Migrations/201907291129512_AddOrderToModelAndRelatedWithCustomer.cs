namespace VinylShopWebProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddOrderToModelAndRelatedWithCustomer : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Orders",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        OrderDateTime = c.DateTime(nullable: false),
                        IsPaid = c.Boolean(nullable: false),
                        Comments = c.String(maxLength: 255),
                        CustomerId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Customers", t => t.CustomerId)
                .Index(t => t.CustomerId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Orders", "CustomerId", "dbo.Customers");
            DropIndex("dbo.Orders", new[] { "CustomerId" });
            DropTable("dbo.Orders");
        }
    }
}
