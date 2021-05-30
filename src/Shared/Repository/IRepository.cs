using Codeman.BRS.Shared.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Codeman.BRS.Shared.Repository
{
    public interface IRepository<T> where T : ModelBase
    {
        Task<bool> Add(T entity);

        Task<bool> Update(T entity);

        Task<bool> Delete(T entity);

        Task<IEnumerable<T>> Get();

        Task<T> GetById(int entityId);
    }
}