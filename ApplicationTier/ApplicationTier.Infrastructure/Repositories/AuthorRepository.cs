using ApplicationTier.Domain.Interfaces;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApplicationTier.Domain.Entities;
using ApplicationTier.Infrastructure.Extensions;

namespace ApplicationTier.Infrastructure.Repositories
{
    public static class AuthorRepository
    {
        /// <summary>
        /// Get all items of Author table from stored procedure
        /// </summary>
        /// <param name="repository"></param>
        /// <returns></returns>
        public static async Task<IList<MusLunarAuthor>> GetAll(this IRepository<MusLunarAuthor> repository)
        {
            var Authors = new List<MusLunarAuthor>();
            //SqlParameter demoPara = new SqlParameter();

            //demoPara.ParameterName = "@pId"; // Defining Name  
            //demoPara.Value = 1;
            //demoPara.SqlDbType = SqlDbType.Int; // Defining DataType  
            //demoPara.Direction = ParameterDirection.Input;
            await repository.DbContext.LoadStoredProc("spGetAuthors")
                //.WithSqlParam("@pId", demoPara)
                //.WithSqlParam("id", "1") // Sample code to add params to provided stored procedure
                .ExecuteStoredProcAsync(result =>
                {
                    // Read value to list
                    Authors = result.ReadNextListOrEmpty<MusLunarAuthor>();
                    // Sample code to read to value
                    // var getOne = result.ReadToValue<int>() 
                });


            return Authors;
        }
    }
}
