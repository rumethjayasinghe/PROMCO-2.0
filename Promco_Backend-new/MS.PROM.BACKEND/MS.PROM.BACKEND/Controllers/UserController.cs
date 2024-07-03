using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MS.PROM.BACKEND.Models;
using MS.PROM.BACKEND.Service;
using System.Collections.Generic;

namespace MS.PROM.BACKEND.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : Controller
    {
        private readonly Service.UserService _userservice;

        public UserController(Service.UserService userservice)
        {
            _userservice = userservice;
        }

        [HttpGet]
        public ActionResult<IEnumerable<MidasDTO.TbPfcUser>> GetAllUsres()
        {
            var employees = _userservice.GetAll().ToList();
            return employees;

        }

    }
}
