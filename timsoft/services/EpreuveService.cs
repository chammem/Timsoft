using Microsoft.EntityFrameworkCore.Metadata;
using timsoft.entities;
using timsoft.repositories;

namespace timsoft.services
{
    public class EpreuveService : IEpreuveService
    {

        private IEpreuveRepository _repository;

        public EpreuveService(IEpreuveRepository EpreuveRepository)
        {

            _repository = EpreuveRepository;
        }

        public Epreuve AddEpreuve(EpreuveForm epreuve)
        {
            return _repository.AddEpreuve(epreuve);
        }

        public string DeleteEpreuve(int id)
        {
            return _repository.DeleteEpreuve(id);
        }

        public Epreuve GetEpreuveById(int id)
        {
            return _repository.GetEpreuveById(id);
        }

        public List<Epreuve> Get_All()
        {
            return _repository.Get_All();
        }

        public string UpdateEpreuve(EpreuveForm epreuve, int id)
        {
            return _repository.UpdateEpreuve(epreuve, id);

        }
    }


}
