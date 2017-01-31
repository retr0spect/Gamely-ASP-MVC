namespace Gamely.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateGameWithGenreId : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Games (Name, ReleaseDate, DateAdded, NumberInStock, GenreId) VALUES ('Resident Evil 7', '01/24/2017', '01/24/2017', 10, 4)");
            Sql("INSERT INTO Games (Name, ReleaseDate, DateAdded, NumberInStock, GenreId) VALUES ('Planet Coaster', '12/11/2016', '12/11/2016', 17, 3)");
            Sql("INSERT INTO Games (Name, ReleaseDate, DateAdded, NumberInStock, GenreId) VALUES ('Far Cry Primal', '03/23/2016', '03/23/2016', 8, 1)");
            Sql("INSERT INTO Games (Name, ReleaseDate, DateAdded, NumberInStock, GenreId) VALUES ('Battlefield 1', '11/11/2016', '11/11/2016', 109, 1)");
        }
        
        public override void Down()
        {
        }
    }
}
