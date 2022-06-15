namespace ArageekWebsite.Repository
{
    public interface IGenericCRUD<S> where S : class
    {
        void Add(S entity,int UserID);
        void Update(S entity, int UserID);
        void Delete(S entity);
        S Get(int id);
        List<S> Get();
    }
}
