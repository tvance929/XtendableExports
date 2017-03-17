using System;

namespace XTendableExports.domain
{
    public class Account
    {
        public Guid Id { get; set; }
        public Client Client { get; set; }
        public Patient Patient { get; set; }
        public Facility Facility { get; set; }
        public string AccountNumber { get; set; }
        public double Balance { get; set; }
        public DateTime AdminDate { get; set; }
        public DateTime DischargeDate { get; set; }
    }
}
