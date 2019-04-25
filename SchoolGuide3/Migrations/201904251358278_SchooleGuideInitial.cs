namespace SchoolGuide3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SchooleGuideInitial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Schools",
                c => new
                    {
                        Sc_id = c.Int(nullable: false, identity: true),
                        Sc_Name = c.String(nullable: false),
                        Sc_Details = c.String(nullable: false),
                        Sc_Facebook = c.String(),
                        Sc_Twitter = c.String(),
                        Sc_instagram = c.String(),
                        Sc_Image = c.String(),
                        Sc_Category = c.String(),
                        Sc_Fees = c.String(),
                        Sc_Location = c.String(nullable: false),
                        Sc_phone1 = c.Int(nullable: false),
                        Sc_phone2 = c.Int(nullable: false),
                        Sc_phone3 = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Sc_id);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        UserID = c.Int(nullable: false, identity: true),
                        FirstName = c.String(nullable: false, maxLength: 255),
                        LastName = c.String(nullable: false, maxLength: 255),
                        Email = c.String(nullable: false),
                        UserName = c.String(nullable: false, maxLength: 255),
                        Phone = c.Int(nullable: false),
                        Password = c.String(nullable: false),
                        ConfirmPassword = c.String(),
                        Age = c.Int(nullable: false),
                        Gender = c.String(nullable: false),
                        Address = c.String(),
                        SSN = c.String(),
                        Usertype = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.UserID);
            
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
            DropTable("dbo.Users");
            DropTable("dbo.Schools");
        }
    }
}
