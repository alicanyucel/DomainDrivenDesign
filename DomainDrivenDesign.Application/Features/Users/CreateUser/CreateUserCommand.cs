using MediatR;

namespace DomainDrivenDesign.Application.Features.Users.CreateUser;
// bitti
public sealed record CreateUserCommand(string Name,
    string Email,
    string Password,
    string Country,
    string City,
    string Street,
    string PostalCode,
    string FullAddress):IRequest;

