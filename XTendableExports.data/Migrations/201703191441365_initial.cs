namespace XTendableExports.data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AccountInsurance",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        AccountId = c.Guid(nullable: false),
                        InsuranceId = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Accounts",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        ClientId = c.Guid(nullable: false),
                        PatientId = c.Guid(nullable: false),
                        FacilityId = c.Guid(nullable: false),
                        AccountNumber = c.Guid(nullable: false),
                        Balance = c.Double(nullable: false),
                        AdminDate = c.DateTime(nullable: false),
                        DischargeDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Clients",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Name = c.String(),
                        UserName = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Exports",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Delimeter = c.String(),
                        Fields = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Facilities",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        FacilityName = c.String(),
                        AddressLine1 = c.String(),
                        AddressLine2 = c.String(),
                        City = c.String(),
                        State = c.String(),
                        Zip = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Insurances",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        PlanName = c.String(),
                        Policy = c.String(),
                        GroupNumber = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Patients",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        FirstName = c.String(),
                        LastName = c.String(),
                        MiddleName = c.String(),
                        SocialSecurityNumber = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Patients");
            DropTable("dbo.Insurances");
            DropTable("dbo.Facilities");
            DropTable("dbo.Exports");
            DropTable("dbo.Clients");
            DropTable("dbo.Accounts");
            DropTable("dbo.AccountInsurance");
        }
    }
}
