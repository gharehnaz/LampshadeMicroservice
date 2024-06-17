using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscountManagement.Core.Contracts.Commands.ColleagueDiscountAgg
{
    public class CreateColleagueDiscount:IRequest<CreateColleagueDiscountResult>
    {
    }

    public class CreateColleagueDiscountResult
    {
    }
}
