using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BurguermaniaAPI.Migrations
{
    /// <inheritdoc />
    public partial class seedstatus : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Statuses",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Pendente" },
                    { 2, "Confirmado" },
                    { 3, "Em preparo" },
                    { 4, "A caminho do cliente" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
