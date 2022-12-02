using ApplicationTier.Domain.Entities;
using ApplicationTier.Domain.Interfaces.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ApplicationTier.MainApp.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SongGroupController : Controller
    {
        private readonly ISongGroupService _service;
        public SongGroupController(ISongGroupService service)
        {
            _service = service;
        }
        [AllowAnonymous]
        [HttpPost("getAll")]
        public async Task<IList<MusLunarSongGroup>> getAll()
        {
            return await _service.GetAll();
            //return null;
        }

        [AllowAnonymous]
        [HttpPost("getOne")]
        public async Task<MusLunarSongGroup> getOne(int id)
        {
            return await _service.GetOne(id);
            //return null;
        }

        [Authorize]
        [HttpPost("Update")]
        public async Task Update(MusLunarSongGroup obj)
        {
            await _service.Update(obj);
        }

        [Authorize]
        [HttpPost("Add")]
        public async Task Add(MusLunarSongGroup obj)
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
