namespace ShopManagement.Core.Domain.OrderAgg.Entities
{
    public class OrderItem
    {
        public long ProductId { get;  set; }
        public int Count { get;  set; }
        public double UnitPrice { get;  set; }
        public int DiscountRate { get;  set; }
        public long OrderId { get;  set; }
        public Order Order { get;  set; }

        public OrderItem(long productId, int count, double unitPrice, int discountRate)
        {
            ProductId = productId;
            Count = count;
            UnitPrice = unitPrice;
            DiscountRate = discountRate;
        }
    }
}

