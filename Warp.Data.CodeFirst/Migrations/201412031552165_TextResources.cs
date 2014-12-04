namespace Warp.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TextResources : DbMigration
    {
        public override void Up()
        {
            MoveTable(name: "dbo.Users", newSchema: "Client");
            MoveTable(name: "dbo.RoleGroups", newSchema: "Client");
            MoveTable(name: "dbo.Roles", newSchema: "Client");
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
                        TextResourceId = c.Int(nullable: false, identity: true),
                        ResourceString = c.String(nullable: false),
                        DateUpdated = c.DateTime(nullable: false),
                        DateCreated = c.DateTime(nullable: false),
                        Active = c.Boolean(nullable: false),
                        Client_ClientId = c.Int(),
                        Language_LanguageId = c.Int(),
                        TextResourceIdentifier_TextResourceIdentifierId = c.Int(),
                    })
                .PrimaryKey(t => t.TextResourceId)
                .ForeignKey("dbo.Clients", t => t.Client_ClientId)
                .ForeignKey("dbo.Languages", t => t.Language_LanguageId)
                .ForeignKey("dbo.TextResourceIdentifiers", t => t.TextResourceIdentifier_TextResourceIdentifierId)
                .Index(t => t.Client_ClientId)
                .Index(t => t.Language_LanguageId)
                .Index(t => t.TextResourceIdentifier_TextResourceIdentifierId);
            
            CreateTable(
                "dbo.Languages",
                c => new
                    {
                        LanguageId = c.Int(nullable: false, identity: true),
                        InvariantCulture = c.String(),
                        Locale = c.String(),
                        Name = c.String(),
                        DateUpdated = c.DateTime(nullable: false),
                        DateCreated = c.DateTime(nullable: false),
                        Active = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.LanguageId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.TextResources", "TextResourceIdentifier_TextResourceIdentifierId", "dbo.TextResourceIdentifiers");
            DropForeignKey("dbo.TextResources", "Language_LanguageId", "dbo.Languages");
            DropForeignKey("dbo.TextResources", "Client_ClientId", "dbo.Clients");
            DropIndex("dbo.TextResources", new[] { "TextResourceIdentifier_TextResourceIdentifierId" });
            DropIndex("dbo.TextResources", new[] { "Language_LanguageId" });
            DropIndex("dbo.TextResources", new[] { "Client_ClientId" });
            DropTable("dbo.Languages");
            DropTable("dbo.TextResources");
            DropTable("dbo.TextResourceIdentifiers");
            MoveTable(name: "Client.Roles", newSchema: "dbo");
            MoveTable(name: "Client.RoleGroups", newSchema: "dbo");
            MoveTable(name: "Client.Users", newSchema: "dbo");
        }
    }
}
