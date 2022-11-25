using ApplicationTier.Domain.Entities;
using ApplicationTier.Domain.Interfaces.Services;
using ApplicationTier.Service;
using Microsoft.AspNetCore.Mvc;

namespace ApplicationTier.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SPFavouriteMusicGenController : ControllerBase
    {

        private readonly ISPFavouriteMusicGenService _service;
        public SPFavouriteMusicGenController(ISPFavouriteMusicGenService service)
        {
            _service = service;
        }

        #region CRUD

        [HttpGet("{datefrom}/{dateto}")]
        public async Task<IList<spFavouriteMusicGeneral>> GetAll([FromRoute] string datefrom, [FromRoute] string dateto)
        {
            return await _service.GetAll(datefrom, dateto);
        }


        #endregion
    }
}
