using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using static MS.PROM.BACKEND.Models.Formatclass;

namespace MS.PROM.BACKEND.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SubSectionController : ControllerBase
    {

        private readonly Service.UserService _userservice;

        private readonly Service.MatserDataService _masterdataservice;

        public SubSectionController(Service.UserService userservice, Service.MatserDataService masterdataservice)
        {
            _userservice = userservice;
            _masterdataservice = masterdataservice;
        }

        //[HttpGet]
        //[Route("api/subSection")]
        //public ActionResult<IEnumerable<MidasDTO.TbPfcSubSection>> Login(int plantdepID)
        //{
        //    var log = _masterdataservice.getSubSections(plantdepID).ToList();
        //    return log;

        //}


        [HttpGet]
        [Route("api/subSection")]
        public async Task<ActionResult<SubSection>> GetsubSection(int plandepId)
        {
            var machines = _masterdataservice.GetSubSection(plandepId);

            if (machines == null)
            {
                return NotFound();
            }

            return machines;
        }


    }
}
