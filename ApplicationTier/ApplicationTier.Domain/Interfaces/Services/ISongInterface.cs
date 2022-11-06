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
        Task<IList<MusLunarSong>> GetAll();
        Task<MusLunarSong> GetOne(int songId);
        Task Update(MusLunarSong song);
        Task Add(MusLunarSong song);
        Task Delete(int songId);
    }
}
