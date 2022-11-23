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
    public class CustomerUserService : ICustomerUserService
    {
        private readonly IUnitOfWork _unitOfWork;
        public CustomerUserService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<IList<MusLunarCustomerUser>> GetAll()
        {
            return await _unitOfWork.Repository<MusLunarCustomerUser>().GetAllAsync();
            //return await CustomerUserRepository.GetAll(_unitOfWork.Repository<MusLunarCustomerUser>());
        }

        public async Task<MusLunarCustomerUser> GetOne(int Id)
        {
            return await _unitOfWork.Repository<MusLunarCustomerUser>().FindAsync(Id);
        }

        public async Task Update(MusLunarCustomerUser objInput)
        {
            try
            {
                await _unitOfWork.BeginTransaction();

                var repos = _unitOfWork.Repository<MusLunarCustomerUser>();
                var obj = await repos.FindAsync(objInput.Id);
                if (obj == null)
                    throw new KeyNotFoundException();
                if(obj.Password != null) 
                    obj.Password = objInput.Password;
                if (obj.Password != null) 
                    obj.LastSignin = objInput.LastSignin;
                if (obj.Password != null)
                    obj.IsBlock = objInput.IsBlock;
                if (obj.Password != null)
                    obj.BlockTime = objInput.BlockTime;

                obj.Note = objInput.Note;
                obj.Created = DateTime.UtcNow;
                obj.CreatedBy = objInput.CreatedBy;
                obj.State = 1;

                await _unitOfWork.CommitTransaction();
            }
            catch (Exception e)
            {
                await _unitOfWork.RollbackTransaction();
                throw;
            }
        }

        public async Task Add(MusLunarCustomerUser objInput)
        {
            try
            {
                await _unitOfWork.BeginTransaction();

                var repos = _unitOfWork.Repository<MusLunarCustomerUser>();
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

                var repos = _unitOfWork.Repository<MusLunarCustomerUser>();
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
