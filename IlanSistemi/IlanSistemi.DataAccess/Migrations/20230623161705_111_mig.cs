using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IlanSistemi.DataAccess.Migrations
{
<<<<<<<< HEAD:IlanSistemi/IlanSistemi.DataAccess/Migrations/20230623104111_23_06_2023_first.cs
    public partial class _23_06_2023_first : Migration
========
    public partial class _111_mig : Migration
>>>>>>>> 02271caab0f6c103eb5bdc32cb44f06fc72092c9:IlanSistemi/IlanSistemi.DataAccess/Migrations/20230623161705_111_mig.cs
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Surname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsBanned = table.Column<bool>(type: "bit", nullable: true),
                    IsSuspended = table.Column<bool>(type: "bit", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "pages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Content = table.Column<string>(type: "text", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_pages", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<int>(type: "int", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "adverts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UsersId = table.Column<int>(type: "int", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_adverts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_adverts_AspNetUsers_UsersId",
                        column: x => x.UsersId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false),
                    RoleId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "settings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Value = table.Column<string>(type: "nvarchar(400)", maxLength: 400, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_settings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_settings_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "advertComments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    Comment = table.Column<string>(type: "text", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    AdvertId1 = table.Column<int>(type: "int", nullable: true),
                    UsersId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_advertComments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_advertComments_adverts_AdvertId1",
                        column: x => x.AdvertId1,
                        principalTable: "adverts",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_advertComments_adverts_Id",
                        column: x => x.Id,
                        principalTable: "adverts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_advertComments_AspNetUsers_Id",
                        column: x => x.Id,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_advertComments_AspNetUsers_UsersId",
                        column: x => x.UsersId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "AdvertImages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AdvertId = table.Column<int>(type: "int", nullable: true),
                    ImagePath = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdvertImages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AdvertImages_adverts_AdvertId",
                        column: x => x.AdvertId,
                        principalTable: "adverts",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "CategoryAdverts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    AdvertId = table.Column<int>(type: "int", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoryAdverts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CategoryAdverts_adverts_AdvertId",
                        column: x => x.AdvertId,
                        principalTable: "adverts",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_CategoryAdverts_categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
<<<<<<<< HEAD:IlanSistemi/IlanSistemi.DataAccess/Migrations/20230623104111_23_06_2023_first.cs
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "ConcurrencyStamp", "CreatedAt", "DeletedAt", "Email", "EmailConfirmed", "ImageUrl", "IsBanned", "IsSuspended", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "Phone", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "Surname", "TwoFactorEnabled", "UpdatedAt", "UserName" },
                values: new object[] { 4, 0, "Türkiye", "f69fe248-85eb-426b-b4af-c8d26dc8842d", new DateTime(2023, 6, 23, 13, 41, 10, 959, DateTimeKind.Local).AddTicks(4303), null, "sample@user.com", false, null, null, null, false, null, "Sample", null, null, null, "0543212340", null, false, null, "123456", false, null, null });

            migrationBuilder.InsertData(
========
>>>>>>>> 02271caab0f6c103eb5bdc32cb44f06fc72092c9:IlanSistemi/IlanSistemi.DataAccess/Migrations/20230623161705_111_mig.cs
                table: "categories",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { 1, "Elektronik", "Elektronik" },
                    { 2, "Envai çeşit sizi çıplaklıktan koruyacak kıyafetler.", "Moda" },
                    { 3, "Ev Tekstili, Mutfak Gereçleri", "Ev-Yasam" },
                    { 4, "Aradığınız tüm spor ürünleri", "Spor-Outdoor" },
                    { 5, "Kişisel bakım ve makyaj malzemeleri", "Kozmetik" }
                });

<<<<<<<< HEAD:IlanSistemi/IlanSistemi.DataAccess/Migrations/20230623104111_23_06_2023_first.cs
            migrationBuilder.InsertData(
                table: "adverts",
                columns: new[] { "Id", "CreatedAt", "DeletedAt", "Description", "Title", "UpdatedAt", "UsersId" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 6, 23, 13, 41, 10, 959, DateTimeKind.Local).AddTicks(4440), null, "Sahibinden garantisiz laptop", "Laptop Bal Almayan Mal", null, 4 },
                    { 2, null, null, "Yürüyeni iyi uçak", "Yürüyen Uçak", null, 4 },
                    { 3, new DateTime(2023, 6, 23, 13, 41, 10, 959, DateTimeKind.Local).AddTicks(4451), null, "Krediye uygun gemicik", "Gemicik", null, 4 },
                    { 4, new DateTime(2023, 6, 23, 13, 41, 10, 959, DateTimeKind.Local).AddTicks(4452), null, "Zengin pijaması", "Röpteşambır", null, 4 }
                });

            migrationBuilder.InsertData(
                table: "AdvertImages",
                columns: new[] { "Id", "AdvertId", "ImagePath" },
                values: new object[,]
                {
                    { 1, 1, "/Productimage/laptop1.jpeg" },
                    { 2, 2, "/Productimage/yuruyenucak.png" },
                    { 3, 3, "/Productimage/gemicik.jpg" },
                    { 4, 4, "/Productimage/roptesambir.jpg" }
                });

            migrationBuilder.InsertData(
                table: "CategoryAdverts",
                columns: new[] { "Id", "AdvertId", "CategoryId", "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, 1, 1, null, null, null },
                    { 2, 2, 1, null, null, null },
                    { 3, 4, 2, null, null, null },
                    { 4, 3, 2, null, null, null }
                });

========
>>>>>>>> 02271caab0f6c103eb5bdc32cb44f06fc72092c9:IlanSistemi/IlanSistemi.DataAccess/Migrations/20230623161705_111_mig.cs
            migrationBuilder.CreateIndex(
                name: "IX_advertComments_AdvertId1",
                table: "advertComments",
                column: "AdvertId1");

            migrationBuilder.CreateIndex(
                name: "IX_advertComments_UsersId",
                table: "advertComments",
                column: "UsersId");

            migrationBuilder.CreateIndex(
                name: "IX_AdvertImages_AdvertId",
                table: "AdvertImages",
                column: "AdvertId");

            migrationBuilder.CreateIndex(
                name: "IX_adverts_UsersId",
                table: "adverts",
                column: "UsersId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_CategoryAdverts_AdvertId",
                table: "CategoryAdverts",
                column: "AdvertId");

            migrationBuilder.CreateIndex(
                name: "IX_CategoryAdverts_CategoryId",
                table: "CategoryAdverts",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_settings_UserId",
                table: "settings",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "advertComments");

            migrationBuilder.DropTable(
                name: "AdvertImages");

            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "CategoryAdverts");

            migrationBuilder.DropTable(
                name: "pages");

            migrationBuilder.DropTable(
                name: "settings");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "adverts");

            migrationBuilder.DropTable(
                name: "categories");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}
