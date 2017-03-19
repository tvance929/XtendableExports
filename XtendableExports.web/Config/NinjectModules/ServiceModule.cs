using Ninject.Modules;
using XtendableExports.services;
using XTendableExports.Domain.Contracts.Services;

namespace mhd.Aggregator.Registry.Api.Config.NinjectModules
{
    public class ServiceModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IExportService>().To<ExportService>();
            //Bind<IClientRepository>().To<ClientRepository>();
            //Bind<IExportRepository>().To<ExportRepository>();
            //Bind<IPatientRepository>().To<PatientRepository>();
            //Bind<IInsuranceRepository>().To<InsuranceRepository>();
            //Bind<IAccountInsuranceRepository>().To<AccountInsuranceRepository>();
            //Bind<IFacilityRepository>().To<FacilityRepository>();
        }
    }
}
