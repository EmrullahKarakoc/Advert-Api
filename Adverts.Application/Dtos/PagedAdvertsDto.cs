using System.Collections.Generic;

namespace Adverts.Application.Dtos
{
    public class PagedAdvertsDto
    {
        public PagedAdvertsDto()
        {
            Adverts = new List<AdvertDto>();
        }
        public int Page { get; set; }
        public List<AdvertDto> Adverts { get; set; }
    }
}
