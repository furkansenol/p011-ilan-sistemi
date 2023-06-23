using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IlanSistemi.DataAccess.Migrations
{
    public partial class _23_06_2023_sec : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AdvertImages",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImagePath",
                value: "laptop.jpeg");

            migrationBuilder.UpdateData(
                table: "AdvertImages",
                keyColumn: "Id",
                keyValue: 2,
                column: "ImagePath",
                value: "yuruyenucak.png");

            migrationBuilder.UpdateData(
                table: "AdvertImages",
                keyColumn: "Id",
                keyValue: 3,
                column: "ImagePath",
                value: "gemicik.jpg");

            migrationBuilder.UpdateData(
                table: "AdvertImages",
                keyColumn: "Id",
                keyValue: 4,
                column: "ImagePath",
                value: "roptesambir.jpg");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ConcurrencyStamp", "CreatedAt" },
                values: new object[] { "342433b6-b18a-4e6c-9721-d858c5afff0a", new DateTime(2023, 6, 23, 15, 4, 40, 969, DateTimeKind.Local).AddTicks(6515) });

            migrationBuilder.UpdateData(
                table: "adverts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 23, 15, 4, 40, 969, DateTimeKind.Local).AddTicks(6708));

            migrationBuilder.UpdateData(
                table: "adverts",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 23, 15, 4, 40, 969, DateTimeKind.Local).AddTicks(6714));

            migrationBuilder.UpdateData(
                table: "adverts",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 23, 15, 4, 40, 969, DateTimeKind.Local).AddTicks(6715));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AdvertImages",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImagePath",
                value: "/Productimage/laptop1.jpeg");

            migrationBuilder.UpdateData(
                table: "AdvertImages",
                keyColumn: "Id",
                keyValue: 2,
                column: "ImagePath",
                value: "/Productimage/yuruyenucak.png");

            migrationBuilder.UpdateData(
                table: "AdvertImages",
                keyColumn: "Id",
                keyValue: 3,
                column: "ImagePath",
                value: "/Productimage/gemicik.jpg");

            migrationBuilder.UpdateData(
                table: "AdvertImages",
                keyColumn: "Id",
                keyValue: 4,
                column: "ImagePath",
                value: "/Productimage/roptesambir.jpg");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ConcurrencyStamp", "CreatedAt" },
                values: new object[] { "f69fe248-85eb-426b-b4af-c8d26dc8842d", new DateTime(2023, 6, 23, 13, 41, 10, 959, DateTimeKind.Local).AddTicks(4303) });

            migrationBuilder.UpdateData(
                table: "adverts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 23, 13, 41, 10, 959, DateTimeKind.Local).AddTicks(4440));

            migrationBuilder.UpdateData(
                table: "adverts",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 23, 13, 41, 10, 959, DateTimeKind.Local).AddTicks(4451));

            migrationBuilder.UpdateData(
                table: "adverts",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 23, 13, 41, 10, 959, DateTimeKind.Local).AddTicks(4452));
        }
    }
}
