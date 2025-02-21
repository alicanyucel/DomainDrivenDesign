

using DomainDrivenDesign.Domain.Abstractions;
using DomainDrivenDesign.Domain.Products;
using DomainDrivenDesign.Domain.Shared;

namespace DomainDrivenDesign.Domain.Orders;

public sealed class OrderLine:Entity
{
    private Guid ıd;
    private int v;

    public OrderLine(Guid id, Guid ıd, Guid productId, int quantity, int v) : base(id)
    {
        this.ıd = ıd;
        ProductId = productId;
        Quantity = quantity;
        this.v = v;
    }

    public OrderLine(Guid id,Guid orderId,Guid productId,Product product,int quantity,Money price):base(id)
    {
        ProductId = productId;
        Product = product;
        Quantity = quantity;
        Price = price;
    }

    public Guid OrderId { get;private set; }
    public Guid ProductId { get;private set; }
    public Product Product { get;private set; }
    public int Quantity {  get;private set; }
    public Money Price {  get;private set; }
    public decimal Currency { get; internal set; }
}
