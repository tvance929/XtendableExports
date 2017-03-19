using System;
using System.ComponentModel.DataAnnotations;

namespace XtendableExports.Models
{
    public class ExportViewModel
    {
        public Guid Id { get; set; }

        [Required]
        public string Delimeter { get; set; }

        [Required]
        public string Fields { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string FileNameFormat { get; set; }
    }
}