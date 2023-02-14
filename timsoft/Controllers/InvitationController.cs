using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using timsoft.entities;
using timsoft.services;

namespace timsoft.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InvitationController : ControllerBase

    {
        private IInvitationService invitationService;

        public InvitationController(IInvitationService invitationService)
        {
            this.invitationService = invitationService;
        }

        [HttpPost]
        [Route("AddInvitation")]
        public ActionResult AddInvitation([FromBody] InvitationForm invitation)
        {
            return Ok(invitationService.AddInvitation(invitation));
        }

        [HttpDelete]
        [Route("DeleteInvitation")]
        public ActionResult DeleteInvitation( int id)
        {
            return Ok(invitationService.DeleteInvitation(id));
        }

        [HttpPut]
        [Route("UpdateInvitation")]
        public ActionResult UpdateInvitation(InvitationForm invitation, int id)
        {
            return Ok(invitationService.UpdateInvitation(invitation, id));
        }

        [HttpGet]
        [Route("GetInvitationById")]
        public ActionResult GetInvitationById(int id)
        {
            return Ok(invitationService.GetInvitationById(id));
        }
       
         

        [HttpGet]
        [Route("Get_AllInvitation")]
        public ActionResult Get_All()
        {
            return Ok(invitationService.Get_All());
        }
    }
}
