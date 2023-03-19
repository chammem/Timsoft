using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using timsoft.entities;
using timsoft.services;

namespace timsoft.Controllers
{
    [Route("Epreuve/")]
    [ApiController]
    public class EpreuveController : ControllerBase

    {
        private IEpreuveService EpreuveService;

        public EpreuveController(IEpreuveService EpreuveService)
        {
            this.EpreuveService = EpreuveService;
        }

        [HttpPost]
        [Route("AddEpreuve")]
        public ActionResult AddEpreuve( EpreuveForm epreuve)
        {
            return Ok(EpreuveService.AddEpreuve(epreuve));
        }

        [HttpDelete]
        [Route("DeleteEpreuve")]
        public ActionResult DeleteEpreuve( int id)
        {
            return Ok(EpreuveService.DeleteEpreuve(id));
        }

        [HttpPut]
        [Route("UpdateEpreuve")]
        public ActionResult UpdateEpreuve( EpreuveForm epreuve, int id)
        {
            return Ok(EpreuveService.UpdateEpreuve(epreuve, id));
        }

        [HttpGet]
        [Route("GetEpreuveById")]
        public ActionResult GetEpreuveById( int id)
        {
            return Ok(EpreuveService.GetEpreuveById(id));
        }

        [HttpGet]
        [Route("Get_AllEpreuve")]
        public ActionResult Get_All()
        {
            return Ok(EpreuveService.Get_All());
        }
    }
}