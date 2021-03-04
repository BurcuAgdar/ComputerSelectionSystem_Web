using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ComputerSelection.Data
{
    public class SystemRequirementMAP
    {
        public SystemRequirementMAP(EntityTypeBuilder<SystemRequirement> entityBuilder)
        {
            entityBuilder.HasKey(t => t.Model);
            entityBuilder.Property(t => t.Amd);
            entityBuilder.Property(t => t.Intel);
            entityBuilder.Property(t => t.Ram);
            entityBuilder.Property(t => t.VideoCard1);
            entityBuilder.Property(t => t.VideoCard2);
            entityBuilder.Property(t => t.FreeDiskSpace);
        }
    }
}
