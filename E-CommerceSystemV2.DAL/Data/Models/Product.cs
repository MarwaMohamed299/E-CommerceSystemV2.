using E_CommerceSystemV2.DAL.Data.Types;

namespace E_CommerceSystemV2.DAL.Data.Models
{
    public class Product
    {
        public Guid ProductId { get; set; }
        public string? Name { get; set; }
        public CategoryType CategoryType { get; set; }
        public decimal Price { get; set; }

        //NavProp
        public Category? Category { get; set; }
        public ICollection<TagProducts> TagProducts { get; set; } = new HashSet<TagProducts>();
        public Guid OrderId { get; set; }
        public Order? Order { get; set; } 
    }
}
