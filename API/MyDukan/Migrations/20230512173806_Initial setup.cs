using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyDukan.Migrations
{
    public partial class Initialsetup : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cart",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "Int", nullable: false),
                    MedicineID = table.Column<int>(type: "Int", nullable: false),
                    UnitePrice = table.Column<decimal>(type: "Decimal(18,2)", nullable: false),
                    Discount = table.Column<decimal>(type: "Decimal(18,2)", nullable: false),
                    Quantity = table.Column<int>(type: "Int", nullable: false),
                    Totalprice = table.Column<decimal>(type: "Decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cart", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Medicines",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "NVARCHAR(100)", nullable: false),
                    Manufacturer = table.Column<string>(type: "NVARCHAR(100)", nullable: false),
                    UnitPrice = table.Column<decimal>(type: "Decimal(18,2)", nullable: false),
                    Discount = table.Column<decimal>(type: "Decimal(18,2)", nullable: false),
                    ImageUrl = table.Column<string>(type: "NVARCHAR(100)", nullable: false),
                    Status = table.Column<int>(type: "Int", nullable: false),
                    ExpDate = table.Column<DateTime>(type: "DateTime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Medicines", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "OrderItems",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderId = table.Column<int>(type: "Int", nullable: false),
                    MedicineID = table.Column<int>(type: "Int", nullable: false),
                    UnitPrice = table.Column<decimal>(type: "Decimal(18,2)", nullable: false),
                    Discount = table.Column<decimal>(type: "Decimal(18,2)", nullable: false),
                    Quantity = table.Column<int>(type: "Int", nullable: false),
                    Totalprice = table.Column<decimal>(type: "Decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderItems", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "Int", nullable: false),
                    OrderNo = table.Column<string>(type: "NVARCHAR(100)", nullable: false),
                    OrderTotal = table.Column<decimal>(type: "Decimal(18,2)", nullable: false),
                    OrderStatus = table.Column<string>(type: "NVARCHAR(100)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "NVARCHAR(100)", nullable: false),
                    LastName = table.Column<string>(type: "NVARCHAR(100)", nullable: false),
                    Password = table.Column<string>(type: "NVARCHAR(100)", nullable: false),
                    Email = table.Column<string>(type: "NVARCHAR(100)", nullable: false),
                    Fund = table.Column<decimal>(type: "Decimal(18,2)", nullable: false),
                    Type = table.Column<string>(type: "NVARCHAR(100)", nullable: false),
                    Status = table.Column<int>(type: "Int", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "DateTime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cart");

            migrationBuilder.DropTable(
                name: "Medicines");

            migrationBuilder.DropTable(
                name: "OrderItems");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
