using System.Data.Entity.ModelConfiguration;
using XTendableExports.domain;

namespace XTendableExports.data.Mappings
{
    public class ClientMap : EntityTypeConfiguration<Client>
    {
        public ClientMap(string schema = "dbo")
        {
            ToTable("Clients", schema);
            HasKey(c => c.Id);
        }
    }
}