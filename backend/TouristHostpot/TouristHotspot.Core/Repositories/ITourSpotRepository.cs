using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TouristHotspot.Core.Entities;

namespace TouristHotspot.Core.Repositories
{
    public interface ITourSpotRepository
    {
        Task<List<TourSpot>> GetAllAsync();
        Task<List<TourSpot>> GetByIdAsync(int id);
        Task<List<TourSpot>> Create(TourSpot tourSpot);
    }
}
