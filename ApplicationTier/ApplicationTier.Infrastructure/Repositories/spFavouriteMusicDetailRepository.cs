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
    public static class spFavouriteMusicDetailRepository
    {
        /// <summary>
        /// Get all items of work table from stored procedure
        /// </summary>
        /// <param name="repository"></param>
        /// <returns></returns>
        public static async Task<List<spFavouriteMusicDetail>> GetAll(this IRepository<spFavouriteMusicDetail> repository, string datefrom, string dateto, int genresID)
        {
            var spResult = new List<spFavouriteMusicDetail>();

            await repository.DbContext.LoadStoredProc("YYY_sp_v1_rp_favouritemusic_detail")
                .WithSqlParam("@datefrom", datefrom)
                .WithSqlParam("@dateto", dateto)
                .WithSqlParam("@genresID", genresID)
                .ExecuteStoredProcAsync(result =>
                {
                    spResult = result.ReadNextListOrEmpty<spFavouriteMusicDetail>();
                });
            return spResult;
        }
    }
}
