namespace ArageekWebsite.Repository
{
    public interface IGenericCRUD<S> where S : class
    {
        void Add(S entity,string UserID);
        void Update(S entity, string UserID);
        void Delete(S entity);
        S Get(int id);
        List<S> Get();
    }
}
