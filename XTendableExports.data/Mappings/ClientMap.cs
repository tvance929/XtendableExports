using System.Data.Entity.ModelConfiguration;
using XTendableExports.Domain;

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