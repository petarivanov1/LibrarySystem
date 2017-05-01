using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using LibrarySystem.Data.Contracts;
using LibrarySystem.Data.Models.Models;
using Microsoft.AspNet.Identity.EntityFramework;

namespace LibrarySystem.Data
{
    public class LibrarySystemDbContext : IdentityDbContext<User>, ILibrarySystemDbContext
    {
        public LibrarySystemDbContext()
            : base("LibraryDb")
        {
        }

        public new IDbSet<T> Set<T>() where T : class
        {
            return base.Set<T>();
        }

        public virtual IDbSet<Author> Authors { get; set; }
        public virtual IDbSet<Book> Books { get; set; }
        public virtual IDbSet<Genre> Genres { get; set; }
        public virtual IDbSet<Publisher> Publishers { get; set; }
        public virtual IDbSet<Picture> Puctures { get; set; }

        public static LibrarySystemDbContext Create()
        {
            return new LibrarySystemDbContext();
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();
            
            base.OnModelCreating(modelBuilder);
        }
    }
}
