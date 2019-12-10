using System.Linq;
using Microsoft.EntityFrameworkCore;
using RepositoryPattern.Business.Domain;
using RepositoryPattern.Business.Repositories;

namespace RepositoryPattern.DataAccess.Repositories
{
    public class CategoryRepository:Repository<Category>,ICategoryRepository
    {
        public CategoryRepository(AppDbContext context) : base(context)
        {
        }

        public Category GetCategoryWithProducts(int id)
        {
            return AppDbContext.Categories.Include(c => c.Products).FirstOrDefault(c => c.Id == id);
        }

        public AppDbContext AppDbContext => Context as AppDbContext;
    }
}
