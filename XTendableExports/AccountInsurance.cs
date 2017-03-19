using System;

namespace XTendableExports.Domain
{
    public class AccountInsurance
    {
        public Guid Id { get; set; }
        public Guid AccountId { get; set; }
        public Guid InsuranceId { get; set; }
    }
}
