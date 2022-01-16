using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TouristHotspot.Application.ViewModels;

namespace TouristHotspot.Application.Queries.GetAllTourSpot
{
    public class GetAllTourSpotQuery:IRequest<List<TourSpotViewModel>>
    {
        public string Query { get; set; }

        public GetAllTourSpotQuery(string query)
        {
            Query = query;
        }
    }
}
