using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TouristHotspot.Core.DTOs;
using TouristHotspot.Core.Entities;


namespace TouristHotspot.Core.Repositories
{
    public interface ITourSpotRepository
    {
        List<TourSpotDTO> GetAll();
        TourSpot GetByIdAsync(int id);
        Task Create(TourSpot tourSpot);
    }
}
