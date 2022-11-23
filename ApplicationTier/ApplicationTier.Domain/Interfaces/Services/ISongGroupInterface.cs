using ApplicationTier.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationTier.Domain.Interfaces.Services
{
    public interface ISongGroupService
    {
        Task<IList<MusLunarSongGroup>> GetAll();
        Task<MusLunarSongGroup> GetOne(int Id);
        Task Update(MusLunarSongGroup objInput);
        Task Add(MusLunarSongGroup objInput);
        Task Delete(int Id);
    }
}
