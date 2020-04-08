using System.Collections.Generic;
using System.Linq;
using WebApplication1.Model;

namespace WebApplication1.Services
{
    public class InMemoryRepository : IRepository<User>
    {

        private readonly List<User> users;

        public InMemoryRepository()
        {
            users = new List<User>
            {
                new User
                {
                    firstName = "tony", birthday = new System.DateTime(1988,12,19),lastName = "wang",id=1
                },
                new User
                {
                    firstName = "joe", birthday = new System.DateTime(1978,12,19),lastName = "zhang",id=2
                }
            };
        }

        public User Add(User entity)
        {
            var maxId = this.users.Max(x => x.id);
            entity.id = maxId + 1;
            users.Add(entity);
            return entity;

        }

        public User FindById(int id)
        {
            return users.Find(u =>
            {
                return u.id == id;
            });
        }

        public IEnumerable<User> GetAll()
        {
            return users;
        }
    }
}
