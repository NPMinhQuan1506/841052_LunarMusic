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
    public class SingerService : ISingerService
    {
        private readonly IUnitOfWork _unitOfWork;
        public SingerService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<IList<MusLunarSinger>> GetAll()
        {
            return await _unitOfWork.Repository<MusLunarSinger>().GetAllAsync();
            //return await SingerRepository.GetAll(_unitOfWork.Repository<MusLunarSinger>());
        }

        public async Task<MusLunarSinger> GetOne(int Id)
        {
            return await _unitOfWork.Repository<MusLunarSinger>().FindAsync(Id);
        }

        public async Task Update(MusLunarSinger objInput)
        {
            try
            {
                await _unitOfWork.BeginTransaction();

                var repos = _unitOfWork.Repository<MusLunarSinger>();
                var obj = await repos.FindAsync(objInput.Id);
                if (obj == null)
                    throw new KeyNotFoundException();

                obj.Name = objInput.Name;
                obj.NameNoSign = objInput.NameNoSign;
                obj.NickName = objInput.NickName;
                obj.LastName = objInput.LastName;
                obj.GenderId = objInput.GenderId;
                obj.BirthDay = objInput.BirthDay;
                obj.Avartar = objInput.Avartar;
                obj.Phone = objInput.Phone;
                obj.Email = objInput.Email;
                obj.Description = objInput.Description;
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

        public async Task Add(MusLunarSinger objInput)
        {
            try
            {
                await _unitOfWork.BeginTransaction();

                var repos = _unitOfWork.Repository<MusLunarSinger>();
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

                var repos = _unitOfWork.Repository<MusLunarSinger>();
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
