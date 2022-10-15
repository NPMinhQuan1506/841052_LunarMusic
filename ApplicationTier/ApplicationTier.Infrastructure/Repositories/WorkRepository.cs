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
    public static class WorkRepository
    {
        /// <summary>
        /// Get all items of work table from stored procedure
        /// </summary>
        /// <param name="repository"></param>
        /// <returns></returns>
        public static async Task<IList<Work>> GetAll(this IRepository<Work> repository)
        {
            var works = new List<Work>();
            //SqlParameter demoPara = new SqlParameter();

            //demoPara.ParameterName = "@pId"; // Defining Name  
            //demoPara.SqlDbType = SqlDbType.Int; // Defining DataType  
            //demoPara.Direction = ParameterDirection.Input;
            await repository.DbContext.LoadStoredProc("spGetWorks")
                //.WithSqlParam("@pId", demoPara)
                //.WithSqlParam("id", "1") // Sample code to add params to provided stored procedure
                .ExecuteStoredProcAsync(result =>
                {
                    // Read value to list
                    works = result.ReadNextListOrEmpty<Work>();
                    // Sample code to read to value
                    // var getOne = result.ReadToValue<int>() 
                });


            return works;
        }
    }
}
