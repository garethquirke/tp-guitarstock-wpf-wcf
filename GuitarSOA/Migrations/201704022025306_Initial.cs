namespace GuitarSOA.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Guitars",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Make = c.String(),
                        Model = c.String(),
                        Stock = c.Int(),
                        Year = c.Int(nullable: false),
                        Price = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Guitars");
        }
    }
}
