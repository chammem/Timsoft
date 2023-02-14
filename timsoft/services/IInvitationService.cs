using timsoft.entities;

namespace timsoft.services
{
    public interface IInvitationService
    {
        Invitation AddInvitation(InvitationForm invitation);
        string DeleteInvitation(int id);
        Invitation GetInvitationById(int id);
        List<Invitation> Get_All();
        string UpdateInvitation(InvitationForm invitation, int id);

    }
}

