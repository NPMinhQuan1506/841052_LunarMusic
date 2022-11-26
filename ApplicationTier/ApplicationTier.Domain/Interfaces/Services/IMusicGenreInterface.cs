using ApplicationTier.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationTier.Domain.Interfaces.Services
{
    public interface IMusicGenreService
    {
        Task<IList<MusLunarMusicGenre>> GetAll();
        Task<MusLunarMusicGenre> GetOne(int Id);
        Task Update(MusLunarMusicGenre objInput);
        Task Add(MusLunarMusicGenre objInput);
        Task Delete(int Id);
    }
}
