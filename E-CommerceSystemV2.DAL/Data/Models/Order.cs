namespace E_CommerceSystemV2.DAL.Data.Models
{
    public class Order
    {
        public Guid OrderId { get; set; }
        public DateTime OrderDate { get; set; }
        //nav prop
        public string UserId { get; set; } = string.Empty;
        public User? User { get; set; }
        public ICollection<Product> Products = new HashSet<Product>();
    
    }
}
