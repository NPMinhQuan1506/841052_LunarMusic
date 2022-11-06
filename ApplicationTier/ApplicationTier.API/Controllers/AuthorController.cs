using ApplicationTier.Domain.Entities;
using ApplicationTier.Domain.Interfaces.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApplicationTier.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthorController : ControllerBase
    {
        private readonly IAuthorService _AuthorService;
        public AuthorController(IAuthorService AuthorService)
        {
            _AuthorService = AuthorService;
        }
        [HttpGet]
        public async Task<IList<MusLunarAuthor>> GetAll()
        {
            return await _AuthorService.GetAll();
        }

        [HttpPut]
        public async Task Update(MusLunarAuthor Author)
        {
            await _AuthorService.Update(Author);
        }

        [HttpGet("{id:int}")]
        public async Task<MusLunarAuthor> GetOne([FromRoute] int id)
        {
            return await _AuthorService.GetOne(id);
        }

        [HttpPost]
        public async Task Add(MusLunarAuthor Author)
        {
            await _AuthorService.Add(Author);
        }

        [HttpDelete("{id}")]
        public async Task Delete([FromRoute] int id)
        {
            await _AuthorService.Delete(id);
        }

    }
}
