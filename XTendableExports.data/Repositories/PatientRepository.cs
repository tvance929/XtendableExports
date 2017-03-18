using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using XTendableExports.domain;
using XTendableExports.domain.Contracts.Repositories;

namespace XTendableExports.data.Repositories
{
    public class PatientRepository : IPatientRepository
    {
        public async Task AddAsync(Patient patient)
        {
            using (var context = new EFContext())
            {
                context.Patients.Add(patient);

                await context.SaveChangesAsync();
            }
        }

        public async Task<IEnumerable<Patient>> GetAllAsync()
        {
            using (var context = new EFContext())
            {
                var patients = context.Patients;
                return await patients.ToListAsync();
            }
        }

        public async Task<Patient> GetAsync(Guid id)
        {
            using (var context = new EFContext())
            {
                var patient = await context.Patients.Where(a => a.Id == id).FirstOrDefaultAsync();
                return patient;
            }
        }
    }
}