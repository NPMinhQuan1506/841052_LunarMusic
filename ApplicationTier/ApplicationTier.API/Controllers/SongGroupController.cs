using ApplicationTier.Domain.Entities;
using ApplicationTier.Domain.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;

namespace ApplicationTier.API.Controllers
{
    public class SongGroupController : Controller
    {

        private readonly ISongGroupService _service;
        public SongGroupController(ISongGroupService service)
        {
            _service = service;
        }

        #region CRUD

        [HttpGet]
        public async Task<IList<MusLunarSongGroup>> GetAll()
        {
            return await _service.GetAll();
        }

        [HttpPut]
        public async Task Update(MusLunarSongGroup obj)
        {
            await _service.Update(obj);
        }

        [HttpGet("{id:int}")]
        public async Task<MusLunarSongGroup> GetOne([FromRoute] int id)
        {
            return await _service.GetOne(id);
        }

        [HttpPost]
        public async Task Add(MusLunarSongGroup obj)
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
