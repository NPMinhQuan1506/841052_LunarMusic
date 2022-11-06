using ApplicationTier.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationTier.Domain.Interfaces.Services
{
    public interface IAuthorService
    {
        Task<IList<MusLunarAuthor>> GetAll();
        Task<MusLunarAuthor> GetOne(int authorId);
        Task Update(MusLunarAuthor author);
        Task Add(MusLunarAuthor author);
        Task Delete(int authorId);
    }
}
