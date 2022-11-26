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
        Task<MusLunarAuthor> GetOne(int Id);
        Task Update(MusLunarAuthor objInput);
        Task Add(MusLunarAuthor objInput);
        Task Delete(int Id);
    }
}
