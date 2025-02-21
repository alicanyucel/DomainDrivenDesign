
namespace DomainDrivenDesign.Domain.Categories
{
    public interface ICategoryRepository
    {
        Task CreateAsync(string name,CancellationToken cancellationToken=default);
        Task <List<Category>> GetAlAsync(CancellationToken cancellationToken=default);

    }
}
