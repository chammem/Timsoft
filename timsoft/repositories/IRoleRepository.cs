using timsoft.entities;

namespace timsoft.repositories
{
    public interface IRoleRepository
    {
        Role AddRole(RoleForm role);
        string UpdateRole(RoleForm role, int id);
        string DeleteRole(int id);
        List<Role> GetAllRoles();
        
    }
}
