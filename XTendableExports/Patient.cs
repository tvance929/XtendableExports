using System;

namespace XTendableExports.Domain
{
    public class Patient
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public string SocialSecurityNumber { get; set; }
    }
}
