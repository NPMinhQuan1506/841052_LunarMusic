using ApplicationTier.API.Comon;
using ApplicationTier.API.Model;
using ApplicationTier.Domain.Entities;
using ApplicationTier.Domain.Interfaces.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ApplicationTier.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthoController : ControllerBase
    {
        private readonly ICustomerUserService _userservice;
        private readonly ICustomerService _custservice;
        private readonly IConfiguration _configuration;
        public AuthoController(ICustomerUserService userservice, ICustomerService custservice, IConfiguration configuration)
        {
            _userservice = userservice;
            _custservice = custservice;
            _configuration = configuration;
        }

        #region Authentication Customer
        [AllowAnonymous]
        [HttpPost, Route("Login")]
        public async Task<ActionResult<string>> Login(CustAutho obj)
        {
            GlobalUser gb = new GlobalUser();
            var user = await _userservice.GetOneByUsername(obj.Username);
            if(user == null)
            {
                return StatusCode(StatusCodes.Status401Unauthorized, new { message = "User not found" });
            }  
            if (user.Password != obj.Password)
            {
                return StatusCode(StatusCodes.Status401Unauthorized, new { message = "Wrong password" });
            }
            string token = gb.CreateToken(obj, _configuration["Jwt:Key"].ToString()
                           , _configuration["Jwt:Issuer"].ToString());

            await _userservice.Update(new MusLunarCustomerUser
            {
                Id = user.Id,
                LastSignin = DateTime.Now,
            });
            return Ok(token);
        }

        [HttpPost, Route("Register")]
        public async Task<ActionResult<CustAutho>> Register(CustAutho obj)
        {
            var objCust = new MusLunarCustomer()
            {
                Name = "",
                Email = obj.Email,
                BirthDay = obj.BirthDay,
                Created = DateTime.Now,
            };            
            await _custservice.Add(objCust);
            var objUSer = new MusLunarCustomerUser()
            {
                Username = obj.Username,
                Password = obj.Password,
                Created = DateTime.Now,
                CustomerId = objCust.Id
            };
            await _userservice.Add(objUSer);

            return Ok(obj);
        }

        #endregion
    }
}
