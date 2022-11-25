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
    public class spFavouriteMusicGenService : ISPFavouriteMusicGenService
    {
        private readonly IUnitOfWork _unitOfWork;
        public spFavouriteMusicGenService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<IList<spFavouriteMusicGeneral>> GetAll(string datefrom, string dateto)
        {
            return await spFavouriteMusicGenRepository.GetAll(_unitOfWork.Repository<spFavouriteMusicGeneral>(), datefrom, dateto);
        }

    }
}
