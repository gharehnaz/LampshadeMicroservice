using MediatR;
using ShopManagement.Core.Contracts.Commands.OrderAgg;
using ShopManagement.Core.Contracts.IRepositories.IOrder;
using ShopManagement.Core.Domain.OrderAgg.Entities;

namespace ShopManagement.ApplicationService.OrderHandler.Commands
{
    public class CreateOrderCommandHandler:IRequestHandler<CreateOrder, CreateOrderResult>
    {
        private readonly IOrderCommandRepository _repository;
        public CreateOrderCommandHandler(IOrderCommandRepository repository)
        {
            _repository = repository;   
        }

        public async Task<CreateOrderResult> Handle(CreateOrder request, CancellationToken cancellationToken)
        {
            var order = new Order(request.AccountId, request.PaymentMethod, request.TotalAmount, request.DiscountAmount, request.PayAmount);
            await _repository.Command(order);
            var result = new CreateOrderResult
            {
                Id = order.Id
            };


            return result;
        }
    }
}
