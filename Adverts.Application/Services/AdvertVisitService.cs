using Adverts.Application.Common.Models;
using Adverts.Application.Dtos;
using Adverts.Application.Interfaces;
using AutoMapper;
using System;
using System.Threading.Tasks;

namespace Adverts.Application.Services
{
    public class AdvertVisitService : IAdvertVisitService
    {
        private readonly IMapper _mapper;

        public AdvertVisitService(IMapper mapper)
        {
            _mapper = mapper;
        }
        public Task<BaseResponse<AdvertVisitDto>> CreateAdvertVisitAsync(int advertId)
        {
            throw new NotImplementedException();
        }
    }
}
