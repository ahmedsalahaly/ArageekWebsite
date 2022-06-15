using ArageekWebsite.Models;

namespace ArageekWebsite.Repository
{
    public interface IArtical : IGenericCRUD<Artical>,IValidation<Artical>
    {
        List<Artical> GetByAutherId(int AutherID);
    }
}
