using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using static MS.PROM.BACKEND.Models.Formatclass;

namespace MS.PROM.BACKEND.Controllers
{
   
    [ApiController]
    public class MainSectionController : ControllerBase
    {
        private readonly Service.UserService _userservice;

        private readonly Service.MatserDataService _masterdataservice;

        public MainSectionController(Service.UserService userservice, Service.MatserDataService masterdataservice)
        {
            _userservice = userservice;
            _masterdataservice = masterdataservice;
        }

        //[HttpGet]
        //[Route("api/mainSection")]
        //public ActionResult<IEnumerable<MidasDTO.TbPfcMainSection>> GetNMainSection(int plantdepID)
        //{
        //    var log = _masterdataservice.getMainSections(plantdepID).ToList();
        //    return log;
            
        //}

        [HttpGet]
        [Route("api/mainSection")]
        public async Task<ActionResult<MainSectionCount>> GetMainSection(int plandepId)
        {
            var machines = _masterdataservice.GetMainSection(plandepId);

            if (machines == null)
            {
                return NotFound();
            }

            return machines;
        }

    }
}
