namespace VideoRent.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateMembershiptypedate : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO MembershipTypes(id,Name,SignUpFee,DurationInMonths,DiscountRate) VALUES(1,'Pay as You Go',0,0,0)");
            Sql("INSERT INTO MembershipTypes(id,Name,SignUpFee,DurationInMonths,DiscountRate) VALUES(2,'Monthly',30,1,10)");
            Sql("INSERT INTO MembershipTypes(id,Name,SignUpFee,DurationInMonths,DiscountRate) VALUES(3,'Quartery',90,3,15)");
            Sql("INSERT INTO MembershipTypes(id,Name,SignUpFee,DurationInMonths,DiscountRate) VALUES(4,'Yealy',300,3,15)");
        }
        
        public override void Down()
        {
        }
    }
}
