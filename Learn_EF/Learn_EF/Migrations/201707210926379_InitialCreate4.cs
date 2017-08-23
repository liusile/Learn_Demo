namespace Learn_EF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate4 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Province",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Governor_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Governor", t => t.Governor_Id)
                .Index(t => t.Governor_Id);
            
            CreateTable(
                "dbo.City",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Province_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Province", t => t.Province_Id)
                .Index(t => t.Province_Id);
            
            CreateTable(
                "dbo.Governor",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Province", "Governor_Id", "dbo.Governor");
            DropForeignKey("dbo.City", "Province_Id", "dbo.Province");
            DropIndex("dbo.City", new[] { "Province_Id" });
            DropIndex("dbo.Province", new[] { "Governor_Id" });
            DropTable("dbo.Governor");
            DropTable("dbo.City");
            DropTable("dbo.Province");
        }
    }
}
