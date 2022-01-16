using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using TouristHotspot.Core.Entities;
using TouristHotspot.Core.Repositories;

namespace TouristHotspot.Application.Commands.CreateTourSpot
{
    public class CreateTourSpotCommandHandler : IRequestHandler<CreateTourSpotCommand, Unit>
    {
        private readonly ITourSpotRepository _tourSpotRepository;

        public CreateTourSpotCommandHandler(ITourSpotRepository tourSpotRepository)
        {
            _tourSpotRepository = tourSpotRepository;
        }

        public async Task<Unit> Handle(CreateTourSpotCommand request, CancellationToken cancellationToken)
        {
            var tourSpot = new TourSpot(request.Name, request.Description, request.Address, request.City, request.State);

            await _tourSpotRepository.Create(tourSpot);

            return Unit.Value;
        }
    }
}
