using timsoft.entities;

namespace timsoft.services
{
    public interface IRéclamationService
    {

        Réclamation AddRéclamation(RéclamationForm réclamation);
        string DeleteRéclamation(int id);
        Réclamation GetRéclamationById(int id);
        List<Réclamation> Get_All();
        string UpdateRéclamation(RéclamationForm réclamation, int id);
    }
}
