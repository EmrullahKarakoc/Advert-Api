using Adverts.Application.Common.Models;
using System.Threading.Tasks;

namespace Adverts.Application.Interfaces
{
    public interface IAdvertVisitService
    {
        Task<BaseResponse<bool>> CreateAdvertVisitAsync(int advertId,string remoteIpAddress);
    }
}
