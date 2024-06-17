using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscountManagement.Core.Contracts.Commands.CustomerDiscountAgg
{
    public class CreateCustomerDiscount:IRequest<CreateCustomerDiscountResult>
    {
    }

    public class CreateCustomerDiscountResult
    {
    }
}
