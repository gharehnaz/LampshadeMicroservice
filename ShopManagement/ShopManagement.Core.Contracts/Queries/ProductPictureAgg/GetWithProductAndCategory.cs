using MediatR;
using ShopManagement.Core.Domain.ProductAgg.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopManagement.Core.Contracts.Queries.ProductPictureAgg
{
    public class GetWithProductAndCategory:IRequest<GetWithProductAndCategoryResult>
    {
        public long Id { get; set; }
    }
    public class GetWithProductAndCategoryResult
    {
        public long ProductId { get;  set; }
        public string Picture { get;  set; }
        public string PictureAlt { get;  set; }
        public string PictureTitle { get;  set; }
        public bool IsRemoved { get;  set; }
        public Product Product { get;  set; }
        public long Id { get; set; }
    }
}
