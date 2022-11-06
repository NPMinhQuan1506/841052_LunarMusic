using ApplicationTier.Domain.Entities;
using ApplicationTier.Domain.Interfaces.Services;
using ApplicationTier.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApplicationTier.API.Controllers
{
    [Route("api/employee")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeService _EmployeeService;
        public EmployeeController(IEmployeeService EmployeeService)
        {
            _EmployeeService = EmployeeService;
        }
        [HttpGet]
        public async Task<IList<MusLunarEmployee>> GetAll()
        {
            return await _EmployeeService.GetAll();
        }

        [HttpPut]
        public async Task Update(MusLunarEmployee work)
        {
            await _EmployeeService.Update(work);
        }

        [HttpGet("{id:int}")]
        public async Task<MusLunarEmployee> GetOne([FromRoute] int id)
        {
            return await _EmployeeService.GetOne(id);
        }

        [HttpPost]
        public async Task Add(MusLunarEmployee work)
        {
            await _EmployeeService.Add(work);
        }

        [HttpDelete("{id}")]
        public async Task Delete([FromRoute] int id)
        {
            await _EmployeeService.Delete(id);
        }

    }
}
