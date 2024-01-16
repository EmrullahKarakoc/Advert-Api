using Adverts.Application.Common.Models;
using Adverts.Application.Common.Persistence;
using Adverts.Application.Interfaces;
using Adverts.Domain.Entities;
using AutoMapper;
using System;
using System.Threading.Tasks;

namespace Adverts.Application.Services
{
    public class AdvertVisitService : IAdvertVisitService
    {
        private readonly IAdvertVisitRepository _advertVisitRepository;
        private readonly IMapper _mapper;


        public AdvertVisitService(IAdvertVisitRepository advertVisitRepository, IMapper mapper)
        {
            _advertVisitRepository = advertVisitRepository;
            _mapper = mapper;
        }
        public async Task<BaseResponse<bool>> CreateAdvertVisitAsync(int advertId, string remoteIpAddress)
        {
            var response = new BaseResponse<bool>();

            var isAdded = await _advertVisitRepository.AddAsync(
                new AdvertVisit()
                {
                    AdvertId = advertId,
                    VisitDate = DateTime.UtcNow,
                    IpAddress = remoteIpAddress ?? "1.1.1.1"
                });

            response.Result = isAdded;

            return await Task.FromResult(response);
        }
    }
}
