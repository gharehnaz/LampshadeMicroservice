using MediatR;

namespace BlogManagement.Core.Contracts.Queries.ArticleCategoryAgg
{
    public class GetSlugBy:IRequest<GetSlugByResult>
    {
        public long Id { get; set; }
    }

    public class GetSlugByResult
    {
        public string Slug { get; set; }
    }
}