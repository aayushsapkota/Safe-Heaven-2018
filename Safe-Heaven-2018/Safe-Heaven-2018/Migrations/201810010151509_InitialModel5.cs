namespace Safe_Heaven_2018.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialModel5 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Levels", "Progress_progressId", "dbo.Progresses");
            DropIndex("dbo.Levels", new[] { "Progress_progressId" });
            AddColumn("dbo.Progresses", "Level_levelId", c => c.Int());
            CreateIndex("dbo.Progresses", "Level_levelId");
            AddForeignKey("dbo.Progresses", "Level_levelId", "dbo.Levels", "levelId");
            DropColumn("dbo.Levels", "Progress_progressId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Levels", "Progress_progressId", c => c.Int());
            DropForeignKey("dbo.Progresses", "Level_levelId", "dbo.Levels");
            DropIndex("dbo.Progresses", new[] { "Level_levelId" });
            DropColumn("dbo.Progresses", "Level_levelId");
            CreateIndex("dbo.Levels", "Progress_progressId");
            AddForeignKey("dbo.Levels", "Progress_progressId", "dbo.Progresses", "progressId");
        }
    }
}
