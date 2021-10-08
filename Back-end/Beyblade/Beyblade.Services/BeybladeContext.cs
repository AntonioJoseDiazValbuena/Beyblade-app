using Beyblade.Entities;
using Beyblade.Services.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;

namespace Beyblade.Services
{
    public partial class BeybladeContext : DbContext, IBeybladeContext
    {
        public BeybladeContext(DbContextOptions<BeybladeContext> options) : base(options)
        {

        }

        public DbSet<Layer> Layers { get; set; }
        public DbSet<Disk> Disks { get; set; }
        public DbSet<Frame> Frames { get; set; }
        public DbSet<Driver> Drivers { get; set; }
    }
}
