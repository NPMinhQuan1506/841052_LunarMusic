using ApplicationTier.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationTier.Domain.Interfaces.Services
{
    public interface IParameterService
    {
        /// <summary>
        /// Interface of work is used to excute CRUD action
        /// </summary>
        /// <returns></returns>
        Task<IList<MusLunarParameter>> GetAll();
        Task<Work> GetOne(int workId);
        Task Update(Work work);
        Task Add(Work work);
        Task Delete(int workId);
    }
}
