﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TouristHotspot.Application.ViewModels
{
    public class TourSpotViewModel
    {
        public int Id { get; private set; }
        public string Name { get; private set; }
        public string City { get; private set; }
        public string State { get; private set; }

        public TourSpotViewModel(int id ,string name,  string city, string state)
        {
            Id = id;
            Name = name;
            City = city;
            State = state;
        }
    }
}
