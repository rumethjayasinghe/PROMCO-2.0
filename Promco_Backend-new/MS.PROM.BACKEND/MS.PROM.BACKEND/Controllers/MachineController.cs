using Microsoft.AspNetCore.Mvc;
using static MS.PROM.BACKEND.Models.Formatclass;
using static MS.PROM.BACKEND.Service.MatserDataService;

namespace MS.PROM.BACKEND.Controllers
{
    [ApiController]
    
    public class MachineController : Controller
    {
        private readonly Service.UserService _userservice;

        private readonly Service.MatserDataService _masterdataservice;

        public MachineController(Service.UserService userservice, Service.MatserDataService masterdataservice)
        {
            _userservice = userservice;
            _masterdataservice = masterdataservice;
        }

        //[HttpGet]
        //[Route("api/Machine")]
        //public ActionResult<IEnumerable<MidasDTO.TbPfcMachine>> GetMachine(int plantdepID)
        //{
        //    var log = _masterdataservice.getMachines(plantdepID).ToList();
        //    var count  = log.Count();
        //    return log ;



        //    // public ActionResult<IEnumerable<MidasDTO.TbPfcUser>> GetAllUsres()
        //    //return await _context.AbpUsers.FromSqlRaw($"Select * from AbpUsers where EmailAddress = '{email}'").ToListAsync();
        //}

        [HttpGet]
       // [HttpGet("{plandepId}")]
        [Route("api/Machine")]
        public async Task<ActionResult<MachineUserCount>> GetMachines(int plandepId)
        {
            var machines = _masterdataservice.GetMachine(plandepId);

            if (machines == null)
            {
                return NotFound();
            }

            return machines;
        }



    }
}
