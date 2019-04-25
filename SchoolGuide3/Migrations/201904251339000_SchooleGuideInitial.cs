namespace SchoolGuide3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SchooleGuideInitial : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Schools", "Sc_Fees", c => c.String());
            DropColumn("dbo.Schools", "Sc_Fees_From");
            DropColumn("dbo.Schools", "Sc_Fees_To");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Schools", "Sc_Fees_To", c => c.String());
            AddColumn("dbo.Schools", "Sc_Fees_From", c => c.String());
            DropColumn("dbo.Schools", "Sc_Fees");
        }
    }
}
