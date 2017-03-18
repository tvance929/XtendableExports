using System.Data.Entity.ModelConfiguration;
using XTendableExports.domain;

namespace XTendableExports.data.Mappings
{
    public class FacilityMap : EntityTypeConfiguration<Insurance>
    {
        public FacilityMap(string schema = "dbo")
        {
            ToTable("Facilities", schema);
            HasKey(f => f.Id);
        }
    }
}