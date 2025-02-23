using DomainDrivenDesign.Application.Features.Categories.CreateCategory;
using DomainDrivenDesign.Application.Features.Categories.GetAllCategory;
using DomainDrivenDesign.WebApi.Abstractions;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace DomainDrivenDesign.WebApi.Controllers
{
    public class CategoriesController : ApiController
    {
        public CategoriesController(IMediator mediator) : base(mediator)
        {
        }
        [HttpPost]
        public async Task<IActionResult> Create(CreateCategoryCommand request, CancellationToken cancellationToken)
        {
            await _mediator.Send(request, cancellationToken);
            return NoContent();
        }

        [HttpPost]
        public async Task<IActionResult> GetAll(GetAllCategoryQuery request, CancellationToken cancellationToken)
        {
            var response = await _mediator.Send(request, cancellationToken);
            return Ok(response);
        }
    }
}
