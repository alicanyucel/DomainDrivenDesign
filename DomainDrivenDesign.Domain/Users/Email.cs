namespace DomainDrivenDesign.Domain.Users;

public sealed record Email
{
    public string Value { get; init; }
    public Email(string value)
    {
        if(string.IsNullOrEmpty(value))
        {
            throw new ArgumentException("email boş olamaz");
        }
        if(value.Length<3)
        {
            throw new ArgumentException("email alanı 3 karakterden az olamaz");
        }
        if (!value.Contains("@"))
        {
            throw new ArgumentException("geçerli bir email adresi girin");
        }
        value = value;
    }
}
