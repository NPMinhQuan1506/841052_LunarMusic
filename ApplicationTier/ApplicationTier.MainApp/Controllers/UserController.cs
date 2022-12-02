using ApplicationTier.Domain.Entities;
using ApplicationTier.Domain.Interfaces.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ApplicationTier.MainApp.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : Controller
    {
        private readonly IUserService _service;
        public UserController(IUserService service)
        {
            _service = service;
        }
        [AllowAnonymous]
        [HttpPost("getAll")]
        public async Task<IList<MusLunarUser>> getAll()
        {
            return await _service.GetAll();
            //return null;
        }

        [AllowAnonymous]
        [HttpPost("getOne")]
        public async Task<MusLunarUser> getOne(int id)
        {
            return await _service.GetOne(id);
            //return null;
        }

        [Authorize]
        [HttpPost("Update")]
        public async Task Update(MusLunarUser obj)
        {
            await _service.Update(obj);
        }

        [Authorize]
        [HttpPost("Add")]
        public async Task Add(MusLunarUser obj)
        {
            await _service.Add(obj);
        }

        [Authorize]
        [HttpPost("Delete")]
        public async Task Delete(int id)
        {
            await _service.Delete(id);
        }
    }
}
