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
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Visible = c.Boolean(nullable: false),
                        Status = c.Int(nullable: false),
                        DateUpdated = c.DateTime(nullable: false),
                        DateCreated = c.DateTime(nullable: false),
                        Active = c.Boolean(nullable: false),
                        Client_Id = c.Int(nullable: false),
                        IndustrySector_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Clients", t => t.Client_Id, cascadeDelete: true)
                .ForeignKey("dbo.IndustrySectors", t => t.IndustrySector_Id, cascadeDelete: true)
                .Index(t => t.Client_Id)
                .Index(t => t.IndustrySector_Id);
            
            CreateTable(
                "dbo.Clients",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Code = c.String(nullable: false),
                        DateValidFrom = c.DateTime(),
                        Status = c.Int(nullable: false),
                        AccountManagerId = c.Int(nullable: false),
                        CustomerId = c.Int(nullable: false),
                        DateUpdated = c.DateTime(nullable: false),
                        DateCreated = c.DateTime(nullable: false),
                        Active = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("Client.Users", t => t.AccountManagerId, cascadeDelete: true)
                .ForeignKey("dbo.Customers", t => t.CustomerId, cascadeDelete: true)
                .Index(t => t.AccountManagerId)
                .Index(t => t.CustomerId);
            
            CreateTable(
                "Client.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
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
                        Customer_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Customers", t => t.Customer_Id)
                .Index(t => t.Email)
                .Index(t => t.Customer_Id);
            
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        UrlName = c.String(nullable: false),
                        DisplayName = c.String(nullable: false),
                        CustomerCode = c.String(nullable: false),
                        DefaultLanguageId = c.Int(nullable: false),
                        DateUpdated = c.DateTime(nullable: false),
                        DateCreated = c.DateTime(nullable: false),
                        Active = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "Client.RoleGroups",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Description = c.String(nullable: false),
                        DateUpdated = c.DateTime(nullable: false),
                        DateCreated = c.DateTime(nullable: false),
                        Active = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "Client.Roles",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Description = c.String(nullable: false),
                        DateUpdated = c.DateTime(nullable: false),
                        DateCreated = c.DateTime(nullable: false),
                        Active = c.Boolean(nullable: false),
                        RoleGroup_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("Client.RoleGroups", t => t.RoleGroup_Id, cascadeDelete: true)
                .Index(t => t.RoleGroup_Id);
            
            CreateTable(
                "dbo.IndustrySectors",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        SectorName = c.String(nullable: false),
                        SectorNameForAssessor = c.String(nullable: false),
                        DateUpdated = c.DateTime(nullable: false),
                        DateCreated = c.DateTime(nullable: false),
                        Active = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Languages",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        InvariantCulture = c.String(nullable: false),
                        Locale = c.String(nullable: false),
                        Name = c.String(nullable: false),
                        DateUpdated = c.DateTime(nullable: false),
                        DateCreated = c.DateTime(nullable: false),
                        Active = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.TextResourceIdentifiers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TextResourceCode = c.String(nullable: false),
                        ClientOverridable = c.Boolean(nullable: false),
                        DateUpdated = c.DateTime(nullable: false),
                        DateCreated = c.DateTime(nullable: false),
                        Active = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.TextResources",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        ClientId = c.Int(nullable: false),
                        LanguageId = c.Int(nullable: false),
                        TextResourceIdentifierId = c.Int(nullable: false),
                        ResourceString = c.String(nullable: false),
                        DateUpdated = c.DateTime(nullable: false),
                        DateCreated = c.DateTime(nullable: false),
                        Active = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => new { t.Id, t.ClientId, t.LanguageId, t.TextResourceIdentifierId })
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
                        RoleGroup_Id = c.Int(nullable: false),
                        User_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.RoleGroup_Id, t.User_Id })
                .ForeignKey("Client.RoleGroups", t => t.RoleGroup_Id, cascadeDelete: true)
                .ForeignKey("Client.Users", t => t.User_Id, cascadeDelete: true)
                .Index(t => t.RoleGroup_Id)
                .Index(t => t.User_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.TextResources", "TextResourceIdentifierId", "dbo.TextResourceIdentifiers");
            DropForeignKey("dbo.TextResources", "LanguageId", "dbo.Languages");
            DropForeignKey("dbo.TextResources", "ClientId", "dbo.Clients");
            DropForeignKey("dbo.Brands", "IndustrySector_Id", "dbo.IndustrySectors");
            DropForeignKey("dbo.Brands", "Client_Id", "dbo.Clients");
            DropForeignKey("dbo.Clients", "CustomerId", "dbo.Customers");
            DropForeignKey("dbo.Clients", "AccountManagerId", "Client.Users");
            DropForeignKey("dbo.RoleGroupUsers", "User_Id", "Client.Users");
            DropForeignKey("dbo.RoleGroupUsers", "RoleGroup_Id", "Client.RoleGroups");
            DropForeignKey("Client.Roles", "RoleGroup_Id", "Client.RoleGroups");
            DropForeignKey("Client.Users", "Customer_Id", "dbo.Customers");
            DropIndex("dbo.RoleGroupUsers", new[] { "User_Id" });
            DropIndex("dbo.RoleGroupUsers", new[] { "RoleGroup_Id" });
            DropIndex("dbo.TextResources", new[] { "TextResourceIdentifierId" });
            DropIndex("dbo.TextResources", new[] { "LanguageId" });
            DropIndex("dbo.TextResources", new[] { "ClientId" });
            DropIndex("Client.Roles", new[] { "RoleGroup_Id" });
            DropIndex("Client.Users", new[] { "Customer_Id" });
            DropIndex("Client.Users", new[] { "Email" });
            DropIndex("dbo.Clients", new[] { "CustomerId" });
            DropIndex("dbo.Clients", new[] { "AccountManagerId" });
            DropIndex("dbo.Brands", new[] { "IndustrySector_Id" });
            DropIndex("dbo.Brands", new[] { "Client_Id" });
            DropTable("dbo.RoleGroupUsers");
            DropTable("dbo.TextResources");
            DropTable("dbo.TextResourceIdentifiers");
            DropTable("dbo.Languages");
            DropTable("dbo.IndustrySectors");
            DropTable("Client.Roles");
            DropTable("Client.RoleGroups");
            DropTable("dbo.Customers");
            DropTable("Client.Users");
            DropTable("dbo.Clients");
            DropTable("dbo.Brands");
        }
    }
}
