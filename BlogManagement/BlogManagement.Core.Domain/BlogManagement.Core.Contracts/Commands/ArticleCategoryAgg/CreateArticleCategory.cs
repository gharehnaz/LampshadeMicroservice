﻿using MediatR;
using System.ComponentModel.DataAnnotations;

namespace BlogManagement.Core.Contracts.Commands.ArticleCategoryAgg
{
    public class CreateArticleCategory : IRequest<CreateArticleCategoryResult>
    {
        public string Name { get; set; }

        public string Picture { get; set; }

        public string PictureAlt { get; set; }

        public string PictureTitle { get; set; }

        public string Description { get; set; }

        public int ShowOrder { get; set; }

        public string Slug { get; set; }

        public string Keywords { get; set; }

        public string MetaDescription { get; set; }

        public string CanonicalAddress { get; set; }
    }


    public class CreateArticleCategoryResult
    {
        public long Id { get; set; }
    }
}