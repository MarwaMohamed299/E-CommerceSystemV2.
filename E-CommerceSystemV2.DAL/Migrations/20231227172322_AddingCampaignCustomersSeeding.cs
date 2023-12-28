using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace E_CommerceSystemV2.DAL.Migrations
{
    /// <inheritdoc />
    public partial class AddingCampaignCustomersSeeding : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("28280a96-f2e8-41b8-9105-871030a88892"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("2cfb589a-7d17-446a-9b5d-0102c4a8105b"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("652c0564-99c4-46a6-80ef-ec1e46505617"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("847da3ec-7920-4717-b340-9d42e9768866"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("99ce44f7-aa4b-45db-ae00-f594c6a1015b"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("bccd5635-cd23-42dd-aad8-89536fc60da4"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("d0980572-7070-4166-badc-e84cba75beaf"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("dcaefc59-ed9f-43ad-8bdc-a7278fc1d90e"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: new Guid("18371255-84f5-4b35-a9df-47c09ac8a5e1"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: new Guid("34057720-f9c6-41f6-a6c8-73c57b566317"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: new Guid("6889c2c3-a9bf-47b7-bf40-64a3ef0fac91"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: new Guid("cb0a6c9a-b074-4665-95f5-f6d95ef51f1d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("12ab3925-dc14-4a9a-ace4-efb56e038942"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("18bf1839-4e71-419b-81db-6f0ab0298956"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("3b1b2bb8-2cfa-4bb2-937b-850683637f44"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("b915f98b-9250-4c20-b043-a06d90bc4f7e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("cba94cbd-c55e-44f0-925e-b76e093c25c0"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("d76a9078-b0a5-4a5f-8f67-a898aad2feb8"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("ec1b630a-8c60-477f-8c95-bacbfec2518e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("f06074dc-4eb2-4aba-aa56-b4bd28b10908"));

            migrationBuilder.DeleteData(
                table: "TagProducts",
                keyColumns: new[] { "ProductId", "TagId" },
                keyValues: new object[] { new Guid("10b1fa31-cad6-4bda-aa53-f3e86cebc4d5"), new Guid("fdae1f84-b417-420f-a275-5438de4fe8ec") });

            migrationBuilder.DeleteData(
                table: "TagProducts",
                keyColumns: new[] { "ProductId", "TagId" },
                keyValues: new object[] { new Guid("2e5c100c-72cc-485c-a702-8c85b04ad2f2"), new Guid("19439fe2-b120-4923-8a89-24b47b790d6f") });

            migrationBuilder.DeleteData(
                table: "TagProducts",
                keyColumns: new[] { "ProductId", "TagId" },
                keyValues: new object[] { new Guid("b2d8d64d-f203-4577-9f4d-239ae6164842"), new Guid("fdae1f84-b417-420f-a275-5438de4fe8ec") });

            migrationBuilder.DeleteData(
                table: "TagProducts",
                keyColumns: new[] { "ProductId", "TagId" },
                keyValues: new object[] { new Guid("b5bd6d48-cb31-4269-8f35-8fc6da0adc7e"), new Guid("fdae1f84-b417-420f-a275-5438de4fe8ec") });

            migrationBuilder.DeleteData(
                table: "TagProducts",
                keyColumns: new[] { "ProductId", "TagId" },
                keyValues: new object[] { new Guid("db2ef700-401a-4b91-b6ed-3cf234f91ade"), new Guid("fdae1f84-b417-420f-a275-5438de4fe8ec") });

            migrationBuilder.DeleteData(
                table: "TagProducts",
                keyColumns: new[] { "ProductId", "TagId" },
                keyValues: new object[] { new Guid("eb58dbe8-4d10-4c33-8816-f3ec4f7f39d4"), new Guid("fdae1f84-b417-420f-a275-5438de4fe8ec") });

            migrationBuilder.DeleteData(
                table: "TagProducts",
                keyColumns: new[] { "ProductId", "TagId" },
                keyValues: new object[] { new Guid("f23d8d74-7264-4ae8-9dec-78946e7809ac"), new Guid("fdae1f84-b417-420f-a275-5438de4fe8ec") });

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "TagId",
                keyValue: new Guid("318e4a94-026e-4834-8974-6950eb887e6b"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "76034889-5c66-4785-bdc2-8a0d18644f7f");

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: new Guid("5a5b3e05-0618-4a5a-a2fd-4af296933a48"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("10b1fa31-cad6-4bda-aa53-f3e86cebc4d5"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("2e5c100c-72cc-485c-a702-8c85b04ad2f2"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("b2d8d64d-f203-4577-9f4d-239ae6164842"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("b5bd6d48-cb31-4269-8f35-8fc6da0adc7e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("db2ef700-401a-4b91-b6ed-3cf234f91ade"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("eb58dbe8-4d10-4c33-8816-f3ec4f7f39d4"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("f23d8d74-7264-4ae8-9dec-78946e7809ac"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "TagId",
                keyValue: new Guid("19439fe2-b120-4923-8a89-24b47b790d6f"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "TagId",
                keyValue: new Guid("fdae1f84-b417-420f-a275-5438de4fe8ec"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: new Guid("43923a75-be2d-4ee8-af79-919a3c402805"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: new Guid("5e89a538-2c6a-47ce-ae56-fe1328da3819"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: new Guid("f3a5e79b-00bc-4e46-abfc-ff8f72a42c38"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "14258c70-cad6-4a55-8327-a9fa0bee6682");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a14a27cd-493f-47ca-bced-e3adb51cf376");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ffd6b2bb-e580-4609-b00d-b54ee95e1ee7");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "CreationDate", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "4c16ac30-078f-450c-abcb-75d434cb5e83", 0, "2acfe452-7a6c-484b-b682-34a007df0b01", new DateTime(2023, 12, 27, 20, 23, 21, 638, DateTimeKind.Local).AddTicks(561), "jane.doe@example.com", false, false, null, null, null, "password123", null, false, "c28e42dc-59e6-417d-bda8-25560bf5df8e", false, "jane doe" },
                    { "6caab355-b595-4915-9432-4aa53e2d3eb1", 0, "38f20a04-991f-4f66-8a5d-92b0a961c1f6", new DateTime(2023, 12, 27, 20, 23, 21, 638, DateTimeKind.Local).AddTicks(599), "Sara.doe@example.com", false, false, null, null, null, "password123", null, false, "f96c5044-afef-4719-80f4-bb724641dd74", false, "Sara doe" },
                    { "74321f15-29aa-4057-ba32-e9243bc47560", 0, "473fcff2-3fb2-41e5-9f5c-5954e8d8717d", new DateTime(2023, 12, 27, 20, 23, 21, 638, DateTimeKind.Local).AddTicks(613), "Sandy.Jakson@example.com", false, false, null, null, null, "password123", null, false, "a88aa63a-27b0-4035-8bb8-d08ea0c8345b", false, "Sandy Jakson" },
                    { "7d66e6e8-9fd9-4375-bd6f-83f0e4f9e792", 0, "c2c4e98b-0d0e-4bb6-b0d9-3420b02a883d", new DateTime(2023, 12, 27, 20, 23, 21, 638, DateTimeKind.Local).AddTicks(533), "john.doe@example.com", false, false, null, null, null, "password123", null, false, "ec38523c-9c27-4ce0-a6d6-a8fcf0a13773", false, "john doe" }
                });

            migrationBuilder.InsertData(
                table: "CampaignCustomers",
                columns: new[] { "Id", "Email", "Name" },
                values: new object[,]
                {
                    { new Guid("349b906f-8f29-4412-a594-4796edd397bf"), "Jamal_Ali@outlook.com", "Jamal" },
                    { new Guid("9f3d448e-9734-4d59-a780-e63ade3600e7"), "marwaghonem29@gmail.com", "Marwa" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "Name" },
                values: new object[,]
                {
                    { new Guid("19c1f306-3959-472e-865c-5ed14b24d2df"), "Gaming" },
                    { new Guid("29bfa61d-84eb-4c61-ae2e-0d5a68286042"), "Clothing" },
                    { new Guid("673cc6f5-7784-4cd0-ac93-fd79bb6742e2"), "Tablets" },
                    { new Guid("821920b1-0f52-4035-bf04-b7fb05659252"), "SmartDevices" },
                    { new Guid("c6b3d01c-c24a-43d5-927f-10810e131c7f"), "Electronics" },
                    { new Guid("efe957dc-252d-49e9-b1a0-f65c3a181388"), "Mobiles" },
                    { new Guid("f0ed63d2-39c5-44ff-9322-8d0817b9a050"), "Appliances" },
                    { new Guid("f5dbea74-8d31-4825-87c6-63bb4b4e8dc5"), "Fashion" }
                });

            migrationBuilder.InsertData(
                table: "Tags",
                columns: new[] { "TagId", "Name" },
                values: new object[,]
                {
                    { new Guid("87a7a403-675e-4d5c-81dc-06c886571428"), "Fashion 2024" },
                    { new Guid("925ee134-dbfb-4da2-9344-995e988190be"), "FlagShip Mobiles" },
                    { new Guid("bdf4dbb3-2547-44d9-8b1b-aad90df928e3"), "Tech" }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "OrderId", "OrderDate", "UserId" },
                values: new object[,]
                {
                    { new Guid("05dfada3-f0af-4155-a517-ce80bcc0dc67"), new DateTime(2023, 12, 27, 20, 23, 21, 638, DateTimeKind.Local).AddTicks(634), "4c16ac30-078f-450c-abcb-75d434cb5e83" },
                    { new Guid("23b4a2b6-927d-40cd-b2e9-31d97a298f26"), new DateTime(2023, 12, 27, 20, 23, 21, 638, DateTimeKind.Local).AddTicks(658), "74321f15-29aa-4057-ba32-e9243bc47560" },
                    { new Guid("28d31885-acbd-4704-bd43-3701a7ebf62d"), new DateTime(2023, 12, 27, 20, 23, 21, 638, DateTimeKind.Local).AddTicks(669), "4c16ac30-078f-450c-abcb-75d434cb5e83" },
                    { new Guid("5df48ca5-d095-405e-bd2a-7ed28d98e3d5"), new DateTime(2023, 12, 27, 20, 23, 21, 638, DateTimeKind.Local).AddTicks(663), "6caab355-b595-4915-9432-4aa53e2d3eb1" },
                    { new Guid("687f65d7-ea8a-45ed-9ffd-44b347769eb3"), new DateTime(2023, 12, 27, 20, 23, 21, 638, DateTimeKind.Local).AddTicks(640), "7d66e6e8-9fd9-4375-bd6f-83f0e4f9e792" },
                    { new Guid("876a7ad1-ab14-4323-a235-48df92efd880"), new DateTime(2023, 12, 27, 20, 23, 21, 638, DateTimeKind.Local).AddTicks(645), "6caab355-b595-4915-9432-4aa53e2d3eb1" },
                    { new Guid("8e246e43-2327-4f3b-a819-37b64716851b"), new DateTime(2023, 12, 27, 20, 23, 21, 638, DateTimeKind.Local).AddTicks(643), "4c16ac30-078f-450c-abcb-75d434cb5e83" },
                    { new Guid("9033cf11-fa84-44e4-9730-1ffaa7f23756"), new DateTime(2023, 12, 27, 20, 23, 21, 638, DateTimeKind.Local).AddTicks(648), "4c16ac30-078f-450c-abcb-75d434cb5e83" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "CategoryId", "CategoryType", "Name", "OrderId", "Price", "TagId" },
                values: new object[,]
                {
                    { new Guid("0273038d-cb11-4f16-9830-1368dcd45a9d"), null, 5, "Amazon Echo Dot", new Guid("687f65d7-ea8a-45ed-9ffd-44b347769eb3"), 39.99m, null },
                    { new Guid("1afc6bc9-c4a9-468c-a091-bcf71876a16c"), null, 1, "Bose Noise-Canceling Headphones", new Guid("687f65d7-ea8a-45ed-9ffd-44b347769eb3"), 299.99m, null },
                    { new Guid("74e37db8-5f17-40cd-b972-a2516192119d"), null, 3, "Fossil Smartwatch", new Guid("05dfada3-f0af-4155-a517-ce80bcc0dc67"), 149.99m, null },
                    { new Guid("7845c623-9053-4bbc-b763-6a29ff33a43d"), null, 6, "Fitbit Charge 5", new Guid("687f65d7-ea8a-45ed-9ffd-44b347769eb3"), 149.99m, null },
                    { new Guid("83dd8132-2eed-45b8-bfef-604f0975b5f0"), null, 4, "KitchenAid Stand Mixer", new Guid("876a7ad1-ab14-4323-a235-48df92efd880"), 349.99m, null },
                    { new Guid("8bdc926b-53da-41b3-ad0c-ed6dc00b4c40"), null, 2, "Samsung Galaxy S21", new Guid("05dfada3-f0af-4155-a517-ce80bcc0dc67"), 799.99m, null },
                    { new Guid("96a86cbf-1d2c-4925-8b86-0bab35fd5c08"), null, 1, "Sony Smart TV", new Guid("687f65d7-ea8a-45ed-9ffd-44b347769eb3"), 1299.99m, null },
                    { new Guid("a07bcdaf-81b6-4a85-a681-e617c2fe82a3"), null, 3, "Calvin Klein Watch", new Guid("687f65d7-ea8a-45ed-9ffd-44b347769eb3"), 199.99m, null },
                    { new Guid("c0f557d9-699f-44cb-85ea-cef38a9248e8"), null, 3, "Nike Running Shoes", new Guid("687f65d7-ea8a-45ed-9ffd-44b347769eb3"), 89.99m, null },
                    { new Guid("cb8bb99f-29ee-40db-977a-fe6e63e49369"), null, 4, "Cuisinart Coffee Maker", new Guid("05dfada3-f0af-4155-a517-ce80bcc0dc67"), 79.99m, null },
                    { new Guid("cb9f30a5-cf43-41c1-9b09-7c187a998504"), null, 1, "Canon EOS Rebel T7", new Guid("8e246e43-2327-4f3b-a819-37b64716851b"), 499.99m, null },
                    { new Guid("d0f2cedb-2585-4354-b596-2b26ca68b760"), null, 3, "Levi's Jeans", new Guid("687f65d7-ea8a-45ed-9ffd-44b347769eb3"), 59.99m, null },
                    { new Guid("d1638cc7-8622-453e-973d-320441808656"), null, 3, "Adidas Running Shoes", new Guid("8e246e43-2327-4f3b-a819-37b64716851b"), 109.99m, null },
                    { new Guid("e5dcb228-8db8-4f5d-9337-21417896f046"), null, 6, "Razer Gaming Mouse", new Guid("687f65d7-ea8a-45ed-9ffd-44b347769eb3"), 69.99m, null },
                    { new Guid("f2c1dac1-c987-4d16-815f-1142eb264212"), null, 1, "HP Printer", new Guid("687f65d7-ea8a-45ed-9ffd-44b347769eb3"), 149.99m, null }
                });

            migrationBuilder.InsertData(
                table: "TagProducts",
                columns: new[] { "ProductId", "TagId" },
                values: new object[,]
                {
                    { new Guid("1afc6bc9-c4a9-468c-a091-bcf71876a16c"), new Guid("bdf4dbb3-2547-44d9-8b1b-aad90df928e3") },
                    { new Guid("83dd8132-2eed-45b8-bfef-604f0975b5f0"), new Guid("bdf4dbb3-2547-44d9-8b1b-aad90df928e3") },
                    { new Guid("96a86cbf-1d2c-4925-8b86-0bab35fd5c08"), new Guid("925ee134-dbfb-4da2-9344-995e988190be") },
                    { new Guid("c0f557d9-699f-44cb-85ea-cef38a9248e8"), new Guid("bdf4dbb3-2547-44d9-8b1b-aad90df928e3") },
                    { new Guid("cb9f30a5-cf43-41c1-9b09-7c187a998504"), new Guid("bdf4dbb3-2547-44d9-8b1b-aad90df928e3") },
                    { new Guid("d0f2cedb-2585-4354-b596-2b26ca68b760"), new Guid("bdf4dbb3-2547-44d9-8b1b-aad90df928e3") },
                    { new Guid("f2c1dac1-c987-4d16-815f-1142eb264212"), new Guid("bdf4dbb3-2547-44d9-8b1b-aad90df928e3") }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CampaignCustomers",
                keyColumn: "Id",
                keyValue: new Guid("349b906f-8f29-4412-a594-4796edd397bf"));

            migrationBuilder.DeleteData(
                table: "CampaignCustomers",
                keyColumn: "Id",
                keyValue: new Guid("9f3d448e-9734-4d59-a780-e63ade3600e7"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("19c1f306-3959-472e-865c-5ed14b24d2df"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("29bfa61d-84eb-4c61-ae2e-0d5a68286042"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("673cc6f5-7784-4cd0-ac93-fd79bb6742e2"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("821920b1-0f52-4035-bf04-b7fb05659252"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("c6b3d01c-c24a-43d5-927f-10810e131c7f"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("efe957dc-252d-49e9-b1a0-f65c3a181388"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("f0ed63d2-39c5-44ff-9322-8d0817b9a050"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("f5dbea74-8d31-4825-87c6-63bb4b4e8dc5"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: new Guid("23b4a2b6-927d-40cd-b2e9-31d97a298f26"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: new Guid("28d31885-acbd-4704-bd43-3701a7ebf62d"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: new Guid("5df48ca5-d095-405e-bd2a-7ed28d98e3d5"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: new Guid("9033cf11-fa84-44e4-9730-1ffaa7f23756"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("0273038d-cb11-4f16-9830-1368dcd45a9d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("74e37db8-5f17-40cd-b972-a2516192119d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("7845c623-9053-4bbc-b763-6a29ff33a43d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("8bdc926b-53da-41b3-ad0c-ed6dc00b4c40"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("a07bcdaf-81b6-4a85-a681-e617c2fe82a3"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("cb8bb99f-29ee-40db-977a-fe6e63e49369"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("d1638cc7-8622-453e-973d-320441808656"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("e5dcb228-8db8-4f5d-9337-21417896f046"));

            migrationBuilder.DeleteData(
                table: "TagProducts",
                keyColumns: new[] { "ProductId", "TagId" },
                keyValues: new object[] { new Guid("1afc6bc9-c4a9-468c-a091-bcf71876a16c"), new Guid("bdf4dbb3-2547-44d9-8b1b-aad90df928e3") });

            migrationBuilder.DeleteData(
                table: "TagProducts",
                keyColumns: new[] { "ProductId", "TagId" },
                keyValues: new object[] { new Guid("83dd8132-2eed-45b8-bfef-604f0975b5f0"), new Guid("bdf4dbb3-2547-44d9-8b1b-aad90df928e3") });

            migrationBuilder.DeleteData(
                table: "TagProducts",
                keyColumns: new[] { "ProductId", "TagId" },
                keyValues: new object[] { new Guid("96a86cbf-1d2c-4925-8b86-0bab35fd5c08"), new Guid("925ee134-dbfb-4da2-9344-995e988190be") });

            migrationBuilder.DeleteData(
                table: "TagProducts",
                keyColumns: new[] { "ProductId", "TagId" },
                keyValues: new object[] { new Guid("c0f557d9-699f-44cb-85ea-cef38a9248e8"), new Guid("bdf4dbb3-2547-44d9-8b1b-aad90df928e3") });

            migrationBuilder.DeleteData(
                table: "TagProducts",
                keyColumns: new[] { "ProductId", "TagId" },
                keyValues: new object[] { new Guid("cb9f30a5-cf43-41c1-9b09-7c187a998504"), new Guid("bdf4dbb3-2547-44d9-8b1b-aad90df928e3") });

            migrationBuilder.DeleteData(
                table: "TagProducts",
                keyColumns: new[] { "ProductId", "TagId" },
                keyValues: new object[] { new Guid("d0f2cedb-2585-4354-b596-2b26ca68b760"), new Guid("bdf4dbb3-2547-44d9-8b1b-aad90df928e3") });

            migrationBuilder.DeleteData(
                table: "TagProducts",
                keyColumns: new[] { "ProductId", "TagId" },
                keyValues: new object[] { new Guid("f2c1dac1-c987-4d16-815f-1142eb264212"), new Guid("bdf4dbb3-2547-44d9-8b1b-aad90df928e3") });

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "TagId",
                keyValue: new Guid("87a7a403-675e-4d5c-81dc-06c886571428"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "74321f15-29aa-4057-ba32-e9243bc47560");

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: new Guid("05dfada3-f0af-4155-a517-ce80bcc0dc67"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("1afc6bc9-c4a9-468c-a091-bcf71876a16c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("83dd8132-2eed-45b8-bfef-604f0975b5f0"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("96a86cbf-1d2c-4925-8b86-0bab35fd5c08"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("c0f557d9-699f-44cb-85ea-cef38a9248e8"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("cb9f30a5-cf43-41c1-9b09-7c187a998504"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("d0f2cedb-2585-4354-b596-2b26ca68b760"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("f2c1dac1-c987-4d16-815f-1142eb264212"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "TagId",
                keyValue: new Guid("925ee134-dbfb-4da2-9344-995e988190be"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "TagId",
                keyValue: new Guid("bdf4dbb3-2547-44d9-8b1b-aad90df928e3"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: new Guid("687f65d7-ea8a-45ed-9ffd-44b347769eb3"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: new Guid("876a7ad1-ab14-4323-a235-48df92efd880"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: new Guid("8e246e43-2327-4f3b-a819-37b64716851b"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4c16ac30-078f-450c-abcb-75d434cb5e83");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6caab355-b595-4915-9432-4aa53e2d3eb1");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7d66e6e8-9fd9-4375-bd6f-83f0e4f9e792");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "CreationDate", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "14258c70-cad6-4a55-8327-a9fa0bee6682", 0, "26810a59-db66-4a57-84e6-fdb1f94521d0", new DateTime(2023, 12, 27, 20, 22, 17, 809, DateTimeKind.Local).AddTicks(2265), "john.doe@example.com", false, false, null, null, null, "password123", null, false, "eb6e95be-2df0-440e-89c0-45a05541b1f9", false, "john doe" },
                    { "76034889-5c66-4785-bdc2-8a0d18644f7f", 0, "93fb0ccf-e00d-4283-81e0-b31494aabdf3", new DateTime(2023, 12, 27, 20, 22, 17, 809, DateTimeKind.Local).AddTicks(2293), "Sandy.Jakson@example.com", false, false, null, null, null, "password123", null, false, "bf46d382-6853-4b35-9e47-f724fe92046a", false, "Sandy Jakson" },
                    { "a14a27cd-493f-47ca-bced-e3adb51cf376", 0, "80bb158d-6573-4f5a-95b4-12ada4a027b3", new DateTime(2023, 12, 27, 20, 22, 17, 809, DateTimeKind.Local).AddTicks(2287), "Sara.doe@example.com", false, false, null, null, null, "password123", null, false, "f8d547a0-b24a-483a-8de9-e53f4d444939", false, "Sara doe" },
                    { "ffd6b2bb-e580-4609-b00d-b54ee95e1ee7", 0, "9f9818d2-d6dd-48ad-bc56-366c5117f479", new DateTime(2023, 12, 27, 20, 22, 17, 809, DateTimeKind.Local).AddTicks(2272), "jane.doe@example.com", false, false, null, null, null, "password123", null, false, "a8fa800e-912e-4fdf-b325-88e1060ab482", false, "jane doe" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "Name" },
                values: new object[,]
                {
                    { new Guid("28280a96-f2e8-41b8-9105-871030a88892"), "SmartDevices" },
                    { new Guid("2cfb589a-7d17-446a-9b5d-0102c4a8105b"), "Fashion" },
                    { new Guid("652c0564-99c4-46a6-80ef-ec1e46505617"), "Electronics" },
                    { new Guid("847da3ec-7920-4717-b340-9d42e9768866"), "Mobiles" },
                    { new Guid("99ce44f7-aa4b-45db-ae00-f594c6a1015b"), "Gaming" },
                    { new Guid("bccd5635-cd23-42dd-aad8-89536fc60da4"), "Appliances" },
                    { new Guid("d0980572-7070-4166-badc-e84cba75beaf"), "Tablets" },
                    { new Guid("dcaefc59-ed9f-43ad-8bdc-a7278fc1d90e"), "Clothing" }
                });

            migrationBuilder.InsertData(
                table: "Tags",
                columns: new[] { "TagId", "Name" },
                values: new object[,]
                {
                    { new Guid("19439fe2-b120-4923-8a89-24b47b790d6f"), "FlagShip Mobiles" },
                    { new Guid("318e4a94-026e-4834-8974-6950eb887e6b"), "Fashion 2024" },
                    { new Guid("fdae1f84-b417-420f-a275-5438de4fe8ec"), "Tech" }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "OrderId", "OrderDate", "UserId" },
                values: new object[,]
                {
                    { new Guid("18371255-84f5-4b35-a9df-47c09ac8a5e1"), new DateTime(2023, 12, 27, 20, 22, 17, 809, DateTimeKind.Local).AddTicks(2320), "76034889-5c66-4785-bdc2-8a0d18644f7f" },
                    { new Guid("34057720-f9c6-41f6-a6c8-73c57b566317"), new DateTime(2023, 12, 27, 20, 22, 17, 809, DateTimeKind.Local).AddTicks(2322), "a14a27cd-493f-47ca-bced-e3adb51cf376" },
                    { new Guid("43923a75-be2d-4ee8-af79-919a3c402805"), new DateTime(2023, 12, 27, 20, 22, 17, 809, DateTimeKind.Local).AddTicks(2306), "14258c70-cad6-4a55-8327-a9fa0bee6682" },
                    { new Guid("5a5b3e05-0618-4a5a-a2fd-4af296933a48"), new DateTime(2023, 12, 27, 20, 22, 17, 809, DateTimeKind.Local).AddTicks(2302), "ffd6b2bb-e580-4609-b00d-b54ee95e1ee7" },
                    { new Guid("5e89a538-2c6a-47ce-ae56-fe1328da3819"), new DateTime(2023, 12, 27, 20, 22, 17, 809, DateTimeKind.Local).AddTicks(2313), "a14a27cd-493f-47ca-bced-e3adb51cf376" },
                    { new Guid("6889c2c3-a9bf-47b7-bf40-64a3ef0fac91"), new DateTime(2023, 12, 27, 20, 22, 17, 809, DateTimeKind.Local).AddTicks(2326), "ffd6b2bb-e580-4609-b00d-b54ee95e1ee7" },
                    { new Guid("cb0a6c9a-b074-4665-95f5-f6d95ef51f1d"), new DateTime(2023, 12, 27, 20, 22, 17, 809, DateTimeKind.Local).AddTicks(2316), "ffd6b2bb-e580-4609-b00d-b54ee95e1ee7" },
                    { new Guid("f3a5e79b-00bc-4e46-abfc-ff8f72a42c38"), new DateTime(2023, 12, 27, 20, 22, 17, 809, DateTimeKind.Local).AddTicks(2308), "ffd6b2bb-e580-4609-b00d-b54ee95e1ee7" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "CategoryId", "CategoryType", "Name", "OrderId", "Price", "TagId" },
                values: new object[,]
                {
                    { new Guid("10b1fa31-cad6-4bda-aa53-f3e86cebc4d5"), null, 4, "KitchenAid Stand Mixer", new Guid("5e89a538-2c6a-47ce-ae56-fe1328da3819"), 349.99m, null },
                    { new Guid("12ab3925-dc14-4a9a-ace4-efb56e038942"), null, 6, "Razer Gaming Mouse", new Guid("43923a75-be2d-4ee8-af79-919a3c402805"), 69.99m, null },
                    { new Guid("18bf1839-4e71-419b-81db-6f0ab0298956"), null, 5, "Amazon Echo Dot", new Guid("43923a75-be2d-4ee8-af79-919a3c402805"), 39.99m, null },
                    { new Guid("2e5c100c-72cc-485c-a702-8c85b04ad2f2"), null, 1, "Sony Smart TV", new Guid("43923a75-be2d-4ee8-af79-919a3c402805"), 1299.99m, null },
                    { new Guid("3b1b2bb8-2cfa-4bb2-937b-850683637f44"), null, 6, "Fitbit Charge 5", new Guid("43923a75-be2d-4ee8-af79-919a3c402805"), 149.99m, null },
                    { new Guid("b2d8d64d-f203-4577-9f4d-239ae6164842"), null, 1, "Canon EOS Rebel T7", new Guid("f3a5e79b-00bc-4e46-abfc-ff8f72a42c38"), 499.99m, null },
                    { new Guid("b5bd6d48-cb31-4269-8f35-8fc6da0adc7e"), null, 1, "HP Printer", new Guid("43923a75-be2d-4ee8-af79-919a3c402805"), 149.99m, null },
                    { new Guid("b915f98b-9250-4c20-b043-a06d90bc4f7e"), null, 3, "Adidas Running Shoes", new Guid("f3a5e79b-00bc-4e46-abfc-ff8f72a42c38"), 109.99m, null },
                    { new Guid("cba94cbd-c55e-44f0-925e-b76e093c25c0"), null, 3, "Calvin Klein Watch", new Guid("43923a75-be2d-4ee8-af79-919a3c402805"), 199.99m, null },
                    { new Guid("d76a9078-b0a5-4a5f-8f67-a898aad2feb8"), null, 2, "Samsung Galaxy S21", new Guid("5a5b3e05-0618-4a5a-a2fd-4af296933a48"), 799.99m, null },
                    { new Guid("db2ef700-401a-4b91-b6ed-3cf234f91ade"), null, 3, "Nike Running Shoes", new Guid("43923a75-be2d-4ee8-af79-919a3c402805"), 89.99m, null },
                    { new Guid("eb58dbe8-4d10-4c33-8816-f3ec4f7f39d4"), null, 3, "Levi's Jeans", new Guid("43923a75-be2d-4ee8-af79-919a3c402805"), 59.99m, null },
                    { new Guid("ec1b630a-8c60-477f-8c95-bacbfec2518e"), null, 3, "Fossil Smartwatch", new Guid("5a5b3e05-0618-4a5a-a2fd-4af296933a48"), 149.99m, null },
                    { new Guid("f06074dc-4eb2-4aba-aa56-b4bd28b10908"), null, 4, "Cuisinart Coffee Maker", new Guid("5a5b3e05-0618-4a5a-a2fd-4af296933a48"), 79.99m, null },
                    { new Guid("f23d8d74-7264-4ae8-9dec-78946e7809ac"), null, 1, "Bose Noise-Canceling Headphones", new Guid("43923a75-be2d-4ee8-af79-919a3c402805"), 299.99m, null }
                });

            migrationBuilder.InsertData(
                table: "TagProducts",
                columns: new[] { "ProductId", "TagId" },
                values: new object[,]
                {
                    { new Guid("10b1fa31-cad6-4bda-aa53-f3e86cebc4d5"), new Guid("fdae1f84-b417-420f-a275-5438de4fe8ec") },
                    { new Guid("2e5c100c-72cc-485c-a702-8c85b04ad2f2"), new Guid("19439fe2-b120-4923-8a89-24b47b790d6f") },
                    { new Guid("b2d8d64d-f203-4577-9f4d-239ae6164842"), new Guid("fdae1f84-b417-420f-a275-5438de4fe8ec") },
                    { new Guid("b5bd6d48-cb31-4269-8f35-8fc6da0adc7e"), new Guid("fdae1f84-b417-420f-a275-5438de4fe8ec") },
                    { new Guid("db2ef700-401a-4b91-b6ed-3cf234f91ade"), new Guid("fdae1f84-b417-420f-a275-5438de4fe8ec") },
                    { new Guid("eb58dbe8-4d10-4c33-8816-f3ec4f7f39d4"), new Guid("fdae1f84-b417-420f-a275-5438de4fe8ec") },
                    { new Guid("f23d8d74-7264-4ae8-9dec-78946e7809ac"), new Guid("fdae1f84-b417-420f-a275-5438de4fe8ec") }
                });
        }
    }
}
