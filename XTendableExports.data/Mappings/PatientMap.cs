using System.Data.Entity.ModelConfiguration;
using XTendableExports.domain;

namespace XTendableExports.data.Mappings
{
    public class PatientMap : EntityTypeConfiguration<Patient>
    {
        public PatientMap(string schema = "dbo")
        {
            ToTable("Patients", schema);
            HasKey(p => p.Key);
        }
    }
}