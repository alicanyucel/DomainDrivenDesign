using DomainDrivenDesign.Domain.Abstractions;
using DomainDrivenDesign.Domain.Shared;

namespace DomainDrivenDesign.Domain.Orders;

public sealed partial class Order : Entity
{
    public Order(Guid id, string orderNumber, DateTime createdDate, OrderStatusEnum status, ICollection<OrderLine> orderLines) : base(id)
    {
        OrderNumber = orderNumber;
        CreatedDate = createdDate;
        Status = status;
    }

    public string OrderNumber { get; private set; }
    public DateTime CreatedDate { get; private set; }
    public OrderStatusEnum Status { get; private set; }
    public ICollection<OrderLine> OrderLines { get; private set; }
    public void CreateOrder(Guid pdroductId, int Quantity, decimal amount, string currency)
    {
        foreach (var item in OrderLines)
        {
            if (item.Quantity < 1)
            {
                throw new ArgumentException("quantity 1 den küçük olamaz");
            }
            OrderLine orderLine = new(
                Guid.NewGuid(),
                Id,
                item.ProductId,
                item.Quantity,
                new(item.Amount,Currency.FromCode(Currency);
            OrderLines.Add(orderLine);

        }
    }
    public void RemoveOrderLine(Guid orderLineId)
    {
        var orderdLine = OrderLines.FirstOrDefault(p => p.Id == orderLineId);
        if (orderdLine is null)
        {
            throw new ArgumentException("silmek istediğiniz sipariş bulunamadı");
        }
        OrderLines.Remove(orderdLine);
    }
}
