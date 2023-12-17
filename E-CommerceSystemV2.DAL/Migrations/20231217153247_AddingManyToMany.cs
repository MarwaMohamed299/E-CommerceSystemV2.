using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace E_CommerceSystemV2.DAL.Migrations
{
    /// <inheritdoc />
    public partial class AddingManyToMany : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "addbff2d-c448-4a1d-9c05-0a909a4bdf4a");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f2b17123-530d-403a-87c1-03ba87e014dc");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("02a9c761-f62e-4b1f-994d-a42c60baecfd"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("0b7375db-6acb-46ae-aea2-f99772dc373e"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("254b221e-4a9d-43c5-9a67-004b671624af"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("29bf952d-fe1b-46d6-9dcf-792888134c68"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("52c113bf-6f35-4c9e-9ccb-08b536ceea9c"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("73fa5b4e-6c71-4f9e-8522-1848336fea07"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("7aa31bd4-2a97-4d7d-b320-ceb6053ab188"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("fb4bf68b-1340-49b7-b3d0-d36a57816260"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: new Guid("982a7a74-fbf8-4470-b71a-248c567b0c62"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("0ae0d660-a4d4-4e86-a935-a1e53a7a5fab"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("52addef3-1313-46bd-8f07-8ba8683c7a46"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("534fe139-2600-46d4-98a4-ab2e172260e7"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("bd32118c-51c4-4e3f-acef-bfad7bd04377"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("c34fc8f8-bf0e-499f-872f-090c786c45a8"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("d26cc5bf-74a7-4b9b-a7cb-d59b0254a696"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("e3a3b0e0-3bae-44c9-82dc-7b04d64de48f"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("ecb89810-d67d-47c8-abaa-5e7a53b53743"));

            migrationBuilder.DeleteData(
                table: "TagProducts",
                keyColumns: new[] { "ProductId", "TagId" },
                keyValues: new object[] { new Guid("0a809444-8345-488d-a027-66c40bcc9583"), new Guid("de9cc795-4ee7-45d4-b523-ea5c743fd8d0") });

            migrationBuilder.DeleteData(
                table: "TagProducts",
                keyColumns: new[] { "ProductId", "TagId" },
                keyValues: new object[] { new Guid("0adc9a32-4a4a-4353-9b60-b7ff7236e1c0"), new Guid("de9cc795-4ee7-45d4-b523-ea5c743fd8d0") });

            migrationBuilder.DeleteData(
                table: "TagProducts",
                keyColumns: new[] { "ProductId", "TagId" },
                keyValues: new object[] { new Guid("0d880792-bde9-4d53-ba9e-1d72dabf637b"), new Guid("de9cc795-4ee7-45d4-b523-ea5c743fd8d0") });

            migrationBuilder.DeleteData(
                table: "TagProducts",
                keyColumns: new[] { "ProductId", "TagId" },
                keyValues: new object[] { new Guid("4c261103-8d7f-45b4-918d-60e2579768fb"), new Guid("de9cc795-4ee7-45d4-b523-ea5c743fd8d0") });

            migrationBuilder.DeleteData(
                table: "TagProducts",
                keyColumns: new[] { "ProductId", "TagId" },
                keyValues: new object[] { new Guid("87d3b371-c4e0-4f6d-ac80-988949de071a"), new Guid("de9cc795-4ee7-45d4-b523-ea5c743fd8d0") });

            migrationBuilder.DeleteData(
                table: "TagProducts",
                keyColumns: new[] { "ProductId", "TagId" },
                keyValues: new object[] { new Guid("98f322c6-ae4b-4abb-8a61-f9af769eda2c"), new Guid("737cf16e-5cb2-4a8a-9059-97777fb006ad") });

            migrationBuilder.DeleteData(
                table: "TagProducts",
                keyColumns: new[] { "ProductId", "TagId" },
                keyValues: new object[] { new Guid("a38e151a-4bd3-4e6b-8e3e-e7d58b9dc89d"), new Guid("de9cc795-4ee7-45d4-b523-ea5c743fd8d0") });

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "TagId",
                keyValue: new Guid("5116354d-96a1-429a-a373-98ae6847cb9e"));

            migrationBuilder.DeleteData(
                table: "UserOrders",
                keyColumns: new[] { "Id", "OrderId" },
                keyValues: new object[] { "6daf8104-a4e3-4c46-b3cb-0918617b1c61", new Guid("ff5af8eb-9367-4c5a-b476-1169dc0d9960") });

            migrationBuilder.DeleteData(
                table: "UserOrders",
                keyColumns: new[] { "Id", "OrderId" },
                keyValues: new object[] { "ec9190fc-b6d7-4eb1-8e6c-e22fb71aab3c", new Guid("ff5af8eb-9367-4c5a-b476-1169dc0d9960") });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6daf8104-a4e3-4c46-b3cb-0918617b1c61");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ec9190fc-b6d7-4eb1-8e6c-e22fb71aab3c");

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: new Guid("ff5af8eb-9367-4c5a-b476-1169dc0d9960"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("0a809444-8345-488d-a027-66c40bcc9583"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("0adc9a32-4a4a-4353-9b60-b7ff7236e1c0"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("0d880792-bde9-4d53-ba9e-1d72dabf637b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("4c261103-8d7f-45b4-918d-60e2579768fb"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("87d3b371-c4e0-4f6d-ac80-988949de071a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("98f322c6-ae4b-4abb-8a61-f9af769eda2c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("a38e151a-4bd3-4e6b-8e3e-e7d58b9dc89d"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "TagId",
                keyValue: new Guid("737cf16e-5cb2-4a8a-9059-97777fb006ad"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "TagId",
                keyValue: new Guid("de9cc795-4ee7-45d4-b523-ea5c743fd8d0"));

            migrationBuilder.AddColumn<Guid>(
                name: "TagId",
                table: "Products",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "CreationDate", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "6eeed75d-7e23-43f1-a27e-1f97b6eac236", 0, "3b54874a-d9be-46d5-a617-67e2e01b76d4", new DateTime(2023, 12, 17, 17, 32, 46, 880, DateTimeKind.Local).AddTicks(1994), "Sandy.Jakson@example.com", false, false, null, null, null, "password123", null, false, "c7ba2f3e-8d48-4e12-89fa-efd9d3db1950", false, "Sandy Jakson" },
                    { "7e87a4d6-4f3d-44e4-999c-56d6ab0192d8", 0, "32e10c83-5326-40dc-adb7-45f1766880b0", new DateTime(2023, 12, 17, 17, 32, 46, 880, DateTimeKind.Local).AddTicks(1966), "jane.doe@example.com", false, false, null, null, null, "password123", null, false, "6de0626c-1b0e-452f-b6a7-ae2df4879921", false, "jane doe" },
                    { "ce4dc91c-e83a-4ec3-91f4-083118866779", 0, "11c11d49-0eb6-4b7c-91fa-c4f5e01a58cd", new DateTime(2023, 12, 17, 17, 32, 46, 880, DateTimeKind.Local).AddTicks(1981), "Sara.doe@example.com", false, false, null, null, null, "password123", null, false, "9101b99f-e4d8-435f-808e-6f5cf091fdee", false, "Sara doe" },
                    { "eae7b3a5-5441-4abb-94f0-ce35f3c8963b", 0, "dd91a48b-2013-49c7-a0d7-9b04a1d89aa9", new DateTime(2023, 12, 17, 17, 32, 46, 880, DateTimeKind.Local).AddTicks(1948), "john.doe@example.com", false, false, null, null, null, "password123", null, false, "6d88ca2f-9dc0-4dc4-88f1-5458ccf1edc8", false, "john doe" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "Name" },
                values: new object[,]
                {
                    { new Guid("017e2185-48c6-4c95-a48d-16e470603710"), "Fashion" },
                    { new Guid("2024abf4-128a-4428-be61-07527eb457f4"), "Clothing" },
                    { new Guid("391608a7-aca5-408b-ba6f-edcb7f68b2c3"), "Electronics" },
                    { new Guid("3c074ff0-d2be-474d-94b0-968ac0a5883f"), "Tablets" },
                    { new Guid("5a605348-b861-4beb-ad64-51a57c5383a5"), "Mobiles" },
                    { new Guid("c19e82b5-7bf9-4840-8e89-f2f772dc50b3"), "Appliances" },
                    { new Guid("f6f4e350-25f9-4a83-8027-97f56f36e3c3"), "Gaming" },
                    { new Guid("fd1d5176-a150-47a0-b302-bcf144f31b4d"), "SmartDevices" }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "OrderId", "OrderDate" },
                values: new object[,]
                {
                    { new Guid("119131d2-f0f7-4d8f-9bb5-e8e646df4f57"), new DateTime(2023, 12, 17, 17, 32, 46, 880, DateTimeKind.Local).AddTicks(2001) },
                    { new Guid("53da2caf-e663-4700-b2a8-7d37ab16fab5"), new DateTime(2023, 12, 17, 17, 32, 46, 880, DateTimeKind.Local).AddTicks(2007) }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "CategoryId", "CategoryType", "Name", "Price", "TagId" },
                values: new object[,]
                {
                    { new Guid("0388871d-1ed4-40d9-9141-fbc7ec3ec36e"), null, 4, "KitchenAid Stand Mixer", 349.99m, null },
                    { new Guid("38bc03d4-a17d-4304-965d-46bf93a3ad1e"), null, 3, "Fossil Smartwatch", 149.99m, null },
                    { new Guid("5542e0b4-1732-47d0-823a-7fd2b5943f3e"), null, 6, "Fitbit Charge 5", 149.99m, null },
                    { new Guid("6272d26a-bd72-4eb9-ab68-b68c86a27230"), null, 1, "HP Printer", 149.99m, null },
                    { new Guid("7036dc85-833f-4be8-9b38-57c4b8915195"), null, 3, "Levi's Jeans", 59.99m, null },
                    { new Guid("7bcce6d2-f1ee-4664-8d5e-577cde13fe11"), null, 3, "Nike Running Shoes", 89.99m, null },
                    { new Guid("8dc54614-a6bb-43da-8208-b7ff05f7672f"), null, 5, "Amazon Echo Dot", 39.99m, null },
                    { new Guid("9364327a-844f-4afe-bef6-ed19f28efd37"), null, 6, "Razer Gaming Mouse", 69.99m, null },
                    { new Guid("a5065ae5-ae59-4bab-b715-77d56ee04074"), null, 1, "Bose Noise-Canceling Headphones", 299.99m, null },
                    { new Guid("bad5db85-5450-42c9-a103-357dd33b6ed8"), null, 3, "Adidas Running Shoes", 109.99m, null },
                    { new Guid("c6db1b96-ea2d-43ac-b99e-c8a007d26f98"), null, 2, "Samsung Galaxy S21", 799.99m, null },
                    { new Guid("ca5240cc-1597-4d70-be9f-bb36a6917dfa"), null, 1, "Canon EOS Rebel T7", 499.99m, null },
                    { new Guid("cb6c9e3f-9c60-48fe-96c8-f99090fd891c"), null, 1, "Sony Smart TV", 1299.99m, null },
                    { new Guid("fc9e8ed9-eac5-44b7-b419-20705022cf65"), null, 4, "Cuisinart Coffee Maker", 79.99m, null },
                    { new Guid("fca2697f-d210-4277-844c-f2521c5b38f8"), null, 3, "Calvin Klein Watch", 199.99m, null }
                });

            migrationBuilder.InsertData(
                table: "Tags",
                columns: new[] { "TagId", "Name" },
                values: new object[,]
                {
                    { new Guid("656dcee4-d717-4c32-aa6f-95da420f1777"), "FlagShip Mobiles" },
                    { new Guid("cfd931d2-3881-48c0-8924-8c981c7b4e53"), "Fashion 2024" },
                    { new Guid("e19e7131-285f-4a94-b01e-7421f0c22b59"), "Tech" }
                });

            migrationBuilder.InsertData(
                table: "TagProducts",
                columns: new[] { "ProductId", "TagId" },
                values: new object[,]
                {
                    { new Guid("0388871d-1ed4-40d9-9141-fbc7ec3ec36e"), new Guid("e19e7131-285f-4a94-b01e-7421f0c22b59") },
                    { new Guid("6272d26a-bd72-4eb9-ab68-b68c86a27230"), new Guid("e19e7131-285f-4a94-b01e-7421f0c22b59") },
                    { new Guid("7036dc85-833f-4be8-9b38-57c4b8915195"), new Guid("e19e7131-285f-4a94-b01e-7421f0c22b59") },
                    { new Guid("7bcce6d2-f1ee-4664-8d5e-577cde13fe11"), new Guid("e19e7131-285f-4a94-b01e-7421f0c22b59") },
                    { new Guid("a5065ae5-ae59-4bab-b715-77d56ee04074"), new Guid("e19e7131-285f-4a94-b01e-7421f0c22b59") },
                    { new Guid("ca5240cc-1597-4d70-be9f-bb36a6917dfa"), new Guid("e19e7131-285f-4a94-b01e-7421f0c22b59") },
                    { new Guid("cb6c9e3f-9c60-48fe-96c8-f99090fd891c"), new Guid("656dcee4-d717-4c32-aa6f-95da420f1777") }
                });

            migrationBuilder.InsertData(
                table: "UserOrders",
                columns: new[] { "Id", "OrderId" },
                values: new object[,]
                {
                    { "7e87a4d6-4f3d-44e4-999c-56d6ab0192d8", new Guid("53da2caf-e663-4700-b2a8-7d37ab16fab5") },
                    { "ce4dc91c-e83a-4ec3-91f4-083118866779", new Guid("53da2caf-e663-4700-b2a8-7d37ab16fab5") }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Products_TagId",
                table: "Products",
                column: "TagId");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Tags_TagId",
                table: "Products",
                column: "TagId",
                principalTable: "Tags",
                principalColumn: "TagId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Tags_TagId",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_TagId",
                table: "Products");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6eeed75d-7e23-43f1-a27e-1f97b6eac236");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "eae7b3a5-5441-4abb-94f0-ce35f3c8963b");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("017e2185-48c6-4c95-a48d-16e470603710"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("2024abf4-128a-4428-be61-07527eb457f4"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("391608a7-aca5-408b-ba6f-edcb7f68b2c3"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("3c074ff0-d2be-474d-94b0-968ac0a5883f"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("5a605348-b861-4beb-ad64-51a57c5383a5"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("c19e82b5-7bf9-4840-8e89-f2f772dc50b3"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("f6f4e350-25f9-4a83-8027-97f56f36e3c3"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("fd1d5176-a150-47a0-b302-bcf144f31b4d"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: new Guid("119131d2-f0f7-4d8f-9bb5-e8e646df4f57"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("38bc03d4-a17d-4304-965d-46bf93a3ad1e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("5542e0b4-1732-47d0-823a-7fd2b5943f3e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("8dc54614-a6bb-43da-8208-b7ff05f7672f"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("9364327a-844f-4afe-bef6-ed19f28efd37"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("bad5db85-5450-42c9-a103-357dd33b6ed8"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("c6db1b96-ea2d-43ac-b99e-c8a007d26f98"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("fc9e8ed9-eac5-44b7-b419-20705022cf65"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("fca2697f-d210-4277-844c-f2521c5b38f8"));

            migrationBuilder.DeleteData(
                table: "TagProducts",
                keyColumns: new[] { "ProductId", "TagId" },
                keyValues: new object[] { new Guid("0388871d-1ed4-40d9-9141-fbc7ec3ec36e"), new Guid("e19e7131-285f-4a94-b01e-7421f0c22b59") });

            migrationBuilder.DeleteData(
                table: "TagProducts",
                keyColumns: new[] { "ProductId", "TagId" },
                keyValues: new object[] { new Guid("6272d26a-bd72-4eb9-ab68-b68c86a27230"), new Guid("e19e7131-285f-4a94-b01e-7421f0c22b59") });

            migrationBuilder.DeleteData(
                table: "TagProducts",
                keyColumns: new[] { "ProductId", "TagId" },
                keyValues: new object[] { new Guid("7036dc85-833f-4be8-9b38-57c4b8915195"), new Guid("e19e7131-285f-4a94-b01e-7421f0c22b59") });

            migrationBuilder.DeleteData(
                table: "TagProducts",
                keyColumns: new[] { "ProductId", "TagId" },
                keyValues: new object[] { new Guid("7bcce6d2-f1ee-4664-8d5e-577cde13fe11"), new Guid("e19e7131-285f-4a94-b01e-7421f0c22b59") });

            migrationBuilder.DeleteData(
                table: "TagProducts",
                keyColumns: new[] { "ProductId", "TagId" },
                keyValues: new object[] { new Guid("a5065ae5-ae59-4bab-b715-77d56ee04074"), new Guid("e19e7131-285f-4a94-b01e-7421f0c22b59") });

            migrationBuilder.DeleteData(
                table: "TagProducts",
                keyColumns: new[] { "ProductId", "TagId" },
                keyValues: new object[] { new Guid("ca5240cc-1597-4d70-be9f-bb36a6917dfa"), new Guid("e19e7131-285f-4a94-b01e-7421f0c22b59") });

            migrationBuilder.DeleteData(
                table: "TagProducts",
                keyColumns: new[] { "ProductId", "TagId" },
                keyValues: new object[] { new Guid("cb6c9e3f-9c60-48fe-96c8-f99090fd891c"), new Guid("656dcee4-d717-4c32-aa6f-95da420f1777") });

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "TagId",
                keyValue: new Guid("cfd931d2-3881-48c0-8924-8c981c7b4e53"));

            migrationBuilder.DeleteData(
                table: "UserOrders",
                keyColumns: new[] { "Id", "OrderId" },
                keyValues: new object[] { "7e87a4d6-4f3d-44e4-999c-56d6ab0192d8", new Guid("53da2caf-e663-4700-b2a8-7d37ab16fab5") });

            migrationBuilder.DeleteData(
                table: "UserOrders",
                keyColumns: new[] { "Id", "OrderId" },
                keyValues: new object[] { "ce4dc91c-e83a-4ec3-91f4-083118866779", new Guid("53da2caf-e663-4700-b2a8-7d37ab16fab5") });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7e87a4d6-4f3d-44e4-999c-56d6ab0192d8");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ce4dc91c-e83a-4ec3-91f4-083118866779");

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: new Guid("53da2caf-e663-4700-b2a8-7d37ab16fab5"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("0388871d-1ed4-40d9-9141-fbc7ec3ec36e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("6272d26a-bd72-4eb9-ab68-b68c86a27230"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("7036dc85-833f-4be8-9b38-57c4b8915195"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("7bcce6d2-f1ee-4664-8d5e-577cde13fe11"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("a5065ae5-ae59-4bab-b715-77d56ee04074"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("ca5240cc-1597-4d70-be9f-bb36a6917dfa"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("cb6c9e3f-9c60-48fe-96c8-f99090fd891c"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "TagId",
                keyValue: new Guid("656dcee4-d717-4c32-aa6f-95da420f1777"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "TagId",
                keyValue: new Guid("e19e7131-285f-4a94-b01e-7421f0c22b59"));

            migrationBuilder.DropColumn(
                name: "TagId",
                table: "Products");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "CreationDate", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "6daf8104-a4e3-4c46-b3cb-0918617b1c61", 0, "e3b29ec6-5656-4043-b313-7602999de03b", new DateTime(2023, 12, 16, 16, 10, 11, 851, DateTimeKind.Local).AddTicks(9517), "Sara.doe@example.com", false, false, null, null, null, "password123", null, false, "7cb407e9-817b-4732-8947-a231c79f053d", false, "Sara doe" },
                    { "addbff2d-c448-4a1d-9c05-0a909a4bdf4a", 0, "a9bb11b0-2b11-4704-80e0-6502cfba7147", new DateTime(2023, 12, 16, 16, 10, 11, 851, DateTimeKind.Local).AddTicks(9527), "Sandy.Jakson@example.com", false, false, null, null, null, "password123", null, false, "5afc1f1f-a4e8-4350-9ac3-f8ec8ef8aca2", false, "Sandy Jakson" },
                    { "ec9190fc-b6d7-4eb1-8e6c-e22fb71aab3c", 0, "f498ae7b-a44b-4dae-9f58-7dd2052fd11e", new DateTime(2023, 12, 16, 16, 10, 11, 851, DateTimeKind.Local).AddTicks(9510), "jane.doe@example.com", false, false, null, null, null, "password123", null, false, "75847b32-fc0b-4290-ae7f-0ddb7a2baf52", false, "jane doe" },
                    { "f2b17123-530d-403a-87c1-03ba87e014dc", 0, "2de514f0-7333-4fb1-a23b-fadbe46c03bd", new DateTime(2023, 12, 16, 16, 10, 11, 851, DateTimeKind.Local).AddTicks(9501), "john.doe@example.com", false, false, null, null, null, "password123", null, false, "af0c079b-1553-478d-9798-038c093d5e51", false, "john doe" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "Name" },
                values: new object[,]
                {
                    { new Guid("02a9c761-f62e-4b1f-994d-a42c60baecfd"), "Clothing" },
                    { new Guid("0b7375db-6acb-46ae-aea2-f99772dc373e"), "Gaming" },
                    { new Guid("254b221e-4a9d-43c5-9a67-004b671624af"), "Fashion" },
                    { new Guid("29bf952d-fe1b-46d6-9dcf-792888134c68"), "Electronics" },
                    { new Guid("52c113bf-6f35-4c9e-9ccb-08b536ceea9c"), "Tablets" },
                    { new Guid("73fa5b4e-6c71-4f9e-8522-1848336fea07"), "SmartDevices" },
                    { new Guid("7aa31bd4-2a97-4d7d-b320-ceb6053ab188"), "Mobiles" },
                    { new Guid("fb4bf68b-1340-49b7-b3d0-d36a57816260"), "Appliances" }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "OrderId", "OrderDate" },
                values: new object[,]
                {
                    { new Guid("982a7a74-fbf8-4470-b71a-248c567b0c62"), new DateTime(2023, 12, 16, 16, 10, 11, 851, DateTimeKind.Local).AddTicks(9537) },
                    { new Guid("ff5af8eb-9367-4c5a-b476-1169dc0d9960"), new DateTime(2023, 12, 16, 16, 10, 11, 851, DateTimeKind.Local).AddTicks(9540) }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "CategoryId", "CategoryType", "Name", "Price" },
                values: new object[,]
                {
                    { new Guid("0a809444-8345-488d-a027-66c40bcc9583"), null, 1, "Canon EOS Rebel T7", 499.99m },
                    { new Guid("0adc9a32-4a4a-4353-9b60-b7ff7236e1c0"), null, 1, "Bose Noise-Canceling Headphones", 299.99m },
                    { new Guid("0ae0d660-a4d4-4e86-a935-a1e53a7a5fab"), null, 2, "Samsung Galaxy S21", 799.99m },
                    { new Guid("0d880792-bde9-4d53-ba9e-1d72dabf637b"), null, 4, "KitchenAid Stand Mixer", 349.99m },
                    { new Guid("4c261103-8d7f-45b4-918d-60e2579768fb"), null, 1, "HP Printer", 149.99m },
                    { new Guid("52addef3-1313-46bd-8f07-8ba8683c7a46"), null, 4, "Cuisinart Coffee Maker", 79.99m },
                    { new Guid("534fe139-2600-46d4-98a4-ab2e172260e7"), null, 6, "Razer Gaming Mouse", 69.99m },
                    { new Guid("87d3b371-c4e0-4f6d-ac80-988949de071a"), null, 3, "Levi's Jeans", 59.99m },
                    { new Guid("98f322c6-ae4b-4abb-8a61-f9af769eda2c"), null, 1, "Sony Smart TV", 1299.99m },
                    { new Guid("a38e151a-4bd3-4e6b-8e3e-e7d58b9dc89d"), null, 3, "Nike Running Shoes", 89.99m },
                    { new Guid("bd32118c-51c4-4e3f-acef-bfad7bd04377"), null, 5, "Amazon Echo Dot", 39.99m },
                    { new Guid("c34fc8f8-bf0e-499f-872f-090c786c45a8"), null, 3, "Adidas Running Shoes", 109.99m },
                    { new Guid("d26cc5bf-74a7-4b9b-a7cb-d59b0254a696"), null, 3, "Calvin Klein Watch", 199.99m },
                    { new Guid("e3a3b0e0-3bae-44c9-82dc-7b04d64de48f"), null, 3, "Fossil Smartwatch", 149.99m },
                    { new Guid("ecb89810-d67d-47c8-abaa-5e7a53b53743"), null, 6, "Fitbit Charge 5", 149.99m }
                });

            migrationBuilder.InsertData(
                table: "Tags",
                columns: new[] { "TagId", "Name" },
                values: new object[,]
                {
                    { new Guid("5116354d-96a1-429a-a373-98ae6847cb9e"), "Fashion 2024" },
                    { new Guid("737cf16e-5cb2-4a8a-9059-97777fb006ad"), "FlagShip Mobiles" },
                    { new Guid("de9cc795-4ee7-45d4-b523-ea5c743fd8d0"), "Tech" }
                });

            migrationBuilder.InsertData(
                table: "TagProducts",
                columns: new[] { "ProductId", "TagId" },
                values: new object[,]
                {
                    { new Guid("0a809444-8345-488d-a027-66c40bcc9583"), new Guid("de9cc795-4ee7-45d4-b523-ea5c743fd8d0") },
                    { new Guid("0adc9a32-4a4a-4353-9b60-b7ff7236e1c0"), new Guid("de9cc795-4ee7-45d4-b523-ea5c743fd8d0") },
                    { new Guid("0d880792-bde9-4d53-ba9e-1d72dabf637b"), new Guid("de9cc795-4ee7-45d4-b523-ea5c743fd8d0") },
                    { new Guid("4c261103-8d7f-45b4-918d-60e2579768fb"), new Guid("de9cc795-4ee7-45d4-b523-ea5c743fd8d0") },
                    { new Guid("87d3b371-c4e0-4f6d-ac80-988949de071a"), new Guid("de9cc795-4ee7-45d4-b523-ea5c743fd8d0") },
                    { new Guid("98f322c6-ae4b-4abb-8a61-f9af769eda2c"), new Guid("737cf16e-5cb2-4a8a-9059-97777fb006ad") },
                    { new Guid("a38e151a-4bd3-4e6b-8e3e-e7d58b9dc89d"), new Guid("de9cc795-4ee7-45d4-b523-ea5c743fd8d0") }
                });

            migrationBuilder.InsertData(
                table: "UserOrders",
                columns: new[] { "Id", "OrderId" },
                values: new object[,]
                {
                    { "6daf8104-a4e3-4c46-b3cb-0918617b1c61", new Guid("ff5af8eb-9367-4c5a-b476-1169dc0d9960") },
                    { "ec9190fc-b6d7-4eb1-8e6c-e22fb71aab3c", new Guid("ff5af8eb-9367-4c5a-b476-1169dc0d9960") }
                });
        }
    }
}
