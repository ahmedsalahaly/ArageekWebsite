namespace ArageekWebsite.Repository
{
    public interface IValidation<S> where S : class
    {
        bool IsExist (S entity);
        bool IsExistById (int Id);
    }
}
