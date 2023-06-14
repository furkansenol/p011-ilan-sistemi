using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IlanSistemi.DataAccess.Migrations
{
    public partial class CategoryAdvertDataSeedAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "adverts",
                columns: new[] { "Id", "CreatedAt", "DeletedAt", "Description", "Title", "UpdatedAt", "UserId" },
                values: new object[] { 4, new DateTime(2023, 6, 14, 16, 12, 27, 434, DateTimeKind.Local).AddTicks(7827), null, "Zengin pijaması", "Röpteşambır", null, 1 });

            migrationBuilder.InsertData(
                table: "categoryAdverts",
                columns: new[] { "Id", "AdvertId", "CategoryId", "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, 1, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null },
                    { 2, 2, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null }
                });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 14, 16, 12, 27, 434, DateTimeKind.Local).AddTicks(7638));

            migrationBuilder.InsertData(
                table: "categoryAdverts",
                columns: new[] { "Id", "AdvertId", "CategoryId", "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { 3, 4, 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "categoryAdverts",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "categoryAdverts",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "categoryAdverts",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "adverts",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.UpdateData(
                table: "adverts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 14, 13, 11, 11, 212, DateTimeKind.Local).AddTicks(4493));

            migrationBuilder.UpdateData(
                table: "adverts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 14, 13, 11, 11, 212, DateTimeKind.Local).AddTicks(4497));

            migrationBuilder.UpdateData(
                table: "adverts",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 14, 13, 11, 11, 212, DateTimeKind.Local).AddTicks(4498));

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 14, 13, 11, 11, 212, DateTimeKind.Local).AddTicks(4356));
        }
    }
}
