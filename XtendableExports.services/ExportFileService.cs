using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XTendableExports.Domain.Contracts.Services;
using XTendableExports.Domain.Contracts.Repositories;
using System.IO;

namespace XtendableExports.services
{
    public class ExportFileService : IExportFileService
    {
        IExportRepository exportRepository;
        IAccountRepository accountRepository;
        IPatientRepository patientRepository;
        IClientRepository clientRepository;
        IFacilityRepository facilityRepository;
        IInsuranceRepository insuranceRepository;
        IAccountInsuranceRepository accountInsuranceRepository;

        public ExportFileService(IExportRepository exportRepository, IAccountRepository accountRepository, 
            IPatientRepository patientRepository, IClientRepository clientRepository, IFacilityRepository facilityRepository, IInsuranceRepository insuranceRepository, IAccountInsuranceRepository accountInsuranceRepository)
        {
            this.exportRepository = exportRepository;
            this.accountRepository = accountRepository;
            this.patientRepository = patientRepository;
            this.clientRepository = clientRepository;
            this.facilityRepository = facilityRepository;
            this.insuranceRepository = insuranceRepository;
            this.accountRepository = accountRepository;
            this.accountInsuranceRepository = accountInsuranceRepository;
        }

        public async Task<byte[]> GetExportFileAsync(string exportId, string loggedInUserName)
        {
            if (String.IsNullOrWhiteSpace(exportId)) throw new ArgumentNullException(nameof(exportId));
            if (String.IsNullOrWhiteSpace(loggedInUserName)) throw new ArgumentNullException(nameof(loggedInUserName));

            var export = await this.exportRepository.GetAsync(new Guid(exportId));
            
            MemoryStream ms = new MemoryStream();
            TextWriter tw = new StreamWriter(ms);
            tw.WriteLine("Line 1");
            tw.WriteLine("Line 2");
            tw.WriteLine("Line 3");
            tw.Flush();
            var bytes = ms.ToArray();
            ms.Close();

            return bytes;
        }
    }
}
