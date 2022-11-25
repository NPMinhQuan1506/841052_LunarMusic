using ApplicationTier.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationTier.Domain.Interfaces.Services
{
    public interface ISPFavouriteMusicGenService
    {
        Task<IList<spFavouriteMusicGeneral>> GetAll(string datefrom, string dateto);
    }
}
