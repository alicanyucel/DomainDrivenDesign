using DomainDrivenDesign.Domain.Orders;
using MediatR;

namespace DomainDrivenDesign.Application.Features.Orders.GetAllOrder;

internal sealed class GetAllOrderQueryHandler : IRequestHandler<GetAllOrderQuery, List<Order>>
{
    private readonly IOrderRespository _orderRepository;

    public GetAllOrderQueryHandler(IOrderRespository orderRepository)
    {
        _orderRepository = orderRepository;
    }

    public async Task<List<Order>> Handle(GetAllOrderQuery request, CancellationToken cancellationToken)
    {
        return await _orderRepository.GetAllAsync(cancellationToken);
    }
}