using timsoft.entities;

namespace timsoft.repositories
{
    public interface IReponseRepository
    {
        Reponse AddReponse(ReponseForm reponse);
        String UpdateReponse(ReponseForm reponse, int id);
        List<Reponse> GetAllReponses();
        Reponse GetReponseById(int id);
        string DeleteReponse(int id);
    }
}
