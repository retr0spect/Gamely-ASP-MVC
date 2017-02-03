namespace Gamely.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class fixDB : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Games", "Name", c => c.String(nullable: false));
            AlterColumn("dbo.Games", "ReleaseDate", c => c.String(nullable: false));
        
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Games", "ReleaseDate", c => c.String());
            AlterColumn("dbo.Games", "Name", c => c.String());
        }
    }
}
