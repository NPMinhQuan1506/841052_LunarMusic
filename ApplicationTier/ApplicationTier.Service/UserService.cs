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
        private readonly IUnitOfUser _unitOfUser;

        public UserService(IUnitOfUser unitOfUser)
        {
            _unitOfUser = unitOfUser;
        }

        public async Task Add(MusLunarUser userInput)
        {
            try
            {
                await _unitOfUser.BeginTransaction();

                var MusLunarUserRepos = _unitOfUser.Repository<MusLunarUser>();
                await MusLunarUserRepos.InsertAsync(userInput);

                await _unitOfUser.CommitTransaction();
            }
            catch (Exception e)
            {
                await _unitOfUser.RollbackTransaction();
                throw;
            }
        }

        public async Task Delete(int UserId)
        {
            try
            {
                await _unitOfUser.BeginTransaction();

                var userRepos = _unitOfUser.Repository<MusLunarEmployee>();
                var MusLunarUser = await userRepos.FindAsync(UserId);
                if (MusLunarUser == null)
                    throw new KeyNotFoundException();

                await userRepos.DeleteAsync(MusLunarUser);

                await _unitOfUser.CommitTransaction();
            }
            catch (Exception e)
            {
                await _unitOfUser.RollbackTransaction();
                throw;
            }
        }

        public async Task<IList<MusLunarUser>> GetAll()
        {
            return await UserRepository.GetAll(_unitOfUser.Repository<MusLunarUser>());

        }

        public Task<MusLunarUser> GetOne(int userId)
        {
            throw new NotImplementedException();
        }

        public async Task Update(MusLunarUser UserInput)
        {
            try
            {
                await _unitOfUser.BeginTransaction();

                var userRepos = _unitOfUser.Repository<MusLunarUser>();
                var user = await userRepos.FindAsync(UserInput.Id);
                if (user == null)
                    throw new KeyNotFoundException();

                user.Username = user.Username;

                await _unitOfUser.CommitTransaction();
            }
            catch (Exception e)
            {
                await _unitOfUser.RollbackTransaction();
                throw;
            }
        }
    }
}
