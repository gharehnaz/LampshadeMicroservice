using DiscountManagement.Core.Contracts.IRepositories.ICustomerDiscountAgg;
using DiscountManagement.Core.Contracts.Queries.CustomerDiscountAgg;
using MediatR;

namespace DiscountManagement.Core.ApplicationService.CustomerDiscountHandler.Queries
{
    public class CustomerDiscountSearchQueryHandler:IRequestHandler<CustomerDiscountSearchModel, List<CustomerDiscountSearchModelResult>>
    {
        private readonly ICustomerDiscountQueryRepository _repository;
        public CustomerDiscountSearchQueryHandler(ICustomerDiscountQueryRepository repository)
        {
            _repository = repository; 
        }

        public async Task<List<CustomerDiscountSearchModelResult>> Handle(CustomerDiscountSearchModel request, CancellationToken cancellationToken)
        {
            return await _repository.Query(request);
        }
    }
}
