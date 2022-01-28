using Dapper;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TouristHotspot.Application.ViewModels;
using TouristHotspot.Core.DTOs;
using TouristHotspot.Core.Entities;
using TouristHotspot.Core.Repositories;

namespace TouristHotspot.Infrastructure.Persistence.Repositories
{
    public class TourSpotRepository : ITourSpotRepository
    {
        private readonly TouristHotspotDbContext _dbContext;
        private readonly string _connectionString;

        public TourSpotRepository(TouristHotspotDbContext dbContext, IConfiguration configuration)
        {
            _dbContext = dbContext;
            _connectionString = configuration.GetConnectionString("TouristHotspotCs");
        }

        public async Task Create(TourSpot tourSpot)
        {
            await _dbContext.TourSpots.AddAsync(tourSpot);
            await _dbContext.SaveChangesAsync();
        }

        public List<TourSpotDTO> GetAll()
        {
            
            using (var sqlConnection = new SqlConnection(_connectionString))
            {
                sqlConnection.Open();

                var script = "SELECT Id, Name, Description, Address, City, State FROM TourSpots Where Status = 1";

                return sqlConnection.Query<TourSpotDTO>(script).ToList();
            }
        }

        public TourSpot GetByIdAsync(int id)
        {
            using (var sqlConnection = new SqlConnection(_connectionString))
            {
                sqlConnection.Open();

                var script = "SELECT Name, Description, Address, City, State FROM TourSpots Where Id = @id;";

                var tourSpotDetails = sqlConnection.QueryFirstOrDefault<TourSpot>(script,new { id });

                return tourSpotDetails;
            }
        }
    }
}
