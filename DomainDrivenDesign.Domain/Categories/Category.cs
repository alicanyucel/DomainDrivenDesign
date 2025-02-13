

using DomainDrivenDesign.Domain.Abstractions;
using DomainDrivenDesign.Domain.Products;
using DomainDrivenDesign.Domain.Shared;
using DomainDrivenDesign.Domain.Users;

namespace DomainDrivenDesign.Domain.Categories;

public sealed class Category:Entity
{
    public Category(Guid id,Name name) : base(id)
    {
        Name = name;
       
    }

    public Name Name { get;private set; }
    public ICollection<Product> Products { get; set; }
    public void ChangeName(string name)
    {
        Name=new(name);
    }
}
