using ApplicationTier.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationTier.Domain.Interfaces.Services
{
    public interface IUserService
    {

        /// <summary>
        /// Interface of work is used to excute CRUD action
        /// </summary>
        /// <returns></returns>
        Task<IList<MusLunarUser>> GetAll();
        Task<MusLunarUser> GetOne(int userId);
        Task Update(MusLunarUser user);
        Task Add(MusLunarUser user);
        Task Delete(int userId);
    }
}
