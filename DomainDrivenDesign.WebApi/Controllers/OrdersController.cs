using DomainDrivenDesign.Application.Features.Orders.CreateOrder;
using DomainDrivenDesign.Application.Features.Orders.GetAllOrder;
using DomainDrivenDesign.WebApi.Abstractions;
using MediatR;
using Microsoft.AspNetCore.Mvc;


namespace DomainDrivenDesign.WebApi.Controllers;


public class OrdersController : ApiController
{
    public OrdersController(IMediator mediator) : base(mediator)
    {
    }
    [HttpPost]
    public async Task<IActionResult> Create(CreateOrderCommand request, CancellationToken cancellationToken)
    {
        await _mediator.Send(request, cancellationToken);
        return NoContent();
    }

    [HttpPost]
    public async Task<IActionResult> GetAll(GetAllOrderQuery request, CancellationToken cancellationToken)
    {
        var response = await _mediator.Send(request, cancellationToken);
        return Ok(response);
    }
}
