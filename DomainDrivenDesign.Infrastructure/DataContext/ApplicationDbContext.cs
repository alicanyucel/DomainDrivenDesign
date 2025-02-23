using DomainDrivenDesign.Domain.Abstractions;
using DomainDrivenDesign.Domain.Categories;
using DomainDrivenDesign.Domain.Products;
using DomainDrivenDesign.Domain.Shared;
using DomainDrivenDesignUdemy.Domain.Orders;
using DomainDrivenDesignUdemy.Domain.Users;
using Microsoft.EntityFrameworkCore;

namespace DomainDrivenDesign.Infrastructure.DataContext;

internal sealed class ApplicationDbContext : DbContext, IUnitofWork
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Data Source=DESKTOP-L6NJT48\\SQLEXPRESS;Initial Catalog=DDDDb;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");
    }

    public DbSet<User> Users { get; set; }
    public DbSet<Order> Orders { get; set; }
    public DbSet<Product> Products { get; set; }
    public DbSet<Category> Categories { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<User>()
            .Property(p => p.Name)
            .HasConversion(name => name.Value, value => new(value));

        modelBuilder.Entity<User>()
           .Property(p => p.Email)
           .HasConversion(email => email.Value, value => new(value));

        modelBuilder.Entity<User>()
           .Property(p => p.Password)
           .HasConversion(password => password.value, value => new(value));

        modelBuilder.Entity<User>()
            .OwnsOne(p => p.Address);

        modelBuilder.Entity<Category>()
            .Property(p => p.Name)
            .HasConversion(name => name.Value, value => new(value));

        modelBuilder.Entity<Product>()
            .Property(p => p.Name)
            .HasConversion(name => name.Value, value => new(value));

        modelBuilder.Entity<Product>()
            .OwnsOne(p => p.Price, priceBuilder =>
            {
                priceBuilder
                .Property(p => p.Currency)
                .HasConversion(currency => currency.Code, code => Currency.FromCode(code));

                priceBuilder
                .Property(p => p.Amount)
                .HasColumnType("money");
            });

        modelBuilder.Entity<OrderLine>()
            .OwnsOne(p => p.Price, priceBuilder =>
            {
                priceBuilder
                .Property(p => p.Currency)
                .HasConversion(currency => currency.Code, code => Currency.FromCode(code));

                priceBuilder
                .Property(p => p.Amount)
                .HasColumnType("money");
            });
    }
}