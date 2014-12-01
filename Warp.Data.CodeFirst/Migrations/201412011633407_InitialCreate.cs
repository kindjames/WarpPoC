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
                "dbo.RoleGroups",
                c => new
                    {
                        RoleGroupId = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Description = c.String(nullable: false),
                        DateUpdated = c.DateTime(nullable: false),
                        DateCreated = c.DateTime(nullable: false),
                        Active = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.RoleGroupId);
            
            CreateTable(
                "dbo.Roles",
                c => new
                    {
                        RoleId = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Description = c.String(nullable: false),
                        DateUpdated = c.DateTime(nullable: false),
                        DateCreated = c.DateTime(nullable: false),
                        Active = c.Boolean(nullable: false),
                        RoleGroup_RoleGroupId = c.Int(),
                    })
                .PrimaryKey(t => t.RoleId)
                .ForeignKey("dbo.RoleGroups", t => t.RoleGroup_RoleGroupId)
                .Index(t => t.RoleGroup_RoleGroupId);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        UserId = c.Int(nullable: false, identity: true),
                        Forename = c.String(nullable: false, maxLength: 100),
                        Surname = c.String(nullable: false, maxLength: 100),
                        PasswordHash = c.String(nullable: false),
                        Salt = c.String(nullable: false, maxLength: 100),
                        Email = c.String(nullable: false, maxLength: 255),
                        PasswordAnswer = c.String(nullable: false, maxLength: 255),
                        DateLastPasswordChange = c.DateTime(nullable: false),
                        ForcePasswordChange = c.Boolean(nullable: false),
                        CustomerId = c.Int(nullable: false),
                        DefaultUserRoleId = c.Int(nullable: false),
                        DefaultLanguageId = c.Int(nullable: false),
                        LegacyUserId = c.Int(),
                        DateValidFrom = c.DateTime(nullable: false),
                        DateValidTo = c.DateTime(),
                        AutoCloseToast = c.Boolean(nullable: false),
                        PasswordQuestionId = c.Int(nullable: false),
                        DateOfLastActivity = c.DateTime(nullable: false),
                        DateLastLockedOut = c.DateTime(),
                        DateLastLoggedIn = c.DateTime(nullable: false),
                        IsApproved = c.Boolean(nullable: false),
                        IsLockedOut = c.Boolean(nullable: false),
                        DateUpdated = c.DateTime(nullable: false),
                        DateCreated = c.DateTime(nullable: false),
                        Active = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.UserId)
                .Index(t => t.Email);
            
            CreateTable(
                "dbo.UserRoleGroups",
                c => new
                    {
                        User_UserId = c.Int(nullable: false),
                        RoleGroup_RoleGroupId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.User_UserId, t.RoleGroup_RoleGroupId })
                .ForeignKey("dbo.Users", t => t.User_UserId, cascadeDelete: true)
                .ForeignKey("dbo.RoleGroups", t => t.RoleGroup_RoleGroupId, cascadeDelete: true)
                .Index(t => t.User_UserId)
                .Index(t => t.RoleGroup_RoleGroupId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.UserRoleGroups", "RoleGroup_RoleGroupId", "dbo.RoleGroups");
            DropForeignKey("dbo.UserRoleGroups", "User_UserId", "dbo.Users");
            DropForeignKey("dbo.Roles", "RoleGroup_RoleGroupId", "dbo.RoleGroups");
            DropForeignKey("dbo.Brands", "IndustrySectorId", "dbo.IndustrySectors");
            DropForeignKey("dbo.Brands", "ClientId", "dbo.Clients");
            DropForeignKey("dbo.Clients", "ClientStatusId", "dbo.ClientStatus");
            DropForeignKey("dbo.Brands", "BrandStatusId", "dbo.BrandStatus");
            DropIndex("dbo.UserRoleGroups", new[] { "RoleGroup_RoleGroupId" });
            DropIndex("dbo.UserRoleGroups", new[] { "User_UserId" });
            DropIndex("dbo.Users", new[] { "Email" });
            DropIndex("dbo.Roles", new[] { "RoleGroup_RoleGroupId" });
            DropIndex("dbo.Clients", new[] { "ClientStatusId" });
            DropIndex("dbo.Brands", new[] { "IndustrySectorId" });
            DropIndex("dbo.Brands", new[] { "BrandStatusId" });
            DropIndex("dbo.Brands", new[] { "ClientId" });
            DropTable("dbo.UserRoleGroups");
            DropTable("dbo.Users");
            DropTable("dbo.Roles");
            DropTable("dbo.RoleGroups");
            DropTable("dbo.Customers");
            DropTable("dbo.IndustrySectors");
            DropTable("dbo.ClientStatus");
            DropTable("dbo.Clients");
            DropTable("dbo.BrandStatus");
            DropTable("dbo.Brands");
        }
    }
}
