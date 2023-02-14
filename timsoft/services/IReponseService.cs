using timsoft.entities;

namespace timsoft.services
{
    public interface IReponseService
    {
        Reponse AddReponse(ReponseForm reponse);
        String UpdateReponse(ReponseForm reponse, int id);
        List<Reponse> GetAllReponses();
        Reponse GetReponseById(int id);
        String DeleteReponse(int id);
    }
}
