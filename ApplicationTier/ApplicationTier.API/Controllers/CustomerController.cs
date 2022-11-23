using ApplicationTier.Domain.Entities;
using ApplicationTier.Domain.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;

namespace ApplicationTier.API.Controllers
{
    public class CustomerController : Controller
    {
        private readonly ICustomerService _service;
        public CustomerController(ICustomerService service)
        {
            _service = service;
        }

        #region CRUD

        [HttpGet]
        public async Task<IList<MusLunarCustomer>> GetAll()
        {
            return await _service.GetAll();
        }

        [HttpPut]
        public async Task Update(MusLunarCustomer obj)
        {
            await _service.Update(obj);
        }

        [HttpGet("{id:int}")]
        public async Task<MusLunarCustomer> GetOne([FromRoute] int id)
        {
            return await _service.GetOne(id);
        }

        [HttpPost]
        public async Task Add(MusLunarCustomer obj)
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
