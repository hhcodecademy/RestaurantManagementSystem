using RMS.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS.DAL.Repositories.Interfaces
{
    public interface IGenericRepository<T> where T : BaseEntitiy
    {
        public T Add(T entity);
        public T Get(int id);
        public IList<T> GetAll();
        public void Update(int id,T entity);
        public void Delete(int id);
    }
}
