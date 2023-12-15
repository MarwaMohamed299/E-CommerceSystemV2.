namespace E_CommerceSystemV2.DAL.Data.Models
{
    public class Order
    {
        public Guid OrderId { get; set; }
        public DateTime OrderDate { get; set; }
        //nav prop
        public ICollection<UserOrders> UserOrders { get; set; } = new HashSet<UserOrders>();
    }
}
