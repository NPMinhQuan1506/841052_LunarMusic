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
    public class SongService: ISongService
    {
        private readonly IUnitOfWork _unitOfWork;
        public SongService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<IList<MusLunarSong>> GetAll()
        {
            return await _unitOfWork.Repository<MusLunarSong>().GetAllAsync();
            //return await SongRepository.GetAll(_unitOfWork.Repository<MusLunarSong>());
        }

        public async Task<MusLunarSong> GetOne(int Id)
        {
            return await _unitOfWork.Repository<MusLunarSong>().FindAsync(Id);
        }

        public async Task Update(MusLunarSong objInput)
        {
            try
            {
                await _unitOfWork.BeginTransaction();

                var repos = _unitOfWork.Repository<MusLunarSong>();
                var obj = await repos.FindAsync(objInput.Id);
                if (obj == null)
                    throw new KeyNotFoundException();

                obj.Name = objInput.Name;
                obj.Source = objInput.Source;
                obj.PlayTimeInt = objInput.PlayTimeInt;
                if(obj.Image != null)
                {
                    obj.Image = objInput.Image;
                }
                if (obj.IsPro != null)
                {
                    obj.IsPro = objInput.IsPro;
                }
                obj.UnitPrice = objInput.UnitPrice;
                obj.GenresId = objInput.GenresId;
                obj.AuthorId = objInput.AuthorId;
                obj.SingerId = objInput.SingerId;
                obj.GroupId = objInput.GroupId;
                obj.NationalId = objInput.NationalId;
                if (obj.Lyrics != null)
                {
                    obj.Lyrics = objInput.Lyrics;
                }
                if (obj.Note != null)
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

        public async Task Add(MusLunarSong objInput)
        {
            try
            {
                await _unitOfWork.BeginTransaction();

                var repos = _unitOfWork.Repository<MusLunarSong>();
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

                var repos = _unitOfWork.Repository<MusLunarSong>();
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
