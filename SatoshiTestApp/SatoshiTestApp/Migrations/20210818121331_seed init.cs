using Microsoft.EntityFrameworkCore.Migrations;

namespace SatoshiTestApp.Migrations
{
    public partial class seedinit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "id", "SalesOrderModelid", "productName" },
                values: new object[,]
                {
                    { 1, null, "MI Notebook" },
                    { 2, null, "Lenovo" },
                    { 3, null, "Surface" },
                    { 4, null, "Mac" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "id",
                keyValue: 4);
        }
    }
}
