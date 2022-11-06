using ApplicationTier.Domain.Entities;
using ApplicationTier.Domain.Interfaces;
using ApplicationTier.Domain.Interfaces.Services;
using ApplicationTier.Infrastructure;
using ApplicationTier.Infrastructure.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationTier.Service
{
    public class UserService: IUserService
    {
        private readonly IUnitOfWork _unitOfWork;

        public UserService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task<IList<MusLunarUser>> GetAll()
        {
            return await UserRepository.GetAll(_unitOfWork.Repository<MusLunarUser>());

        }

        public async Task<MusLunarUser> GetOne(int userId)
        {
            return await _unitOfWork.Repository<MusLunarUser>().FindAsync(userId);
        }

        public async Task Add(MusLunarUser userInput)
        {
            try
            {
                await _unitOfWork.BeginTransaction();

                var MusLunarUserRepos = _unitOfWork.Repository<MusLunarUser>();
                await MusLunarUserRepos.InsertAsync(userInput);

                await _unitOfWork.CommitTransaction();
            }
            catch (Exception e)
            {
                await _unitOfWork.RollbackTransaction();
                throw;
            }
        }

        public async Task Delete(int UserId)
        {
            try
            {
                await _unitOfWork.BeginTransaction();

                var userRepos = _unitOfWork.Repository<MusLunarUser>();
                var MusLunarUser = await userRepos.FindAsync(UserId);
                if (MusLunarUser == null)
                    throw new KeyNotFoundException();

                await userRepos.DeleteAsync(MusLunarUser);

                await _unitOfWork.CommitTransaction();
            }
            catch (Exception e)
            {
                await _unitOfWork.RollbackTransaction();
                throw;
            }
        }

        public async Task Update(MusLunarUser UserInput)
        {
            try
            {
                await _unitOfWork.BeginTransaction();

                var userRepos = _unitOfWork.Repository<MusLunarUser>();
                var user = await userRepos.FindAsync(UserInput.Id);
                if (user == null)
                    throw new KeyNotFoundException();

                user.Username = user.Username;

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
