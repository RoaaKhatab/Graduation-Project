namespace SchoolGuide3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Schools12 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Schools", "Sc_Fees", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Schools", "Sc_Fees");
        }
    }
}
