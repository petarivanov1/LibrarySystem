using LibrarySystem.Data.Contracts;
using Bytes2you.Validation;

namespace LibrarySystem.Data.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ILibrarySystemDbContext context;

        public UnitOfWork(ILibrarySystemDbContext context)
        {
            Guard.WhenArgument(context, "DbContext can not be null.").IsNull().Throw();

            this.context = context;
        }

        public void SaveChanges()
        {
            this.context.SaveChanges();
        }

        public void Dispose()
        {
        }
    }
}
