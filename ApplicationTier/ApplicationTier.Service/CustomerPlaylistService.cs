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
    public class CustomerPlaylistService : ICustomerPlaylistService
    {
        private readonly IUnitOfWork _unitOfWork;
        public CustomerPlaylistService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<IList<MusLunarCustomerPlaylist>> GetAll()
        {
            return await _unitOfWork.Repository<MusLunarCustomerPlaylist>().GetAllAsync();
            //return await CustomerPlaylistRepository.GetAll(_unitOfWork.Repository<MusLunarCustomerPlaylist>());
        }

        public async Task<MusLunarCustomerPlaylist> GetOne(int Id)
        {
            return await _unitOfWork.Repository<MusLunarCustomerPlaylist>().FindAsync(Id);
        }

        public async Task Update(MusLunarCustomerPlaylist objInput)
        {
            try
            {
                await _unitOfWork.BeginTransaction();

                var repos = _unitOfWork.Repository<MusLunarCustomerPlaylist>();
                var obj = await repos.FindAsync(objInput.Id);
                if (obj == null)
                    throw new KeyNotFoundException();

                obj.ListeningTimes = objInput.ListeningTimes;

                await _unitOfWork.CommitTransaction();
            }
            catch (Exception e)
            {
                await _unitOfWork.RollbackTransaction();
                throw;
            }
        }

        public async Task Add(MusLunarCustomerPlaylist objInput)
        {
            try
            {
                await _unitOfWork.BeginTransaction();

                var repos = _unitOfWork.Repository<MusLunarCustomerPlaylist>();
                await repos.InsertAsync(objInput);

                await _unitOfWork.CommitTransaction();
            }
            catch (Exception e)
            {
                await _unitOfWork.RollbackTransaction();
                throw;
            }
        }

        public async Task Delete(int Id)
        {
            try
            {
                await _unitOfWork.BeginTransaction();

                var repos = _unitOfWork.Repository<MusLunarCustomerPlaylist>();
                var obj = await repos.FindAsync(Id);
                if (obj == null)
                    throw new KeyNotFoundException();

                await repos.DeleteAsync(obj);

                await _unitOfWork.CommitTransaction();
            }
            catch (Exception e)
            {
                await _unitOfWork.RollbackTransaction();
                throw;
            }
        }
    }
}
