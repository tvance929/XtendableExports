using System.Data.Entity.ModelConfiguration;
using XTendableExports.Domain;

namespace XTendableExports.data.Mappings
{
    public class FacilityMap : EntityTypeConfiguration<Facility>
    {
        public FacilityMap(string schema = "dbo")
        {
            ToTable("Facilities", schema);
            HasKey(f => f.Id);
        }
    }
}