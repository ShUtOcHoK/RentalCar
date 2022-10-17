using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RentalCar.Migrations
{
    public partial class test : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CarStatys",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarStatys", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CarTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DiscountCars",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MinYear = table.Column<int>(type: "int", nullable: false),
                    Percent = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DiscountCars", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DiscountClients",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Price = table.Column<int>(type: "int", nullable: false),
                    Percent = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DiscountClients", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PersonalDatas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Patronymic = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Addres = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonalDatas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Cars",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Number = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Year = table.Column<int>(type: "int", nullable: false),
                    BasePrice = table.Column<int>(type: "int", nullable: false),
                    CarType_Id = table.Column<int>(type: "int", nullable: false),
                    CarStatus_Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cars", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Cars_CarStatys_CarStatus_Id",
                        column: x => x.CarStatus_Id,
                        principalTable: "CarStatys",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Cars_CarTypes_CarType_Id",
                        column: x => x.CarType_Id,
                        principalTable: "CarTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Accounts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Login = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Role_Id = table.Column<int>(type: "int", nullable: false),
                    PersonalData_Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Accounts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Accounts_PersonalDatas_PersonalData_Id",
                        column: x => x.PersonalData_Id,
                        principalTable: "PersonalDatas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Accounts_Roles_Role_Id",
                        column: x => x.Role_Id,
                        principalTable: "Roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Rentals",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Price = table.Column<int>(type: "int", nullable: false),
                    Discount = table.Column<int>(type: "int", nullable: false),
                    PersonalData_Id = table.Column<int>(type: "int", nullable: false),
                    Car_Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rentals", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Rentals_Cars_Car_Id",
                        column: x => x.Car_Id,
                        principalTable: "Cars",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Rentals_PersonalDatas_PersonalData_Id",
                        column: x => x.PersonalData_Id,
                        principalTable: "PersonalDatas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ReturnRentals",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Dete = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Price = table.Column<int>(type: "int", nullable: false),
                    Rental_Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReturnRentals", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ReturnRentals_Rentals_Rental_Id",
                        column: x => x.Rental_Id,
                        principalTable: "Rentals",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "CarStatys",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Рабочая" },
                    { 2, "На обслуживании" }
                });

            migrationBuilder.InsertData(
                table: "CarTypes",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Грузовая" },
                    { 2, "Легковая" }
                });

            migrationBuilder.InsertData(
                table: "DiscountCars",
                columns: new[] { "Id", "MinYear", "Percent" },
                values: new object[,]
                {
                    { 1, 5, 0 },
                    { 2, 10, 5 },
                    { 3, 15, 10 }
                });

            migrationBuilder.InsertData(
                table: "DiscountClients",
                columns: new[] { "Id", "Percent", "Price" },
                values: new object[,]
                {
                    { 1, 2, 10000 },
                    { 2, 3, 15000 },
                    { 3, 5, 20000 },
                    { 4, 7, 30000 },
                    { 5, 10, 50000 }
                });

            migrationBuilder.InsertData(
                table: "PersonalDatas",
                columns: new[] { "Id", "Addres", "FirstName", "LastName", "Patronymic", "Phone" },
                values: new object[,]
                {
                    { 1, "60 лет Гагарина", "Андрей", "Пушкин", "Валерьевич", "89145659031" },
                    { 2, "Улица бессмертного", "Александр", "Частоступов", "Сергеевич", "89457143083" },
                    { 3, "Ленинградский", "Ирина", "Сучкова", "Сергеевна", "89610048783" },
                    { 4, "Перегорская", "Максим", "Беляев", "Павлович", "89633358392" },
                    { 5, "Косой переулок", "Анжела", "Скоропогодька", "Александровна", "89996669993" },
                    { 6, "Бегущий в лабиринте", "Алексе ", "Чередниченко", "Владимирович", "89137095738" }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Администратор" },
                    { 2, "Менеджер" },
                    { 3, "Клиент" }
                });

            migrationBuilder.InsertData(
                table: "Accounts",
                columns: new[] { "Id", "Login", "Password", "PersonalData_Id", "Role_Id" },
                values: new object[,]
                {
                    { 1, "admin", "admin", 1, 1 },
                    { 2, "manager1", "manager1", 2, 2 },
                    { 3, "manager2", "manager2", 3, 2 },
                    { 4, "client1", "client1", 4, 3 },
                    { 5, "client2", "client2", 5, 3 },
                    { 6, "client3", "client3", 6, 3 }
                });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "BasePrice", "CarStatus_Id", "CarType_Id", "Name", "Number", "Year" },
                values: new object[,]
                {
                    { 1, 1500, 1, 1, "Ford", "CB234P", 2001 },
                    { 2, 700, 2, 2, "Honda", "CE254P", 2020 },
                    { 3, 1000, 2, 1, "Jeep", "BB238P", 2015 },
                    { 4, 600, 1, 2, "Nissan", "CP634P", 2007 },
                    { 5, 650, 1, 2, "Toyota", "CX294P", 2009 },
                    { 6, 800, 1, 2, "Lada", "CA847T", 2019 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Accounts_PersonalData_Id",
                table: "Accounts",
                column: "PersonalData_Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Accounts_Role_Id",
                table: "Accounts",
                column: "Role_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Cars_CarStatus_Id",
                table: "Cars",
                column: "CarStatus_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Cars_CarType_Id",
                table: "Cars",
                column: "CarType_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Rentals_Car_Id",
                table: "Rentals",
                column: "Car_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Rentals_PersonalData_Id",
                table: "Rentals",
                column: "PersonalData_Id");

            migrationBuilder.CreateIndex(
                name: "IX_ReturnRentals_Rental_Id",
                table: "ReturnRentals",
                column: "Rental_Id",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Accounts");

            migrationBuilder.DropTable(
                name: "DiscountCars");

            migrationBuilder.DropTable(
                name: "DiscountClients");

            migrationBuilder.DropTable(
                name: "ReturnRentals");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "Rentals");

            migrationBuilder.DropTable(
                name: "Cars");

            migrationBuilder.DropTable(
                name: "PersonalDatas");

            migrationBuilder.DropTable(
                name: "CarStatys");

            migrationBuilder.DropTable(
                name: "CarTypes");
        }
    }
}
