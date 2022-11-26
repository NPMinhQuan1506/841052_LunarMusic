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
    public class EmployeeService: IEmployeeService
    {
        private readonly IUnitOfWork _unitOfWork;
        public EmployeeService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<IList<MusLunarEmployee>> GetAll()
        {
            return await _unitOfWork.Repository<MusLunarEmployee>().GetAllAsync();
            //return await SongRepository.GetAll(_unitOfWork.Repository<MusLunarSong>());
        }

        public async Task<MusLunarEmployee> GetOne(int Id)
        {
            return await _unitOfWork.Repository<MusLunarEmployee>().FindAsync(Id);
        }

        public async Task Update(MusLunarEmployee objInput)
        {
            try
            {
                await _unitOfWork.BeginTransaction();

                var repos = _unitOfWork.Repository<MusLunarEmployee>();
                var obj = await repos.FindAsync(objInput.Id);
                if (obj == null)
                    throw new KeyNotFoundException();

                obj.Name = objInput.Name;
                obj.NameNoSign = objInput.NameNoSign;
                obj.LastName = objInput.LastName;
                obj.GenderId = objInput.GenderId;
                obj.BirthDay = objInput.BirthDay;
                obj.Phone = objInput.Phone;
                obj.Address = objInput.Address;
                obj.Note = objInput.Note;
                obj.Created = DateTime.UtcNow;
                obj.CreatedBy = objInput.CreatedBy;
                obj.State = 1;
                if (obj.NickName != null)
                {
                    obj.NickName = objInput.NickName;
                }
                if (obj.Email != null)
                {
                    obj.Email = objInput.Email;
                }
                if (obj.AssistantEmail != null)
                {
                    obj.AssistantEmail = objInput.AssistantEmail;
                }
                if (obj.BackgroundImage != null)
                {
                    obj.BackgroundImage = objInput.BackgroundImage;
                }
                if (obj.Avartar != null)
                {
                    obj.Avartar = objInput.Avartar;
                }

                await _unitOfWork.CommitTransaction();
            }
            catch (Exception e)
            {
                await _unitOfWork.RollbackTransaction();
                throw;
            }
        }

        public async Task Add(MusLunarEmployee objInput)
        {
            try
            {
                await _unitOfWork.BeginTransaction();

                var repos = _unitOfWork.Repository<MusLunarEmployee>();
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

                var repos = _unitOfWork.Repository<MusLunarEmployee>();
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
