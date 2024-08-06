namespace E_CommerceSystemV2.DAL.Data.Models
{
    public class BasketItem
    {
        public Guid Id { get; set; }
        public string ProductName { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public string CustomerBasketId { get; set; } = string.Empty;
        public CustomerBasket? customerBasket { get; set; }
    }
}