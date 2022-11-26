using ApplicationTier.Domain.Entities;
using ApplicationTier.Domain.Interfaces;
using ApplicationTier.Domain.Interfaces.Services;
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
            return await _unitOfWork.Repository<MusLunarUser>().GetAllAsync();
            //return await SongRepository.GetAll(_unitOfWork.Repository<MusLunarSong>());
        }

        public async Task<MusLunarUser> GetOne(int Id)
        {
            return await _unitOfWork.Repository<MusLunarUser>().FindAsync(Id);
        }

        public async Task Update(MusLunarUser objInput)
        {
            try
            {
                await _unitOfWork.BeginTransaction();

                var repos = _unitOfWork.Repository<MusLunarUser>();
                var obj = await repos.FindAsync(objInput.Id);
                if (obj == null)
                    throw new KeyNotFoundException();

                obj.Password = objInput.Password;
                obj.EmployeeId = objInput.EmployeeId;
                obj.LastSignin = objInput.LastSignin;
                if(obj.Note != null)
                {
                    obj.Note = objInput.Note;
                }
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

        public async Task Add(MusLunarUser objInput)
        {
            try
            {
                await _unitOfWork.BeginTransaction();

                var repos = _unitOfWork.Repository<MusLunarUser>();
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

                var repos = _unitOfWork.Repository<MusLunarUser>();
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
