using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace E_CommerceSystemV2.DAL.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
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
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
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
                name: "Categories",
                columns: table => new
                {
                    CategoryId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategoryId);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    OrderId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    OrderDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.OrderId);
                });

            migrationBuilder.CreateTable(
                name: "Tags",
                columns: table => new
                {
                    TagId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tags", x => x.TagId);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
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
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
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
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
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
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
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
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
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
                name: "Products",
                columns: table => new
                {
                    ProductId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CategoryType = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CategoryId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ProductId);
                    table.ForeignKey(
                        name: "FK_Products_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "CategoryId");
                });

            migrationBuilder.CreateTable(
                name: "UserOrders",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    OrderId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserOrders", x => new { x.Id, x.OrderId });
                    table.ForeignKey(
                        name: "FK_UserOrders_AspNetUsers_Id",
                        column: x => x.Id,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserOrders_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "OrderId");
                });

            migrationBuilder.CreateTable(
                name: "TagProducts",
                columns: table => new
                {
                    ProductId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TagId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TagProducts", x => new { x.ProductId, x.TagId });
                    table.ForeignKey(
                        name: "FK_TagProducts_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "ProductId");
                    table.ForeignKey(
                        name: "FK_TagProducts_Tags_TagId",
                        column: x => x.TagId,
                        principalTable: "Tags",
                        principalColumn: "TagId");
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "CreationDate", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "6fc57450-b171-416f-a5ee-7ce7aa1e88e4", 0, "600415d0-b9c4-45bf-aaf3-f16b21dd7391", new DateTime(2023, 12, 15, 15, 48, 38, 610, DateTimeKind.Local).AddTicks(1237), "john.doe@example.com", false, false, null, null, null, "password123", null, false, "3173bf8d-84c6-4539-a593-d6f0a4ae5ad2", false, "john doe" },
                    { "817dea1a-128e-4561-bf70-02a61ebb28ea", 0, "6277c217-fdc9-471e-93ad-aba16f7b5c1c", new DateTime(2023, 12, 15, 15, 48, 38, 610, DateTimeKind.Local).AddTicks(1270), "Sandy.Jakson@example.com", false, false, null, null, null, "password123", null, false, "ba5f87ee-157e-407f-b1b9-ba73f181f17c", false, "Sandy Jakson" },
                    { "8f8be606-1b6a-4fc0-9eb4-64cbdeb572db", 0, "224ecd06-efce-4a3d-ab97-4822281bb46b", new DateTime(2023, 12, 15, 15, 48, 38, 610, DateTimeKind.Local).AddTicks(1259), "jane.doe@example.com", false, false, null, null, null, "password123", null, false, "3a9f18ab-5192-4b93-9aaf-6d3a87b383ec", false, "jane doe" },
                    { "911ff057-c661-4236-a00e-67252e78797c", 0, "e1ea3ea7-fb2c-48aa-bf23-99a5a97af942", new DateTime(2023, 12, 15, 15, 48, 38, 610, DateTimeKind.Local).AddTicks(1264), "Sara.doe@example.com", false, false, null, null, null, "password123", null, false, "3415b4ed-c0ce-45c8-adde-9aa3cf52f056", false, "Sara doe" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "Name" },
                values: new object[,]
                {
                    { new Guid("1e3ac85b-8875-49ba-99ba-018ddcf25602"), "Clothing" },
                    { new Guid("2467a93b-c3c7-42e2-bba2-fa67e50d41f8"), "Gaming" },
                    { new Guid("24e47f0b-447c-4d66-aee9-c7be948e0747"), "Electronics" },
                    { new Guid("291fae8e-8fea-4c4e-be1b-74af2c2551a4"), "Mobiles" },
                    { new Guid("73e32f3a-91b2-4047-95c1-d2262bdb0bdd"), "Fashion" },
                    { new Guid("8b7dc28e-cac6-480e-b5fd-24c099a113bb"), "Tablets" },
                    { new Guid("952f2248-1949-4152-8e7b-7ae413f16299"), "SmartDevices" },
                    { new Guid("f6cc9ecd-c88c-42ea-92c3-26f790196617"), "Appliances" }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "OrderId", "OrderDate" },
                values: new object[,]
                {
                    { new Guid("518d50b3-64f1-4856-9bdd-dc711ced2e74"), new DateTime(2023, 12, 15, 15, 48, 38, 610, DateTimeKind.Local).AddTicks(1280) },
                    { new Guid("f1d148a2-8dd8-4315-a227-41f8830ec2df"), new DateTime(2023, 12, 15, 15, 48, 38, 610, DateTimeKind.Local).AddTicks(1282) }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "CategoryId", "CategoryType", "Name", "Price" },
                values: new object[,]
                {
                    { new Guid("1657f280-8380-471a-baa6-4eb846aeaeba"), null, 4, "Cuisinart Coffee Maker", 79.99m },
                    { new Guid("4788ead3-d312-4464-9c24-179513960799"), null, 1, "Sony Smart TV", 1299.99m },
                    { new Guid("4fc22b6d-a00d-4bd7-bd0d-0064ca56d9e8"), null, 2, "Samsung Galaxy S21", 799.99m },
                    { new Guid("6736ffa4-502a-40b9-9c50-04296dbcf4ac"), null, 1, "Canon EOS Rebel T7", 499.99m },
                    { new Guid("748b16c7-0d6b-4ea4-9e44-60b926830a80"), null, 1, "HP Printer", 149.99m },
                    { new Guid("7684c781-877f-4510-bdd9-f02e93ef6d84"), null, 3, "Calvin Klein Watch", 199.99m },
                    { new Guid("7f2bbfb7-2086-4413-b8b6-80765518e7d8"), null, 3, "Adidas Running Shoes", 109.99m },
                    { new Guid("90cfddf2-2827-4ae3-8014-a454a1caf113"), null, 3, "Nike Running Shoes", 89.99m },
                    { new Guid("94a78685-ee6d-4ba1-9f7a-89754ea63625"), null, 1, "Bose Noise-Canceling Headphones", 299.99m },
                    { new Guid("a3bec710-ecf9-4351-9bd4-27c3b245a378"), null, 3, "Levi's Jeans", 59.99m },
                    { new Guid("ba7306fa-9228-4e20-8f9d-2d6160f13938"), null, 5, "Amazon Echo Dot", 39.99m },
                    { new Guid("c6e72622-1cb0-468c-b459-558ddf96c98e"), null, 6, "Fitbit Charge 5", 149.99m },
                    { new Guid("d780117e-5d00-4738-9d40-451366845386"), null, 4, "KitchenAid Stand Mixer", 349.99m },
                    { new Guid("deaf8252-e940-4e15-a060-2ff721484b91"), null, 3, "Fossil Smartwatch", 149.99m },
                    { new Guid("e3a13aec-4b03-4e57-bd01-30ae111f39ef"), null, 6, "Razer Gaming Mouse", 69.99m }
                });

            migrationBuilder.InsertData(
                table: "Tags",
                columns: new[] { "TagId", "Name" },
                values: new object[,]
                {
                    { new Guid("43e42810-d632-4245-bbc1-112b905e562a"), "Tech" },
                    { new Guid("499ff470-510c-4250-8a57-60e43c9552e3"), "FlagShip Mobiles" },
                    { new Guid("966023cd-9348-47e5-a06f-b95767e2ae3a"), "Fashion 2024" }
                });

            migrationBuilder.InsertData(
                table: "TagProducts",
                columns: new[] { "ProductId", "TagId" },
                values: new object[,]
                {
                    { new Guid("4788ead3-d312-4464-9c24-179513960799"), new Guid("499ff470-510c-4250-8a57-60e43c9552e3") },
                    { new Guid("6736ffa4-502a-40b9-9c50-04296dbcf4ac"), new Guid("43e42810-d632-4245-bbc1-112b905e562a") }
                });

            migrationBuilder.InsertData(
                table: "UserOrders",
                columns: new[] { "Id", "OrderId" },
                values: new object[,]
                {
                    { "8f8be606-1b6a-4fc0-9eb4-64cbdeb572db", new Guid("f1d148a2-8dd8-4315-a227-41f8830ec2df") },
                    { "911ff057-c661-4236-a00e-67252e78797c", new Guid("f1d148a2-8dd8-4315-a227-41f8830ec2df") }
                });

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
                name: "IX_Products_CategoryId",
                table: "Products",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_TagProducts_TagId",
                table: "TagProducts",
                column: "TagId");

            migrationBuilder.CreateIndex(
                name: "IX_UserOrders_OrderId",
                table: "UserOrders",
                column: "OrderId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
                name: "TagProducts");

            migrationBuilder.DropTable(
                name: "UserOrders");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Tags");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
