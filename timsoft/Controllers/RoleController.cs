using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using timsoft.entities;
using timsoft.services;

namespace timsoft.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoleController : ControllerBase

    {

        private IRoleService roleService;
        public RoleController(IRoleService roleService)
        {
            this.roleService = roleService;
        }

        [HttpPost]
        [Route("AddRole")]
        public ActionResult AddRole(RoleForm role)
        {
            return Ok(roleService.AddRole(role));
        }
       

        [HttpGet]
        [Route("GetAllRole")]
        public ActionResult GetAllRoles()
        { 
            return Ok(roleService.GetAllRoles()); 
        }

       
        [HttpPut]
        [Route("UpdateRole")]
        public ActionResult UpdateRole(RoleForm role, int id)
        {
            return Ok(roleService.UpdateRole(role, id));

        }

        [HttpDelete]
        [Route("DeleteRole")]
        public ActionResult DeleteRole(int id)
        {
            return Ok(roleService.DeleteRole(id));
        }
    }
    
}
