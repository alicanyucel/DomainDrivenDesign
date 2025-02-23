using DomainDrivenDesign.Application.Features.Users.CreateUser;
using DomainDrivenDesign.Application.Features.Users.GetAllUser;
using DomainDrivenDesign.WebApi.Abstractions;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace DomainDrivenDesign.WebApi.Controllers;

public class UsersController : ApiController
{
    public UsersController(IMediator mediator) : base(mediator)
    {
    }

    [HttpPost]
    public async Task<IActionResult> Create(CreateUserCommand request, CancellationToken cancellationToken)
    {
        await _mediator.Send(request, cancellationToken);
        return NoContent();
    }

    [HttpPost]
    public async Task<IActionResult> GetAll(GetAllUserQuery request, CancellationToken cancellationToken)
    {
        var response = await _mediator.Send(request, cancellationToken);
        return Ok(response);
    }

}