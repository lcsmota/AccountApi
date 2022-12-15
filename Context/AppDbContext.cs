using AccountApi.Models;
using Microsoft.EntityFrameworkCore;

namespace AccountApi.Context;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options) { }

    public DbSet<Owner>? Owners { get; set; }
    public DbSet<Account>? Accounts { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Owner>(entity =>
        {
            entity.ToTable("Owners");

            entity.HasKey(e => e.OwnerId);

            entity.Property(e => e.Name)
                .HasColumnType("nvarchar(60)")
                .IsRequired();

            entity.Property(e => e.DateOfBirth)
                .IsRequired();

            entity.Property(e => e.Address)
                .HasColumnType("nvarchar(100)")
                .IsRequired();

            entity.HasMany(e => e.Accounts)
                .WithOne(x => x.Owner)
                .HasForeignKey(key => key.OwnerId)
                .HasConstraintName("FK_Owner_Accounts")
                .OnDelete(DeleteBehavior.Cascade);
        });

        modelBuilder.Entity<Account>(entity =>
        {
            entity.ToTable("Accounts");

            entity.HasKey(e => e.AccountId);

            entity.Property(e => e.DateCreated)
                .IsRequired();

            entity.Property(e => e.AccountType)
                .IsRequired();

            entity.HasOne(e => e.Owner)
                .WithMany(x => x.Accounts)
                .HasForeignKey(key => key.OwnerId)
                .HasConstraintName("FK_Accounts_Owner")
                .OnDelete(DeleteBehavior.Cascade);
        });
    }
}
