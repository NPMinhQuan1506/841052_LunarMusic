﻿using ApplicationTier.Domain.Entities;
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
    public class CustomerUserService : ICustomerUserService
    {
        private readonly IUnitOfWork _unitOfWork;
        public CustomerUserService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<IList<MusLunarCustomerUser>> GetAll()
        {
            return await _unitOfWork.Repository<MusLunarCustomerUser>().GetAllAsync();

        }

        public async Task<MusLunarCustomerUser> GetOne(int Id)
        {
            return await _unitOfWork.Repository<MusLunarCustomerUser>().FindAsync(Id);
        }

        public async Task<MusLunarCustomerUser> GetOneByUsername(string Username)
        {
            return await CustomerUserRepository.GetOneByUsername(_unitOfWork.Repository<MusLunarCustomerUser>(), Username);
        }

        public async Task Update(MusLunarCustomerUser objInput)
        {
            try
            {
                await _unitOfWork.BeginTransaction();

                var repos = _unitOfWork.Repository<MusLunarCustomerUser>();
                var obj = await repos.FindAsync(objInput.Id);
                if (obj == null)
                    throw new KeyNotFoundException();
                if (objInput.Password != null)
                    obj.Password = objInput.Password;                
                if (objInput.LastSignin != null)
                    obj.LastSignin = objInput.LastSignin;
                if (objInput.IsBlock != null)
                    obj.IsBlock = objInput.IsBlock;
                if (objInput.BlockTime != null)
                    obj.BlockTime = objInput.BlockTime;
                if (objInput.BlockTime != null)
                    obj.Note = objInput.Note;
                obj.Modified = DateTime.UtcNow;

                obj.CreatedBy = objInput.CreatedBy ?? 1;
                obj.State = 1;

                await _unitOfWork.CommitTransaction();
            }
            catch (Exception e)
            {
                await _unitOfWork.RollbackTransaction();
                throw;
            }
        }

        public async Task Add(MusLunarCustomerUser objInput)
        {
            try
            {
                await _unitOfWork.BeginTransaction();

                var repos = _unitOfWork.Repository<MusLunarCustomerUser>();
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

                var repos = _unitOfWork.Repository<MusLunarCustomerUser>();
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
