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
        Task<IList<MusLunarUser>> GetAll();
        Task<MusLunarUser> GetOne(int Id);
        Task Update(MusLunarUser objInput);
        Task Add(MusLunarUser objInput);
        Task Delete(int Id);
    }
}
