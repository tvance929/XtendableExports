using System.Data.Entity.ModelConfiguration;
using XTendableExports.domain;

namespace XTendableExports.data.Mappings
{
    public class AccountMap : EntityTypeConfiguration<Account>
    {
        public AccountMap(string schema = "dbo")
        {
            //ToTable("Consumers", schema);
            //HasKey(t => t.AccountKey);
            //Property(t => t.Version).IsRowVersion();

            //this.HasRequired(a => a.Account).WithRequiredDependent();
        }
    }
}