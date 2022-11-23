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
    public class CustomerGroupService : ICustomerGroupService
    {
        private readonly IUnitOfWork _unitOfWork;
        public CustomerGroupService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<IList<MusLunarCustomerGroup>> GetAll()
        {
            return await _unitOfWork.Repository<MusLunarCustomerGroup>().GetAllAsync();
            //return await CustomerGroupRepository.GetAll(_unitOfWork.Repository<MusLunarCustomerGroup>());
        }

        public async Task<MusLunarCustomerGroup> GetOne(int Id)
        {
            return await _unitOfWork.Repository<MusLunarCustomerGroup>().FindAsync(Id);
        }

        public async Task Update(MusLunarCustomerGroup objInput)
        {
            try
            {
                await _unitOfWork.BeginTransaction();

                var repos = _unitOfWork.Repository<MusLunarCustomerGroup>();
                var obj = await repos.FindAsync(objInput.Id);
                if (obj == null)
                    throw new KeyNotFoundException();

                obj.Name = objInput.Name;
                obj.Image = objInput.Image;
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

        public async Task Add(MusLunarCustomerGroup objInput)
        {
            try
            {
                await _unitOfWork.BeginTransaction();

                var repos = _unitOfWork.Repository<MusLunarCustomerGroup>();
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

                var repos = _unitOfWork.Repository<MusLunarCustomerGroup>();
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
