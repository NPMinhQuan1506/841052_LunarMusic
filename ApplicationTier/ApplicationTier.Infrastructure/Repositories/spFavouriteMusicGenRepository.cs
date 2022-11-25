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
    public static class spFavouriteMusicGenRepository
    {
        /// <summary>
        /// Get all items of work table from stored procedure
        /// </summary>
        /// <param name="repository"></param>
        /// <returns></returns>
        public static async Task<List<spFavouriteMusicGeneral>> GetAll(this IRepository<spFavouriteMusicGeneral> repository, string datefrom, string dateto)
        {
            var spResult = new List<spFavouriteMusicGeneral>();

            await repository.DbContext.LoadStoredProc("YYY_sp_v1_rp_favouritemusic_general")
                .WithSqlParam("@datefrom", datefrom)
                .WithSqlParam("@dateto", dateto)
                .ExecuteStoredProcAsync(result =>
                {
                    spResult = result.ReadNextListOrEmpty<spFavouriteMusicGeneral>();
                });
            return spResult;
        }
    }
}
