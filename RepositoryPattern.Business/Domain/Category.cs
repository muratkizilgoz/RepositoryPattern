using System.Collections.Generic;

namespace RepositoryPattern.Business.Domain
{
    public class Category:BaseDomain
    {
        public IList<Product> Products { get; set; }

    }
}
