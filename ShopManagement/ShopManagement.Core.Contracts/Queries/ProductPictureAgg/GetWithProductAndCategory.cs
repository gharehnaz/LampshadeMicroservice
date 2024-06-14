using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopManagement.Core.Contracts.Queries.ProductPictureAgg
{
    public class GetWithProductAndCategory:IRequest<GetWithProductAndCategoryResult>
    {
    }
    public class GetWithProductAndCategoryResult
    {
    }
}
