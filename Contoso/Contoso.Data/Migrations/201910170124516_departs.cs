namespace Contoso.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class departs : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Departs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Budget = c.Decimal(nullable: false, precision: 18, scale: 2),
                        StartDate = c.DateTime(nullable: false),
                        InstructorId = c.Int(nullable: false),
                        RowVersion = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Instuctors", t => t.InstructorId)
                .Index(t => t.InstructorId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Departs", "InstructorId", "dbo.Instuctors");
            DropIndex("dbo.Departs", new[] { "InstructorId" });
            DropTable("dbo.Departs");
        }
    }
}
