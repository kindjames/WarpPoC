namespace Warp.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Brands",
                c => new
                    {
                        BrandId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        ClientId = c.Int(nullable: false),
                        BrandStatusId = c.Int(nullable: false),
                        IndustrySectorId = c.Int(nullable: false),
                        Visible = c.Boolean(nullable: false),
                        DateUpdated = c.DateTime(nullable: false),
                        DateCreated = c.DateTime(nullable: false),
                        Active = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.BrandId)
                .ForeignKey("dbo.BrandStatus", t => t.BrandStatusId, cascadeDelete: true)
                .ForeignKey("dbo.Clients", t => t.ClientId, cascadeDelete: true)
                .ForeignKey("dbo.IndustrySectors", t => t.IndustrySectorId, cascadeDelete: true)
                .Index(t => t.ClientId)
                .Index(t => t.BrandStatusId)
                .Index(t => t.IndustrySectorId);
            
            CreateTable(
                "dbo.BrandStatus",
                c => new
                    {
                        BrandStatusId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                        DateUpdated = c.DateTime(nullable: false),
                        DateCreated = c.DateTime(nullable: false),
                        Active = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.BrandStatusId);
            
            CreateTable(
                "dbo.Clients",
                c => new
                    {
                        ClientId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        ClientStatusId = c.Short(nullable: false),
                        Code = c.String(),
                        CustomerId = c.Int(nullable: false),
                        DateValidFrom = c.DateTime(),
                        DateUpdated = c.DateTime(nullable: false),
                        DateCreated = c.DateTime(nullable: false),
                        Active = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ClientId)
                .ForeignKey("dbo.ClientStatus", t => t.ClientStatusId, cascadeDelete: true)
                .Index(t => t.ClientStatusId);
            
            CreateTable(
                "dbo.ClientStatus",
                c => new
                    {
                        ClientStatusId = c.Short(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                        DateUpdated = c.DateTime(nullable: false),
                        DateCreated = c.DateTime(nullable: false),
                        Active = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ClientStatusId);
            
            CreateTable(
                "dbo.IndustrySectors",
                c => new
                    {
                        IndustrySectorId = c.Int(nullable: false, identity: true),
                        SectorName = c.String(),
                        SectorNameForAssessor = c.String(),
                        DateUpdated = c.DateTime(nullable: false),
                        DateCreated = c.DateTime(nullable: false),
                        Active = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.IndustrySectorId);
            
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        CustomerId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        UrlName = c.String(),
                        DisplayName = c.String(),
                        CustomerCode = c.String(),
                        DefaultLanguageId = c.Int(nullable: false),
                        DateUpdated = c.DateTime(nullable: false),
                        DateCreated = c.DateTime(nullable: false),
                        Active = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.CustomerId);
            
            CreateTable(
                "dbo.Roles",
                c => new
                    {
                        RoleId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        DateUpdated = c.DateTime(nullable: false),
                        DateCreated = c.DateTime(nullable: false),
                        Active = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.RoleId);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        UserId = c.Int(nullable: false, identity: true),
                        Forename = c.String(),
                        Surname = c.String(),
                        PasswordHash = c.String(),
                        Salt = c.String(),
                        UserName = c.String(),
                        DateLastPasswordChange = c.DateTime(nullable: false),
                        ForcePasswordChange = c.Boolean(nullable: false),
                        Email = c.String(),
                        CustomerId = c.Int(nullable: false),
                        DefaultUserRoleId = c.Int(nullable: false),
                        DefaultLanguageId = c.Int(nullable: false),
                        LegacyUserId = c.Int(nullable: false),
                        DateValidFrom = c.DateTime(nullable: false),
                        DateValidTo = c.DateTime(),
                        AutoCloseToast = c.Boolean(nullable: false),
                        PasswordQuestionId = c.Int(nullable: false),
                        PasswordAnswer = c.String(),
                        DateOfLastActivity = c.DateTime(nullable: false),
                        DateLastLockedOut = c.DateTime(),
                        DateLastLoggedIn = c.DateTime(nullable: false),
                        IsApproved = c.Boolean(nullable: false),
                        IsLockedOut = c.Boolean(nullable: false),
                        DateUpdated = c.DateTime(nullable: false),
                        DateCreated = c.DateTime(nullable: false),
                        Active = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.UserId);
            
            CreateTable(
                "dbo.UserRoles",
                c => new
                    {
                        User_UserId = c.Int(nullable: false),
                        Role_RoleId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.User_UserId, t.Role_RoleId })
                .ForeignKey("dbo.Users", t => t.User_UserId, cascadeDelete: true)
                .ForeignKey("dbo.Roles", t => t.Role_RoleId, cascadeDelete: true)
                .Index(t => t.User_UserId)
                .Index(t => t.Role_RoleId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.UserRoles", "Role_RoleId", "dbo.Roles");
            DropForeignKey("dbo.UserRoles", "User_UserId", "dbo.Users");
            DropForeignKey("dbo.Brands", "IndustrySectorId", "dbo.IndustrySectors");
            DropForeignKey("dbo.Brands", "ClientId", "dbo.Clients");
            DropForeignKey("dbo.Clients", "ClientStatusId", "dbo.ClientStatus");
            DropForeignKey("dbo.Brands", "BrandStatusId", "dbo.BrandStatus");
            DropIndex("dbo.UserRoles", new[] { "Role_RoleId" });
            DropIndex("dbo.UserRoles", new[] { "User_UserId" });
            DropIndex("dbo.Clients", new[] { "ClientStatusId" });
            DropIndex("dbo.Brands", new[] { "IndustrySectorId" });
            DropIndex("dbo.Brands", new[] { "BrandStatusId" });
            DropIndex("dbo.Brands", new[] { "ClientId" });
            DropTable("dbo.UserRoles");
            DropTable("dbo.Users");
            DropTable("dbo.Roles");
            DropTable("dbo.Customers");
            DropTable("dbo.IndustrySectors");
            DropTable("dbo.ClientStatus");
            DropTable("dbo.Clients");
            DropTable("dbo.BrandStatus");
            DropTable("dbo.Brands");
        }
    }
}
