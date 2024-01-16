using Adverts.Application.Common.Models;
using Adverts.Application.Common.Persistence;
using Adverts.Application.Dtos;
using Adverts.Application.Interfaces;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Adverts.Application.Services
{
    public class AdvertService : IAdvertService
    {
        private readonly IMapper _mapper;
        private readonly IAdvertRepository _advertRepository;


        public AdvertService(IAdvertRepository advertRepository, IMapper mapper)
        {
            _advertRepository = advertRepository;
            _mapper = mapper;
        }

        public async Task<BaseResponse<PagedAdvertsDto>> GetAllAsync(int page, int limit)
        {
            var response = new BaseResponse<PagedAdvertsDto>()
            {
                Result = new PagedAdvertsDto()
            };

            var adverts = await _advertRepository.GetAllAsync();
            var pagedAdverts = adverts.Skip(page * limit).Take(limit).ToList();
            response.Total = limit > adverts.Count() ? 1 : (int)Math.Ceiling((double)adverts.Count() / limit);

            response.Result.Adverts = _mapper.Map<List<AdvertDto>>(pagedAdverts);
            response.Result.Page = page;

            return await Task.FromResult(response);
        }

        public async Task<BaseResponse<AdvertDto>> GetByIdAsync(int id)
        {
            var response = new BaseResponse<AdvertDto>()
            {
                Result = new AdvertDto()
            };
            var advert = await _advertRepository.GetByIdAsync(id);

            response.Result = _mapper.Map<AdvertDto>(advert);
            return await Task.FromResult(response);
        }
    }
}
