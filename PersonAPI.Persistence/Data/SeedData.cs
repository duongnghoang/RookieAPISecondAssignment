using Microsoft.EntityFrameworkCore;
using PersonAPI.Domain.Entities;
using PersonAPI.Domain.Enums;

namespace PersonAPI.Persistence.Data;

public static class SeedData
{
    public static void Seed(this ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Person>().HasData(
            new Person(
                Guid.Parse("a1b2c3d4-e5f6-7890-abcd-ef1234567890"),
                "John",
                "Doe",
                new DateTime(1990, 1, 1),
                Gender.Male,
                "New York"
            ),
            new Person(
                Guid.Parse("b2c3d4e5-f678-9012-bcde-f12345678901"),
                "Jane",
                "Doe",
                new DateTime(1992, 2, 2),
                Gender.Female,
                "Los Angeles"
            ),
            // Five additional dummy records
            new Person(
                Guid.Parse("c3d4e5f6-7890-1234-cdef-123456789012"),
                "Alice",
                "Smith",
                new DateTime(1985, 5, 15),
                Gender.Female,
                "Chicago"
            ),
            new Person(
                Guid.Parse("d4e5f678-9012-3456-def1-234567890123"),
                "Bob",
                "Johnson",
                new DateTime(1978, 9, 30),
                Gender.Male,
                "Houston"
            ),
            new Person(
                Guid.Parse("e5f67890-1234-5678-ef12-345678901234"),
                "Emma",
                "Brown",
                new DateTime(1995, 12, 10),
                Gender.Female,
                "Seattle"
            ),
            new Person(
                Guid.Parse("f6789012-3456-7890-f123-456789012345"),
                "Michael",
                "Lee",
                new DateTime(1988, 3, 22),
                Gender.Other,
                "Boston"
            ),
            new Person(
                Guid.Parse("78901234-5678-9012-3456-567890123456"),
                "Anthony",
                "Davis",
                new DateTime(1993, 7, 8),
                Gender.Male,
                "Miami"
            )
        );
    }
}