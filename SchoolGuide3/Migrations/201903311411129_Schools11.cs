namespace SchoolGuide3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Schools11 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Schools", "Sc_Category", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Schools", "Sc_Category");
        }
    }
}
