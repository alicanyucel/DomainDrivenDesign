

using DomainDrivenDesign.Domain.Products;
using MediatR;

namespace DomainDrivenDesign.Application;
public sealed record GetAllProductQuery() : IRequest<List<Product>>;