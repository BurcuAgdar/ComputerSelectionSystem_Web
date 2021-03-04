using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace ComputerSelection.Data
{
    public class RAMMAP
    {
        public RAMMAP(EntityTypeBuilder<RAM> entityBuilder)
        {
            entityBuilder.HasKey(t => t.Model);
            entityBuilder.Property(t => t.Usage_Type);
            entityBuilder.Property(t => t.Memory_Types);
            entityBuilder.Property(t => t.Memory_Capacity);
            entityBuilder.Property(t => t.Memory_Speed);
            entityBuilder.Property(t => t.Delay_Time);
            entityBuilder.Property(t => t.Kit_Type);

        }
    }
}
