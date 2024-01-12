using Adverts.Application.Dtos;
using Adverts.Domain.Entities;
using AutoMapper;

namespace Adverts.Application.Common.Mappings
{
    public class AdvertProfile : Profile
    {
        public AdvertProfile()
        {
            CreateMap<Adverts, AdvertVisitDto>().ReverseMap();
        }

    }
}