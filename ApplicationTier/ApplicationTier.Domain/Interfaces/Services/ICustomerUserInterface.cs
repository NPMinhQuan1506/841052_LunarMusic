using ApplicationTier.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationTier.Domain.Interfaces.Services
{
    public interface ICustomerUserService
    {
        Task<IList<MusLunarCustomerUser>> GetAll();
        Task<MusLunarCustomerUser> GetOne(int Id);
        Task Update(MusLunarCustomerUser objInput);
        Task Add(MusLunarCustomerUser objInput);
        Task Delete(int Id);
    }
}
