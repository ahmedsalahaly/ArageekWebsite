namespace ArageekWebsite.Repository
{
    public interface IGenericCRUD<S> where S : class
    {
        void Add(S entity);
        void Update(S entity);
        void Delete(S entity);
        S Get(int id);
        List<S> Get();
    }
}
