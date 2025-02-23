
using DomainDrivenDesign.Application.Features.Product.AddProduct;
using DomainDrivenDesign.Application;
using DomainDrivenDesign.WebApi.Abstractions;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace DomainDrivenDesign.WebApi.Controllers;


public class ProductsController : ApiController
{
    public ProductsController(IMediator mediator) : base(mediator)
    {
    }
    [HttpPost]
    public async Task<IActionResult> Create(CreateProductCommand request, CancellationToken cancellationToken)
    {
        await _mediator.Send(request, cancellationToken);
        return NoContent();
    }

    [HttpPost]
    public async Task<IActionResult> GetAll(GetAllProductQuery request, CancellationToken cancellationToken)
    {
        var response = await _mediator.Send(request, cancellationToken);
        return Ok(response);
    }
}
