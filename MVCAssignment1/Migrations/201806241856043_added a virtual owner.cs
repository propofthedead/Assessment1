namespace MVCAssignment1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedavirtualowner : DbMigration
    {
        public override void Up()
        {
            CreateIndex("dbo.Vehicles", "OwnerId");
            AddForeignKey("dbo.Vehicles", "OwnerId", "dbo.Owners", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Vehicles", "OwnerId", "dbo.Owners");
            DropIndex("dbo.Vehicles", new[] { "OwnerId" });
        }
    }
}
