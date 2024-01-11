using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace E_CommerceSystemV2.DAL.Migrations
{
    /// <inheritdoc />
    public partial class AddingSeeding : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CampaignCustomers",
                keyColumn: "Id",
                keyValue: new Guid("50dacaaf-093f-4260-aa72-712086df41b0"));

            migrationBuilder.DeleteData(
                table: "CampaignCustomers",
                keyColumn: "Id",
                keyValue: new Guid("b4f65567-55cb-4672-a903-ef8a5bb8269b"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("30ad1a3f-4476-493a-a1b0-c2b56366e3b9"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("44c7ef0f-8cbd-47a3-b077-d6c116a8394a"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("692dec8f-e9bd-420e-8513-f1132a1360fa"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("6e552106-ec11-45d4-b8db-8b0929b0d192"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("843191b0-7023-4e60-a532-be409f2240fd"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("a7b4a669-22d8-486c-9432-294e5c4f3c95"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("d34c7a34-4a51-4fd3-8c10-a5566cddb518"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("e56d3b03-105f-40da-9055-e3ba4dbbe954"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: new Guid("1ad6b2e4-6083-46c9-891c-be3d290710bd"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: new Guid("6cef3c2f-c313-47f4-8a43-7ca4eb5dd69f"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: new Guid("c304455e-ba11-44e2-9198-b290dec7a3ec"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: new Guid("dca411e5-f593-4feb-932e-846dac4bc9ec"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("1153a908-18f5-402d-bbce-a73b2a9ae894"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("5fa5e5c4-f93c-4cfa-bda0-e05dd1e04ff2"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("6c93eaba-60c7-4cd5-a3a9-a2a0b99e9c05"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("6f472250-bf50-44b0-ac91-289c27457755"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("81d28b43-fb4d-40c3-80fc-926b555887ed"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("c286eb51-c8d9-4049-bb96-0a8fda24e61e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("c3ceb045-4019-40c3-9a78-9275bc1f59ff"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("df5ccde3-d90d-4b31-a76d-66f09becb349"));

            migrationBuilder.DeleteData(
                table: "TagProducts",
                keyColumns: new[] { "ProductId", "TagId" },
                keyValues: new object[] { new Guid("1e13ad8e-34d9-47b7-ab91-ff1305b54a39"), new Guid("e38a559d-a6ec-4c8f-8545-e9aacbba0fe5") });

            migrationBuilder.DeleteData(
                table: "TagProducts",
                keyColumns: new[] { "ProductId", "TagId" },
                keyValues: new object[] { new Guid("8ed6a215-9304-4b34-9f03-15ec95acf7e0"), new Guid("e38a559d-a6ec-4c8f-8545-e9aacbba0fe5") });

            migrationBuilder.DeleteData(
                table: "TagProducts",
                keyColumns: new[] { "ProductId", "TagId" },
                keyValues: new object[] { new Guid("983a6355-b6dd-4b37-b912-40614853099e"), new Guid("97e104e5-8f88-4d77-8871-c1a42e6bebc4") });

            migrationBuilder.DeleteData(
                table: "TagProducts",
                keyColumns: new[] { "ProductId", "TagId" },
                keyValues: new object[] { new Guid("ab8caa48-4203-405f-9291-8e0a8c1b81ce"), new Guid("e38a559d-a6ec-4c8f-8545-e9aacbba0fe5") });

            migrationBuilder.DeleteData(
                table: "TagProducts",
                keyColumns: new[] { "ProductId", "TagId" },
                keyValues: new object[] { new Guid("ae721a5e-1aed-49ea-bbe5-b052532e9b5f"), new Guid("e38a559d-a6ec-4c8f-8545-e9aacbba0fe5") });

            migrationBuilder.DeleteData(
                table: "TagProducts",
                keyColumns: new[] { "ProductId", "TagId" },
                keyValues: new object[] { new Guid("cf9ee6d2-3d82-4f66-8092-d0fe941097de"), new Guid("e38a559d-a6ec-4c8f-8545-e9aacbba0fe5") });

            migrationBuilder.DeleteData(
                table: "TagProducts",
                keyColumns: new[] { "ProductId", "TagId" },
                keyValues: new object[] { new Guid("f95100c3-1026-4a22-aeea-91bbbd6a0f95"), new Guid("e38a559d-a6ec-4c8f-8545-e9aacbba0fe5") });

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "TagId",
                keyValue: new Guid("e8cbf26c-66e6-48a8-8326-3f2a775dedb0"));

            migrationBuilder.DeleteData(
                table: "Textsss",
                keyColumn: "Id",
                keyValue: new Guid("85d98fe6-8f34-466f-9326-e008ad4acf8b"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d2db1857-d4ea-4c1b-8c73-f6fa6affdfb1");

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: new Guid("36b50542-d788-44c9-8125-2913d89b0f9b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("1e13ad8e-34d9-47b7-ab91-ff1305b54a39"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("8ed6a215-9304-4b34-9f03-15ec95acf7e0"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("983a6355-b6dd-4b37-b912-40614853099e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("ab8caa48-4203-405f-9291-8e0a8c1b81ce"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("ae721a5e-1aed-49ea-bbe5-b052532e9b5f"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("cf9ee6d2-3d82-4f66-8092-d0fe941097de"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("f95100c3-1026-4a22-aeea-91bbbd6a0f95"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "TagId",
                keyValue: new Guid("97e104e5-8f88-4d77-8871-c1a42e6bebc4"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "TagId",
                keyValue: new Guid("e38a559d-a6ec-4c8f-8545-e9aacbba0fe5"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: new Guid("1254d8bf-ca94-405b-8e2d-07f7cb466cd0"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: new Guid("7ab3db9c-f063-43ee-8923-a96b462c23b3"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: new Guid("dc2eb7d0-e008-48f1-a171-5b9f03391526"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "45bb0a73-7ed7-4d4c-9b5b-10a2ff66180f");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4d70a68d-01db-4318-b23b-078714ced347");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7ecb5903-a3a8-4d6c-8bcf-bac712fd1d86");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "CreationDate", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "126f9b91-0660-4d35-b66e-c00893477c16", 0, "dd1ca627-e2c3-472d-b68d-a3e64e9a172a", new DateTime(2024, 1, 10, 8, 42, 30, 367, DateTimeKind.Local).AddTicks(17), "Sandy.Jakson@example.com", false, false, null, null, null, "password123", null, false, "ec0265b0-3a75-4e9a-8623-dc62a75eb36b", false, "Sandy Jakson" },
                    { "79889c8e-d151-44bf-92bc-e811a2b03cf8", 0, "2ca84058-a984-420b-bd95-2db5d7dc4256", new DateTime(2024, 1, 10, 8, 42, 30, 366, DateTimeKind.Local).AddTicks(9938), "john.doe@example.com", false, false, null, null, null, "password123", null, false, "ab9ef759-c6b9-43a1-a07b-f6a32b01ba82", false, "john doe" },
                    { "9797bc68-71b8-49de-aa9d-1953616f2366", 0, "e7933f18-085e-4120-9049-e9b20aa241e0", new DateTime(2024, 1, 10, 8, 42, 30, 366, DateTimeKind.Local).AddTicks(9996), "Sara.doe@example.com", false, false, null, null, null, "password123", null, false, "3e4f878f-ca7d-4326-bf9f-5b98d1218df1", false, "Sara doe" },
                    { "ecce009f-c6b2-48ef-bf80-99363d4cd53a", 0, "031587d4-f431-4a45-8425-ca3cec400a5d", new DateTime(2024, 1, 10, 8, 42, 30, 366, DateTimeKind.Local).AddTicks(9964), "jane.doe@example.com", false, false, null, null, null, "password123", null, false, "54388261-c387-4e4b-a2ac-89b98efec038", false, "jane doe" }
                });

            migrationBuilder.InsertData(
                table: "CampaignCustomers",
                columns: new[] { "Id", "Email", "Name" },
                values: new object[,]
                {
                    { new Guid("777c6bd7-29d8-4a00-92d0-cbf34460e860"), "Jamal_Ali@outlook.com", "Jamal" },
                    { new Guid("7e7154a6-3183-42fb-8911-a572316731cf"), "marwaghonem29@gmail.com", "Marwa" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "Name" },
                values: new object[,]
                {
                    { new Guid("3c9734be-cf73-42c9-bfd4-0396e89fe6f8"), "Appliances" },
                    { new Guid("4428caba-e423-4438-9c10-096ef781e58f"), "Fashion" },
                    { new Guid("6eb52884-9be7-497d-8dfe-ce8275963d65"), "Mobiles" },
                    { new Guid("78747418-3cde-421c-a789-8ed80ad1b7d5"), "Electronics" },
                    { new Guid("8319c5a3-a526-41a9-b527-6c7ad7e94aa7"), "Gaming" },
                    { new Guid("876a50b5-ebc1-4be6-88dd-3dc7f70d748a"), "SmartDevices" },
                    { new Guid("e6d518b7-72ee-49d7-9500-0b9ebee8443e"), "Clothing" },
                    { new Guid("ebb9e988-5ab1-4b26-867e-d440a8ae996e"), "Tablets" }
                });

            migrationBuilder.InsertData(
                table: "Tags",
                columns: new[] { "TagId", "Name" },
                values: new object[,]
                {
                    { new Guid("363c132c-1c56-4cf7-bc2a-2bd681c6be51"), "FlagShip Mobiles" },
                    { new Guid("b6109b6d-bcfc-45c6-b35c-cab9079f5637"), "Fashion 2024" },
                    { new Guid("e88056e3-0b4b-44b4-87b5-b52f4d46556f"), "Tech" }
                });

            migrationBuilder.InsertData(
                table: "Textsss",
                columns: new[] { "Id", "ArabicText", "EnglishText", "TextKey" },
                values: new object[,]
                {
                    { new Guid("1181958f-63fd-4172-9f08-65e6892aed56"), "مرحبا", "Welcome", "WelcomeMessage" },
                    { new Guid("c3d4261a-0f29-4f18-8e14-d2357e0cfe10"), "مرحبا {0} كلمة المرور الخاصة بك هي {1}", "Hello {0}, your Password Is {1}.", "PasswordRetrievalMessage" }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "OrderId", "OrderDate", "UserId" },
                values: new object[,]
                {
                    { new Guid("0023148a-a3b6-4903-b73a-7fd3be268cb8"), new DateTime(2024, 1, 10, 8, 42, 30, 367, DateTimeKind.Local).AddTicks(73), "ecce009f-c6b2-48ef-bf80-99363d4cd53a" },
                    { new Guid("1cb44ee7-6105-418d-8ce9-189c2d053416"), new DateTime(2024, 1, 10, 8, 42, 30, 367, DateTimeKind.Local).AddTicks(102), "126f9b91-0660-4d35-b66e-c00893477c16" },
                    { new Guid("3b80e265-ef3b-4bd5-addc-b2a3627d980b"), new DateTime(2024, 1, 10, 8, 42, 30, 367, DateTimeKind.Local).AddTicks(117), "ecce009f-c6b2-48ef-bf80-99363d4cd53a" },
                    { new Guid("6e068562-f13e-47f9-9639-f8b250dc61ef"), new DateTime(2024, 1, 10, 8, 42, 30, 367, DateTimeKind.Local).AddTicks(52), "ecce009f-c6b2-48ef-bf80-99363d4cd53a" },
                    { new Guid("ad6bd523-a194-4235-892e-62f765cb51b2"), new DateTime(2024, 1, 10, 8, 42, 30, 367, DateTimeKind.Local).AddTicks(32), "ecce009f-c6b2-48ef-bf80-99363d4cd53a" },
                    { new Guid("c1aa224f-7262-4e72-a3c7-efb58bd0b1dc"), new DateTime(2024, 1, 10, 8, 42, 30, 367, DateTimeKind.Local).AddTicks(110), "9797bc68-71b8-49de-aa9d-1953616f2366" },
                    { new Guid("d1f887eb-70bf-4f71-aeea-d667ae6eb566"), new DateTime(2024, 1, 10, 8, 42, 30, 367, DateTimeKind.Local).AddTicks(68), "9797bc68-71b8-49de-aa9d-1953616f2366" },
                    { new Guid("e7e89f06-a384-4df6-9466-5d33a5dcbea3"), new DateTime(2024, 1, 10, 8, 42, 30, 367, DateTimeKind.Local).AddTicks(45), "79889c8e-d151-44bf-92bc-e811a2b03cf8" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "CategoryId", "CategoryType", "Name", "OrderId", "Price", "TagId" },
                values: new object[,]
                {
                    { new Guid("069fa4b5-df42-450a-b5c0-81f227340814"), null, 3, "Fossil Smartwatch", new Guid("ad6bd523-a194-4235-892e-62f765cb51b2"), 149.99m, null },
                    { new Guid("3a8bc47f-fe1f-44a4-8adc-4398a06622ae"), null, 1, "HP Printer", new Guid("e7e89f06-a384-4df6-9466-5d33a5dcbea3"), 149.99m, null },
                    { new Guid("54ac2598-5c9b-4d7c-a457-6964e22f24c6"), null, 4, "KitchenAid Stand Mixer", new Guid("d1f887eb-70bf-4f71-aeea-d667ae6eb566"), 349.99m, null },
                    { new Guid("5b843000-0c07-4bed-8c88-b6b3715ee759"), null, 2, "Samsung Galaxy S21", new Guid("ad6bd523-a194-4235-892e-62f765cb51b2"), 799.99m, null },
                    { new Guid("6929afd3-c996-42ac-84fb-82c0c0bf943e"), null, 6, "Razer Gaming Mouse", new Guid("e7e89f06-a384-4df6-9466-5d33a5dcbea3"), 69.99m, null },
                    { new Guid("97477696-21db-4a8b-9d24-15f46ec71cc9"), null, 3, "Adidas Running Shoes", new Guid("6e068562-f13e-47f9-9639-f8b250dc61ef"), 109.99m, null },
                    { new Guid("a107453b-7703-4f67-ab62-a94776e458bc"), null, 4, "Cuisinart Coffee Maker", new Guid("ad6bd523-a194-4235-892e-62f765cb51b2"), 79.99m, null },
                    { new Guid("a32ef41f-0745-4b0b-bd78-e9a813c80626"), null, 1, "Sony Smart TV", new Guid("e7e89f06-a384-4df6-9466-5d33a5dcbea3"), 1299.99m, null },
                    { new Guid("bda98f8a-6444-4a75-86b1-cfdb0a34d332"), null, 1, "Canon EOS Rebel T7", new Guid("6e068562-f13e-47f9-9639-f8b250dc61ef"), 499.99m, null },
                    { new Guid("cdf3295b-3d9e-4395-b41b-281d6ac6d691"), null, 6, "Fitbit Charge 5", new Guid("e7e89f06-a384-4df6-9466-5d33a5dcbea3"), 149.99m, null },
                    { new Guid("d494c082-4db3-4550-8279-431a50a4923c"), null, 3, "Calvin Klein Watch", new Guid("e7e89f06-a384-4df6-9466-5d33a5dcbea3"), 199.99m, null },
                    { new Guid("dea0d956-c9d2-490f-9048-4bf9f7e00e3b"), null, 3, "Nike Running Shoes", new Guid("e7e89f06-a384-4df6-9466-5d33a5dcbea3"), 89.99m, null },
                    { new Guid("f2845201-7964-4b21-b7c0-0828f37358c4"), null, 1, "Bose Noise-Canceling Headphones", new Guid("e7e89f06-a384-4df6-9466-5d33a5dcbea3"), 299.99m, null },
                    { new Guid("f40c0dcc-5003-4b80-ad3e-ba3f10e2c8df"), null, 5, "Amazon Echo Dot", new Guid("e7e89f06-a384-4df6-9466-5d33a5dcbea3"), 39.99m, null },
                    { new Guid("fbce8595-093d-41d2-8a23-da7907cee36d"), null, 3, "Levi's Jeans", new Guid("e7e89f06-a384-4df6-9466-5d33a5dcbea3"), 59.99m, null }
                });

            migrationBuilder.InsertData(
                table: "TagProducts",
                columns: new[] { "ProductId", "TagId" },
                values: new object[,]
                {
                    { new Guid("3a8bc47f-fe1f-44a4-8adc-4398a06622ae"), new Guid("e88056e3-0b4b-44b4-87b5-b52f4d46556f") },
                    { new Guid("54ac2598-5c9b-4d7c-a457-6964e22f24c6"), new Guid("e88056e3-0b4b-44b4-87b5-b52f4d46556f") },
                    { new Guid("a32ef41f-0745-4b0b-bd78-e9a813c80626"), new Guid("363c132c-1c56-4cf7-bc2a-2bd681c6be51") },
                    { new Guid("bda98f8a-6444-4a75-86b1-cfdb0a34d332"), new Guid("e88056e3-0b4b-44b4-87b5-b52f4d46556f") },
                    { new Guid("dea0d956-c9d2-490f-9048-4bf9f7e00e3b"), new Guid("e88056e3-0b4b-44b4-87b5-b52f4d46556f") },
                    { new Guid("f2845201-7964-4b21-b7c0-0828f37358c4"), new Guid("e88056e3-0b4b-44b4-87b5-b52f4d46556f") },
                    { new Guid("fbce8595-093d-41d2-8a23-da7907cee36d"), new Guid("e88056e3-0b4b-44b4-87b5-b52f4d46556f") }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CampaignCustomers",
                keyColumn: "Id",
                keyValue: new Guid("777c6bd7-29d8-4a00-92d0-cbf34460e860"));

            migrationBuilder.DeleteData(
                table: "CampaignCustomers",
                keyColumn: "Id",
                keyValue: new Guid("7e7154a6-3183-42fb-8911-a572316731cf"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("3c9734be-cf73-42c9-bfd4-0396e89fe6f8"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("4428caba-e423-4438-9c10-096ef781e58f"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("6eb52884-9be7-497d-8dfe-ce8275963d65"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("78747418-3cde-421c-a789-8ed80ad1b7d5"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("8319c5a3-a526-41a9-b527-6c7ad7e94aa7"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("876a50b5-ebc1-4be6-88dd-3dc7f70d748a"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("e6d518b7-72ee-49d7-9500-0b9ebee8443e"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("ebb9e988-5ab1-4b26-867e-d440a8ae996e"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: new Guid("0023148a-a3b6-4903-b73a-7fd3be268cb8"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: new Guid("1cb44ee7-6105-418d-8ce9-189c2d053416"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: new Guid("3b80e265-ef3b-4bd5-addc-b2a3627d980b"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: new Guid("c1aa224f-7262-4e72-a3c7-efb58bd0b1dc"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("069fa4b5-df42-450a-b5c0-81f227340814"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("5b843000-0c07-4bed-8c88-b6b3715ee759"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("6929afd3-c996-42ac-84fb-82c0c0bf943e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("97477696-21db-4a8b-9d24-15f46ec71cc9"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("a107453b-7703-4f67-ab62-a94776e458bc"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("cdf3295b-3d9e-4395-b41b-281d6ac6d691"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("d494c082-4db3-4550-8279-431a50a4923c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("f40c0dcc-5003-4b80-ad3e-ba3f10e2c8df"));

            migrationBuilder.DeleteData(
                table: "TagProducts",
                keyColumns: new[] { "ProductId", "TagId" },
                keyValues: new object[] { new Guid("3a8bc47f-fe1f-44a4-8adc-4398a06622ae"), new Guid("e88056e3-0b4b-44b4-87b5-b52f4d46556f") });

            migrationBuilder.DeleteData(
                table: "TagProducts",
                keyColumns: new[] { "ProductId", "TagId" },
                keyValues: new object[] { new Guid("54ac2598-5c9b-4d7c-a457-6964e22f24c6"), new Guid("e88056e3-0b4b-44b4-87b5-b52f4d46556f") });

            migrationBuilder.DeleteData(
                table: "TagProducts",
                keyColumns: new[] { "ProductId", "TagId" },
                keyValues: new object[] { new Guid("a32ef41f-0745-4b0b-bd78-e9a813c80626"), new Guid("363c132c-1c56-4cf7-bc2a-2bd681c6be51") });

            migrationBuilder.DeleteData(
                table: "TagProducts",
                keyColumns: new[] { "ProductId", "TagId" },
                keyValues: new object[] { new Guid("bda98f8a-6444-4a75-86b1-cfdb0a34d332"), new Guid("e88056e3-0b4b-44b4-87b5-b52f4d46556f") });

            migrationBuilder.DeleteData(
                table: "TagProducts",
                keyColumns: new[] { "ProductId", "TagId" },
                keyValues: new object[] { new Guid("dea0d956-c9d2-490f-9048-4bf9f7e00e3b"), new Guid("e88056e3-0b4b-44b4-87b5-b52f4d46556f") });

            migrationBuilder.DeleteData(
                table: "TagProducts",
                keyColumns: new[] { "ProductId", "TagId" },
                keyValues: new object[] { new Guid("f2845201-7964-4b21-b7c0-0828f37358c4"), new Guid("e88056e3-0b4b-44b4-87b5-b52f4d46556f") });

            migrationBuilder.DeleteData(
                table: "TagProducts",
                keyColumns: new[] { "ProductId", "TagId" },
                keyValues: new object[] { new Guid("fbce8595-093d-41d2-8a23-da7907cee36d"), new Guid("e88056e3-0b4b-44b4-87b5-b52f4d46556f") });

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "TagId",
                keyValue: new Guid("b6109b6d-bcfc-45c6-b35c-cab9079f5637"));

            migrationBuilder.DeleteData(
                table: "Textsss",
                keyColumn: "Id",
                keyValue: new Guid("1181958f-63fd-4172-9f08-65e6892aed56"));

            migrationBuilder.DeleteData(
                table: "Textsss",
                keyColumn: "Id",
                keyValue: new Guid("c3d4261a-0f29-4f18-8e14-d2357e0cfe10"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "126f9b91-0660-4d35-b66e-c00893477c16");

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: new Guid("ad6bd523-a194-4235-892e-62f765cb51b2"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("3a8bc47f-fe1f-44a4-8adc-4398a06622ae"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("54ac2598-5c9b-4d7c-a457-6964e22f24c6"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("a32ef41f-0745-4b0b-bd78-e9a813c80626"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("bda98f8a-6444-4a75-86b1-cfdb0a34d332"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("dea0d956-c9d2-490f-9048-4bf9f7e00e3b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("f2845201-7964-4b21-b7c0-0828f37358c4"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("fbce8595-093d-41d2-8a23-da7907cee36d"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "TagId",
                keyValue: new Guid("363c132c-1c56-4cf7-bc2a-2bd681c6be51"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "TagId",
                keyValue: new Guid("e88056e3-0b4b-44b4-87b5-b52f4d46556f"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: new Guid("6e068562-f13e-47f9-9639-f8b250dc61ef"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: new Guid("d1f887eb-70bf-4f71-aeea-d667ae6eb566"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: new Guid("e7e89f06-a384-4df6-9466-5d33a5dcbea3"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "79889c8e-d151-44bf-92bc-e811a2b03cf8");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9797bc68-71b8-49de-aa9d-1953616f2366");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ecce009f-c6b2-48ef-bf80-99363d4cd53a");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "CreationDate", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "45bb0a73-7ed7-4d4c-9b5b-10a2ff66180f", 0, "56998682-5f04-41ed-bac4-9bc7ba620957", new DateTime(2024, 1, 5, 15, 19, 18, 836, DateTimeKind.Local).AddTicks(4790), "Sara.doe@example.com", false, false, null, null, null, "password123", null, false, "37721efa-3ce7-4328-b46e-97da54848926", false, "Sara doe" },
                    { "4d70a68d-01db-4318-b23b-078714ced347", 0, "ba224085-322c-44ec-9e47-8f4d50bde428", new DateTime(2024, 1, 5, 15, 19, 18, 836, DateTimeKind.Local).AddTicks(4773), "jane.doe@example.com", false, false, null, null, null, "password123", null, false, "b0f83cac-0838-4636-8df9-6ca8a73a42b9", false, "jane doe" },
                    { "7ecb5903-a3a8-4d6c-8bcf-bac712fd1d86", 0, "97edc9d4-c5c2-4290-b4de-709cbd118051", new DateTime(2024, 1, 5, 15, 19, 18, 836, DateTimeKind.Local).AddTicks(4746), "john.doe@example.com", false, false, null, null, null, "password123", null, false, "4fe27054-3661-44d8-b7d8-0afcedaec787", false, "john doe" },
                    { "d2db1857-d4ea-4c1b-8c73-f6fa6affdfb1", 0, "4ff0797f-432b-4248-8d2f-6b9edbf4a0fb", new DateTime(2024, 1, 5, 15, 19, 18, 836, DateTimeKind.Local).AddTicks(4814), "Sandy.Jakson@example.com", false, false, null, null, null, "password123", null, false, "98d95edf-558e-4f3e-aa14-78fc3d5476ed", false, "Sandy Jakson" }
                });

            migrationBuilder.InsertData(
                table: "CampaignCustomers",
                columns: new[] { "Id", "Email", "Name" },
                values: new object[,]
                {
                    { new Guid("50dacaaf-093f-4260-aa72-712086df41b0"), "marwaghonem29@gmail.com", "Marwa" },
                    { new Guid("b4f65567-55cb-4672-a903-ef8a5bb8269b"), "Jamal_Ali@outlook.com", "Jamal" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "Name" },
                values: new object[,]
                {
                    { new Guid("30ad1a3f-4476-493a-a1b0-c2b56366e3b9"), "Tablets" },
                    { new Guid("44c7ef0f-8cbd-47a3-b077-d6c116a8394a"), "Electronics" },
                    { new Guid("692dec8f-e9bd-420e-8513-f1132a1360fa"), "Fashion" },
                    { new Guid("6e552106-ec11-45d4-b8db-8b0929b0d192"), "SmartDevices" },
                    { new Guid("843191b0-7023-4e60-a532-be409f2240fd"), "Clothing" },
                    { new Guid("a7b4a669-22d8-486c-9432-294e5c4f3c95"), "Appliances" },
                    { new Guid("d34c7a34-4a51-4fd3-8c10-a5566cddb518"), "Mobiles" },
                    { new Guid("e56d3b03-105f-40da-9055-e3ba4dbbe954"), "Gaming" }
                });

            migrationBuilder.InsertData(
                table: "Tags",
                columns: new[] { "TagId", "Name" },
                values: new object[,]
                {
                    { new Guid("97e104e5-8f88-4d77-8871-c1a42e6bebc4"), "FlagShip Mobiles" },
                    { new Guid("e38a559d-a6ec-4c8f-8545-e9aacbba0fe5"), "Tech" },
                    { new Guid("e8cbf26c-66e6-48a8-8326-3f2a775dedb0"), "Fashion 2024" }
                });

            migrationBuilder.InsertData(
                table: "Textsss",
                columns: new[] { "Id", "ArabicText", "EnglishText", "TextKey" },
                values: new object[] { new Guid("85d98fe6-8f34-466f-9326-e008ad4acf8b"), "مرحبا", "Welcome", "WelcomeMessage" });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "OrderId", "OrderDate", "UserId" },
                values: new object[,]
                {
                    { new Guid("1254d8bf-ca94-405b-8e2d-07f7cb466cd0"), new DateTime(2024, 1, 5, 15, 19, 18, 836, DateTimeKind.Local).AddTicks(4920), "45bb0a73-7ed7-4d4c-9b5b-10a2ff66180f" },
                    { new Guid("1ad6b2e4-6083-46c9-891c-be3d290710bd"), new DateTime(2024, 1, 5, 15, 19, 18, 836, DateTimeKind.Local).AddTicks(4950), "45bb0a73-7ed7-4d4c-9b5b-10a2ff66180f" },
                    { new Guid("36b50542-d788-44c9-8125-2913d89b0f9b"), new DateTime(2024, 1, 5, 15, 19, 18, 836, DateTimeKind.Local).AddTicks(4895), "4d70a68d-01db-4318-b23b-078714ced347" },
                    { new Guid("6cef3c2f-c313-47f4-8a43-7ca4eb5dd69f"), new DateTime(2024, 1, 5, 15, 19, 18, 836, DateTimeKind.Local).AddTicks(4958), "4d70a68d-01db-4318-b23b-078714ced347" },
                    { new Guid("7ab3db9c-f063-43ee-8923-a96b462c23b3"), new DateTime(2024, 1, 5, 15, 19, 18, 836, DateTimeKind.Local).AddTicks(4906), "7ecb5903-a3a8-4d6c-8bcf-bac712fd1d86" },
                    { new Guid("c304455e-ba11-44e2-9198-b290dec7a3ec"), new DateTime(2024, 1, 5, 15, 19, 18, 836, DateTimeKind.Local).AddTicks(4943), "d2db1857-d4ea-4c1b-8c73-f6fa6affdfb1" },
                    { new Guid("dc2eb7d0-e008-48f1-a171-5b9f03391526"), new DateTime(2024, 1, 5, 15, 19, 18, 836, DateTimeKind.Local).AddTicks(4913), "4d70a68d-01db-4318-b23b-078714ced347" },
                    { new Guid("dca411e5-f593-4feb-932e-846dac4bc9ec"), new DateTime(2024, 1, 5, 15, 19, 18, 836, DateTimeKind.Local).AddTicks(4927), "4d70a68d-01db-4318-b23b-078714ced347" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "CategoryId", "CategoryType", "Name", "OrderId", "Price", "TagId" },
                values: new object[,]
                {
                    { new Guid("1153a908-18f5-402d-bbce-a73b2a9ae894"), null, 3, "Calvin Klein Watch", new Guid("7ab3db9c-f063-43ee-8923-a96b462c23b3"), 199.99m, null },
                    { new Guid("1e13ad8e-34d9-47b7-ab91-ff1305b54a39"), null, 4, "KitchenAid Stand Mixer", new Guid("1254d8bf-ca94-405b-8e2d-07f7cb466cd0"), 349.99m, null },
                    { new Guid("5fa5e5c4-f93c-4cfa-bda0-e05dd1e04ff2"), null, 3, "Adidas Running Shoes", new Guid("dc2eb7d0-e008-48f1-a171-5b9f03391526"), 109.99m, null },
                    { new Guid("6c93eaba-60c7-4cd5-a3a9-a2a0b99e9c05"), null, 3, "Fossil Smartwatch", new Guid("36b50542-d788-44c9-8125-2913d89b0f9b"), 149.99m, null },
                    { new Guid("6f472250-bf50-44b0-ac91-289c27457755"), null, 2, "Samsung Galaxy S21", new Guid("36b50542-d788-44c9-8125-2913d89b0f9b"), 799.99m, null },
                    { new Guid("81d28b43-fb4d-40c3-80fc-926b555887ed"), null, 4, "Cuisinart Coffee Maker", new Guid("36b50542-d788-44c9-8125-2913d89b0f9b"), 79.99m, null },
                    { new Guid("8ed6a215-9304-4b34-9f03-15ec95acf7e0"), null, 3, "Levi's Jeans", new Guid("7ab3db9c-f063-43ee-8923-a96b462c23b3"), 59.99m, null },
                    { new Guid("983a6355-b6dd-4b37-b912-40614853099e"), null, 1, "Sony Smart TV", new Guid("7ab3db9c-f063-43ee-8923-a96b462c23b3"), 1299.99m, null },
                    { new Guid("ab8caa48-4203-405f-9291-8e0a8c1b81ce"), null, 1, "Canon EOS Rebel T7", new Guid("dc2eb7d0-e008-48f1-a171-5b9f03391526"), 499.99m, null },
                    { new Guid("ae721a5e-1aed-49ea-bbe5-b052532e9b5f"), null, 1, "Bose Noise-Canceling Headphones", new Guid("7ab3db9c-f063-43ee-8923-a96b462c23b3"), 299.99m, null },
                    { new Guid("c286eb51-c8d9-4049-bb96-0a8fda24e61e"), null, 6, "Razer Gaming Mouse", new Guid("7ab3db9c-f063-43ee-8923-a96b462c23b3"), 69.99m, null },
                    { new Guid("c3ceb045-4019-40c3-9a78-9275bc1f59ff"), null, 5, "Amazon Echo Dot", new Guid("7ab3db9c-f063-43ee-8923-a96b462c23b3"), 39.99m, null },
                    { new Guid("cf9ee6d2-3d82-4f66-8092-d0fe941097de"), null, 3, "Nike Running Shoes", new Guid("7ab3db9c-f063-43ee-8923-a96b462c23b3"), 89.99m, null },
                    { new Guid("df5ccde3-d90d-4b31-a76d-66f09becb349"), null, 6, "Fitbit Charge 5", new Guid("7ab3db9c-f063-43ee-8923-a96b462c23b3"), 149.99m, null },
                    { new Guid("f95100c3-1026-4a22-aeea-91bbbd6a0f95"), null, 1, "HP Printer", new Guid("7ab3db9c-f063-43ee-8923-a96b462c23b3"), 149.99m, null }
                });

            migrationBuilder.InsertData(
                table: "TagProducts",
                columns: new[] { "ProductId", "TagId" },
                values: new object[,]
                {
                    { new Guid("1e13ad8e-34d9-47b7-ab91-ff1305b54a39"), new Guid("e38a559d-a6ec-4c8f-8545-e9aacbba0fe5") },
                    { new Guid("8ed6a215-9304-4b34-9f03-15ec95acf7e0"), new Guid("e38a559d-a6ec-4c8f-8545-e9aacbba0fe5") },
                    { new Guid("983a6355-b6dd-4b37-b912-40614853099e"), new Guid("97e104e5-8f88-4d77-8871-c1a42e6bebc4") },
                    { new Guid("ab8caa48-4203-405f-9291-8e0a8c1b81ce"), new Guid("e38a559d-a6ec-4c8f-8545-e9aacbba0fe5") },
                    { new Guid("ae721a5e-1aed-49ea-bbe5-b052532e9b5f"), new Guid("e38a559d-a6ec-4c8f-8545-e9aacbba0fe5") },
                    { new Guid("cf9ee6d2-3d82-4f66-8092-d0fe941097de"), new Guid("e38a559d-a6ec-4c8f-8545-e9aacbba0fe5") },
                    { new Guid("f95100c3-1026-4a22-aeea-91bbbd6a0f95"), new Guid("e38a559d-a6ec-4c8f-8545-e9aacbba0fe5") }
                });
        }
    }
}
