namespace RepositoryPattern.Business.Domain
{
    public class Product:BaseDomain
    {
        public Category Category { get; set; }
        public int CategoryId { get; set; }

    }
}
