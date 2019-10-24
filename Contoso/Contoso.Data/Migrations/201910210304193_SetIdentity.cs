namespace Contoso.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SetIdentity : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Courses", "DepartId", "dbo.Departs");
            DropPrimaryKey("dbo.Departs");
            AlterColumn("dbo.Departs", "Id", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.Departs", "Id");
            AddForeignKey("dbo.Courses", "DepartId", "dbo.Departs", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Courses", "DepartId", "dbo.Departs");
            DropPrimaryKey("dbo.Departs");
            AlterColumn("dbo.Departs", "Id", c => c.Int(nullable: false));
            AddPrimaryKey("dbo.Departs", "Id");
            AddForeignKey("dbo.Courses", "DepartId", "dbo.Departs", "Id", cascadeDelete: true);
        }
    }
}
