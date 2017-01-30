namespace Gamely.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateGames : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Games (Name, Genre, ReleaseDate, DateAdded, NumberInStock) VALUES ('Resident Evil 7', 'Horror', '01/24/2017', '01/24/2017', 10)");
            Sql("INSERT INTO Games (Name, Genre, ReleaseDate, DateAdded, NumberInStock) VALUES ('Planet Coaster', 'Simulation', '12/11/2016', '12/11/2016', 17)");
            Sql("INSERT INTO Games (Name, Genre, ReleaseDate, DateAdded, NumberInStock) VALUES ('Far Cry Primal', 'Adventure', '03/23/2016', '03/23/2016', 8)");
            Sql("INSERT INTO Games (Name, Genre, ReleaseDate, DateAdded, NumberInStock) VALUES ('Battlefield 1', 'Action', '11/11/2016', '11/11/2016', 109)");
        }
        
        public override void Down()
        {
        }
    }
}
