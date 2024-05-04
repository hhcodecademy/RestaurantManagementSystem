using Microsoft.EntityFrameworkCore;
using RMS.DAL.Data;
using RMS.DAL.Models;
using RMS.DAL.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS.DAL.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : BaseEntitiy
    {
        private readonly RMSDbContext _dbContext;
        private readonly DbSet<T> _dbSet;
        public GenericRepository()
        {
            _dbContext = new();
            _dbSet = _dbContext.Set<T>();
        }
        public T Add(T entity)
        {
            _dbSet.Add(entity);
            _dbContext.SaveChanges();
            return entity;
        }

        public void Delete(int id)
        {
            var entity = _dbSet.Find(id);
            _dbSet.Remove(entity);
            _dbContext.SaveChanges();
        }

        public T Get(int id)
        {
            return _dbSet.Find(id);
             
        }

        public IList<T> GetAll()
        {
            return _dbSet.ToList();
        }

        public void Update(int id,T entity)
        {
            var dbEntity = _dbSet.Find(id);
            if (dbEntity != null)
            {
                dbEntity = entity;
                dbEntity.Id = id;
                _dbContext.Entry(dbEntity).State = EntityState.Modified;
                _dbSet.Update(dbEntity);
                _dbContext.SaveChanges();
            }
        }
    }
}
