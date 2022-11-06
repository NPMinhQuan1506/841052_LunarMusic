using ApplicationTier.Domain.Entities;
using ApplicationTier.Domain.Interfaces;
using ApplicationTier.Infrastructure.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationTier.Infrastructure.Repositories
{
    public static class SongRepository
    {
        /// <summary>
        /// Get all items of song table from stored procedure
        /// </summary>
        /// <param name="repository"></param>
        /// <returns></returns>
        public static async Task<IList<MusLunarSong>> GetAll(this IRepository<MusLunarSong> repository)
        {
            var songs = new List<MusLunarSong>();
            //SqlParameter demoPara = new SqlParameter();

            //demoPara.ParameterName = "@pId"; // Defining Name  
            //demoPara.Value = 1;
            //demoPara.SqlDbType = SqlDbType.Int; // Defining DataType  
            //demoPara.Direction = ParameterDirection.Input;
            await repository.DbContext.LoadStoredProc("spGetsongs")
                //.WithSqlParam("@pId", demoPara)
                //.WithSqlParam("id", "1") // Sample code to add params to provided stored procedure
                .ExecuteStoredProcAsync(result =>
                {
                    // Read value to list
                    songs = result.ReadNextListOrEmpty<MusLunarSong>();
                    // Sample code to read to value
                    // var getOne = result.ReadToValue<int>() 
                });


            return songs;
        }
    }
}
