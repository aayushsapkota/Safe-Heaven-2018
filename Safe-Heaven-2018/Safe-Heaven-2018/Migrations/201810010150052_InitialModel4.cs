namespace Safe_Heaven_2018.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialModel4 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Levels", "Score_scoreId", "dbo.Scores");
            DropForeignKey("dbo.Players", "Score_scoreId", "dbo.Scores");
            DropIndex("dbo.Levels", new[] { "Score_scoreId" });
            DropIndex("dbo.Players", new[] { "Score_scoreId" });
            AddColumn("dbo.Scores", "Level_levelId", c => c.Int());
            AddColumn("dbo.Scores", "Player_playerId", c => c.Int());
            CreateIndex("dbo.Scores", "Level_levelId");
            CreateIndex("dbo.Scores", "Player_playerId");
            AddForeignKey("dbo.Scores", "Level_levelId", "dbo.Levels", "levelId");
            AddForeignKey("dbo.Scores", "Player_playerId", "dbo.Players", "playerId");
            DropColumn("dbo.Levels", "Score_scoreId");
            DropColumn("dbo.Players", "Score_scoreId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Players", "Score_scoreId", c => c.Int());
            AddColumn("dbo.Levels", "Score_scoreId", c => c.Int());
            DropForeignKey("dbo.Scores", "Player_playerId", "dbo.Players");
            DropForeignKey("dbo.Scores", "Level_levelId", "dbo.Levels");
            DropIndex("dbo.Scores", new[] { "Player_playerId" });
            DropIndex("dbo.Scores", new[] { "Level_levelId" });
            DropColumn("dbo.Scores", "Player_playerId");
            DropColumn("dbo.Scores", "Level_levelId");
            CreateIndex("dbo.Players", "Score_scoreId");
            CreateIndex("dbo.Levels", "Score_scoreId");
            AddForeignKey("dbo.Players", "Score_scoreId", "dbo.Scores", "scoreId");
            AddForeignKey("dbo.Levels", "Score_scoreId", "dbo.Scores", "scoreId");
        }
    }
}
