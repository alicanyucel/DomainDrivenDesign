

using static DomainDrivenDesign.Domain.Orders.Order;

namespace DomainDrivenDesign.Domain.Orders;

public interface IOrderRespository
{
    Task CreateOrderAsync(List<CreateOrderDto> createOrderDto, CancellationToken cancellation = default);
    Task<List<Order>> GetAllAsync(CancellationToken cancellation = default);
}
