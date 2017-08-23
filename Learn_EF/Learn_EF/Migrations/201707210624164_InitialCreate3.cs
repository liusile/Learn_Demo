namespace Learn_EF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate3 : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.Student");
            AlterColumn("dbo.Student", "Name", c => c.String());
            AlterColumn("dbo.Student", "Id", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.Student", "Id");
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.Student");
            AlterColumn("dbo.Student", "Id", c => c.Int(nullable: false));
            AlterColumn("dbo.Student", "Name", c => c.String(nullable: false, maxLength: 128));
            AddPrimaryKey("dbo.Student", "Name");
        }
    }
}
