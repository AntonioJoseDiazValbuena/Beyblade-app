using Beyblade.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Beyblade.Services.ModelBuilders
{
    public class FrameModelBuilder : IEntityTypeConfiguration<Frame>
    {
        public FrameModelBuilder() { }

        public void Configure(EntityTypeBuilder<Frame> part)
        {
            part.HasKey(p => p.Id);
            part.Property(p => p.Id);
            part.Property(p => p.Name).HasMaxLength(50);
            part.Property(p => p.Weight);
        }
    }
}
