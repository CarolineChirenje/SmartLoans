using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SmartDataAccess.Migrations
{
    public partial class TableAlterations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsPaid",
                table: "ClientFees");

            migrationBuilder.RenameColumn(
                name: "CurrentSalary",
                table: "ClientDeductions",
                newName: "Salary");

            migrationBuilder.AddColumn<DateTime>(
                name: "DatePaid",
                table: "ClientFees",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ClientProductID",
                table: "ClientDeductions",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "DatePaid",
                table: "ClientDeductions",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "BankAccountTypes",
                keyColumn: "BankAccountTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 903, DateTimeKind.Local).AddTicks(6570));

            migrationBuilder.UpdateData(
                table: "BankAccountTypes",
                keyColumn: "BankAccountTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 903, DateTimeKind.Local).AddTicks(7283));

            migrationBuilder.UpdateData(
                table: "BankAccountTypes",
                keyColumn: "BankAccountTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 903, DateTimeKind.Local).AddTicks(7293));

            migrationBuilder.UpdateData(
                table: "BankAccountTypes",
                keyColumn: "BankAccountTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 903, DateTimeKind.Local).AddTicks(7298));

            migrationBuilder.UpdateData(
                table: "ContactTypes",
                keyColumn: "ContactTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 917, DateTimeKind.Local).AddTicks(8376));

            migrationBuilder.UpdateData(
                table: "ContactTypes",
                keyColumn: "ContactTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 917, DateTimeKind.Local).AddTicks(8369));

            migrationBuilder.UpdateData(
                table: "ContactTypes",
                keyColumn: "ContactTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 917, DateTimeKind.Local).AddTicks(8359));

            migrationBuilder.UpdateData(
                table: "ContactTypes",
                keyColumn: "ContactTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 917, DateTimeKind.Local).AddTicks(8195));

            migrationBuilder.UpdateData(
                table: "ContactTypes",
                keyColumn: "ContactTypeID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 917, DateTimeKind.Local).AddTicks(8382));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 924, DateTimeKind.Local).AddTicks(5966));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 924, DateTimeKind.Local).AddTicks(6369));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 924, DateTimeKind.Local).AddTicks(6378));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 924, DateTimeKind.Local).AddTicks(6390));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 924, DateTimeKind.Local).AddTicks(6394));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 924, DateTimeKind.Local).AddTicks(6404));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 924, DateTimeKind.Local).AddTicks(6407));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 924, DateTimeKind.Local).AddTicks(6412));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 924, DateTimeKind.Local).AddTicks(6416));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 924, DateTimeKind.Local).AddTicks(6420));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 924, DateTimeKind.Local).AddTicks(6424));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 924, DateTimeKind.Local).AddTicks(6427));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 13,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 924, DateTimeKind.Local).AddTicks(6430));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 14,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 924, DateTimeKind.Local).AddTicks(6434));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 15,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 924, DateTimeKind.Local).AddTicks(6437));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 16,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 924, DateTimeKind.Local).AddTicks(6441));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 17,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 924, DateTimeKind.Local).AddTicks(6445));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 18,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 924, DateTimeKind.Local).AddTicks(6451));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 19,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 924, DateTimeKind.Local).AddTicks(6471));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 20,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 924, DateTimeKind.Local).AddTicks(6474));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 21,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 924, DateTimeKind.Local).AddTicks(6478));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 22,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 924, DateTimeKind.Local).AddTicks(6481));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 23,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 924, DateTimeKind.Local).AddTicks(6485));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 24,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 924, DateTimeKind.Local).AddTicks(6488));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 25,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 924, DateTimeKind.Local).AddTicks(6491));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 26,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 924, DateTimeKind.Local).AddTicks(6494));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 27,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 924, DateTimeKind.Local).AddTicks(6499));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 28,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 924, DateTimeKind.Local).AddTicks(6502));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 29,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 924, DateTimeKind.Local).AddTicks(6506));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 30,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 924, DateTimeKind.Local).AddTicks(6511));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 31,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 924, DateTimeKind.Local).AddTicks(6514));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 32,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 924, DateTimeKind.Local).AddTicks(6518));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 33,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 924, DateTimeKind.Local).AddTicks(6522));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 34,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 924, DateTimeKind.Local).AddTicks(6528));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 35,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 924, DateTimeKind.Local).AddTicks(6531));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 36,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 924, DateTimeKind.Local).AddTicks(6534));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 37,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 924, DateTimeKind.Local).AddTicks(6537));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 38,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 924, DateTimeKind.Local).AddTicks(6540));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 39,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 924, DateTimeKind.Local).AddTicks(6545));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 40,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 924, DateTimeKind.Local).AddTicks(6549));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 41,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 924, DateTimeKind.Local).AddTicks(6553));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 42,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 924, DateTimeKind.Local).AddTicks(6557));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 43,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 924, DateTimeKind.Local).AddTicks(6560));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 44,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 924, DateTimeKind.Local).AddTicks(6563));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 45,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 924, DateTimeKind.Local).AddTicks(6567));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 46,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 924, DateTimeKind.Local).AddTicks(6570));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 47,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 924, DateTimeKind.Local).AddTicks(6574));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 48,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 924, DateTimeKind.Local).AddTicks(6579));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 49,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 924, DateTimeKind.Local).AddTicks(6583));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 50,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 924, DateTimeKind.Local).AddTicks(6587));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 51,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 924, DateTimeKind.Local).AddTicks(6591));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 52,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 924, DateTimeKind.Local).AddTicks(6594));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 53,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 924, DateTimeKind.Local).AddTicks(6597));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 54,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 924, DateTimeKind.Local).AddTicks(6601));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 55,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 924, DateTimeKind.Local).AddTicks(6604));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 56,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 924, DateTimeKind.Local).AddTicks(6608));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 57,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 924, DateTimeKind.Local).AddTicks(6611));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 58,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 924, DateTimeKind.Local).AddTicks(6614));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 59,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 924, DateTimeKind.Local).AddTicks(6619));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 60,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 924, DateTimeKind.Local).AddTicks(6622));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 61,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 924, DateTimeKind.Local).AddTicks(6626));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 62,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 924, DateTimeKind.Local).AddTicks(6629));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 63,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 924, DateTimeKind.Local).AddTicks(6633));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 64,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 924, DateTimeKind.Local).AddTicks(6637));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 65,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 924, DateTimeKind.Local).AddTicks(6641));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 66,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 924, DateTimeKind.Local).AddTicks(6646));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 67,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 924, DateTimeKind.Local).AddTicks(6649));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 68,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 924, DateTimeKind.Local).AddTicks(6653));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 69,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 924, DateTimeKind.Local).AddTicks(6656));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 70,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 924, DateTimeKind.Local).AddTicks(6659));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 71,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 924, DateTimeKind.Local).AddTicks(6662));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 72,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 924, DateTimeKind.Local).AddTicks(6666));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 73,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 924, DateTimeKind.Local).AddTicks(6757));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 74,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 924, DateTimeKind.Local).AddTicks(6761));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 75,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 924, DateTimeKind.Local).AddTicks(6765));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 76,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 924, DateTimeKind.Local).AddTicks(6769));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 77,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 924, DateTimeKind.Local).AddTicks(6772));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 78,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 924, DateTimeKind.Local).AddTicks(6775));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 79,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 924, DateTimeKind.Local).AddTicks(6778));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 80,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 924, DateTimeKind.Local).AddTicks(6781));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 81,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 924, DateTimeKind.Local).AddTicks(6784));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 82,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 924, DateTimeKind.Local).AddTicks(6788));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 83,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 924, DateTimeKind.Local).AddTicks(6791));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 84,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 924, DateTimeKind.Local).AddTicks(6794));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 85,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 924, DateTimeKind.Local).AddTicks(6797));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 86,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 924, DateTimeKind.Local).AddTicks(6801));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 87,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 924, DateTimeKind.Local).AddTicks(6804));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 88,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 924, DateTimeKind.Local).AddTicks(6807));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 89,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 924, DateTimeKind.Local).AddTicks(6811));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 90,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 924, DateTimeKind.Local).AddTicks(6814));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 91,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 924, DateTimeKind.Local).AddTicks(6818));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 92,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 924, DateTimeKind.Local).AddTicks(6821));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 93,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 924, DateTimeKind.Local).AddTicks(6824));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 94,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 924, DateTimeKind.Local).AddTicks(6828));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 95,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 924, DateTimeKind.Local).AddTicks(6831));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 96,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 924, DateTimeKind.Local).AddTicks(6834));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 97,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 924, DateTimeKind.Local).AddTicks(6837));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 98,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 924, DateTimeKind.Local).AddTicks(6840));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 99,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 924, DateTimeKind.Local).AddTicks(6843));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 100,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 924, DateTimeKind.Local).AddTicks(6847));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 101,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 924, DateTimeKind.Local).AddTicks(6851));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 102,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 924, DateTimeKind.Local).AddTicks(6854));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 103,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 924, DateTimeKind.Local).AddTicks(6857));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 104,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 924, DateTimeKind.Local).AddTicks(6860));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 105,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 924, DateTimeKind.Local).AddTicks(6864));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 106,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 924, DateTimeKind.Local).AddTicks(6867));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 107,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 924, DateTimeKind.Local).AddTicks(6870));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 108,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 924, DateTimeKind.Local).AddTicks(6873));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 109,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 924, DateTimeKind.Local).AddTicks(6877));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 110,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 924, DateTimeKind.Local).AddTicks(6880));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 111,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 924, DateTimeKind.Local).AddTicks(6884));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 112,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 924, DateTimeKind.Local).AddTicks(6887));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 113,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 924, DateTimeKind.Local).AddTicks(6891));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 114,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 924, DateTimeKind.Local).AddTicks(6894));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 115,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 924, DateTimeKind.Local).AddTicks(6898));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 116,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 924, DateTimeKind.Local).AddTicks(6901));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 117,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 924, DateTimeKind.Local).AddTicks(6904));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 118,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 924, DateTimeKind.Local).AddTicks(6908));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 119,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 924, DateTimeKind.Local).AddTicks(6911));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 120,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 924, DateTimeKind.Local).AddTicks(6914));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 121,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 924, DateTimeKind.Local).AddTicks(6917));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 122,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 924, DateTimeKind.Local).AddTicks(6920));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 123,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 924, DateTimeKind.Local).AddTicks(6924));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 124,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 924, DateTimeKind.Local).AddTicks(6927));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 125,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 924, DateTimeKind.Local).AddTicks(6930));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 126,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 924, DateTimeKind.Local).AddTicks(6933));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 127,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 924, DateTimeKind.Local).AddTicks(6936));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 128,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 924, DateTimeKind.Local).AddTicks(6939));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 129,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 924, DateTimeKind.Local).AddTicks(6943));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 130,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 924, DateTimeKind.Local).AddTicks(6956));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 131,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 924, DateTimeKind.Local).AddTicks(6960));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 132,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 924, DateTimeKind.Local).AddTicks(6964));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 133,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 924, DateTimeKind.Local).AddTicks(6967));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 134,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 924, DateTimeKind.Local).AddTicks(6971));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 135,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 924, DateTimeKind.Local).AddTicks(6974));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 136,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 924, DateTimeKind.Local).AddTicks(6977));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 137,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 924, DateTimeKind.Local).AddTicks(6980));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 138,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 924, DateTimeKind.Local).AddTicks(6985));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 139,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 924, DateTimeKind.Local).AddTicks(6988));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 140,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 924, DateTimeKind.Local).AddTicks(6991));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 141,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 924, DateTimeKind.Local).AddTicks(6994));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 142,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 924, DateTimeKind.Local).AddTicks(6997));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 143,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 924, DateTimeKind.Local).AddTicks(7001));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 144,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 924, DateTimeKind.Local).AddTicks(7004));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 145,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 924, DateTimeKind.Local).AddTicks(7008));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 146,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 924, DateTimeKind.Local).AddTicks(7011));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 147,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 924, DateTimeKind.Local).AddTicks(7014));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 148,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 924, DateTimeKind.Local).AddTicks(7017));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 149,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 924, DateTimeKind.Local).AddTicks(7021));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 150,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 924, DateTimeKind.Local).AddTicks(7025));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 151,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 924, DateTimeKind.Local).AddTicks(7029));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 152,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 924, DateTimeKind.Local).AddTicks(7033));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 153,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 924, DateTimeKind.Local).AddTicks(7036));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 154,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 924, DateTimeKind.Local).AddTicks(7039));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 155,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 924, DateTimeKind.Local).AddTicks(7044));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 156,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 924, DateTimeKind.Local).AddTicks(7047));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 157,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 924, DateTimeKind.Local).AddTicks(7050));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 158,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 924, DateTimeKind.Local).AddTicks(7054));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 159,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 924, DateTimeKind.Local).AddTicks(7057));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 160,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 924, DateTimeKind.Local).AddTicks(7060));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 161,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 924, DateTimeKind.Local).AddTicks(7065));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 162,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 924, DateTimeKind.Local).AddTicks(7068));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 163,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 924, DateTimeKind.Local).AddTicks(7071));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 164,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 924, DateTimeKind.Local).AddTicks(7074));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 165,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 924, DateTimeKind.Local).AddTicks(7078));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 166,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 924, DateTimeKind.Local).AddTicks(7081));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 167,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 924, DateTimeKind.Local).AddTicks(7085));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 168,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 924, DateTimeKind.Local).AddTicks(7088));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 169,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 924, DateTimeKind.Local).AddTicks(7091));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 170,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 924, DateTimeKind.Local).AddTicks(7095));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 171,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 924, DateTimeKind.Local).AddTicks(7097));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 172,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 924, DateTimeKind.Local).AddTicks(7101));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 173,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 924, DateTimeKind.Local).AddTicks(7105));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 174,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 924, DateTimeKind.Local).AddTicks(7109));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 175,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 924, DateTimeKind.Local).AddTicks(7113));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 176,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 924, DateTimeKind.Local).AddTicks(7118));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 177,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 924, DateTimeKind.Local).AddTicks(7123));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 178,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 924, DateTimeKind.Local).AddTicks(7126));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 179,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 924, DateTimeKind.Local).AddTicks(7130));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 180,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 924, DateTimeKind.Local).AddTicks(7135));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 181,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 924, DateTimeKind.Local).AddTicks(7138));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 182,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 924, DateTimeKind.Local).AddTicks(7142));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 183,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 924, DateTimeKind.Local).AddTicks(7145));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 184,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 924, DateTimeKind.Local).AddTicks(7148));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 185,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 924, DateTimeKind.Local).AddTicks(7152));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 186,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 924, DateTimeKind.Local).AddTicks(7155));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 187,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 924, DateTimeKind.Local).AddTicks(7159));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 188,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 924, DateTimeKind.Local).AddTicks(7162));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 189,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 924, DateTimeKind.Local).AddTicks(7166));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 190,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 924, DateTimeKind.Local).AddTicks(7169));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 191,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 924, DateTimeKind.Local).AddTicks(7173));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 192,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 924, DateTimeKind.Local).AddTicks(7176));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 193,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 924, DateTimeKind.Local).AddTicks(7180));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 194,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 924, DateTimeKind.Local).AddTicks(7183));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 195,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 924, DateTimeKind.Local).AddTicks(7186));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 196,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 924, DateTimeKind.Local).AddTicks(7198));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 197,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 924, DateTimeKind.Local).AddTicks(7202));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 198,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 924, DateTimeKind.Local).AddTicks(7205));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 199,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 924, DateTimeKind.Local).AddTicks(7208));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 200,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 924, DateTimeKind.Local).AddTicks(7211));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 201,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 924, DateTimeKind.Local).AddTicks(7215));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 202,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 924, DateTimeKind.Local).AddTicks(7218));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 203,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 924, DateTimeKind.Local).AddTicks(7221));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 204,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 924, DateTimeKind.Local).AddTicks(7224));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 205,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 924, DateTimeKind.Local).AddTicks(7227));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 206,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 924, DateTimeKind.Local).AddTicks(7231));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 207,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 924, DateTimeKind.Local).AddTicks(7235));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 208,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 924, DateTimeKind.Local).AddTicks(7238));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 209,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 924, DateTimeKind.Local).AddTicks(7241));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 210,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 924, DateTimeKind.Local).AddTicks(7245));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 211,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 924, DateTimeKind.Local).AddTicks(7249));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 212,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 924, DateTimeKind.Local).AddTicks(7252));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 213,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 924, DateTimeKind.Local).AddTicks(7255));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 214,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 924, DateTimeKind.Local).AddTicks(7259));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 215,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 924, DateTimeKind.Local).AddTicks(7263));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 216,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 924, DateTimeKind.Local).AddTicks(7267));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 217,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 924, DateTimeKind.Local).AddTicks(7270));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 218,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 924, DateTimeKind.Local).AddTicks(7273));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 219,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 924, DateTimeKind.Local).AddTicks(7277));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 220,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 924, DateTimeKind.Local).AddTicks(7280));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 221,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 924, DateTimeKind.Local).AddTicks(7283));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 222,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 924, DateTimeKind.Local).AddTicks(7287));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 223,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 924, DateTimeKind.Local).AddTicks(7290));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 224,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 924, DateTimeKind.Local).AddTicks(7294));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 225,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 924, DateTimeKind.Local).AddTicks(7298));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 226,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 924, DateTimeKind.Local).AddTicks(7301));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 227,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 924, DateTimeKind.Local).AddTicks(7304));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 228,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 924, DateTimeKind.Local).AddTicks(7308));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 907, DateTimeKind.Local).AddTicks(1809));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 907, DateTimeKind.Local).AddTicks(2505));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 907, DateTimeKind.Local).AddTicks(2514));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 907, DateTimeKind.Local).AddTicks(2520));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 907, DateTimeKind.Local).AddTicks(2525));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 907, DateTimeKind.Local).AddTicks(2539));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 907, DateTimeKind.Local).AddTicks(2544));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 907, DateTimeKind.Local).AddTicks(2549));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 907, DateTimeKind.Local).AddTicks(2554));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 907, DateTimeKind.Local).AddTicks(2561));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 907, DateTimeKind.Local).AddTicks(2566));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 907, DateTimeKind.Local).AddTicks(2571));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 13,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 907, DateTimeKind.Local).AddTicks(2577));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 14,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 907, DateTimeKind.Local).AddTicks(2582));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 15,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 907, DateTimeKind.Local).AddTicks(2587));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 16,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 907, DateTimeKind.Local).AddTicks(2592));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 17,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 907, DateTimeKind.Local).AddTicks(2597));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 18,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 907, DateTimeKind.Local).AddTicks(2604));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 19,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 907, DateTimeKind.Local).AddTicks(2610));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 20,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 907, DateTimeKind.Local).AddTicks(2614));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 21,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 907, DateTimeKind.Local).AddTicks(2619));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 22,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 907, DateTimeKind.Local).AddTicks(2624));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 23,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 907, DateTimeKind.Local).AddTicks(2630));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 24,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 907, DateTimeKind.Local).AddTicks(2635));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 25,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 907, DateTimeKind.Local).AddTicks(2639));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 26,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 907, DateTimeKind.Local).AddTicks(2644));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 27,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 907, DateTimeKind.Local).AddTicks(2649));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 28,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 907, DateTimeKind.Local).AddTicks(2654));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 29,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 907, DateTimeKind.Local).AddTicks(2660));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 30,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 907, DateTimeKind.Local).AddTicks(2665));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 31,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 907, DateTimeKind.Local).AddTicks(2671));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 32,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 907, DateTimeKind.Local).AddTicks(2676));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 33,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 907, DateTimeKind.Local).AddTicks(2681));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 34,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 907, DateTimeKind.Local).AddTicks(2688));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 35,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 907, DateTimeKind.Local).AddTicks(2692));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 36,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 907, DateTimeKind.Local).AddTicks(2697));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 37,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 907, DateTimeKind.Local).AddTicks(2701));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 38,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 907, DateTimeKind.Local).AddTicks(2705));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 39,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 907, DateTimeKind.Local).AddTicks(2711));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 40,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 907, DateTimeKind.Local).AddTicks(2716));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 41,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 907, DateTimeKind.Local).AddTicks(2747));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 42,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 907, DateTimeKind.Local).AddTicks(2752));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 43,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 907, DateTimeKind.Local).AddTicks(2757));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 44,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 907, DateTimeKind.Local).AddTicks(2762));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 45,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 907, DateTimeKind.Local).AddTicks(2766));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 46,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 907, DateTimeKind.Local).AddTicks(2772));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 47,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 907, DateTimeKind.Local).AddTicks(2776));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 48,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 907, DateTimeKind.Local).AddTicks(2780));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 49,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 907, DateTimeKind.Local).AddTicks(2787));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 50,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 907, DateTimeKind.Local).AddTicks(2791));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 51,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 907, DateTimeKind.Local).AddTicks(2797));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 52,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 907, DateTimeKind.Local).AddTicks(2802));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 53,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 907, DateTimeKind.Local).AddTicks(2807));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 54,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 907, DateTimeKind.Local).AddTicks(2812));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 55,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 907, DateTimeKind.Local).AddTicks(2817));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 56,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 907, DateTimeKind.Local).AddTicks(2822));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 57,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 907, DateTimeKind.Local).AddTicks(2828));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 58,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 907, DateTimeKind.Local).AddTicks(2832));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 59,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 907, DateTimeKind.Local).AddTicks(2837));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 60,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 907, DateTimeKind.Local).AddTicks(2843));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 61,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 907, DateTimeKind.Local).AddTicks(2847));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 62,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 907, DateTimeKind.Local).AddTicks(2852));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 63,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 907, DateTimeKind.Local).AddTicks(2857));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 64,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 907, DateTimeKind.Local).AddTicks(2866));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 65,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 907, DateTimeKind.Local).AddTicks(2870));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 66,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 907, DateTimeKind.Local).AddTicks(2879));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 67,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 907, DateTimeKind.Local).AddTicks(2884));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 68,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 907, DateTimeKind.Local).AddTicks(2889));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 69,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 907, DateTimeKind.Local).AddTicks(2893));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 70,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 907, DateTimeKind.Local).AddTicks(2898));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 71,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 907, DateTimeKind.Local).AddTicks(2904));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 72,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 907, DateTimeKind.Local).AddTicks(2908));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 73,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 907, DateTimeKind.Local).AddTicks(2913));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 74,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 907, DateTimeKind.Local).AddTicks(2918));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 75,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 907, DateTimeKind.Local).AddTicks(2922));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 76,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 907, DateTimeKind.Local).AddTicks(2927));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 77,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 907, DateTimeKind.Local).AddTicks(2932));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 78,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 907, DateTimeKind.Local).AddTicks(2937));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 79,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 907, DateTimeKind.Local).AddTicks(2942));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 80,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 907, DateTimeKind.Local).AddTicks(2946));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 81,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 907, DateTimeKind.Local).AddTicks(2950));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 82,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 907, DateTimeKind.Local).AddTicks(2956));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 83,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 907, DateTimeKind.Local).AddTicks(2961));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 84,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 907, DateTimeKind.Local).AddTicks(2965));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 85,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 907, DateTimeKind.Local).AddTicks(2971));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 86,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 907, DateTimeKind.Local).AddTicks(2976));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 87,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 907, DateTimeKind.Local).AddTicks(2982));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 88,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 907, DateTimeKind.Local).AddTicks(2986));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 89,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 907, DateTimeKind.Local).AddTicks(2990));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 90,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 907, DateTimeKind.Local).AddTicks(2994));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 91,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 907, DateTimeKind.Local).AddTicks(2999));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 92,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 907, DateTimeKind.Local).AddTicks(3005));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 93,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 907, DateTimeKind.Local).AddTicks(3011));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 94,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 907, DateTimeKind.Local).AddTicks(3015));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 95,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 907, DateTimeKind.Local).AddTicks(3020));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 96,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 907, DateTimeKind.Local).AddTicks(3025));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 97,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 907, DateTimeKind.Local).AddTicks(3030));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 98,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 907, DateTimeKind.Local).AddTicks(3034));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 99,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 907, DateTimeKind.Local).AddTicks(3039));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 100,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 907, DateTimeKind.Local).AddTicks(3043));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 101,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 907, DateTimeKind.Local).AddTicks(3048));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 102,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 907, DateTimeKind.Local).AddTicks(3053));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 103,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 907, DateTimeKind.Local).AddTicks(3058));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 104,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 907, DateTimeKind.Local).AddTicks(3063));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 105,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 907, DateTimeKind.Local).AddTicks(3067));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 106,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 907, DateTimeKind.Local).AddTicks(3072));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 107,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 907, DateTimeKind.Local).AddTicks(3076));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 108,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 907, DateTimeKind.Local).AddTicks(3081));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 109,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 907, DateTimeKind.Local).AddTicks(3100));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 110,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 907, DateTimeKind.Local).AddTicks(3108));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 111,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 907, DateTimeKind.Local).AddTicks(3113));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 112,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 907, DateTimeKind.Local).AddTicks(3118));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 113,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 907, DateTimeKind.Local).AddTicks(3123));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 114,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 907, DateTimeKind.Local).AddTicks(3128));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 115,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 907, DateTimeKind.Local).AddTicks(3132));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 116,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 907, DateTimeKind.Local).AddTicks(3137));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 117,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 907, DateTimeKind.Local).AddTicks(3142));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 118,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 907, DateTimeKind.Local).AddTicks(3146));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 119,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 907, DateTimeKind.Local).AddTicks(3151));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 120,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 907, DateTimeKind.Local).AddTicks(3155));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 121,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 907, DateTimeKind.Local).AddTicks(3160));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 122,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 907, DateTimeKind.Local).AddTicks(3165));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 123,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 907, DateTimeKind.Local).AddTicks(3170));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 124,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 907, DateTimeKind.Local).AddTicks(3174));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 125,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 907, DateTimeKind.Local).AddTicks(3180));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 126,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 907, DateTimeKind.Local).AddTicks(3184));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 127,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 907, DateTimeKind.Local).AddTicks(3189));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 128,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 907, DateTimeKind.Local).AddTicks(3194));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 129,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 907, DateTimeKind.Local).AddTicks(3198));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 130,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 907, DateTimeKind.Local).AddTicks(3206));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 131,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 907, DateTimeKind.Local).AddTicks(3210));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 132,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 907, DateTimeKind.Local).AddTicks(3214));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 133,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 907, DateTimeKind.Local).AddTicks(3219));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 134,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 907, DateTimeKind.Local).AddTicks(3226));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 135,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 907, DateTimeKind.Local).AddTicks(3231));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 136,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 907, DateTimeKind.Local).AddTicks(3235));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 137,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 907, DateTimeKind.Local).AddTicks(3240));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 138,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 907, DateTimeKind.Local).AddTicks(3244));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 139,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 907, DateTimeKind.Local).AddTicks(3249));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 140,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 907, DateTimeKind.Local).AddTicks(3254));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 141,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 907, DateTimeKind.Local).AddTicks(3258));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 142,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 907, DateTimeKind.Local).AddTicks(3263));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 143,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 907, DateTimeKind.Local).AddTicks(3267));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 144,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 907, DateTimeKind.Local).AddTicks(3272));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 145,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 907, DateTimeKind.Local).AddTicks(3277));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 146,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 907, DateTimeKind.Local).AddTicks(3281));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 147,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 907, DateTimeKind.Local).AddTicks(3285));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 148,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 907, DateTimeKind.Local).AddTicks(3291));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 149,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 907, DateTimeKind.Local).AddTicks(3295));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 150,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 907, DateTimeKind.Local).AddTicks(3299));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 151,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 907, DateTimeKind.Local).AddTicks(3304));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 152,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 907, DateTimeKind.Local).AddTicks(3308));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 153,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 907, DateTimeKind.Local).AddTicks(3312));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 154,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 907, DateTimeKind.Local).AddTicks(3317));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 155,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 907, DateTimeKind.Local).AddTicks(3321));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 156,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 907, DateTimeKind.Local).AddTicks(3326));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 157,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 907, DateTimeKind.Local).AddTicks(3330));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 158,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 907, DateTimeKind.Local).AddTicks(3336));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 159,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 907, DateTimeKind.Local).AddTicks(3341));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 160,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 907, DateTimeKind.Local).AddTicks(3346));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 161,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 907, DateTimeKind.Local).AddTicks(3350));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 162,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 907, DateTimeKind.Local).AddTicks(3354));

            migrationBuilder.UpdateData(
                table: "CustomSettingTypes",
                keyColumn: "CustomSettingTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 920, DateTimeKind.Local).AddTicks(1308));

            migrationBuilder.UpdateData(
                table: "CustomSettingTypes",
                keyColumn: "CustomSettingTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 920, DateTimeKind.Local).AddTicks(1434));

            migrationBuilder.UpdateData(
                table: "CustomSettingTypes",
                keyColumn: "CustomSettingTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 920, DateTimeKind.Local).AddTicks(1439));

            migrationBuilder.UpdateData(
                table: "CustomSettingTypes",
                keyColumn: "CustomSettingTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 920, DateTimeKind.Local).AddTicks(1443));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 959, DateTimeKind.Local).AddTicks(1853));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 959, DateTimeKind.Local).AddTicks(2121));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 959, DateTimeKind.Local).AddTicks(2156));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 959, DateTimeKind.Local).AddTicks(2168));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 959, DateTimeKind.Local).AddTicks(2177));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 959, DateTimeKind.Local).AddTicks(2132));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 959, DateTimeKind.Local).AddTicks(2191));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 959, DateTimeKind.Local).AddTicks(2200));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 959, DateTimeKind.Local).AddTicks(2209));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 959, DateTimeKind.Local).AddTicks(2216));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 959, DateTimeKind.Local).AddTicks(2225));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 959, DateTimeKind.Local).AddTicks(2236));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 13,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 959, DateTimeKind.Local).AddTicks(2309));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 14,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 959, DateTimeKind.Local).AddTicks(2349));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 15,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 959, DateTimeKind.Local).AddTicks(2359));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 16,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 959, DateTimeKind.Local).AddTicks(2369));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 17,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 959, DateTimeKind.Local).AddTicks(2139));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 18,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 959, DateTimeKind.Local).AddTicks(2111));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 19,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 959, DateTimeKind.Local).AddTicks(2377));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 20,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 959, DateTimeKind.Local).AddTicks(2385));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 21,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 959, DateTimeKind.Local).AddTicks(2391));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 22,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 959, DateTimeKind.Local).AddTicks(2399));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 23,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 959, DateTimeKind.Local).AddTicks(2406));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 25,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 959, DateTimeKind.Local).AddTicks(2452));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 26,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 959, DateTimeKind.Local).AddTicks(2414));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 27,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 959, DateTimeKind.Local).AddTicks(2423));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 28,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 959, DateTimeKind.Local).AddTicks(2437));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 29,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 959, DateTimeKind.Local).AddTicks(2430));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 30,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 959, DateTimeKind.Local).AddTicks(2445));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 31,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 959, DateTimeKind.Local).AddTicks(2462));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 32,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 959, DateTimeKind.Local).AddTicks(2470));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 33,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 959, DateTimeKind.Local).AddTicks(2476));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 34,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 959, DateTimeKind.Local).AddTicks(2482));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 35,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 959, DateTimeKind.Local).AddTicks(2495));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 36,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 959, DateTimeKind.Local).AddTicks(2502));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 37,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 959, DateTimeKind.Local).AddTicks(2509));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 38,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 959, DateTimeKind.Local).AddTicks(2516));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 39,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 959, DateTimeKind.Local).AddTicks(2524));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 40,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 959, DateTimeKind.Local).AddTicks(2531));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 41,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 959, DateTimeKind.Local).AddTicks(2537));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 42,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 959, DateTimeKind.Local).AddTicks(2544));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 43,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 959, DateTimeKind.Local).AddTicks(2551));

            migrationBuilder.UpdateData(
                table: "DocumentFormats",
                keyColumn: "DocumentFormatID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 935, DateTimeKind.Local).AddTicks(1854));

            migrationBuilder.UpdateData(
                table: "DocumentFormats",
                keyColumn: "DocumentFormatID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 935, DateTimeKind.Local).AddTicks(2546));

            migrationBuilder.UpdateData(
                table: "DocumentFormats",
                keyColumn: "DocumentFormatID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 935, DateTimeKind.Local).AddTicks(2557));

            migrationBuilder.UpdateData(
                table: "DocumentFormats",
                keyColumn: "DocumentFormatID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 935, DateTimeKind.Local).AddTicks(2563));

            migrationBuilder.UpdateData(
                table: "DocumentFormats",
                keyColumn: "DocumentFormatID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 935, DateTimeKind.Local).AddTicks(2568));

            migrationBuilder.UpdateData(
                table: "DocumentFormats",
                keyColumn: "DocumentFormatID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 935, DateTimeKind.Local).AddTicks(2580));

            migrationBuilder.UpdateData(
                table: "DocumentTypes",
                keyColumn: "DocumentTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 939, DateTimeKind.Local).AddTicks(595));

            migrationBuilder.UpdateData(
                table: "DocumentTypes",
                keyColumn: "DocumentTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 939, DateTimeKind.Local).AddTicks(2219));

            migrationBuilder.UpdateData(
                table: "DocumentTypes",
                keyColumn: "DocumentTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 939, DateTimeKind.Local).AddTicks(2256));

            migrationBuilder.UpdateData(
                table: "DocumentTypes",
                keyColumn: "DocumentTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 939, DateTimeKind.Local).AddTicks(2263));

            migrationBuilder.UpdateData(
                table: "EmailTypes",
                keyColumn: "EmailTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 953, DateTimeKind.Local).AddTicks(322));

            migrationBuilder.UpdateData(
                table: "EmailTypes",
                keyColumn: "EmailTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 953, DateTimeKind.Local).AddTicks(892));

            migrationBuilder.UpdateData(
                table: "EmailTypes",
                keyColumn: "EmailTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 953, DateTimeKind.Local).AddTicks(905));

            migrationBuilder.UpdateData(
                table: "EmailTypes",
                keyColumn: "EmailTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 953, DateTimeKind.Local).AddTicks(911));

            migrationBuilder.UpdateData(
                table: "FeatureFlags",
                keyColumn: "FeatureFlagID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 932, DateTimeKind.Local).AddTicks(1548));

            migrationBuilder.UpdateData(
                table: "FeatureFlags",
                keyColumn: "FeatureFlagID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 932, DateTimeKind.Local).AddTicks(2157));

            migrationBuilder.UpdateData(
                table: "FeatureFlags",
                keyColumn: "FeatureFlagID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 932, DateTimeKind.Local).AddTicks(2169));

            migrationBuilder.UpdateData(
                table: "Frequencies",
                keyColumn: "FrequencyID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 912, DateTimeKind.Local).AddTicks(2927));

            migrationBuilder.UpdateData(
                table: "Frequencies",
                keyColumn: "FrequencyID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 912, DateTimeKind.Local).AddTicks(3698));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "GenderID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 922, DateTimeKind.Local).AddTicks(475));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "GenderID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 922, DateTimeKind.Local).AddTicks(575));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 942, DateTimeKind.Local).AddTicks(4611));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 942, DateTimeKind.Local).AddTicks(5455));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 942, DateTimeKind.Local).AddTicks(5471));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 942, DateTimeKind.Local).AddTicks(5486));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 942, DateTimeKind.Local).AddTicks(5478));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 999,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 942, DateTimeKind.Local).AddTicks(5554));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 9998,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 942, DateTimeKind.Local).AddTicks(5505));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 945, DateTimeKind.Local).AddTicks(7078));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 945, DateTimeKind.Local).AddTicks(7350));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 945, DateTimeKind.Local).AddTicks(7360));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 945, DateTimeKind.Local).AddTicks(7366));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 945, DateTimeKind.Local).AddTicks(7372));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 945, DateTimeKind.Local).AddTicks(7389));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 945, DateTimeKind.Local).AddTicks(7394));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 945, DateTimeKind.Local).AddTicks(7399));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 945, DateTimeKind.Local).AddTicks(7404));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 945, DateTimeKind.Local).AddTicks(7411));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 945, DateTimeKind.Local).AddTicks(7415));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 945, DateTimeKind.Local).AddTicks(7420));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 13,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 945, DateTimeKind.Local).AddTicks(7425));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 14,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 945, DateTimeKind.Local).AddTicks(7430));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 15,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 945, DateTimeKind.Local).AddTicks(7435));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 16,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 945, DateTimeKind.Local).AddTicks(7440));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 17,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 945, DateTimeKind.Local).AddTicks(7446));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 18,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 945, DateTimeKind.Local).AddTicks(7454));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 19,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 945, DateTimeKind.Local).AddTicks(7459));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 20,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 945, DateTimeKind.Local).AddTicks(7463));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 21,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 945, DateTimeKind.Local).AddTicks(7468));

            migrationBuilder.UpdateData(
                table: "PaymentStatus",
                keyColumn: "PaymentStatusID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 893, DateTimeKind.Local).AddTicks(3124));

            migrationBuilder.UpdateData(
                table: "PaymentStatus",
                keyColumn: "PaymentStatusID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 893, DateTimeKind.Local).AddTicks(3599));

            migrationBuilder.UpdateData(
                table: "PaymentStatus",
                keyColumn: "PaymentStatusID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 893, DateTimeKind.Local).AddTicks(3607));

            migrationBuilder.UpdateData(
                table: "PaymentStatus",
                keyColumn: "PaymentStatusID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 893, DateTimeKind.Local).AddTicks(3611));

            migrationBuilder.UpdateData(
                table: "PaymentStatus",
                keyColumn: "PaymentStatusID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 893, DateTimeKind.Local).AddTicks(3614));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 887, DateTimeKind.Local).AddTicks(5771));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 887, DateTimeKind.Local).AddTicks(6446));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 887, DateTimeKind.Local).AddTicks(6460));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 887, DateTimeKind.Local).AddTicks(6466));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 887, DateTimeKind.Local).AddTicks(6474));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 887, DateTimeKind.Local).AddTicks(6488));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 887, DateTimeKind.Local).AddTicks(6495));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 887, DateTimeKind.Local).AddTicks(6501));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 887, DateTimeKind.Local).AddTicks(6548));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 887, DateTimeKind.Local).AddTicks(6558));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 887, DateTimeKind.Local).AddTicks(6565));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 887, DateTimeKind.Local).AddTicks(6573));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 13,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 887, DateTimeKind.Local).AddTicks(6579));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 14,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 887, DateTimeKind.Local).AddTicks(6585));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 15,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 887, DateTimeKind.Local).AddTicks(6592));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 16,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 887, DateTimeKind.Local).AddTicks(6598));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 17,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 887, DateTimeKind.Local).AddTicks(6605));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 18,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 887, DateTimeKind.Local).AddTicks(6613));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 19,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 887, DateTimeKind.Local).AddTicks(6621));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 20,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 887, DateTimeKind.Local).AddTicks(6627));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 21,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 887, DateTimeKind.Local).AddTicks(6633));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 22,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 887, DateTimeKind.Local).AddTicks(6638));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 23,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 887, DateTimeKind.Local).AddTicks(6646));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 24,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 887, DateTimeKind.Local).AddTicks(6652));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 25,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 887, DateTimeKind.Local).AddTicks(6659));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 26,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 887, DateTimeKind.Local).AddTicks(6666));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 27,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 887, DateTimeKind.Local).AddTicks(6675));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 28,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 887, DateTimeKind.Local).AddTicks(6681));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 29,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 887, DateTimeKind.Local).AddTicks(6688));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 30,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 887, DateTimeKind.Local).AddTicks(6694));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 31,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 887, DateTimeKind.Local).AddTicks(6702));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 32,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 887, DateTimeKind.Local).AddTicks(6708));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 33,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 887, DateTimeKind.Local).AddTicks(6714));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 34,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 887, DateTimeKind.Local).AddTicks(6724));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 35,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 887, DateTimeKind.Local).AddTicks(6731));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 36,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 887, DateTimeKind.Local).AddTicks(6737));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 37,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 887, DateTimeKind.Local).AddTicks(6745));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 38,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 887, DateTimeKind.Local).AddTicks(6751));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 39,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 887, DateTimeKind.Local).AddTicks(6757));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 40,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 887, DateTimeKind.Local).AddTicks(6765));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 41,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 887, DateTimeKind.Local).AddTicks(6770));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 42,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 887, DateTimeKind.Local).AddTicks(6777));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 43,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 887, DateTimeKind.Local).AddTicks(6783));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 44,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 887, DateTimeKind.Local).AddTicks(6789));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 45,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 887, DateTimeKind.Local).AddTicks(6795));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 46,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 887, DateTimeKind.Local).AddTicks(6801));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 47,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 887, DateTimeKind.Local).AddTicks(6807));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 48,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 887, DateTimeKind.Local).AddTicks(6829));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 49,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 887, DateTimeKind.Local).AddTicks(6835));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 50,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 887, DateTimeKind.Local).AddTicks(6843));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 51,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 887, DateTimeKind.Local).AddTicks(6849));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 52,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 887, DateTimeKind.Local).AddTicks(6855));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 53,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 887, DateTimeKind.Local).AddTicks(6861));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 54,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 887, DateTimeKind.Local).AddTicks(6867));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 55,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 887, DateTimeKind.Local).AddTicks(6873));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 56,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 887, DateTimeKind.Local).AddTicks(6880));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 57,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 887, DateTimeKind.Local).AddTicks(6886));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 58,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 887, DateTimeKind.Local).AddTicks(6892));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 59,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 887, DateTimeKind.Local).AddTicks(6898));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 60,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 887, DateTimeKind.Local).AddTicks(6904));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 61,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 887, DateTimeKind.Local).AddTicks(6910));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 62,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 887, DateTimeKind.Local).AddTicks(6917));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 63,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 887, DateTimeKind.Local).AddTicks(6923));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 64,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 887, DateTimeKind.Local).AddTicks(6929));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 65,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 887, DateTimeKind.Local).AddTicks(6934));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 66,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 887, DateTimeKind.Local).AddTicks(6943));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 67,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 887, DateTimeKind.Local).AddTicks(6949));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 68,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 887, DateTimeKind.Local).AddTicks(6955));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 69,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 887, DateTimeKind.Local).AddTicks(6960));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 70,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 887, DateTimeKind.Local).AddTicks(6966));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 71,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 887, DateTimeKind.Local).AddTicks(6971));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 72,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 887, DateTimeKind.Local).AddTicks(6977));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 73,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 887, DateTimeKind.Local).AddTicks(6984));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 74,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 887, DateTimeKind.Local).AddTicks(6990));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 75,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 887, DateTimeKind.Local).AddTicks(6996));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 76,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 887, DateTimeKind.Local).AddTicks(7002));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 77,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 887, DateTimeKind.Local).AddTicks(7008));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 78,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 887, DateTimeKind.Local).AddTicks(7013));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 79,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 887, DateTimeKind.Local).AddTicks(7019));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 80,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 887, DateTimeKind.Local).AddTicks(7025));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 81,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 887, DateTimeKind.Local).AddTicks(7032));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 82,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 887, DateTimeKind.Local).AddTicks(7038));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 83,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 887, DateTimeKind.Local).AddTicks(7045));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 84,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 887, DateTimeKind.Local).AddTicks(7052));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 85,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 887, DateTimeKind.Local).AddTicks(7058));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 86,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 887, DateTimeKind.Local).AddTicks(7064));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 87,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 887, DateTimeKind.Local).AddTicks(7071));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 88,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 887, DateTimeKind.Local).AddTicks(7077));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 89,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 887, DateTimeKind.Local).AddTicks(7095));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 90,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 887, DateTimeKind.Local).AddTicks(7101));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 91,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 887, DateTimeKind.Local).AddTicks(7109));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 92,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 887, DateTimeKind.Local).AddTicks(7116));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 93,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 887, DateTimeKind.Local).AddTicks(7122));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 94,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 887, DateTimeKind.Local).AddTicks(7129));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 95,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 887, DateTimeKind.Local).AddTicks(7135));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 96,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 887, DateTimeKind.Local).AddTicks(7141));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 97,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 887, DateTimeKind.Local).AddTicks(7148));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 98,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 887, DateTimeKind.Local).AddTicks(7154));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 99,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 887, DateTimeKind.Local).AddTicks(7160));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 100,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 887, DateTimeKind.Local).AddTicks(7166));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 101,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 887, DateTimeKind.Local).AddTicks(7171));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 102,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 887, DateTimeKind.Local).AddTicks(7177));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 103,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 887, DateTimeKind.Local).AddTicks(7182));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 104,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 887, DateTimeKind.Local).AddTicks(7189));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 105,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 887, DateTimeKind.Local).AddTicks(7196));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 106,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 887, DateTimeKind.Local).AddTicks(7204));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 107,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 887, DateTimeKind.Local).AddTicks(7211));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 108,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 887, DateTimeKind.Local).AddTicks(7217));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 109,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 887, DateTimeKind.Local).AddTicks(7224));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 110,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 887, DateTimeKind.Local).AddTicks(7232));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 111,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 887, DateTimeKind.Local).AddTicks(7239));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 112,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 887, DateTimeKind.Local).AddTicks(7246));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 113,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 887, DateTimeKind.Local).AddTicks(7253));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 114,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 887, DateTimeKind.Local).AddTicks(7259));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 115,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 887, DateTimeKind.Local).AddTicks(7266));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 116,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 887, DateTimeKind.Local).AddTicks(7271));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 117,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 887, DateTimeKind.Local).AddTicks(7277));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 118,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 887, DateTimeKind.Local).AddTicks(7283));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 119,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 887, DateTimeKind.Local).AddTicks(7292));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 120,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 887, DateTimeKind.Local).AddTicks(7299));

            migrationBuilder.UpdateData(
                table: "PriorityRanks",
                keyColumn: "PriorityRankID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 925, DateTimeKind.Local).AddTicks(6084));

            migrationBuilder.UpdateData(
                table: "PriorityRanks",
                keyColumn: "PriorityRankID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 925, DateTimeKind.Local).AddTicks(6199));

            migrationBuilder.UpdateData(
                table: "PriorityRanks",
                keyColumn: "PriorityRankID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 925, DateTimeKind.Local).AddTicks(6204));

            migrationBuilder.UpdateData(
                table: "PriorityRanks",
                keyColumn: "PriorityRankID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 925, DateTimeKind.Local).AddTicks(6208));

            migrationBuilder.UpdateData(
                table: "RelationshipTypes",
                keyColumn: "RelationshipTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 918, DateTimeKind.Local).AddTicks(7797));

            migrationBuilder.UpdateData(
                table: "RelationshipTypes",
                keyColumn: "RelationshipTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 918, DateTimeKind.Local).AddTicks(8051));

            migrationBuilder.UpdateData(
                table: "RelationshipTypes",
                keyColumn: "RelationshipTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 918, DateTimeKind.Local).AddTicks(8056));

            migrationBuilder.UpdateData(
                table: "RelationshipTypes",
                keyColumn: "RelationshipTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 918, DateTimeKind.Local).AddTicks(8060));

            migrationBuilder.UpdateData(
                table: "RelationshipTypes",
                keyColumn: "RelationshipTypeID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 918, DateTimeKind.Local).AddTicks(8063));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 960, DateTimeKind.Local).AddTicks(774));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 960, DateTimeKind.Local).AddTicks(1436));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 960, DateTimeKind.Local).AddTicks(1443));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 960, DateTimeKind.Local).AddTicks(1446));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 960, DateTimeKind.Local).AddTicks(1448));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 960, DateTimeKind.Local).AddTicks(1456));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 960, DateTimeKind.Local).AddTicks(1458));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 960, DateTimeKind.Local).AddTicks(1461));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 960, DateTimeKind.Local).AddTicks(1463));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 960, DateTimeKind.Local).AddTicks(1467));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 960, DateTimeKind.Local).AddTicks(1470));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 960, DateTimeKind.Local).AddTicks(1472));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 13,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 960, DateTimeKind.Local).AddTicks(1474));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 14,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 960, DateTimeKind.Local).AddTicks(1476));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 15,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 960, DateTimeKind.Local).AddTicks(1479));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 16,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 960, DateTimeKind.Local).AddTicks(1481));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 17,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 960, DateTimeKind.Local).AddTicks(1483));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 18,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 960, DateTimeKind.Local).AddTicks(1487));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 19,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 960, DateTimeKind.Local).AddTicks(1490));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 20,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 960, DateTimeKind.Local).AddTicks(1492));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 21,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 960, DateTimeKind.Local).AddTicks(1494));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 888, DateTimeKind.Local).AddTicks(8342));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 888, DateTimeKind.Local).AddTicks(8594));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 888, DateTimeKind.Local).AddTicks(8601));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 888, DateTimeKind.Local).AddTicks(8605));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 888, DateTimeKind.Local).AddTicks(8608));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 888, DateTimeKind.Local).AddTicks(8619));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 888, DateTimeKind.Local).AddTicks(8623));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 888, DateTimeKind.Local).AddTicks(8627));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 888, DateTimeKind.Local).AddTicks(8630));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 888, DateTimeKind.Local).AddTicks(8635));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 888, DateTimeKind.Local).AddTicks(8637));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 888, DateTimeKind.Local).AddTicks(8639));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 13,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 888, DateTimeKind.Local).AddTicks(8642));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 14,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 888, DateTimeKind.Local).AddTicks(8644));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 15,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 888, DateTimeKind.Local).AddTicks(8646));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 16,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 888, DateTimeKind.Local).AddTicks(8648));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 17,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 888, DateTimeKind.Local).AddTicks(8651));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 18,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 888, DateTimeKind.Local).AddTicks(8654));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 19,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 888, DateTimeKind.Local).AddTicks(8657));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 20,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 888, DateTimeKind.Local).AddTicks(8661));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 21,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 888, DateTimeKind.Local).AddTicks(8664));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 22,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 888, DateTimeKind.Local).AddTicks(8666));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 23,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 888, DateTimeKind.Local).AddTicks(8670));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 24,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 888, DateTimeKind.Local).AddTicks(8672));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 25,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 888, DateTimeKind.Local).AddTicks(8675));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 26,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 888, DateTimeKind.Local).AddTicks(8678));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 27,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 888, DateTimeKind.Local).AddTicks(8680));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 28,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 888, DateTimeKind.Local).AddTicks(8684));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 29,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 888, DateTimeKind.Local).AddTicks(8687));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 30,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 888, DateTimeKind.Local).AddTicks(8690));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 31,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 888, DateTimeKind.Local).AddTicks(8692));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 32,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 888, DateTimeKind.Local).AddTicks(8695));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 33,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 888, DateTimeKind.Local).AddTicks(8697));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 34,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 888, DateTimeKind.Local).AddTicks(8703));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 35,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 888, DateTimeKind.Local).AddTicks(8707));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 36,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 888, DateTimeKind.Local).AddTicks(8710));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 37,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 888, DateTimeKind.Local).AddTicks(8713));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 38,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 888, DateTimeKind.Local).AddTicks(8715));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 39,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 888, DateTimeKind.Local).AddTicks(8719));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 40,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 888, DateTimeKind.Local).AddTicks(8826));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 41,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 888, DateTimeKind.Local).AddTicks(8831));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 42,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 888, DateTimeKind.Local).AddTicks(8836));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 43,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 888, DateTimeKind.Local).AddTicks(8839));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 44,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 888, DateTimeKind.Local).AddTicks(8842));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 45,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 888, DateTimeKind.Local).AddTicks(8844));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 46,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 888, DateTimeKind.Local).AddTicks(8847));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 47,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 888, DateTimeKind.Local).AddTicks(8849));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 48,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 888, DateTimeKind.Local).AddTicks(8852));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 49,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 888, DateTimeKind.Local).AddTicks(8854));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 50,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 888, DateTimeKind.Local).AddTicks(8857));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 51,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 888, DateTimeKind.Local).AddTicks(8859));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 52,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 888, DateTimeKind.Local).AddTicks(8862));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 53,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 888, DateTimeKind.Local).AddTicks(8864));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 54,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 888, DateTimeKind.Local).AddTicks(8867));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 55,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 888, DateTimeKind.Local).AddTicks(8869));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 56,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 888, DateTimeKind.Local).AddTicks(8871));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 57,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 888, DateTimeKind.Local).AddTicks(8876));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 58,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 888, DateTimeKind.Local).AddTicks(8878));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 59,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 888, DateTimeKind.Local).AddTicks(8883));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 60,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 888, DateTimeKind.Local).AddTicks(8886));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 61,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 888, DateTimeKind.Local).AddTicks(8889));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 62,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 888, DateTimeKind.Local).AddTicks(8891));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 63,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 888, DateTimeKind.Local).AddTicks(8895));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 64,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 888, DateTimeKind.Local).AddTicks(8897));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 65,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 888, DateTimeKind.Local).AddTicks(8899));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 66,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 888, DateTimeKind.Local).AddTicks(8907));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 67,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 888, DateTimeKind.Local).AddTicks(8909));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 68,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 888, DateTimeKind.Local).AddTicks(8915));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 69,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 888, DateTimeKind.Local).AddTicks(8918));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 70,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 888, DateTimeKind.Local).AddTicks(8921));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 71,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 888, DateTimeKind.Local).AddTicks(8924));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 72,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 888, DateTimeKind.Local).AddTicks(8926));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 73,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 888, DateTimeKind.Local).AddTicks(8930));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 74,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 888, DateTimeKind.Local).AddTicks(8934));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 75,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 888, DateTimeKind.Local).AddTicks(8936));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 76,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 888, DateTimeKind.Local).AddTicks(8939));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 77,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 888, DateTimeKind.Local).AddTicks(8942));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 78,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 888, DateTimeKind.Local).AddTicks(8945));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 79,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 888, DateTimeKind.Local).AddTicks(8948));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 80,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 888, DateTimeKind.Local).AddTicks(8950));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 81,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 888, DateTimeKind.Local).AddTicks(8953));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 82,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 888, DateTimeKind.Local).AddTicks(8955));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 83,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 888, DateTimeKind.Local).AddTicks(8958));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 84,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 888, DateTimeKind.Local).AddTicks(8965));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 85,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 888, DateTimeKind.Local).AddTicks(8967));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 86,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 888, DateTimeKind.Local).AddTicks(8970));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 87,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 888, DateTimeKind.Local).AddTicks(8972));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 88,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 888, DateTimeKind.Local).AddTicks(8974));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 89,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 888, DateTimeKind.Local).AddTicks(8977));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 90,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 888, DateTimeKind.Local).AddTicks(8979));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 91,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 888, DateTimeKind.Local).AddTicks(8982));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 92,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 888, DateTimeKind.Local).AddTicks(8984));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 93,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 888, DateTimeKind.Local).AddTicks(8986));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 94,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 888, DateTimeKind.Local).AddTicks(8989));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 95,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 888, DateTimeKind.Local).AddTicks(8991));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 96,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 888, DateTimeKind.Local).AddTicks(8993));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 97,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 888, DateTimeKind.Local).AddTicks(8995));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 98,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 888, DateTimeKind.Local).AddTicks(8999));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 99,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 888, DateTimeKind.Local).AddTicks(9002));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 100,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 888, DateTimeKind.Local).AddTicks(9003));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 101,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 888, DateTimeKind.Local).AddTicks(9009));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 102,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 888, DateTimeKind.Local).AddTicks(9012));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 103,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 888, DateTimeKind.Local).AddTicks(9015));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 104,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 888, DateTimeKind.Local).AddTicks(9018));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 105,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 888, DateTimeKind.Local).AddTicks(9020));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 106,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 888, DateTimeKind.Local).AddTicks(9023));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 107,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 888, DateTimeKind.Local).AddTicks(9026));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 108,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 888, DateTimeKind.Local).AddTicks(9028));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 109,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 888, DateTimeKind.Local).AddTicks(9031));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 110,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 888, DateTimeKind.Local).AddTicks(9033));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 111,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 888, DateTimeKind.Local).AddTicks(9035));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 112,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 888, DateTimeKind.Local).AddTicks(9038));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 113,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 888, DateTimeKind.Local).AddTicks(9041));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 114,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 888, DateTimeKind.Local).AddTicks(9043));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 115,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 888, DateTimeKind.Local).AddTicks(9046));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 116,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 888, DateTimeKind.Local).AddTicks(9048));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 117,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 888, DateTimeKind.Local).AddTicks(9050));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 118,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 888, DateTimeKind.Local).AddTicks(9054));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 119,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 888, DateTimeKind.Local).AddTicks(9056));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 120,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 888, DateTimeKind.Local).AddTicks(9060));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 878, DateTimeKind.Local).AddTicks(6411));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 880, DateTimeKind.Local).AddTicks(7927));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 880, DateTimeKind.Local).AddTicks(8004));

            migrationBuilder.UpdateData(
                table: "SystemVariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 921, DateTimeKind.Local).AddTicks(3493));

            migrationBuilder.UpdateData(
                table: "SystemVariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 921, DateTimeKind.Local).AddTicks(3633));

            migrationBuilder.UpdateData(
                table: "SystemVariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 921, DateTimeKind.Local).AddTicks(3630));

            migrationBuilder.UpdateData(
                table: "SystemVariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 921, DateTimeKind.Local).AddTicks(3626));

            migrationBuilder.UpdateData(
                table: "SystemVariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 921, DateTimeKind.Local).AddTicks(3620));

            migrationBuilder.UpdateData(
                table: "SystemVariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 921, DateTimeKind.Local).AddTicks(3643));

            migrationBuilder.UpdateData(
                table: "SystemVariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 921, DateTimeKind.Local).AddTicks(3656));

            migrationBuilder.UpdateData(
                table: "SystemVariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 921, DateTimeKind.Local).AddTicks(3661));

            migrationBuilder.UpdateData(
                table: "SystemVariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 921, DateTimeKind.Local).AddTicks(3664));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 898, DateTimeKind.Local).AddTicks(5893));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 898, DateTimeKind.Local).AddTicks(7188));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 898, DateTimeKind.Local).AddTicks(7395));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 898, DateTimeKind.Local).AddTicks(7576));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 898, DateTimeKind.Local).AddTicks(7793));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 898, DateTimeKind.Local).AddTicks(7966));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 898, DateTimeKind.Local).AddTicks(8108));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 898, DateTimeKind.Local).AddTicks(8242));

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumns: new[] { "UserID", "RoleID" },
                keyValues: new object[] { 1, 1 },
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 940, DateTimeKind.Local).AddTicks(828));

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumns: new[] { "UserID", "RoleID" },
                keyValues: new object[] { 2, 3 },
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 940, DateTimeKind.Local).AddTicks(997));

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "UserTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 916, DateTimeKind.Local).AddTicks(3379));

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "UserTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 916, DateTimeKind.Local).AddTicks(4155));

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "UserTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 916, DateTimeKind.Local).AddTicks(4172));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 926, DateTimeKind.Local).AddTicks(3222));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 929, DateTimeKind.Local).AddTicks(3066));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 11, 6, 929, DateTimeKind.Local).AddTicks(3355));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DatePaid",
                table: "ClientFees");

            migrationBuilder.DropColumn(
                name: "ClientProductID",
                table: "ClientDeductions");

            migrationBuilder.DropColumn(
                name: "DatePaid",
                table: "ClientDeductions");

            migrationBuilder.RenameColumn(
                name: "Salary",
                table: "ClientDeductions",
                newName: "CurrentSalary");

            migrationBuilder.AddColumn<bool>(
                name: "IsPaid",
                table: "ClientFees",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "BankAccountTypes",
                keyColumn: "BankAccountTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 488, DateTimeKind.Local).AddTicks(6922));

            migrationBuilder.UpdateData(
                table: "BankAccountTypes",
                keyColumn: "BankAccountTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 488, DateTimeKind.Local).AddTicks(8324));

            migrationBuilder.UpdateData(
                table: "BankAccountTypes",
                keyColumn: "BankAccountTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 488, DateTimeKind.Local).AddTicks(8339));

            migrationBuilder.UpdateData(
                table: "BankAccountTypes",
                keyColumn: "BankAccountTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 488, DateTimeKind.Local).AddTicks(8346));

            migrationBuilder.UpdateData(
                table: "ContactTypes",
                keyColumn: "ContactTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 511, DateTimeKind.Local).AddTicks(7497));

            migrationBuilder.UpdateData(
                table: "ContactTypes",
                keyColumn: "ContactTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 511, DateTimeKind.Local).AddTicks(7484));

            migrationBuilder.UpdateData(
                table: "ContactTypes",
                keyColumn: "ContactTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 511, DateTimeKind.Local).AddTicks(7465));

            migrationBuilder.UpdateData(
                table: "ContactTypes",
                keyColumn: "ContactTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 511, DateTimeKind.Local).AddTicks(7057));

            migrationBuilder.UpdateData(
                table: "ContactTypes",
                keyColumn: "ContactTypeID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 511, DateTimeKind.Local).AddTicks(7504));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 525, DateTimeKind.Local).AddTicks(6571));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 525, DateTimeKind.Local).AddTicks(7464));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 525, DateTimeKind.Local).AddTicks(7478));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 525, DateTimeKind.Local).AddTicks(7502));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 525, DateTimeKind.Local).AddTicks(7507));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 525, DateTimeKind.Local).AddTicks(7521));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 525, DateTimeKind.Local).AddTicks(7526));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 525, DateTimeKind.Local).AddTicks(7561));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 525, DateTimeKind.Local).AddTicks(7566));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 525, DateTimeKind.Local).AddTicks(7573));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 525, DateTimeKind.Local).AddTicks(7578));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 525, DateTimeKind.Local).AddTicks(7583));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 13,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 525, DateTimeKind.Local).AddTicks(7587));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 14,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 525, DateTimeKind.Local).AddTicks(7592));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 15,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 525, DateTimeKind.Local).AddTicks(7596));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 16,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 525, DateTimeKind.Local).AddTicks(7602));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 17,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 525, DateTimeKind.Local).AddTicks(7606));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 18,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 525, DateTimeKind.Local).AddTicks(7614));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 19,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 525, DateTimeKind.Local).AddTicks(7618));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 20,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 525, DateTimeKind.Local).AddTicks(7622));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 21,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 525, DateTimeKind.Local).AddTicks(7626));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 22,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 525, DateTimeKind.Local).AddTicks(7630));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 23,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 525, DateTimeKind.Local).AddTicks(7635));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 24,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 525, DateTimeKind.Local).AddTicks(7639));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 25,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 525, DateTimeKind.Local).AddTicks(7645));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 26,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 525, DateTimeKind.Local).AddTicks(7649));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 27,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 525, DateTimeKind.Local).AddTicks(7655));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 28,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 525, DateTimeKind.Local).AddTicks(7660));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 29,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 525, DateTimeKind.Local).AddTicks(7664));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 30,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 525, DateTimeKind.Local).AddTicks(7671));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 31,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 525, DateTimeKind.Local).AddTicks(7675));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 32,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 525, DateTimeKind.Local).AddTicks(7680));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 33,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 525, DateTimeKind.Local).AddTicks(7685));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 34,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 525, DateTimeKind.Local).AddTicks(7691));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 35,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 525, DateTimeKind.Local).AddTicks(7696));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 36,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 525, DateTimeKind.Local).AddTicks(7700));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 37,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 525, DateTimeKind.Local).AddTicks(7704));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 38,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 525, DateTimeKind.Local).AddTicks(7708));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 39,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 525, DateTimeKind.Local).AddTicks(7713));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 40,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 525, DateTimeKind.Local).AddTicks(7719));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 41,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 525, DateTimeKind.Local).AddTicks(7725));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 42,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 525, DateTimeKind.Local).AddTicks(7729));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 43,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 525, DateTimeKind.Local).AddTicks(7733));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 44,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 525, DateTimeKind.Local).AddTicks(7738));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 45,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 525, DateTimeKind.Local).AddTicks(7742));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 46,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 525, DateTimeKind.Local).AddTicks(7746));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 47,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 525, DateTimeKind.Local).AddTicks(7752));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 48,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 525, DateTimeKind.Local).AddTicks(7759));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 49,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 525, DateTimeKind.Local).AddTicks(7764));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 50,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 525, DateTimeKind.Local).AddTicks(7769));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 51,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 525, DateTimeKind.Local).AddTicks(7774));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 52,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 525, DateTimeKind.Local).AddTicks(7779));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 53,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 525, DateTimeKind.Local).AddTicks(7783));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 54,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 525, DateTimeKind.Local).AddTicks(7787));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 55,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 525, DateTimeKind.Local).AddTicks(7793));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 56,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 525, DateTimeKind.Local).AddTicks(7797));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 57,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 525, DateTimeKind.Local).AddTicks(7801));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 58,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 525, DateTimeKind.Local).AddTicks(7806));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 59,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 525, DateTimeKind.Local).AddTicks(7812));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 60,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 525, DateTimeKind.Local).AddTicks(7817));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 61,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 525, DateTimeKind.Local).AddTicks(7821));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 62,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 525, DateTimeKind.Local).AddTicks(7826));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 63,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 525, DateTimeKind.Local).AddTicks(7831));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 64,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 525, DateTimeKind.Local).AddTicks(7837));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 65,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 525, DateTimeKind.Local).AddTicks(7841));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 66,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 525, DateTimeKind.Local).AddTicks(7864));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 67,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 525, DateTimeKind.Local).AddTicks(7868));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 68,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 525, DateTimeKind.Local).AddTicks(7873));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 69,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 525, DateTimeKind.Local).AddTicks(7878));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 70,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 525, DateTimeKind.Local).AddTicks(7882));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 71,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 525, DateTimeKind.Local).AddTicks(7886));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 72,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 525, DateTimeKind.Local).AddTicks(7891));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 73,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 525, DateTimeKind.Local).AddTicks(7897));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 74,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 525, DateTimeKind.Local).AddTicks(7901));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 75,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 525, DateTimeKind.Local).AddTicks(7906));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 76,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 525, DateTimeKind.Local).AddTicks(7912));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 77,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 525, DateTimeKind.Local).AddTicks(7916));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 78,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 525, DateTimeKind.Local).AddTicks(7920));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 79,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 525, DateTimeKind.Local).AddTicks(7924));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 80,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 525, DateTimeKind.Local).AddTicks(7935));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 81,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 525, DateTimeKind.Local).AddTicks(7942));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 82,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 525, DateTimeKind.Local).AddTicks(7947));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 83,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 525, DateTimeKind.Local).AddTicks(7953));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 84,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 525, DateTimeKind.Local).AddTicks(7959));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 85,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 525, DateTimeKind.Local).AddTicks(7964));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 86,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 525, DateTimeKind.Local).AddTicks(7970));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 87,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 525, DateTimeKind.Local).AddTicks(7976));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 88,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 525, DateTimeKind.Local).AddTicks(7982));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 89,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 525, DateTimeKind.Local).AddTicks(7990));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 90,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 525, DateTimeKind.Local).AddTicks(7997));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 91,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 525, DateTimeKind.Local).AddTicks(8003));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 92,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 525, DateTimeKind.Local).AddTicks(8009));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 93,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 525, DateTimeKind.Local).AddTicks(8023));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 94,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 525, DateTimeKind.Local).AddTicks(8031));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 95,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 525, DateTimeKind.Local).AddTicks(8038));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 96,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 525, DateTimeKind.Local).AddTicks(8043));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 97,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 525, DateTimeKind.Local).AddTicks(8049));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 98,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 525, DateTimeKind.Local).AddTicks(8055));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 99,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 525, DateTimeKind.Local).AddTicks(8060));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 100,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 525, DateTimeKind.Local).AddTicks(8070));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 101,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 525, DateTimeKind.Local).AddTicks(8080));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 102,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 525, DateTimeKind.Local).AddTicks(8086));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 103,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 525, DateTimeKind.Local).AddTicks(8092));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 104,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 525, DateTimeKind.Local).AddTicks(8098));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 105,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 525, DateTimeKind.Local).AddTicks(8105));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 106,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 525, DateTimeKind.Local).AddTicks(8111));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 107,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 525, DateTimeKind.Local).AddTicks(8117));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 108,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 525, DateTimeKind.Local).AddTicks(8124));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 109,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 525, DateTimeKind.Local).AddTicks(8131));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 110,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 525, DateTimeKind.Local).AddTicks(8137));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 111,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 525, DateTimeKind.Local).AddTicks(8145));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 112,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 525, DateTimeKind.Local).AddTicks(8153));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 113,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 525, DateTimeKind.Local).AddTicks(8159));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 114,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 525, DateTimeKind.Local).AddTicks(8165));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 115,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 525, DateTimeKind.Local).AddTicks(8174));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 116,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 525, DateTimeKind.Local).AddTicks(8180));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 117,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 525, DateTimeKind.Local).AddTicks(8187));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 118,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 525, DateTimeKind.Local).AddTicks(8194));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 119,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 525, DateTimeKind.Local).AddTicks(8200));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 120,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 525, DateTimeKind.Local).AddTicks(8210));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 121,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 525, DateTimeKind.Local).AddTicks(8217));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 122,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 525, DateTimeKind.Local).AddTicks(8223));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 123,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 525, DateTimeKind.Local).AddTicks(8228));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 124,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 525, DateTimeKind.Local).AddTicks(8233));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 125,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 525, DateTimeKind.Local).AddTicks(8239));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 126,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 525, DateTimeKind.Local).AddTicks(8245));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 127,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 525, DateTimeKind.Local).AddTicks(8250));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 128,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 525, DateTimeKind.Local).AddTicks(8257));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 129,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 525, DateTimeKind.Local).AddTicks(8264));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 130,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 525, DateTimeKind.Local).AddTicks(8285));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 131,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 525, DateTimeKind.Local).AddTicks(8289));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 132,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 525, DateTimeKind.Local).AddTicks(8295));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 133,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 525, DateTimeKind.Local).AddTicks(8299));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 134,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 525, DateTimeKind.Local).AddTicks(8303));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 135,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 525, DateTimeKind.Local).AddTicks(8307));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 136,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 525, DateTimeKind.Local).AddTicks(8311));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 137,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 525, DateTimeKind.Local).AddTicks(8316));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 138,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 525, DateTimeKind.Local).AddTicks(8322));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 139,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 525, DateTimeKind.Local).AddTicks(8326));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 140,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 525, DateTimeKind.Local).AddTicks(8330));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 141,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 525, DateTimeKind.Local).AddTicks(8335));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 142,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 525, DateTimeKind.Local).AddTicks(8339));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 143,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 525, DateTimeKind.Local).AddTicks(8343));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 144,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 525, DateTimeKind.Local).AddTicks(8348));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 145,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 525, DateTimeKind.Local).AddTicks(8352));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 146,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 525, DateTimeKind.Local).AddTicks(8357));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 147,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 525, DateTimeKind.Local).AddTicks(8361));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 148,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 525, DateTimeKind.Local).AddTicks(8365));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 149,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 525, DateTimeKind.Local).AddTicks(8371));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 150,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 525, DateTimeKind.Local).AddTicks(8376));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 151,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 525, DateTimeKind.Local).AddTicks(8382));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 152,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 525, DateTimeKind.Local).AddTicks(8386));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 153,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 525, DateTimeKind.Local).AddTicks(8391));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 154,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 525, DateTimeKind.Local).AddTicks(8395));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 155,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 525, DateTimeKind.Local).AddTicks(8401));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 156,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 525, DateTimeKind.Local).AddTicks(8405));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 157,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 525, DateTimeKind.Local).AddTicks(8409));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 158,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 525, DateTimeKind.Local).AddTicks(8414));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 159,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 525, DateTimeKind.Local).AddTicks(8418));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 160,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 525, DateTimeKind.Local).AddTicks(8422));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 161,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 525, DateTimeKind.Local).AddTicks(8428));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 162,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 525, DateTimeKind.Local).AddTicks(8432));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 163,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 525, DateTimeKind.Local).AddTicks(8436));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 164,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 525, DateTimeKind.Local).AddTicks(8441));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 165,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 525, DateTimeKind.Local).AddTicks(8445));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 166,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 525, DateTimeKind.Local).AddTicks(8449));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 167,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 525, DateTimeKind.Local).AddTicks(8454));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 168,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 525, DateTimeKind.Local).AddTicks(8459));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 169,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 525, DateTimeKind.Local).AddTicks(8463));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 170,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 525, DateTimeKind.Local).AddTicks(8467));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 171,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 525, DateTimeKind.Local).AddTicks(8471));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 172,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 525, DateTimeKind.Local).AddTicks(8476));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 173,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 525, DateTimeKind.Local).AddTicks(8481));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 174,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 525, DateTimeKind.Local).AddTicks(8487));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 175,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 525, DateTimeKind.Local).AddTicks(8492));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 176,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 525, DateTimeKind.Local).AddTicks(8498));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 177,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 525, DateTimeKind.Local).AddTicks(8505));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 178,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 525, DateTimeKind.Local).AddTicks(8510));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 179,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 525, DateTimeKind.Local).AddTicks(8515));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 180,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 525, DateTimeKind.Local).AddTicks(8521));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 181,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 525, DateTimeKind.Local).AddTicks(8526));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 182,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 525, DateTimeKind.Local).AddTicks(8544));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 183,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 525, DateTimeKind.Local).AddTicks(8548));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 184,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 525, DateTimeKind.Local).AddTicks(8552));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 185,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 525, DateTimeKind.Local).AddTicks(8557));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 186,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 525, DateTimeKind.Local).AddTicks(8561));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 187,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 525, DateTimeKind.Local).AddTicks(8566));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 188,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 525, DateTimeKind.Local).AddTicks(8570));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 189,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 525, DateTimeKind.Local).AddTicks(8575));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 190,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 525, DateTimeKind.Local).AddTicks(8579));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 191,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 525, DateTimeKind.Local).AddTicks(8584));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 192,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 525, DateTimeKind.Local).AddTicks(8588));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 193,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 525, DateTimeKind.Local).AddTicks(8593));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 194,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 525, DateTimeKind.Local).AddTicks(8598));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 195,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 525, DateTimeKind.Local).AddTicks(8602));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 196,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 525, DateTimeKind.Local).AddTicks(8606));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 197,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 525, DateTimeKind.Local).AddTicks(8610));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 198,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 525, DateTimeKind.Local).AddTicks(8614));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 199,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 525, DateTimeKind.Local).AddTicks(8618));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 200,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 525, DateTimeKind.Local).AddTicks(8622));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 201,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 525, DateTimeKind.Local).AddTicks(8626));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 202,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 525, DateTimeKind.Local).AddTicks(8631));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 203,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 525, DateTimeKind.Local).AddTicks(8635));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 204,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 525, DateTimeKind.Local).AddTicks(8639));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 205,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 525, DateTimeKind.Local).AddTicks(8643));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 206,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 525, DateTimeKind.Local).AddTicks(8648));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 207,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 525, DateTimeKind.Local).AddTicks(8652));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 208,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 525, DateTimeKind.Local).AddTicks(8657));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 209,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 525, DateTimeKind.Local).AddTicks(8661));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 210,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 525, DateTimeKind.Local).AddTicks(8666));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 211,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 525, DateTimeKind.Local).AddTicks(8671));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 212,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 525, DateTimeKind.Local).AddTicks(8675));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 213,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 525, DateTimeKind.Local).AddTicks(8679));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 214,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 525, DateTimeKind.Local).AddTicks(8684));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 215,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 525, DateTimeKind.Local).AddTicks(8689));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 216,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 525, DateTimeKind.Local).AddTicks(8695));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 217,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 525, DateTimeKind.Local).AddTicks(8699));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 218,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 525, DateTimeKind.Local).AddTicks(8703));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 219,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 525, DateTimeKind.Local).AddTicks(8707));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 220,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 525, DateTimeKind.Local).AddTicks(8712));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 221,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 525, DateTimeKind.Local).AddTicks(8716));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 222,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 525, DateTimeKind.Local).AddTicks(8721));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 223,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 525, DateTimeKind.Local).AddTicks(8726));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 224,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 525, DateTimeKind.Local).AddTicks(8731));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 225,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 525, DateTimeKind.Local).AddTicks(8736));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 226,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 525, DateTimeKind.Local).AddTicks(8740));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 227,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 525, DateTimeKind.Local).AddTicks(8744));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 228,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 525, DateTimeKind.Local).AddTicks(8749));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 495, DateTimeKind.Local).AddTicks(4690));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 495, DateTimeKind.Local).AddTicks(6175));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 495, DateTimeKind.Local).AddTicks(6193));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 495, DateTimeKind.Local).AddTicks(6204));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 495, DateTimeKind.Local).AddTicks(6210));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 495, DateTimeKind.Local).AddTicks(6233));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 495, DateTimeKind.Local).AddTicks(6242));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 495, DateTimeKind.Local).AddTicks(6249));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 495, DateTimeKind.Local).AddTicks(6256));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 495, DateTimeKind.Local).AddTicks(6266));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 495, DateTimeKind.Local).AddTicks(6274));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 495, DateTimeKind.Local).AddTicks(6281));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 13,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 495, DateTimeKind.Local).AddTicks(6287));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 14,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 495, DateTimeKind.Local).AddTicks(6294));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 15,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 495, DateTimeKind.Local).AddTicks(6304));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 16,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 495, DateTimeKind.Local).AddTicks(6313));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 17,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 495, DateTimeKind.Local).AddTicks(6325));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 18,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 495, DateTimeKind.Local).AddTicks(6334));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 19,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 495, DateTimeKind.Local).AddTicks(6346));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 20,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 495, DateTimeKind.Local).AddTicks(6352));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 21,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 495, DateTimeKind.Local).AddTicks(6358));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 22,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 495, DateTimeKind.Local).AddTicks(6367));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 23,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 495, DateTimeKind.Local).AddTicks(6373));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 24,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 495, DateTimeKind.Local).AddTicks(6384));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 25,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 495, DateTimeKind.Local).AddTicks(6392));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 26,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 495, DateTimeKind.Local).AddTicks(6401));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 27,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 495, DateTimeKind.Local).AddTicks(6408));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 28,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 495, DateTimeKind.Local).AddTicks(6425));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 29,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 495, DateTimeKind.Local).AddTicks(6432));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 30,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 495, DateTimeKind.Local).AddTicks(6503));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 31,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 495, DateTimeKind.Local).AddTicks(6514));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 32,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 495, DateTimeKind.Local).AddTicks(6526));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 33,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 495, DateTimeKind.Local).AddTicks(6533));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 34,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 495, DateTimeKind.Local).AddTicks(6545));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 35,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 495, DateTimeKind.Local).AddTicks(6552));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 36,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 495, DateTimeKind.Local).AddTicks(6560));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 37,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 495, DateTimeKind.Local).AddTicks(6565));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 38,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 495, DateTimeKind.Local).AddTicks(6572));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 39,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 495, DateTimeKind.Local).AddTicks(6579));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 40,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 495, DateTimeKind.Local).AddTicks(6588));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 41,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 495, DateTimeKind.Local).AddTicks(6601));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 42,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 495, DateTimeKind.Local).AddTicks(6610));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 43,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 495, DateTimeKind.Local).AddTicks(6619));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 44,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 495, DateTimeKind.Local).AddTicks(6627));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 45,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 495, DateTimeKind.Local).AddTicks(6633));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 46,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 495, DateTimeKind.Local).AddTicks(6639));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 47,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 495, DateTimeKind.Local).AddTicks(6652));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 48,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 495, DateTimeKind.Local).AddTicks(6663));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 49,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 495, DateTimeKind.Local).AddTicks(6669));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 50,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 495, DateTimeKind.Local).AddTicks(6677));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 51,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 495, DateTimeKind.Local).AddTicks(6685));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 52,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 495, DateTimeKind.Local).AddTicks(6692));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 53,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 495, DateTimeKind.Local).AddTicks(6698));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 54,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 495, DateTimeKind.Local).AddTicks(6705));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 55,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 495, DateTimeKind.Local).AddTicks(6713));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 56,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 495, DateTimeKind.Local).AddTicks(6724));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 57,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 495, DateTimeKind.Local).AddTicks(6731));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 58,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 495, DateTimeKind.Local).AddTicks(6741));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 59,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 495, DateTimeKind.Local).AddTicks(6753));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 60,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 495, DateTimeKind.Local).AddTicks(6765));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 61,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 495, DateTimeKind.Local).AddTicks(6772));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 62,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 495, DateTimeKind.Local).AddTicks(6781));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 63,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 495, DateTimeKind.Local).AddTicks(6788));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 64,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 495, DateTimeKind.Local).AddTicks(6793));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 65,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 495, DateTimeKind.Local).AddTicks(6800));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 66,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 495, DateTimeKind.Local).AddTicks(6809));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 67,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 495, DateTimeKind.Local).AddTicks(6818));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 68,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 495, DateTimeKind.Local).AddTicks(6825));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 69,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 495, DateTimeKind.Local).AddTicks(6832));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 70,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 495, DateTimeKind.Local).AddTicks(6841));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 71,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 495, DateTimeKind.Local).AddTicks(6855));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 72,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 495, DateTimeKind.Local).AddTicks(6865));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 73,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 495, DateTimeKind.Local).AddTicks(6874));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 74,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 495, DateTimeKind.Local).AddTicks(6880));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 75,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 495, DateTimeKind.Local).AddTicks(6886));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 76,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 495, DateTimeKind.Local).AddTicks(6895));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 77,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 495, DateTimeKind.Local).AddTicks(6905));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 78,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 495, DateTimeKind.Local).AddTicks(6913));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 79,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 495, DateTimeKind.Local).AddTicks(6918));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 80,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 495, DateTimeKind.Local).AddTicks(6926));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 81,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 495, DateTimeKind.Local).AddTicks(6933));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 82,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 495, DateTimeKind.Local).AddTicks(6939));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 83,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 495, DateTimeKind.Local).AddTicks(6947));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 84,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 495, DateTimeKind.Local).AddTicks(6955));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 85,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 495, DateTimeKind.Local).AddTicks(6962));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 86,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 495, DateTimeKind.Local).AddTicks(6974));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 87,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 495, DateTimeKind.Local).AddTicks(6981));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 88,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 495, DateTimeKind.Local).AddTicks(6988));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 89,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 495, DateTimeKind.Local).AddTicks(6996));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 90,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 495, DateTimeKind.Local).AddTicks(7004));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 91,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 495, DateTimeKind.Local).AddTicks(7012));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 92,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 495, DateTimeKind.Local).AddTicks(7019));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 93,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 495, DateTimeKind.Local).AddTicks(7045));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 94,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 495, DateTimeKind.Local).AddTicks(7056));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 95,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 495, DateTimeKind.Local).AddTicks(7061));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 96,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 495, DateTimeKind.Local).AddTicks(7072));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 97,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 495, DateTimeKind.Local).AddTicks(7079));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 98,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 495, DateTimeKind.Local).AddTicks(7085));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 99,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 495, DateTimeKind.Local).AddTicks(7095));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 100,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 495, DateTimeKind.Local).AddTicks(7103));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 101,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 495, DateTimeKind.Local).AddTicks(7110));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 102,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 495, DateTimeKind.Local).AddTicks(7116));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 103,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 495, DateTimeKind.Local).AddTicks(7124));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 104,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 495, DateTimeKind.Local).AddTicks(7133));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 105,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 495, DateTimeKind.Local).AddTicks(7138));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 106,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 495, DateTimeKind.Local).AddTicks(7150));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 107,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 495, DateTimeKind.Local).AddTicks(7160));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 108,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 495, DateTimeKind.Local).AddTicks(7168));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 109,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 495, DateTimeKind.Local).AddTicks(7179));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 110,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 495, DateTimeKind.Local).AddTicks(7186));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 111,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 495, DateTimeKind.Local).AddTicks(7196));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 112,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 495, DateTimeKind.Local).AddTicks(7202));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 113,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 495, DateTimeKind.Local).AddTicks(7209));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 114,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 495, DateTimeKind.Local).AddTicks(7221));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 115,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 495, DateTimeKind.Local).AddTicks(7230));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 116,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 495, DateTimeKind.Local).AddTicks(7237));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 117,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 495, DateTimeKind.Local).AddTicks(7243));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 118,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 495, DateTimeKind.Local).AddTicks(7257));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 119,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 495, DateTimeKind.Local).AddTicks(7270));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 120,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 495, DateTimeKind.Local).AddTicks(7277));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 121,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 495, DateTimeKind.Local).AddTicks(7286));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 122,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 495, DateTimeKind.Local).AddTicks(7297));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 123,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 495, DateTimeKind.Local).AddTicks(7307));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 124,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 495, DateTimeKind.Local).AddTicks(7316));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 125,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 495, DateTimeKind.Local).AddTicks(7326));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 126,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 495, DateTimeKind.Local).AddTicks(7336));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 127,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 495, DateTimeKind.Local).AddTicks(7346));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 128,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 495, DateTimeKind.Local).AddTicks(7353));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 129,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 495, DateTimeKind.Local).AddTicks(7364));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 130,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 495, DateTimeKind.Local).AddTicks(7379));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 131,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 495, DateTimeKind.Local).AddTicks(7391));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 132,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 495, DateTimeKind.Local).AddTicks(7397));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 133,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 495, DateTimeKind.Local).AddTicks(7404));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 134,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 495, DateTimeKind.Local).AddTicks(7416));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 135,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 495, DateTimeKind.Local).AddTicks(7424));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 136,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 495, DateTimeKind.Local).AddTicks(7433));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 137,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 495, DateTimeKind.Local).AddTicks(7447));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 138,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 495, DateTimeKind.Local).AddTicks(7459));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 139,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 495, DateTimeKind.Local).AddTicks(7471));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 140,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 495, DateTimeKind.Local).AddTicks(7477));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 141,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 495, DateTimeKind.Local).AddTicks(7484));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 142,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 495, DateTimeKind.Local).AddTicks(7493));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 143,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 495, DateTimeKind.Local).AddTicks(7501));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 144,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 495, DateTimeKind.Local).AddTicks(7511));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 145,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 495, DateTimeKind.Local).AddTicks(7516));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 146,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 495, DateTimeKind.Local).AddTicks(7522));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 147,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 495, DateTimeKind.Local).AddTicks(7532));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 148,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 495, DateTimeKind.Local).AddTicks(7538));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 149,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 495, DateTimeKind.Local).AddTicks(7549));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 150,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 495, DateTimeKind.Local).AddTicks(7556));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 151,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 495, DateTimeKind.Local).AddTicks(7561));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 152,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 495, DateTimeKind.Local).AddTicks(7592));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 153,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 495, DateTimeKind.Local).AddTicks(7599));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 154,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 495, DateTimeKind.Local).AddTicks(7608));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 155,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 495, DateTimeKind.Local).AddTicks(7617));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 156,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 495, DateTimeKind.Local).AddTicks(7627));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 157,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 495, DateTimeKind.Local).AddTicks(7637));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 158,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 495, DateTimeKind.Local).AddTicks(7646));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 159,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 495, DateTimeKind.Local).AddTicks(7653));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 160,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 495, DateTimeKind.Local).AddTicks(7659));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 161,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 495, DateTimeKind.Local).AddTicks(7668));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 162,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 495, DateTimeKind.Local).AddTicks(7674));

            migrationBuilder.UpdateData(
                table: "CustomSettingTypes",
                keyColumn: "CustomSettingTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 516, DateTimeKind.Local).AddTicks(2030));

            migrationBuilder.UpdateData(
                table: "CustomSettingTypes",
                keyColumn: "CustomSettingTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 516, DateTimeKind.Local).AddTicks(2498));

            migrationBuilder.UpdateData(
                table: "CustomSettingTypes",
                keyColumn: "CustomSettingTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 516, DateTimeKind.Local).AddTicks(2513));

            migrationBuilder.UpdateData(
                table: "CustomSettingTypes",
                keyColumn: "CustomSettingTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 516, DateTimeKind.Local).AddTicks(2520));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 590, DateTimeKind.Local).AddTicks(164));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 590, DateTimeKind.Local).AddTicks(712));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 590, DateTimeKind.Local).AddTicks(773));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 590, DateTimeKind.Local).AddTicks(786));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 590, DateTimeKind.Local).AddTicks(879));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 590, DateTimeKind.Local).AddTicks(730));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 590, DateTimeKind.Local).AddTicks(892));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 590, DateTimeKind.Local).AddTicks(906));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 590, DateTimeKind.Local).AddTicks(916));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 590, DateTimeKind.Local).AddTicks(927));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 590, DateTimeKind.Local).AddTicks(940));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 590, DateTimeKind.Local).AddTicks(957));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 13,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 590, DateTimeKind.Local).AddTicks(1083));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 14,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 590, DateTimeKind.Local).AddTicks(1094));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 15,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 590, DateTimeKind.Local).AddTicks(1104));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 16,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 590, DateTimeKind.Local).AddTicks(1118));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 17,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 590, DateTimeKind.Local).AddTicks(751));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 18,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 590, DateTimeKind.Local).AddTicks(700));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 19,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 590, DateTimeKind.Local).AddTicks(1129));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 20,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 590, DateTimeKind.Local).AddTicks(1137));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 21,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 590, DateTimeKind.Local).AddTicks(1148));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 22,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 590, DateTimeKind.Local).AddTicks(1165));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 23,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 590, DateTimeKind.Local).AddTicks(1174));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 25,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 590, DateTimeKind.Local).AddTicks(1236));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 26,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 590, DateTimeKind.Local).AddTicks(1183));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 27,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 590, DateTimeKind.Local).AddTicks(1196));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 28,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 590, DateTimeKind.Local).AddTicks(1216));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 29,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 590, DateTimeKind.Local).AddTicks(1206));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 30,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 590, DateTimeKind.Local).AddTicks(1225));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 31,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 590, DateTimeKind.Local).AddTicks(1246));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 32,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 590, DateTimeKind.Local).AddTicks(1260));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 33,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 590, DateTimeKind.Local).AddTicks(1272));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 34,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 590, DateTimeKind.Local).AddTicks(1283));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 35,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 590, DateTimeKind.Local).AddTicks(1300));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 36,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 590, DateTimeKind.Local).AddTicks(1313));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 37,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 590, DateTimeKind.Local).AddTicks(1323));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 38,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 590, DateTimeKind.Local).AddTicks(1336));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 39,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 590, DateTimeKind.Local).AddTicks(1349));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 40,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 590, DateTimeKind.Local).AddTicks(1361));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 41,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 590, DateTimeKind.Local).AddTicks(1370));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 42,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 590, DateTimeKind.Local).AddTicks(1379));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 43,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 590, DateTimeKind.Local).AddTicks(1392));

            migrationBuilder.UpdateData(
                table: "DocumentFormats",
                keyColumn: "DocumentFormatID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 542, DateTimeKind.Local).AddTicks(4270));

            migrationBuilder.UpdateData(
                table: "DocumentFormats",
                keyColumn: "DocumentFormatID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 542, DateTimeKind.Local).AddTicks(5011));

            migrationBuilder.UpdateData(
                table: "DocumentFormats",
                keyColumn: "DocumentFormatID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 542, DateTimeKind.Local).AddTicks(5020));

            migrationBuilder.UpdateData(
                table: "DocumentFormats",
                keyColumn: "DocumentFormatID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 542, DateTimeKind.Local).AddTicks(5027));

            migrationBuilder.UpdateData(
                table: "DocumentFormats",
                keyColumn: "DocumentFormatID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 542, DateTimeKind.Local).AddTicks(5032));

            migrationBuilder.UpdateData(
                table: "DocumentFormats",
                keyColumn: "DocumentFormatID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 542, DateTimeKind.Local).AddTicks(5046));

            migrationBuilder.UpdateData(
                table: "DocumentTypes",
                keyColumn: "DocumentTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 551, DateTimeKind.Local).AddTicks(1579));

            migrationBuilder.UpdateData(
                table: "DocumentTypes",
                keyColumn: "DocumentTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 551, DateTimeKind.Local).AddTicks(4092));

            migrationBuilder.UpdateData(
                table: "DocumentTypes",
                keyColumn: "DocumentTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 551, DateTimeKind.Local).AddTicks(4134));

            migrationBuilder.UpdateData(
                table: "DocumentTypes",
                keyColumn: "DocumentTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 551, DateTimeKind.Local).AddTicks(4140));

            migrationBuilder.UpdateData(
                table: "EmailTypes",
                keyColumn: "EmailTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 578, DateTimeKind.Local).AddTicks(2511));

            migrationBuilder.UpdateData(
                table: "EmailTypes",
                keyColumn: "EmailTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 578, DateTimeKind.Local).AddTicks(3576));

            migrationBuilder.UpdateData(
                table: "EmailTypes",
                keyColumn: "EmailTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 578, DateTimeKind.Local).AddTicks(3590));

            migrationBuilder.UpdateData(
                table: "EmailTypes",
                keyColumn: "EmailTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 578, DateTimeKind.Local).AddTicks(3599));

            migrationBuilder.UpdateData(
                table: "FeatureFlags",
                keyColumn: "FeatureFlagID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 537, DateTimeKind.Local).AddTicks(7591));

            migrationBuilder.UpdateData(
                table: "FeatureFlags",
                keyColumn: "FeatureFlagID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 537, DateTimeKind.Local).AddTicks(8496));

            migrationBuilder.UpdateData(
                table: "FeatureFlags",
                keyColumn: "FeatureFlagID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 537, DateTimeKind.Local).AddTicks(8508));

            migrationBuilder.UpdateData(
                table: "Frequencies",
                keyColumn: "FrequencyID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 501, DateTimeKind.Local).AddTicks(9786));

            migrationBuilder.UpdateData(
                table: "Frequencies",
                keyColumn: "FrequencyID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 502, DateTimeKind.Local).AddTicks(1337));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "GenderID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 521, DateTimeKind.Local).AddTicks(748));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "GenderID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 521, DateTimeKind.Local).AddTicks(987));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 555, DateTimeKind.Local).AddTicks(4950));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 555, DateTimeKind.Local).AddTicks(5384));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 555, DateTimeKind.Local).AddTicks(5396));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 555, DateTimeKind.Local).AddTicks(5411));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 555, DateTimeKind.Local).AddTicks(5405));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 999,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 555, DateTimeKind.Local).AddTicks(5445));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 9998,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 555, DateTimeKind.Local).AddTicks(5430));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 562, DateTimeKind.Local).AddTicks(5710));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 562, DateTimeKind.Local).AddTicks(6201));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 562, DateTimeKind.Local).AddTicks(6214));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 562, DateTimeKind.Local).AddTicks(6221));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 562, DateTimeKind.Local).AddTicks(6228));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 562, DateTimeKind.Local).AddTicks(6246));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 562, DateTimeKind.Local).AddTicks(6254));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 562, DateTimeKind.Local).AddTicks(6263));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 562, DateTimeKind.Local).AddTicks(6271));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 562, DateTimeKind.Local).AddTicks(6282));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 562, DateTimeKind.Local).AddTicks(6290));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 562, DateTimeKind.Local).AddTicks(6297));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 13,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 562, DateTimeKind.Local).AddTicks(6304));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 14,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 562, DateTimeKind.Local).AddTicks(6315));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 15,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 562, DateTimeKind.Local).AddTicks(6322));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 16,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 562, DateTimeKind.Local).AddTicks(6329));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 17,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 562, DateTimeKind.Local).AddTicks(6335));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 18,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 562, DateTimeKind.Local).AddTicks(6344));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 19,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 562, DateTimeKind.Local).AddTicks(6350));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 20,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 562, DateTimeKind.Local).AddTicks(6357));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 21,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 562, DateTimeKind.Local).AddTicks(6363));

            migrationBuilder.UpdateData(
                table: "PaymentStatus",
                keyColumn: "PaymentStatusID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 478, DateTimeKind.Local).AddTicks(4548));

            migrationBuilder.UpdateData(
                table: "PaymentStatus",
                keyColumn: "PaymentStatusID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 478, DateTimeKind.Local).AddTicks(5304));

            migrationBuilder.UpdateData(
                table: "PaymentStatus",
                keyColumn: "PaymentStatusID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 478, DateTimeKind.Local).AddTicks(5312));

            migrationBuilder.UpdateData(
                table: "PaymentStatus",
                keyColumn: "PaymentStatusID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 478, DateTimeKind.Local).AddTicks(5316));

            migrationBuilder.UpdateData(
                table: "PaymentStatus",
                keyColumn: "PaymentStatusID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 478, DateTimeKind.Local).AddTicks(5320));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 473, DateTimeKind.Local).AddTicks(1548));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 473, DateTimeKind.Local).AddTicks(2338));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 473, DateTimeKind.Local).AddTicks(2351));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 473, DateTimeKind.Local).AddTicks(2358));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 473, DateTimeKind.Local).AddTicks(2364));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 473, DateTimeKind.Local).AddTicks(2380));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 473, DateTimeKind.Local).AddTicks(2385));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 473, DateTimeKind.Local).AddTicks(2390));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 473, DateTimeKind.Local).AddTicks(2396));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 473, DateTimeKind.Local).AddTicks(2404));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 473, DateTimeKind.Local).AddTicks(2410));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 473, DateTimeKind.Local).AddTicks(2415));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 13,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 473, DateTimeKind.Local).AddTicks(2421));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 14,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 473, DateTimeKind.Local).AddTicks(2426));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 15,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 473, DateTimeKind.Local).AddTicks(2432));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 16,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 473, DateTimeKind.Local).AddTicks(2437));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 17,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 473, DateTimeKind.Local).AddTicks(2444));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 18,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 473, DateTimeKind.Local).AddTicks(2451));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 19,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 473, DateTimeKind.Local).AddTicks(2457));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 20,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 473, DateTimeKind.Local).AddTicks(2462));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 21,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 473, DateTimeKind.Local).AddTicks(2467));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 22,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 473, DateTimeKind.Local).AddTicks(2472));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 23,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 473, DateTimeKind.Local).AddTicks(2478));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 24,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 473, DateTimeKind.Local).AddTicks(2484));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 25,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 473, DateTimeKind.Local).AddTicks(2490));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 26,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 473, DateTimeKind.Local).AddTicks(2496));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 27,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 473, DateTimeKind.Local).AddTicks(2502));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 28,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 473, DateTimeKind.Local).AddTicks(2507));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 29,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 473, DateTimeKind.Local).AddTicks(2512));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 30,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 473, DateTimeKind.Local).AddTicks(2517));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 31,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 473, DateTimeKind.Local).AddTicks(2523));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 32,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 473, DateTimeKind.Local).AddTicks(2529));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 33,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 473, DateTimeKind.Local).AddTicks(2534));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 34,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 473, DateTimeKind.Local).AddTicks(2542));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 35,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 473, DateTimeKind.Local).AddTicks(2548));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 36,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 473, DateTimeKind.Local).AddTicks(2554));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 37,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 473, DateTimeKind.Local).AddTicks(2560));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 38,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 473, DateTimeKind.Local).AddTicks(2596));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 39,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 473, DateTimeKind.Local).AddTicks(2601));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 40,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 473, DateTimeKind.Local).AddTicks(2608));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 41,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 473, DateTimeKind.Local).AddTicks(2613));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 42,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 473, DateTimeKind.Local).AddTicks(2619));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 43,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 473, DateTimeKind.Local).AddTicks(2624));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 44,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 473, DateTimeKind.Local).AddTicks(2629));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 45,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 473, DateTimeKind.Local).AddTicks(2633));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 46,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 473, DateTimeKind.Local).AddTicks(2639));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 47,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 473, DateTimeKind.Local).AddTicks(2645));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 48,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 473, DateTimeKind.Local).AddTicks(2650));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 49,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 473, DateTimeKind.Local).AddTicks(2656));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 50,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 473, DateTimeKind.Local).AddTicks(2662));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 51,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 473, DateTimeKind.Local).AddTicks(2668));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 52,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 473, DateTimeKind.Local).AddTicks(2673));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 53,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 473, DateTimeKind.Local).AddTicks(2678));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 54,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 473, DateTimeKind.Local).AddTicks(2683));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 55,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 473, DateTimeKind.Local).AddTicks(2688));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 56,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 473, DateTimeKind.Local).AddTicks(2694));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 57,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 473, DateTimeKind.Local).AddTicks(2699));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 58,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 473, DateTimeKind.Local).AddTicks(2704));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 59,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 473, DateTimeKind.Local).AddTicks(2709));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 60,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 473, DateTimeKind.Local).AddTicks(2715));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 61,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 473, DateTimeKind.Local).AddTicks(2720));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 62,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 473, DateTimeKind.Local).AddTicks(2725));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 63,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 473, DateTimeKind.Local).AddTicks(2730));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 64,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 473, DateTimeKind.Local).AddTicks(2735));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 65,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 473, DateTimeKind.Local).AddTicks(2740));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 66,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 473, DateTimeKind.Local).AddTicks(2748));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 67,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 473, DateTimeKind.Local).AddTicks(2753));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 68,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 473, DateTimeKind.Local).AddTicks(2759));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 69,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 473, DateTimeKind.Local).AddTicks(2763));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 70,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 473, DateTimeKind.Local).AddTicks(2768));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 71,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 473, DateTimeKind.Local).AddTicks(2773));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 72,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 473, DateTimeKind.Local).AddTicks(2779));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 73,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 473, DateTimeKind.Local).AddTicks(2784));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 74,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 473, DateTimeKind.Local).AddTicks(2789));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 75,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 473, DateTimeKind.Local).AddTicks(2793));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 76,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 473, DateTimeKind.Local).AddTicks(2799));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 77,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 473, DateTimeKind.Local).AddTicks(2804));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 78,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 473, DateTimeKind.Local).AddTicks(2809));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 79,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 473, DateTimeKind.Local).AddTicks(2942));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 80,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 473, DateTimeKind.Local).AddTicks(2949));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 81,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 473, DateTimeKind.Local).AddTicks(2954));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 82,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 473, DateTimeKind.Local).AddTicks(2960));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 83,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 473, DateTimeKind.Local).AddTicks(2965));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 84,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 473, DateTimeKind.Local).AddTicks(2971));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 85,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 473, DateTimeKind.Local).AddTicks(2977));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 86,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 473, DateTimeKind.Local).AddTicks(2982));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 87,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 473, DateTimeKind.Local).AddTicks(2987));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 88,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 473, DateTimeKind.Local).AddTicks(2992));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 89,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 473, DateTimeKind.Local).AddTicks(2997));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 90,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 473, DateTimeKind.Local).AddTicks(3002));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 91,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 473, DateTimeKind.Local).AddTicks(3009));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 92,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 473, DateTimeKind.Local).AddTicks(3014));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 93,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 473, DateTimeKind.Local).AddTicks(3020));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 94,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 473, DateTimeKind.Local).AddTicks(3025));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 95,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 473, DateTimeKind.Local).AddTicks(3030));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 96,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 473, DateTimeKind.Local).AddTicks(3036));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 97,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 473, DateTimeKind.Local).AddTicks(3041));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 98,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 473, DateTimeKind.Local).AddTicks(3046));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 99,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 473, DateTimeKind.Local).AddTicks(3051));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 100,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 473, DateTimeKind.Local).AddTicks(3056));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 101,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 473, DateTimeKind.Local).AddTicks(3060));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 102,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 473, DateTimeKind.Local).AddTicks(3065));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 103,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 473, DateTimeKind.Local).AddTicks(3070));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 104,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 473, DateTimeKind.Local).AddTicks(3076));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 105,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 473, DateTimeKind.Local).AddTicks(3082));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 106,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 473, DateTimeKind.Local).AddTicks(3088));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 107,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 473, DateTimeKind.Local).AddTicks(3093));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 108,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 473, DateTimeKind.Local).AddTicks(3099));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 109,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 473, DateTimeKind.Local).AddTicks(3104));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 110,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 473, DateTimeKind.Local).AddTicks(3110));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 111,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 473, DateTimeKind.Local).AddTicks(3115));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 112,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 473, DateTimeKind.Local).AddTicks(3121));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 113,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 473, DateTimeKind.Local).AddTicks(3125));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 114,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 473, DateTimeKind.Local).AddTicks(3131));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 115,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 473, DateTimeKind.Local).AddTicks(3136));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 116,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 473, DateTimeKind.Local).AddTicks(3141));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 117,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 473, DateTimeKind.Local).AddTicks(3146));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 118,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 473, DateTimeKind.Local).AddTicks(3151));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 119,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 473, DateTimeKind.Local).AddTicks(3157));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 120,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 473, DateTimeKind.Local).AddTicks(3162));

            migrationBuilder.UpdateData(
                table: "PriorityRanks",
                keyColumn: "PriorityRankID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 527, DateTimeKind.Local).AddTicks(2910));

            migrationBuilder.UpdateData(
                table: "PriorityRanks",
                keyColumn: "PriorityRankID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 527, DateTimeKind.Local).AddTicks(3121));

            migrationBuilder.UpdateData(
                table: "PriorityRanks",
                keyColumn: "PriorityRankID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 527, DateTimeKind.Local).AddTicks(3128));

            migrationBuilder.UpdateData(
                table: "PriorityRanks",
                keyColumn: "PriorityRankID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 527, DateTimeKind.Local).AddTicks(3132));

            migrationBuilder.UpdateData(
                table: "RelationshipTypes",
                keyColumn: "RelationshipTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 513, DateTimeKind.Local).AddTicks(7574));

            migrationBuilder.UpdateData(
                table: "RelationshipTypes",
                keyColumn: "RelationshipTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 513, DateTimeKind.Local).AddTicks(8144));

            migrationBuilder.UpdateData(
                table: "RelationshipTypes",
                keyColumn: "RelationshipTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 513, DateTimeKind.Local).AddTicks(8152));

            migrationBuilder.UpdateData(
                table: "RelationshipTypes",
                keyColumn: "RelationshipTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 513, DateTimeKind.Local).AddTicks(8156));

            migrationBuilder.UpdateData(
                table: "RelationshipTypes",
                keyColumn: "RelationshipTypeID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 513, DateTimeKind.Local).AddTicks(8161));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 591, DateTimeKind.Local).AddTicks(6895));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 591, DateTimeKind.Local).AddTicks(7200));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 591, DateTimeKind.Local).AddTicks(7208));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 591, DateTimeKind.Local).AddTicks(7213));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 591, DateTimeKind.Local).AddTicks(7218));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 591, DateTimeKind.Local).AddTicks(7228));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 591, DateTimeKind.Local).AddTicks(7233));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 591, DateTimeKind.Local).AddTicks(7238));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 591, DateTimeKind.Local).AddTicks(7243));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 591, DateTimeKind.Local).AddTicks(7248));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 591, DateTimeKind.Local).AddTicks(7252));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 591, DateTimeKind.Local).AddTicks(7256));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 13,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 591, DateTimeKind.Local).AddTicks(7260));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 14,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 591, DateTimeKind.Local).AddTicks(7266));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 15,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 591, DateTimeKind.Local).AddTicks(7269));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 16,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 591, DateTimeKind.Local).AddTicks(7273));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 17,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 591, DateTimeKind.Local).AddTicks(7278));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 18,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 591, DateTimeKind.Local).AddTicks(7284));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 19,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 591, DateTimeKind.Local).AddTicks(7288));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 20,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 591, DateTimeKind.Local).AddTicks(7292));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 21,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 591, DateTimeKind.Local).AddTicks(7295));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 474, DateTimeKind.Local).AddTicks(3801));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 474, DateTimeKind.Local).AddTicks(3962));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 474, DateTimeKind.Local).AddTicks(3965));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 474, DateTimeKind.Local).AddTicks(3968));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 474, DateTimeKind.Local).AddTicks(3970));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 474, DateTimeKind.Local).AddTicks(3976));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 474, DateTimeKind.Local).AddTicks(3978));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 474, DateTimeKind.Local).AddTicks(3980));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 474, DateTimeKind.Local).AddTicks(3982));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 474, DateTimeKind.Local).AddTicks(3985));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 474, DateTimeKind.Local).AddTicks(3987));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 474, DateTimeKind.Local).AddTicks(3990));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 13,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 474, DateTimeKind.Local).AddTicks(3992));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 14,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 474, DateTimeKind.Local).AddTicks(3994));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 15,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 474, DateTimeKind.Local).AddTicks(3996));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 16,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 474, DateTimeKind.Local).AddTicks(3998));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 17,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 474, DateTimeKind.Local).AddTicks(4000));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 18,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 474, DateTimeKind.Local).AddTicks(4004));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 19,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 474, DateTimeKind.Local).AddTicks(4006));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 20,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 474, DateTimeKind.Local).AddTicks(4008));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 21,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 474, DateTimeKind.Local).AddTicks(4010));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 22,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 474, DateTimeKind.Local).AddTicks(4032));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 23,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 474, DateTimeKind.Local).AddTicks(4036));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 24,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 474, DateTimeKind.Local).AddTicks(4039));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 25,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 474, DateTimeKind.Local).AddTicks(4041));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 26,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 474, DateTimeKind.Local).AddTicks(4043));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 27,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 474, DateTimeKind.Local).AddTicks(4045));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 28,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 474, DateTimeKind.Local).AddTicks(4047));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 29,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 474, DateTimeKind.Local).AddTicks(4049));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 30,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 474, DateTimeKind.Local).AddTicks(4052));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 31,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 474, DateTimeKind.Local).AddTicks(4054));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 32,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 474, DateTimeKind.Local).AddTicks(4056));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 33,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 474, DateTimeKind.Local).AddTicks(4058));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 34,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 474, DateTimeKind.Local).AddTicks(4062));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 35,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 474, DateTimeKind.Local).AddTicks(4064));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 36,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 474, DateTimeKind.Local).AddTicks(4067));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 37,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 474, DateTimeKind.Local).AddTicks(4069));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 38,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 474, DateTimeKind.Local).AddTicks(4071));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 39,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 474, DateTimeKind.Local).AddTicks(4073));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 40,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 474, DateTimeKind.Local).AddTicks(4075));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 41,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 474, DateTimeKind.Local).AddTicks(4077));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 42,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 474, DateTimeKind.Local).AddTicks(4079));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 43,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 474, DateTimeKind.Local).AddTicks(4081));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 44,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 474, DateTimeKind.Local).AddTicks(4083));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 45,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 474, DateTimeKind.Local).AddTicks(4085));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 46,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 474, DateTimeKind.Local).AddTicks(4087));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 47,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 474, DateTimeKind.Local).AddTicks(4090));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 48,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 474, DateTimeKind.Local).AddTicks(4092));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 49,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 474, DateTimeKind.Local).AddTicks(4094));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 50,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 474, DateTimeKind.Local).AddTicks(4096));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 51,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 474, DateTimeKind.Local).AddTicks(4098));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 52,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 474, DateTimeKind.Local).AddTicks(4100));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 53,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 474, DateTimeKind.Local).AddTicks(4103));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 54,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 474, DateTimeKind.Local).AddTicks(4105));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 55,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 474, DateTimeKind.Local).AddTicks(4107));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 56,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 474, DateTimeKind.Local).AddTicks(4109));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 57,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 474, DateTimeKind.Local).AddTicks(4111));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 58,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 474, DateTimeKind.Local).AddTicks(4113));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 59,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 474, DateTimeKind.Local).AddTicks(4115));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 60,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 474, DateTimeKind.Local).AddTicks(4117));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 61,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 474, DateTimeKind.Local).AddTicks(4119));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 62,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 474, DateTimeKind.Local).AddTicks(4121));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 63,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 474, DateTimeKind.Local).AddTicks(4123));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 64,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 474, DateTimeKind.Local).AddTicks(4125));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 65,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 474, DateTimeKind.Local).AddTicks(4128));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 66,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 474, DateTimeKind.Local).AddTicks(4132));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 67,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 474, DateTimeKind.Local).AddTicks(4135));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 68,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 474, DateTimeKind.Local).AddTicks(4137));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 69,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 474, DateTimeKind.Local).AddTicks(4139));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 70,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 474, DateTimeKind.Local).AddTicks(4141));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 71,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 474, DateTimeKind.Local).AddTicks(4143));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 72,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 474, DateTimeKind.Local).AddTicks(4145));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 73,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 474, DateTimeKind.Local).AddTicks(4147));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 74,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 474, DateTimeKind.Local).AddTicks(4149));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 75,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 474, DateTimeKind.Local).AddTicks(4151));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 76,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 474, DateTimeKind.Local).AddTicks(4153));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 77,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 474, DateTimeKind.Local).AddTicks(4155));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 78,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 474, DateTimeKind.Local).AddTicks(4157));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 79,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 474, DateTimeKind.Local).AddTicks(4160));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 80,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 474, DateTimeKind.Local).AddTicks(4162));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 81,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 474, DateTimeKind.Local).AddTicks(4164));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 82,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 474, DateTimeKind.Local).AddTicks(4166));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 83,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 474, DateTimeKind.Local).AddTicks(4168));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 84,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 474, DateTimeKind.Local).AddTicks(4170));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 85,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 474, DateTimeKind.Local).AddTicks(4172));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 86,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 474, DateTimeKind.Local).AddTicks(4174));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 87,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 474, DateTimeKind.Local).AddTicks(4176));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 88,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 474, DateTimeKind.Local).AddTicks(4178));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 89,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 474, DateTimeKind.Local).AddTicks(4181));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 90,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 474, DateTimeKind.Local).AddTicks(4183));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 91,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 474, DateTimeKind.Local).AddTicks(4185));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 92,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 474, DateTimeKind.Local).AddTicks(4187));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 93,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 474, DateTimeKind.Local).AddTicks(4189));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 94,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 474, DateTimeKind.Local).AddTicks(4191));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 95,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 474, DateTimeKind.Local).AddTicks(4193));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 96,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 474, DateTimeKind.Local).AddTicks(4195));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 97,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 474, DateTimeKind.Local).AddTicks(4197));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 98,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 474, DateTimeKind.Local).AddTicks(4199));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 99,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 474, DateTimeKind.Local).AddTicks(4201));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 100,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 474, DateTimeKind.Local).AddTicks(4203));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 101,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 474, DateTimeKind.Local).AddTicks(4206));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 102,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 474, DateTimeKind.Local).AddTicks(4208));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 103,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 474, DateTimeKind.Local).AddTicks(4210));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 104,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 474, DateTimeKind.Local).AddTicks(4212));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 105,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 474, DateTimeKind.Local).AddTicks(4214));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 106,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 474, DateTimeKind.Local).AddTicks(4216));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 107,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 474, DateTimeKind.Local).AddTicks(4218));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 108,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 474, DateTimeKind.Local).AddTicks(4220));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 109,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 474, DateTimeKind.Local).AddTicks(4222));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 110,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 474, DateTimeKind.Local).AddTicks(4224));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 111,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 474, DateTimeKind.Local).AddTicks(4226));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 112,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 474, DateTimeKind.Local).AddTicks(4228));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 113,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 474, DateTimeKind.Local).AddTicks(4230));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 114,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 474, DateTimeKind.Local).AddTicks(4232));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 115,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 474, DateTimeKind.Local).AddTicks(4234));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 116,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 474, DateTimeKind.Local).AddTicks(4236));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 117,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 474, DateTimeKind.Local).AddTicks(4239));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 118,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 474, DateTimeKind.Local).AddTicks(4241));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 119,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 474, DateTimeKind.Local).AddTicks(4243));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 120,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 474, DateTimeKind.Local).AddTicks(4245));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 463, DateTimeKind.Local).AddTicks(894));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 465, DateTimeKind.Local).AddTicks(7171));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 465, DateTimeKind.Local).AddTicks(7269));

            migrationBuilder.UpdateData(
                table: "SystemVariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 519, DateTimeKind.Local).AddTicks(3403));

            migrationBuilder.UpdateData(
                table: "SystemVariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 519, DateTimeKind.Local).AddTicks(3797));

            migrationBuilder.UpdateData(
                table: "SystemVariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 519, DateTimeKind.Local).AddTicks(3790));

            migrationBuilder.UpdateData(
                table: "SystemVariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 519, DateTimeKind.Local).AddTicks(3783));

            migrationBuilder.UpdateData(
                table: "SystemVariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 519, DateTimeKind.Local).AddTicks(3772));

            migrationBuilder.UpdateData(
                table: "SystemVariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 519, DateTimeKind.Local).AddTicks(3815));

            migrationBuilder.UpdateData(
                table: "SystemVariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 519, DateTimeKind.Local).AddTicks(3833));

            migrationBuilder.UpdateData(
                table: "SystemVariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 519, DateTimeKind.Local).AddTicks(3840));

            migrationBuilder.UpdateData(
                table: "SystemVariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 519, DateTimeKind.Local).AddTicks(3848));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 483, DateTimeKind.Local).AddTicks(3593));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 483, DateTimeKind.Local).AddTicks(5127));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 483, DateTimeKind.Local).AddTicks(5304));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 483, DateTimeKind.Local).AddTicks(5476));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 483, DateTimeKind.Local).AddTicks(5590));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 483, DateTimeKind.Local).AddTicks(5686));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 483, DateTimeKind.Local).AddTicks(5764));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 483, DateTimeKind.Local).AddTicks(5836));

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumns: new[] { "UserID", "RoleID" },
                keyValues: new object[] { 1, 1 },
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 552, DateTimeKind.Local).AddTicks(5345));

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumns: new[] { "UserID", "RoleID" },
                keyValues: new object[] { 2, 3 },
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 552, DateTimeKind.Local).AddTicks(5553));

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "UserTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 508, DateTimeKind.Local).AddTicks(8797));

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "UserTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 509, DateTimeKind.Local).AddTicks(197));

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "UserTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 509, DateTimeKind.Local).AddTicks(210));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 528, DateTimeKind.Local).AddTicks(6359));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 533, DateTimeKind.Local).AddTicks(948));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 7, 17, 17, 12, 533, DateTimeKind.Local).AddTicks(1433));
        }
    }
}
