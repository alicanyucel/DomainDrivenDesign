

namespace DomainDrivenDesign.Domain.Products
{
    public interface IProductRepository
    {
        Task CreateAsync(string name,int quantity,decimal amount,string currency,Guid categoryId,CancellationToken cancellation=default);
        Task List<Product>(CancellationToken cancellation=default);
    }
}
