namespace Contoso.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class secondIdentity : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Courses", "Departs_Id", "dbo.Departs");
            DropPrimaryKey("dbo.Departs");
            AlterColumn("dbo.Departs", "Id", c => c.Int(nullable: false));
            AddPrimaryKey("dbo.Departs", "Id");
            AddForeignKey("dbo.Courses", "Departs_Id", "dbo.Departs", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Courses", "Departs_Id", "dbo.Departs");
            DropPrimaryKey("dbo.Departs");
            AlterColumn("dbo.Departs", "Id", c => c.Int(nullable: false));
            AddPrimaryKey("dbo.Departs", "Id");
            AddForeignKey("dbo.Courses", "Departs_Id", "dbo.Departs", "Id");
        }
    }
}
