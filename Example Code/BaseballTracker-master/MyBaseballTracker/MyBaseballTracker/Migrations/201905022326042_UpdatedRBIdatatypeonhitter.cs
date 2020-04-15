namespace MyBaseballTracker.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdatedRBIdatatypeonhitter : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Hitters", "BattingAverage", c => c.Double(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Hitters", "BattingAverage", c => c.Int(nullable: false));
        }
    }
}
