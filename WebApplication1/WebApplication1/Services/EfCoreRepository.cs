using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Data;
using WebApplication1.Model;

namespace WebApplication1.Services
{
    public class EfCoreRepository : IRepository<User>
    {
        private readonly DataContext context;

        public EfCoreRepository(DataContext context)
        {
            this.context = context;
        }
        public User Add(User entity)
        {
            context.users.Add(entity);
            context.SaveChanges();
            return entity;

        }

        public User FindById(int id)
        {
            return context.users.Find(id);
        }

        public IEnumerable<User> GetAll()
        {
            return context.users.ToList();
        }
    }
}
