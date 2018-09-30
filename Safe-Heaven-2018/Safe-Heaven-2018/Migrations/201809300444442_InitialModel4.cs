namespace Safe_Heaven_2018.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialModel4 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Pages",
                c => new
                    {
                        pageId = c.Int(nullable: false, identity: true),
                        pageHeading = c.String(),
                        pageSubHeading = c.String(),
                        pageContent1 = c.String(),
                        pageContent2 = c.String(),
                        pageContent3 = c.String(),
                        pageContent4 = c.String(),
                        pageContent5 = c.String(),
                        pageHeading1 = c.String(),
                        pageHeading2 = c.String(),
                        pageHeading3 = c.String(),
                        pageHeading4 = c.String(),
                        pageHeading5 = c.String(),
                        pageHeading6 = c.String(),
                    })
                .PrimaryKey(t => t.pageId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Pages");
        }
    }
}
