using System;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using LibrarySystem.Data.Models.Models;

namespace LibrarySystem.Data.Contracts
{
    public interface ILibrarySystemDbContext : IDisposable
    {
        int SaveChanges();

        IDbSet<User> Users { get; set; }

        DbSet<TEntity> Set<TEntity>() where TEntity : class;

        DbEntityEntry<TEntity> Entry<TEntity>(TEntity entity) where TEntity : class;
    }
}
