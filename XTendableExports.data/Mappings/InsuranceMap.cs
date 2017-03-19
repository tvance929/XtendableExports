using System.Data.Entity.ModelConfiguration;
using XTendableExports.Domain;

namespace XTendableExports.data.Mappings
{
    public class InsuranceMap : EntityTypeConfiguration<Insurance>
    {
        public InsuranceMap(string schema = "dbo")
        {
            ToTable("Insurances", schema);
            HasKey(i => i.Id);
        }
    }
}