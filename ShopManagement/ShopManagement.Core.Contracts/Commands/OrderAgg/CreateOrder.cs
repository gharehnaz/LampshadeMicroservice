namespace ShopManagement.Core.Contracts.Commands.OrderAgg
{
    public class CreateOrder
    {
        public long AccountId { get; set; }
        public int PaymentMethod { get; set; }
        public double TotalAmount { get; set; }
        public double DiscountAmount { get; set; }
        public double PayAmount { get; set; }
        public bool IsPaid { get; set; }
        public bool IsCanceled { get; set; }
        public string IssueTrackingNo { get; set; }
        public long RefId { get; set; }
        public List<OrderItem> Items { get; set; }
    }
}
