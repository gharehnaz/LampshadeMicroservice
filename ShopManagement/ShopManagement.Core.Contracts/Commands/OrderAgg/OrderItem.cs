namespace ShopManagement.Core.Contracts.Commands.OrderAgg
{
    public class OrderItem
    {
        public long Id { get; set; }
        public long ProductId { get; set; }
        public string Product { get; set; }
        public int Count { get; set; }
        public double UnitPrice { get; set; }
        public int DiscountRate { get; set; }
        public long OrderId { get; set; }
    }
}
