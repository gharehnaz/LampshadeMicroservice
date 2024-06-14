using MediatR;
using ShopManagement.Core.Contracts.IRepositories.IOrder;
using ShopManagement.Core.Contracts.Queries.OrderAgg;

namespace ShopManagement.ApplicationService.OrderHandler.Queries
{
    public class OrderSearchQueryHandler : IRequestHandler<OrderSearch, List<OrderSearchResult>>
    {
        private readonly IOrderQueryRepository _repository;

        public OrderSearchQueryHandler(IOrderQueryRepository repository)
        {
            _repository = repository;
        }
        public async Task<List<OrderSearchResult>> Handle(OrderSearch request, CancellationToken cancellationToken)
        {
            var query = await _repository.Query(request);
            return query;
        }


    }

}
