using ApplicationTier.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationTier.Domain.Interfaces.Services
{
    public interface ISPFavouriteMusicDetailService
    {
        Task<IList<spFavouriteMusicDetail>> GetAll(string datefrom, string dateto, int genresID);
    }
}
