using DiscountManagement.Core.Contracts.IRepositories.IColleagueDiscountAgg;
using DiscountManagement.Core.Contracts.Queries.ColleagueDiscountAgg;
using MediatR;

namespace DiscountManagement.Core.ApplicationService.ColleagueDiscountHandler.Queries
{
    public class GetDetailsColleagueDiscountQueryHandler:IRequestHandler<GetDetailsColleagueDiscount, GetDetailsColleagueDiscountResult>
    {
        private readonly IColleagueDiscountQueryRepository _repository;
        public GetDetailsColleagueDiscountQueryHandler(IColleagueDiscountQueryRepository repository)
        {
            _repository = repository;
        }
        public async Task<GetDetailsColleagueDiscountResult> Handle(GetDetailsColleagueDiscount request, CancellationToken cancellationToken)
        {
            return await _repository.Query(request);        }
        }
}
