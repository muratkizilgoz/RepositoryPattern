using RepositoryPattern.Business;
using RepositoryPattern.Business.Repositories;
using RepositoryPattern.DataAccess.Repositories;

namespace RepositoryPattern.DataAccess
{
    public class UnitOfWork:IUnitOfWork
    {
        private readonly AppDbContext _context;

        public UnitOfWork(AppDbContext context)
        {
            _context = context;
            Categories = new CategoryRepository(_context);
            Products = new ProductRepository(_context);
        }

        public ICategoryRepository Categories { get; }
        public IProductRepository Products { get; }

        public int Commit()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
