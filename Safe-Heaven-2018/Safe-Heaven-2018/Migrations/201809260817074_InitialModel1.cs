namespace Safe_Heaven_2018.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialModel1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Scores",
                c => new
                    {
                        playerId = c.Int(nullable: false),
                        levelId = c.Int(nullable: false),
                        scoreId = c.Int(nullable: false, identity: true),
                        scoreValue = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.scoreId)
                .ForeignKey("dbo.Levels", t => t.levelId, cascadeDelete: true)
                .ForeignKey("dbo.Players", t => t.playerId, cascadeDelete: true)
                .Index(t => t.playerId)
                .Index(t => t.levelId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Scores", "playerId", "dbo.Players");
            DropForeignKey("dbo.Scores", "levelId", "dbo.Levels");
            DropIndex("dbo.Scores", new[] { "levelId" });
            DropIndex("dbo.Scores", new[] { "playerId" });
            DropTable("dbo.Scores");
        }
    }
}
