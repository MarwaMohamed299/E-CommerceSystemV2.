namespace E_CommerceSystemV2.DAL.Data.Models
{
    public class Category
    {
        public Guid CategoryId { get; set; }
        public string Name { get; set; } = string.Empty;

        //NavProp
        public ICollection<Product> Products { get; set; } = new HashSet<Product>();
    }
}
