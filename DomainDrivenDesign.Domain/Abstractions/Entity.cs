
namespace DomainDrivenDesign.Domain.Abstractions;

public abstract class Entity : IEquatable<Entity>
{
    public Guid Id { get; init; }
    public Entity(Guid id)
    {
        Id = id;
    }

    public bool Equals(Entity? obj)
    {
        if (obj is null)
        {
            return false;
        }
        if (obj is not Entity entity)
        {
            return false;
        }
        return entity.Id == Id;
    }

}