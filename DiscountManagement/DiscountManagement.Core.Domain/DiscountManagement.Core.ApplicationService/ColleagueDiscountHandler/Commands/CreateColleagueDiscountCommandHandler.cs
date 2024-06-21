using DiscountManagement.Core.Contracts.Commands.ColleagueDiscountAgg;
using DiscountManagement.Core.Contracts.IRepositories.IColleagueDiscountAgg;
using DiscountManagement.Core.Domain.ColleagueDiscountAgg;
using MediatR;

namespace DiscountManagement.Core.ApplicationService.ColleagueDiscountHandler.Commands
{
    public class CreateColleagueDiscountCommandHandler : IRequestHandler<CreateColleagueDiscount, CreateColleagueDiscountResult>
    {
        private readonly IColleagueDiscountCommandRepository _repository;
        public async Task<CreateColleagueDiscountResult> Handle(CreateColleagueDiscount request, CancellationToken cancellationToken)
        {
            var colleague = new ColleagueDiscount(request.ProductId, request.DiscountRate);
            await _repository.Command(colleague);
            var result = new CreateColleagueDiscountResult
            {
                Id = colleague.Id
            };


            return result;
        }
    }
}
