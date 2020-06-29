using DataAccess.EFCore.Core.Service.Implement;
using DataAccess.EFCore.Core.Service.Interface;

namespace DataAccess.EFCore.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationContext _context;
        public UnitOfWork(ApplicationContext context)
        {
            _context = context;
            Developer = new DeveloperRepository(_context);
            Project = new ProjectRepository(_context);
        }
        public IDeveloperRepository Developer { get; private set; }

        public IProjectRepository Project { get; private set; }

        public int Complete()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
