using System;

namespace XTendableExports.domain
{
    public class Account
    {
        public Guid Id { get; set; }
        public Guid ClientId { get; set; }
        public string AccountNumber { get; set; }
        public double Balance { get; set; }
        public Guid FaicilityId { get; set; }
        public DateTime AdminDate { get; set; }
        public DateTime DischargeDate { get; set; }
    }
}
