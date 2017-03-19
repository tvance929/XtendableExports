using System.Data.Entity.ModelConfiguration;
using XTendableExports.Domain;

namespace XTendableExports.data.Mappings
{
    public class AccountInsuranceMap : EntityTypeConfiguration<AccountInsurance>
    {
        public AccountInsuranceMap(string schema = "dbo")
        {
            ToTable("AccountInsurance", schema);
            HasKey(a => a.Id);
        }
    }
}