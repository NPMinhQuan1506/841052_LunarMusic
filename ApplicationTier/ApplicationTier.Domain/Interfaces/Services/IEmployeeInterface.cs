using ApplicationTier.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationTier.Domain.Interfaces.Services
{
    public interface IEmployeeService
    {
        /// <summary>
        /// Interface of IEmployee is used to excute CRUD action
        /// </summary>
        /// <returns></returns>
        Task<IList<MusLunarEmployee>> GetAll();
        Task<MusLunarEmployee> GetOne(int employeeId);
        Task Update(MusLunarEmployee employee);
        Task Add(MusLunarEmployee employee);
        Task Delete(int employeeId);
    }
}
