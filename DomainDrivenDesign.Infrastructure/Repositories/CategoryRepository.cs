

using DomainDrivenDesign.Domain.Categories;
using DomainDrivenDesign.Infrastructure.DataContext;
using Microsoft.EntityFrameworkCore;

namespace DomainDrivenDesign.Infrastructure.Repositories;

internal sealed class CategoryRepository : ICategoryRepository
{
    private readonly ApplicationDbContext _context;

    public CategoryRepository(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task CreateAsync(string name, CancellationToken cancellationToken = default)
    {
        Category category = new(Guid.NewGuid(), new(name));
        await _context.Categories.AddAsync(category, cancellationToken);
    }

    public async Task<List<Category>> GetAlAsync(CancellationToken cancellationToken = default)
    {
        return await _context.Categories.ToListAsync(cancellationToken);
    }
}