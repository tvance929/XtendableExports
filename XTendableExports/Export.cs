using System;

namespace XTendableExports.Domain
{
    public class Export
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Delimeter { get; set; }
        public string Fields { get; set; }
        public string FileNameFormat { get; set; }
        //TODO Make some sort of expression evaluator list so clients can attach evaluations on whether a row should come back ( ie balance>100 ) 
    }
}
