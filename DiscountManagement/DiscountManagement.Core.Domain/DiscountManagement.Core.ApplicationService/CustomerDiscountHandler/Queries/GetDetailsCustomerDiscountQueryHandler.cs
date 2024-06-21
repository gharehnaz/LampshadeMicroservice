using DiscountManagement.Core.Contracts.IRepositories.ICustomerDiscountAgg;
using DiscountManagement.Core.Contracts.Queries.CustomerDiscountAgg;
using MediatR;

namespace DiscountManagement.Core.ApplicationService.CustomerDiscountHandler.Queries
{
    public class GetDetailsCustomerDiscountQueryHandler : IRequestHandler<GetDetailsCustomerDiscount, GetDetailsCustomerDiscountResult>
    {
        private readonly ICustomerDiscountQueryRepository _repository;
        public GetDetailsCustomerDiscountQueryHandler(ICustomerDiscountQueryRepository repository)
        {
            _repository= repository;
        }
        public async Task<GetDetailsCustomerDiscountResult> Handle(GetDetailsCustomerDiscount request, CancellationToken cancellationToken)
        {
            return await _repository.Query(request);
        }
    }
}
