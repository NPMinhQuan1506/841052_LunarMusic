using ApplicationTier.Domain.Entities;
using ApplicationTier.Domain.Interfaces;
using ApplicationTier.Domain.Entities;
using ApplicationTier.Domain.Interfaces;
using ApplicationTier.Infrastructure.Extensions;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationTier.Infrastructure.Repositories
{
    public static class UserRepository
    {
        /// <summary>
        /// Get all items of user table from stored procedure
        /// </summary>
        /// <param name="repository"></param>
        /// <returns></returns>
        public static async Task<IList<MusLunarUser>> GetAll(this IRepository<MusLunarUser> repository)
        {
            var users = new List<MusLunarUser>();
            //SqlParameter demoPara = new SqlParameter();

            //demoPara.ParameterName = "@pId"; // Defining Name  
            //demoPara.Value = 1;
            //demoPara.SqlDbType = SqlDbType.Int; // Defining DataType  
            //demoPara.Direction = ParameterDirection.Input;
            await repository.DbContext.LoadStoredProc("spGetusers")
                //.WithSqlParam("@pId", demoPara)
                //.WithSqlParam("id", "1") // Sample code to add params to provided stored procedure
                .ExecuteStoredProcAsync(result =>
                {
                    // Read value to list
                    users = result.ReadNextListOrEmpty<MusLunarUser>();
                    // Sample code to read to value
                    // var getOne = result.ReadToValue<int>() 
                });


            return users;
        }
    }
}
