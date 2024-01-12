using Adverts.Application.Common.Models;
using Adverts.Application.Dtos;
using System.Threading.Tasks;

namespace Adverts.Application.Interfaces
{
    public interface IAdvertVisitService
    {
        Task<BaseResponse<AdvertVisitDto>> CreateAdvertVisitAsync(int advertId);
    }
}
