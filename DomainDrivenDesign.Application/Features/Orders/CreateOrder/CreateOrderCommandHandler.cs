using DomainDrivenDesign.Domain.Abstractions;
using DomainDrivenDesign.Domain.Orders.Events;
using DomainDrivenDesign.Domain.Orders;
using MediatR;

namespace DomainDrivenDesign.Application.Features.Orders.CreateOrder;

internal sealed class CreateOrderCommandHandler : IRequestHandler<CreateOrderCommand>
{
    private readonly IOrderRespository _orderRepository;
    private readonly IUnitofWork _unitOfWork;
    private readonly IMediator _mediator;

    public CreateOrderCommandHandler(IOrderRespository orderRepository, IUnitofWork unitOfWork, IMediator mediator)
    {
        _orderRepository = orderRepository;
        _unitOfWork = unitOfWork;
        _mediator = mediator;
    }

    public async Task Handle(CreateOrderCommand request, CancellationToken cancellationToken)
    {
        var order = await _orderRepository.CreateOrderAsync(request.CreateOrderDtos, cancellationToken);
        await _unitOfWork.SaveChangesAsync(cancellationToken);

        await _mediator.Publish(new OrderDomainEvent(order));
    }
}