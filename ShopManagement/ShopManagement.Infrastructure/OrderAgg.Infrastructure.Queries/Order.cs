

namespace OrderAgg.Infrastructure.Queries
{
    public class Order
    {
        public long Id { get; set; }
        public long AccountId { get;  set; }
        public int PaymentMethod { get;  set; }
        public double TotalAmount { get;  set; }
        public double DiscountAmount { get;  set; }
        public double PayAmount { get;  set; }
        public bool IsPaid { get;  set; }
        public bool IsCanceled { get;  set; }
        public string IssueTrackingNo { get;  set; }
        public long RefId { get;  set; }
        public List<OrderItem> Items { get;  set; }
    }
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
    public class Product
    {
        public long Id { get; set; }
        public string Name { get;  set; }
        public string Code { get;  set; }
        public string ShortDescription { get;  set; }
        public string Description { get;  set; }
        public string Picture { get;  set; }
        public string PictureAlt { get;  set; }
        public string PictureTitle { get;  set; }
        public long CategoryId { get;  set; }
        public string Slug { get;  set; }
        public string Keywords { get;  set; }
        public string MetaDescription { get;  set; }
    }
}
