using ApplicationTier.Domain.Entities;
using ApplicationTier.Domain.Interfaces;
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
        private readonly IUnitOfAuthor _unitOfAuthor;
        public AuthorService(IUnitOfAuthor unitOfAuthor)
        {
            _unitOfAuthor = unitOfAuthor;
        }

        public async Task Add(MusLunarAuthor AuthorInput)
        {
            try
            {
                await _unitOfAuthor.BeginTransaction();

                var MusLunarAuthorRepos = _unitOfAuthor.Repository<MusLunarAuthor>();
                await MusLunarAuthorRepos.InsertAsync(AuthorInput);

                await _unitOfAuthor.CommitTransaction();
            }
            catch (Exception e)
            {
                await _unitOfAuthor.RollbackTransaction();
                throw;
            }
        }

        public async Task Delete(int AuthorId)
        {
            try
            {
                await _unitOfAuthor.BeginTransaction();

                var AuthorRepos = _unitOfAuthor.Repository<MusLunarAuthor>();
                var MusLunarAuthor = await AuthorRepos.FindAsync(AuthorId);
                if (MusLunarAuthor == null)
                    throw new KeyNotFoundException();

                await AuthorRepos.DeleteAsync(MusLunarAuthor);

                await _unitOfAuthor.CommitTransaction();
            }
            catch (Exception e)
            {
                await _unitOfAuthor.RollbackTransaction();
                throw;
            }
        }

        public async Task<IList<MusLunarAuthor>> GetAll()
        {
            return await AuthorRepository.GetAll(_unitOfAuthor.Repository<MusLunarAuthor>());
        }

        public async Task<MusLunarAuthor> GetOne(int AuthorId)
        {
            return await _unitOfAuthor.Repository<MusLunarAuthor>().FindAsync(AuthorId);
        }

        public async Task Update(MusLunarAuthor AuthorInput)
        {
            try
            {
                await _unitOfAuthor.BeginTransaction();

                var AuthorRepos = _unitOfAuthor.Repository<MusLunarAuthor>();
                var Author = await AuthorRepos.FindAsync(AuthorInput.Id);
                if (Author == null)
                    throw new KeyNotFoundException();

                Author.Name = Author.Name;

                await _unitOfAuthor.CommitTransaction();
            }
            catch (Exception e)
            {
                await _unitOfAuthor.RollbackTransaction();
                throw;
            }
        }
    }
}
