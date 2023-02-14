using Microsoft.EntityFrameworkCore.Metadata;
using timsoft.DataBase;
using timsoft.entities;

namespace timsoft.repositories
{
    public class EpreuveRepository : IEpreuveRepository
    {
        private DataBaseContext _context;
        public EpreuveRepository(DataBaseContext dataBaseContext)
        {

            _context = dataBaseContext;

        }

        public Epreuve AddEpreuve(EpreuveForm epreuve)
        {
            Epreuve dbEpreuve = new Epreuve();

            dbEpreuve.NomEpreuve = epreuve.NomEpreuve;

            dbEpreuve.Duree = epreuve.Duree;

            dbEpreuve.SommePoints = epreuve.SommePoints;

            dbEpreuve.Complexité = epreuve.Complexité;

            var type_Epreuves = _context.Type_Epreuve.Where(u => u.IdType == epreuve.type_Epreuves).FirstOrDefault();



            dbEpreuve.Type_Epreuves = type_Epreuves;

            dbEpreuve.UserEpreuves = new List<UserEpreuve>();

            dbEpreuve.Question = new List<Question>();

            _context.Epreuve.Add(dbEpreuve);

            _context.SaveChanges();
            return dbEpreuve;
        }

       

        public string DeleteEpreuve(int id)
        {
            Epreuve e = _context.Epreuve.Where(i => i.IdEpreuve == id).FirstOrDefault();

            if (e == null)
                throw new NullReferenceException();

            _context.Epreuve.Remove(e);
            _context.SaveChanges();
            return "Epreuve supprimé !";
        }

        public Epreuve GetEpreuveById(int id)
        {
            Epreuve ep = new Epreuve();
            ep = _context.Epreuve.Where(i => i.IdEpreuve == id).FirstOrDefault();
            return ep;
        }

        public List<Epreuve> Get_All()
        {
            List<Epreuve> ep = new List<Epreuve>();
            ep = _context.Epreuve.ToList();
            return ep;
        }

        public string UpdateEpreuve(EpreuveForm epreuve, int id)
        {
            var itemToUpdate = _context.Epreuve.Where(i => i.IdEpreuve == id).FirstOrDefault();
            if (itemToUpdate == null)
                throw new NullReferenceException();

            itemToUpdate.NomEpreuve = epreuve.NomEpreuve;
            itemToUpdate.Duree = epreuve.Duree;
            itemToUpdate.SommePoints = epreuve.SommePoints;
            itemToUpdate.Complexité = epreuve.Complexité;
            _context.SaveChanges();
            return "Epreuve modifié";
        }

        
    }


}

