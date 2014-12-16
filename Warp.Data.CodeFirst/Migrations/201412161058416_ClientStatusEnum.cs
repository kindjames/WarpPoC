using System.Data.Entity.Migrations;

namespace Warp.Data.Migrations
{
    public partial class ClientStatusEnum : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Clients", "ClientStatus_ClientStatusId", "dbo.ClientStatus");
            DropIndex("dbo.Clients", new[] { "ClientStatus_ClientStatusId" });
            AddColumn("dbo.Clients", "Status", c => c.Int(nullable: false));
            DropColumn("dbo.Clients", "ClientStatus_ClientStatusId");
            DropTable("dbo.ClientStatus");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.ClientStatus",
                c => new
                    {
                        ClientStatusId = c.Short(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Description = c.String(nullable: false),
                        DateUpdated = c.DateTime(nullable: false),
                        DateCreated = c.DateTime(nullable: false),
                        Active = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ClientStatusId);
            
            AddColumn("dbo.Clients", "ClientStatus_ClientStatusId", c => c.Short(nullable: false));
            DropColumn("dbo.Clients", "Status");
            CreateIndex("dbo.Clients", "ClientStatus_ClientStatusId");
            AddForeignKey("dbo.Clients", "ClientStatus_ClientStatusId", "dbo.ClientStatus", "ClientStatusId", cascadeDelete: true);
        }
    }
}
