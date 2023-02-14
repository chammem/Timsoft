using Microsoft.EntityFrameworkCore.Metadata;
using timsoft.DataBase;
using timsoft.entities;

namespace timsoft.repositories
{
    public class RéclamationRepository : IRéclamationRepository
    {
        private DataBaseContext _context;
        public RéclamationRepository(DataBaseContext dataBaseContext)
        {

            _context = dataBaseContext;

        }

        public Réclamation AddRéclamation(RéclamationForm réclamation)
        {
            Réclamation dbRéclamation = new Réclamation();

            dbRéclamation.Objet = réclamation.Objet;

            dbRéclamation.Description = réclamation.Description;

            dbRéclamation.Users = new List<User>();

            
            _context.Réclamation.Add(dbRéclamation);

            _context.SaveChanges();
            return dbRéclamation;
        }

        public string DeleteRéclamation(int id)
        {
            Réclamation r = _context.Réclamation.Where(i => i.IdReclam == id).FirstOrDefault();

            if (r == null)
                throw new NullReferenceException();

            _context.Réclamation.Remove(r);
            _context.SaveChanges();
            return "Réclamation supprimé !";
        }

        public Réclamation GetRéclamationById(int id)
        {
            Réclamation rec = new Réclamation();
            rec = _context.Réclamation.Where(i => i.IdReclam == id).FirstOrDefault();
            return rec;
        }

        public List<Réclamation> Get_All()
        {
            List<Réclamation> rec = new List<Réclamation>();
            rec = _context.Réclamation.ToList();
            return rec;
        }

        public string UpdateRéclamation(RéclamationForm réclamation, int id)
        {
            var itemToUpdate = _context.Réclamation.Where(i => i.IdReclam == id).FirstOrDefault();
            if (itemToUpdate == null)
                throw new NullReferenceException();

            itemToUpdate.Objet = réclamation.Objet;
            itemToUpdate.Description = réclamation.Description;
            _context.SaveChanges();
            return "Réclamation modifié";
        }
    }
}
