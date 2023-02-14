using Microsoft.EntityFrameworkCore.Metadata;
using timsoft.entities;
using timsoft.repositories;

namespace timsoft.services
{
    public class RéclamationService : IRéclamationService
    {

        private IRéclamationRepository _repository;

        public RéclamationService(IRéclamationRepository RéclamationRepository)
        {

            _repository = RéclamationRepository;
        }

        public Réclamation AddRéclamation(RéclamationForm réclamation)
        {
            return _repository.AddRéclamation(réclamation);
        }

        public string DeleteRéclamation(int id)
        {
            return _repository.DeleteRéclamation(id);
        }

        public Réclamation GetRéclamationById(int id)
        {
            return _repository.GetRéclamationById(id);
        }

        public List<Réclamation> Get_All()
        {
            return _repository.Get_All();
        }

        public string UpdateRéclamation(RéclamationForm réclamation, int id)
        {
            return _repository.UpdateRéclamation(réclamation, id);
        }
    }
}

