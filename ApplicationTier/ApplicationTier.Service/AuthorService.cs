using ApplicationTier.Domain.Entities;
using ApplicationTier.Domain.Interfaces;
using ApplicationTier.Infrastructure;
using ApplicationTier.Infrastructure.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationTier.Service
{
    public class AuthorService
    {
        private readonly IUnitOfWork _unitOfWork;
        public AuthorService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task Add(MusLunarAuthor AuthorInput)
        {
            try
            {
                await _unitOfWork.BeginTransaction();

                var MusLunarAuthorRepos = _unitOfWork.Repository<MusLunarAuthor>();
                await MusLunarAuthorRepos.InsertAsync(AuthorInput);

                await _unitOfWork.CommitTransaction();
            }
            catch (Exception e)
            {
                await _unitOfWork.RollbackTransaction();
                throw;
            }
        }

        public async Task Delete(int AuthorId)
        {
            try
            {
                await _unitOfWork.BeginTransaction();

                var AuthorRepos = _unitOfWork.Repository<MusLunarAuthor>();
                var MusLunarAuthor = await AuthorRepos.FindAsync(AuthorId);
                if (MusLunarAuthor == null)
                    throw new KeyNotFoundException();

                await AuthorRepos.DeleteAsync(MusLunarAuthor);

                await _unitOfWork.CommitTransaction();
            }
            catch (Exception e)
            {
                await _unitOfWork.RollbackTransaction();
                throw;
            }
        }

        public async Task<IList<MusLunarAuthor>> GetAll()
        {
            return await AuthorRepository.GetAll(_unitOfWork.Repository<MusLunarAuthor>());
        }

        public async Task<MusLunarAuthor> GetOne(int AuthorId)
        {
            return await _unitOfWork.Repository<MusLunarAuthor>().FindAsync(AuthorId);
        }

        public async Task Update(MusLunarAuthor AuthorInput)
        {
            try
            {
                await _unitOfWork.BeginTransaction();

                var AuthorRepos = _unitOfWork.Repository<MusLunarAuthor>();
                var Author = await AuthorRepos.FindAsync(AuthorInput.Id);
                if (Author == null)
                    throw new KeyNotFoundException();

                Author.Name = Author.Name;

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
