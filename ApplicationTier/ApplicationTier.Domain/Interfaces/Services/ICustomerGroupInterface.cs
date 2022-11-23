using ApplicationTier.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationTier.Domain.Interfaces.Services
{
    public interface ICustomerGroupService
    {
        Task<IList<MusLunarCustomerGroup>> GetAll();
        Task<MusLunarCustomerGroup> GetOne(int Id);
        Task Update(MusLunarCustomerGroup objInput);
        Task Add(MusLunarCustomerGroup objInput);
        Task Delete(int Id);
    }
}
