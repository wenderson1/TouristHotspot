using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using TouristHotspot.Core.Entities;

namespace TouristHotspot.Infrastructure.Persistence
{
    public class TouristHotspotDbContext:DbContext
    {
        public TouristHotspotDbContext(DbContextOptions<TouristHotspotDbContext> options) : base(options) { }

        public DbSet<TourSpot> TourSpots { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
        
    }
}
