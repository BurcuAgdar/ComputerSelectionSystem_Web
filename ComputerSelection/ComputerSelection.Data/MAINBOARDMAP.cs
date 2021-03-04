using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ComputerSelection.Data
{
    public class MAINBOARDMAP
    {
        public MAINBOARDMAP(EntityTypeBuilder<MainBoard> entityBuilder)
        {
            entityBuilder.HasKey(t => t.Model);
            entityBuilder.Property(t => t.ProcessorModel);
            entityBuilder.Property(t => t.ProcessorSupport);
            entityBuilder.Property(t => t.Chipset);
            entityBuilder.Property(t => t.SocketStructure);
            entityBuilder.Property(t => t.RamType);
            entityBuilder.Property(t => t.M2_Slot);
            entityBuilder.Property(t => t.CasingStructure);
        }
    }
}
