using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace E_CommerceSystemV2.DAL.Migrations
{
    /// <inheritdoc />
    public partial class second : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6fc57450-b171-416f-a5ee-7ce7aa1e88e4");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "817dea1a-128e-4561-bf70-02a61ebb28ea");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("1e3ac85b-8875-49ba-99ba-018ddcf25602"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("2467a93b-c3c7-42e2-bba2-fa67e50d41f8"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("24e47f0b-447c-4d66-aee9-c7be948e0747"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("291fae8e-8fea-4c4e-be1b-74af2c2551a4"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("73e32f3a-91b2-4047-95c1-d2262bdb0bdd"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("8b7dc28e-cac6-480e-b5fd-24c099a113bb"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("952f2248-1949-4152-8e7b-7ae413f16299"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("f6cc9ecd-c88c-42ea-92c3-26f790196617"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: new Guid("518d50b3-64f1-4856-9bdd-dc711ced2e74"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("1657f280-8380-471a-baa6-4eb846aeaeba"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("4fc22b6d-a00d-4bd7-bd0d-0064ca56d9e8"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("748b16c7-0d6b-4ea4-9e44-60b926830a80"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("7684c781-877f-4510-bdd9-f02e93ef6d84"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("7f2bbfb7-2086-4413-b8b6-80765518e7d8"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("90cfddf2-2827-4ae3-8014-a454a1caf113"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("94a78685-ee6d-4ba1-9f7a-89754ea63625"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("a3bec710-ecf9-4351-9bd4-27c3b245a378"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("ba7306fa-9228-4e20-8f9d-2d6160f13938"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("c6e72622-1cb0-468c-b459-558ddf96c98e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("d780117e-5d00-4738-9d40-451366845386"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("deaf8252-e940-4e15-a060-2ff721484b91"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("e3a13aec-4b03-4e57-bd01-30ae111f39ef"));

            migrationBuilder.DeleteData(
                table: "TagProducts",
                keyColumns: new[] { "ProductId", "TagId" },
                keyValues: new object[] { new Guid("4788ead3-d312-4464-9c24-179513960799"), new Guid("499ff470-510c-4250-8a57-60e43c9552e3") });

            migrationBuilder.DeleteData(
                table: "TagProducts",
                keyColumns: new[] { "ProductId", "TagId" },
                keyValues: new object[] { new Guid("6736ffa4-502a-40b9-9c50-04296dbcf4ac"), new Guid("43e42810-d632-4245-bbc1-112b905e562a") });

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "TagId",
                keyValue: new Guid("966023cd-9348-47e5-a06f-b95767e2ae3a"));

            migrationBuilder.DeleteData(
                table: "UserOrders",
                keyColumns: new[] { "Id", "OrderId" },
                keyValues: new object[] { "8f8be606-1b6a-4fc0-9eb4-64cbdeb572db", new Guid("f1d148a2-8dd8-4315-a227-41f8830ec2df") });

            migrationBuilder.DeleteData(
                table: "UserOrders",
                keyColumns: new[] { "Id", "OrderId" },
                keyValues: new object[] { "911ff057-c661-4236-a00e-67252e78797c", new Guid("f1d148a2-8dd8-4315-a227-41f8830ec2df") });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8f8be606-1b6a-4fc0-9eb4-64cbdeb572db");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "911ff057-c661-4236-a00e-67252e78797c");

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: new Guid("f1d148a2-8dd8-4315-a227-41f8830ec2df"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("4788ead3-d312-4464-9c24-179513960799"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("6736ffa4-502a-40b9-9c50-04296dbcf4ac"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "TagId",
                keyValue: new Guid("43e42810-d632-4245-bbc1-112b905e562a"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "TagId",
                keyValue: new Guid("499ff470-510c-4250-8a57-60e43c9552e3"));

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
        }
    }
}
