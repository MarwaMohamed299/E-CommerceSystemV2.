using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace E_CommerceSystemV2.DAL.Migrations
{
    /// <inheritdoc />
    public partial class AddingCampaignCustomers : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("0397150e-05b3-4fc2-8e6b-9a53b1da359f"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("40b5538a-5108-43ab-98d8-154909d27980"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("5a59f5a4-d059-4155-8b72-d8e9db8d6237"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("9b7b88c5-162c-4712-b414-c0f1002bbe82"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("a3e7cffc-f47a-46cb-9233-927aa8e42e07"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("e20fcb32-e66b-4f39-bcc4-17093bd305b9"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("e8776dd9-f129-4696-9e2e-1f44d71b0293"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("f404369a-5578-4593-93aa-8817a630f639"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: new Guid("46307b76-03aa-4329-9216-1ad02d7f3ce5"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: new Guid("5d0bfb29-1d96-448c-942a-cbb084cf32a5"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: new Guid("9f1db7cb-46dc-4b3b-80f1-113ab1c10a2f"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: new Guid("e6a023f6-99c0-4a34-9ecb-0b49d367dc50"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("04ef4f41-6446-4dd9-9173-1fd64e651444"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("103fc9a8-64ee-4e1a-ae9e-ac26a3974109"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("3d12a097-ae94-4bd1-8aa6-9bc40128a7f8"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("55b572f5-374d-4ecc-81a4-b242ba6a5ea1"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("c75be557-8fd5-4e3b-9725-61b3a97142bd"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("d82730ad-c898-48fb-bc7a-7d0ab50cd6a4"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("dda0b29c-14c9-40c2-872d-e0f7fec49d7a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("f2332187-7456-4e9c-a3fa-db3621091cf6"));

            migrationBuilder.DeleteData(
                table: "TagProducts",
                keyColumns: new[] { "ProductId", "TagId" },
                keyValues: new object[] { new Guid("064fd01a-bf9f-4889-9200-60b295613c54"), new Guid("f1c0a02b-b9e0-4155-b618-1e316f486fd6") });

            migrationBuilder.DeleteData(
                table: "TagProducts",
                keyColumns: new[] { "ProductId", "TagId" },
                keyValues: new object[] { new Guid("3935c87e-2954-44cc-a95f-7f67a902291b"), new Guid("f1c0a02b-b9e0-4155-b618-1e316f486fd6") });

            migrationBuilder.DeleteData(
                table: "TagProducts",
                keyColumns: new[] { "ProductId", "TagId" },
                keyValues: new object[] { new Guid("399acc92-7aaa-4f05-aae2-d07e88e83ebb"), new Guid("f1c0a02b-b9e0-4155-b618-1e316f486fd6") });

            migrationBuilder.DeleteData(
                table: "TagProducts",
                keyColumns: new[] { "ProductId", "TagId" },
                keyValues: new object[] { new Guid("3bef8d04-44fe-4b64-9919-400029667621"), new Guid("f1c0a02b-b9e0-4155-b618-1e316f486fd6") });

            migrationBuilder.DeleteData(
                table: "TagProducts",
                keyColumns: new[] { "ProductId", "TagId" },
                keyValues: new object[] { new Guid("ae170701-a04d-476e-8bd9-3f9bb12bf79f"), new Guid("6613d20b-76c4-4d60-9f2c-b4f4d33a11c7") });

            migrationBuilder.DeleteData(
                table: "TagProducts",
                keyColumns: new[] { "ProductId", "TagId" },
                keyValues: new object[] { new Guid("b243621f-e966-476e-acfb-6dabb89cd8a7"), new Guid("f1c0a02b-b9e0-4155-b618-1e316f486fd6") });

            migrationBuilder.DeleteData(
                table: "TagProducts",
                keyColumns: new[] { "ProductId", "TagId" },
                keyValues: new object[] { new Guid("c79c163e-ca39-42d6-980e-981e97d2fe5f"), new Guid("f1c0a02b-b9e0-4155-b618-1e316f486fd6") });

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "TagId",
                keyValue: new Guid("ce580732-35a9-41b8-96af-116518cef9f1"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c6a48572-1d1c-47bc-8082-97369cb152fe");

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: new Guid("20dd7cb7-5440-41fd-bf00-65e47a056d0c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("064fd01a-bf9f-4889-9200-60b295613c54"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("3935c87e-2954-44cc-a95f-7f67a902291b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("399acc92-7aaa-4f05-aae2-d07e88e83ebb"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("3bef8d04-44fe-4b64-9919-400029667621"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("ae170701-a04d-476e-8bd9-3f9bb12bf79f"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("b243621f-e966-476e-acfb-6dabb89cd8a7"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("c79c163e-ca39-42d6-980e-981e97d2fe5f"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "TagId",
                keyValue: new Guid("6613d20b-76c4-4d60-9f2c-b4f4d33a11c7"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "TagId",
                keyValue: new Guid("f1c0a02b-b9e0-4155-b618-1e316f486fd6"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: new Guid("5a3081d7-7565-4335-a199-c5fc4ccc8096"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: new Guid("8d6ed240-c801-4b55-a881-58827c28fb06"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: new Guid("e5dd0a36-65f0-49fb-9f16-75c279dbc6c3"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5e542efa-8217-4855-93d7-7c47a56c98f7");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7517cc9e-ced0-48ce-b404-ace27e6e2c9d");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f86a79f0-0680-41f5-a2d8-8bf2d1c04081");

            migrationBuilder.CreateTable(
                name: "CampaignCustomers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CampaignCustomers", x => x.Id);
                });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CampaignCustomers");

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
        }
    }
}
