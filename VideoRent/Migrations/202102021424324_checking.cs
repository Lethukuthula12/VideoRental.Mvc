namespace VideoRent.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class checking : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 255),
                        Surname = c.String(maxLength: 255),
                        dateOfBirth = c.DateTime(nullable: false),
                        isSubscribedToNewsLetter = c.Boolean(nullable: false),
                        MembershipTypesId = c.Int(nullable: false),
                        MembershipType_id = c.Byte(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.MembershipTypes", t => t.MembershipType_id)
                .Index(t => t.MembershipType_id);
            
            CreateTable(
                "dbo.MembershipTypes",
                c => new
                    {
                        id = c.Byte(nullable: false),
                        Name = c.String(nullable: false, maxLength: 225),
                        SignUpFee = c.Short(nullable: false),
                        DurationInMonths = c.Byte(nullable: false),
                        DiscountRate = c.Byte(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Customers", "MembershipType_id", "dbo.MembershipTypes");
            DropIndex("dbo.Customers", new[] { "MembershipType_id" });
            DropTable("dbo.MembershipTypes");
            DropTable("dbo.Customers");
        }
    }
}
