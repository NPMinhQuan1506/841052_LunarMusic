using ApplicationTier.Domain.Entities;
using ApplicationTier.Domain.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;

namespace ApplicationTier.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SongController : Controller
    {
            private readonly ISongService _service;
            public SongController(ISongService service)
            {
                _service = service;
            }

            #region CRUD

            [HttpGet]
            public async Task<IList<MusLunarSong>> GetAll()
            {
                return await _service.GetAll();
            }

            [HttpPut]
            public async Task Update(MusLunarSong obj)
            {
                await _service.Update(obj);
            }

            [HttpGet("{id:int}")]
            public async Task<MusLunarSong> GetOne([FromRoute] int id)
            {
                return await _service.GetOne(id);
            }

            [HttpPost]
            public async Task Add(MusLunarSong obj)
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
