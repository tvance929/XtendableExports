﻿using System;

namespace XTendableExports.domain
{
    public class Account
    {
        public Guid Key { get; set; }
        public Guid ClientId { get; set; }
        public Guid PatientId { get; set; }
        public Guid FacilityId { get; set; }
        public Guid AccountNumber { get; set; }
        public double Balance { get; set; }
        public DateTime AdminDate { get; set; }
        public DateTime DischargeDate { get; set; }
    }
}
