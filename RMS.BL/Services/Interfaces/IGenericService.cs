using RMS.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS.BL.Services.Interfaces
{
    public interface IGenericService<T> where T : BaseEntitiy
    {
        public T Add(T entity);
        public T Get(int id);
        public IList<T> GetAll();
        public void Update(int id,T entity);
        public void Delete(int id);
    }
    
   
}
