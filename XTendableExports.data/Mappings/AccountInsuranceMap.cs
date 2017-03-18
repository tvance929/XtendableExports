using System.Data.Entity.ModelConfiguration;
using XTendableExports.domain;

namespace XTendableExports.data.Mappings
{
    public class AccountInsuranceMap : EntityTypeConfiguration<AccountInsurance>
    {
        public AccountInsuranceMap(string schema = "dbo")
        {
            ToTable("AccountInsurance", schema);
            HasKey(a => a.Id);
            this.HasRequired(a => a.Account).WithRequiredDependent();
            this.HasRequired(a => a.Insurance).WithRequiredDependent();
        }
    }
}