namespace PaddleApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NewApplication : DbMigration
    {
        public override void Up()
        {
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Bookings", "courtId", "dbo.Courts");
            DropForeignKey("dbo.Courts", "locID", "dbo.Paddles");
            DropIndex("dbo.Courts", new[] { "locID" });
            DropIndex("dbo.Bookings", new[] { "courtId" });
            DropTable("dbo.Courts");
            DropTable("dbo.Bookings");
        }
    }
}
