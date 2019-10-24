namespace Contoso.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class modifypeople : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.People", "Email", c => c.String());
            AddColumn("dbo.People", "Phone", c => c.Int());
            AddColumn("dbo.People", "Address1", c => c.String());
            AddColumn("dbo.People", "Address2", c => c.String());
            AddColumn("dbo.People", "UnitOrApartmentNumber", c => c.Int());
            AddColumn("dbo.People", "City", c => c.String());
            AddColumn("dbo.People", "State", c => c.String());
            AddColumn("dbo.People", "ZipCode", c => c.Int());
            AddColumn("dbo.People", "PassWord", c => c.String());
            AddColumn("dbo.People", "Salt", c => c.String());
            AddColumn("dbo.People", "IsLocked", c => c.Boolean(nullable: false));
            AddColumn("dbo.People", "LastLockedDateTime", c => c.DateTime());
            AddColumn("dbo.People", "FailedAttempts", c => c.Int());
            AddColumn("dbo.People", "CreatedDate", c => c.DateTime());
            AddColumn("dbo.People", "CreatedBy", c => c.String());
            AddColumn("dbo.People", "UpdatedDate", c => c.DateTime());
            AddColumn("dbo.People", "UpdatedBy", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.People", "UpdatedBy");
            DropColumn("dbo.People", "UpdatedDate");
            DropColumn("dbo.People", "CreatedBy");
            DropColumn("dbo.People", "CreatedDate");
            DropColumn("dbo.People", "FailedAttempts");
            DropColumn("dbo.People", "LastLockedDateTime");
            DropColumn("dbo.People", "IsLocked");
            DropColumn("dbo.People", "Salt");
            DropColumn("dbo.People", "PassWord");
            DropColumn("dbo.People", "ZipCode");
            DropColumn("dbo.People", "State");
            DropColumn("dbo.People", "City");
            DropColumn("dbo.People", "UnitOrApartmentNumber");
            DropColumn("dbo.People", "Address2");
            DropColumn("dbo.People", "Address1");
            DropColumn("dbo.People", "Phone");
            DropColumn("dbo.People", "Email");
        }
    }
}
