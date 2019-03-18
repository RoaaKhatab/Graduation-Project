namespace SchoolGuide3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FirstMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.admins",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        FirstName = c.String(nullable: false),
                        LastName = c.String(nullable: false),
                        Email = c.String(nullable: false),
                        UserName = c.String(nullable: false),
                        Password = c.String(nullable: false),
                        ConfirmPassword = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Parents",
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
                    })
                .PrimaryKey(t => t.UserID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Parents");
            DropTable("dbo.admins");
        }
    }
}
