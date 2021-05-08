using Codeman.BRS.Shared.Entity;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Codeman.BRS.Shared.Repository
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