namespace VideoRent.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangedGerne : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Movies", "Genreid", "dbo.Genres");
            DropPrimaryKey("dbo.Genres");
            AlterColumn("dbo.Genres", "id", c => c.Int(nullable: false));
            AlterColumn("dbo.Genres", "Name", c => c.String());
            AddPrimaryKey("dbo.Genres", "id");
            AddForeignKey("dbo.Movies", "Genreid", "dbo.Genres", "id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Movies", "Genreid", "dbo.Genres");
            DropPrimaryKey("dbo.Genres");
            AlterColumn("dbo.Genres", "Name", c => c.Short(nullable: false));
            AlterColumn("dbo.Genres", "id", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.Genres", "id");
            AddForeignKey("dbo.Movies", "Genreid", "dbo.Genres", "id", cascadeDelete: true);
        }
    }
}
