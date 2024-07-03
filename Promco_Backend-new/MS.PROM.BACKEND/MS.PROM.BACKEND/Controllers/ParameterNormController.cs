using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using static MS.PROM.BACKEND.Models.Formatclass;

namespace MS.PROM.BACKEND.Controllers
{
    
    [ApiController]
    public class ParameterNormController : ControllerBase
    {

        private readonly Service.UserService _userservice;

        private readonly Service.MatserDataService _masterdataservice;

        public ParameterNormController(Service.UserService userservice, Service.MatserDataService masterdataservice)
        {
            _userservice = userservice;
            _masterdataservice = masterdataservice;
        }

        //[HttpGet]
        //[Route("api/parameterNorms")]
        //public ActionResult<IEnumerable<MidasDTO.TbPfcParameterNorm>> GetParameterNorm(int plantdepID)
        //{
        //    var log = _masterdataservice.getParameterNorms(plantdepID).ToList();
        //    return log;

        //}


        [HttpGet]
        [Route("api/parameterNorms")]
        public async Task<ActionResult<ParametrNormCount>> GetparameterNorm(int plandepId)
        {
            var machines = _masterdataservice.GetParameterNorm(plandepId);

            if (machines == null)
            {
                return NotFound();
            }

            return machines;
        }

    }
}
