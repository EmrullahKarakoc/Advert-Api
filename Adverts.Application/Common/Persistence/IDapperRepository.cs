using System.Threading.Tasks;

namespace Adverts.Application.Common.Persistence
{
    public interface IDapperRepository<T> where T : class
    {
        Task<T> GetAllAsync();
        Task<T> GetByIdAsync(int id);
        Task<int> AddAsync(T entity);
    }
}
