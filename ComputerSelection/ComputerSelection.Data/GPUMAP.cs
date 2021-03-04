using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ComputerSelection.Data
{
    public class GPUMAP
    {
        public GPUMAP(EntityTypeBuilder<GPU> entityBuilder)
        {
            entityBuilder.HasKey(t => t.Model);
            entityBuilder.Property(t => t.Company);
            entityBuilder.Property(t => t.GPUChip);
            entityBuilder.Property(t => t.Released);
            entityBuilder.Property(t => t.Bus);
            entityBuilder.Property(t => t.Memory);
            entityBuilder.Property(t => t.GPUclock);
            entityBuilder.Property(t => t.Memoryclock);
            entityBuilder.Property(t => t.Shaders_TMUs_ROPs);
            entityBuilder.Property(t => t.PassmarkG3dMark);
            entityBuilder.Property(t => t.Rank);
        }
    }
}
