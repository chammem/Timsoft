using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using timsoft.entities;
using timsoft.services;

namespace timsoft.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RéclamationController : ControllerBase

    {
        private IRéclamationService RéclamationService;

        public RéclamationController(IRéclamationService RéclamationService)
        {
            this.RéclamationService = RéclamationService;
        }

        [HttpPost]
        [Route("AddRéclamation")]
        public ActionResult AddRéclamation( RéclamationForm réclamation)
        {
            return Ok(RéclamationService.AddRéclamation(réclamation));
        }

        [HttpDelete]
        [Route("DeleteRéclamation")]
        public ActionResult DeleteRéclamation(int id)
        {
            return Ok(RéclamationService.DeleteRéclamation(id));
        }

        [HttpPut]
        [Route("UpdateRéclamation")]
        public ActionResult UpdateRéclamation( RéclamationForm réclamation, int id)
        {
            return Ok(RéclamationService.UpdateRéclamation(réclamation, id));
        }

        [HttpGet]
        [Route("GetRéclamationById")]
        public ActionResult GetRéclamationById( int id)
        {
            return Ok(RéclamationService.GetRéclamationById(id));
        }

        [HttpGet]
        [Route("Get_AllRéclamation")]
        public ActionResult Get_All()
        {
            return Ok(RéclamationService.Get_All());
        }
    }
}

