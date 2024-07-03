using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using static MS.PROM.BACKEND.Models.Formatclass;

namespace MS.PROM.BACKEND.Controllers
{
    
    [ApiController]
    public class ToleranceController : ControllerBase
    {
        private readonly Service.UserService _userservice;

        private readonly Service.MatserDataService _masterdataservice;

        public ToleranceController(Service.UserService userservice, Service.MatserDataService masterdataservice)
        {
            _userservice = userservice;
            _masterdataservice = masterdataservice;
        }


        [HttpPost("api/tolerance")]
        public IActionResult saveTolerance(MidasDTO.TbPfcTolerance allocationRequestDTO)
        {
            var res = _masterdataservice.saveTolerance(allocationRequestDTO);
            if (res != null)
            {
                return Ok(res);
            }
            else
            {
                return BadRequest();
            }
        }

        //[HttpGet("api/tolerance")]
        //public ActionResult<IEnumerable<MidasDTO.TbPfcTolerance>> GetTolarance(int plantId)
        //{
        //    var employees = _masterdataservice.getToerances(plantId).ToList();
        //    return employees;

        //}


        [HttpGet]
        [Route("api/tolerance")]
        public async Task<ActionResult<Tolarance>> Gettolarance(int plandepId)
        {
            var machines = _masterdataservice.Gettolarance(plandepId);

            if (machines == null)
            {
                return NotFound();
            }

            return machines;
        }

    }
}
