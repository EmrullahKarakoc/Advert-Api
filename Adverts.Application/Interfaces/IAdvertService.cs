using Adverts.Application.Common.Models;
using Adverts.Application.Dtos;
using System.Threading.Tasks;

namespace Adverts.Application.Interfaces
{
    public interface IAdvertService
    {
        Task<BaseResponse<PagedAdvertsDto>> GetAllAsync(int page, int limit);
        Task<BaseResponse<AdvertDto>> GetByIdAsync(int id);
    }
}
