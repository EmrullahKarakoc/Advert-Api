using Adverts.Domain.Entities;
using System.Threading.Tasks;

namespace Adverts.Application.Common.Persistence
{
    public interface IAdvertVisitRepository
    {
        Task<bool> AddAsync(AdvertVisit entity);
    }
}
