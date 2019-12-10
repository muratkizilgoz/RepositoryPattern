using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using RepositoryPattern.Business.Domain;
using RepositoryPattern.Business.Repositories;

namespace RepositoryPattern.DataAccess.Repositories
{
    public class ProductRepository:Repository<Product>,IProductRepository
    {
        public ProductRepository(AppDbContext context) : base(context)
        {
        }

        public IEnumerable<Product> GetProductsWithCategories(int pageIndex, int pageSize)
        {
            return AppDbContext.Products
                .Include(p => p.Category)
                .OrderByDescending(p => p.Id)
                .Skip((pageIndex - 1) * pageSize)
                .Take(pageSize)
                .ToList();
        }

        public AppDbContext AppDbContext=>Context as AppDbContext;
    }
}
