using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PersonAPI.Domain.Entities;

namespace PersonAPI.Persistence.Configurations;

public class PersonConfiguration : IEntityTypeConfiguration<Person>
{
    public void Configure(EntityTypeBuilder<Person> builder)
    {
        builder.HasKey(e => e.Id);

        builder.Property(e => e.Gender)
            .HasConversion<string>()
            .HasMaxLength(20);

        builder.Property(e => e.FirstName)
            .HasMaxLength(50);

        builder.Property(e => e.LastName)
            .HasMaxLength(50);

        builder.Property(e => e.BirthPlace)
            .HasMaxLength(100);
    }
}