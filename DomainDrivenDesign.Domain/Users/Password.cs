namespace DomainDrivenDesign.Domain.Users;

public sealed record Password
{
    public string value { get; init; }
    public Password(string value)
    {
        if(string.IsNullOrEmpty(value))
        {
            throw new ArgumentException("şifre boş olamaz");
        }
        if(value.Length<6)
        {
            throw new ArgumentException("şifre en az 6 karakter olmalıdır");
        }
        value = value;
    }
}
