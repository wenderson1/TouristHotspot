using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TouristHotspot.Core.Entities
{
    public class Localization : BaseEntity
    {
        public string Address { get; private set; }
        public string City { get; private set; }
        public string State { get; private set; }
        public bool Status { get; private set; }
        public List<TourSpot> TourSpots{ get; private set; }

        public Localization(string address, string city, string state)
        {
            Address = address;
            City = city;
            State = state;
            Status = true;
            TourSpots = new List<TourSpot>();
        }
    }
}
