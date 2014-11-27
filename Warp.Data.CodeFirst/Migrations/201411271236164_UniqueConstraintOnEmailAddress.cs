namespace Warp.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UniqueConstraintOnEmailAddress : DbMigration
    {
        public override void Up()
        {
            CreateIndex("dbo.Users", "Email");
            DropColumn("dbo.Users", "UserName");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Users", "UserName", c => c.String());
            DropIndex("dbo.Users", new[] { "Email" });
        }
    }
}
