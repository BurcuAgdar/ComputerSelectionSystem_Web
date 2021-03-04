using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace ComputerSelection.Data
{
    public class CPUMap
    {
        public CPUMap(EntityTypeBuilder<CPU> entityBuilder)
        {
            entityBuilder.HasKey(t => t.Model);
            entityBuilder.Property(t => t.CpuCore);
            entityBuilder.Property(t => t.ThreatNumber);
            entityBuilder.Property(t => t.Released);
            entityBuilder.Property(t => t.BaseClock);
            entityBuilder.Property(t => t.MaxClock);
            entityBuilder.Property(t => t.SocketType);
            entityBuilder.Property(t => t.TDP);
            entityBuilder.Property(t => t.MemoryType);
            entityBuilder.Property(t => t.MemoryFrequancy);
            entityBuilder.Property(t => t.Type);
            entityBuilder.Property(t => t.Apu);
            entityBuilder.Property(t => t.ApuFrequancy);
            entityBuilder.Property(t => t.CpuMark);
            entityBuilder.Property(t => t.Rank);
        }
    }
}
