using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IlanSistemi.DataAccess.Migrations
{
    public partial class dataSeedForCategoriesforMyDb2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "Description",
                value: "Ev Tekstili, Mutfak Gereçleri");

            migrationBuilder.UpdateData(
                table: "categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "Description",
                value: "Aradığınız tüm spor ürünleri");

            migrationBuilder.UpdateData(
                table: "categories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Description", "Name" },
                values: new object[] { "Kişisel bakım ve makyaj malzemeleri", "Kozmetik" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "Description",
                value: "Envai çeşit sizi çıplaklıktan koruyacak kıyafetler.");

            migrationBuilder.UpdateData(
                table: "categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "Description",
                value: "Envai çeşit sizi çıplaklıktan koruyacak kıyafetler.");

            migrationBuilder.UpdateData(
                table: "categories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Description", "Name" },
                values: new object[] { "Envai çeşit sizi çıplaklıktan koruyacak kıyafetler.", "FKozmetik" });
        }
    }
}
