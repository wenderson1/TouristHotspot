using System;

namespace TouristHotspot.Core.Entities
{
    public class TourSpot : BaseEntity
    {
        public string Name { get; private set; }
        public string Description { get; private set; }
        public string Address { get; private set; }
        public string City { get; private set; }
        public string State { get; private set; }
        public bool Status { get; private set; }
        public DateTime CreatedAt { get; private set; 
        
        }
        public TourSpot(string name, string description, string address, string city, string state)
        {
            Name = name;
            Description = description;
            Address = address;
            City = city;
            State = state;
            Status = true;
            CreatedAt = DateTime.Now;
        } 

        

        public void Deactive()
        {
            Status = false;
        }
    }
}
