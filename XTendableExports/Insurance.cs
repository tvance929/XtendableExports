﻿using System;

namespace XTendableExports.Domain
{
    public class Insurance
    {
        public Guid Id { get; set; }
        public string PlanName { get; set; }
        public string Policy { get; set; }
        public string GroupNumber { get; set; }
    }
}
