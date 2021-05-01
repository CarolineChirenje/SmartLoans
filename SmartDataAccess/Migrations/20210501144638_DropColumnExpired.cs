using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SmartDataAccess.Migrations
{
    public partial class DropColumnExpired : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "HasExpired",
                table: "Maintanances");

            migrationBuilder.UpdateData(
                table: "BankAccountTypes",
                keyColumn: "BankAccountTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 416, DateTimeKind.Local).AddTicks(7717));

            migrationBuilder.UpdateData(
                table: "BankAccountTypes",
                keyColumn: "BankAccountTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 416, DateTimeKind.Local).AddTicks(8456));

            migrationBuilder.UpdateData(
                table: "BankAccountTypes",
                keyColumn: "BankAccountTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 416, DateTimeKind.Local).AddTicks(8466));

            migrationBuilder.UpdateData(
                table: "BankAccountTypes",
                keyColumn: "BankAccountTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 416, DateTimeKind.Local).AddTicks(8472));

            migrationBuilder.UpdateData(
                table: "ClientAccountTypes",
                keyColumn: "ID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 490, DateTimeKind.Local).AddTicks(4744));

            migrationBuilder.UpdateData(
                table: "ClientAccountTypes",
                keyColumn: "ID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 490, DateTimeKind.Local).AddTicks(5907));

            migrationBuilder.UpdateData(
                table: "ClientGroups",
                keyColumn: "ClientGroupID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 499, DateTimeKind.Local).AddTicks(2641));

            migrationBuilder.UpdateData(
                table: "ClientGroups",
                keyColumn: "ClientGroupID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 499, DateTimeKind.Local).AddTicks(3656));

            migrationBuilder.UpdateData(
                table: "ContactTypes",
                keyColumn: "ContactTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 429, DateTimeKind.Local).AddTicks(6920));

            migrationBuilder.UpdateData(
                table: "ContactTypes",
                keyColumn: "ContactTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 429, DateTimeKind.Local).AddTicks(6913));

            migrationBuilder.UpdateData(
                table: "ContactTypes",
                keyColumn: "ContactTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 429, DateTimeKind.Local).AddTicks(6904));

            migrationBuilder.UpdateData(
                table: "ContactTypes",
                keyColumn: "ContactTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 429, DateTimeKind.Local).AddTicks(6755));

            migrationBuilder.UpdateData(
                table: "ContactTypes",
                keyColumn: "ContactTypeID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 429, DateTimeKind.Local).AddTicks(6931));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 438, DateTimeKind.Local).AddTicks(7200));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 438, DateTimeKind.Local).AddTicks(8148));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 438, DateTimeKind.Local).AddTicks(8169));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 438, DateTimeKind.Local).AddTicks(8181));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 438, DateTimeKind.Local).AddTicks(8186));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 438, DateTimeKind.Local).AddTicks(8201));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 438, DateTimeKind.Local).AddTicks(8206));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 438, DateTimeKind.Local).AddTicks(8212));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 438, DateTimeKind.Local).AddTicks(8217));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 438, DateTimeKind.Local).AddTicks(8224));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 438, DateTimeKind.Local).AddTicks(8257));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 438, DateTimeKind.Local).AddTicks(8263));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 13,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 438, DateTimeKind.Local).AddTicks(8268));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 14,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 438, DateTimeKind.Local).AddTicks(8272));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 15,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 438, DateTimeKind.Local).AddTicks(8277));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 16,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 438, DateTimeKind.Local).AddTicks(8283));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 17,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 438, DateTimeKind.Local).AddTicks(8288));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 18,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 438, DateTimeKind.Local).AddTicks(8297));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 19,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 438, DateTimeKind.Local).AddTicks(8303));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 20,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 438, DateTimeKind.Local).AddTicks(8310));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 21,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 438, DateTimeKind.Local).AddTicks(8315));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 22,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 438, DateTimeKind.Local).AddTicks(8320));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 23,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 438, DateTimeKind.Local).AddTicks(8325));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 24,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 438, DateTimeKind.Local).AddTicks(8329));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 25,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 438, DateTimeKind.Local).AddTicks(8334));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 26,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 438, DateTimeKind.Local).AddTicks(8338));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 27,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 438, DateTimeKind.Local).AddTicks(8345));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 28,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 438, DateTimeKind.Local).AddTicks(8349));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 29,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 438, DateTimeKind.Local).AddTicks(8354));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 30,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 438, DateTimeKind.Local).AddTicks(8361));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 31,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 438, DateTimeKind.Local).AddTicks(8366));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 32,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 438, DateTimeKind.Local).AddTicks(8371));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 33,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 438, DateTimeKind.Local).AddTicks(8377));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 34,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 438, DateTimeKind.Local).AddTicks(8385));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 35,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 438, DateTimeKind.Local).AddTicks(8389));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 36,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 438, DateTimeKind.Local).AddTicks(8394));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 37,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 438, DateTimeKind.Local).AddTicks(8399));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 38,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 438, DateTimeKind.Local).AddTicks(8404));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 39,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 438, DateTimeKind.Local).AddTicks(8410));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 40,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 438, DateTimeKind.Local).AddTicks(8415));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 41,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 438, DateTimeKind.Local).AddTicks(8422));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 42,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 438, DateTimeKind.Local).AddTicks(8426));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 43,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 438, DateTimeKind.Local).AddTicks(8432));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 44,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 438, DateTimeKind.Local).AddTicks(8436));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 45,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 438, DateTimeKind.Local).AddTicks(8441));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 46,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 438, DateTimeKind.Local).AddTicks(8446));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 47,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 438, DateTimeKind.Local).AddTicks(8452));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 48,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 438, DateTimeKind.Local).AddTicks(8459));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 49,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 438, DateTimeKind.Local).AddTicks(8464));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 50,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 438, DateTimeKind.Local).AddTicks(8470));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 51,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 438, DateTimeKind.Local).AddTicks(8475));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 52,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 438, DateTimeKind.Local).AddTicks(8480));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 53,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 438, DateTimeKind.Local).AddTicks(8484));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 54,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 438, DateTimeKind.Local).AddTicks(8488));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 55,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 438, DateTimeKind.Local).AddTicks(8493));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 56,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 438, DateTimeKind.Local).AddTicks(8498));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 57,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 438, DateTimeKind.Local).AddTicks(8502));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 58,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 438, DateTimeKind.Local).AddTicks(8507));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 59,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 438, DateTimeKind.Local).AddTicks(8513));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 60,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 438, DateTimeKind.Local).AddTicks(8518));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 61,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 438, DateTimeKind.Local).AddTicks(8524));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 62,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 438, DateTimeKind.Local).AddTicks(8529));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 63,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 438, DateTimeKind.Local).AddTicks(8534));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 64,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 438, DateTimeKind.Local).AddTicks(8540));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 65,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 438, DateTimeKind.Local).AddTicks(8545));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 66,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 438, DateTimeKind.Local).AddTicks(8564));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 67,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 438, DateTimeKind.Local).AddTicks(8569));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 68,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 438, DateTimeKind.Local).AddTicks(8575));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 69,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 438, DateTimeKind.Local).AddTicks(8579));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 70,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 438, DateTimeKind.Local).AddTicks(8584));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 71,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 438, DateTimeKind.Local).AddTicks(8589));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 72,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 438, DateTimeKind.Local).AddTicks(8595));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 73,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 438, DateTimeKind.Local).AddTicks(8600));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 74,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 438, DateTimeKind.Local).AddTicks(8606));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 75,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 438, DateTimeKind.Local).AddTicks(8611));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 76,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 438, DateTimeKind.Local).AddTicks(8616));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 77,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 438, DateTimeKind.Local).AddTicks(8622));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 78,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 438, DateTimeKind.Local).AddTicks(8626));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 79,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 438, DateTimeKind.Local).AddTicks(8631));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 80,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 438, DateTimeKind.Local).AddTicks(8637));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 81,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 438, DateTimeKind.Local).AddTicks(8641));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 82,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 438, DateTimeKind.Local).AddTicks(8646));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 83,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 438, DateTimeKind.Local).AddTicks(8655));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 84,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 438, DateTimeKind.Local).AddTicks(8662));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 85,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 438, DateTimeKind.Local).AddTicks(8668));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 86,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 438, DateTimeKind.Local).AddTicks(8674));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 87,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 438, DateTimeKind.Local).AddTicks(8678));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 88,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 438, DateTimeKind.Local).AddTicks(8683));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 89,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 438, DateTimeKind.Local).AddTicks(8689));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 90,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 438, DateTimeKind.Local).AddTicks(8694));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 91,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 438, DateTimeKind.Local).AddTicks(8699));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 92,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 438, DateTimeKind.Local).AddTicks(8707));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 93,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 438, DateTimeKind.Local).AddTicks(8713));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 94,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 438, DateTimeKind.Local).AddTicks(8719));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 95,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 438, DateTimeKind.Local).AddTicks(8724));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 96,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 438, DateTimeKind.Local).AddTicks(8728));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 97,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 438, DateTimeKind.Local).AddTicks(8732));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 98,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 438, DateTimeKind.Local).AddTicks(8736));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 99,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 438, DateTimeKind.Local).AddTicks(8741));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 100,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 438, DateTimeKind.Local).AddTicks(8745));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 101,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 438, DateTimeKind.Local).AddTicks(8752));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 102,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 438, DateTimeKind.Local).AddTicks(8757));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 103,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 438, DateTimeKind.Local).AddTicks(8762));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 104,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 438, DateTimeKind.Local).AddTicks(8766));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 105,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 438, DateTimeKind.Local).AddTicks(8771));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 106,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 438, DateTimeKind.Local).AddTicks(8776));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 107,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 438, DateTimeKind.Local).AddTicks(8781));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 108,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 438, DateTimeKind.Local).AddTicks(8787));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 109,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 438, DateTimeKind.Local).AddTicks(8791));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 110,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 438, DateTimeKind.Local).AddTicks(8796));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 111,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 438, DateTimeKind.Local).AddTicks(8802));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 112,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 438, DateTimeKind.Local).AddTicks(8807));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 113,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 438, DateTimeKind.Local).AddTicks(8812));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 114,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 438, DateTimeKind.Local).AddTicks(8816));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 115,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 438, DateTimeKind.Local).AddTicks(8823));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 116,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 438, DateTimeKind.Local).AddTicks(8828));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 117,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 438, DateTimeKind.Local).AddTicks(8833));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 118,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 438, DateTimeKind.Local).AddTicks(8838));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 119,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 438, DateTimeKind.Local).AddTicks(8843));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 120,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 438, DateTimeKind.Local).AddTicks(8847));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 121,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 438, DateTimeKind.Local).AddTicks(8853));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 122,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 438, DateTimeKind.Local).AddTicks(8857));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 123,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 438, DateTimeKind.Local).AddTicks(8863));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 124,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 438, DateTimeKind.Local).AddTicks(8868));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 125,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 438, DateTimeKind.Local).AddTicks(8874));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 126,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 438, DateTimeKind.Local).AddTicks(8878));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 127,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 438, DateTimeKind.Local).AddTicks(8882));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 128,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 438, DateTimeKind.Local).AddTicks(8887));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 129,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 438, DateTimeKind.Local).AddTicks(8892));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 130,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 438, DateTimeKind.Local).AddTicks(8914));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 131,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 438, DateTimeKind.Local).AddTicks(8920));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 132,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 438, DateTimeKind.Local).AddTicks(8925));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 133,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 438, DateTimeKind.Local).AddTicks(8930));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 134,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 438, DateTimeKind.Local).AddTicks(8934));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 135,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 438, DateTimeKind.Local).AddTicks(8941));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 136,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 438, DateTimeKind.Local).AddTicks(8946));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 137,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 438, DateTimeKind.Local).AddTicks(8950));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 138,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 438, DateTimeKind.Local).AddTicks(8956));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 139,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 438, DateTimeKind.Local).AddTicks(8961));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 140,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 438, DateTimeKind.Local).AddTicks(8966));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 141,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 438, DateTimeKind.Local).AddTicks(8971));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 142,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 438, DateTimeKind.Local).AddTicks(8975));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 143,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 438, DateTimeKind.Local).AddTicks(8980));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 144,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 438, DateTimeKind.Local).AddTicks(8985));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 145,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 438, DateTimeKind.Local).AddTicks(8991));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 146,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 438, DateTimeKind.Local).AddTicks(8996));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 147,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 438, DateTimeKind.Local).AddTicks(9001));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 148,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 438, DateTimeKind.Local).AddTicks(9005));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 149,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 438, DateTimeKind.Local).AddTicks(9011));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 150,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 438, DateTimeKind.Local).AddTicks(9017));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 151,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 438, DateTimeKind.Local).AddTicks(9022));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 152,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 438, DateTimeKind.Local).AddTicks(9027));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 153,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 438, DateTimeKind.Local).AddTicks(9034));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 154,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 438, DateTimeKind.Local).AddTicks(9039));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 155,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 438, DateTimeKind.Local).AddTicks(9044));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 156,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 438, DateTimeKind.Local).AddTicks(9049));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 157,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 438, DateTimeKind.Local).AddTicks(9054));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 158,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 438, DateTimeKind.Local).AddTicks(9059));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 159,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 438, DateTimeKind.Local).AddTicks(9064));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 160,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 438, DateTimeKind.Local).AddTicks(9068));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 161,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 438, DateTimeKind.Local).AddTicks(9074));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 162,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 438, DateTimeKind.Local).AddTicks(9078));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 163,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 438, DateTimeKind.Local).AddTicks(9082));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 164,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 438, DateTimeKind.Local).AddTicks(9087));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 165,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 438, DateTimeKind.Local).AddTicks(9091));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 166,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 438, DateTimeKind.Local).AddTicks(9096));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 167,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 438, DateTimeKind.Local).AddTicks(9103));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 168,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 438, DateTimeKind.Local).AddTicks(9108));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 169,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 438, DateTimeKind.Local).AddTicks(9113));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 170,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 438, DateTimeKind.Local).AddTicks(9118));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 171,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 438, DateTimeKind.Local).AddTicks(9122));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 172,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 438, DateTimeKind.Local).AddTicks(9127));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 173,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 438, DateTimeKind.Local).AddTicks(9133));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 174,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 438, DateTimeKind.Local).AddTicks(9139));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 175,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 438, DateTimeKind.Local).AddTicks(9145));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 176,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 438, DateTimeKind.Local).AddTicks(9152));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 177,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 438, DateTimeKind.Local).AddTicks(9159));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 178,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 438, DateTimeKind.Local).AddTicks(9164));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 179,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 438, DateTimeKind.Local).AddTicks(9170));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 180,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 438, DateTimeKind.Local).AddTicks(9177));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 181,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 438, DateTimeKind.Local).AddTicks(9182));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 182,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 438, DateTimeKind.Local).AddTicks(9187));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 183,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 438, DateTimeKind.Local).AddTicks(9192));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 184,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 438, DateTimeKind.Local).AddTicks(9196));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 185,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 438, DateTimeKind.Local).AddTicks(9201));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 186,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 438, DateTimeKind.Local).AddTicks(9218));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 187,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 438, DateTimeKind.Local).AddTicks(9224));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 188,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 438, DateTimeKind.Local).AddTicks(9229));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 189,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 438, DateTimeKind.Local).AddTicks(9236));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 190,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 438, DateTimeKind.Local).AddTicks(9241));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 191,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 438, DateTimeKind.Local).AddTicks(9246));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 192,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 438, DateTimeKind.Local).AddTicks(9250));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 193,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 438, DateTimeKind.Local).AddTicks(9255));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 194,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 438, DateTimeKind.Local).AddTicks(9259));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 195,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 438, DateTimeKind.Local).AddTicks(9263));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 196,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 438, DateTimeKind.Local).AddTicks(9267));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 197,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 438, DateTimeKind.Local).AddTicks(9271));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 198,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 438, DateTimeKind.Local).AddTicks(9275));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 199,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 438, DateTimeKind.Local).AddTicks(9279));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 200,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 438, DateTimeKind.Local).AddTicks(9283));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 201,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 438, DateTimeKind.Local).AddTicks(9288));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 202,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 438, DateTimeKind.Local).AddTicks(9292));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 203,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 438, DateTimeKind.Local).AddTicks(9296));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 204,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 438, DateTimeKind.Local).AddTicks(9301));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 205,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 438, DateTimeKind.Local).AddTicks(9307));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 206,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 438, DateTimeKind.Local).AddTicks(9313));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 207,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 438, DateTimeKind.Local).AddTicks(9317));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 208,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 438, DateTimeKind.Local).AddTicks(9321));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 209,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 438, DateTimeKind.Local).AddTicks(9327));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 210,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 438, DateTimeKind.Local).AddTicks(9332));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 211,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 438, DateTimeKind.Local).AddTicks(9337));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 212,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 438, DateTimeKind.Local).AddTicks(9342));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 213,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 438, DateTimeKind.Local).AddTicks(9346));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 214,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 438, DateTimeKind.Local).AddTicks(9352));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 215,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 438, DateTimeKind.Local).AddTicks(9358));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 216,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 438, DateTimeKind.Local).AddTicks(9363));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 217,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 438, DateTimeKind.Local).AddTicks(9369));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 218,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 438, DateTimeKind.Local).AddTicks(9374));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 219,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 438, DateTimeKind.Local).AddTicks(9379));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 220,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 438, DateTimeKind.Local).AddTicks(9383));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 221,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 438, DateTimeKind.Local).AddTicks(9388));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 222,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 438, DateTimeKind.Local).AddTicks(9393));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 223,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 438, DateTimeKind.Local).AddTicks(9398));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 224,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 438, DateTimeKind.Local).AddTicks(9403));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 225,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 438, DateTimeKind.Local).AddTicks(9409));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 226,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 438, DateTimeKind.Local).AddTicks(9414));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 227,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 438, DateTimeKind.Local).AddTicks(9419));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 228,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 438, DateTimeKind.Local).AddTicks(9425));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 420, DateTimeKind.Local).AddTicks(4263));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 420, DateTimeKind.Local).AddTicks(4924));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 420, DateTimeKind.Local).AddTicks(4936));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 420, DateTimeKind.Local).AddTicks(4943));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 420, DateTimeKind.Local).AddTicks(4949));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 420, DateTimeKind.Local).AddTicks(4960));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 420, DateTimeKind.Local).AddTicks(4965));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 420, DateTimeKind.Local).AddTicks(4970));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 420, DateTimeKind.Local).AddTicks(4976));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 420, DateTimeKind.Local).AddTicks(4983));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 420, DateTimeKind.Local).AddTicks(4989));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 420, DateTimeKind.Local).AddTicks(4994));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 13,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 420, DateTimeKind.Local).AddTicks(4999));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 14,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 420, DateTimeKind.Local).AddTicks(5005));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 15,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 420, DateTimeKind.Local).AddTicks(5010));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 16,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 420, DateTimeKind.Local).AddTicks(5015));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 17,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 420, DateTimeKind.Local).AddTicks(5020));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 18,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 420, DateTimeKind.Local).AddTicks(5029));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 19,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 420, DateTimeKind.Local).AddTicks(5034));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 20,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 420, DateTimeKind.Local).AddTicks(5039));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 21,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 420, DateTimeKind.Local).AddTicks(5044));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 22,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 420, DateTimeKind.Local).AddTicks(5049));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 23,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 420, DateTimeKind.Local).AddTicks(5054));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 24,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 420, DateTimeKind.Local).AddTicks(5059));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 25,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 420, DateTimeKind.Local).AddTicks(5065));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 26,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 420, DateTimeKind.Local).AddTicks(5071));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 27,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 420, DateTimeKind.Local).AddTicks(5076));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 28,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 420, DateTimeKind.Local).AddTicks(5081));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 29,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 420, DateTimeKind.Local).AddTicks(5086));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 30,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 420, DateTimeKind.Local).AddTicks(5091));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 31,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 420, DateTimeKind.Local).AddTicks(5097));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 32,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 420, DateTimeKind.Local).AddTicks(5102));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 33,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 420, DateTimeKind.Local).AddTicks(5107));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 34,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 420, DateTimeKind.Local).AddTicks(5130));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 35,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 420, DateTimeKind.Local).AddTicks(5135));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 36,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 420, DateTimeKind.Local).AddTicks(5140));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 37,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 420, DateTimeKind.Local).AddTicks(5146));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 38,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 420, DateTimeKind.Local).AddTicks(5151));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 39,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 420, DateTimeKind.Local).AddTicks(5156));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 40,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 420, DateTimeKind.Local).AddTicks(5161));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 41,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 420, DateTimeKind.Local).AddTicks(5168));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 42,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 420, DateTimeKind.Local).AddTicks(5173));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 43,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 420, DateTimeKind.Local).AddTicks(5179));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 44,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 420, DateTimeKind.Local).AddTicks(5184));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 45,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 420, DateTimeKind.Local).AddTicks(5189));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 46,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 420, DateTimeKind.Local).AddTicks(5195));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 47,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 420, DateTimeKind.Local).AddTicks(5200));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 48,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 420, DateTimeKind.Local).AddTicks(5205));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 49,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 420, DateTimeKind.Local).AddTicks(5210));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 50,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 420, DateTimeKind.Local).AddTicks(5215));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 51,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 420, DateTimeKind.Local).AddTicks(5220));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 52,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 420, DateTimeKind.Local).AddTicks(5226));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 53,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 420, DateTimeKind.Local).AddTicks(5232));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 54,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 420, DateTimeKind.Local).AddTicks(5237));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 55,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 420, DateTimeKind.Local).AddTicks(5243));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 56,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 420, DateTimeKind.Local).AddTicks(5248));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 57,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 420, DateTimeKind.Local).AddTicks(5253));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 58,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 420, DateTimeKind.Local).AddTicks(5258));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 59,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 420, DateTimeKind.Local).AddTicks(5263));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 60,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 420, DateTimeKind.Local).AddTicks(5268));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 61,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 420, DateTimeKind.Local).AddTicks(5274));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 62,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 420, DateTimeKind.Local).AddTicks(5279));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 63,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 420, DateTimeKind.Local).AddTicks(5284));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 64,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 420, DateTimeKind.Local).AddTicks(5290));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 65,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 420, DateTimeKind.Local).AddTicks(5295));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 66,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 420, DateTimeKind.Local).AddTicks(5304));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 67,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 420, DateTimeKind.Local).AddTicks(5309));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 68,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 420, DateTimeKind.Local).AddTicks(5314));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 69,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 420, DateTimeKind.Local).AddTicks(5319));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 70,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 420, DateTimeKind.Local).AddTicks(5324));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 71,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 420, DateTimeKind.Local).AddTicks(5330));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 72,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 420, DateTimeKind.Local).AddTicks(5335));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 73,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 420, DateTimeKind.Local).AddTicks(5341));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 74,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 420, DateTimeKind.Local).AddTicks(5346));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 75,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 420, DateTimeKind.Local).AddTicks(5351));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 76,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 420, DateTimeKind.Local).AddTicks(5357));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 77,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 420, DateTimeKind.Local).AddTicks(5363));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 78,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 420, DateTimeKind.Local).AddTicks(5369));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 79,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 420, DateTimeKind.Local).AddTicks(5374));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 80,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 420, DateTimeKind.Local).AddTicks(5379));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 81,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 420, DateTimeKind.Local).AddTicks(5384));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 82,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 420, DateTimeKind.Local).AddTicks(5389));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 83,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 420, DateTimeKind.Local).AddTicks(5394));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 84,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 420, DateTimeKind.Local).AddTicks(5399));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 85,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 420, DateTimeKind.Local).AddTicks(5405));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 86,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 420, DateTimeKind.Local).AddTicks(5409));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 87,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 420, DateTimeKind.Local).AddTicks(5415));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 88,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 420, DateTimeKind.Local).AddTicks(5420));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 89,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 420, DateTimeKind.Local).AddTicks(5424));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 90,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 420, DateTimeKind.Local).AddTicks(5429));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 91,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 420, DateTimeKind.Local).AddTicks(5433));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 92,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 420, DateTimeKind.Local).AddTicks(5438));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 93,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 420, DateTimeKind.Local).AddTicks(5443));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 94,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 420, DateTimeKind.Local).AddTicks(5449));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 95,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 420, DateTimeKind.Local).AddTicks(5454));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 96,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 420, DateTimeKind.Local).AddTicks(5459));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 97,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 420, DateTimeKind.Local).AddTicks(5464));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 98,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 420, DateTimeKind.Local).AddTicks(5469));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 99,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 420, DateTimeKind.Local).AddTicks(5485));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 100,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 420, DateTimeKind.Local).AddTicks(5491));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 101,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 420, DateTimeKind.Local).AddTicks(5496));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 102,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 420, DateTimeKind.Local).AddTicks(5501));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 103,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 420, DateTimeKind.Local).AddTicks(5507));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 104,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 420, DateTimeKind.Local).AddTicks(5512));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 105,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 420, DateTimeKind.Local).AddTicks(5519));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 106,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 420, DateTimeKind.Local).AddTicks(5524));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 107,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 420, DateTimeKind.Local).AddTicks(5529));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 108,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 420, DateTimeKind.Local).AddTicks(5534));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 109,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 420, DateTimeKind.Local).AddTicks(5539));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 110,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 420, DateTimeKind.Local).AddTicks(5544));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 111,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 420, DateTimeKind.Local).AddTicks(5550));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 112,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 420, DateTimeKind.Local).AddTicks(5556));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 113,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 420, DateTimeKind.Local).AddTicks(5560));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 114,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 420, DateTimeKind.Local).AddTicks(5566));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 115,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 420, DateTimeKind.Local).AddTicks(5571));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 116,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 420, DateTimeKind.Local).AddTicks(5576));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 117,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 420, DateTimeKind.Local).AddTicks(5581));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 118,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 420, DateTimeKind.Local).AddTicks(5586));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 119,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 420, DateTimeKind.Local).AddTicks(5591));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 120,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 420, DateTimeKind.Local).AddTicks(5596));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 121,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 420, DateTimeKind.Local).AddTicks(5601));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 122,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 420, DateTimeKind.Local).AddTicks(5606));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 123,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 420, DateTimeKind.Local).AddTicks(5612));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 124,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 420, DateTimeKind.Local).AddTicks(5618));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 125,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 420, DateTimeKind.Local).AddTicks(5623));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 126,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 420, DateTimeKind.Local).AddTicks(5628));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 127,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 420, DateTimeKind.Local).AddTicks(5633));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 128,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 420, DateTimeKind.Local).AddTicks(5638));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 129,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 420, DateTimeKind.Local).AddTicks(5644));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 130,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 420, DateTimeKind.Local).AddTicks(5652));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 131,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 420, DateTimeKind.Local).AddTicks(5657));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 132,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 420, DateTimeKind.Local).AddTicks(5662));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 133,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 420, DateTimeKind.Local).AddTicks(5668));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 134,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 420, DateTimeKind.Local).AddTicks(5673));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 135,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 420, DateTimeKind.Local).AddTicks(5678));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 136,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 420, DateTimeKind.Local).AddTicks(5683));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 137,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 420, DateTimeKind.Local).AddTicks(5688));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 138,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 420, DateTimeKind.Local).AddTicks(5693));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 139,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 420, DateTimeKind.Local).AddTicks(5698));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 140,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 420, DateTimeKind.Local).AddTicks(5703));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 141,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 420, DateTimeKind.Local).AddTicks(5708));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 142,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 420, DateTimeKind.Local).AddTicks(5714));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 143,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 420, DateTimeKind.Local).AddTicks(5720));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 144,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 420, DateTimeKind.Local).AddTicks(5725));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 145,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 420, DateTimeKind.Local).AddTicks(5730));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 146,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 420, DateTimeKind.Local).AddTicks(5735));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 147,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 420, DateTimeKind.Local).AddTicks(5740));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 148,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 420, DateTimeKind.Local).AddTicks(5745));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 149,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 420, DateTimeKind.Local).AddTicks(5749));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 150,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 420, DateTimeKind.Local).AddTicks(5754));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 151,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 420, DateTimeKind.Local).AddTicks(5760));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 152,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 420, DateTimeKind.Local).AddTicks(5764));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 153,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 420, DateTimeKind.Local).AddTicks(5770));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 154,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 420, DateTimeKind.Local).AddTicks(5776));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 155,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 420, DateTimeKind.Local).AddTicks(5781));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 156,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 420, DateTimeKind.Local).AddTicks(5786));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 157,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 420, DateTimeKind.Local).AddTicks(5801));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 158,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 420, DateTimeKind.Local).AddTicks(5806));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 159,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 420, DateTimeKind.Local).AddTicks(5812));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 160,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 420, DateTimeKind.Local).AddTicks(5817));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 161,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 420, DateTimeKind.Local).AddTicks(5822));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 162,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 420, DateTimeKind.Local).AddTicks(5829));

            migrationBuilder.UpdateData(
                table: "CustomSettingTypes",
                keyColumn: "CustomSettingTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 432, DateTimeKind.Local).AddTicks(2056));

            migrationBuilder.UpdateData(
                table: "CustomSettingTypes",
                keyColumn: "CustomSettingTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 432, DateTimeKind.Local).AddTicks(2234));

            migrationBuilder.UpdateData(
                table: "CustomSettingTypes",
                keyColumn: "CustomSettingTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 432, DateTimeKind.Local).AddTicks(2242));

            migrationBuilder.UpdateData(
                table: "CustomSettingTypes",
                keyColumn: "CustomSettingTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 432, DateTimeKind.Local).AddTicks(2247));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 474, DateTimeKind.Local).AddTicks(1337));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 474, DateTimeKind.Local).AddTicks(1652));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 474, DateTimeKind.Local).AddTicks(1687));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 474, DateTimeKind.Local).AddTicks(1659));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 474, DateTimeKind.Local).AddTicks(1693));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 474, DateTimeKind.Local).AddTicks(1705));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 474, DateTimeKind.Local).AddTicks(1713));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 474, DateTimeKind.Local).AddTicks(1719));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 474, DateTimeKind.Local).AddTicks(1725));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 474, DateTimeKind.Local).AddTicks(1731));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 474, DateTimeKind.Local).AddTicks(1804));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 474, DateTimeKind.Local).AddTicks(1811));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 13,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 474, DateTimeKind.Local).AddTicks(1816));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 14,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 474, DateTimeKind.Local).AddTicks(1823));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 15,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 474, DateTimeKind.Local).AddTicks(1667));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 16,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 474, DateTimeKind.Local).AddTicks(1643));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 17,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 474, DateTimeKind.Local).AddTicks(1832));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 18,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 474, DateTimeKind.Local).AddTicks(1838));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 19,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 474, DateTimeKind.Local).AddTicks(1846));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 20,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 474, DateTimeKind.Local).AddTicks(1853));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 22,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 474, DateTimeKind.Local).AddTicks(1878));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 23,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 474, DateTimeKind.Local).AddTicks(1866));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 24,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 474, DateTimeKind.Local).AddTicks(1860));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 25,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 474, DateTimeKind.Local).AddTicks(1872));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 26,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 474, DateTimeKind.Local).AddTicks(1884));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 27,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 474, DateTimeKind.Local).AddTicks(1891));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 28,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 474, DateTimeKind.Local).AddTicks(1897));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 30,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 474, DateTimeKind.Local).AddTicks(1904));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 31,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 474, DateTimeKind.Local).AddTicks(1910));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 32,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 474, DateTimeKind.Local).AddTicks(1916));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 33,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 474, DateTimeKind.Local).AddTicks(1923));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 34,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 474, DateTimeKind.Local).AddTicks(1929));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 36,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 474, DateTimeKind.Local).AddTicks(1938));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 37,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 474, DateTimeKind.Local).AddTicks(1944));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 38,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 474, DateTimeKind.Local).AddTicks(1950));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 39,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 474, DateTimeKind.Local).AddTicks(1699));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 40,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 474, DateTimeKind.Local).AddTicks(1957));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 41,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 474, DateTimeKind.Local).AddTicks(1963));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 42,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 474, DateTimeKind.Local).AddTicks(2141));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 43,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 474, DateTimeKind.Local).AddTicks(2148));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 44,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 474, DateTimeKind.Local).AddTicks(2154));

            migrationBuilder.UpdateData(
                table: "DocumentFormats",
                keyColumn: "DocumentFormatID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 451, DateTimeKind.Local).AddTicks(9676));

            migrationBuilder.UpdateData(
                table: "DocumentFormats",
                keyColumn: "DocumentFormatID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 452, DateTimeKind.Local).AddTicks(179));

            migrationBuilder.UpdateData(
                table: "DocumentFormats",
                keyColumn: "DocumentFormatID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 452, DateTimeKind.Local).AddTicks(186));

            migrationBuilder.UpdateData(
                table: "DocumentFormats",
                keyColumn: "DocumentFormatID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 452, DateTimeKind.Local).AddTicks(190));

            migrationBuilder.UpdateData(
                table: "DocumentFormats",
                keyColumn: "DocumentFormatID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 452, DateTimeKind.Local).AddTicks(193));

            migrationBuilder.UpdateData(
                table: "DocumentFormats",
                keyColumn: "DocumentFormatID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 452, DateTimeKind.Local).AddTicks(203));

            migrationBuilder.UpdateData(
                table: "DocumentTypes",
                keyColumn: "DocumentTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 455, DateTimeKind.Local).AddTicks(3239));

            migrationBuilder.UpdateData(
                table: "DocumentTypes",
                keyColumn: "DocumentTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 455, DateTimeKind.Local).AddTicks(4596));

            migrationBuilder.UpdateData(
                table: "DocumentTypes",
                keyColumn: "DocumentTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 455, DateTimeKind.Local).AddTicks(4623));

            migrationBuilder.UpdateData(
                table: "DocumentTypes",
                keyColumn: "DocumentTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 455, DateTimeKind.Local).AddTicks(4628));

            migrationBuilder.UpdateData(
                table: "EmailTemplates",
                keyColumn: "EmailTemplateID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 468, DateTimeKind.Local).AddTicks(9045));

            migrationBuilder.UpdateData(
                table: "EmailTypes",
                keyColumn: "EmailTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 468, DateTimeKind.Local).AddTicks(124));

            migrationBuilder.UpdateData(
                table: "EmailTypes",
                keyColumn: "EmailTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 468, DateTimeKind.Local).AddTicks(692));

            migrationBuilder.UpdateData(
                table: "EmailTypes",
                keyColumn: "EmailTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 468, DateTimeKind.Local).AddTicks(702));

            migrationBuilder.UpdateData(
                table: "EmailTypes",
                keyColumn: "EmailTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 468, DateTimeKind.Local).AddTicks(708));

            migrationBuilder.UpdateData(
                table: "FeatureFlags",
                keyColumn: "FeatureFlagID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 448, DateTimeKind.Local).AddTicks(4191));

            migrationBuilder.UpdateData(
                table: "FeatureFlags",
                keyColumn: "FeatureFlagID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 448, DateTimeKind.Local).AddTicks(4837));

            migrationBuilder.UpdateData(
                table: "FeatureFlags",
                keyColumn: "FeatureFlagID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 448, DateTimeKind.Local).AddTicks(4848));

            migrationBuilder.UpdateData(
                table: "Frequencies",
                keyColumn: "FrequencyID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 424, DateTimeKind.Local).AddTicks(5442));

            migrationBuilder.UpdateData(
                table: "Frequencies",
                keyColumn: "FrequencyID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 424, DateTimeKind.Local).AddTicks(6117));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "GenderID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 434, DateTimeKind.Local).AddTicks(9540));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "GenderID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 434, DateTimeKind.Local).AddTicks(9701));

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "InvoiceStatusID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 503, DateTimeKind.Local).AddTicks(438));

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "InvoiceStatusID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 503, DateTimeKind.Local).AddTicks(1141));

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "InvoiceStatusID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 503, DateTimeKind.Local).AddTicks(1155));

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "InvoiceStatusID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 503, DateTimeKind.Local).AddTicks(1160));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 458, DateTimeKind.Local).AddTicks(2767));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 458, DateTimeKind.Local).AddTicks(2975));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 458, DateTimeKind.Local).AddTicks(2989));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 458, DateTimeKind.Local).AddTicks(2995));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 458, DateTimeKind.Local).AddTicks(3002));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 458, DateTimeKind.Local).AddTicks(3029));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 999,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 458, DateTimeKind.Local).AddTicks(3023));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 9998,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 458, DateTimeKind.Local).AddTicks(3017));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 460, DateTimeKind.Local).AddTicks(9152));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 460, DateTimeKind.Local).AddTicks(9602));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 460, DateTimeKind.Local).AddTicks(9608));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 460, DateTimeKind.Local).AddTicks(9613));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 460, DateTimeKind.Local).AddTicks(9618));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 460, DateTimeKind.Local).AddTicks(9630));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 460, DateTimeKind.Local).AddTicks(9635));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 460, DateTimeKind.Local).AddTicks(9641));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 460, DateTimeKind.Local).AddTicks(9648));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 460, DateTimeKind.Local).AddTicks(9655));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 460, DateTimeKind.Local).AddTicks(9659));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 13,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 460, DateTimeKind.Local).AddTicks(9665));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 14,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 460, DateTimeKind.Local).AddTicks(9669));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 15,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 460, DateTimeKind.Local).AddTicks(9674));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 16,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 460, DateTimeKind.Local).AddTicks(9679));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 17,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 460, DateTimeKind.Local).AddTicks(9684));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 18,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 460, DateTimeKind.Local).AddTicks(9688));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 19,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 460, DateTimeKind.Local).AddTicks(9694));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 20,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 460, DateTimeKind.Local).AddTicks(9699));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 9997,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 460, DateTimeKind.Local).AddTicks(9703));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 9998,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 460, DateTimeKind.Local).AddTicks(9707));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 9999,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 460, DateTimeKind.Local).AddTicks(9712));

            migrationBuilder.UpdateData(
                table: "PaymentStatus",
                keyColumn: "PaymentStatusID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 409, DateTimeKind.Local).AddTicks(4757));

            migrationBuilder.UpdateData(
                table: "PaymentStatus",
                keyColumn: "PaymentStatusID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 409, DateTimeKind.Local).AddTicks(5274));

            migrationBuilder.UpdateData(
                table: "PaymentStatus",
                keyColumn: "PaymentStatusID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 409, DateTimeKind.Local).AddTicks(5283));

            migrationBuilder.UpdateData(
                table: "PaymentStatus",
                keyColumn: "PaymentStatusID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 409, DateTimeKind.Local).AddTicks(5287));

            migrationBuilder.UpdateData(
                table: "PaymentStatus",
                keyColumn: "PaymentStatusID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 409, DateTimeKind.Local).AddTicks(5292));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 405, DateTimeKind.Local).AddTicks(6206));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 405, DateTimeKind.Local).AddTicks(6806));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 405, DateTimeKind.Local).AddTicks(6815));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 405, DateTimeKind.Local).AddTicks(6820));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 405, DateTimeKind.Local).AddTicks(6825));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 405, DateTimeKind.Local).AddTicks(6836));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 405, DateTimeKind.Local).AddTicks(6841));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 405, DateTimeKind.Local).AddTicks(6845));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 405, DateTimeKind.Local).AddTicks(6850));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 405, DateTimeKind.Local).AddTicks(6876));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 405, DateTimeKind.Local).AddTicks(6882));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 405, DateTimeKind.Local).AddTicks(6886));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 13,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 405, DateTimeKind.Local).AddTicks(6891));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 14,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 405, DateTimeKind.Local).AddTicks(6895));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 15,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 405, DateTimeKind.Local).AddTicks(6900));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 16,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 405, DateTimeKind.Local).AddTicks(6904));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 17,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 405, DateTimeKind.Local).AddTicks(6908));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 18,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 405, DateTimeKind.Local).AddTicks(6915));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 19,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 405, DateTimeKind.Local).AddTicks(6920));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 20,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 405, DateTimeKind.Local).AddTicks(6925));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 21,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 405, DateTimeKind.Local).AddTicks(6929));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 22,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 405, DateTimeKind.Local).AddTicks(6934));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 23,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 405, DateTimeKind.Local).AddTicks(6939));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 24,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 405, DateTimeKind.Local).AddTicks(6944));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 25,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 405, DateTimeKind.Local).AddTicks(6948));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 26,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 405, DateTimeKind.Local).AddTicks(6953));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 27,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 405, DateTimeKind.Local).AddTicks(6958));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 28,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 405, DateTimeKind.Local).AddTicks(6963));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 29,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 405, DateTimeKind.Local).AddTicks(6967));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 30,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 405, DateTimeKind.Local).AddTicks(6972));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 31,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 405, DateTimeKind.Local).AddTicks(6978));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 32,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 405, DateTimeKind.Local).AddTicks(6983));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 33,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 405, DateTimeKind.Local).AddTicks(6988));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 34,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 405, DateTimeKind.Local).AddTicks(6995));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 35,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 405, DateTimeKind.Local).AddTicks(7000));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 36,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 405, DateTimeKind.Local).AddTicks(7005));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 37,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 405, DateTimeKind.Local).AddTicks(7010));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 38,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 405, DateTimeKind.Local).AddTicks(7014));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 39,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 405, DateTimeKind.Local).AddTicks(7019));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 40,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 405, DateTimeKind.Local).AddTicks(7024));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 41,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 405, DateTimeKind.Local).AddTicks(7028));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 42,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 405, DateTimeKind.Local).AddTicks(7033));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 43,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 405, DateTimeKind.Local).AddTicks(7037));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 44,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 405, DateTimeKind.Local).AddTicks(7042));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 45,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 405, DateTimeKind.Local).AddTicks(7046));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 46,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 405, DateTimeKind.Local).AddTicks(7051));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 47,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 405, DateTimeKind.Local).AddTicks(7056));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 48,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 405, DateTimeKind.Local).AddTicks(7061));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 49,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 405, DateTimeKind.Local).AddTicks(7065));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 50,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 405, DateTimeKind.Local).AddTicks(7079));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 51,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 405, DateTimeKind.Local).AddTicks(7083));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 52,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 405, DateTimeKind.Local).AddTicks(7089));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 53,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 405, DateTimeKind.Local).AddTicks(7094));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 54,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 405, DateTimeKind.Local).AddTicks(7098));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 55,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 405, DateTimeKind.Local).AddTicks(7102));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 56,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 405, DateTimeKind.Local).AddTicks(7107));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 57,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 405, DateTimeKind.Local).AddTicks(7111));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 58,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 405, DateTimeKind.Local).AddTicks(7116));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 59,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 405, DateTimeKind.Local).AddTicks(7121));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 60,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 405, DateTimeKind.Local).AddTicks(7126));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 61,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 405, DateTimeKind.Local).AddTicks(7131));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 62,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 405, DateTimeKind.Local).AddTicks(7136));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 63,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 405, DateTimeKind.Local).AddTicks(7140));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 64,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 405, DateTimeKind.Local).AddTicks(7144));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 65,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 405, DateTimeKind.Local).AddTicks(7149));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 66,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 405, DateTimeKind.Local).AddTicks(7156));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 67,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 405, DateTimeKind.Local).AddTicks(7160));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 68,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 405, DateTimeKind.Local).AddTicks(7164));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 69,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 405, DateTimeKind.Local).AddTicks(7169));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 70,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 405, DateTimeKind.Local).AddTicks(7173));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 71,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 405, DateTimeKind.Local).AddTicks(7178));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 72,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 405, DateTimeKind.Local).AddTicks(7182));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 73,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 405, DateTimeKind.Local).AddTicks(7186));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 74,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 405, DateTimeKind.Local).AddTicks(7191));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 75,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 405, DateTimeKind.Local).AddTicks(7195));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 76,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 405, DateTimeKind.Local).AddTicks(7199));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 77,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 405, DateTimeKind.Local).AddTicks(7203));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 78,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 405, DateTimeKind.Local).AddTicks(7208));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 79,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 405, DateTimeKind.Local).AddTicks(7213));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 80,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 405, DateTimeKind.Local).AddTicks(7217));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 81,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 405, DateTimeKind.Local).AddTicks(7222));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 82,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 405, DateTimeKind.Local).AddTicks(7226));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 83,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 405, DateTimeKind.Local).AddTicks(7231));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 84,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 405, DateTimeKind.Local).AddTicks(7235));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 85,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 405, DateTimeKind.Local).AddTicks(7240));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 86,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 405, DateTimeKind.Local).AddTicks(7245));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 87,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 405, DateTimeKind.Local).AddTicks(7250));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 88,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 405, DateTimeKind.Local).AddTicks(7254));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 89,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 405, DateTimeKind.Local).AddTicks(7258));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 90,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 405, DateTimeKind.Local).AddTicks(7263));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 91,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 405, DateTimeKind.Local).AddTicks(7295));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 92,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 405, DateTimeKind.Local).AddTicks(7300));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 93,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 405, DateTimeKind.Local).AddTicks(7304));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 94,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 405, DateTimeKind.Local).AddTicks(7308));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 95,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 405, DateTimeKind.Local).AddTicks(7313));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 96,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 405, DateTimeKind.Local).AddTicks(7318));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 97,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 405, DateTimeKind.Local).AddTicks(7322));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 98,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 405, DateTimeKind.Local).AddTicks(7327));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 99,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 405, DateTimeKind.Local).AddTicks(7332));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 100,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 405, DateTimeKind.Local).AddTicks(7336));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 101,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 405, DateTimeKind.Local).AddTicks(7340));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 102,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 405, DateTimeKind.Local).AddTicks(7344));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 103,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 405, DateTimeKind.Local).AddTicks(7349));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 104,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 405, DateTimeKind.Local).AddTicks(7353));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 105,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 405, DateTimeKind.Local).AddTicks(7357));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 106,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 405, DateTimeKind.Local).AddTicks(7362));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 107,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 405, DateTimeKind.Local).AddTicks(7367));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 108,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 405, DateTimeKind.Local).AddTicks(7372));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 109,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 405, DateTimeKind.Local).AddTicks(7377));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 110,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 405, DateTimeKind.Local).AddTicks(7381));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 111,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 405, DateTimeKind.Local).AddTicks(7386));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 112,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 405, DateTimeKind.Local).AddTicks(7391));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 113,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 405, DateTimeKind.Local).AddTicks(7396));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 114,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 405, DateTimeKind.Local).AddTicks(7400));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 115,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 405, DateTimeKind.Local).AddTicks(7405));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 116,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 405, DateTimeKind.Local).AddTicks(7410));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 117,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 405, DateTimeKind.Local).AddTicks(7414));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 118,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 405, DateTimeKind.Local).AddTicks(7419));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 119,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 405, DateTimeKind.Local).AddTicks(7423));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 120,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 405, DateTimeKind.Local).AddTicks(7427));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 121,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 405, DateTimeKind.Local).AddTicks(7432));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 122,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 405, DateTimeKind.Local).AddTicks(7436));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 123,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 405, DateTimeKind.Local).AddTicks(7441));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 124,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 405, DateTimeKind.Local).AddTicks(7446));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 125,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 405, DateTimeKind.Local).AddTicks(7450));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 126,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 405, DateTimeKind.Local).AddTicks(7455));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 127,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 405, DateTimeKind.Local).AddTicks(7459));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 128,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 405, DateTimeKind.Local).AddTicks(7464));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 129,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 405, DateTimeKind.Local).AddTicks(7469));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 130,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 405, DateTimeKind.Local).AddTicks(7486));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 131,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 405, DateTimeKind.Local).AddTicks(7491));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 132,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 405, DateTimeKind.Local).AddTicks(7497));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 133,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 405, DateTimeKind.Local).AddTicks(7501));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 134,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 405, DateTimeKind.Local).AddTicks(7507));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 135,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 405, DateTimeKind.Local).AddTicks(7511));

            migrationBuilder.UpdateData(
                table: "PriorityRanks",
                keyColumn: "PriorityRankID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 440, DateTimeKind.Local).AddTicks(2163));

            migrationBuilder.UpdateData(
                table: "PriorityRanks",
                keyColumn: "PriorityRankID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 440, DateTimeKind.Local).AddTicks(2317));

            migrationBuilder.UpdateData(
                table: "PriorityRanks",
                keyColumn: "PriorityRankID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 440, DateTimeKind.Local).AddTicks(2325));

            migrationBuilder.UpdateData(
                table: "PriorityRanks",
                keyColumn: "PriorityRankID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 440, DateTimeKind.Local).AddTicks(2330));

            migrationBuilder.UpdateData(
                table: "RecordStatus",
                keyColumn: "RecordStatusID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 495, DateTimeKind.Local).AddTicks(3336));

            migrationBuilder.UpdateData(
                table: "RecordStatus",
                keyColumn: "RecordStatusID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 495, DateTimeKind.Local).AddTicks(4151));

            migrationBuilder.UpdateData(
                table: "RecordStatus",
                keyColumn: "RecordStatusID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 495, DateTimeKind.Local).AddTicks(4161));

            migrationBuilder.UpdateData(
                table: "RelationshipTypes",
                keyColumn: "RelationshipTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 430, DateTimeKind.Local).AddTicks(8449));

            migrationBuilder.UpdateData(
                table: "RelationshipTypes",
                keyColumn: "RelationshipTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 430, DateTimeKind.Local).AddTicks(8989));

            migrationBuilder.UpdateData(
                table: "RelationshipTypes",
                keyColumn: "RelationshipTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 430, DateTimeKind.Local).AddTicks(8995));

            migrationBuilder.UpdateData(
                table: "RelationshipTypes",
                keyColumn: "RelationshipTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 430, DateTimeKind.Local).AddTicks(9003));

            migrationBuilder.UpdateData(
                table: "RelationshipTypes",
                keyColumn: "RelationshipTypeID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 430, DateTimeKind.Local).AddTicks(9006));

            migrationBuilder.UpdateData(
                table: "RelationshipTypes",
                keyColumn: "RelationshipTypeID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 430, DateTimeKind.Local).AddTicks(9019));

            migrationBuilder.UpdateData(
                table: "RelationshipTypes",
                keyColumn: "RelationshipTypeID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 430, DateTimeKind.Local).AddTicks(9024));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 475, DateTimeKind.Local).AddTicks(935));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 475, DateTimeKind.Local).AddTicks(1067));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 475, DateTimeKind.Local).AddTicks(1071));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 475, DateTimeKind.Local).AddTicks(1074));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 475, DateTimeKind.Local).AddTicks(1076));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 475, DateTimeKind.Local).AddTicks(1082));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 475, DateTimeKind.Local).AddTicks(1084));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 475, DateTimeKind.Local).AddTicks(1086));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 475, DateTimeKind.Local).AddTicks(1088));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 475, DateTimeKind.Local).AddTicks(1092));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 475, DateTimeKind.Local).AddTicks(1095));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 475, DateTimeKind.Local).AddTicks(1097));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 13,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 475, DateTimeKind.Local).AddTicks(1099));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 14,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 475, DateTimeKind.Local).AddTicks(1101));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 15,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 475, DateTimeKind.Local).AddTicks(1103));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 16,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 475, DateTimeKind.Local).AddTicks(1105));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 17,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 475, DateTimeKind.Local).AddTicks(1107));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 18,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 475, DateTimeKind.Local).AddTicks(1111));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 19,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 475, DateTimeKind.Local).AddTicks(1113));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 20,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 475, DateTimeKind.Local).AddTicks(1115));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 21,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 475, DateTimeKind.Local).AddTicks(1117));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 22,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 475, DateTimeKind.Local).AddTicks(1120));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 406, DateTimeKind.Local).AddTicks(5608));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 406, DateTimeKind.Local).AddTicks(5752));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 406, DateTimeKind.Local).AddTicks(5759));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 406, DateTimeKind.Local).AddTicks(5762));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 406, DateTimeKind.Local).AddTicks(5764));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 406, DateTimeKind.Local).AddTicks(5769));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 406, DateTimeKind.Local).AddTicks(5771));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 406, DateTimeKind.Local).AddTicks(5773));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 406, DateTimeKind.Local).AddTicks(5775));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 406, DateTimeKind.Local).AddTicks(5778));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 406, DateTimeKind.Local).AddTicks(5780));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 406, DateTimeKind.Local).AddTicks(5782));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 13,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 406, DateTimeKind.Local).AddTicks(5784));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 14,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 406, DateTimeKind.Local).AddTicks(5786));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 15,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 406, DateTimeKind.Local).AddTicks(5788));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 16,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 406, DateTimeKind.Local).AddTicks(5790));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 17,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 406, DateTimeKind.Local).AddTicks(5792));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 18,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 406, DateTimeKind.Local).AddTicks(5796));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 19,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 406, DateTimeKind.Local).AddTicks(5798));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 20,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 406, DateTimeKind.Local).AddTicks(5800));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 21,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 406, DateTimeKind.Local).AddTicks(5802));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 22,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 406, DateTimeKind.Local).AddTicks(5804));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 23,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 406, DateTimeKind.Local).AddTicks(5806));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 24,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 406, DateTimeKind.Local).AddTicks(5808));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 25,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 406, DateTimeKind.Local).AddTicks(5810));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 26,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 406, DateTimeKind.Local).AddTicks(5812));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 27,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 406, DateTimeKind.Local).AddTicks(5814));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 28,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 406, DateTimeKind.Local).AddTicks(5816));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 29,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 406, DateTimeKind.Local).AddTicks(5818));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 30,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 406, DateTimeKind.Local).AddTicks(5820));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 31,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 406, DateTimeKind.Local).AddTicks(5821));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 32,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 406, DateTimeKind.Local).AddTicks(5823));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 33,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 406, DateTimeKind.Local).AddTicks(5825));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 34,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 406, DateTimeKind.Local).AddTicks(5829));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 35,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 406, DateTimeKind.Local).AddTicks(5831));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 36,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 406, DateTimeKind.Local).AddTicks(5833));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 37,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 406, DateTimeKind.Local).AddTicks(5835));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 38,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 406, DateTimeKind.Local).AddTicks(5837));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 39,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 406, DateTimeKind.Local).AddTicks(5839));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 40,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 406, DateTimeKind.Local).AddTicks(5841));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 41,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 406, DateTimeKind.Local).AddTicks(5843));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 42,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 406, DateTimeKind.Local).AddTicks(5845));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 43,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 406, DateTimeKind.Local).AddTicks(5847));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 44,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 406, DateTimeKind.Local).AddTicks(5849));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 45,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 406, DateTimeKind.Local).AddTicks(5851));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 46,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 406, DateTimeKind.Local).AddTicks(5853));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 47,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 406, DateTimeKind.Local).AddTicks(5855));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 48,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 406, DateTimeKind.Local).AddTicks(5857));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 49,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 406, DateTimeKind.Local).AddTicks(5859));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 50,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 406, DateTimeKind.Local).AddTicks(5861));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 51,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 406, DateTimeKind.Local).AddTicks(5863));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 52,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 406, DateTimeKind.Local).AddTicks(5865));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 53,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 406, DateTimeKind.Local).AddTicks(5867));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 54,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 406, DateTimeKind.Local).AddTicks(5869));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 55,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 406, DateTimeKind.Local).AddTicks(5871));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 56,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 406, DateTimeKind.Local).AddTicks(5873));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 57,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 406, DateTimeKind.Local).AddTicks(5875));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 58,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 406, DateTimeKind.Local).AddTicks(5877));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 59,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 406, DateTimeKind.Local).AddTicks(5879));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 60,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 406, DateTimeKind.Local).AddTicks(5881));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 61,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 406, DateTimeKind.Local).AddTicks(5883));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 62,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 406, DateTimeKind.Local).AddTicks(5885));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 63,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 406, DateTimeKind.Local).AddTicks(5887));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 64,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 406, DateTimeKind.Local).AddTicks(5889));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 65,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 406, DateTimeKind.Local).AddTicks(5891));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 66,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 406, DateTimeKind.Local).AddTicks(5895));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 67,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 406, DateTimeKind.Local).AddTicks(5897));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 68,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 406, DateTimeKind.Local).AddTicks(5899));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 69,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 406, DateTimeKind.Local).AddTicks(5901));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 70,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 406, DateTimeKind.Local).AddTicks(5903));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 71,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 406, DateTimeKind.Local).AddTicks(5905));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 72,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 406, DateTimeKind.Local).AddTicks(5907));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 73,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 406, DateTimeKind.Local).AddTicks(5909));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 74,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 406, DateTimeKind.Local).AddTicks(5911));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 75,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 406, DateTimeKind.Local).AddTicks(5913));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 76,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 406, DateTimeKind.Local).AddTicks(5915));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 77,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 406, DateTimeKind.Local).AddTicks(5917));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 78,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 406, DateTimeKind.Local).AddTicks(5918));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 79,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 406, DateTimeKind.Local).AddTicks(5921));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 80,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 406, DateTimeKind.Local).AddTicks(5922));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 81,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 406, DateTimeKind.Local).AddTicks(5924));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 82,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 406, DateTimeKind.Local).AddTicks(5926));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 83,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 406, DateTimeKind.Local).AddTicks(5928));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 84,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 406, DateTimeKind.Local).AddTicks(5930));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 85,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 406, DateTimeKind.Local).AddTicks(5932));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 86,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 406, DateTimeKind.Local).AddTicks(5934));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 87,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 406, DateTimeKind.Local).AddTicks(5936));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 88,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 406, DateTimeKind.Local).AddTicks(5938));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 89,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 406, DateTimeKind.Local).AddTicks(5957));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 90,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 406, DateTimeKind.Local).AddTicks(5959));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 91,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 406, DateTimeKind.Local).AddTicks(5961));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 92,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 406, DateTimeKind.Local).AddTicks(5963));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 93,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 406, DateTimeKind.Local).AddTicks(5965));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 94,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 406, DateTimeKind.Local).AddTicks(5967));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 95,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 406, DateTimeKind.Local).AddTicks(5969));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 96,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 406, DateTimeKind.Local).AddTicks(5971));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 97,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 406, DateTimeKind.Local).AddTicks(5973));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 98,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 406, DateTimeKind.Local).AddTicks(5975));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 99,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 406, DateTimeKind.Local).AddTicks(5977));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 100,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 406, DateTimeKind.Local).AddTicks(5979));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 101,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 406, DateTimeKind.Local).AddTicks(5981));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 102,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 406, DateTimeKind.Local).AddTicks(5983));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 103,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 406, DateTimeKind.Local).AddTicks(5985));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 104,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 406, DateTimeKind.Local).AddTicks(5987));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 105,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 406, DateTimeKind.Local).AddTicks(5989));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 106,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 406, DateTimeKind.Local).AddTicks(5991));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 107,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 406, DateTimeKind.Local).AddTicks(5993));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 108,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 406, DateTimeKind.Local).AddTicks(5995));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 109,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 406, DateTimeKind.Local).AddTicks(5997));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 110,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 406, DateTimeKind.Local).AddTicks(5999));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 111,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 406, DateTimeKind.Local).AddTicks(6001));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 112,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 406, DateTimeKind.Local).AddTicks(6003));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 113,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 406, DateTimeKind.Local).AddTicks(6005));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 114,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 406, DateTimeKind.Local).AddTicks(6007));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 115,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 406, DateTimeKind.Local).AddTicks(6009));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 116,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 406, DateTimeKind.Local).AddTicks(6011));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 117,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 406, DateTimeKind.Local).AddTicks(6013));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 118,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 406, DateTimeKind.Local).AddTicks(6015));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 119,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 406, DateTimeKind.Local).AddTicks(6017));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 120,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 406, DateTimeKind.Local).AddTicks(6019));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 121,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 406, DateTimeKind.Local).AddTicks(6021));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 122,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 406, DateTimeKind.Local).AddTicks(6023));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 123,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 406, DateTimeKind.Local).AddTicks(6025));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 124,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 406, DateTimeKind.Local).AddTicks(6027));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 125,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 406, DateTimeKind.Local).AddTicks(6029));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 126,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 406, DateTimeKind.Local).AddTicks(6031));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 127,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 406, DateTimeKind.Local).AddTicks(6033));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 128,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 406, DateTimeKind.Local).AddTicks(6035));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 129,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 406, DateTimeKind.Local).AddTicks(6037));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 130,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 406, DateTimeKind.Local).AddTicks(6041));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 131,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 406, DateTimeKind.Local).AddTicks(6043));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 132,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 406, DateTimeKind.Local).AddTicks(6045));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 133,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 406, DateTimeKind.Local).AddTicks(6047));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 134,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 406, DateTimeKind.Local).AddTicks(6049));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 135,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 406, DateTimeKind.Local).AddTicks(6051));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 398, DateTimeKind.Local).AddTicks(5711));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 400, DateTimeKind.Local).AddTicks(6928));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 400, DateTimeKind.Local).AddTicks(7019));

            migrationBuilder.UpdateData(
                table: "StatementLists",
                keyColumn: "StatementID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 482, DateTimeKind.Local).AddTicks(5249));

            migrationBuilder.UpdateData(
                table: "StatementLists",
                keyColumn: "StatementID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 482, DateTimeKind.Local).AddTicks(5788));

            migrationBuilder.UpdateData(
                table: "SystemVariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 433, DateTimeKind.Local).AddTicks(9650));

            migrationBuilder.UpdateData(
                table: "SystemVariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 433, DateTimeKind.Local).AddTicks(9852));

            migrationBuilder.UpdateData(
                table: "SystemVariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 433, DateTimeKind.Local).AddTicks(9847));

            migrationBuilder.UpdateData(
                table: "SystemVariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 433, DateTimeKind.Local).AddTicks(9842));

            migrationBuilder.UpdateData(
                table: "SystemVariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 433, DateTimeKind.Local).AddTicks(9834));

            migrationBuilder.UpdateData(
                table: "SystemVariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 433, DateTimeKind.Local).AddTicks(9865));

            migrationBuilder.UpdateData(
                table: "SystemVariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 433, DateTimeKind.Local).AddTicks(9877));

            migrationBuilder.UpdateData(
                table: "SystemVariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 433, DateTimeKind.Local).AddTicks(9883));

            migrationBuilder.UpdateData(
                table: "SystemVariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 433, DateTimeKind.Local).AddTicks(9887));

            migrationBuilder.UpdateData(
                table: "Titles",
                keyColumn: "TitleID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 486, DateTimeKind.Local).AddTicks(294));

            migrationBuilder.UpdateData(
                table: "Titles",
                keyColumn: "TitleID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 486, DateTimeKind.Local).AddTicks(4792));

            migrationBuilder.UpdateData(
                table: "Titles",
                keyColumn: "TitleID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 486, DateTimeKind.Local).AddTicks(4799));

            migrationBuilder.UpdateData(
                table: "Titles",
                keyColumn: "TitleID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 486, DateTimeKind.Local).AddTicks(4804));

            migrationBuilder.UpdateData(
                table: "Titles",
                keyColumn: "TitleID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 486, DateTimeKind.Local).AddTicks(4807));

            migrationBuilder.UpdateData(
                table: "Titles",
                keyColumn: "TitleID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 486, DateTimeKind.Local).AddTicks(4819));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 413, DateTimeKind.Local).AddTicks(2841));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 413, DateTimeKind.Local).AddTicks(3733));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 413, DateTimeKind.Local).AddTicks(3849));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 413, DateTimeKind.Local).AddTicks(3931));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 413, DateTimeKind.Local).AddTicks(4011));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 413, DateTimeKind.Local).AddTicks(4088));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 413, DateTimeKind.Local).AddTicks(4152));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 413, DateTimeKind.Local).AddTicks(4215));

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumns: new[] { "UserID", "RoleID" },
                keyValues: new object[] { 1, 1 },
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 456, DateTimeKind.Local).AddTicks(2334));

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumns: new[] { "UserID", "RoleID" },
                keyValues: new object[] { 2, 3 },
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 456, DateTimeKind.Local).AddTicks(2456));

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "UserTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 428, DateTimeKind.Local).AddTicks(4537));

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "UserTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 428, DateTimeKind.Local).AddTicks(5132));

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "UserTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 428, DateTimeKind.Local).AddTicks(5140));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 441, DateTimeKind.Local).AddTicks(2008));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 444, DateTimeKind.Local).AddTicks(9426));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 16, 46, 36, 444, DateTimeKind.Local).AddTicks(9946));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "HasExpired",
                table: "Maintanances",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "BankAccountTypes",
                keyColumn: "BankAccountTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 401, DateTimeKind.Local).AddTicks(7412));

            migrationBuilder.UpdateData(
                table: "BankAccountTypes",
                keyColumn: "BankAccountTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 401, DateTimeKind.Local).AddTicks(7987));

            migrationBuilder.UpdateData(
                table: "BankAccountTypes",
                keyColumn: "BankAccountTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 401, DateTimeKind.Local).AddTicks(7996));

            migrationBuilder.UpdateData(
                table: "BankAccountTypes",
                keyColumn: "BankAccountTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 401, DateTimeKind.Local).AddTicks(7999));

            migrationBuilder.UpdateData(
                table: "ClientAccountTypes",
                keyColumn: "ID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 470, DateTimeKind.Local).AddTicks(9538));

            migrationBuilder.UpdateData(
                table: "ClientAccountTypes",
                keyColumn: "ID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 471, DateTimeKind.Local).AddTicks(365));

            migrationBuilder.UpdateData(
                table: "ClientGroups",
                keyColumn: "ClientGroupID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 477, DateTimeKind.Local).AddTicks(7362));

            migrationBuilder.UpdateData(
                table: "ClientGroups",
                keyColumn: "ClientGroupID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 478, DateTimeKind.Local).AddTicks(2540));

            migrationBuilder.UpdateData(
                table: "ContactTypes",
                keyColumn: "ContactTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 412, DateTimeKind.Local).AddTicks(9813));

            migrationBuilder.UpdateData(
                table: "ContactTypes",
                keyColumn: "ContactTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 412, DateTimeKind.Local).AddTicks(9807));

            migrationBuilder.UpdateData(
                table: "ContactTypes",
                keyColumn: "ContactTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 412, DateTimeKind.Local).AddTicks(9799));

            migrationBuilder.UpdateData(
                table: "ContactTypes",
                keyColumn: "ContactTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 412, DateTimeKind.Local).AddTicks(9661));

            migrationBuilder.UpdateData(
                table: "ContactTypes",
                keyColumn: "ContactTypeID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 412, DateTimeKind.Local).AddTicks(9818));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 420, DateTimeKind.Local).AddTicks(8195));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 420, DateTimeKind.Local).AddTicks(9287));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 420, DateTimeKind.Local).AddTicks(9307));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 420, DateTimeKind.Local).AddTicks(9319));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 420, DateTimeKind.Local).AddTicks(9324));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 420, DateTimeKind.Local).AddTicks(9343));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 420, DateTimeKind.Local).AddTicks(9348));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 420, DateTimeKind.Local).AddTicks(9354));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 420, DateTimeKind.Local).AddTicks(9359));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 420, DateTimeKind.Local).AddTicks(9366));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 420, DateTimeKind.Local).AddTicks(9372));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 420, DateTimeKind.Local).AddTicks(9377));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 13,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 420, DateTimeKind.Local).AddTicks(9382));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 14,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 420, DateTimeKind.Local).AddTicks(9387));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 15,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 420, DateTimeKind.Local).AddTicks(9392));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 16,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 420, DateTimeKind.Local).AddTicks(9399));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 17,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 420, DateTimeKind.Local).AddTicks(9403));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 18,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 420, DateTimeKind.Local).AddTicks(9411));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 19,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 420, DateTimeKind.Local).AddTicks(9416));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 20,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 420, DateTimeKind.Local).AddTicks(9421));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 21,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 420, DateTimeKind.Local).AddTicks(9427));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 22,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 420, DateTimeKind.Local).AddTicks(9432));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 23,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 420, DateTimeKind.Local).AddTicks(9442));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 24,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 420, DateTimeKind.Local).AddTicks(9456));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 25,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 420, DateTimeKind.Local).AddTicks(9462));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 26,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 420, DateTimeKind.Local).AddTicks(9467));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 27,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 420, DateTimeKind.Local).AddTicks(9474));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 28,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 420, DateTimeKind.Local).AddTicks(9478));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 29,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 420, DateTimeKind.Local).AddTicks(9483));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 30,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 420, DateTimeKind.Local).AddTicks(9492));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 31,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 420, DateTimeKind.Local).AddTicks(9498));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 32,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 420, DateTimeKind.Local).AddTicks(9502));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 33,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 420, DateTimeKind.Local).AddTicks(9508));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 34,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 420, DateTimeKind.Local).AddTicks(9516));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 35,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 420, DateTimeKind.Local).AddTicks(9520));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 36,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 420, DateTimeKind.Local).AddTicks(9524));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 37,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 420, DateTimeKind.Local).AddTicks(9530));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 38,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 420, DateTimeKind.Local).AddTicks(9534));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 39,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 420, DateTimeKind.Local).AddTicks(9540));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 40,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 420, DateTimeKind.Local).AddTicks(9546));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 41,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 420, DateTimeKind.Local).AddTicks(9619));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 42,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 420, DateTimeKind.Local).AddTicks(9625));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 43,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 420, DateTimeKind.Local).AddTicks(9631));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 44,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 420, DateTimeKind.Local).AddTicks(9636));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 45,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 420, DateTimeKind.Local).AddTicks(9641));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 46,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 420, DateTimeKind.Local).AddTicks(9646));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 47,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 420, DateTimeKind.Local).AddTicks(9652));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 48,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 420, DateTimeKind.Local).AddTicks(9659));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 49,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 420, DateTimeKind.Local).AddTicks(9665));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 50,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 420, DateTimeKind.Local).AddTicks(9670));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 51,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 420, DateTimeKind.Local).AddTicks(9676));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 52,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 420, DateTimeKind.Local).AddTicks(9680));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 53,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 420, DateTimeKind.Local).AddTicks(9685));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 54,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 420, DateTimeKind.Local).AddTicks(9689));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 55,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 420, DateTimeKind.Local).AddTicks(9695));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 56,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 420, DateTimeKind.Local).AddTicks(9699));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 57,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 420, DateTimeKind.Local).AddTicks(9703));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 58,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 420, DateTimeKind.Local).AddTicks(9708));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 59,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 420, DateTimeKind.Local).AddTicks(9715));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 60,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 420, DateTimeKind.Local).AddTicks(9720));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 61,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 420, DateTimeKind.Local).AddTicks(9725));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 62,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 420, DateTimeKind.Local).AddTicks(9729));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 63,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 420, DateTimeKind.Local).AddTicks(9735));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 64,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 420, DateTimeKind.Local).AddTicks(9741));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 65,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 420, DateTimeKind.Local).AddTicks(9746));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 66,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 420, DateTimeKind.Local).AddTicks(9754));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 67,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 420, DateTimeKind.Local).AddTicks(9759));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 68,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 420, DateTimeKind.Local).AddTicks(9764));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 69,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 420, DateTimeKind.Local).AddTicks(9769));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 70,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 420, DateTimeKind.Local).AddTicks(9774));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 71,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 420, DateTimeKind.Local).AddTicks(9778));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 72,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 420, DateTimeKind.Local).AddTicks(9783));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 73,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 420, DateTimeKind.Local).AddTicks(9789));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 74,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 420, DateTimeKind.Local).AddTicks(9793));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 75,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 420, DateTimeKind.Local).AddTicks(9799));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 76,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 420, DateTimeKind.Local).AddTicks(9807));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 77,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 420, DateTimeKind.Local).AddTicks(9813));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 78,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 420, DateTimeKind.Local).AddTicks(9818));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 79,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 420, DateTimeKind.Local).AddTicks(9822));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 80,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 420, DateTimeKind.Local).AddTicks(9827));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 81,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 420, DateTimeKind.Local).AddTicks(9831));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 82,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 420, DateTimeKind.Local).AddTicks(9836));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 83,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 420, DateTimeKind.Local).AddTicks(9840));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 84,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 420, DateTimeKind.Local).AddTicks(9845));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 85,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 420, DateTimeKind.Local).AddTicks(9851));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 86,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 420, DateTimeKind.Local).AddTicks(9856));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 87,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 420, DateTimeKind.Local).AddTicks(9860));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 88,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 420, DateTimeKind.Local).AddTicks(9865));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 89,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 420, DateTimeKind.Local).AddTicks(9870));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 90,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 420, DateTimeKind.Local).AddTicks(9874));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 91,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 420, DateTimeKind.Local).AddTicks(9878));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 92,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 420, DateTimeKind.Local).AddTicks(9883));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 93,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 420, DateTimeKind.Local).AddTicks(9888));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 94,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 420, DateTimeKind.Local).AddTicks(9892));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 95,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 420, DateTimeKind.Local).AddTicks(9896));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 96,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 420, DateTimeKind.Local).AddTicks(9900));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 97,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 420, DateTimeKind.Local).AddTicks(9905));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 98,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 420, DateTimeKind.Local).AddTicks(9910));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 99,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 420, DateTimeKind.Local).AddTicks(9915));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 100,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 420, DateTimeKind.Local).AddTicks(9976));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 101,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 420, DateTimeKind.Local).AddTicks(9983));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 102,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 420, DateTimeKind.Local).AddTicks(9989));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 103,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 420, DateTimeKind.Local).AddTicks(9993));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 104,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 420, DateTimeKind.Local).AddTicks(9998));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 105,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 421, DateTimeKind.Local).AddTicks(2));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 106,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 421, DateTimeKind.Local).AddTicks(7));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 107,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 421, DateTimeKind.Local).AddTicks(15));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 108,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 421, DateTimeKind.Local).AddTicks(20));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 109,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 421, DateTimeKind.Local).AddTicks(25));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 110,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 421, DateTimeKind.Local).AddTicks(30));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 111,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 421, DateTimeKind.Local).AddTicks(35));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 112,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 421, DateTimeKind.Local).AddTicks(40));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 113,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 421, DateTimeKind.Local).AddTicks(45));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 114,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 421, DateTimeKind.Local).AddTicks(49));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 115,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 421, DateTimeKind.Local).AddTicks(55));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 116,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 421, DateTimeKind.Local).AddTicks(59));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 117,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 421, DateTimeKind.Local).AddTicks(64));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 118,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 421, DateTimeKind.Local).AddTicks(68));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 119,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 421, DateTimeKind.Local).AddTicks(73));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 120,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 421, DateTimeKind.Local).AddTicks(78));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 121,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 421, DateTimeKind.Local).AddTicks(83));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 122,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 421, DateTimeKind.Local).AddTicks(87));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 123,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 421, DateTimeKind.Local).AddTicks(92));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 124,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 421, DateTimeKind.Local).AddTicks(96));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 125,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 421, DateTimeKind.Local).AddTicks(101));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 126,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 421, DateTimeKind.Local).AddTicks(106));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 127,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 421, DateTimeKind.Local).AddTicks(112));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 128,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 421, DateTimeKind.Local).AddTicks(116));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 129,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 421, DateTimeKind.Local).AddTicks(122));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 130,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 421, DateTimeKind.Local).AddTicks(131));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 131,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 421, DateTimeKind.Local).AddTicks(137));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 132,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 421, DateTimeKind.Local).AddTicks(143));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 133,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 421, DateTimeKind.Local).AddTicks(147));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 134,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 421, DateTimeKind.Local).AddTicks(152));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 135,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 421, DateTimeKind.Local).AddTicks(161));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 136,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 421, DateTimeKind.Local).AddTicks(168));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 137,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 421, DateTimeKind.Local).AddTicks(174));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 138,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 421, DateTimeKind.Local).AddTicks(180));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 139,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 421, DateTimeKind.Local).AddTicks(187));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 140,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 421, DateTimeKind.Local).AddTicks(191));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 141,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 421, DateTimeKind.Local).AddTicks(195));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 142,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 421, DateTimeKind.Local).AddTicks(201));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 143,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 421, DateTimeKind.Local).AddTicks(208));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 144,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 421, DateTimeKind.Local).AddTicks(214));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 145,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 421, DateTimeKind.Local).AddTicks(218));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 146,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 421, DateTimeKind.Local).AddTicks(223));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 147,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 421, DateTimeKind.Local).AddTicks(228));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 148,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 421, DateTimeKind.Local).AddTicks(233));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 149,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 421, DateTimeKind.Local).AddTicks(239));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 150,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 421, DateTimeKind.Local).AddTicks(246));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 151,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 421, DateTimeKind.Local).AddTicks(251));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 152,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 421, DateTimeKind.Local).AddTicks(257));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 153,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 421, DateTimeKind.Local).AddTicks(262));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 154,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 421, DateTimeKind.Local).AddTicks(267));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 155,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 421, DateTimeKind.Local).AddTicks(325));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 156,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 421, DateTimeKind.Local).AddTicks(330));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 157,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 421, DateTimeKind.Local).AddTicks(335));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 158,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 421, DateTimeKind.Local).AddTicks(340));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 159,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 421, DateTimeKind.Local).AddTicks(345));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 160,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 421, DateTimeKind.Local).AddTicks(350));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 161,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 421, DateTimeKind.Local).AddTicks(356));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 162,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 421, DateTimeKind.Local).AddTicks(361));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 163,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 421, DateTimeKind.Local).AddTicks(367));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 164,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 421, DateTimeKind.Local).AddTicks(372));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 165,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 421, DateTimeKind.Local).AddTicks(376));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 166,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 421, DateTimeKind.Local).AddTicks(381));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 167,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 421, DateTimeKind.Local).AddTicks(387));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 168,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 421, DateTimeKind.Local).AddTicks(392));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 169,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 421, DateTimeKind.Local).AddTicks(397));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 170,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 421, DateTimeKind.Local).AddTicks(402));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 171,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 421, DateTimeKind.Local).AddTicks(408));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 172,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 421, DateTimeKind.Local).AddTicks(413));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 173,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 421, DateTimeKind.Local).AddTicks(419));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 174,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 421, DateTimeKind.Local).AddTicks(427));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 175,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 421, DateTimeKind.Local).AddTicks(435));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 176,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 421, DateTimeKind.Local).AddTicks(442));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 177,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 421, DateTimeKind.Local).AddTicks(450));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 178,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 421, DateTimeKind.Local).AddTicks(454));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 179,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 421, DateTimeKind.Local).AddTicks(460));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 180,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 421, DateTimeKind.Local).AddTicks(466));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 181,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 421, DateTimeKind.Local).AddTicks(472));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 182,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 421, DateTimeKind.Local).AddTicks(477));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 183,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 421, DateTimeKind.Local).AddTicks(483));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 184,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 421, DateTimeKind.Local).AddTicks(487));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 185,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 421, DateTimeKind.Local).AddTicks(492));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 186,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 421, DateTimeKind.Local).AddTicks(497));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 187,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 421, DateTimeKind.Local).AddTicks(503));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 188,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 421, DateTimeKind.Local).AddTicks(508));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 189,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 421, DateTimeKind.Local).AddTicks(513));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 190,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 421, DateTimeKind.Local).AddTicks(518));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 191,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 421, DateTimeKind.Local).AddTicks(525));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 192,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 421, DateTimeKind.Local).AddTicks(530));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 193,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 421, DateTimeKind.Local).AddTicks(536));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 194,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 421, DateTimeKind.Local).AddTicks(541));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 195,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 421, DateTimeKind.Local).AddTicks(546));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 196,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 421, DateTimeKind.Local).AddTicks(550));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 197,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 421, DateTimeKind.Local).AddTicks(555));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 198,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 421, DateTimeKind.Local).AddTicks(560));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 199,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 421, DateTimeKind.Local).AddTicks(567));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 200,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 421, DateTimeKind.Local).AddTicks(571));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 201,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 421, DateTimeKind.Local).AddTicks(576));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 202,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 421, DateTimeKind.Local).AddTicks(580));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 203,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 421, DateTimeKind.Local).AddTicks(586));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 204,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 421, DateTimeKind.Local).AddTicks(591));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 205,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 421, DateTimeKind.Local).AddTicks(596));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 206,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 421, DateTimeKind.Local).AddTicks(601));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 207,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 421, DateTimeKind.Local).AddTicks(606));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 208,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 421, DateTimeKind.Local).AddTicks(611));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 209,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 421, DateTimeKind.Local).AddTicks(616));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 210,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 421, DateTimeKind.Local).AddTicks(622));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 211,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 421, DateTimeKind.Local).AddTicks(626));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 212,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 421, DateTimeKind.Local).AddTicks(631));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 213,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 421, DateTimeKind.Local).AddTicks(635));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 214,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 421, DateTimeKind.Local).AddTicks(641));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 215,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 421, DateTimeKind.Local).AddTicks(647));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 216,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 421, DateTimeKind.Local).AddTicks(652));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 217,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 421, DateTimeKind.Local).AddTicks(657));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 218,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 421, DateTimeKind.Local).AddTicks(662));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 219,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 421, DateTimeKind.Local).AddTicks(670));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 220,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 421, DateTimeKind.Local).AddTicks(675));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 221,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 421, DateTimeKind.Local).AddTicks(679));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 222,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 421, DateTimeKind.Local).AddTicks(685));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 223,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 421, DateTimeKind.Local).AddTicks(744));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 224,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 421, DateTimeKind.Local).AddTicks(751));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 225,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 421, DateTimeKind.Local).AddTicks(756));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 226,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 421, DateTimeKind.Local).AddTicks(762));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 227,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 421, DateTimeKind.Local).AddTicks(766));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 228,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 421, DateTimeKind.Local).AddTicks(771));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 406, DateTimeKind.Local).AddTicks(493));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 406, DateTimeKind.Local).AddTicks(1132));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 406, DateTimeKind.Local).AddTicks(1208));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 406, DateTimeKind.Local).AddTicks(1214));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 406, DateTimeKind.Local).AddTicks(1219));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 406, DateTimeKind.Local).AddTicks(1230));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 406, DateTimeKind.Local).AddTicks(1235));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 406, DateTimeKind.Local).AddTicks(1239));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 406, DateTimeKind.Local).AddTicks(1243));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 406, DateTimeKind.Local).AddTicks(1250));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 406, DateTimeKind.Local).AddTicks(1254));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 406, DateTimeKind.Local).AddTicks(1258));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 13,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 406, DateTimeKind.Local).AddTicks(1263));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 14,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 406, DateTimeKind.Local).AddTicks(1267));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 15,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 406, DateTimeKind.Local).AddTicks(1271));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 16,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 406, DateTimeKind.Local).AddTicks(1275));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 17,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 406, DateTimeKind.Local).AddTicks(1280));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 18,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 406, DateTimeKind.Local).AddTicks(1286));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 19,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 406, DateTimeKind.Local).AddTicks(1290));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 20,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 406, DateTimeKind.Local).AddTicks(1294));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 21,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 406, DateTimeKind.Local).AddTicks(1301));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 22,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 406, DateTimeKind.Local).AddTicks(1305));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 23,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 406, DateTimeKind.Local).AddTicks(1309));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 24,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 406, DateTimeKind.Local).AddTicks(1313));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 25,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 406, DateTimeKind.Local).AddTicks(1317));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 26,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 406, DateTimeKind.Local).AddTicks(1321));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 27,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 406, DateTimeKind.Local).AddTicks(1325));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 28,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 406, DateTimeKind.Local).AddTicks(1329));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 29,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 406, DateTimeKind.Local).AddTicks(1334));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 30,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 406, DateTimeKind.Local).AddTicks(1338));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 31,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 406, DateTimeKind.Local).AddTicks(1342));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 32,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 406, DateTimeKind.Local).AddTicks(1346));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 33,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 406, DateTimeKind.Local).AddTicks(1350));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 34,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 406, DateTimeKind.Local).AddTicks(1357));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 35,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 406, DateTimeKind.Local).AddTicks(1361));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 36,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 406, DateTimeKind.Local).AddTicks(1366));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 37,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 406, DateTimeKind.Local).AddTicks(1370));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 38,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 406, DateTimeKind.Local).AddTicks(1373));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 39,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 406, DateTimeKind.Local).AddTicks(1378));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 40,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 406, DateTimeKind.Local).AddTicks(1382));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 41,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 406, DateTimeKind.Local).AddTicks(1388));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 42,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 406, DateTimeKind.Local).AddTicks(1392));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 43,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 406, DateTimeKind.Local).AddTicks(1397));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 44,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 406, DateTimeKind.Local).AddTicks(1401));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 45,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 406, DateTimeKind.Local).AddTicks(1405));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 46,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 406, DateTimeKind.Local).AddTicks(1410));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 47,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 406, DateTimeKind.Local).AddTicks(1414));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 48,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 406, DateTimeKind.Local).AddTicks(1418));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 49,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 406, DateTimeKind.Local).AddTicks(1422));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 50,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 406, DateTimeKind.Local).AddTicks(1426));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 51,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 406, DateTimeKind.Local).AddTicks(1430));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 52,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 406, DateTimeKind.Local).AddTicks(1435));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 53,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 406, DateTimeKind.Local).AddTicks(1439));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 54,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 406, DateTimeKind.Local).AddTicks(1443));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 55,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 406, DateTimeKind.Local).AddTicks(1447));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 56,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 406, DateTimeKind.Local).AddTicks(1451));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 57,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 406, DateTimeKind.Local).AddTicks(1455));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 58,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 406, DateTimeKind.Local).AddTicks(1459));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 59,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 406, DateTimeKind.Local).AddTicks(1463));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 60,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 406, DateTimeKind.Local).AddTicks(1467));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 61,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 406, DateTimeKind.Local).AddTicks(1472));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 62,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 406, DateTimeKind.Local).AddTicks(1476));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 63,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 406, DateTimeKind.Local).AddTicks(1480));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 64,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 406, DateTimeKind.Local).AddTicks(1485));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 65,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 406, DateTimeKind.Local).AddTicks(1488));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 66,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 406, DateTimeKind.Local).AddTicks(1626));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 67,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 406, DateTimeKind.Local).AddTicks(1631));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 68,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 406, DateTimeKind.Local).AddTicks(1635));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 69,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 406, DateTimeKind.Local).AddTicks(1639));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 70,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 406, DateTimeKind.Local).AddTicks(1643));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 71,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 406, DateTimeKind.Local).AddTicks(1647));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 72,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 406, DateTimeKind.Local).AddTicks(1651));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 73,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 406, DateTimeKind.Local).AddTicks(1655));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 74,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 406, DateTimeKind.Local).AddTicks(1659));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 75,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 406, DateTimeKind.Local).AddTicks(1663));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 76,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 406, DateTimeKind.Local).AddTicks(1667));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 77,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 406, DateTimeKind.Local).AddTicks(1671));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 78,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 406, DateTimeKind.Local).AddTicks(1675));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 79,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 406, DateTimeKind.Local).AddTicks(1679));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 80,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 406, DateTimeKind.Local).AddTicks(1683));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 81,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 406, DateTimeKind.Local).AddTicks(1687));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 82,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 406, DateTimeKind.Local).AddTicks(1692));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 83,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 406, DateTimeKind.Local).AddTicks(1696));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 84,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 406, DateTimeKind.Local).AddTicks(1701));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 85,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 406, DateTimeKind.Local).AddTicks(1705));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 86,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 406, DateTimeKind.Local).AddTicks(1709));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 87,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 406, DateTimeKind.Local).AddTicks(1713));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 88,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 406, DateTimeKind.Local).AddTicks(1717));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 89,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 406, DateTimeKind.Local).AddTicks(1720));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 90,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 406, DateTimeKind.Local).AddTicks(1724));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 91,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 406, DateTimeKind.Local).AddTicks(1728));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 92,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 406, DateTimeKind.Local).AddTicks(1732));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 93,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 406, DateTimeKind.Local).AddTicks(1736));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 94,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 406, DateTimeKind.Local).AddTicks(1741));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 95,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 406, DateTimeKind.Local).AddTicks(1745));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 96,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 406, DateTimeKind.Local).AddTicks(1748));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 97,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 406, DateTimeKind.Local).AddTicks(1752));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 98,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 406, DateTimeKind.Local).AddTicks(1756));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 99,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 406, DateTimeKind.Local).AddTicks(1760));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 100,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 406, DateTimeKind.Local).AddTicks(1764));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 101,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 406, DateTimeKind.Local).AddTicks(1768));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 102,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 406, DateTimeKind.Local).AddTicks(1772));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 103,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 406, DateTimeKind.Local).AddTicks(1776));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 104,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 406, DateTimeKind.Local).AddTicks(1780));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 105,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 406, DateTimeKind.Local).AddTicks(1785));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 106,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 406, DateTimeKind.Local).AddTicks(1788));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 107,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 406, DateTimeKind.Local).AddTicks(1792));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 108,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 406, DateTimeKind.Local).AddTicks(1796));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 109,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 406, DateTimeKind.Local).AddTicks(1800));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 110,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 406, DateTimeKind.Local).AddTicks(1804));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 111,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 406, DateTimeKind.Local).AddTicks(1808));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 112,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 406, DateTimeKind.Local).AddTicks(1812));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 113,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 406, DateTimeKind.Local).AddTicks(1816));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 114,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 406, DateTimeKind.Local).AddTicks(1820));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 115,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 406, DateTimeKind.Local).AddTicks(1824));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 116,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 406, DateTimeKind.Local).AddTicks(1828));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 117,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 406, DateTimeKind.Local).AddTicks(1832));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 118,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 406, DateTimeKind.Local).AddTicks(1836));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 119,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 406, DateTimeKind.Local).AddTicks(1840));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 120,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 406, DateTimeKind.Local).AddTicks(1844));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 121,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 406, DateTimeKind.Local).AddTicks(1848));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 122,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 406, DateTimeKind.Local).AddTicks(1851));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 123,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 406, DateTimeKind.Local).AddTicks(1856));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 124,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 406, DateTimeKind.Local).AddTicks(1860));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 125,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 406, DateTimeKind.Local).AddTicks(1865));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 126,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 406, DateTimeKind.Local).AddTicks(1869));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 127,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 406, DateTimeKind.Local).AddTicks(1873));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 128,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 406, DateTimeKind.Local).AddTicks(1877));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 129,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 406, DateTimeKind.Local).AddTicks(1881));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 130,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 406, DateTimeKind.Local).AddTicks(1930));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 131,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 406, DateTimeKind.Local).AddTicks(1936));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 132,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 406, DateTimeKind.Local).AddTicks(1940));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 133,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 406, DateTimeKind.Local).AddTicks(1944));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 134,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 406, DateTimeKind.Local).AddTicks(1948));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 135,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 406, DateTimeKind.Local).AddTicks(1952));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 136,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 406, DateTimeKind.Local).AddTicks(1956));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 137,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 406, DateTimeKind.Local).AddTicks(1960));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 138,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 406, DateTimeKind.Local).AddTicks(1964));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 139,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 406, DateTimeKind.Local).AddTicks(1967));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 140,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 406, DateTimeKind.Local).AddTicks(1971));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 141,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 406, DateTimeKind.Local).AddTicks(1975));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 142,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 406, DateTimeKind.Local).AddTicks(1979));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 143,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 406, DateTimeKind.Local).AddTicks(1983));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 144,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 406, DateTimeKind.Local).AddTicks(1988));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 145,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 406, DateTimeKind.Local).AddTicks(1991));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 146,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 406, DateTimeKind.Local).AddTicks(1996));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 147,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 406, DateTimeKind.Local).AddTicks(1999));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 148,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 406, DateTimeKind.Local).AddTicks(2003));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 149,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 406, DateTimeKind.Local).AddTicks(2007));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 150,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 406, DateTimeKind.Local).AddTicks(2011));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 151,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 406, DateTimeKind.Local).AddTicks(2015));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 152,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 406, DateTimeKind.Local).AddTicks(2019));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 153,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 406, DateTimeKind.Local).AddTicks(2023));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 154,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 406, DateTimeKind.Local).AddTicks(2027));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 155,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 406, DateTimeKind.Local).AddTicks(2031));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 156,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 406, DateTimeKind.Local).AddTicks(2035));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 157,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 406, DateTimeKind.Local).AddTicks(2039));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 158,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 406, DateTimeKind.Local).AddTicks(2043));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 159,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 406, DateTimeKind.Local).AddTicks(2047));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 160,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 406, DateTimeKind.Local).AddTicks(2051));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 161,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 406, DateTimeKind.Local).AddTicks(2055));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 162,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 406, DateTimeKind.Local).AddTicks(2059));

            migrationBuilder.UpdateData(
                table: "CustomSettingTypes",
                keyColumn: "CustomSettingTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 414, DateTimeKind.Local).AddTicks(8937));

            migrationBuilder.UpdateData(
                table: "CustomSettingTypes",
                keyColumn: "CustomSettingTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 414, DateTimeKind.Local).AddTicks(9079));

            migrationBuilder.UpdateData(
                table: "CustomSettingTypes",
                keyColumn: "CustomSettingTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 414, DateTimeKind.Local).AddTicks(9085));

            migrationBuilder.UpdateData(
                table: "CustomSettingTypes",
                keyColumn: "CustomSettingTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 414, DateTimeKind.Local).AddTicks(9089));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 454, DateTimeKind.Local).AddTicks(5729));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 454, DateTimeKind.Local).AddTicks(6022));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 454, DateTimeKind.Local).AddTicks(6069));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 454, DateTimeKind.Local).AddTicks(6035));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 454, DateTimeKind.Local).AddTicks(6075));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 454, DateTimeKind.Local).AddTicks(6094));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 454, DateTimeKind.Local).AddTicks(6103));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 454, DateTimeKind.Local).AddTicks(6110));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 454, DateTimeKind.Local).AddTicks(6119));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 454, DateTimeKind.Local).AddTicks(6128));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 454, DateTimeKind.Local).AddTicks(6196));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 454, DateTimeKind.Local).AddTicks(6204));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 13,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 454, DateTimeKind.Local).AddTicks(6211));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 14,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 454, DateTimeKind.Local).AddTicks(6219));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 15,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 454, DateTimeKind.Local).AddTicks(6045));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 16,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 454, DateTimeKind.Local).AddTicks(6011));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 17,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 454, DateTimeKind.Local).AddTicks(6230));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 18,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 454, DateTimeKind.Local).AddTicks(6237));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 19,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 454, DateTimeKind.Local).AddTicks(6245));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 20,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 454, DateTimeKind.Local).AddTicks(6273));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 22,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 454, DateTimeKind.Local).AddTicks(6306));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 23,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 454, DateTimeKind.Local).AddTicks(6290));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 24,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 454, DateTimeKind.Local).AddTicks(6282));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 25,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 454, DateTimeKind.Local).AddTicks(6299));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 26,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 454, DateTimeKind.Local).AddTicks(6314));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 27,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 454, DateTimeKind.Local).AddTicks(6322));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 28,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 454, DateTimeKind.Local).AddTicks(6329));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 30,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 454, DateTimeKind.Local).AddTicks(6338));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 31,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 454, DateTimeKind.Local).AddTicks(6346));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 32,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 454, DateTimeKind.Local).AddTicks(6354));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 33,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 454, DateTimeKind.Local).AddTicks(6362));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 34,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 454, DateTimeKind.Local).AddTicks(6370));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 36,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 454, DateTimeKind.Local).AddTicks(6380));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 37,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 454, DateTimeKind.Local).AddTicks(6388));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 38,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 454, DateTimeKind.Local).AddTicks(6397));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 39,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 454, DateTimeKind.Local).AddTicks(6087));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 40,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 454, DateTimeKind.Local).AddTicks(6407));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 41,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 454, DateTimeKind.Local).AddTicks(6414));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 42,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 454, DateTimeKind.Local).AddTicks(6422));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 43,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 454, DateTimeKind.Local).AddTicks(6429));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 44,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 454, DateTimeKind.Local).AddTicks(6437));

            migrationBuilder.UpdateData(
                table: "DocumentFormats",
                keyColumn: "DocumentFormatID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 432, DateTimeKind.Local).AddTicks(9099));

            migrationBuilder.UpdateData(
                table: "DocumentFormats",
                keyColumn: "DocumentFormatID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 432, DateTimeKind.Local).AddTicks(9592));

            migrationBuilder.UpdateData(
                table: "DocumentFormats",
                keyColumn: "DocumentFormatID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 432, DateTimeKind.Local).AddTicks(9599));

            migrationBuilder.UpdateData(
                table: "DocumentFormats",
                keyColumn: "DocumentFormatID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 432, DateTimeKind.Local).AddTicks(9603));

            migrationBuilder.UpdateData(
                table: "DocumentFormats",
                keyColumn: "DocumentFormatID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 432, DateTimeKind.Local).AddTicks(9606));

            migrationBuilder.UpdateData(
                table: "DocumentFormats",
                keyColumn: "DocumentFormatID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 432, DateTimeKind.Local).AddTicks(9616));

            migrationBuilder.UpdateData(
                table: "DocumentTypes",
                keyColumn: "DocumentTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 435, DateTimeKind.Local).AddTicks(9490));

            migrationBuilder.UpdateData(
                table: "DocumentTypes",
                keyColumn: "DocumentTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 436, DateTimeKind.Local).AddTicks(620));

            migrationBuilder.UpdateData(
                table: "DocumentTypes",
                keyColumn: "DocumentTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 436, DateTimeKind.Local).AddTicks(644));

            migrationBuilder.UpdateData(
                table: "DocumentTypes",
                keyColumn: "DocumentTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 436, DateTimeKind.Local).AddTicks(649));

            migrationBuilder.UpdateData(
                table: "EmailTemplates",
                keyColumn: "EmailTemplateID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 447, DateTimeKind.Local).AddTicks(9328));

            migrationBuilder.UpdateData(
                table: "EmailTypes",
                keyColumn: "EmailTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 447, DateTimeKind.Local).AddTicks(1800));

            migrationBuilder.UpdateData(
                table: "EmailTypes",
                keyColumn: "EmailTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 447, DateTimeKind.Local).AddTicks(2398));

            migrationBuilder.UpdateData(
                table: "EmailTypes",
                keyColumn: "EmailTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 447, DateTimeKind.Local).AddTicks(2407));

            migrationBuilder.UpdateData(
                table: "EmailTypes",
                keyColumn: "EmailTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 447, DateTimeKind.Local).AddTicks(2487));

            migrationBuilder.UpdateData(
                table: "FeatureFlags",
                keyColumn: "FeatureFlagID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 429, DateTimeKind.Local).AddTicks(9261));

            migrationBuilder.UpdateData(
                table: "FeatureFlags",
                keyColumn: "FeatureFlagID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 429, DateTimeKind.Local).AddTicks(9924));

            migrationBuilder.UpdateData(
                table: "FeatureFlags",
                keyColumn: "FeatureFlagID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 429, DateTimeKind.Local).AddTicks(9935));

            migrationBuilder.UpdateData(
                table: "Frequencies",
                keyColumn: "FrequencyID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 408, DateTimeKind.Local).AddTicks(9856));

            migrationBuilder.UpdateData(
                table: "Frequencies",
                keyColumn: "FrequencyID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 409, DateTimeKind.Local).AddTicks(358));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "GenderID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 416, DateTimeKind.Local).AddTicks(9489));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "GenderID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 416, DateTimeKind.Local).AddTicks(9608));

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "InvoiceStatusID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 482, DateTimeKind.Local).AddTicks(418));

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "InvoiceStatusID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 482, DateTimeKind.Local).AddTicks(1188));

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "InvoiceStatusID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 482, DateTimeKind.Local).AddTicks(1199));

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "InvoiceStatusID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 482, DateTimeKind.Local).AddTicks(1204));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 438, DateTimeKind.Local).AddTicks(6246));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 438, DateTimeKind.Local).AddTicks(6471));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 438, DateTimeKind.Local).AddTicks(6487));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 438, DateTimeKind.Local).AddTicks(6493));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 438, DateTimeKind.Local).AddTicks(6500));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 438, DateTimeKind.Local).AddTicks(6527));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 999,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 438, DateTimeKind.Local).AddTicks(6521));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 9998,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 438, DateTimeKind.Local).AddTicks(6513));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 441, DateTimeKind.Local).AddTicks(2094));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 441, DateTimeKind.Local).AddTicks(2303));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 441, DateTimeKind.Local).AddTicks(2309));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 441, DateTimeKind.Local).AddTicks(2314));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 441, DateTimeKind.Local).AddTicks(2318));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 441, DateTimeKind.Local).AddTicks(2329));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 441, DateTimeKind.Local).AddTicks(2334));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 441, DateTimeKind.Local).AddTicks(2338));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 441, DateTimeKind.Local).AddTicks(2344));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 441, DateTimeKind.Local).AddTicks(2350));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 441, DateTimeKind.Local).AddTicks(2354));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 13,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 441, DateTimeKind.Local).AddTicks(2358));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 14,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 441, DateTimeKind.Local).AddTicks(2363));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 15,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 441, DateTimeKind.Local).AddTicks(2367));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 16,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 441, DateTimeKind.Local).AddTicks(2372));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 17,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 441, DateTimeKind.Local).AddTicks(2376));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 18,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 441, DateTimeKind.Local).AddTicks(2380));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 19,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 441, DateTimeKind.Local).AddTicks(2386));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 20,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 441, DateTimeKind.Local).AddTicks(2390));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 9997,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 441, DateTimeKind.Local).AddTicks(2395));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 9998,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 441, DateTimeKind.Local).AddTicks(2399));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 9999,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 441, DateTimeKind.Local).AddTicks(2403));

            migrationBuilder.UpdateData(
                table: "PaymentStatus",
                keyColumn: "PaymentStatusID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 395, DateTimeKind.Local).AddTicks(785));

            migrationBuilder.UpdateData(
                table: "PaymentStatus",
                keyColumn: "PaymentStatusID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 395, DateTimeKind.Local).AddTicks(1360));

            migrationBuilder.UpdateData(
                table: "PaymentStatus",
                keyColumn: "PaymentStatusID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 395, DateTimeKind.Local).AddTicks(1368));

            migrationBuilder.UpdateData(
                table: "PaymentStatus",
                keyColumn: "PaymentStatusID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 395, DateTimeKind.Local).AddTicks(1372));

            migrationBuilder.UpdateData(
                table: "PaymentStatus",
                keyColumn: "PaymentStatusID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 395, DateTimeKind.Local).AddTicks(1376));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 390, DateTimeKind.Local).AddTicks(7378));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 390, DateTimeKind.Local).AddTicks(7998));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 390, DateTimeKind.Local).AddTicks(8009));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 390, DateTimeKind.Local).AddTicks(8015));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 390, DateTimeKind.Local).AddTicks(8022));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 390, DateTimeKind.Local).AddTicks(8035));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 390, DateTimeKind.Local).AddTicks(8040));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 390, DateTimeKind.Local).AddTicks(8045));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 390, DateTimeKind.Local).AddTicks(8050));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 390, DateTimeKind.Local).AddTicks(8058));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 390, DateTimeKind.Local).AddTicks(8064));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 390, DateTimeKind.Local).AddTicks(8069));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 13,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 390, DateTimeKind.Local).AddTicks(8074));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 14,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 390, DateTimeKind.Local).AddTicks(8079));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 15,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 390, DateTimeKind.Local).AddTicks(8085));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 16,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 390, DateTimeKind.Local).AddTicks(8091));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 17,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 390, DateTimeKind.Local).AddTicks(8096));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 18,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 390, DateTimeKind.Local).AddTicks(8105));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 19,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 390, DateTimeKind.Local).AddTicks(8110));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 20,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 390, DateTimeKind.Local).AddTicks(8115));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 21,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 390, DateTimeKind.Local).AddTicks(8121));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 22,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 390, DateTimeKind.Local).AddTicks(8126));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 23,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 390, DateTimeKind.Local).AddTicks(8132));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 24,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 390, DateTimeKind.Local).AddTicks(8138));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 25,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 390, DateTimeKind.Local).AddTicks(8144));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 26,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 390, DateTimeKind.Local).AddTicks(8149));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 27,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 390, DateTimeKind.Local).AddTicks(8155));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 28,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 390, DateTimeKind.Local).AddTicks(8160));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 29,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 390, DateTimeKind.Local).AddTicks(8165));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 30,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 390, DateTimeKind.Local).AddTicks(8170));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 31,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 390, DateTimeKind.Local).AddTicks(8176));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 32,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 390, DateTimeKind.Local).AddTicks(8181));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 33,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 390, DateTimeKind.Local).AddTicks(8187));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 34,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 390, DateTimeKind.Local).AddTicks(8280));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 35,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 390, DateTimeKind.Local).AddTicks(8289));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 36,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 390, DateTimeKind.Local).AddTicks(8295));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 37,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 390, DateTimeKind.Local).AddTicks(8300));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 38,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 390, DateTimeKind.Local).AddTicks(8306));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 39,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 390, DateTimeKind.Local).AddTicks(8311));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 40,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 390, DateTimeKind.Local).AddTicks(8315));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 41,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 390, DateTimeKind.Local).AddTicks(8320));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 42,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 390, DateTimeKind.Local).AddTicks(8325));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 43,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 390, DateTimeKind.Local).AddTicks(8330));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 44,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 390, DateTimeKind.Local).AddTicks(8339));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 45,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 390, DateTimeKind.Local).AddTicks(8344));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 46,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 390, DateTimeKind.Local).AddTicks(8350));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 47,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 390, DateTimeKind.Local).AddTicks(8356));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 48,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 390, DateTimeKind.Local).AddTicks(8361));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 49,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 390, DateTimeKind.Local).AddTicks(8365));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 50,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 390, DateTimeKind.Local).AddTicks(8370));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 51,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 390, DateTimeKind.Local).AddTicks(8374));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 52,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 390, DateTimeKind.Local).AddTicks(8380));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 53,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 390, DateTimeKind.Local).AddTicks(8386));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 54,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 390, DateTimeKind.Local).AddTicks(8391));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 55,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 390, DateTimeKind.Local).AddTicks(8396));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 56,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 390, DateTimeKind.Local).AddTicks(8401));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 57,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 390, DateTimeKind.Local).AddTicks(8406));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 58,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 390, DateTimeKind.Local).AddTicks(8410));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 59,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 390, DateTimeKind.Local).AddTicks(8416));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 60,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 390, DateTimeKind.Local).AddTicks(8421));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 61,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 390, DateTimeKind.Local).AddTicks(8426));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 62,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 390, DateTimeKind.Local).AddTicks(8432));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 63,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 390, DateTimeKind.Local).AddTicks(8437));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 64,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 390, DateTimeKind.Local).AddTicks(8441));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 65,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 390, DateTimeKind.Local).AddTicks(8446));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 66,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 390, DateTimeKind.Local).AddTicks(8454));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 67,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 390, DateTimeKind.Local).AddTicks(8459));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 68,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 390, DateTimeKind.Local).AddTicks(8463));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 69,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 390, DateTimeKind.Local).AddTicks(8469));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 70,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 390, DateTimeKind.Local).AddTicks(8474));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 71,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 390, DateTimeKind.Local).AddTicks(8479));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 72,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 390, DateTimeKind.Local).AddTicks(8602));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 73,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 390, DateTimeKind.Local).AddTicks(8610));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 74,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 390, DateTimeKind.Local).AddTicks(8615));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 75,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 390, DateTimeKind.Local).AddTicks(8620));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 76,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 390, DateTimeKind.Local).AddTicks(8624));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 77,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 390, DateTimeKind.Local).AddTicks(8629));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 78,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 390, DateTimeKind.Local).AddTicks(8635));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 79,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 390, DateTimeKind.Local).AddTicks(8640));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 80,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 390, DateTimeKind.Local).AddTicks(8645));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 81,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 390, DateTimeKind.Local).AddTicks(8650));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 82,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 390, DateTimeKind.Local).AddTicks(8655));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 83,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 390, DateTimeKind.Local).AddTicks(8660));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 84,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 390, DateTimeKind.Local).AddTicks(8665));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 85,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 390, DateTimeKind.Local).AddTicks(8670));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 86,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 390, DateTimeKind.Local).AddTicks(8676));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 87,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 390, DateTimeKind.Local).AddTicks(8681));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 88,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 390, DateTimeKind.Local).AddTicks(8686));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 89,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 390, DateTimeKind.Local).AddTicks(8691));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 90,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 390, DateTimeKind.Local).AddTicks(8696));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 91,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 390, DateTimeKind.Local).AddTicks(8701));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 92,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 390, DateTimeKind.Local).AddTicks(8706));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 93,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 390, DateTimeKind.Local).AddTicks(8711));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 94,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 390, DateTimeKind.Local).AddTicks(8716));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 95,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 390, DateTimeKind.Local).AddTicks(8722));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 96,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 390, DateTimeKind.Local).AddTicks(8727));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 97,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 390, DateTimeKind.Local).AddTicks(8732));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 98,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 390, DateTimeKind.Local).AddTicks(8737));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 99,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 390, DateTimeKind.Local).AddTicks(8742));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 100,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 390, DateTimeKind.Local).AddTicks(8747));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 101,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 390, DateTimeKind.Local).AddTicks(8752));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 102,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 390, DateTimeKind.Local).AddTicks(8757));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 103,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 390, DateTimeKind.Local).AddTicks(8762));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 104,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 390, DateTimeKind.Local).AddTicks(8766));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 105,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 390, DateTimeKind.Local).AddTicks(8771));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 106,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 390, DateTimeKind.Local).AddTicks(8777));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 107,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 390, DateTimeKind.Local).AddTicks(8782));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 108,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 390, DateTimeKind.Local).AddTicks(8788));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 109,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 390, DateTimeKind.Local).AddTicks(8793));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 110,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 390, DateTimeKind.Local).AddTicks(8798));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 111,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 390, DateTimeKind.Local).AddTicks(8803));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 112,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 390, DateTimeKind.Local).AddTicks(8808));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 113,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 390, DateTimeKind.Local).AddTicks(8813));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 114,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 390, DateTimeKind.Local).AddTicks(8818));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 115,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 390, DateTimeKind.Local).AddTicks(8823));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 116,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 390, DateTimeKind.Local).AddTicks(8829));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 117,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 390, DateTimeKind.Local).AddTicks(8834));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 118,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 390, DateTimeKind.Local).AddTicks(8877));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 119,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 390, DateTimeKind.Local).AddTicks(8882));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 120,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 390, DateTimeKind.Local).AddTicks(8887));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 121,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 390, DateTimeKind.Local).AddTicks(8892));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 122,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 390, DateTimeKind.Local).AddTicks(8897));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 123,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 390, DateTimeKind.Local).AddTicks(8902));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 124,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 390, DateTimeKind.Local).AddTicks(8906));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 125,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 390, DateTimeKind.Local).AddTicks(8911));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 126,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 390, DateTimeKind.Local).AddTicks(8916));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 127,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 390, DateTimeKind.Local).AddTicks(8921));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 128,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 390, DateTimeKind.Local).AddTicks(8926));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 129,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 390, DateTimeKind.Local).AddTicks(8932));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 130,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 390, DateTimeKind.Local).AddTicks(8941));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 131,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 390, DateTimeKind.Local).AddTicks(8946));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 132,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 390, DateTimeKind.Local).AddTicks(8952));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 133,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 390, DateTimeKind.Local).AddTicks(8958));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 134,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 390, DateTimeKind.Local).AddTicks(8963));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 135,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 390, DateTimeKind.Local).AddTicks(8969));

            migrationBuilder.UpdateData(
                table: "PriorityRanks",
                keyColumn: "PriorityRankID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 422, DateTimeKind.Local).AddTicks(5369));

            migrationBuilder.UpdateData(
                table: "PriorityRanks",
                keyColumn: "PriorityRankID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 422, DateTimeKind.Local).AddTicks(5568));

            migrationBuilder.UpdateData(
                table: "PriorityRanks",
                keyColumn: "PriorityRankID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 422, DateTimeKind.Local).AddTicks(5699));

            migrationBuilder.UpdateData(
                table: "PriorityRanks",
                keyColumn: "PriorityRankID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 422, DateTimeKind.Local).AddTicks(5705));

            migrationBuilder.UpdateData(
                table: "RecordStatus",
                keyColumn: "RecordStatusID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 474, DateTimeKind.Local).AddTicks(976));

            migrationBuilder.UpdateData(
                table: "RecordStatus",
                keyColumn: "RecordStatusID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 474, DateTimeKind.Local).AddTicks(1466));

            migrationBuilder.UpdateData(
                table: "RecordStatus",
                keyColumn: "RecordStatusID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 474, DateTimeKind.Local).AddTicks(1473));

            migrationBuilder.UpdateData(
                table: "RelationshipTypes",
                keyColumn: "RelationshipTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 413, DateTimeKind.Local).AddTicks(8662));

            migrationBuilder.UpdateData(
                table: "RelationshipTypes",
                keyColumn: "RelationshipTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 413, DateTimeKind.Local).AddTicks(8879));

            migrationBuilder.UpdateData(
                table: "RelationshipTypes",
                keyColumn: "RelationshipTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 413, DateTimeKind.Local).AddTicks(8883));

            migrationBuilder.UpdateData(
                table: "RelationshipTypes",
                keyColumn: "RelationshipTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 413, DateTimeKind.Local).AddTicks(8886));

            migrationBuilder.UpdateData(
                table: "RelationshipTypes",
                keyColumn: "RelationshipTypeID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 413, DateTimeKind.Local).AddTicks(8888));

            migrationBuilder.UpdateData(
                table: "RelationshipTypes",
                keyColumn: "RelationshipTypeID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 413, DateTimeKind.Local).AddTicks(8897));

            migrationBuilder.UpdateData(
                table: "RelationshipTypes",
                keyColumn: "RelationshipTypeID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 413, DateTimeKind.Local).AddTicks(8899));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 455, DateTimeKind.Local).AddTicks(4564));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 455, DateTimeKind.Local).AddTicks(4706));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 455, DateTimeKind.Local).AddTicks(4709));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 455, DateTimeKind.Local).AddTicks(4712));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 455, DateTimeKind.Local).AddTicks(4715));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 455, DateTimeKind.Local).AddTicks(4721));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 455, DateTimeKind.Local).AddTicks(4723));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 455, DateTimeKind.Local).AddTicks(4726));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 455, DateTimeKind.Local).AddTicks(4729));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 455, DateTimeKind.Local).AddTicks(4733));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 455, DateTimeKind.Local).AddTicks(4736));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 455, DateTimeKind.Local).AddTicks(4738));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 13,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 455, DateTimeKind.Local).AddTicks(4741));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 14,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 455, DateTimeKind.Local).AddTicks(4743));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 15,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 455, DateTimeKind.Local).AddTicks(4746));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 16,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 455, DateTimeKind.Local).AddTicks(4749));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 17,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 455, DateTimeKind.Local).AddTicks(4751));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 18,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 455, DateTimeKind.Local).AddTicks(4756));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 19,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 455, DateTimeKind.Local).AddTicks(4758));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 20,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 455, DateTimeKind.Local).AddTicks(4761));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 21,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 455, DateTimeKind.Local).AddTicks(4763));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 22,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 455, DateTimeKind.Local).AddTicks(4766));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 391, DateTimeKind.Local).AddTicks(7817));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 391, DateTimeKind.Local).AddTicks(7981));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 391, DateTimeKind.Local).AddTicks(7985));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 391, DateTimeKind.Local).AddTicks(7988));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 391, DateTimeKind.Local).AddTicks(7990));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 391, DateTimeKind.Local).AddTicks(7999));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 391, DateTimeKind.Local).AddTicks(8001));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 391, DateTimeKind.Local).AddTicks(8004));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 391, DateTimeKind.Local).AddTicks(8008));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 391, DateTimeKind.Local).AddTicks(8012));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 391, DateTimeKind.Local).AddTicks(8015));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 391, DateTimeKind.Local).AddTicks(8017));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 13,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 391, DateTimeKind.Local).AddTicks(8020));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 14,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 391, DateTimeKind.Local).AddTicks(8022));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 15,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 391, DateTimeKind.Local).AddTicks(8024));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 16,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 391, DateTimeKind.Local).AddTicks(8027));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 17,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 391, DateTimeKind.Local).AddTicks(8029));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 18,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 391, DateTimeKind.Local).AddTicks(8034));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 19,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 391, DateTimeKind.Local).AddTicks(8036));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 20,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 391, DateTimeKind.Local).AddTicks(8039));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 21,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 391, DateTimeKind.Local).AddTicks(8041));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 22,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 391, DateTimeKind.Local).AddTicks(8043));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 23,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 391, DateTimeKind.Local).AddTicks(8046));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 24,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 391, DateTimeKind.Local).AddTicks(8048));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 25,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 391, DateTimeKind.Local).AddTicks(8050));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 26,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 391, DateTimeKind.Local).AddTicks(8052));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 27,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 391, DateTimeKind.Local).AddTicks(8055));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 28,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 391, DateTimeKind.Local).AddTicks(8057));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 29,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 391, DateTimeKind.Local).AddTicks(8059));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 30,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 391, DateTimeKind.Local).AddTicks(8062));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 31,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 391, DateTimeKind.Local).AddTicks(8064));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 32,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 391, DateTimeKind.Local).AddTicks(8067));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 33,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 391, DateTimeKind.Local).AddTicks(8069));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 34,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 391, DateTimeKind.Local).AddTicks(8073));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 35,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 391, DateTimeKind.Local).AddTicks(8076));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 36,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 391, DateTimeKind.Local).AddTicks(8078));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 37,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 391, DateTimeKind.Local).AddTicks(8081));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 38,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 391, DateTimeKind.Local).AddTicks(8083));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 39,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 391, DateTimeKind.Local).AddTicks(8085));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 40,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 391, DateTimeKind.Local).AddTicks(8088));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 41,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 391, DateTimeKind.Local).AddTicks(8090));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 42,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 391, DateTimeKind.Local).AddTicks(8092));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 43,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 391, DateTimeKind.Local).AddTicks(8094));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 44,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 391, DateTimeKind.Local).AddTicks(8097));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 45,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 391, DateTimeKind.Local).AddTicks(8099));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 46,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 391, DateTimeKind.Local).AddTicks(8101));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 47,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 391, DateTimeKind.Local).AddTicks(8104));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 48,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 391, DateTimeKind.Local).AddTicks(8106));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 49,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 391, DateTimeKind.Local).AddTicks(8108));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 50,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 391, DateTimeKind.Local).AddTicks(8111));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 51,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 391, DateTimeKind.Local).AddTicks(8113));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 52,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 391, DateTimeKind.Local).AddTicks(8115));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 53,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 391, DateTimeKind.Local).AddTicks(8118));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 54,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 391, DateTimeKind.Local).AddTicks(8184));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 55,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 391, DateTimeKind.Local).AddTicks(8187));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 56,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 391, DateTimeKind.Local).AddTicks(8189));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 57,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 391, DateTimeKind.Local).AddTicks(8191));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 58,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 391, DateTimeKind.Local).AddTicks(8194));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 59,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 391, DateTimeKind.Local).AddTicks(8196));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 60,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 391, DateTimeKind.Local).AddTicks(8198));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 61,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 391, DateTimeKind.Local).AddTicks(8201));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 62,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 391, DateTimeKind.Local).AddTicks(8203));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 63,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 391, DateTimeKind.Local).AddTicks(8205));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 64,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 391, DateTimeKind.Local).AddTicks(8208));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 65,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 391, DateTimeKind.Local).AddTicks(8210));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 66,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 391, DateTimeKind.Local).AddTicks(8215));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 67,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 391, DateTimeKind.Local).AddTicks(8218));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 68,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 391, DateTimeKind.Local).AddTicks(8220));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 69,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 391, DateTimeKind.Local).AddTicks(8222));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 70,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 391, DateTimeKind.Local).AddTicks(8225));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 71,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 391, DateTimeKind.Local).AddTicks(8227));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 72,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 391, DateTimeKind.Local).AddTicks(8230));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 73,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 391, DateTimeKind.Local).AddTicks(8232));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 74,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 391, DateTimeKind.Local).AddTicks(8234));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 75,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 391, DateTimeKind.Local).AddTicks(8237));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 76,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 391, DateTimeKind.Local).AddTicks(8239));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 77,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 391, DateTimeKind.Local).AddTicks(8242));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 78,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 391, DateTimeKind.Local).AddTicks(8244));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 79,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 391, DateTimeKind.Local).AddTicks(8246));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 80,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 391, DateTimeKind.Local).AddTicks(8248));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 81,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 391, DateTimeKind.Local).AddTicks(8251));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 82,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 391, DateTimeKind.Local).AddTicks(8253));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 83,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 391, DateTimeKind.Local).AddTicks(8256));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 84,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 391, DateTimeKind.Local).AddTicks(8258));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 85,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 391, DateTimeKind.Local).AddTicks(8260));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 86,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 391, DateTimeKind.Local).AddTicks(8262));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 87,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 391, DateTimeKind.Local).AddTicks(8265));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 88,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 391, DateTimeKind.Local).AddTicks(8267));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 89,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 391, DateTimeKind.Local).AddTicks(8269));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 90,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 391, DateTimeKind.Local).AddTicks(8272));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 91,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 391, DateTimeKind.Local).AddTicks(8274));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 92,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 391, DateTimeKind.Local).AddTicks(8276));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 93,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 391, DateTimeKind.Local).AddTicks(8278));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 94,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 391, DateTimeKind.Local).AddTicks(8281));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 95,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 391, DateTimeKind.Local).AddTicks(8283));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 96,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 391, DateTimeKind.Local).AddTicks(8285));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 97,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 391, DateTimeKind.Local).AddTicks(8288));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 98,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 391, DateTimeKind.Local).AddTicks(8290));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 99,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 391, DateTimeKind.Local).AddTicks(8292));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 100,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 391, DateTimeKind.Local).AddTicks(8294));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 101,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 391, DateTimeKind.Local).AddTicks(8297));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 102,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 391, DateTimeKind.Local).AddTicks(8299));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 103,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 391, DateTimeKind.Local).AddTicks(8301));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 104,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 391, DateTimeKind.Local).AddTicks(8304));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 105,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 391, DateTimeKind.Local).AddTicks(8306));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 106,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 391, DateTimeKind.Local).AddTicks(8308));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 107,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 391, DateTimeKind.Local).AddTicks(8311));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 108,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 391, DateTimeKind.Local).AddTicks(8313));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 109,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 391, DateTimeKind.Local).AddTicks(8315));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 110,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 391, DateTimeKind.Local).AddTicks(8318));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 111,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 391, DateTimeKind.Local).AddTicks(8320));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 112,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 391, DateTimeKind.Local).AddTicks(8322));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 113,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 391, DateTimeKind.Local).AddTicks(8325));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 114,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 391, DateTimeKind.Local).AddTicks(8327));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 115,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 391, DateTimeKind.Local).AddTicks(8329));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 116,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 391, DateTimeKind.Local).AddTicks(8332));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 117,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 391, DateTimeKind.Local).AddTicks(8334));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 118,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 391, DateTimeKind.Local).AddTicks(8336));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 119,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 391, DateTimeKind.Local).AddTicks(8339));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 120,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 391, DateTimeKind.Local).AddTicks(8341));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 121,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 391, DateTimeKind.Local).AddTicks(8343));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 122,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 391, DateTimeKind.Local).AddTicks(8346));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 123,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 391, DateTimeKind.Local).AddTicks(8348));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 124,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 391, DateTimeKind.Local).AddTicks(8350));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 125,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 391, DateTimeKind.Local).AddTicks(8353));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 126,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 391, DateTimeKind.Local).AddTicks(8355));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 127,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 391, DateTimeKind.Local).AddTicks(8358));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 128,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 391, DateTimeKind.Local).AddTicks(8361));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 129,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 391, DateTimeKind.Local).AddTicks(8364));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 130,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 391, DateTimeKind.Local).AddTicks(8371));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 131,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 391, DateTimeKind.Local).AddTicks(8375));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 132,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 391, DateTimeKind.Local).AddTicks(8378));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 133,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 391, DateTimeKind.Local).AddTicks(8481));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 134,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 391, DateTimeKind.Local).AddTicks(8483));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 135,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 391, DateTimeKind.Local).AddTicks(8486));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 382, DateTimeKind.Local).AddTicks(5104));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 384, DateTimeKind.Local).AddTicks(5114));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 384, DateTimeKind.Local).AddTicks(5205));

            migrationBuilder.UpdateData(
                table: "StatementLists",
                keyColumn: "StatementID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 462, DateTimeKind.Local).AddTicks(5421));

            migrationBuilder.UpdateData(
                table: "StatementLists",
                keyColumn: "StatementID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 462, DateTimeKind.Local).AddTicks(6029));

            migrationBuilder.UpdateData(
                table: "SystemVariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 416, DateTimeKind.Local).AddTicks(1668));

            migrationBuilder.UpdateData(
                table: "SystemVariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 416, DateTimeKind.Local).AddTicks(1825));

            migrationBuilder.UpdateData(
                table: "SystemVariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 416, DateTimeKind.Local).AddTicks(1821));

            migrationBuilder.UpdateData(
                table: "SystemVariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 416, DateTimeKind.Local).AddTicks(1817));

            migrationBuilder.UpdateData(
                table: "SystemVariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 416, DateTimeKind.Local).AddTicks(1811));

            migrationBuilder.UpdateData(
                table: "SystemVariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 416, DateTimeKind.Local).AddTicks(1836));

            migrationBuilder.UpdateData(
                table: "SystemVariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 416, DateTimeKind.Local).AddTicks(1847));

            migrationBuilder.UpdateData(
                table: "SystemVariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 416, DateTimeKind.Local).AddTicks(1852));

            migrationBuilder.UpdateData(
                table: "SystemVariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 416, DateTimeKind.Local).AddTicks(1856));

            migrationBuilder.UpdateData(
                table: "Titles",
                keyColumn: "TitleID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 466, DateTimeKind.Local).AddTicks(3474));

            migrationBuilder.UpdateData(
                table: "Titles",
                keyColumn: "TitleID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 466, DateTimeKind.Local).AddTicks(4426));

            migrationBuilder.UpdateData(
                table: "Titles",
                keyColumn: "TitleID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 466, DateTimeKind.Local).AddTicks(4473));

            migrationBuilder.UpdateData(
                table: "Titles",
                keyColumn: "TitleID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 466, DateTimeKind.Local).AddTicks(4546));

            migrationBuilder.UpdateData(
                table: "Titles",
                keyColumn: "TitleID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 466, DateTimeKind.Local).AddTicks(4557));

            migrationBuilder.UpdateData(
                table: "Titles",
                keyColumn: "TitleID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 466, DateTimeKind.Local).AddTicks(4581));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 398, DateTimeKind.Local).AddTicks(6101));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 398, DateTimeKind.Local).AddTicks(7055));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 398, DateTimeKind.Local).AddTicks(7150));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 398, DateTimeKind.Local).AddTicks(7233));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 398, DateTimeKind.Local).AddTicks(7319));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 398, DateTimeKind.Local).AddTicks(7399));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 398, DateTimeKind.Local).AddTicks(7467));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 398, DateTimeKind.Local).AddTicks(7532));

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumns: new[] { "UserID", "RoleID" },
                keyValues: new object[] { 1, 1 },
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 436, DateTimeKind.Local).AddTicks(6637));

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumns: new[] { "UserID", "RoleID" },
                keyValues: new object[] { 2, 3 },
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 436, DateTimeKind.Local).AddTicks(6773));

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "UserTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 411, DateTimeKind.Local).AddTicks(8456));

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "UserTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 411, DateTimeKind.Local).AddTicks(8990));

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "UserTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 411, DateTimeKind.Local).AddTicks(8998));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 423, DateTimeKind.Local).AddTicks(6445));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 427, DateTimeKind.Local).AddTicks(215));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 15, 44, 2, 427, DateTimeKind.Local).AddTicks(540));
        }
    }
}
