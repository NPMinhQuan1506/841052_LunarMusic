using ApplicationTier.Domain.Entities;
using ApplicationTier.Domain.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;

namespace ApplicationTier.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MusicGenreController : ControllerBase
    {
        private readonly IMusicGenreService _service;
        public MusicGenreController(IMusicGenreService service)
        {
            _service = service;
        }

        #region CRUD

        [HttpGet]
        public async Task<IList<MusLunarMusicGenre>> GetAll()
        {
            return await _service.GetAll();
        }

        [HttpPut]
        public async Task Update(MusLunarMusicGenre obj)
        {
            await _service.Update(obj);
        }

        [HttpGet("{id:int}")]
        public async Task<MusLunarMusicGenre> GetOne([FromRoute] int id)
        {
            return await _service.GetOne(id);
        }

        [HttpPost]
        public async Task Add(MusLunarMusicGenre obj)
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
