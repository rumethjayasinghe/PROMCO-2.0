using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using static MS.PROM.BACKEND.Models.Formatclass;

namespace MS.PROM.BACKEND.Controllers
{
    
    [ApiController]
    public class ShiftController : ControllerBase
    {

        private readonly Service.UserService _userservice;

        private readonly Service.MatserDataService _masterdataservice;

        public ShiftController(Service.UserService userservice, Service.MatserDataService masterdataservice)
        {
            _userservice = userservice;
            _masterdataservice = masterdataservice;
        }

        //[HttpGet]
        //[Route("api/shift")]
        //public ActionResult<IEnumerable<MidasDTO.TbPfcShift>> Login(int plantdepID)
        //{
        //    var log = _masterdataservice.getShifts(plantdepID).ToList();
        //    return log;

        //}


        [HttpGet]
        [Route("api/shift")]
        public async Task<ActionResult<Shift>> Getshift(int plandepId)
        {
            var machines = _masterdataservice.GetShift(plandepId);

            if (machines == null)
            {
                return NotFound();
            }

            return machines;
        }


    }
}
