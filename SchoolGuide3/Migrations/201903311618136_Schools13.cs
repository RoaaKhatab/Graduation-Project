namespace SchoolGuide3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Schools13 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.WishLists",
                c => new
                    {
                        SchoolPage = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.SchoolPage);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.WishLists");
        }
    }
}
