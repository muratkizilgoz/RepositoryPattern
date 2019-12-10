using System.Collections.Generic;
using RepositoryPattern.Business.Domain;

namespace RepositoryPattern.Business.Repositories
{
    public interface IProductRepository:IRepository<Product>
    {
        IEnumerable<Product> GetProductsWithCategories(int pageIndex, int pageSize);
    }
}
