using System;
using RepositoryPattern.Business.Repositories;

namespace RepositoryPattern.Business
{
    public interface IUnitOfWork:IDisposable
    {
        ICategoryRepository Categories { get; }
        IProductRepository Products { get; }
        int Commit();
    }
}
