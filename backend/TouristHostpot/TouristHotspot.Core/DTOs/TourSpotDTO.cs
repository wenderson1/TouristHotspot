using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TouristHotspot.Core.DTOs
{
    public class TourSpotDTO
    {
        public TourSpotDTO(int id, string name, string description, string address, string city, string state)
        {
            Id = id;
            Name = name;
            Description = description;
            Address = address;
            City = city;
            State = state;
        }

        public int Id { get; private set; }
        public string Name { get; private set; }
        public string Description { get; private set; }
        public string Address { get; private set; }
        public string City { get; private set; }
        public string State { get; private set; }

      
    }
}