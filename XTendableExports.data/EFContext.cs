using System.Data.Entity;
using XTendableExports.data.Mappings;
using XTendableExports.Domain;

namespace XTendableExports.data
{
    public class EFContext : DbContext
    {
        public EFContext() : base("XtendableSqlServer")
        {
        }

        public EFContext(string connectionStringName) : base(connectionStringName)
        {
        }

        public IDbSet<Account> Accounts { get; set; }
        public IDbSet<AccountInsurance> AccountInsurances { get; set; }
        public IDbSet<Client> Clients { get; set; }
        public IDbSet<Export> Exports { get; set; }
        public IDbSet<Facility> Facilities { get; set; }
        public IDbSet<Insurance> Insurances { get; set; }
        public IDbSet<Patient> Patients { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new AccountMap());
            modelBuilder.Configurations.Add(new AccountInsuranceMap());
            modelBuilder.Configurations.Add(new ClientMap());
            modelBuilder.Configurations.Add(new ExportMap());
            modelBuilder.Configurations.Add(new FacilityMap());
            modelBuilder.Configurations.Add(new InsuranceMap());
            modelBuilder.Configurations.Add(new PatientMap());

            base.OnModelCreating(modelBuilder);
        }
    }
}
