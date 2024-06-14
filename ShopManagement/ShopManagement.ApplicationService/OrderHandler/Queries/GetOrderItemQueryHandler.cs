using MediatR;
using ShopManagement.Core.Contracts.IRepositories.IOrder;
using ShopManagement.Core.Contracts.Queries.OrderAgg;

namespace ShopManagement.ApplicationService.OrderHandler.Queries
{
    public class GetOrderItemQueryHandler : IRequestHandler<GetOrderItem, List<GetOrderItemResult>>
    {
        private readonly IOrderQueryRepository _repository;

        public GetOrderItemQueryHandler(IOrderQueryRepository repository)
        {
            _repository = repository;
        }
        public async Task<List<GetOrderItemResult>> Handle(GetOrderItem request, CancellationToken cancellationToken)
        {
            var query = await _repository.Query(request);
            return query;
        }


    }
}
