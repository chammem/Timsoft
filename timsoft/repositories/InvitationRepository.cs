using Microsoft.EntityFrameworkCore;
using System.Data;
using timsoft.DataBase;
using timsoft.entities;

namespace timsoft.repositories
{
    public class InvitationRepository : IInvitationRepository
    {
        private DataBaseContext _context;
        public InvitationRepository(DataBaseContext dataBaseContext)
        {

            _context = dataBaseContext;

        }

        public string DeleteInvitation(int id)
        {
            Invitation v = _context.Invitation.Where(i => i.IdInv == id).FirstOrDefault();

            if (v == null)
                throw new NullReferenceException();

            _context.Invitation.Remove(v);
            _context.SaveChanges();
            return "Invitation supprimé !";
        }

        public string UpdateInvitation(InvitationForm invitation, int id)
        {
            var itemToUpdate = _context.Invitation.Where(i => i.IdInv == id).FirstOrDefault();
            if (itemToUpdate == null)
                throw new NullReferenceException();

            itemToUpdate.date_inv = invitation.date_inv;
            itemToUpdate.description = invitation.description;
            _context.SaveChanges();
            return "Invitation modifié";
        }

        Invitation IInvitationRepository.AddInvitation(InvitationForm invitation)
        {
            
            Invitation dbInvitation = new Invitation();

            dbInvitation.date_inv = invitation.date_inv;



            dbInvitation.description = invitation.description;



            var user = _context.Users.Where(u => u.IdUser == invitation.user).FirstOrDefault();



            dbInvitation.User = user;


           

            _context.Invitation.Add(dbInvitation);

            _context.SaveChanges();
            return dbInvitation;
        }



        public Invitation GetInvitationById(int id)
        {
            Invitation inv = new Invitation();
            if (inv == null)
                throw new NullReferenceException();
            inv = _context.Invitation.Where(i => i.IdInv == id).FirstOrDefault();
            return inv;
        }

        

        List<Invitation> IInvitationRepository.Get_All()
        {
            List<Invitation> inv = new List<Invitation>();
            inv = _context.Invitation.ToList();
            return inv;
        }


    }
}

