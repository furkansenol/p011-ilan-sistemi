using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IlanSistemi.DataAccess.Migrations
{
    public partial class _19_06_2023_propertyNamesFixed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "adverts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 19, 13, 13, 31, 584, DateTimeKind.Local).AddTicks(4372));

            migrationBuilder.UpdateData(
                table: "adverts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 19, 13, 13, 31, 584, DateTimeKind.Local).AddTicks(4379));

            migrationBuilder.UpdateData(
                table: "adverts",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 19, 13, 13, 31, 584, DateTimeKind.Local).AddTicks(4382));

            migrationBuilder.UpdateData(
                table: "adverts",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 19, 13, 13, 31, 584, DateTimeKind.Local).AddTicks(4384));

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 19, 13, 13, 31, 584, DateTimeKind.Local).AddTicks(3948));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "adverts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 19, 12, 52, 42, 543, DateTimeKind.Local).AddTicks(6060));

            migrationBuilder.UpdateData(
                table: "adverts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 19, 12, 52, 42, 543, DateTimeKind.Local).AddTicks(6071));

            migrationBuilder.UpdateData(
                table: "adverts",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 19, 12, 52, 42, 543, DateTimeKind.Local).AddTicks(6072));

            migrationBuilder.UpdateData(
                table: "adverts",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 19, 12, 52, 42, 543, DateTimeKind.Local).AddTicks(6073));

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 19, 12, 52, 42, 543, DateTimeKind.Local).AddTicks(5850));
        }
    }
}
