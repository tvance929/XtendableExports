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
            var delimeter = export.Delimeter;
            var fields = ParseFields(export.Fields);

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

        private List<TablesWithColumns> ParseFields(string encodedFields)
        {
            var tablesWithColumnsString = encodedFields.Split('~');
            var tablesWithColumnsList = new List<TablesWithColumns>();

            foreach (var table in tablesWithColumnsString)
            {
                var tableWithColumns = new TablesWithColumns();
                tableWithColumns.table = table.Split('^')[0];

                foreach (var column in table.Split('^')[1].Split(','))
                {
                    if (column.Contains('*'))
                    {
                        tableWithColumns.substrings.Add(column);
                        tableWithColumns.columns.Add(column.Split('*')[0]);
                    }
                    else
                    {
                        tableWithColumns.columns.Add(column);
                    }
                }
                tablesWithColumnsList.Add(tableWithColumns);
            }
            return tablesWithColumnsList;
        }
    }

    internal class TablesWithColumns
    {
        public string table { get; set; }
        public List<string> columns { get; set; }
        public List<string> substrings { get; set; }

        public TablesWithColumns()
        {
            columns = new List<string>();
            substrings = new List<string>();
        }
    }
}
