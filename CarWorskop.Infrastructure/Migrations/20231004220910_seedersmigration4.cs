using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarWorskop.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class seedersmigration4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f60a08e0-14d1-4c21-ac80-5e264fd1a66b", "AQAAAAIAAYagAAAAEHR1DeJaWCYbox8qZDL5buhVLr+cQZEonLgb/Lc7PJL5gWBvwb4VVlNVB4V6GZKAhg==", "31aa9ae4-d40f-415b-a76a-3df21f4eda32" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "07a0186f-427f-455b-8fb3-7f241eb91f86", "AQAAAAIAAYagAAAAEOU9q+EVKR7da2pLrFV111biUvnjxJkTx2MHZ2JdustDi39fkRFWQHj3kgy35QFLpQ==", "1ebe3600-3069-4ae2-8f0a-e6360f91be14" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f3eed938-dd7b-4d7f-82b4-77d3e4fb4336", "Test5%", "e18c215d-5d61-46e7-8246-32f1734e006f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "835aa190-1e44-4560-a5f1-4fc68d0c162b", "Test5%", "9f1aa150-2f2c-4e00-b855-5aceeb35b16d" });
        }
    }
}
