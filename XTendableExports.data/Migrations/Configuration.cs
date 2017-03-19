namespace XTendableExports.data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    using Domain;

    internal sealed class Configuration : DbMigrationsConfiguration<EFContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(EFContext context)
        {
            var generalHospital = new Client { Id = Guid.NewGuid(), Name = "General Hospital", UserName = "GeneralHospital@test.com" };
            var veteranHospital = new Client { Id = Guid.NewGuid(), Name = "Veteran Hospital", UserName = "VeteranHospital@test.com" };
            var fastPace = new Facility { Id = Guid.NewGuid(), FacilityName = "Fast Pace", AddressLine1 = "123 Street", AddressLine2 = "Suite 10", City = "Fairview", State = "TN", Zip = "37062" };
            var quickMed = new Facility { Id = Guid.NewGuid(), FacilityName = "Quick Med", AddressLine1 = "789 Avenue", AddressLine2 = "Suite 11", City = "Bellevue", State = "TN", Zip = "37205" };
            var toddVance = new Patient { Id = Guid.NewGuid(), FirstName = "Todd", LastName = "Vance", MiddleName = "Eric", SocialSecurityNumber = "123-45-6789" };
            var janeDoe = new Patient { Id = Guid.NewGuid(), FirstName = "Jane", LastName = "Doe" };
            var americanFamily = new Insurance { Id = Guid.NewGuid(), GroupNumber = "123", PlanName = "Gold Choice", Policy = "1234" };
            var blueCrossBS = new Insurance { Id = Guid.NewGuid(), GroupNumber = "456", PlanName = "Generic plan", Policy = "4567" };
            var account1 = new Account { Id = Guid.NewGuid(), AccountNumber = Guid.NewGuid(), AdminDate = new DateTime(2015, 4, 1), Balance = 200.00, ClientId = generalHospital.Id, DischargeDate = new DateTime(2015, 6, 7), FacilityId = fastPace.Id, PatientId = toddVance.Id };
            var account2 = new Account { Id = Guid.NewGuid(), AccountNumber = Guid.NewGuid(), AdminDate = new DateTime(2015, 4, 1), Balance = 200.00, ClientId = generalHospital.Id, DischargeDate = new DateTime(2015, 6, 7), FacilityId = fastPace.Id, PatientId = toddVance.Id };
            var account3 = new Account { Id = Guid.NewGuid(), AccountNumber = Guid.NewGuid(), AdminDate = new DateTime(2016, 7, 2), Balance = 100.00, ClientId = veteranHospital.Id, DischargeDate = new DateTime(2016, 8, 1), FacilityId = quickMed.Id, PatientId = toddVance.Id };
            var account4 = new Account { Id = Guid.NewGuid(), AccountNumber = Guid.NewGuid(), AdminDate = new DateTime(2017, 1, 1), Balance = 20000.00, ClientId = generalHospital.Id, DischargeDate = new DateTime(2017, 1, 1), FacilityId = fastPace.Id, PatientId = janeDoe.Id };
            var account5 = new Account { Id = Guid.NewGuid(), AccountNumber = Guid.NewGuid(), AdminDate = new DateTime(2016, 12, 11), Balance = 2120.00, ClientId = veteranHospital.Id, DischargeDate = new DateTime(2016, 12, 10), FacilityId = quickMed.Id, PatientId = janeDoe.Id };

            context.Patients.AddOrUpdate(toddVance, janeDoe);
            context.Clients.AddOrUpdate(generalHospital, veteranHospital);
            context.Facilities.AddOrUpdate(fastPace, quickMed);
            context.Insurances.AddOrUpdate(americanFamily, blueCrossBS);
            context.Accounts.AddOrUpdate(account1, account2, account3, account4, account5);

            context.AccountInsurances.AddOrUpdate(
                new AccountInsurance { Id = Guid.NewGuid(), AccountId = account1.Id, InsuranceId = americanFamily.Id },
                new AccountInsurance { Id = Guid.NewGuid(), AccountId = account2.Id, InsuranceId = blueCrossBS.Id },
                new AccountInsurance { Id = Guid.NewGuid(), AccountId = account3.Id, InsuranceId = americanFamily.Id },
                new AccountInsurance { Id = Guid.NewGuid(), AccountId = account4.Id, InsuranceId = blueCrossBS.Id },
                new AccountInsurance { Id = Guid.NewGuid(), AccountId = account5.Id, InsuranceId = americanFamily.Id }
                );
        }
    }
}
