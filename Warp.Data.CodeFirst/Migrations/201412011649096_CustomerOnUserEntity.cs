namespace Warp.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CustomerOnUserEntity : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Users", "Customer_CustomerId", c => c.Int());
            CreateIndex("dbo.Users", "Customer_CustomerId");
            AddForeignKey("dbo.Users", "Customer_CustomerId", "dbo.Customers", "CustomerId");
            DropColumn("dbo.Users", "CustomerId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Users", "CustomerId", c => c.Int(nullable: false));
            DropForeignKey("dbo.Users", "Customer_CustomerId", "dbo.Customers");
            DropIndex("dbo.Users", new[] { "Customer_CustomerId" });
            DropColumn("dbo.Users", "Customer_CustomerId");
        }
    }
}
