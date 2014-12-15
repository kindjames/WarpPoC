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
                        Name = c.String(nullable: false),
                        Visible = c.Boolean(nullable: false),
                        DateUpdated = c.DateTime(nullable: false),
                        DateCreated = c.DateTime(nullable: false),
                        Active = c.Boolean(nullable: false),
                        BrandStatus_BrandStatusId = c.Int(nullable: false),
                        Client_ClientId = c.Int(nullable: false),
                        IndustrySector_IndustrySectorId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.BrandId)
                .ForeignKey("dbo.BrandStatus", t => t.BrandStatus_BrandStatusId, cascadeDelete: true)
                .ForeignKey("dbo.Clients", t => t.Client_ClientId, cascadeDelete: true)
                .ForeignKey("dbo.IndustrySectors", t => t.IndustrySector_IndustrySectorId, cascadeDelete: true)
                .Index(t => t.BrandStatus_BrandStatusId)
                .Index(t => t.Client_ClientId)
                .Index(t => t.IndustrySector_IndustrySectorId);
            
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
            
            CreateTable(
                "dbo.Clients",
                c => new
                    {
                        ClientId = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Code = c.String(nullable: false),
                        DateValidFrom = c.DateTime(),
                        DateUpdated = c.DateTime(nullable: false),
                        DateCreated = c.DateTime(nullable: false),
                        Active = c.Boolean(nullable: false),
                        AccountManager_UserId = c.Int(nullable: false),
                        ClientStatus_ClientStatusId = c.Short(nullable: false),
                        Customer_CustomerId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ClientId)
                .ForeignKey("Client.Users", t => t.AccountManager_UserId, cascadeDelete: true)
                .ForeignKey("dbo.ClientStatus", t => t.ClientStatus_ClientStatusId, cascadeDelete: true)
                .ForeignKey("dbo.Customers", t => t.Customer_CustomerId, cascadeDelete: true)
                .Index(t => t.AccountManager_UserId)
                .Index(t => t.ClientStatus_ClientStatusId)
                .Index(t => t.Customer_CustomerId);
            
            CreateTable(
                "Client.Users",
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
                        Customer_CustomerId = c.Int(),
                    })
                .PrimaryKey(t => t.UserId)
                .ForeignKey("dbo.Customers", t => t.Customer_CustomerId)
                .Index(t => t.Email)
                .Index(t => t.Customer_CustomerId);
            
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        CustomerId = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        UrlName = c.String(nullable: false),
                        DisplayName = c.String(nullable: false),
                        CustomerCode = c.String(nullable: false),
                        DefaultLanguageId = c.Int(nullable: false),
                        DateUpdated = c.DateTime(nullable: false),
                        DateCreated = c.DateTime(nullable: false),
                        Active = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.CustomerId);
            
            CreateTable(
                "Client.RoleGroups",
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
                "Client.Roles",
                c => new
                    {
                        RoleId = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Description = c.String(nullable: false),
                        DateUpdated = c.DateTime(nullable: false),
                        DateCreated = c.DateTime(nullable: false),
                        Active = c.Boolean(nullable: false),
                        RoleGroup_RoleGroupId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.RoleId)
                .ForeignKey("Client.RoleGroups", t => t.RoleGroup_RoleGroupId, cascadeDelete: true)
                .Index(t => t.RoleGroup_RoleGroupId);
            
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
            
            CreateTable(
                "dbo.IndustrySectors",
                c => new
                    {
                        IndustrySectorId = c.Int(nullable: false, identity: true),
                        SectorName = c.String(nullable: false),
                        SectorNameForAssessor = c.String(nullable: false),
                        DateUpdated = c.DateTime(nullable: false),
                        DateCreated = c.DateTime(nullable: false),
                        Active = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.IndustrySectorId);
            
            CreateTable(
                "dbo.Languages",
                c => new
                    {
                        LanguageId = c.Int(nullable: false, identity: true),
                        InvariantCulture = c.String(nullable: false),
                        Locale = c.String(nullable: false),
                        Name = c.String(nullable: false),
                        DateUpdated = c.DateTime(nullable: false),
                        DateCreated = c.DateTime(nullable: false),
                        Active = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.LanguageId);
            
            CreateTable(
                "dbo.TextResourceIdentifiers",
                c => new
                    {
                        TextResourceIdentifierId = c.Int(nullable: false, identity: true),
                        TextResourceCode = c.String(nullable: false),
                        ClientOverridable = c.Boolean(nullable: false),
                        DateUpdated = c.DateTime(nullable: false),
                        DateCreated = c.DateTime(nullable: false),
                        Active = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.TextResourceIdentifierId);
            
            CreateTable(
                "dbo.TextResources",
                c => new
                    {
                        TextResourceId = c.Int(nullable: false),
                        ClientId = c.Int(nullable: false),
                        LanguageId = c.Int(nullable: false),
                        TextResourceIdentifierId = c.Int(nullable: false),
                        ResourceString = c.String(nullable: false),
                        DateUpdated = c.DateTime(nullable: false),
                        DateCreated = c.DateTime(nullable: false),
                        Active = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => new { t.TextResourceId, t.ClientId, t.LanguageId, t.TextResourceIdentifierId })
                .ForeignKey("dbo.Clients", t => t.ClientId, cascadeDelete: true)
                .ForeignKey("dbo.Languages", t => t.LanguageId, cascadeDelete: true)
                .ForeignKey("dbo.TextResourceIdentifiers", t => t.TextResourceIdentifierId, cascadeDelete: true)
                .Index(t => t.ClientId)
                .Index(t => t.LanguageId)
                .Index(t => t.TextResourceIdentifierId);
            
            CreateTable(
                "dbo.RoleGroupUsers",
                c => new
                    {
                        RoleGroup_RoleGroupId = c.Int(nullable: false),
                        User_UserId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.RoleGroup_RoleGroupId, t.User_UserId })
                .ForeignKey("Client.RoleGroups", t => t.RoleGroup_RoleGroupId, cascadeDelete: true)
                .ForeignKey("Client.Users", t => t.User_UserId, cascadeDelete: true)
                .Index(t => t.RoleGroup_RoleGroupId)
                .Index(t => t.User_UserId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.TextResources", "TextResourceIdentifierId", "dbo.TextResourceIdentifiers");
            DropForeignKey("dbo.TextResources", "LanguageId", "dbo.Languages");
            DropForeignKey("dbo.TextResources", "ClientId", "dbo.Clients");
            DropForeignKey("dbo.Brands", "IndustrySector_IndustrySectorId", "dbo.IndustrySectors");
            DropForeignKey("dbo.Brands", "Client_ClientId", "dbo.Clients");
            DropForeignKey("dbo.Clients", "Customer_CustomerId", "dbo.Customers");
            DropForeignKey("dbo.Clients", "ClientStatus_ClientStatusId", "dbo.ClientStatus");
            DropForeignKey("dbo.Clients", "AccountManager_UserId", "Client.Users");
            DropForeignKey("dbo.RoleGroupUsers", "User_UserId", "Client.Users");
            DropForeignKey("dbo.RoleGroupUsers", "RoleGroup_RoleGroupId", "Client.RoleGroups");
            DropForeignKey("Client.Roles", "RoleGroup_RoleGroupId", "Client.RoleGroups");
            DropForeignKey("Client.Users", "Customer_CustomerId", "dbo.Customers");
            DropForeignKey("dbo.Brands", "BrandStatus_BrandStatusId", "dbo.BrandStatus");
            DropIndex("dbo.RoleGroupUsers", new[] { "User_UserId" });
            DropIndex("dbo.RoleGroupUsers", new[] { "RoleGroup_RoleGroupId" });
            DropIndex("dbo.TextResources", new[] { "TextResourceIdentifierId" });
            DropIndex("dbo.TextResources", new[] { "LanguageId" });
            DropIndex("dbo.TextResources", new[] { "ClientId" });
            DropIndex("Client.Roles", new[] { "RoleGroup_RoleGroupId" });
            DropIndex("Client.Users", new[] { "Customer_CustomerId" });
            DropIndex("Client.Users", new[] { "Email" });
            DropIndex("dbo.Clients", new[] { "Customer_CustomerId" });
            DropIndex("dbo.Clients", new[] { "ClientStatus_ClientStatusId" });
            DropIndex("dbo.Clients", new[] { "AccountManager_UserId" });
            DropIndex("dbo.Brands", new[] { "IndustrySector_IndustrySectorId" });
            DropIndex("dbo.Brands", new[] { "Client_ClientId" });
            DropIndex("dbo.Brands", new[] { "BrandStatus_BrandStatusId" });
            DropTable("dbo.RoleGroupUsers");
            DropTable("dbo.TextResources");
            DropTable("dbo.TextResourceIdentifiers");
            DropTable("dbo.Languages");
            DropTable("dbo.IndustrySectors");
            DropTable("dbo.ClientStatus");
            DropTable("Client.Roles");
            DropTable("Client.RoleGroups");
            DropTable("dbo.Customers");
            DropTable("Client.Users");
            DropTable("dbo.Clients");
            DropTable("dbo.BrandStatus");
            DropTable("dbo.Brands");
        }
    }
}
