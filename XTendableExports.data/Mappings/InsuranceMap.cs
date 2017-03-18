using System.Data.Entity.ModelConfiguration;
using XTendableExports.domain;

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