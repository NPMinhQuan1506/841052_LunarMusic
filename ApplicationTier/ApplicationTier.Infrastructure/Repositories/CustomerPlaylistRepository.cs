using ApplicationTier.Domain.Entities;
using ApplicationTier.Domain.Interfaces;
using ApplicationTier.Infrastructure.Extensions;
using HandlebarsDotNet;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationTier.Infrastructure.Repositories
{
    public static class CustomerPlaylistRepository
    {
        /// <summary>
        /// Get all items of work table from stored procedure
        /// </summary>
        /// <param name="repository"></param>
        /// <returns></returns>
        public static async Task<List<MusLunarCustomerPlaylist>> GetAll(this IRepository<MusLunarCustomerPlaylist> repository)
        {
            var playlists = new List<MusLunarCustomerPlaylist>();
            //var Entities = repository.DbContext.Set<MusLunarCustomerPlaylist>();
            //playlists = await Entities
            //    .Where(x => x.State == 1)
            //    .ToListAsync();

            await repository.DbContext.LoadStoredProc("YYY_sp_v1_CustomerPlaylist_LoadList")
                .ExecuteStoredProcAsync(result =>
                {
                    // Read value to list
                    //var x = result;
                    playlists = result.ReadNextListOrEmpty<MusLunarCustomerPlaylist>();
                });


            //return (IList<(int Id, string CustName, string SongName, int ListeningTimes)>)results;
            return playlists;
        }
    }
}
