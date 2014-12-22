namespace Warp.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class BrandStatusEnum : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Brands", "BrandStatus_BrandStatusId", "dbo.BrandStatus");
            DropIndex("dbo.Brands", new[] { "BrandStatus_BrandStatusId" });
            AddColumn("dbo.Brands", "Status", c => c.Int(nullable: false));
            DropColumn("dbo.Brands", "BrandStatus_BrandStatusId");
            DropTable("dbo.BrandStatus");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.BrandStatus",
                c => new
                    {
                        BrandStatusId = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Description = c.String(nullable: false),
                        DateUpdated = c.DateTime(nullable: false),
                        DateCreated = c.DateTime(nullable: false),
                        Active = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.BrandStatusId);
            
            AddColumn("dbo.Brands", "BrandStatus_BrandStatusId", c => c.Int(nullable: false));
            DropColumn("dbo.Brands", "Status");
            CreateIndex("dbo.Brands", "BrandStatus_BrandStatusId");
            AddForeignKey("dbo.Brands", "BrandStatus_BrandStatusId", "dbo.BrandStatus", "BrandStatusId", cascadeDelete: true);
        }
    }
}
