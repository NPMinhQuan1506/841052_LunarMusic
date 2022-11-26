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
        Task<IList<MusLunarEmployee>> GetAll();
        Task<MusLunarEmployee> GetOne(int Id);
        Task Update(MusLunarEmployee objInput);
        Task Add(MusLunarEmployee objInput);
        Task Delete(int Id);
    }
}
