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
    public static class SongRepository
    {
        /// <summary>
        /// Get all items of work table from stored procedure
        /// </summary>
        /// <param name="repository"></param>
        /// <returns></returns>
        public static async Task<List<spMusLunarSong>> GetAll(this IRepository<spMusLunarSong> repository)
        {
            var song = new List<spMusLunarSong>();
            //var Entities = repository.DbContext.Set<MusLunarSong>();
            //playlists = await Entities
            //    .Where(x => x.State == 1)
            //    .ToListAsync();

            await repository.DbContext.LoadStoredProc("YYY_sp_v1_rp_song_loadlist")
                .ExecuteStoredProcAsync(result =>
                {
                    // Read value to list
                    //var x = result;
                    song = result.ReadNextListOrEmpty<spMusLunarSong>();
                });


            //return (IList<(int Id, string CustName, string SongName, int ListeningTimes)>)results;
            return song;
        }
    }
}
