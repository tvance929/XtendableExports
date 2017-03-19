using System;

namespace XTendableExports.Domain
{
    public class Facility
    {
        public Guid Id { get; set; }
        public string FacilityName { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
    }
}
