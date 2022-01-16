using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TouristHotspot.Application.ViewModels;

namespace TouristHotspot.Application.Queries.GetTourSpot
{
    public class GetTourSpotByIdQuery:IRequest<TourSpotDetailsViewModel>
    {
        public int Id { get; private set; }

        public GetTourSpotByIdQuery(int id)
        {
            Id = id;
        }
    }
}
