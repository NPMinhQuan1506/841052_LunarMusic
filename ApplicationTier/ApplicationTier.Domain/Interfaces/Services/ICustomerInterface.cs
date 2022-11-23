using ApplicationTier.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationTier.Domain.Interfaces.Services
{
    public interface ICustomerService
    {
        Task<IList<MusLunarCustomer>> GetAll();
        Task<MusLunarCustomer> GetOne(int Id);
        Task Update(MusLunarCustomer objInput);
        Task Add(MusLunarCustomer objInput);
        Task Delete(int Id);
    }
}
