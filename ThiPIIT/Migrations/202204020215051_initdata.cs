namespace ThiPIIT.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initdata : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Coins",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        BaseAsset = c.String(),
                        QuoteAsset = c.String(),
                        LastPrice = c.String(),
                        Volumn24h = c.Int(nullable: false),
                        Status = c.Int(nullable: false),
                        MarketId_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Markets", t => t.MarketId_Id)
                .Index(t => t.MarketId_Id);
            
            CreateTable(
                "dbo.Markets",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                        Status = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Coins", "MarketId_Id", "dbo.Markets");
            DropIndex("dbo.Coins", new[] { "MarketId_Id" });
            DropTable("dbo.Markets");
            DropTable("dbo.Coins");
        }
    }
}
