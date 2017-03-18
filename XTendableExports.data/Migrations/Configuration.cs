namespace XTendableExports.data.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using domain;

    internal sealed class Configuration : DbMigrationsConfiguration<XTendableExports.data.EFContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(XTendableExports.data.EFContext context)
        {
            var generalHospital = new Client { Key = new Guid(), Name = "General Hospital", UserName = "GeneralHospital@test.com" };
            var veteranHospital = new Client { Key = new Guid(), Name = "Veteran Hospital", UserName = "VeteranHospital@test.com" };
            var fastPace = new Facility { Key = new Guid(), FacilityName = "Fast Pace", AddressLine1 = "123 Street", AddressLine2 = "Suite 10", City = "Fairview", State = "TN", Zip = "37062" };
            var quickMed = new Facility { Key = new Guid(), FacilityName = "Quick Med", AddressLine1 = "789 Avenue", AddressLine2 = "Suite 11", City = "Bellevue", State = "TN", Zip = "37205" };
            var toddVance = new Patient { Key = new Guid(), FirstName = "Todd", LastName = "Vance", MiddleName = "Eric", SocialSecurityNumber = "123-45-6789" };
            var janeDoe = new Patient { Key = new Guid(), FirstName = "Jane", LastName = "Doe" };
            var americanFamily = new Insurance { Key = new Guid(), GroupNumber = "123", PlanName = "Gold Choice", Policy = "1234" };
            var blueCrossBS = new Insurance { Key = new Guid(), GroupNumber = "456", PlanName = "Generic plan", Policy = "4567" };
            var account1 = new Account { Key = new Guid(), AccountNumber = new Guid(), AdminDate = new DateTime(2015, 4, 1), Balance = 200.00, ClientId = generalHospital.Key, DischargeDate = new DateTime(2015, 6, 7), FacilityId = fastPace.Key, PatientId = toddVance.Key };
            var account2 = new Account { Key = new Guid(), AccountNumber = new Guid(), AdminDate = new DateTime(2015, 4, 1), Balance = 200.00, ClientId = generalHospital.Key, DischargeDate = new DateTime(2015, 6, 7), FacilityId = fastPace.Key, PatientId = toddVance.Key};
            var account3 = new Account { Key = new Guid(), AccountNumber = new Guid(), AdminDate = new DateTime(2016, 7, 2), Balance = 100.00, ClientId = veteranHospital.Key, DischargeDate = new DateTime(2016, 8, 1), FacilityId = quickMed.Key, PatientId = toddVance.Key };
            var account4 = new Account { Key = new Guid(), AccountNumber = new Guid(), AdminDate = new DateTime(2017, 1, 1), Balance = 20000.00, ClientId = generalHospital.Key, DischargeDate = new DateTime(2017, 1, 1), FacilityId = fastPace.Key, PatientId = janeDoe.Key };
            var account5 = new Account { Key = new Guid(), AccountNumber = new Guid(), AdminDate = new DateTime(2016, 12, 11), Balance = 2120.00, ClientId = veteranHospital.Key, DischargeDate = new DateTime(2016, 12, 10), FacilityId = quickMed.Key, PatientId = janeDoe.Key };

            context.Patients.AddOrUpdate(toddVance, janeDoe);
            context.Clients.AddOrUpdate(generalHospital, veteranHospital);
            context.Facilities.AddOrUpdate(fastPace, quickMed);
            context.Insurances.AddOrUpdate(americanFamily, blueCrossBS);
            context.Accounts.AddOrUpdate(account1, account2, account3, account4, account5);

            context.AccountInsurances.AddOrUpdate(
                new AccountInsurance { Key = new Guid(), AccountId = account1.Key, InsuranceId = americanFamily.Key },
                new AccountInsurance { Key = new Guid(), AccountId = account2.Key, InsuranceId = blueCrossBS.Key },
                new AccountInsurance { Key = new Guid(), AccountId = account3.Key, InsuranceId = americanFamily.Key },
                new AccountInsurance { Key = new Guid(), AccountId = account4.Key, InsuranceId = blueCrossBS.Key },
                new AccountInsurance { Key = new Guid(), AccountId = account5.Key, InsuranceId = americanFamily.Key }
                );
        }
    }
}
