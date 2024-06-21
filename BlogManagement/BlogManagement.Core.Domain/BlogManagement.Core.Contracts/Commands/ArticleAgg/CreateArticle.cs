﻿using MediatR;
using System.ComponentModel.DataAnnotations;

namespace BlogManagement.Core.Contracts.Commands.ArticleAgg
{
    public class CreateArticle:IRequest<CreateArticleResult>
    {
    
        public string Title { get; set; }

        public string ShortDescription { get; set; }

        public string Description { get; set; }

        public string Picture { get; set; }

        public string PictureAlt { get; set; }

        public string PictureTitle { get; set; }

        public DateTime PublishDate { get; set; }

    
        public string Slug { get; set; }

       
        public string Keywords { get; set; }

    
        public string MetaDescription { get; set; }

        public string CanonicalAddress { get; set; }

        public long CategoryId { get; set; }
    }

    public class CreateArticleResult
    {
        public long Id { get; set; }
    }
}
