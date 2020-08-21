namespace GuitarsAndMore.Migrations
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
                        GuitarId = c.Int(nullable: false, identity: true),
                        Brand = c.String(),
                        GuitarType = c.String(),
                        Color = c.String(),
                        Value = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.GuitarId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Guitars");
        }
    }
}
