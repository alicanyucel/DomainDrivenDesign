

using DomainDrivenDesignUdemy.Domain.Users;

namespace DomainDrivenDesign.Domain.Users
{
    public  interface IUserRepository
    {
        Task CreateUser(string name, string email, string password, string city, string street);
        Task<User> CreateAsync(string name, string email, string password, string country, string city, string street, string postalCode, string fullAddress, CancellationToken cancellationToken = default);
        Task <List<User>> GetAllAsync(CancellationToken cancellationToken=default);
    }
}
