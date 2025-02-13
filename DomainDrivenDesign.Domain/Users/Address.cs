namespace DomainDrivenDesign.Domain.Users;

// value object kimliği olmayan ve değiştirilemeyen neseneler genellikle adresler,para,koordinat verileri value object olarak tanımlanır
public sealed record Address(string Country,string City,string Street,string FullAddress,string PostalCode);
