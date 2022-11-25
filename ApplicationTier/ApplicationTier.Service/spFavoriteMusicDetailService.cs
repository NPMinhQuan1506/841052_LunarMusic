using ApplicationTier.Domain.Entities;
using ApplicationTier.Domain.Interfaces.Services;
using ApplicationTier.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApplicationTier.Infrastructure.Repositories;
namespace ApplicationTier.Service
{
    public class spFavouriteMusicDetailService : ISPFavouriteMusicDetailService
    {
        private readonly IUnitOfWork _unitOfWork;
        public spFavouriteMusicDetailService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<IList<spFavouriteMusicDetail>> GetAll(string datefrom, string dateto, int genresID)
        {
            return await spFavouriteMusicDetailRepository.GetAll(_unitOfWork.Repository<spFavouriteMusicDetail>(), datefrom, dateto, genresID);
        }

    }
}
