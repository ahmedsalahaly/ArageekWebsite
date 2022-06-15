using ArageekWebsite.Data;
using ArageekWebsite.Models;
using ArageekWebsite.Repository;

namespace ArageekWebsite.Services
{
    public class AutherService : IAuther
    {
        ApplicationDbContext dbContext = new ApplicationDbContext();
        public void Add(Auther entity)
        {
            if (!IsExist(entity))
            {
                entity.CreatedDate = DateTime.Now;
                dbContext.authers.Add(entity);
                dbContext.SaveChanges();
            }
        }

        public void Delete(Auther entity)
        {
            if (IsExistById(entity.Id))
            {
                dbContext.authers.Remove(Get(entity.Id));
                dbContext.SaveChanges();
            }
        }

        public Auther Get(int id)
        {
            if (IsExistById(id))
            {
                return dbContext.authers.Find(id);
            }
            return null;
        }

        public List<Auther> Get()
        {
            return dbContext.authers.ToList();
        }

        public bool IsExist(Auther entity)
        {
            return dbContext.authers.Any(x => x.Name == entity.Name);
        }

        public bool IsExistById(int Id)
        {
            return dbContext.authers.Any(x => x.Id == Id);
        }

        public void Update(Auther entity)
        {
            if (IsExist(entity))
            {
                Auther oldAther = Get(entity.Id);
                oldAther.Name = entity.Name;
                dbContext.authers.Update(oldAther);
                dbContext.SaveChanges();
            }
        }
    }
}
