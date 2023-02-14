using timsoft.entities;

namespace timsoft.repositories
{
    public interface IType_EpreuveRepository
    {
        Type_Epreuve AddType_Epreuve(string type_Epreuve);
        String UpdateType_Epreuve(string type_Epreuve, int id);
        List<Type_Epreuve> GetAllType_Epreuves();
        Type_Epreuve GetType_EpreuveById(int id);
        string DeleteType_Epreuve(int id);
    }
}
