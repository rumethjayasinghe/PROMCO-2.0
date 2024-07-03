using Microsoft.AspNetCore.Mvc;
using MS.PROM.BACKEND.MidasDTO;
using MS.PROM.BACKEND.Models;

namespace MS.PROM.BACKEND.Controllers
{
    [ApiController]
    public class AllocationController : Controller
    {

        private readonly Service.UserService _userservice;

        private readonly Service.MatserDataService _masterdataservice;

        public AllocationController(Service.UserService userservice , Service.MatserDataService masterdataservice)
        {
            _userservice = userservice;
            _masterdataservice = masterdataservice;
        }
  

        [HttpPost("api/allocation")]
        public IActionResult SaveAllocation(MidasDTO.TbPfcAllocation allocationRequestDTO)
        {
           var res = _masterdataservice.SaveAllocation(allocationRequestDTO);
            if(res != null)
            {
                return Ok(res); 
            } else
            {
                return BadRequest();
            }
        }

        [HttpGet("api/allocation/get")]
        public ActionResult<IEnumerable<MidasDTO.TbPfcAllocation>> GetAllUsres()
        {
            var employees = _masterdataservice.GetAll().ToList();
            return employees;

        }

    }


}

