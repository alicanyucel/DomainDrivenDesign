

namespace DomainDrivenDesign.Domain.Shared;

public sealed record Currency
{
    internal static readonly Currency None = new("");
    public static readonly Currency Usd = new("Usd");
    public static readonly Currency TRY = new("TRY");
    public string Code {  get; init; }
    public Currency(string code)
    {
        code = code;
    }
    public static Currency FromCode(string code)
    {
        return All.FirstOrDefault(p => p.Code == code) ?? throw new ArgumentException("geçeri bir para birimi girin");
    }
    public static readonly IReadOnlyCollection<Currency> All = new[] { Usd, TRY };

}
