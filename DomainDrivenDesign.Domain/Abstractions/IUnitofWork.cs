namespace DomainDrivenDesign.Domain.Abstractions;

public interface IUnitofWork
{
    Task<int> SaveChangesAsync(CancellationToken cancellationToken=default);
}
