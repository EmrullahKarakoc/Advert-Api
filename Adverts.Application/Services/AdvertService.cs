using Adverts.Application.Common.Models;
using Adverts.Application.Dtos;
using Adverts.Application.Interfaces;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Adverts.Application.Services
{
    public class AdvertService : IAdvertService
    {
        private readonly IMapper _mapper;

        public AdvertService(IMapper mapper)
        {
            _mapper = mapper;
        }

        public Task<BaseResponse<PagedAdvertsDto>> GetAllAsync(int page, int limit)
        {
            throw new NotImplementedException();
        }

        public Task<BaseResponse<AdvertsDto>> GetByIdAsync(int id)
        {
            var response = new BaseResponse<AdvertsDto>();
            response.Result = new AdvertsDto();

            response.Result.CityName = "Ankara";
            return Task.FromResult(response);
            //_mapper.Map<AdvertsDto>(advert)
            //throw new NotImplementedException();
        }
    }
}
