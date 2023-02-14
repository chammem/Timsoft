using timsoft.entities;

namespace timsoft.repositories
{
    public interface IEpreuveRepository
    {
        Epreuve AddEpreuve(EpreuveForm epreuve);
        string DeleteEpreuve(int id);
        Epreuve GetEpreuveById(int id);
        List<Epreuve> Get_All();
        string UpdateEpreuve(EpreuveForm epreuve, int id);
    }
}

