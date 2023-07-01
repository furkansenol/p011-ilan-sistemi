using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IlanSistemi.DataAccess.Migrations
{
    public partial class _1002_vmadd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreatedAt" },
                values: new object[] { "18ac918e-523e-4aa9-8a58-dd50ab1195cf", new DateTime(2023, 7, 1, 12, 54, 17, 474, DateTimeKind.Local).AddTicks(8527) });

            migrationBuilder.UpdateData(
                table: "adverts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 1, 12, 54, 17, 474, DateTimeKind.Local).AddTicks(8620));

            migrationBuilder.UpdateData(
                table: "adverts",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 1, 12, 54, 17, 474, DateTimeKind.Local).AddTicks(8624));

            migrationBuilder.UpdateData(
                table: "adverts",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 1, 12, 54, 17, 474, DateTimeKind.Local).AddTicks(8625));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreatedAt" },
                values: new object[] { "5bd68353-f7c6-4e60-87e3-91541b816e81", new DateTime(2023, 7, 1, 11, 0, 50, 290, DateTimeKind.Local).AddTicks(2193) });

            migrationBuilder.UpdateData(
                table: "adverts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 1, 11, 0, 50, 290, DateTimeKind.Local).AddTicks(2321));

            migrationBuilder.UpdateData(
                table: "adverts",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 1, 11, 0, 50, 290, DateTimeKind.Local).AddTicks(2325));

            migrationBuilder.UpdateData(
                table: "adverts",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 1, 11, 0, 50, 290, DateTimeKind.Local).AddTicks(2327));
        }
    }
}
