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
        public long ProductId { get; private set; }
        public string Picture { get; private set; }
        public string PictureAlt { get; private set; }
        public string PictureTitle { get; private set; }
        public bool IsRemoved { get; private set; }
        public Product Product { get; private set; }
    }
}
