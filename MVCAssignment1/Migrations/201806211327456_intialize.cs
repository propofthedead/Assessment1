namespace MVCAssignment1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class intialize : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Owners",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        State = c.String(),
                        City = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Owners");
        }
    }
}
