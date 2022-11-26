using ApplicationTier.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationTier.Domain.Interfaces.Services
{
    public interface ISingerService
    {
        Task<IList<MusLunarSinger>> GetAll();
        Task<MusLunarSinger> GetOne(int Id);
        Task Update(MusLunarSinger objInput);
        Task Add(MusLunarSinger objInput);
        Task Delete(int Id);
    }
}
