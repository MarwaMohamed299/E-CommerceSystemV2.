using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace E_CommerceSystemV2.DAL.Migrations
{
    /// <inheritdoc />
    public partial class AddingTest : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.CreateTable(
                name: "Test",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TextKey = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EnglishText = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ArabicText = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Test", x => x.Id);
                });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Test");

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
        }
    }
}
