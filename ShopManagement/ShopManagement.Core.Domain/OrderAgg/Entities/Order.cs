using ShopManagement.Framework;

namespace ShopManagement.Core.Domain.OrderAgg.Entities
{
    public class Order:AggregateRoot
    {
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
    
        public Order(long accountId, int paymentMethod, double totalAmount, double discountAmount, double payAmount)
        {
            AccountId = accountId;
            TotalAmount = totalAmount;
            DiscountAmount = discountAmount;
            PayAmount = payAmount;
            PaymentMethod = paymentMethod;
            IsPaid = false;
            IsCanceled = false;
            RefId = 0;
            Items = new List<OrderItem>();
        }

        public void PaymentSucceeded(long refId)
        {
            IsPaid = true;

            if (refId != 0)
                RefId = refId;
        }

        public void Cancel()
        {
            IsCanceled = true;
        }

        public void SetIssueTrackingNo(string number)
        {
            IssueTrackingNo = number;
        }

        public void AddItem(OrderItem item)
        {
            Items.Add(item);
        }
    }
}
