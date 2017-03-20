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
            Bind<IExportFileService>().To<ExportFileService>();
        }
    }
}
