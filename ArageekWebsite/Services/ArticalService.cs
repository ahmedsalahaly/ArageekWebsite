using ArageekWebsite.Data;
using ArageekWebsite.Models;
using ArageekWebsite.Repository;

namespace ArageekWebsite.Services
{
    public class ArticalService : IArtical
    {
        ApplicationDbContext dbContext = new ApplicationDbContext();
        public void Add(Artical entity)
        {
            if (!IsExist(entity))
            {
                entity.CreatedDate = DateTime.Now;
                dbContext.articals.Add(entity);
                dbContext.SaveChanges();
            }
        }

        public void Delete(Artical entity)
        {
            if (IsExistById(entity.Id))
            {
                dbContext.articals.Remove(Get(entity.Id));
                dbContext.SaveChanges();
            }
        }

        public Artical Get(int id)
        {
            if (IsExistById(id))
            {
                return dbContext.articals.Find(id);
            }
            return null;
        }

        public List<Artical> Get()
        {
            return dbContext.articals.ToList();
        }

        public bool IsExist(Artical entity)
        {
            return dbContext.articals.Any(x => x.Name == entity.Name);
        }

        public bool IsExistById(int Id)
        {
            return dbContext.articals.Any(x => x.Id == Id);   
        }

        public void Update(Artical entity)
        {
            if (IsExist(entity))
            {
                Artical oldArtical = Get(entity.Id);
                oldArtical.Name = entity.Name;
                dbContext.articals.Update(oldArtical);
                dbContext.SaveChanges();
            }
        }
    }
}
