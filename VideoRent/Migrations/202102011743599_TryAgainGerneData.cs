namespace VideoRent.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TryAgainGerneData : DbMigration
    {
        public override void Up()
        {

            Sql("INSERT INTO Genres (Name) VALUES ('Action')");
            Sql("INSERT INTO Genres (Name) VALUES ('Documentary')");
            Sql("INSERT INTO Genres (Name) VALUES ('Thriller')");
            Sql("INSERT INTO Genres (Name) VALUES ('Romance')");
            Sql("INSERT INTO Genres (Name) VALUES ('Scarry')");
            Sql("INSERT INTO Genres (Name) VALUES ('Crime')");
        }
        
        public override void Down()
        {
        }
    }
}
