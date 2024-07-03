using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using static MS.PROM.BACKEND.Models.Formatclass;

namespace MS.PROM.BACKEND.Controllers
{
   
    [ApiController]
    public class SectionTemplateController : ControllerBase
    {
        private readonly Service.UserService _userservice;

        private readonly Service.MatserDataService _masterdataservice;

        public SectionTemplateController(Service.UserService userservice, Service.MatserDataService masterdataservice)
        {
            _userservice = userservice;
            _masterdataservice = masterdataservice;
        }

        //[HttpGet]
        //[Route("api/sectionTemplate")]
        //public ActionResult<IEnumerable<MidasDTO.TbPfcSectionTemplate>> GetSectionTemplate(int plantdepID)
        //{
        //    var log = _masterdataservice.getSectionTemplate(plantdepID).ToList();
        //    return log;

        //}

        [HttpGet]
        [Route("api/sectionTemplate")]
        public async Task<ActionResult<SectionTemplate>> GetsectionTeplate(int plandepId)
        {
            var machines = _masterdataservice.GetSectionTemplete(plandepId);

            if (machines == null)
            {
                return NotFound();
            }

            return machines;
        }



        //[HttpPost("api/sectionTemplate")]
        //public IActionResult SaveAllocation(MidasDTO.TbPfcSectionTemplate sectionTemplate)
        //{
        //    var res = _masterdataservice.saveSectionTemplate(sectionTemplate);
        //    if (res != null)
        //    {
        //        return Ok(res);
        //    }
        //    else
        //    {
        //        return BadRequest();
        //    }
        //}


    }
}
