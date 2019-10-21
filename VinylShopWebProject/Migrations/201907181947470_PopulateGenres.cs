namespace VinylShopWebProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateGenres : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Genres (Id, Name) VALUES (1, 'Alternative Rock')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (2, 'Ambient')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (3, 'Blues')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (4, 'Breakbeat')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (5, 'Classical')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (6, 'Country')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (7, 'Dance')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (8, 'Disco')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (9, 'Drum and Bass')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (10, 'Dubstep')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (11, 'Electro')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (12, 'Electronic Dance')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (13, 'Experimental')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (14, 'Folk')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (15, 'Funk')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (16, 'Gospel')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (17, 'Grunge')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (18, 'Hardcore Punk')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (19, 'Hard Rock')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (20, 'Heavy Metal')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (21, 'Hip Hop')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (22, 'House')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (23, 'Indie Rock')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (24, 'Industrial')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (25, 'Instrumental')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (26, 'Jazz')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (27, 'Latin')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (28, 'Musical Theatre')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (29, 'New Wave')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (30, 'Orchestra')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (31, 'Pop')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (32, 'Pop Rock')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (33, 'Popular')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (34, 'Progressive Rock')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (35, 'Psychedelic')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (36, 'Punk Rock')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (37, 'Rapper')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (38, 'Reggae')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (39, 'Rhythm and Blues')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (40, 'Rock')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (41, 'Singing')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (42, 'Ska')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (43, 'Soul')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (44, 'Techno')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (45, 'Trance')");
        }
        
        public override void Down()
        {
            Sql("DELETE FROM Genres");
        }
    }
}
