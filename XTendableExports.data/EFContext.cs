using System.Data.Entity;
using XTendableExports.data.Mappings;
using XTendableExports.domain;

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
        //public IDbSet<Consumer> Consumers { get; set; }
        //public IDbSet<ConsumerHistory> ConsumerHistories { get; set; }
        //public IDbSet<InsuranceCarrier> InsuranceCarriers { get; set; }
        //public IDbSet<InsuranceGroup> InsuranceGroups { get; set; }
        //public IDbSet<InsurancePlan> InsurancePlans { get; set; }
        //public IDbSet<PayerType> PayerTypes { get; set; }
        //public IDbSet<SpecialtyGroup> SpecialtyGroups { get; set; }
        //public IDbSet<Specialty> Specialties { get; set; }
        //public IDbSet<SchedulingVendorConfiguration> SchedulingVendorConfigurations { get; set; }
        //public IDbSet<SchedulingVendorConfigurationHistory> SchedulingVendorConfigurationHistories { get; set; }
        //public IDbSet<TrackedRequest> TrackedRequests { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new AccountMap());
            //modelBuilder.Configurations.Add(new ConsumerMap());
            //modelBuilder.Configurations.Add(new ConsumerHistoryMap());
            //modelBuilder.Configurations.Add(new InsuranceGroupMap());
            //modelBuilder.Configurations.Add(new InsuranceCarrierMap());
            //modelBuilder.Configurations.Add(new InsurancePlanMap());
            //modelBuilder.Configurations.Add(new PayerTypeMap());
            //modelBuilder.Configurations.Add(new SpecialtyGroupMap());
            //modelBuilder.Configurations.Add(new SpecialtyMap());
            //modelBuilder.Configurations.Add(new SchedulingVendorConfigurationMap());
            //modelBuilder.Configurations.Add(new SchedulingVendorConfigurationHistoryMap());
            //modelBuilder.Configurations.Add(new TrackedRequestMap());

            base.OnModelCreating(modelBuilder);
        }
    }
}
