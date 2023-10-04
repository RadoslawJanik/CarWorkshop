using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarWorskop.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class seedersmigration2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e2677cad-8b9b-4d1f-a754-97076abfe813");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "926d48df-6e00-4881-9aec-fe8d4d1ae78f", null, "Test", "TEST" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "926d48df-6e00-4881-9aec-fe8d4d1ae78f");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "e2677cad-8b9b-4d1f-a754-97076abfe813", null, "Test", "TEST" });
        }
    }
}
