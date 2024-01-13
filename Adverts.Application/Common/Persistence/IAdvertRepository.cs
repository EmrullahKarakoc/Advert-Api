using Adverts.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Adverts.Application.Common.Persistence
{
    public interface IAdvertRepository
    {
        Task<List<Advert>> GetAllAsync();
        Task<Advert> GetByIdAsync(int id);
    }
}
