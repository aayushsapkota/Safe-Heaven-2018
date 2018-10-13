namespace Safe_Heaven_2018.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class allowedTimeAdded : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.allowedTimes",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        time = c.DateTime(nullable: false),
                        playerId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Players", t => t.playerId, cascadeDelete: true)
                .Index(t => t.playerId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.allowedTimes", "playerId", "dbo.Players");
            DropIndex("dbo.allowedTimes", new[] { "playerId" });
            DropTable("dbo.allowedTimes");
        }
    }
}
