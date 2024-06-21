using DiscountManagement.Core.Contracts.Commands.ColleagueDiscountAgg;
using DiscountManagement.Core.Contracts.Commands.CustomerDiscountAgg;
using DiscountManagement.Core.Contracts.IRepositories.ICustomerDiscountAgg;
using DiscountManagement.Core.Domain.ColleagueDiscountAgg;
using DiscountManagement.Core.Domain.CustomerDiscountAgg;
using MediatR;

namespace DiscountManagement.Core.ApplicationService.CustomerDiscountHandler.Commands
{
    public class CreateCustomerDiscountCommandHandler : IRequestHandler<CreateCustomerDiscount, CreateCustomerDiscountResult>
    {
        private readonly ICustomerDiscountCommandRepository _repository;
        public CreateCustomerDiscountCommandHandler(ICustomerDiscountCommandRepository repository)
        {
            _repository = repository;
        }
        public async Task<CreateCustomerDiscountResult> Handle(CreateCustomerDiscount request, CancellationToken cancellationToken)
        {
            var customer = new CustomerDiscount(request.ProductId, request.DiscountRate, request.StartDate,
            request.EndDate, request.Reason);
            await _repository.Command(customer);
            var result = new CreateCustomerDiscountResult
            {
                Id = customer.Id
            };


            return result;
        }
    }
}
