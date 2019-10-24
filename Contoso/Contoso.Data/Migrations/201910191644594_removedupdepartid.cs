namespace Contoso.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class removedupdepartid : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Courses", "Departs_Id", "dbo.Departs");
            DropIndex("dbo.Courses", new[] { "Departs_Id" });
            RenameColumn(table: "dbo.Courses", name: "Departs_Id", newName: "DepartId");
            AlterColumn("dbo.Courses", "DepartId", c => c.Int(nullable: false));
            CreateIndex("dbo.Courses", "DepartId");
            AddForeignKey("dbo.Courses", "DepartId", "dbo.Departs", "Id", cascadeDelete: true);
            DropColumn("dbo.Courses", "DepartmentId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Courses", "DepartmentId", c => c.Int(nullable: false));
            DropForeignKey("dbo.Courses", "DepartId", "dbo.Departs");
            DropIndex("dbo.Courses", new[] { "DepartId" });
            AlterColumn("dbo.Courses", "DepartId", c => c.Int());
            RenameColumn(table: "dbo.Courses", name: "DepartId", newName: "Departs_Id");
            CreateIndex("dbo.Courses", "Departs_Id");
            AddForeignKey("dbo.Courses", "Departs_Id", "dbo.Departs", "Id");
        }
    }
}
