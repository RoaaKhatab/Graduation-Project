namespace SchoolGuide3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FirstMigration1 : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Parents", newName: "Users");
            AddColumn("dbo.Users", "Usertype", c => c.Int(nullable: false));
            DropTable("dbo.admins");
        }
        
        public override void Down()
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
            
            DropColumn("dbo.Users", "Usertype");
            RenameTable(name: "dbo.Users", newName: "Parents");
        }
    }
}
