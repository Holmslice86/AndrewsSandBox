using System;
using System.Data.Entity;
using System.Linq;
using CodeNameBravo.DAL.Interfaces.Repository;
using CodeNameBravo.Web.DAL.DataEntities;

namespace CodeNameBravo.Web.DAL.Repository
{
    public class GenericRepository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        private readonly CodeNameBravoContext _context;

        public GenericRepository(CodeNameBravoContext context)
        {
            _context = context;
        }

        public TEntity Find(object id)
        {
            TEntity entity = null;

            entity = _context.Set<TEntity>().Find(id);

            return entity;
        }

        public IQueryable<TEntity> GetAll()
        {
            IQueryable<TEntity> allEntities = null;

            allEntities = _context.Set<TEntity>();

            return allEntities;
        }

        public void Insert(TEntity entity)
        {
            _context.Entry(entity).State = EntityState.Added;
        }

        public void InsertMany(IQueryable<TEntity> entities)
        {
            foreach (TEntity entity in entities)
                _context.Entry(entity).State = EntityState.Added;
        }

        public void Update(TEntity entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
        }

        public void UpdateMany(IQueryable<TEntity> entities)
        {
            foreach (TEntity entity in entities)
                _context.Entry(entity).State = EntityState.Modified;
        }

        public void Delete(int id)
        {
            var entity = _context.Set<TEntity>().Find(id);
            _context.Set<TEntity>().Remove(entity);
        }

        public void Delete(Guid id)
        {
            var entity = _context.Set<TEntity>().Find(id);

            _context.Set<TEntity>().Remove(entity);
        }

        public void DeleteMany(IQueryable<TEntity> entities)
        {
            foreach (TEntity entity in entities)
                _context.Set<TEntity>().Remove(entity);
        }
    }
}
