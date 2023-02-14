using timsoft.entities;

namespace timsoft.repositories
{
    public interface IRéclamationRepository
    {
        Réclamation AddRéclamation(RéclamationForm réclamation);
        string DeleteRéclamation(int id);
        Réclamation GetRéclamationById(int id);
        List<Réclamation> Get_All();
        string UpdateRéclamation(RéclamationForm réclamation, int id);
    }
}