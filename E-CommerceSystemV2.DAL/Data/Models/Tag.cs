namespace E_CommerceSystemV2.DAL.Data.Models
{
    public class Tag
    {
        public Guid TagId { get; set; }

        // TODO: Shouldn't be nullable
        public string? Name { get; set; }

        //NavProp
        public ICollection<Product> Products { get; set; }= new HashSet<Product>();
        public ICollection<TagProducts> TagProducts { get; set; } = new HashSet<TagProducts>();
    }
}
