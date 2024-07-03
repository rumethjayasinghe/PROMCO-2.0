using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using static MS.PROM.BACKEND.Models.Formatclass;

namespace MS.PROM.BACKEND.Controllers
{
   
    [ApiController]
    public class MachineTypeController : ControllerBase
    {

        private readonly Service.UserService _userservice;

        private readonly Service.MatserDataService _masterdataservice;

        public MachineTypeController(Service.UserService userservice, Service.MatserDataService masterdataservice)
        {
            _userservice = userservice;
            _masterdataservice = masterdataservice;
        }

        //[HttpGet]
        //[Route("api/MachineType")]
        //public ActionResult<IEnumerable<MidasDTO.TbPfcMachineType>> GetMachineType(int plantdepID)
        //{
        //    var log = _masterdataservice.getMachineType(plantdepID).ToList();
        //    return log;
        //    // public ActionResult<IEnumerable<MidasDTO.TbPfcUser>> GetAllUsres()
        //    //return await _context.AbpUsers.FromSqlRaw($"Select * from AbpUsers where EmailAddress = '{email}'").ToListAsync();
        //}
        [HttpGet]
        //[HttpGet("{plandepId}")]
        [Route("api/MachineType")]
        public async Task<ActionResult<MachineTypeCount>> GetMachinesType(int plandepId)
        {
            var machines = _masterdataservice.GetMachineYype(plandepId);

            if (machines == null)
            {
                return NotFound();
            }

            return machines;
        }

    }
}
