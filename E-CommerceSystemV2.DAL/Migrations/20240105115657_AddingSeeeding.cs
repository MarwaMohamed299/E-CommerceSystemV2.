using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace E_CommerceSystemV2.DAL.Migrations
{
    /// <inheritdoc />
    public partial class AddingSeeeding : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Orders_OrderId",
                table: "Products");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "CreationDate", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "331564f6-3281-4a64-b903-feb3d97fe146", 0, "690e1610-c9fb-4db0-b2fc-f674c88194cb", new DateTime(2024, 1, 5, 14, 56, 56, 606, DateTimeKind.Local).AddTicks(7389), "john.doe@example.com", false, false, null, null, null, "password123", null, false, "2ad7844c-481e-4f2e-9b65-4a279f01ce97", false, "john doe" },
                    { "49003d27-37d3-4a86-93ce-5b2221318114", 0, "d9bf1c11-9dcc-4476-bcac-a51f326c7e60", new DateTime(2024, 1, 5, 14, 56, 56, 606, DateTimeKind.Local).AddTicks(7417), "Sara.doe@example.com", false, false, null, null, null, "password123", null, false, "4bde03dc-0640-4d5e-81f4-18c843a94620", false, "Sara doe" },
                    { "914f96f1-b243-4b96-a43c-c0043dff9715", 0, "1e6e2b92-5498-40ea-9425-7319de224489", new DateTime(2024, 1, 5, 14, 56, 56, 606, DateTimeKind.Local).AddTicks(7397), "jane.doe@example.com", false, false, null, null, null, "password123", null, false, "c7c4311e-e338-40a8-86e0-266b064b14a1", false, "jane doe" },
                    { "cd418a76-6602-473d-bfea-8ca934e30b56", 0, "0312a912-34ca-4987-915c-fc94b30f07a4", new DateTime(2024, 1, 5, 14, 56, 56, 606, DateTimeKind.Local).AddTicks(7422), "Sandy.Jakson@example.com", false, false, null, null, null, "password123", null, false, "722e3c5c-f4f2-4213-ac37-a4b7c4c48ce7", false, "Sandy Jakson" }
                });

            migrationBuilder.InsertData(
                table: "CampaignCustomers",
                columns: new[] { "Id", "Email", "Name" },
                values: new object[,]
                {
                    { new Guid("449673be-c237-4dfd-8f83-c80768e9ef44"), "marwaghonem29@gmail.com", "Marwa" },
                    { new Guid("6023ed86-cf89-4c14-9a87-ea26ae24f460"), "Jamal_Ali@outlook.com", "Jamal" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "Name" },
                values: new object[,]
                {
                    { new Guid("20f70b3d-708a-4ba8-9128-4615a3464fd3"), "Appliances" },
                    { new Guid("45cefe16-9fe9-4028-9464-802cc92219c6"), "Tablets" },
                    { new Guid("509ab127-35e7-4aea-a7f6-9e0def6ccd96"), "SmartDevices" },
                    { new Guid("618b02db-d1cf-4b2b-9fbf-320d08377b42"), "Clothing" },
                    { new Guid("77370d0b-070f-4153-a544-8f57604d6a14"), "Fashion" },
                    { new Guid("aa86afc3-e0d5-4741-b047-343f1885376a"), "Gaming" },
                    { new Guid("ba0ff918-546c-4478-bc90-e74ab59f3cff"), "Electronics" },
                    { new Guid("bf643b98-64fc-46c1-8c31-552111eb74f5"), "Mobiles" }
                });

            migrationBuilder.InsertData(
                table: "Tags",
                columns: new[] { "TagId", "Name" },
                values: new object[,]
                {
                    { new Guid("6d89fe93-505b-4032-a51d-32278ff391bd"), "Tech" },
                    { new Guid("7236c9dc-d594-4f04-a7ea-442b9c7ce9f6"), "FlagShip Mobiles" },
                    { new Guid("e126b7b4-d6fe-4b6e-9b0f-d865b3871827"), "Fashion 2024" }
                });

            migrationBuilder.InsertData(
                table: "Textsss",
                columns: new[] { "Id", "ArabicText", "EnglishText", "TextKey" },
                values: new object[] { new Guid("8a8fa707-cd35-4050-9763-7abb813bf3c6"), "مرحبا", "Welcome", "WelcomeMessage" });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "OrderId", "OrderDate", "UserId" },
                values: new object[,]
                {
                    { new Guid("1a5635e0-8a4d-4f11-879f-4c06bd69be8d"), new DateTime(2024, 1, 5, 14, 56, 56, 606, DateTimeKind.Local).AddTicks(7444), "49003d27-37d3-4a86-93ce-5b2221318114" },
                    { new Guid("55a3d7fe-43ef-4ca1-93e5-ecfab416766b"), new DateTime(2024, 1, 5, 14, 56, 56, 606, DateTimeKind.Local).AddTicks(7446), "914f96f1-b243-4b96-a43c-c0043dff9715" },
                    { new Guid("60eea5da-f2cd-4fdc-b3f5-794894b1ab21"), new DateTime(2024, 1, 5, 14, 56, 56, 606, DateTimeKind.Local).AddTicks(7442), "914f96f1-b243-4b96-a43c-c0043dff9715" },
                    { new Guid("61432ee8-c136-4459-b69c-c4957801355d"), new DateTime(2024, 1, 5, 14, 56, 56, 606, DateTimeKind.Local).AddTicks(7437), "331564f6-3281-4a64-b903-feb3d97fe146" },
                    { new Guid("90a81f1c-1c00-4a0e-8f56-21f3b53cba00"), new DateTime(2024, 1, 5, 14, 56, 56, 606, DateTimeKind.Local).AddTicks(7450), "cd418a76-6602-473d-bfea-8ca934e30b56" },
                    { new Guid("d04ab8fd-047f-426b-a775-a5c022ce660b"), new DateTime(2024, 1, 5, 14, 56, 56, 606, DateTimeKind.Local).AddTicks(7454), "914f96f1-b243-4b96-a43c-c0043dff9715" },
                    { new Guid("da6032a1-ff08-45d0-aa1a-47d702bccdb2"), new DateTime(2024, 1, 5, 14, 56, 56, 606, DateTimeKind.Local).AddTicks(7452), "49003d27-37d3-4a86-93ce-5b2221318114" },
                    { new Guid("f7a110d0-7cc3-4988-be3b-4f3f0f5932ad"), new DateTime(2024, 1, 5, 14, 56, 56, 606, DateTimeKind.Local).AddTicks(7429), "914f96f1-b243-4b96-a43c-c0043dff9715" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "CategoryId", "CategoryType", "Name", "OrderId", "Price", "TagId" },
                values: new object[,]
                {
                    { new Guid("333ed7b8-90c6-4522-9fde-43f57b5b89e1"), null, 3, "Calvin Klein Watch", new Guid("61432ee8-c136-4459-b69c-c4957801355d"), 199.99m, null },
                    { new Guid("33427392-3d61-428b-bb74-b27358dae2f6"), null, 1, "HP Printer", new Guid("61432ee8-c136-4459-b69c-c4957801355d"), 149.99m, null },
                    { new Guid("75ecfe62-c1fc-4466-83e7-451999543342"), null, 6, "Razer Gaming Mouse", new Guid("61432ee8-c136-4459-b69c-c4957801355d"), 69.99m, null },
                    { new Guid("871b5405-6dc5-47a6-b02e-f80c6ebee9e2"), null, 1, "Bose Noise-Canceling Headphones", new Guid("61432ee8-c136-4459-b69c-c4957801355d"), 299.99m, null },
                    { new Guid("8d227ecc-04a6-4817-a5a4-6201cf76dd40"), null, 5, "Amazon Echo Dot", new Guid("61432ee8-c136-4459-b69c-c4957801355d"), 39.99m, null },
                    { new Guid("97f2567f-0d57-4a10-aab9-43f66393afd1"), null, 3, "Fossil Smartwatch", new Guid("f7a110d0-7cc3-4988-be3b-4f3f0f5932ad"), 149.99m, null },
                    { new Guid("b24c1794-db69-4d84-b448-5ac708f458a4"), null, 1, "Canon EOS Rebel T7", new Guid("60eea5da-f2cd-4fdc-b3f5-794894b1ab21"), 499.99m, null },
                    { new Guid("ca4d1ded-7d4d-41f6-9ee0-41715085f598"), null, 4, "Cuisinart Coffee Maker", new Guid("f7a110d0-7cc3-4988-be3b-4f3f0f5932ad"), 79.99m, null },
                    { new Guid("d1027440-6b13-4fd2-bfba-340214f09c37"), null, 3, "Levi's Jeans", new Guid("61432ee8-c136-4459-b69c-c4957801355d"), 59.99m, null },
                    { new Guid("df32db8b-15c3-44af-aff1-a2440dc7f523"), null, 6, "Fitbit Charge 5", new Guid("61432ee8-c136-4459-b69c-c4957801355d"), 149.99m, null },
                    { new Guid("e4278ee9-549f-4e3a-bb40-5771e6de00aa"), null, 1, "Sony Smart TV", new Guid("61432ee8-c136-4459-b69c-c4957801355d"), 1299.99m, null },
                    { new Guid("e57b0fdf-ab7b-498b-964a-9e983526540b"), null, 4, "KitchenAid Stand Mixer", new Guid("1a5635e0-8a4d-4f11-879f-4c06bd69be8d"), 349.99m, null },
                    { new Guid("f2f71960-3867-4b42-bd30-f4b8802f747c"), null, 2, "Samsung Galaxy S21", new Guid("f7a110d0-7cc3-4988-be3b-4f3f0f5932ad"), 799.99m, null },
                    { new Guid("f42865db-b358-4151-a681-f95b7e2a541a"), null, 3, "Adidas Running Shoes", new Guid("60eea5da-f2cd-4fdc-b3f5-794894b1ab21"), 109.99m, null },
                    { new Guid("ff60d97f-a5fe-4585-a207-0b499a22a82c"), null, 3, "Nike Running Shoes", new Guid("61432ee8-c136-4459-b69c-c4957801355d"), 89.99m, null }
                });

            migrationBuilder.InsertData(
                table: "TagProducts",
                columns: new[] { "ProductId", "TagId" },
                values: new object[,]
                {
                    { new Guid("33427392-3d61-428b-bb74-b27358dae2f6"), new Guid("6d89fe93-505b-4032-a51d-32278ff391bd") },
                    { new Guid("871b5405-6dc5-47a6-b02e-f80c6ebee9e2"), new Guid("6d89fe93-505b-4032-a51d-32278ff391bd") },
                    { new Guid("b24c1794-db69-4d84-b448-5ac708f458a4"), new Guid("6d89fe93-505b-4032-a51d-32278ff391bd") },
                    { new Guid("d1027440-6b13-4fd2-bfba-340214f09c37"), new Guid("6d89fe93-505b-4032-a51d-32278ff391bd") },
                    { new Guid("e4278ee9-549f-4e3a-bb40-5771e6de00aa"), new Guid("7236c9dc-d594-4f04-a7ea-442b9c7ce9f6") },
                    { new Guid("e57b0fdf-ab7b-498b-964a-9e983526540b"), new Guid("6d89fe93-505b-4032-a51d-32278ff391bd") },
                    { new Guid("ff60d97f-a5fe-4585-a207-0b499a22a82c"), new Guid("6d89fe93-505b-4032-a51d-32278ff391bd") }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Orders_OrderId",
                table: "Products",
                column: "OrderId",
                principalTable: "Orders",
                principalColumn: "OrderId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Orders_OrderId",
                table: "Products");

            migrationBuilder.DeleteData(
                table: "CampaignCustomers",
                keyColumn: "Id",
                keyValue: new Guid("449673be-c237-4dfd-8f83-c80768e9ef44"));

            migrationBuilder.DeleteData(
                table: "CampaignCustomers",
                keyColumn: "Id",
                keyValue: new Guid("6023ed86-cf89-4c14-9a87-ea26ae24f460"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("20f70b3d-708a-4ba8-9128-4615a3464fd3"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("45cefe16-9fe9-4028-9464-802cc92219c6"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("509ab127-35e7-4aea-a7f6-9e0def6ccd96"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("618b02db-d1cf-4b2b-9fbf-320d08377b42"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("77370d0b-070f-4153-a544-8f57604d6a14"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("aa86afc3-e0d5-4741-b047-343f1885376a"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("ba0ff918-546c-4478-bc90-e74ab59f3cff"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("bf643b98-64fc-46c1-8c31-552111eb74f5"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: new Guid("55a3d7fe-43ef-4ca1-93e5-ecfab416766b"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: new Guid("90a81f1c-1c00-4a0e-8f56-21f3b53cba00"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: new Guid("d04ab8fd-047f-426b-a775-a5c022ce660b"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: new Guid("da6032a1-ff08-45d0-aa1a-47d702bccdb2"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("333ed7b8-90c6-4522-9fde-43f57b5b89e1"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("75ecfe62-c1fc-4466-83e7-451999543342"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("8d227ecc-04a6-4817-a5a4-6201cf76dd40"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("97f2567f-0d57-4a10-aab9-43f66393afd1"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("ca4d1ded-7d4d-41f6-9ee0-41715085f598"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("df32db8b-15c3-44af-aff1-a2440dc7f523"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("f2f71960-3867-4b42-bd30-f4b8802f747c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("f42865db-b358-4151-a681-f95b7e2a541a"));

            migrationBuilder.DeleteData(
                table: "TagProducts",
                keyColumns: new[] { "ProductId", "TagId" },
                keyValues: new object[] { new Guid("33427392-3d61-428b-bb74-b27358dae2f6"), new Guid("6d89fe93-505b-4032-a51d-32278ff391bd") });

            migrationBuilder.DeleteData(
                table: "TagProducts",
                keyColumns: new[] { "ProductId", "TagId" },
                keyValues: new object[] { new Guid("871b5405-6dc5-47a6-b02e-f80c6ebee9e2"), new Guid("6d89fe93-505b-4032-a51d-32278ff391bd") });

            migrationBuilder.DeleteData(
                table: "TagProducts",
                keyColumns: new[] { "ProductId", "TagId" },
                keyValues: new object[] { new Guid("b24c1794-db69-4d84-b448-5ac708f458a4"), new Guid("6d89fe93-505b-4032-a51d-32278ff391bd") });

            migrationBuilder.DeleteData(
                table: "TagProducts",
                keyColumns: new[] { "ProductId", "TagId" },
                keyValues: new object[] { new Guid("d1027440-6b13-4fd2-bfba-340214f09c37"), new Guid("6d89fe93-505b-4032-a51d-32278ff391bd") });

            migrationBuilder.DeleteData(
                table: "TagProducts",
                keyColumns: new[] { "ProductId", "TagId" },
                keyValues: new object[] { new Guid("e4278ee9-549f-4e3a-bb40-5771e6de00aa"), new Guid("7236c9dc-d594-4f04-a7ea-442b9c7ce9f6") });

            migrationBuilder.DeleteData(
                table: "TagProducts",
                keyColumns: new[] { "ProductId", "TagId" },
                keyValues: new object[] { new Guid("e57b0fdf-ab7b-498b-964a-9e983526540b"), new Guid("6d89fe93-505b-4032-a51d-32278ff391bd") });

            migrationBuilder.DeleteData(
                table: "TagProducts",
                keyColumns: new[] { "ProductId", "TagId" },
                keyValues: new object[] { new Guid("ff60d97f-a5fe-4585-a207-0b499a22a82c"), new Guid("6d89fe93-505b-4032-a51d-32278ff391bd") });

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "TagId",
                keyValue: new Guid("e126b7b4-d6fe-4b6e-9b0f-d865b3871827"));

            migrationBuilder.DeleteData(
                table: "Textsss",
                keyColumn: "Id",
                keyValue: new Guid("8a8fa707-cd35-4050-9763-7abb813bf3c6"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cd418a76-6602-473d-bfea-8ca934e30b56");

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: new Guid("f7a110d0-7cc3-4988-be3b-4f3f0f5932ad"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("33427392-3d61-428b-bb74-b27358dae2f6"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("871b5405-6dc5-47a6-b02e-f80c6ebee9e2"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("b24c1794-db69-4d84-b448-5ac708f458a4"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("d1027440-6b13-4fd2-bfba-340214f09c37"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("e4278ee9-549f-4e3a-bb40-5771e6de00aa"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("e57b0fdf-ab7b-498b-964a-9e983526540b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("ff60d97f-a5fe-4585-a207-0b499a22a82c"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "TagId",
                keyValue: new Guid("6d89fe93-505b-4032-a51d-32278ff391bd"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "TagId",
                keyValue: new Guid("7236c9dc-d594-4f04-a7ea-442b9c7ce9f6"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: new Guid("1a5635e0-8a4d-4f11-879f-4c06bd69be8d"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: new Guid("60eea5da-f2cd-4fdc-b3f5-794894b1ab21"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: new Guid("61432ee8-c136-4459-b69c-c4957801355d"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "331564f6-3281-4a64-b903-feb3d97fe146");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "49003d27-37d3-4a86-93ce-5b2221318114");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "914f96f1-b243-4b96-a43c-c0043dff9715");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Orders_OrderId",
                table: "Products",
                column: "OrderId",
                principalTable: "Orders",
                principalColumn: "OrderId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
