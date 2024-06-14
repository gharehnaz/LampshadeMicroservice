using MediatR;
using ShopManagement.Core.Contracts.IRepositories.IOrder;
using ShopManagement.Core.Contracts.Queries.OrderAgg;

namespace ShopManagement.ApplicationService.OrderHandler.Queries
{
    public class GetAmountByQueryHandler : IRequestHandler<GetAmountBy, GetAmountByResult>
    {
        private readonly IOrderQueryRepository _repository;

        public GetAmountByQueryHandler(IOrderQueryRepository repository)
        {
            _repository = repository;
        }
        public async Task<GetAmountByResult> Handle(GetAmountBy request, CancellationToken cancellationToken)
        {
            var query = await _repository.Query(request);
            return query;
        }
    }

}
