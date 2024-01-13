using System;

namespace Adverts.Domain.Entities
{
    public class AdvertVisit
    {
        public int AdvertId { get; set; }
        public string IpAddress { get; set; }
        public DateTime VisitDate { get; set; }
    }
}
