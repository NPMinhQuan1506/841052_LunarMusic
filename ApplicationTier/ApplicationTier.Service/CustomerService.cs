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
    public class CustomerService : ICustomerService
    {
        private readonly IUnitOfWork _unitOfWork;
        public CustomerService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<IList<MusLunarCustomer>> GetAll()
        {
            return await _unitOfWork.Repository<MusLunarCustomer>().GetAllAsync();
            //return await CustomerRepository.GetAll(_unitOfWork.Repository<MusLunarCustomer>());
        }

        public async Task<MusLunarCustomer> GetOne(int Id)
        {
            return await _unitOfWork.Repository<MusLunarCustomer>().FindAsync(Id);
        }

        public async Task Update(MusLunarCustomer objInput)
        {
            try
            {
                await _unitOfWork.BeginTransaction();

                var repos = _unitOfWork.Repository<MusLunarCustomer>();
                var obj = await repos.FindAsync(objInput.Id);
                if (obj == null)
                    throw new KeyNotFoundException();

                obj.Name = objInput.Name;
                obj.NameNoSign = objInput.NameNoSign;
                obj.NickName = objInput.NickName;
                obj.LastName = objInput.LastName;
                obj.GenderId = objInput.GenderId;
                obj.BirthDay = objInput.BirthDay;
                obj.Phone = objInput.Phone;
                obj.Email = objInput.Email;
                obj.AssistantEmail = objInput.AssistantEmail;
                obj.Address = objInput.Address;
                obj.Avartar = objInput.Avartar;
                obj.BackgroundImage = objInput.BackgroundImage;

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

        public async Task Add(MusLunarCustomer objInput)
        {
            try
            {
                await _unitOfWork.BeginTransaction();

                var repos = _unitOfWork.Repository<MusLunarCustomer>();
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

                var repos = _unitOfWork.Repository<MusLunarCustomer>();
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
