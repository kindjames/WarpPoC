namespace Warp.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UserConstraints : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Users", "Forename", c => c.String(nullable: false, maxLength: 100));
            AlterColumn("dbo.Users", "Surname", c => c.String(nullable: false, maxLength: 100));
            AlterColumn("dbo.Users", "PasswordHash", c => c.String(nullable: false));
            AlterColumn("dbo.Users", "Salt", c => c.String(nullable: false, maxLength: 100));
            AlterColumn("dbo.Users", "Email", c => c.String(nullable: false, maxLength: 255));
            AlterColumn("dbo.Users", "PasswordAnswer", c => c.String(nullable: false, maxLength: 255));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Users", "PasswordAnswer", c => c.String());
            AlterColumn("dbo.Users", "Email", c => c.String());
            AlterColumn("dbo.Users", "Salt", c => c.String());
            AlterColumn("dbo.Users", "PasswordHash", c => c.String());
            AlterColumn("dbo.Users", "Surname", c => c.String());
            AlterColumn("dbo.Users", "Forename", c => c.String());
        }
    }
}
