using RMS.BL.Services.Interfaces;
using RMS.DAL.Models;
using RMS.DAL.Repositories;
using RMS.DAL.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS.BL.Services
{
    public class GenericService<T> : IGenericService<T> where T : BaseEntitiy
    {
        private readonly IGenericRepository<T> _repository;
        public GenericService()
        {
            _repository = new GenericRepository<T>();
        }
        public T Add(T entity)
        {
            return _repository.Add(entity);
        }

        public void Delete(int id)
        {
            _repository.Delete(id);
        }

        public T Get(int id)
        {
            return _repository.Get(id);
        }

        public IList<T> GetAll()
        {
            return _repository.GetAll();
        }

        public void Update(int id,T entity)
        {
            _repository.Update(id,entity);
        }
    }
}
