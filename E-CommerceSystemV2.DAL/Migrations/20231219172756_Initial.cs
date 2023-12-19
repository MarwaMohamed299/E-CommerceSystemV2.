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
                name: "Tags",
                columns: table => new
                {
                    TagId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
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
                name: "Orders",
                columns: table => new
                {
                    OrderId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    OrderDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.OrderId);
                    table.ForeignKey(
                        name: "FK_Orders_AspNetUsers_UserId",
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
                    CategoryId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    OrderId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TagId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ProductId);
                    table.ForeignKey(
                        name: "FK_Products_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "CategoryId");
                    table.ForeignKey(
                        name: "FK_Products_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "OrderId");
                    table.ForeignKey(
                        name: "FK_Products_Tags_TagId",
                        column: x => x.TagId,
                        principalTable: "Tags",
                        principalColumn: "TagId");
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
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Cascade);
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
                    { "5e542efa-8217-4855-93d7-7c47a56c98f7", 0, "2eec0103-b47a-4d67-a071-16f0f3e6ac86", new DateTime(2023, 12, 19, 20, 27, 55, 374, DateTimeKind.Local).AddTicks(1021), "Sara.doe@example.com", false, false, null, null, null, "password123", null, false, "76d3d2e8-4f48-4ee9-a49d-4bfff2003a69", false, "Sara doe" },
                    { "7517cc9e-ced0-48ce-b404-ace27e6e2c9d", 0, "4fb8f04c-1532-4a06-9f6c-70947b15b274", new DateTime(2023, 12, 19, 20, 27, 55, 374, DateTimeKind.Local).AddTicks(995), "john.doe@example.com", false, false, null, null, null, "password123", null, false, "8afa9aee-b694-4f5f-ba9b-9b60919c5d0e", false, "john doe" },
                    { "c6a48572-1d1c-47bc-8082-97369cb152fe", 0, "04ed1d37-8e38-4b3a-bab7-da9c0d6b1458", new DateTime(2023, 12, 19, 20, 27, 55, 374, DateTimeKind.Local).AddTicks(1029), "Sandy.Jakson@example.com", false, false, null, null, null, "password123", null, false, "7f27fa9b-67c4-41e5-9b96-9c4cba002de7", false, "Sandy Jakson" },
                    { "f86a79f0-0680-41f5-a2d8-8bf2d1c04081", 0, "a232040e-2f38-4bcd-8a72-15df79e8ff93", new DateTime(2023, 12, 19, 20, 27, 55, 374, DateTimeKind.Local).AddTicks(1010), "jane.doe@example.com", false, false, null, null, null, "password123", null, false, "892a66a2-be15-4cea-a391-95464787d676", false, "jane doe" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "Name" },
                values: new object[,]
                {
                    { new Guid("0397150e-05b3-4fc2-8e6b-9a53b1da359f"), "Fashion" },
                    { new Guid("40b5538a-5108-43ab-98d8-154909d27980"), "SmartDevices" },
                    { new Guid("5a59f5a4-d059-4155-8b72-d8e9db8d6237"), "Mobiles" },
                    { new Guid("9b7b88c5-162c-4712-b414-c0f1002bbe82"), "Tablets" },
                    { new Guid("a3e7cffc-f47a-46cb-9233-927aa8e42e07"), "Electronics" },
                    { new Guid("e20fcb32-e66b-4f39-bcc4-17093bd305b9"), "Clothing" },
                    { new Guid("e8776dd9-f129-4696-9e2e-1f44d71b0293"), "Appliances" },
                    { new Guid("f404369a-5578-4593-93aa-8817a630f639"), "Gaming" }
                });

            migrationBuilder.InsertData(
                table: "Tags",
                columns: new[] { "TagId", "Name" },
                values: new object[,]
                {
                    { new Guid("6613d20b-76c4-4d60-9f2c-b4f4d33a11c7"), "FlagShip Mobiles" },
                    { new Guid("ce580732-35a9-41b8-96af-116518cef9f1"), "Fashion 2024" },
                    { new Guid("f1c0a02b-b9e0-4155-b618-1e316f486fd6"), "Tech" }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "OrderId", "OrderDate", "UserId" },
                values: new object[,]
                {
                    { new Guid("20dd7cb7-5440-41fd-bf00-65e47a056d0c"), new DateTime(2023, 12, 19, 20, 27, 55, 374, DateTimeKind.Local).AddTicks(1039), "f86a79f0-0680-41f5-a2d8-8bf2d1c04081" },
                    { new Guid("46307b76-03aa-4329-9216-1ad02d7f3ce5"), new DateTime(2023, 12, 19, 20, 27, 55, 374, DateTimeKind.Local).AddTicks(1070), "5e542efa-8217-4855-93d7-7c47a56c98f7" },
                    { new Guid("5a3081d7-7565-4335-a199-c5fc4ccc8096"), new DateTime(2023, 12, 19, 20, 27, 55, 374, DateTimeKind.Local).AddTicks(1045), "7517cc9e-ced0-48ce-b404-ace27e6e2c9d" },
                    { new Guid("5d0bfb29-1d96-448c-942a-cbb084cf32a5"), new DateTime(2023, 12, 19, 20, 27, 55, 374, DateTimeKind.Local).AddTicks(1067), "c6a48572-1d1c-47bc-8082-97369cb152fe" },
                    { new Guid("8d6ed240-c801-4b55-a881-58827c28fb06"), new DateTime(2023, 12, 19, 20, 27, 55, 374, DateTimeKind.Local).AddTicks(1048), "f86a79f0-0680-41f5-a2d8-8bf2d1c04081" },
                    { new Guid("9f1db7cb-46dc-4b3b-80f1-113ab1c10a2f"), new DateTime(2023, 12, 19, 20, 27, 55, 374, DateTimeKind.Local).AddTicks(1073), "f86a79f0-0680-41f5-a2d8-8bf2d1c04081" },
                    { new Guid("e5dd0a36-65f0-49fb-9f16-75c279dbc6c3"), new DateTime(2023, 12, 19, 20, 27, 55, 374, DateTimeKind.Local).AddTicks(1052), "5e542efa-8217-4855-93d7-7c47a56c98f7" },
                    { new Guid("e6a023f6-99c0-4a34-9ecb-0b49d367dc50"), new DateTime(2023, 12, 19, 20, 27, 55, 374, DateTimeKind.Local).AddTicks(1058), "f86a79f0-0680-41f5-a2d8-8bf2d1c04081" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "CategoryId", "CategoryType", "Name", "OrderId", "Price", "TagId" },
                values: new object[,]
                {
                    { new Guid("04ef4f41-6446-4dd9-9173-1fd64e651444"), null, 3, "Adidas Running Shoes", new Guid("8d6ed240-c801-4b55-a881-58827c28fb06"), 109.99m, null },
                    { new Guid("064fd01a-bf9f-4889-9200-60b295613c54"), null, 3, "Levi's Jeans", new Guid("5a3081d7-7565-4335-a199-c5fc4ccc8096"), 59.99m, null },
                    { new Guid("103fc9a8-64ee-4e1a-ae9e-ac26a3974109"), null, 3, "Fossil Smartwatch", new Guid("20dd7cb7-5440-41fd-bf00-65e47a056d0c"), 149.99m, null },
                    { new Guid("3935c87e-2954-44cc-a95f-7f67a902291b"), null, 1, "Bose Noise-Canceling Headphones", new Guid("5a3081d7-7565-4335-a199-c5fc4ccc8096"), 299.99m, null },
                    { new Guid("399acc92-7aaa-4f05-aae2-d07e88e83ebb"), null, 1, "HP Printer", new Guid("5a3081d7-7565-4335-a199-c5fc4ccc8096"), 149.99m, null },
                    { new Guid("3bef8d04-44fe-4b64-9919-400029667621"), null, 4, "KitchenAid Stand Mixer", new Guid("e5dd0a36-65f0-49fb-9f16-75c279dbc6c3"), 349.99m, null },
                    { new Guid("3d12a097-ae94-4bd1-8aa6-9bc40128a7f8"), null, 2, "Samsung Galaxy S21", new Guid("20dd7cb7-5440-41fd-bf00-65e47a056d0c"), 799.99m, null },
                    { new Guid("55b572f5-374d-4ecc-81a4-b242ba6a5ea1"), null, 5, "Amazon Echo Dot", new Guid("5a3081d7-7565-4335-a199-c5fc4ccc8096"), 39.99m, null },
                    { new Guid("ae170701-a04d-476e-8bd9-3f9bb12bf79f"), null, 1, "Sony Smart TV", new Guid("5a3081d7-7565-4335-a199-c5fc4ccc8096"), 1299.99m, null },
                    { new Guid("b243621f-e966-476e-acfb-6dabb89cd8a7"), null, 3, "Nike Running Shoes", new Guid("5a3081d7-7565-4335-a199-c5fc4ccc8096"), 89.99m, null },
                    { new Guid("c75be557-8fd5-4e3b-9725-61b3a97142bd"), null, 6, "Razer Gaming Mouse", new Guid("5a3081d7-7565-4335-a199-c5fc4ccc8096"), 69.99m, null },
                    { new Guid("c79c163e-ca39-42d6-980e-981e97d2fe5f"), null, 1, "Canon EOS Rebel T7", new Guid("8d6ed240-c801-4b55-a881-58827c28fb06"), 499.99m, null },
                    { new Guid("d82730ad-c898-48fb-bc7a-7d0ab50cd6a4"), null, 6, "Fitbit Charge 5", new Guid("5a3081d7-7565-4335-a199-c5fc4ccc8096"), 149.99m, null },
                    { new Guid("dda0b29c-14c9-40c2-872d-e0f7fec49d7a"), null, 3, "Calvin Klein Watch", new Guid("5a3081d7-7565-4335-a199-c5fc4ccc8096"), 199.99m, null },
                    { new Guid("f2332187-7456-4e9c-a3fa-db3621091cf6"), null, 4, "Cuisinart Coffee Maker", new Guid("20dd7cb7-5440-41fd-bf00-65e47a056d0c"), 79.99m, null }
                });

            migrationBuilder.InsertData(
                table: "TagProducts",
                columns: new[] { "ProductId", "TagId" },
                values: new object[,]
                {
                    { new Guid("064fd01a-bf9f-4889-9200-60b295613c54"), new Guid("f1c0a02b-b9e0-4155-b618-1e316f486fd6") },
                    { new Guid("3935c87e-2954-44cc-a95f-7f67a902291b"), new Guid("f1c0a02b-b9e0-4155-b618-1e316f486fd6") },
                    { new Guid("399acc92-7aaa-4f05-aae2-d07e88e83ebb"), new Guid("f1c0a02b-b9e0-4155-b618-1e316f486fd6") },
                    { new Guid("3bef8d04-44fe-4b64-9919-400029667621"), new Guid("f1c0a02b-b9e0-4155-b618-1e316f486fd6") },
                    { new Guid("ae170701-a04d-476e-8bd9-3f9bb12bf79f"), new Guid("6613d20b-76c4-4d60-9f2c-b4f4d33a11c7") },
                    { new Guid("b243621f-e966-476e-acfb-6dabb89cd8a7"), new Guid("f1c0a02b-b9e0-4155-b618-1e316f486fd6") },
                    { new Guid("c79c163e-ca39-42d6-980e-981e97d2fe5f"), new Guid("f1c0a02b-b9e0-4155-b618-1e316f486fd6") }
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
                name: "IX_Orders_UserId",
                table: "Orders",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryId",
                table: "Products",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_OrderId",
                table: "Products",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_TagId",
                table: "Products",
                column: "TagId");

            migrationBuilder.CreateIndex(
                name: "IX_TagProducts_TagId",
                table: "TagProducts",
                column: "TagId");
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
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Tags");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}
