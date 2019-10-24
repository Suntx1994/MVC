﻿namespace Contoso.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class courses : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Courses",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Credits = c.Int(nullable: false),
                        DepartmentId = c.Int(nullable: false),
                        CreatedDate = c.DateTime(nullable: false),
                        CreatedBy = c.String(),
                        UpdatedDate = c.DateTime(nullable: false),
                        UpdatedBy = c.String(),
                        Departs_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Departs", t => t.Departs_Id)
                .Index(t => t.Departs_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Courses", "Departs_Id", "dbo.Departs");
            DropIndex("dbo.Courses", new[] { "Departs_Id" });
            DropTable("dbo.Courses");
        }
    }
}
