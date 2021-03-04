using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace ComputerSelection.Data
{
    public class ComputerMap
    {
        public ComputerMap(EntityTypeBuilder<Computers> entityBuilder)
        {
            entityBuilder.HasKey(t => t.Model);
            entityBuilder.Property(t => t.DisplayCard);
            entityBuilder.Property(t => t.ProcessorType);
            entityBuilder.Property(t => t.Ram);
            entityBuilder.Property(t => t.ProcessorGeneration);
            entityBuilder.Property(t => t.ProcessorModel);
            entityBuilder.Property(t => t.OS);
            entityBuilder.Property(t => t.Resulation);
            entityBuilder.Property(t => t.ScreenSize);
            entityBuilder.Property(t => t.SSD_Capacity);
            entityBuilder.Property(t => t.Color);
        }
    }
}
