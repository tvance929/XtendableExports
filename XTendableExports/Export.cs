using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XTendableExports.domain
{
    public class Export
    {
        public Guid Id { get; set; }
        public string Delimeter { get; set; }
        public string Fields { get; set; }
    }
}
