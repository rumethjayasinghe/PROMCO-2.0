using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MS.PROM.BACKEND.MidasDTO;
using System.Net;
using System.Xml.Linq;
using Microsoft.AspNetCore.Mvc;

namespace MS.PROM.BACKEND.Controllers
{
    
    [ApiController]
    [Route("[controller]")]
    public class LoginController : ControllerBase
    {
  
        private readonly Service.UserService _userservice;

        public LoginController(Service.UserService userservice)
        {
            _userservice = userservice;
        }


        [HttpGet]
        public ActionResult<string> Login(string email,string password)
        {
            var log =   _userservice.UserLogin(email,password);
            return log;
            //return await _context.AbpUsers.FromSqlRaw($"Select * from AbpUsers where EmailAddress = '{email}'").ToListAsync();
        }

    }
}
