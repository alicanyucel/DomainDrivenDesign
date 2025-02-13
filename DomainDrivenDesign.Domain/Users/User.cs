

using DomainDrivenDesign.Domain.Abstractions;

namespace DomainDrivenDesign.Domain.Users;

public sealed class User:Entity
{
    public User(Guid id,Name Name,Email Email,Password Password,Address Address):base(id)
    {
        Name = Name;
        Email = Email;
        Password = Password;
        Address = Address;
    }

    public Name Name { get; private set; }
    public Email Email { get; private set; }
    public Password Password { get;private set; }
    public Address Address { get; private set; }
    public void ChangeName(string name)
    {
        name = new(name);
    }
}
