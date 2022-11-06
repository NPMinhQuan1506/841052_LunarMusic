using ApplicationTier.Domain.Entities;
using ApplicationTier.Domain.Interfaces;
using ApplicationTier.Domain.Interfaces.Services;
using ApplicationTier.Infrastructure.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationTier.Service
{
    public class SongService: ISongService
    {
        private readonly IUnitOfWork _unitOfSong;

        public SongService(IUnitOfWork unitOfSong)
        {
            _unitOfSong = unitOfSong;
        }

        public async Task Add(MusLunarSong songInput)
        {
            try
            {
                await _unitOfSong.BeginTransaction();

                var MusLunarSongRepos = _unitOfSong.Repository<MusLunarSong>();
                await MusLunarSongRepos.InsertAsync(songInput);

                await _unitOfSong.CommitTransaction();
            }
            catch (Exception e)
            {
                await _unitOfSong.RollbackTransaction();
                throw;
            }
        }

        public async Task Delete(int SongId)
        {
            try
            {
                await _unitOfSong.BeginTransaction();

                var songRepos = _unitOfSong.Repository<MusLunarEmployee>();
                var MusLunarSong = await songRepos.FindAsync(SongId);
                if (MusLunarSong == null)
                    throw new KeyNotFoundException();

                await songRepos.DeleteAsync(MusLunarSong);

                await _unitOfSong.CommitTransaction();
            }
            catch (Exception e)
            {
                await _unitOfSong.RollbackTransaction();
                throw;
            }
        }

        public async Task<IList<MusLunarSong>> GetAll()
        {
            return await SongRepository.GetAll(_unitOfSong.Repository<MusLunarSong>());

        }

        public Task<MusLunarSong> GetOne(int songId)
        {
            throw new NotImplementedException();
        }

        public async Task Update(MusLunarSong SongInput)
        {
            try
            {
                await _unitOfSong.BeginTransaction();

                var songRepos = _unitOfSong.Repository<MusLunarSong>();
                var song = await songRepos.FindAsync(SongInput.Id);
                if (song == null)
                    throw new KeyNotFoundException();

                song.Name = song.Name;

                await _unitOfSong.CommitTransaction();
            }
            catch (Exception e)
            {
                await _unitOfSong.RollbackTransaction();
                throw;
            }
        }
    }
}
