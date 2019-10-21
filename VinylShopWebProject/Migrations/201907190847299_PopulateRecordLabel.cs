namespace VinylShopWebProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateRecordLabel : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO RecordLabels (Id, Name) VALUES (1, 'Sony Music Entertainment')");
            Sql("INSERT INTO RecordLabels (Id, Name) VALUES (2, 'Universal Music Group')");
            Sql("INSERT INTO RecordLabels (Id, Name) VALUES (3, 'Warner Music')");
            Sql("INSERT INTO RecordLabels (Id, Name) VALUES (4, 'BMG')");
            Sql("INSERT INTO RecordLabels (Id, Name) VALUES (5, 'Paramount Records')");
            Sql("INSERT INTO RecordLabels (Id, Name) VALUES (6, 'Virgin Records')");
            Sql("INSERT INTO RecordLabels (Id, Name) VALUES (7, 'Global Underground')");
            Sql("INSERT INTO RecordLabels (Id, Name) VALUES (8, 'Defected Records')");
            Sql("INSERT INTO RecordLabels (Id, Name) VALUES (9, 'Yoshitoshi Recordings')");
            Sql("INSERT INTO RecordLabels (Id, Name) VALUES (10, 'EMI')");
            Sql("INSERT INTO RecordLabels (Id, Name) VALUES (11, 'Polygram')");
            Sql("INSERT INTO RecordLabels (Id, Name) VALUES (12, 'Electra Records')");
            Sql("INSERT INTO RecordLabels (Id, Name) VALUES (13, 'Red Hill Records')");
            Sql("INSERT INTO RecordLabels (Id, Name) VALUES (14, 'Atlantic Records')");
            Sql("INSERT INTO RecordLabels (Id, Name) VALUES (15, 'Ministry Of Sound Records')");
        }
        
        public override void Down()
        {
            Sql("DELETE FROM RecordLabels");
        }
    }
}
