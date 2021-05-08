using Codeman.BikeRentingSystem.Shared.Entity;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Codeman.BikeRentingSystem.Shared.Repository
{
    public interface IRepository<T> where T : BaseEntity
    {
        Task<bool> Add(T entity);

        Task<bool> Update(T entity);

        Task<bool> Delete(T entity);

        Task<IEnumerable<T>> Get();

        Task<T> GetById(int entityId);
    }
}