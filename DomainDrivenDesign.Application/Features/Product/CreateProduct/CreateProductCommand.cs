

using MediatR;

namespace DomainDrivenDesign.Application.Features.Product.AddProduct
{
    public sealed record CreateProductCommand(
      string Name,
      int Quantity,
      decimal Amount,
      string Currency,
      Guid CategoryId) : IRequest;
}
