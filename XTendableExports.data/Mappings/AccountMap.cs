using System.Data.Entity.ModelConfiguration;
using XTendableExports.Domain;

namespace XTendableExports.data.Mappings
{
    public class AccountMap : EntityTypeConfiguration<Account>
    {
        public AccountMap(string schema = "dbo")
        {
            ToTable("Accounts", schema);
            HasKey(a => a.Id);
        }
    }
}