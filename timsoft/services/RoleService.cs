using System.Data;
using timsoft.entities;
using timsoft.repositories;

namespace timsoft.services
{
    public class RoleService : IRoleService
    {

        private IRoleRepository _repository;

        public RoleService(IRoleRepository RoleRepository)
        {

            _repository = RoleRepository;
        }
   
        public Role AddRole(RoleForm role)
        {
            return _repository.AddRole(role);
        }

        public string DeleteRole(int id)
        {
            return _repository.DeleteRole(id);
        }

        public List<Role> GetAllRoles()
        {
            return _repository.GetAllRoles();
        }

        public string UpdateRole(RoleForm role, int id)
        {
            return _repository.UpdateRole(role, id);
        }
    }
}
