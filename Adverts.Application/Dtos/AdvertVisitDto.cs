using System;

namespace Adverts.Application.Dtos
{
    public class AdvertVisitDto
    {
        public int AdvertId { get; set; }
        public string IpAddress { get; set; }
        public DateTime VisitDate { get; set; }
    }
}
