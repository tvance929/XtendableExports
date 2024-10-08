﻿using System.Data.Entity.ModelConfiguration;
using XTendableExports.Domain;

namespace XTendableExports.data.Mappings
{
    public class ExportMap : EntityTypeConfiguration<Export>
    {
        public ExportMap(string schema = "dbo")
        {
            ToTable("Exports", schema);
            HasKey(e => e.Id);
        }
    }
}