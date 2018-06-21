namespace MVCAssignment1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedvehicle : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Vehicles",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        OwnerId = c.Int(nullable: false),
                        Vin = c.String(),
                        Model = c.String(),
                        Make = c.String(),
                        Year = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Vehicles");
        }
    }
}
