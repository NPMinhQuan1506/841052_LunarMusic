using ApplicationTier.Domain.Entities;
using ApplicationTier.Domain.Interfaces.Services;
using ApplicationTier.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApplicationTier.Infrastructure.Repositories;
using ApplicationTier.Infrastructure;

namespace ApplicationTier.Service
{

    public class EmployeeService: IEmployeeService
    {
        private readonly IUnitOfWork _unitOfEmployee;
        public EmployeeService(IUnitOfWork unitOfEmployee)
        {
            _unitOfEmployee = unitOfEmployee;
        }

        public async Task Add(MusLunarEmployee employeeInput)
        {
            try
            {
                await _unitOfEmployee.BeginTransaction();

                var MusLunarEmployeRepos = _unitOfEmployee.Repository<MusLunarEmployee>();
                await MusLunarEmployeRepos.InsertAsync(employeeInput);

                await _unitOfEmployee.CommitTransaction();
            }
            catch (Exception e)
            {
                await _unitOfEmployee.RollbackTransaction();
                throw;
            }
        }

        public async Task Delete(int EmployeeId)
        {
            try
            {
                await _unitOfEmployee.BeginTransaction();

                var employeeRepos = _unitOfEmployee.Repository<MusLunarEmployee>();
                var MusLunarEmployee = await employeeRepos.FindAsync(EmployeeId);
                if (MusLunarEmployee == null)
                    throw new KeyNotFoundException();

                await employeeRepos.DeleteAsync(MusLunarEmployee);

                await _unitOfEmployee.CommitTransaction();
            }
            catch (Exception e)
            {
                await _unitOfEmployee.RollbackTransaction();
                throw;
            }
        }

        public async Task<IList<MusLunarEmployee>> GetAll()
        {
            return await EmployeeRepository.GetAll(_unitOfEmployee.Repository<MusLunarEmployee>());
        }

        public async Task<MusLunarEmployee> GetOne(int employeeId)
        {
            return await _unitOfEmployee.Repository<MusLunarEmployee>().FindAsync(employeeId);
        }

        public async Task Update(MusLunarEmployee EmployeeInput)
        {
            try
            {
                await _unitOfEmployee.BeginTransaction();

                var employeeRepos = _unitOfEmployee.Repository<MusLunarEmployee>();
                var employee = await employeeRepos.FindAsync(EmployeeInput.Id);
                if (employee == null)
                    throw new KeyNotFoundException();

                employee.Name = employee.Name;

                await _unitOfEmployee.CommitTransaction();
            }
            catch (Exception e)
            {
                await _unitOfEmployee.RollbackTransaction();
                throw;
            }
        }
    }
}
