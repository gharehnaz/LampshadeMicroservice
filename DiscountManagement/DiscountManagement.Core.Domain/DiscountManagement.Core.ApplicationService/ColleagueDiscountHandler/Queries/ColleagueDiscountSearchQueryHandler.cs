using DiscountManagement.Core.Contracts.IRepositories.IColleagueDiscountAgg;
using DiscountManagement.Core.Contracts.Queries.ColleagueDiscountAgg;
using MediatR;

namespace DiscountManagement.Core.ApplicationService.ColleagueDiscountHandler.Queries
{
    public class ColleagueDiscountSearchQueryHandler:IRequestHandler<ColleagueDiscountSearchModel, List<ColleagueDiscountSearchModelResult>>
    {
        private readonly IColleagueDiscountQueryRepository _repository;
        public ColleagueDiscountSearchQueryHandler(IColleagueDiscountQueryRepository repository)
        {
            _repository = repository;
        }

        public async Task<List<ColleagueDiscountSearchModelResult>> Handle(ColleagueDiscountSearchModel request, CancellationToken cancellationToken)
        {
            return await _repository.Query(request);
        }
    }
}
