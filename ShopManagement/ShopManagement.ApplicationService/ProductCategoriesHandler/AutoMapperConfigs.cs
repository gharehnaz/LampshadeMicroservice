using AutoMapper;
using ShopManagement.Core.Contracts.Queries.ProductCategoryAgg;

namespace ShopManagement.ApplicationService.ProductCategoriesHandler
{
    public class AutoMapperConfigs : Profile
    {
        public AutoMapperConfigs()
        {
            CreateMap<GetDetailsResult, GetDetails>();
        }

    }
}
