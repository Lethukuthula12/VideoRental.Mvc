namespace VideoRent.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addMembershipAndMovieGenre : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.MembershipTypes",
                c => new
                    {
                        id = c.Byte(nullable: false),
                        SignUpFee = c.Short(nullable: false),
                        DurationInMonths = c.Byte(nullable: false),
                        DiscountRate = c.Byte(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.Genres",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        Name = c.Short(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
            AddColumn("dbo.Customers", "MembershipTypeId", c => c.Int(nullable: false));
            AddColumn("dbo.Customers", "membershipType_id", c => c.Byte());
            AddColumn("dbo.Movies", "Genreid", c => c.Int(nullable: false));
            CreateIndex("dbo.Customers", "membershipType_id");
            CreateIndex("dbo.Movies", "Genreid");
            AddForeignKey("dbo.Customers", "membershipType_id", "dbo.MembershipTypes", "id");
            AddForeignKey("dbo.Movies", "Genreid", "dbo.Genres", "id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Movies", "Genreid", "dbo.Genres");
            DropForeignKey("dbo.Customers", "membershipType_id", "dbo.MembershipTypes");
            DropIndex("dbo.Movies", new[] { "Genreid" });
            DropIndex("dbo.Customers", new[] { "membershipType_id" });
            DropColumn("dbo.Movies", "Genreid");
            DropColumn("dbo.Customers", "membershipType_id");
            DropColumn("dbo.Customers", "MembershipTypeId");
            DropTable("dbo.Genres");
            DropTable("dbo.MembershipTypes");
        }
    }
}
