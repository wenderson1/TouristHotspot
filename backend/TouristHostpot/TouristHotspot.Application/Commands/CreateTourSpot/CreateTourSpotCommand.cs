using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TouristHotspot.Application.Commands.CreateTourSpot
{
    public class CreateTourSpotCommand : IRequest<Unit>
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }

        public CreateTourSpotCommand(string name, string description, string address, string city, string state)
        {
            Name = name;
            Description = description;
            Address = address;
            City = city;
            State = state;
        }
    }
}
