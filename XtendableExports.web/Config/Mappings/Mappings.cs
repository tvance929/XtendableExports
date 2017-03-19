using AutoMapper;
using XtendableExports.Models;
using XTendableExports.Domain;

namespace XtendableExports.Config.Mappings
{
    public class Mappings : Profile
    {
        protected override void Configure()
        {
            MapExportModels();
            //MapInsuranceCarrierModels();
            //MapSpecialtyModels();
            //MapConsumerModels();
            //MapSchedulingVendorConfigurationModels();
            //MapResourceModels();
        }

        private void MapExportModels()
        {
            CreateMap<ExportViewModel, Export>();
            CreateMap<Export, ExportViewModel>();
        }

        //private void MapInsuranceCarrierModels()
        //{
        //    CreateMap<Shared.DTOs.InsuranceCarrier, Web.Admin.Models.InsuranceCarrier>();
        //    CreateMap<Web.Admin.Models.InsuranceCarrier, Shared.DTOs.InsuranceCarrier>();
        //}

        //private void MapSpecialtyModels()
        //{
        //    CreateMap<Shared.DTOs.Specialty, Web.Admin.Models.Specialty>();
        //    CreateMap<Web.Admin.Models.Specialty, Shared.DTOs.Specialty>();
        //    CreateMap<Shared.DTOs.SpecialtyGroup, Web.Admin.Models.SpecialtyGroup>();
        //    CreateMap<Web.Admin.Models.SpecialtyGroup, Shared.DTOs.SpecialtyGroup>();
        //}

        //private void MapConsumerModels()
        //{
        //    CreateMap<Shared.DTOs.Consumer, Web.Admin.Models.Consumer>();
        //    CreateMap<Web.Admin.Models.Consumer, Shared.DTOs.Consumer>();
        //}

        //private void MapSchedulingVendorConfigurationModels()
        //{
        //    CreateMap<Shared.DTOs.SchedulingVendorConfiguration, Web.Admin.Models.SchedulingVendorConfiguration>();
        //    CreateMap<Web.Admin.Models.SchedulingVendorConfiguration, Shared.DTOs.SchedulingVendorConfiguration>();
        //}

        //private void MapResourceModels()
        //{
        //    CreateMap<Shared.DTOs.Resource, Web.Admin.Models.Resource>();
        //    CreateMap<Web.Admin.Models.Resource, Shared.DTOs.Resource>();
        //}
    }
}