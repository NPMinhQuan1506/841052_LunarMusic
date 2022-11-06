using ApplicationTier.Domain.Entities;
using ApplicationTier.Domain.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;

namespace ApplicationTier.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SongController : ControllerBase
    {
        private readonly ISongService _SongService;
        public SongController(ISongService SongService)
        {
            _SongService = SongService;
        }
        [HttpGet]
        public async Task<IList<MusLunarSong>> GetAll()
        {
            return await _SongService.GetAll();
        }

        [HttpPut]
        public async Task Update(MusLunarSong song)
        {
            await _SongService.Update(song);
        }

        [HttpGet("{id:int}")]
        public async Task<MusLunarSong> GetOne([FromRoute] int id)
        {
            return await _SongService.GetOne(id);
        }

        [HttpPost]
        public async Task Add(MusLunarSong song)
        {
            await _SongService.Add(song);
        }

        [HttpDelete("{id}")]
        public async Task Delete([FromRoute] int id)
        {
            await _SongService.Delete(id);
        }

    }
}
