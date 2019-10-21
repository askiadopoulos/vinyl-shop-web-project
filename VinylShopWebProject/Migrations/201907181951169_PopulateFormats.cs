namespace VinylShopWebProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateFormats : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Formats (Id, Description, Abbreviation, Comments) VALUES (1, 'Vinyl', 'Vinyl', 'A phonograph record is an analog sound storage medium in the form of a flat disc with an inscribed, modulated spiral groove.')");
            Sql("INSERT INTO Formats (Id, Description, Abbreviation, Comments) VALUES (2, 'CD',	'CD', 'Compact Disc')");
            Sql("INSERT INTO Formats (Id, Description, Abbreviation, Comments) VALUES (3, 'DVD', 'DVD', 'Digital Video Disc')");
            Sql("INSERT INTO Formats (Id, Description, Abbreviation, Comments) VALUES (4, 'HD DVD', 'HD DVD', 'It can store about three times as much data as its predecessor DVD, (15 GB per layer instead of 4.7 GB)')");
            Sql("INSERT INTO Formats (Id, Description, Abbreviation, Comments) VALUES (5, 'Blu-ray', 'Blu-ray', 'A Blu-ray Disc can store 25 GB on each layer.')");
            Sql("INSERT INTO Formats (Id, Description, Abbreviation, Comments) VALUES (6, 'Cassette', 'Cass', 'Compact Cassette, often referred to as audio cassette or simply cassette tape has two sets of stereo tracks. The tape can be turned over to access the second side.')");
            Sql("INSERT INTO Formats (Id, Description, Abbreviation, Comments) VALUES (7, 'DAT', 'DAT', 'Digital Audio Tape')");
            Sql("INSERT INTO Formats (Id, Description, Abbreviation, Comments) VALUES (8, 'DCC', 'DCC', 'Digital Compact Cassette')");
            Sql("INSERT INTO Formats (Id, Description, Abbreviation, Comments) VALUES (9, 'Box Set', 'Box', 'To note that all media are enclosed in extra packaging. Box Set goes on its own line: 5 x LP, Box Set')");
            Sql("INSERT INTO Formats (Id, Description, Abbreviation, Comments) VALUES (10, 'LP', 'LP', 'The LP tag used by itself, denotes a 12 inch 33 rpm long-playing record.')");
            Sql("INSERT INTO Formats (Id, Description, Abbreviation, Comments) VALUES (11, '33 RPM', '33 RPM', '')");
            Sql("INSERT INTO Formats (Id, Description, Abbreviation, Comments) VALUES (12, '45 RPM', '45 RPM', '')");
            Sql("INSERT INTO Formats (Id, Description, Abbreviation, Comments) VALUES (13, '78 RPM', '78 RPM', 'Earlier records may run ±15%, i.e. about 66 to 90 RPM; a record cut at a speed in this range is normally called 78.')");
            Sql("INSERT INTO Formats (Id, Description, Abbreviation, Comments) VALUES (14, '80 RPM', '80 RPM', '')");
            Sql("INSERT INTO Formats (Id, Description, Abbreviation, Comments) VALUES (15, '90 RPM', '90 RPM', '')");
            Sql("INSERT INTO Formats (Id, Description, Abbreviation, Comments) VALUES (16, 'DVD-Audio',	'DVD-A', 'Only to be used when the release shows the DVD-Audio logo.')");
            Sql("INSERT INTO Formats (Id, Description, Abbreviation, Comments) VALUES (17, 'VinylDisc', 'VinylDisc', 'A combination of a digital layer, either in CD or DVD format, and an analogue layer which is a vinyl record.')");
            Sql("INSERT INTO Formats (Id, Description, Abbreviation, Comments) VALUES (18, 'Double Sided', 'D/Sided', '')");
            Sql("INSERT INTO Formats (Id, Description, Abbreviation, Comments) VALUES (19, 'Single Sided', 'S/Sided', '')");
            Sql("INSERT INTO Formats (Id, Description, Abbreviation, Comments) VALUES (20, 'Album', 'Album', '')");
            Sql("INSERT INTO Formats (Id, Description, Abbreviation, Comments) VALUES (21, 'EP', 'EP', 'Only to be used where it is clear the item was released as such.')");
            Sql("INSERT INTO Formats (Id, Description, Abbreviation, Comments) VALUES (22, 'Maxi-Single', 'Maxi', 'Only to be used where it is clear the item was released as such.')");
            Sql("INSERT INTO Formats (Id, Description, Abbreviation, Comments) VALUES (23, 'Single', 'Single', 'Only to be used where it is clear the item was released as such.')");
            Sql("INSERT INTO Formats (Id, Description, Abbreviation, Comments) VALUES (24, 'Compilation', 'Comp', '')");
            Sql("INSERT INTO Formats (Id, Description, Abbreviation, Comments) VALUES (25, 'Stereo', 'Stereo', 'Stereophonic')");
            Sql("INSERT INTO Formats (Id, Description, Abbreviation, Comments) VALUES (26, 'Mono', 'Mono', 'Monophonic')");
            Sql("INSERT INTO Formats (Id, Description, Abbreviation, Comments) VALUES (27, 'Copy Protected', 'Copy Prot.', 'Monophonic')");
            Sql("INSERT INTO Formats (Id, Description, Abbreviation, Comments) VALUES (28, 'Enhanced', 'Enh', 'This includes formats sometimes known as Enhanced CD, Mixed Mode, and CD Extra.')");
            Sql("INSERT INTO Formats (Id, Description, Abbreviation, Comments) VALUES (29, 'Jukebox', 'Jukebox', 'Any item labeled as being released for the jukebox market.')");
            Sql("INSERT INTO Formats (Id, Description, Abbreviation, Comments) VALUES (30, 'Limited Edition', 'Ltd', 'Monophonic')");
            Sql("INSERT INTO Formats (Id, Description, Abbreviation, Comments) VALUES (31, 'Mixed', 'Mixed', 'Continuous mix, DJ mix, segued audio. Use this tag if all of the tracks are mixed together into one continuous flow, for example DJ Mix CDs, mixtapes etc.')");
            Sql("INSERT INTO Formats (Id, Description, Abbreviation, Comments) VALUES (32, 'Promo', 'Promo', 'Promotional copy. Only add this tag if it is explicitly mentioned on the release.')");
            Sql("INSERT INTO Formats (Id, Description, Abbreviation, Comments) VALUES (33, 'Remastered', 'RM', 'This tag should only be used where it is clear the item was released as such, for example it is explicitly mentioned on the release, or by the label, artist, or other reliable source.')");
            Sql("INSERT INTO Formats (Id, Description, Abbreviation, Comments) VALUES (34, 'Sampler', 'Smplr', 'In English, sampler has a different meaning from Compilation, a sampler is a free or low-priced preview of a larger release(s).')");
            Sql("INSERT INTO Formats (Id, Description, Abbreviation, Comments) VALUES (35, 'Special Edition', 'S/Edition', 'Only items that have this printed on them somewhere (stickers etc), or were originally marketed by the label as such, should be tagged as Special Edition.')");
            Sql("INSERT INTO Formats (Id, Description, Abbreviation, Comments) VALUES (36, 'Mono', 'Mono', 'Monophonic')");
        }
        
        public override void Down()
        {
            Sql("DELETE FROM Formats");
        }
    }
}
