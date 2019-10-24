namespace Contoso.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddInstructor : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Instuctors",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        HiredDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.People", t => t.Id)
                .Index(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Instuctors", "Id", "dbo.People");
            DropIndex("dbo.Instuctors", new[] { "Id" });
            DropTable("dbo.Instuctors");
        }
    }
}
