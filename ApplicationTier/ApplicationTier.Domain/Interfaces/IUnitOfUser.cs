using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationTier.Domain.Interfaces
{
    public interface IUnitOfUser:IDisposable
    {
        /// <summary>
        /// get repository
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        IRepository<T> Repository<T>() where T : class;
        /// <summary>
        /// Manage transaction by unitofuser pattern
        /// </summary>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
        Task BeginTransaction();
        Task CommitTransaction();
        Task RollbackTransaction();
    }
}
