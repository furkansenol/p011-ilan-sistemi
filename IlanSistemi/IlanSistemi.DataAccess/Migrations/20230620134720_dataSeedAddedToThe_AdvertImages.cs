using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IlanSistemi.DataAccess.Migrations
{
    public partial class dataSeedAddedToThe_AdvertImages : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "ImagePath",
                table: "AdvertImages",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200);

            migrationBuilder.UpdateData(
                table: "AdvertImages",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImagePath",
                value: "/Productimage/laptop1.jpeg");

            migrationBuilder.InsertData(
                table: "AdvertImages",
                columns: new[] { "Id", "AdvertId", "ImagePath" },
                values: new object[,]
                {
                    { 2, 2, "/Productimage/yuruyenucak.png" },
                    { 3, 3, "/Productimage/gemicik.jpg" },
                    { 4, 4, "/Productimage/roptesambir.jpg" }
                });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AdvertImages",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "AdvertImages",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "AdvertImages",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.AlterColumn<string>(
                name: "ImagePath",
                table: "AdvertImages",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "AdvertImages",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImagePath",
                value: "~/wwwroot/Productimage/laptop1.jpeg");

            migrationBuilder.UpdateData(
                table: "adverts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 20, 12, 10, 25, 482, DateTimeKind.Local).AddTicks(9719));

            migrationBuilder.UpdateData(
                table: "adverts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 20, 12, 10, 25, 482, DateTimeKind.Local).AddTicks(9725));

            migrationBuilder.UpdateData(
                table: "adverts",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 20, 12, 10, 25, 482, DateTimeKind.Local).AddTicks(9727));

            migrationBuilder.UpdateData(
                table: "adverts",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 20, 12, 10, 25, 482, DateTimeKind.Local).AddTicks(9729));

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 20, 12, 10, 25, 482, DateTimeKind.Local).AddTicks(9372));
        }
    }
}
