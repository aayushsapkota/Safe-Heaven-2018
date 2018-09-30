namespace Safe_Heaven_2018.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialModel3 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Scores", "levelId", "dbo.Levels");
            DropForeignKey("dbo.Scores", "playerId", "dbo.Players");
            DropIndex("dbo.Scores", new[] { "playerId" });
            DropIndex("dbo.Scores", new[] { "levelId" });
            CreateTable(
                "dbo.Logs",
                c => new
                    {
                        logId = c.Int(nullable: false, identity: true),
                        logtime = c.Long(nullable: false),
                        logDecsription = c.String(),
                    })
                .PrimaryKey(t => t.logId);
            
            CreateTable(
                "dbo.Progresses",
                c => new
                    {
                        progressId = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.progressId);
            
            AddColumn("dbo.Levels", "Progress_progressId", c => c.Int());
            AddColumn("dbo.Levels", "Score_scoreId", c => c.Int());
            AddColumn("dbo.Players", "Score_scoreId", c => c.Int());
            CreateIndex("dbo.Levels", "Progress_progressId");
            CreateIndex("dbo.Levels", "Score_scoreId");
            CreateIndex("dbo.Players", "Score_scoreId");
            AddForeignKey("dbo.Levels", "Progress_progressId", "dbo.Progresses", "progressId");
            AddForeignKey("dbo.Levels", "Score_scoreId", "dbo.Scores", "scoreId");
            AddForeignKey("dbo.Players", "Score_scoreId", "dbo.Scores", "scoreId");
            DropColumn("dbo.Scores", "playerId");
            DropColumn("dbo.Scores", "levelId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Scores", "levelId", c => c.Int(nullable: false));
            AddColumn("dbo.Scores", "playerId", c => c.Int(nullable: false));
            DropForeignKey("dbo.Players", "Score_scoreId", "dbo.Scores");
            DropForeignKey("dbo.Levels", "Score_scoreId", "dbo.Scores");
            DropForeignKey("dbo.Levels", "Progress_progressId", "dbo.Progresses");
            DropIndex("dbo.Players", new[] { "Score_scoreId" });
            DropIndex("dbo.Levels", new[] { "Score_scoreId" });
            DropIndex("dbo.Levels", new[] { "Progress_progressId" });
            DropColumn("dbo.Players", "Score_scoreId");
            DropColumn("dbo.Levels", "Score_scoreId");
            DropColumn("dbo.Levels", "Progress_progressId");
            DropTable("dbo.Progresses");
            DropTable("dbo.Logs");
            CreateIndex("dbo.Scores", "levelId");
            CreateIndex("dbo.Scores", "playerId");
            AddForeignKey("dbo.Scores", "playerId", "dbo.Players", "playerId", cascadeDelete: true);
            AddForeignKey("dbo.Scores", "levelId", "dbo.Levels", "levelId", cascadeDelete: true);
        }
    }
}
