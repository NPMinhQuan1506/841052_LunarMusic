using ApplicationTier.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationTier.Domain.Interfaces.Services
{
    public interface ISongService
    {
        Task<IList<spMusLunarSong>> GetAll();
        Task<MusLunarSong> GetOne(int Id);
        Task Update(MusLunarSong objInput);
        Task Add(MusLunarSong objInput);
        Task Delete(int Id);
    }
}
