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
    public static class CustomerRepository
    {
        /// <summary>
        /// Get all items of work table from stored procedure
        /// </summary>
        /// <param name="repository"></param>
        /// <returns></returns>
        public static async Task<List<MusLunarCustomer>> GetAll(this IRepository<MusLunarCustomer> repository)
        {
            var playlists = new List<MusLunarCustomer>();
            //var Entities = repository.DbContext.Set<MusLunarCustomer>();
            //playlists = await Entities
            //    .Where(x => x.State == 1)
            //    .ToListAsync();

            await repository.DbContext.LoadStoredProc("YYY_sp_v1_Customer_LoadList")
                .ExecuteStoredProcAsync(result =>
                {
                    // Read value to list
                    //var x = result;
                    playlists = result.ReadNextListOrEmpty<MusLunarCustomer>();
                });


            //return (IList<(int Id, string CustName, string SongName, int ListeningTimes)>)results;
            return playlists;
        }
    }
}
