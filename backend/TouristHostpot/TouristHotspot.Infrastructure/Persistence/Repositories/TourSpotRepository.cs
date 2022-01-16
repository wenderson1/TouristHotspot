using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TouristHotspot.Core.Entities;
using TouristHotspot.Core.Repositories;

namespace TouristHotspot.Infrastructure.Persistence.Repositories
{
    public class TourSpotRepository : ITourSpotRepository
    {
        private readonly TouristHotspotDbContext _dbContext;

        public TourSpotRepository(TouristHotspotDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task Create(TourSpot tourSpot)
        {
            await _dbContext.TourSpots.AddAsync(tourSpot);
            await _dbContext.SaveChangesAsync();
        }

        public async Task<List<TourSpot>> GetAllAsync()
        {
            return await _dbContext.TourSpots.Where(ts => ts.Status==true).ToListAsync();
        }

        public async Task<TourSpot> GetByIdAsync(int id)
        {
            return await _dbContext.TourSpots.SingleOrDefaultAsync(p => p.Id == id);
        }
    }
}
