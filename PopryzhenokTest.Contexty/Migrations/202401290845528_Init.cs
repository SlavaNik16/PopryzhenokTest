namespace PopryzhenokTest.Contexty.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.TAgents",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Type = c.Int(nullable: false),
                        Phone = c.String(),
                        Logotip = c.String(),
                        Address = c.String(),
                        Prioritet = c.Int(nullable: false),
                        DirectorName = c.String(),
                        INN = c.String(),
                        KPP = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.TSales",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ProductId = c.Int(nullable: false),
                        AgentId = c.Int(nullable: false),
                        Relize = c.DateTimeOffset(nullable: false, precision: 7),
                        Count = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.TAgents", t => t.AgentId, cascadeDelete: true)
                .ForeignKey("dbo.TProducts", t => t.ProductId, cascadeDelete: true)
                .Index(t => t.ProductId)
                .Index(t => t.AgentId);
            
            CreateTable(
                "dbo.TProducts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Type = c.Int(nullable: false),
                        Articul = c.String(),
                        Count = c.Int(nullable: false),
                        Number = c.Int(nullable: false),
                        MinPriceAgent = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.TSales", "ProductId", "dbo.TProducts");
            DropForeignKey("dbo.TSales", "AgentId", "dbo.TAgents");
            DropIndex("dbo.TSales", new[] { "AgentId" });
            DropIndex("dbo.TSales", new[] { "ProductId" });
            DropTable("dbo.TProducts");
            DropTable("dbo.TSales");
            DropTable("dbo.TAgents");
        }
    }
}
