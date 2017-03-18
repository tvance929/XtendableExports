using System;

namespace XTendableExports.domain
{
    public class Patient
    {
        public Guid Key { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public string SocialSecurityNumber { get; set; }
    }
}
