using Adverts.Application.Dtos;
using Adverts.Domain.Entities;
using AutoMapper;

namespace Adverts.Application.Common.Mappings
{
    public class AdvertVisitProfile : Profile
    {
        public AdvertVisitProfile()
        {
            CreateMap<AdvertVisit, AdvertVisitDto>().ReverseMap();
        }
    }
}
