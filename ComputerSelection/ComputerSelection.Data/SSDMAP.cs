using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ComputerSelection.Data
{
    public class SSDMAP
    {
        public SSDMAP(EntityTypeBuilder<SSD> entityBuilder)
        {

            entityBuilder.HasKey(t => t.Model);
            entityBuilder.Property(t => t.MemoryCapacity);
            entityBuilder.Property(t => t.DiskSize);
            entityBuilder.Property(t => t.MaxReadSpeed);
            entityBuilder.Property(t => t.MaxWriteSpeed);            
        }
    }
}
