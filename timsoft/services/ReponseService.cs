using timsoft.entities;
using timsoft.repositories;

namespace timsoft.services
{
    public class ReponseService : IReponseService
    {
        private IReponseRepository _repository;

        public ReponseService(IReponseRepository reponseRepository)
        {
            _repository = reponseRepository;

        }
        public Reponse AddReponse(ReponseForm reponse)
        {
            return _repository.AddReponse(reponse);
        }

        public string DeleteReponse(int id)
        {
            return _repository.DeleteReponse(id);
        }

        public List<Reponse> GetAllReponses()
        {
            return _repository.GetAllReponses();
        }

        public Reponse GetReponseById(int id)
        {
            return _repository.GetReponseById(id);
        }

        public string UpdateReponse(ReponseForm reponse, int id)
        {
            return _repository.UpdateReponse(reponse ,id);
        }
    }
}
