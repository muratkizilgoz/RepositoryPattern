using System.Collections.Generic;
using RepositoryPattern.Business.Domain;

namespace RepositoryPattern.Business.Repositories
{
    public interface ICategoryRepository:IRepository<Category>
    {
        Category GetCategoryWithProducts(int id);
    }
}
