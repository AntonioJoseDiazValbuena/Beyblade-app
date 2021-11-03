using Beyblade.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Beyblade.Services.ModelBuilders
{
    public class DriverModelBuilder : IEntityTypeConfiguration<Driver>
    {
        public DriverModelBuilder() { }

        public void Configure(EntityTypeBuilder<Driver> part)
        {
            part.HasKey(p => p.Id);
            part.Property(p => p.Id);
            part.Property(p => p.Name).HasMaxLength(50);
            part.Property(p => p.Type);
            part.Property(p => p.Weight);
            part.Property(p => p.Attack);
            part.Property(p => p.Defense);
            part.Property(p => p.Stamina);
        }
    }
}
