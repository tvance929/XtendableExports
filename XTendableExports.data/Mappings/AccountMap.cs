using System.Data.Entity.ModelConfiguration;
using XTendableExports.domain;

namespace XTendableExports.data.Mappings
{
    public class AccountMap : EntityTypeConfiguration<Account>
    {
        public AccountMap(string schema = "dbo")
        {
            ToTable("Accounts", schema);
            HasKey(a => a.Id);
            this.HasRequired(a => a.Client).WithRequiredDependent();
            this.HasRequired(a => a.Patient).WithRequiredDependent();
            this.HasRequired(a => a.Facility).WithRequiredDependent();
        }
    }
}