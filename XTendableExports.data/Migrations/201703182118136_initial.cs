namespace XTendableExports.data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Accounts", "Key", "dbo.Clients");
            DropForeignKey("dbo.Accounts", "Key", "dbo.Facilities");
            DropForeignKey("dbo.Accounts", "Key", "dbo.Patients");
            DropForeignKey("dbo.AccountInsurance", "Key", "dbo.Accounts");
            DropForeignKey("dbo.AccountInsurance", "Key", "dbo.Insurances");
            DropIndex("dbo.AccountInsurance", new[] { "Key" });
            DropIndex("dbo.Accounts", new[] { "Key" });
            AddColumn("dbo.AccountInsurance", "AccountId", c => c.Guid(nullable: false));
            AddColumn("dbo.AccountInsurance", "InsuranceId", c => c.Guid(nullable: false));
            AddColumn("dbo.Accounts", "ClientId", c => c.Guid(nullable: false));
            AddColumn("dbo.Accounts", "PatientId", c => c.Guid(nullable: false));
            AddColumn("dbo.Accounts", "FacilityId", c => c.Guid(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Accounts", "FacilityId");
            DropColumn("dbo.Accounts", "PatientId");
            DropColumn("dbo.Accounts", "ClientId");
            DropColumn("dbo.AccountInsurance", "InsuranceId");
            DropColumn("dbo.AccountInsurance", "AccountId");
            CreateIndex("dbo.Accounts", "Key");
            CreateIndex("dbo.AccountInsurance", "Key");
            AddForeignKey("dbo.AccountInsurance", "Key", "dbo.Insurances", "Key");
            AddForeignKey("dbo.AccountInsurance", "Key", "dbo.Accounts", "Key");
            AddForeignKey("dbo.Accounts", "Key", "dbo.Patients", "Key");
            AddForeignKey("dbo.Accounts", "Key", "dbo.Facilities", "Key");
            AddForeignKey("dbo.Accounts", "Key", "dbo.Clients", "Key");
        }
    }
}
