using AutoMapper;
using MediatR;
using ShopManagement.Core.Contracts.IRepositories.IProductCategory;
using ShopManagement.Core.Contracts.Queries.ProductCategoryAgg;

namespace ShopManagement.ApplicationService.ProductCategoriesHandler.Queries
{
    public class GetProductCategoriesHandler : IRequestHandler<GetProductCategories, List<GetProductCategoriesResult>>
    {
        private readonly IProductCategoryQueryRepository _repository;
        private readonly IMapper _mapper;

        public GetProductCategoriesHandler(IProductCategoryQueryRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<List<GetProductCategoriesResult>> Handle(GetProductCategories request, CancellationToken cancellationToken)
        {
            var query = _repository.Query(request);
            return await query;
        }

       
    }
}
