using ApplicationTier.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationTier.Domain.Interfaces.Services
{
    public interface ICustomerPlaylistService
    {
        Task<IList<MusLunarCustomerPlaylist>> GetAll();
        Task<MusLunarCustomerPlaylist> GetOne(int Id);
        Task Update(MusLunarCustomerPlaylist objInput);
        Task Add(MusLunarCustomerPlaylist objInput);
        Task Delete(int Id);
    }
}
