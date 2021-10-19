using Beyblade.Entities;
using Beyblade.Services.Interfaces;
using Beyblade.Services.ModelBuilders;
using Microsoft.EntityFrameworkCore;
using System;

namespace Beyblade.Services
{
    public partial class BeybladeContext : DbContext, IBeybladeServices
    {
        public BeybladeContext(DbContextOptions<BeybladeContext> options) : base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<Layer> Layers { get; set; }
        public DbSet<Disk> Disks { get; set; }
        public DbSet<Frame> Frames { get; set; }
        public DbSet<Driver> Drivers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new DiskModelBuilder());
            modelBuilder.ApplyConfiguration(new FrameModelBuilder());
            modelBuilder.ApplyConfiguration(new DriverModelBuilder());
            modelBuilder.ApplyConfiguration(new LayerModelBuilder());
        }
    }
}
