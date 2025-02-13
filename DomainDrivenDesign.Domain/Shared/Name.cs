namespace DomainDrivenDesign.Domain.Shared;

public sealed record Name
{
    public string Value { get; init; }
    public Name(string value)
    {
        if (string.IsNullOrEmpty(value))
        {
            throw new ArgumentException("isim lanı boş olamaz");
        }
        if (value.Length < 3)
        {
            throw new ArgumentException("isim alanı 3 karakterden az olamaz");
        }
    }
}
