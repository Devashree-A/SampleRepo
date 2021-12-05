namespace PaddleApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateLocTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Paddles",
                c => new
                    {
                        loc_id = c.Int(nullable: false, identity: true),
                        location = c.String(),
                    })
                .PrimaryKey(t => t.loc_id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Paddles");
        }
    }
}
