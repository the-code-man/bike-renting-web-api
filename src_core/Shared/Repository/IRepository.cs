using Codeman.BRS.Shared.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Codeman.BRS.Repository
{
    public interface IRepository<T> where T : ModelBase
    {
        Task<bool> Add(T entity);

        Task<bool> Update(T entity);

        Task<bool> Delete(T entity);
    }
}