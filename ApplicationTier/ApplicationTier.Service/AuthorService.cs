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
    public class AuthorService: IAuthorService
    {
        private readonly IUnitOfWork _unitOfWork;
        public AuthorService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<IList<MusLunarAuthor>> GetAll()
        {
            return await _unitOfWork.Repository<MusLunarAuthor>().GetAllAsync();
            //return await SongRepository.GetAll(_unitOfWork.Repository<MusLunarSong>());
        }

        public async Task<MusLunarAuthor> GetOne(int Id)
        {
            return await _unitOfWork.Repository<MusLunarAuthor>().FindAsync(Id);
        }

        public async Task Update(MusLunarAuthor objInput)
        {
            try
            {
                await _unitOfWork.BeginTransaction();

                var repos = _unitOfWork.Repository<MusLunarAuthor>();
                var obj = await repos.FindAsync(objInput.Id);
                if (obj == null)
                    throw new KeyNotFoundException();
                
                obj.NickName = objInput.NickName;
                obj.LastName = objInput.LastName;
                obj.GenderId = objInput.GenderId;
                obj.BirthDay = objInput.BirthDay;
                obj.Created = DateTime.UtcNow;
                obj.CreatedBy = objInput.CreatedBy;
                obj.State = 1;
                if (obj.Phone != null)
                {
                    obj.Phone = objInput.Phone;
                }
                if (obj.Name != null)
                {
                    obj.Name = objInput.Name;
                }
                if (obj.NameNoSign != null)
                {
                    obj.NameNoSign = objInput.NameNoSign;
                }
                if (obj.LastName != null)
                {
                    obj.LastName = objInput.LastName;
                }
                if (obj.Description != null)
                {
                    obj.Description = objInput.Description;
                }
                if (obj.Note != null)
                {
                    obj.Note = objInput.Note;
                }
                if (obj.Email != null)
                {
                    obj.Email = objInput.Email;
                }

                await _unitOfWork.CommitTransaction();
            }
            catch (Exception e)
            {
                await _unitOfWork.RollbackTransaction();
                throw;
            }
        }

        public async Task Add(MusLunarAuthor objInput)
        {
            try
            {
                await _unitOfWork.BeginTransaction();

                var repos = _unitOfWork.Repository<MusLunarAuthor>();
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

                var repos = _unitOfWork.Repository<MusLunarAuthor>();
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
