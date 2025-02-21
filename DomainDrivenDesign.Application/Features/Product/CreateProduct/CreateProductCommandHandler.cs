

using DomainDrivenDesign.Application.Features.Product.AddProduct;
using DomainDrivenDesign.Domain.Abstractions;
using DomainDrivenDesign.Domain.Products;
using MediatR;

namespace DomainDrivenDesign.Application.Features.Product.CreateProduct;

internal sealed class CreateProductCommandHandler : IRequestHandler<CreateProductCommand>
{
    private readonly IProductRepository _productRepository;
    private readonly IUnitofWork _unitOfWork;
    public CreateProductCommandHandler(IProductRepository productRepository, IUnitofWork unitOfWork)
    {
        _productRepository = productRepository;
        _unitOfWork = unitOfWork;
    }

    public async Task Handle(CreateProductCommand request, CancellationToken cancellationToken)
    {
        await _productRepository.CreateAsync(
            request.Name,
            request.Quantity,
            request.Amount,
            request.Currency,
            request.CategoryId,
            cancellationToken);

        await _unitOfWork.SaveChangesAsync(cancellationToken);
    }
}