using Ninject.Modules;
using XTendableExports.data.Repositories;
using XTendableExports.Domain.Contracts.Repositories;

namespace mhd.Aggregator.Registry.Api.Config.NinjectModules
{
    public class RepositoryModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IAccountRepository>().To<AccountRepository>();
            Bind<IClientRepository>().To<ClientRepository>();
            Bind<IExportRepository>().To<ExportRepository>();
            Bind<IPatientRepository>().To<PatientRepository>();
            Bind<IInsuranceRepository>().To<InsuranceRepository>();
            Bind<IAccountInsuranceRepository>().To<AccountInsuranceRepository>();
            Bind<IFacilityRepository>().To<FacilityRepository>();
        }
    }
}
