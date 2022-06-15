using ArageekWebsite.Data;
using ArageekWebsite.Models;
using ArageekWebsite.Repository;

namespace ArageekWebsite.Services
{
    public class ArticalService : IArtical
    {
        private readonly ApplicationDbContext dbContext;

        public ArticalService(ApplicationDbContext _dbContext)
        {
            dbContext = _dbContext;
        }
        public void Add(Artical entity, string UserID)
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

        public List<Artical> GetByAutherId(int AutherID)
        {
            return dbContext.articals.Where(x => x.AutherId == AutherID).ToList();
        }

        public bool IsExist(Artical entity)
        {
            return dbContext.articals.Any(x => x.Name == entity.Name);
        }

        public bool IsExistById(int Id)
        {
            return dbContext.articals.Any(x => x.Id == Id);   
        }

        public void Update(Artical entity, string UserID)
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
