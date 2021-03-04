using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ComputerSelection.Data
{
    public class HARDDISKMAP
    {
        public HARDDISKMAP(EntityTypeBuilder<HardDisk> entityBuilder)
        {
            entityBuilder.HasKey(t => t.Model);
            entityBuilder.Property(t => t.MemoryCapacity);
            entityBuilder.Property(t => t.ConnectionType);
            entityBuilder.Property(t => t.Cache);
            entityBuilder.Property(t => t.RotationSpeed);
            entityBuilder.Property(t => t.DiskSize);
        }
    }
}
