using System.Collections.Generic;

namespace Adverts.Application.Dtos
{
    public class PagedAdvertsDto
    {
        public int Page { get; set; }
        public int Total { get; set; }
        public List<AdvertDto> Adverts { get; set; }
    }
}
