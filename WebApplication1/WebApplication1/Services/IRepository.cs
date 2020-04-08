using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Model;

namespace WebApplication1.Services
{
    public interface IRepository<T> where T:class
    {
        IEnumerable<T> GetAll();
        T FindById(int id);
        T Add(T entity);
    }
}
