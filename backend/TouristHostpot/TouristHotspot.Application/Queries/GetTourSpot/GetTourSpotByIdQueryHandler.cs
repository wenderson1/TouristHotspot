using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using TouristHotspot.Application.ViewModels;
using TouristHotspot.Core.Repositories;

namespace TouristHotspot.Application.Queries.GetTourSpot
{
    public class GetTourSpotByIdQueryHandler : IRequestHandler<GetTourSpotByIdQuery, TourSpotDetailsViewModel>
    {
        private readonly ITourSpotRepository _tourSpotRepository;

        public GetTourSpotByIdQueryHandler(ITourSpotRepository tourSpotRepository)
        {
            _tourSpotRepository = tourSpotRepository;
        }

        public async Task<TourSpotDetailsViewModel> Handle(GetTourSpotByIdQuery request, CancellationToken cancellationToken)
        {
            var tourSpot = await _tourSpotRepository.GetByIdAsync(request.Id);

            var tourSpotDetailsViewModel = new TourSpotDetailsViewModel(tourSpot.Name, tourSpot.Description, tourSpot.Address, tourSpot.City, tourSpot.State, tourSpot.CreatedAt);

            return tourSpotDetailsViewModel;
        }
    }
}
