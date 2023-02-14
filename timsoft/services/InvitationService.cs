using Microsoft.EntityFrameworkCore.Metadata;
using timsoft.entities;
using timsoft.repositories;

namespace timsoft.services
{
    public class InvitationService : IInvitationService
    {

        private IInvitationRepository _repository;

        public InvitationService(IInvitationRepository invitationRepository)
        {

            _repository = invitationRepository;
        }

        public string DeleteInvitation(int id)
        {
            return _repository.DeleteInvitation(id);
        }

        public Invitation GetInvitationById(int id)
        {
            return _repository.GetInvitationById(id);
        }

        public List<Invitation> Get_All()
        {
            return _repository.Get_All();
        }

        public string UpdateInvitation(InvitationForm invitation, int id)
        {
            return _repository.UpdateInvitation(invitation, id);
        }

        Invitation IInvitationService.AddInvitation(InvitationForm invitation)
        {
            return _repository.AddInvitation(invitation);
        }
    }
}


