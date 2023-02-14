using timsoft.DataBase;
using timsoft.entities;

namespace timsoft.repositories
{
    public class ReponseRepository : IReponseRepository
    {
        private DataBaseContext _context;
        public ReponseRepository(DataBaseContext dataBaseContext)
        {

            _context = dataBaseContext;

        }
        public Reponse AddReponse(ReponseForm reponse)
        {
            Reponse dbReponse = new Reponse();

            dbReponse.Flag = reponse.Flag;



            dbReponse.Question = new List<Question>();


            _context.Reponse.Add(dbReponse);

            _context.SaveChanges();
            return dbReponse;
        }

        public string DeleteReponse(int id)
        {
            Reponse r = _context.Reponse.Where(i => i.IdReponse == id).FirstOrDefault();

            if (r == null)
                throw new NullReferenceException();

            _context.Reponse.Remove(r);
            _context.SaveChanges();
            return "Reponse supprimé !";
        }

        public List<Reponse> GetAllReponses()
        {
            List<Reponse> rl = new List<Reponse>();
            rl = _context.Reponse.ToList();
            return rl;
        }

        public Reponse GetReponseById(int id)
        {
            Reponse r = new Reponse();
            if (r == null)
                throw new NullReferenceException();
            r = _context.Reponse.Where(i => i.IdReponse == id).FirstOrDefault();
            return r;
        }

        public string UpdateReponse(ReponseForm reponse, int id)
        {
            var itemToUpdate = _context.Reponse.Where(i => i.IdReponse == id).FirstOrDefault();
            if (itemToUpdate == null)
                throw new NullReferenceException();

            itemToUpdate.Flag = reponse.Flag;
            _context.SaveChanges();
            return "Reponse modifié";
        }
    }
}
