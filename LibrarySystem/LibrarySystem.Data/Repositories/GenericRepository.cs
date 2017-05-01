using System;
using LibrarySystem.Data.Contracts;
using System.Data.Entity;

namespace LibrarySystem.Data.Repositories
{
    public class GenericRepository<T> : IRepository<T> where T : class
    {


        public IDbSet<T> DbSet { get; set; }

        public ILibrarySystemDbContext Context { get; set; }

        public void Add(T entity)
        {
            throw new NotImplementedException();
        }

        public System.Linq.IQueryable<T> All()
        {
            throw new NotImplementedException();
        }

        public void Delete(T entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public void Detach(T entity)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public T GetById(int id)
        {
            throw new NotImplementedException();
        }

        public int SaveChanges()
        {
            throw new NotImplementedException();
        }

        public void Update(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
