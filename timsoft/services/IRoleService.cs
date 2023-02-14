using timsoft.entities;

namespace timsoft.services
{
    public interface IRoleService
    {
        Role AddRole(RoleForm role);
        string UpdateRole(RoleForm role, int id);
        string DeleteRole(int id);
        List<Role> GetAllRoles();
    }
}
