using Microsoft.AspNetCore.Mvc;
using static MS.PROM.BACKEND.Models.Formatclass;

namespace MS.PROM.BACKEND.Controllers
{
    public class MaterialCodeController : Controller
    {
        private readonly Service.UserService _userservice;

        private readonly Service.MatserDataService _masterdataservice;

        public MaterialCodeController(Service.UserService userservice, Service.MatserDataService masterdataservice)
        {
            _userservice = userservice;
            _masterdataservice = masterdataservice;
        }

        //[HttpGet]
        //[Route("api/materialCode")]
        //public ActionResult<IEnumerable<MidasDTO.TbPfcMaterialCode>> GetMaterialCode(int plantdepID)
        //{
        //    var log = _masterdataservice.getMaterialcodes(plantdepID).ToList();
        //    return log;

        //}

        [HttpGet]
        [Route("api/materialCode")]
        public async Task<ActionResult<MaterialCount>> GetmaterialCode(int plandepId)
        {
            var machines = _masterdataservice.GetMaterialCode(plandepId);

            if (machines == null)
            {
                return NotFound();
            }

            return machines;
        }


    }
}
