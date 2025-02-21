

namespace DomainDrivenDesign.Domain.Users
{
    public  interface IUserRepository
    {
        Task CreateUser(string name,string email,string password,string country,string city,string street,string postalCode,string fullAddress,CancellationToken cancellation=default);
        Task <List<User>> GetAllAsync(CancellationToken cancellationToken=default);
    }
}
