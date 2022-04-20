using DomainLayer.Common;

namespace DomainLayer.Entities.CustomerEntities
{
    public class Customer : BaseEntity
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public CustomerDetails CustomerDetails { get; set; }
    }
}
