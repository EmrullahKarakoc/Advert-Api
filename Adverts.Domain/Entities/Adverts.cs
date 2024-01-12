﻿using System;
using System.Collections.Generic;

namespace Adverts.Domain.Entities
{
    public class Adverts
    {
        public int Id { get; set; }
        public int MemberId { get; set; }
        public int CityId { get; set; }
        public string CityName { get; set; }
        public int TownId { get; set; }
        public string TownName { get; set; }
        public int ModelId { get; set; }
        public string ModelName { get; set; }
        public DateTime Year { get; set; }
        public int CategoryId { get; set; }
        public double Km { get; set; }
        public string Color { get; set; }
        public string Gear { get; set; }
        public string Fuel { get; set; }
        public string FirstPhoto { get; set; }
        public string SecondPhoto { get; set; }
        public string UserInfo { get; set; }
        public string UserPhone { get; set; }
        public string Text { get; set; }

        public ICollection<AdvertVisit> AdvertVisits { get; set; }
    }
}
