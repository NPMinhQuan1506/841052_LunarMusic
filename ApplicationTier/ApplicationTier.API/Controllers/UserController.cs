using ApplicationTier.Domain.Entities;
using ApplicationTier.Domain.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;

namespace ApplicationTier.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : Controller
    {
        private readonly IUserService _service;
        public UserController(IUserService service)
        {
            _service = service;
        }

        #region CRUD

        [HttpGet]
        public async Task<IList<MusLunarUser>> GetAll()
        {
            return await _service.GetAll();
        }

        [HttpPut]
        public async Task Update(MusLunarUser obj)
        {
            await _service.Update(obj);
        }

        [HttpGet("{id:int}")]
        public async Task<MusLunarUser> GetOne([FromRoute] int id)
        {
            return await _service.GetOne(id);
        }

        [HttpPost]
        public async Task Add(MusLunarUser obj)
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
