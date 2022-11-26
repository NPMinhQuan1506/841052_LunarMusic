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
    public static class CustomerUserRepository
    {
        /// <summary>
        /// Get all items of work table from stored procedure
        /// </summary>
        /// <param name="repository"></param>
        /// <returns></returns>
        public static async Task<MusLunarCustomerUser> GetOneByUsername(this IRepository<MusLunarCustomerUser> repository, string Username)
        {
            var Entities = repository.DbContext.Set<MusLunarCustomerUser>();
            var user = Entities.SingleOrDefault(o => o.Username == Username);

            return user;
        }
    }
}
