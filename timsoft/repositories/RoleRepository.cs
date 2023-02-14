using timsoft.DataBase;
using timsoft.entities;

namespace timsoft.repositories
{
    public class RoleRepository : IRoleRepository
    {
        private DataBaseContext _context;
        public RoleRepository(DataBaseContext dataBaseContext)
        {

            _context = dataBaseContext;

        }
    
        public Role AddRole(RoleForm role)
        {
            Role dbRole = new Role();

            dbRole.RoleName = role.RoleName;
            dbRole.Users = new List<User>();
           
            _context.Roles.Add(dbRole);
            _context.SaveChanges();
            return dbRole;
            
        }

        public string DeleteRole(int id)
        {
            Role r = _context.Roles.Where(i => i.IdRole == id).FirstOrDefault();

            if (r == null)
                throw new NullReferenceException();

            _context.Roles.Remove(r);
            _context.SaveChanges();
            return "Role supprimé !";
        }

        public List<Role> GetAllRoles()
        {
            List<Role> ep = new List<Role>();
            ep = _context.Roles.ToList();
            return ep;
        }

        public string UpdateRole(RoleForm role, int id)
        {
            var itemToUpdate = _context.Roles.Where(i => i.IdRole == id).FirstOrDefault();
            if (itemToUpdate == null)
                throw new NullReferenceException();

            itemToUpdate.RoleName = role.RoleName;
            _context.SaveChanges();
            return "Role est modifié";
        }
    }
}
