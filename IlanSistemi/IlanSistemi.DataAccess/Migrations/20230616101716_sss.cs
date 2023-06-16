using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IlanSistemi.DataAccess.Migrations
{
    public partial class sss : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "adverts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 16, 13, 17, 16, 90, DateTimeKind.Local).AddTicks(2890));

            migrationBuilder.UpdateData(
                table: "adverts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 16, 13, 17, 16, 90, DateTimeKind.Local).AddTicks(2935));

            migrationBuilder.UpdateData(
                table: "adverts",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 16, 13, 17, 16, 90, DateTimeKind.Local).AddTicks(2937));

            migrationBuilder.UpdateData(
                table: "adverts",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 16, 13, 17, 16, 90, DateTimeKind.Local).AddTicks(2939));

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 16, 13, 17, 16, 90, DateTimeKind.Local).AddTicks(2624));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "adverts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 14, 16, 12, 27, 434, DateTimeKind.Local).AddTicks(7818));

            migrationBuilder.UpdateData(
                table: "adverts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 14, 16, 12, 27, 434, DateTimeKind.Local).AddTicks(7824));

            migrationBuilder.UpdateData(
                table: "adverts",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 14, 16, 12, 27, 434, DateTimeKind.Local).AddTicks(7826));

            migrationBuilder.UpdateData(
                table: "adverts",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 14, 16, 12, 27, 434, DateTimeKind.Local).AddTicks(7827));

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 14, 16, 12, 27, 434, DateTimeKind.Local).AddTicks(7638));
        }
    }
}
