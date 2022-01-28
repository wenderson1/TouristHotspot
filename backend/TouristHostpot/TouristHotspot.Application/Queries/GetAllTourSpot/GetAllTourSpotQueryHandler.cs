using MediatR;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using TouristHotspot.Application.ViewModels;
using TouristHotspot.Core.Repositories;

namespace TouristHotspot.Application.Queries.GetAllTourSpot
{
    public class GetAllTourSpotQueryHandler : IRequestHandler<GetAllTourSpotQuery, List<TourSpotViewModel>>
    {
        private readonly ITourSpotRepository _tourSpotRepository;

        public GetAllTourSpotQueryHandler(ITourSpotRepository tourSpotRepository)
        {
            _tourSpotRepository = tourSpotRepository;
        }

        public async Task<List<TourSpotViewModel>> Handle(GetAllTourSpotQuery request, CancellationToken cancellationToken)
        {
            var tourSpots =  _tourSpotRepository.GetAll();

            var tourSpotsViewModel = tourSpots
                .Select(ts => new TourSpotViewModel(ts.Id,ts.Name, ts.City, ts.State))
                .ToList();

            return tourSpotsViewModel;
        }
    }
}
