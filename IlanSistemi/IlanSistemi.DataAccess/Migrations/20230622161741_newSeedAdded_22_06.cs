using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IlanSistemi.DataAccess.Migrations
{
    public partial class newSeedAdded_22_06 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "CategoryAdverts",
                columns: new[] { "Id", "AdvertId", "CategoryId", "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { 4, 3, 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null });

            migrationBuilder.UpdateData(
                table: "adverts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 22, 19, 17, 41, 392, DateTimeKind.Local).AddTicks(7763));

            migrationBuilder.UpdateData(
                table: "adverts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 22, 19, 17, 41, 392, DateTimeKind.Local).AddTicks(7768));

            migrationBuilder.UpdateData(
                table: "adverts",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 22, 19, 17, 41, 392, DateTimeKind.Local).AddTicks(7770));

            migrationBuilder.UpdateData(
                table: "adverts",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 22, 19, 17, 41, 392, DateTimeKind.Local).AddTicks(7771));

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 22, 19, 17, 41, 392, DateTimeKind.Local).AddTicks(7523));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CategoryAdverts",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.UpdateData(
                table: "adverts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 20, 16, 47, 19, 495, DateTimeKind.Local).AddTicks(6418));

            migrationBuilder.UpdateData(
                table: "adverts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 20, 16, 47, 19, 495, DateTimeKind.Local).AddTicks(6422));

            migrationBuilder.UpdateData(
                table: "adverts",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 20, 16, 47, 19, 495, DateTimeKind.Local).AddTicks(6424));

            migrationBuilder.UpdateData(
                table: "adverts",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 20, 16, 47, 19, 495, DateTimeKind.Local).AddTicks(6425));

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 20, 16, 47, 19, 495, DateTimeKind.Local).AddTicks(6178));
        }
    }
}
