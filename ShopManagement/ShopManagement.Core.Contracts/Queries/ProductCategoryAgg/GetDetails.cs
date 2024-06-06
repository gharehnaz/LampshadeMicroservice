﻿using MediatR;

namespace ShopManagement.Core.Contracts.Queries.ProductCategoryAgg
{
    public class GetDetails : IRequest<GetDetailsResult>
    {
        public long Id { get; set; }
    }
    public class GetDetailsResult
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Picture { get; set; }
        public string PictureAlt { get; set; }
        public string PictureTitle { get; set; }
        public string Keywords { get; set; }
        public string MetaDescription { get; set; }
        public string Slug { get; set; }

    }
}
