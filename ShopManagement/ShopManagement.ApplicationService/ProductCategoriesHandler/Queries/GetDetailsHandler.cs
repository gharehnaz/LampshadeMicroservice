using AutoMapper;
using MediatR;
using ShopManagement.Core.Contracts.IRepositories.IProductCategory;
using ShopManagement.Core.Contracts.Queries.ProductCategoryAgg;

namespace ShopManagement.ApplicationService.ProductCategoriesHandler.Queries
{
    public class GetDetailsHandler : IRequestHandler<GetDetails, GetDetailsResult>
    {
        private readonly IProductCategoryQueryRepository _repository;
        private readonly IMapper _mapper;

        public GetDetailsHandler(IProductCategoryQueryRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public async Task<GetDetailsResult> Handle(GetDetails request, CancellationToken cancellationToken)
        {
            var query =  _repository.Query(request);
            var result =  _mapper.Map<GetDetailsResult>(query);

            return   result;
        }
    }
}
