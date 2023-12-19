namespace E_CommerceSystemV2.DAL.Data.Models
{
    public class Tag
    {
        public Guid TagId { get; set; }

        public string Name { get; set; } = string.Empty;

        //NavProp
        public ICollection<Product> Products { get; set; }= new HashSet<Product>();
        public ICollection<TagProducts> TagProducts { get; set; } = new HashSet<TagProducts>();
    }
}
