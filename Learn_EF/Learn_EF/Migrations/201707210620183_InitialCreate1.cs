namespace Learn_EF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate1 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Student", "Teacher_Id", "dbo.Teacher");
            DropIndex("dbo.Student", new[] { "Teacher_Id" });
            RenameColumn(table: "dbo.Student", name: "Teacher_Id", newName: "TeacherId");
            AlterColumn("dbo.Student", "TeacherId", c => c.Int(nullable: false));
            CreateIndex("dbo.Student", "TeacherId");
            AddForeignKey("dbo.Student", "TeacherId", "dbo.Teacher", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Student", "TeacherId", "dbo.Teacher");
            DropIndex("dbo.Student", new[] { "TeacherId" });
            AlterColumn("dbo.Student", "TeacherId", c => c.Int());
            RenameColumn(table: "dbo.Student", name: "TeacherId", newName: "Teacher_Id");
            CreateIndex("dbo.Student", "Teacher_Id");
            AddForeignKey("dbo.Student", "Teacher_Id", "dbo.Teacher", "Id");
        }
    }
}
