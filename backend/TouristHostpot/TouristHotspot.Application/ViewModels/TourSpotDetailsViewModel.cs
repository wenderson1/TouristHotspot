using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TouristHotspot.Application.ViewModels
{
    public class TourSpotDetailsViewModel
    {
        public string Name { get; private set; }
        public string Description { get; private set; }
        public string Address { get; private set; }
        public string City { get; private set; }
        public string State { get; private set; }
        public DateTime CreatedAt { get; private set; }

        public TourSpotDetailsViewModel(string name, string description, string address, string city, string state, DateTime createdAt)
        {
            Name = name;
            Description = description;
            Address = address;
            City = city;
            State = state;
            CreatedAt = createdAt;
        }
    }
}
