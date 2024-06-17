namespace BlogManagement.Core.Contracts.IRepositories.IArticleCategory
{
    public interface IArticleCategoryQueryRepository
    {
        Task<GetSlugByResult> Query(GetSlugBy getSlugBy);
        Task<GetDetailsArticleCategoryResult> Query(GetDetailsArticleCategory getDetailsArticleCategory);
        Task<List<GetArticleCategoriesResult>> Query(GetArticleCategories getArticleCategories);
        Task<List<ArticleCategorySearchModelResult>> Query(ArticleCategorySearchModel searchModel);
    }
}
