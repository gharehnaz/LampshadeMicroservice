using ShopManagement.Core.Contracts.IRepositories.IOrder;
using ShopManagement.Core.Contracts.Queries.OrderAgg;

namespace OrderAgg.Infrastructure.Queries.Repository
{
    public class OrderQueryRepository : IOrderQueryRepository
    {
        private readonly OrderQueryDbContext _context;
        public OrderQueryRepository(OrderQueryDbContext context)
        {
            _context = context;
        }
        public async Task<GetAmountByResult> Query(GetAmountBy getAmountBy)
        {
            var order = _context.Orders
                            .Select(x => new { x.PayAmount, x.Id })
                            .FirstOrDefault(x => x.Id == getAmountBy.Id);
            var result = new GetAmountByResult { Amount = 0 };

            if (order != null)
            {
                var payAmount = order.PayAmount;
                result = new GetAmountByResult { Amount = order.PayAmount };
                return result;
            }
                
            return  result;
        }

        public async Task<List<GetOrderItemResult>> Query(GetOrderItem getOrderItem)
        {
            var products = _context.Products.Select(x => new { x.Id, x.Name }).ToList();
            var order = _context.Orders.FirstOrDefault(x => x.Id == getOrderItem.OrderId);
            if (order == null)
                return new List<GetOrderItemResult>();

            var items = order.Items.Select(x => new GetOrderItemResult
            {
                Id = x.Id,
                Count = x.Count,
                DiscountRate = x.DiscountRate,
                OrderId = x.OrderId,
                ProductId = x.ProductId,
                UnitPrice = x.UnitPrice
            }).ToList();

            foreach (var item in items)
            {
                item.Product = products.FirstOrDefault(x => x.Id == item.ProductId)?.Name;
            }

            return items;
        }

        public async Task<List<OrderSearchResult>> Query(OrderSearch searchModel)
        {
            //var accounts = _accountContext.Accounts.Select(x => new { x.Id, x.Fullname }).ToList();
            var query = _context.Orders.Select(x => new OrderSearchResult
            {
                Id = x.Id,
                AccountId = x.AccountId,
                DiscountAmount = x.DiscountAmount,
                IsCanceled = x.IsCanceled,
                IsPaid = x.IsPaid,
                IssueTrackingNo = x.IssueTrackingNo,
                PayAmount = x.PayAmount,
                PaymentMethodId = x.PaymentMethod,
                RefId = x.RefId,
                TotalAmount = x.TotalAmount,
            });

            query = query.Where(x => x.IsCanceled == searchModel.IsCanceled);

            if (searchModel.AccountId > 0) query = query.Where(x => x.AccountId == searchModel.AccountId);

            var orders = query.OrderByDescending(x => x.Id).ToList();
            foreach (var order in orders)
            {
                //order.AccountFullName = accounts.FirstOrDefault(x => x.Id == order.AccountId)?.Fullname;
                //order.PaymentMethod = PaymentMethod.GetBy(order.PaymentMethodId).Name;
            }

            return orders;
        }
    }
}
