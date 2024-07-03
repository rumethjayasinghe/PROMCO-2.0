using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using static MS.PROM.BACKEND.Models.Formatclass;

namespace MS.PROM.BACKEND.Controllers
{
    
    [ApiController]
    public class ParameterController : ControllerBase
    {
        private readonly Service.UserService _userservice;

        private readonly Service.MatserDataService _masterdataservice;

        public ParameterController(Service.UserService userservice, Service.MatserDataService masterdataservice)
        {
            _userservice = userservice;
            _masterdataservice = masterdataservice;
        }

        //[HttpGet]
        //[Route("api/parameter")]
        //public ActionResult<IEnumerable<MidasDTO.TbPfcParameter>> GetParameter(int plantdepID)
        //{
        //    var log = _masterdataservice.getParameters(plantdepID).ToList();
        //    return log;

        //}

        [HttpGet]
        [Route("api/parameter")]
        public async Task<ActionResult<ParameterCount>> Getparameter(int plandepId)
        {
            var machines = _masterdataservice.GetParameter(plandepId);

            if (machines == null)
            {
                return NotFound();
            }

            return machines;
        }

    }
}
