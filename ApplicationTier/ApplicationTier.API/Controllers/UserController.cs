using ApplicationTier.Domain.Entities;
using ApplicationTier.Domain.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;

namespace ApplicationTier.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;

        public UserController(IUserService UserService) {
            _userService = UserService;
        }
        [HttpGet]
        public async Task<IList<MusLunarUser>> GetAll()
        {
            return await _userService.GetAll();
        }

        [HttpPut]
        public async Task Update(MusLunarUser work)
        {
            await _userService.Update(work);
        }

        [HttpGet("{id:int}")]
        public async Task<MusLunarUser> GetOne([FromRoute] int id)
        {
            return await _userService.GetOne(id);
        }

        [HttpPost]
        public async Task Add(MusLunarUser work)
        {
            await _userService.Add(work);
        }

        [HttpDelete("{id}")]
        public async Task Delete([FromRoute] int id)
        {
            await _userService.Delete(id);
        }

    }
}
