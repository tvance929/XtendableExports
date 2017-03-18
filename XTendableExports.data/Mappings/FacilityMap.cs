using System.Data.Entity.ModelConfiguration;
using XTendableExports.domain;

namespace XTendableExports.data.Mappings
{
    public class FacilityMap : EntityTypeConfiguration<Facility>
    {
        public FacilityMap(string schema = "dbo")
        {
            ToTable("Facilities", schema);
            HasKey(f => f.Key);
        }
    }
}