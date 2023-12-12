using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace E_CommerceSystemV2.DAL.Migrations
{
    /// <inheritdoc />
    public partial class Second : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserOrders_Orders_OrderId",
                table: "UserOrders");

            migrationBuilder.DropTable(
                name: "OrderUser");

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 1,
                column: "OrderDate",
                value: new DateTime(2023, 12, 12, 16, 18, 53, 576, DateTimeKind.Local).AddTicks(1509));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 2,
                column: "OrderDate",
                value: new DateTime(2023, 12, 12, 16, 18, 53, 576, DateTimeKind.Local).AddTicks(1512));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                column: "CreationDate",
                value: new DateTime(2023, 12, 12, 16, 18, 53, 576, DateTimeKind.Local).AddTicks(1494));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2,
                column: "CreationDate",
                value: new DateTime(2023, 12, 12, 16, 18, 53, 576, DateTimeKind.Local).AddTicks(1502));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 3,
                column: "CreationDate",
                value: new DateTime(2023, 12, 12, 16, 18, 53, 576, DateTimeKind.Local).AddTicks(1504));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 4,
                column: "CreationDate",
                value: new DateTime(2023, 12, 12, 16, 18, 53, 576, DateTimeKind.Local).AddTicks(1506));

            migrationBuilder.AddForeignKey(
                name: "FK_UserOrders_Orders_OrderId",
                table: "UserOrders",
                column: "OrderId",
                principalTable: "Orders",
                principalColumn: "OrderId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserOrders_Orders_OrderId",
                table: "UserOrders");

            migrationBuilder.CreateTable(
                name: "OrderUser",
                columns: table => new
                {
                    OrdersOrderId = table.Column<int>(type: "int", nullable: false),
                    UsersUserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderUser", x => new { x.OrdersOrderId, x.UsersUserId });
                    table.ForeignKey(
                        name: "FK_OrderUser_Orders_OrdersOrderId",
                        column: x => x.OrdersOrderId,
                        principalTable: "Orders",
                        principalColumn: "OrderId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderUser_Users_UsersUserId",
                        column: x => x.UsersUserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 1,
                column: "OrderDate",
                value: new DateTime(2023, 12, 12, 15, 51, 6, 562, DateTimeKind.Local).AddTicks(8314));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 2,
                column: "OrderDate",
                value: new DateTime(2023, 12, 12, 15, 51, 6, 562, DateTimeKind.Local).AddTicks(8321));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                column: "CreationDate",
                value: new DateTime(2023, 12, 12, 15, 51, 6, 562, DateTimeKind.Local).AddTicks(8288));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2,
                column: "CreationDate",
                value: new DateTime(2023, 12, 12, 15, 51, 6, 562, DateTimeKind.Local).AddTicks(8294));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 3,
                column: "CreationDate",
                value: new DateTime(2023, 12, 12, 15, 51, 6, 562, DateTimeKind.Local).AddTicks(8299));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 4,
                column: "CreationDate",
                value: new DateTime(2023, 12, 12, 15, 51, 6, 562, DateTimeKind.Local).AddTicks(8304));

            migrationBuilder.CreateIndex(
                name: "IX_OrderUser_UsersUserId",
                table: "OrderUser",
                column: "UsersUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_UserOrders_Orders_OrderId",
                table: "UserOrders",
                column: "OrderId",
                principalTable: "Orders",
                principalColumn: "OrderId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
