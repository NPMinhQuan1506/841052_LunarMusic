using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationTier.Domain.Interfaces
{
    public interface IRepository<T> where T : class
    {
        DbSet<T> Entities { get; }
        DbContext DbContext { get; }

        /// <summary>
        /// Get all items with async method
        /// </summary>
        /// <returns></returns>
        Task<IList<T>> GetAllAsync();
        /// <summary>
        /// Get one items with sync method
        /// </summary>
        /// <returns></returns>
        T Find(params object[] keyValues);
        /// <summary>
        /// Get one items with async method
        /// </summary>
        /// <returns></returns>
        Task<T> FindAsync(params object[] keyValues);
        /// <summary>
        /// Insert items with async method
        /// </summary>
        /// <returns></returns>
        Task InsertAsync(T entity, bool saveChanges = true);
        /// <summary>
        /// Insert multi items with async method
        /// </summary>
        /// <returns></returns>
        Task InsertRangeAsync(IEnumerable<T> entities, bool saveChanges = true);
        /// <summary>
        /// Remove one item by id
        /// </summary>
        /// <returns></returns>
        Task DeleteAsync(int id, bool saveChanges = true);
        /// <summary>
        /// Removeby entity
        /// </summary>
        /// <returns></returns>
        Task DeleteAsync(T entity, bool saveChanges = true);
        /// <summary>
        /// Remove multiple items from an entity by asynchronous method
        /// </summary>
        /// <returns></returns>
        Task DeleteRangeAsync(IEnumerable<T> entities, bool saveChanges = true);
    }
}
