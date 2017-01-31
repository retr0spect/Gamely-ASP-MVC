namespace Gamely.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemovedGenreColumnFromGame : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Games", "Genre");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Games", "Genre", c => c.String());
        }
    }
}
