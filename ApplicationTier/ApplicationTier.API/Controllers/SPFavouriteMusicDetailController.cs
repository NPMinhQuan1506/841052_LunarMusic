using ApplicationTier.Domain.Entities;
using ApplicationTier.Domain.Interfaces.Services;
using ApplicationTier.Service;
using Microsoft.AspNetCore.Mvc;

namespace ApplicationTier.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SPFavouriteMusicDetailController : ControllerBase
    {

        private readonly ISPFavouriteMusicDetailService _service;
        public SPFavouriteMusicDetailController(ISPFavouriteMusicDetailService service)
        {
            _service = service;
        }

        #region CRUD

        [HttpGet("{datefrom}/{dateto}/{genresID:int}")]
        public async Task<IList<spFavouriteMusicDetail>> GetAll([FromRoute] string datefrom, [FromRoute] string dateto, [FromRoute] int genresID)
        {
            return await _service.GetAll(datefrom, dateto, genresID);
        }


        #endregion
    }
}
