using Codeman.BRS.Shared.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Codeman.BRS.Shared.Repository
{
    public interface IReadOnlyRepository<T, U> where T : ModelBase
    {
        Task<IEnumerable<T>> GetAll();

        Task<T> GetById(U entityId);
    }
}
