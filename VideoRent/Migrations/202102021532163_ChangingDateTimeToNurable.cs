namespace VideoRent.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangingDateTimeToNurable : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Customers", "dateOfBirth", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Customers", "dateOfBirth", c => c.DateTime(nullable: false));
        }
    }
}
