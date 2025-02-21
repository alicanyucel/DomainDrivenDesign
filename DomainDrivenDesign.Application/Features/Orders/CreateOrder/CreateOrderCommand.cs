using MediatR;
using static DomainDrivenDesign.Domain.Orders.Order;

namespace DomainDrivenDesign.Application.Features.Orders.CreateOrder;
public sealed record CreateOrderCommand(
    List<CreateOrderDto> CreateOrderDtos) : IRequest;