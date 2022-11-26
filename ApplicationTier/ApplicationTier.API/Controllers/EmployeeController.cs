using ApplicationTier.Domain.Entities;
using ApplicationTier.Domain.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;

namespace ApplicationTier.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {

        private readonly IEmployeeService _service;
        public EmployeeController(IEmployeeService service)
        {
            _service = service;
        }

        #region CRUD

        [HttpGet]
        public async Task<IList<MusLunarEmployee>> GetAll()
        {
            return await _service.GetAll();
        }

        [HttpPut]
        public async Task Update(MusLunarEmployee obj)
        {
            await _service.Update(obj);
        }

        [HttpGet("{id:int}")]
        public async Task<MusLunarEmployee> GetOne([FromRoute] int id)
        {
            return await _service.GetOne(id);
        }

        [HttpPost]
        public async Task Add(MusLunarEmployee obj)
        {
            await _service.Add(obj);
        }

        [HttpDelete("{id}")]
        public async Task Delete([FromRoute] int id)
        {
            await _service.Delete(id);
        }

        #endregion
    }
}
