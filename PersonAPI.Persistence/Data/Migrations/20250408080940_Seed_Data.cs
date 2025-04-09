using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace PersonAPI.Persistence.Data.Migrations
{
    /// <inheritdoc />
    public partial class Seed_Data : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "Persons",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "Persons",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "BirthPlace",
                table: "Persons",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.InsertData(
                table: "Persons",
                columns: new[] { "Id", "BirthPlace", "DateOfBirth", "FirstName", "Gender", "LastName" },
                values: new object[,]
                {
                    { new Guid("78901234-5678-9012-3456-567890123456"), "Miami", new DateTime(1993, 7, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Anthony", "Male", "Davis" },
                    { new Guid("a1b2c3d4-e5f6-7890-abcd-ef1234567890"), "New York", new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "John", "Male", "Doe" },
                    { new Guid("b2c3d4e5-f678-9012-bcde-f12345678901"), "Los Angeles", new DateTime(1992, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jane", "Female", "Doe" },
                    { new Guid("c3d4e5f6-7890-1234-cdef-123456789012"), "Chicago", new DateTime(1985, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Alice", "Female", "Smith" },
                    { new Guid("d4e5f678-9012-3456-def1-234567890123"), "Houston", new DateTime(1978, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bob", "Male", "Johnson" },
                    { new Guid("e5f67890-1234-5678-ef12-345678901234"), "Seattle", new DateTime(1995, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Emma", "Female", "Brown" },
                    { new Guid("f6789012-3456-7890-f123-456789012345"), "Boston", new DateTime(1988, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Michael", "Other", "Lee" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("78901234-5678-9012-3456-567890123456"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("a1b2c3d4-e5f6-7890-abcd-ef1234567890"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("b2c3d4e5-f678-9012-bcde-f12345678901"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("c3d4e5f6-7890-1234-cdef-123456789012"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("d4e5f678-9012-3456-def1-234567890123"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("e5f67890-1234-5678-ef12-345678901234"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("f6789012-3456-7890-f123-456789012345"));

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "Persons",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "Persons",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "BirthPlace",
                table: "Persons",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);
        }
    }
}
