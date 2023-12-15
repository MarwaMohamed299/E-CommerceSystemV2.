namespace E_CommerceSystemV2.DAL.Data.Models
{
    public class UserOrders
    {
        public string? Id { get; set; }
        public Guid OrderId { get; set; }
        public Order? Order { get; set; }
        public User? User { get; set; }
    }
}
