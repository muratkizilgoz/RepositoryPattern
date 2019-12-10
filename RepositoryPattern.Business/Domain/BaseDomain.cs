using System;

namespace RepositoryPattern.Business.Domain
{
    public abstract class BaseDomain
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }

    }
}
