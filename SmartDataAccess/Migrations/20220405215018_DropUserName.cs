using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SmartDataAccess.Migrations
{
    public partial class DropUserName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UserName",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "UserName",
                table: "Clients");

            migrationBuilder.UpdateData(
                table: "BankAccountTypes",
                keyColumn: "BankAccountTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 438, DateTimeKind.Local).AddTicks(428));

            migrationBuilder.UpdateData(
                table: "BankAccountTypes",
                keyColumn: "BankAccountTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 438, DateTimeKind.Local).AddTicks(626));

            migrationBuilder.UpdateData(
                table: "BankAccountTypes",
                keyColumn: "BankAccountTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 438, DateTimeKind.Local).AddTicks(634));

            migrationBuilder.UpdateData(
                table: "BankAccountTypes",
                keyColumn: "BankAccountTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 438, DateTimeKind.Local).AddTicks(637));

            migrationBuilder.UpdateData(
                table: "ClientAccountTypes",
                keyColumn: "ID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 465, DateTimeKind.Local).AddTicks(7656));

            migrationBuilder.UpdateData(
                table: "ClientAccountTypes",
                keyColumn: "ID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 465, DateTimeKind.Local).AddTicks(7980));

            migrationBuilder.UpdateData(
                table: "ClientGroups",
                keyColumn: "ClientGroupID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 468, DateTimeKind.Local).AddTicks(794));

            migrationBuilder.UpdateData(
                table: "ClientGroups",
                keyColumn: "ClientGroupID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 468, DateTimeKind.Local).AddTicks(956));

            migrationBuilder.UpdateData(
                table: "ContactTypes",
                keyColumn: "ContactTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 443, DateTimeKind.Local).AddTicks(978));

            migrationBuilder.UpdateData(
                table: "ContactTypes",
                keyColumn: "ContactTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 443, DateTimeKind.Local).AddTicks(973));

            migrationBuilder.UpdateData(
                table: "ContactTypes",
                keyColumn: "ContactTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 443, DateTimeKind.Local).AddTicks(968));

            migrationBuilder.UpdateData(
                table: "ContactTypes",
                keyColumn: "ContactTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 443, DateTimeKind.Local).AddTicks(892));

            migrationBuilder.UpdateData(
                table: "ContactTypes",
                keyColumn: "ContactTypeID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 443, DateTimeKind.Local).AddTicks(982));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 446, DateTimeKind.Local).AddTicks(5242));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 446, DateTimeKind.Local).AddTicks(5453));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 446, DateTimeKind.Local).AddTicks(5460));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 446, DateTimeKind.Local).AddTicks(5466));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 446, DateTimeKind.Local).AddTicks(5469));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 446, DateTimeKind.Local).AddTicks(5475));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 446, DateTimeKind.Local).AddTicks(5478));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 446, DateTimeKind.Local).AddTicks(5482));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 446, DateTimeKind.Local).AddTicks(5486));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 446, DateTimeKind.Local).AddTicks(5490));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 446, DateTimeKind.Local).AddTicks(5493));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 446, DateTimeKind.Local).AddTicks(5496));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 13,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 446, DateTimeKind.Local).AddTicks(5499));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 14,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 446, DateTimeKind.Local).AddTicks(5502));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 15,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 446, DateTimeKind.Local).AddTicks(5505));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 16,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 446, DateTimeKind.Local).AddTicks(5509));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 17,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 446, DateTimeKind.Local).AddTicks(5512));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 18,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 446, DateTimeKind.Local).AddTicks(5516));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 19,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 446, DateTimeKind.Local).AddTicks(5519));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 20,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 446, DateTimeKind.Local).AddTicks(5522));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 21,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 446, DateTimeKind.Local).AddTicks(5525));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 22,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 446, DateTimeKind.Local).AddTicks(5528));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 23,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 446, DateTimeKind.Local).AddTicks(5531));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 24,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 446, DateTimeKind.Local).AddTicks(5533));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 25,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 446, DateTimeKind.Local).AddTicks(5536));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 26,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 446, DateTimeKind.Local).AddTicks(5539));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 27,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 446, DateTimeKind.Local).AddTicks(5557));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 28,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 446, DateTimeKind.Local).AddTicks(5560));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 29,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 446, DateTimeKind.Local).AddTicks(5563));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 30,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 446, DateTimeKind.Local).AddTicks(5567));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 31,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 446, DateTimeKind.Local).AddTicks(5570));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 32,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 446, DateTimeKind.Local).AddTicks(5573));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 33,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 446, DateTimeKind.Local).AddTicks(5576));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 34,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 446, DateTimeKind.Local).AddTicks(5772));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 35,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 446, DateTimeKind.Local).AddTicks(5775));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 36,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 446, DateTimeKind.Local).AddTicks(5779));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 37,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 446, DateTimeKind.Local).AddTicks(5782));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 38,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 446, DateTimeKind.Local).AddTicks(5785));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 39,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 446, DateTimeKind.Local).AddTicks(5788));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 40,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 446, DateTimeKind.Local).AddTicks(5792));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 41,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 446, DateTimeKind.Local).AddTicks(5795));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 42,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 446, DateTimeKind.Local).AddTicks(5798));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 43,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 446, DateTimeKind.Local).AddTicks(5801));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 44,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 446, DateTimeKind.Local).AddTicks(5804));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 45,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 446, DateTimeKind.Local).AddTicks(5807));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 46,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 446, DateTimeKind.Local).AddTicks(5810));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 47,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 446, DateTimeKind.Local).AddTicks(5814));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 48,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 446, DateTimeKind.Local).AddTicks(5818));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 49,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 446, DateTimeKind.Local).AddTicks(5821));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 50,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 446, DateTimeKind.Local).AddTicks(5825));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 51,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 446, DateTimeKind.Local).AddTicks(5828));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 52,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 446, DateTimeKind.Local).AddTicks(5831));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 53,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 446, DateTimeKind.Local).AddTicks(5834));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 54,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 446, DateTimeKind.Local).AddTicks(5837));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 55,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 446, DateTimeKind.Local).AddTicks(5841));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 56,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 446, DateTimeKind.Local).AddTicks(5844));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 57,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 446, DateTimeKind.Local).AddTicks(5847));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 58,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 446, DateTimeKind.Local).AddTicks(5850));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 59,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 446, DateTimeKind.Local).AddTicks(5854));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 60,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 446, DateTimeKind.Local).AddTicks(5857));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 61,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 446, DateTimeKind.Local).AddTicks(5860));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 62,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 446, DateTimeKind.Local).AddTicks(5864));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 63,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 446, DateTimeKind.Local).AddTicks(5868));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 64,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 446, DateTimeKind.Local).AddTicks(5871));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 65,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 446, DateTimeKind.Local).AddTicks(5875));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 66,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 446, DateTimeKind.Local).AddTicks(5879));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 67,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 446, DateTimeKind.Local).AddTicks(5882));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 68,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 446, DateTimeKind.Local).AddTicks(5885));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 69,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 446, DateTimeKind.Local).AddTicks(5901));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 70,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 446, DateTimeKind.Local).AddTicks(5904));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 71,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 446, DateTimeKind.Local).AddTicks(5907));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 72,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 446, DateTimeKind.Local).AddTicks(5911));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 73,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 446, DateTimeKind.Local).AddTicks(5915));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 74,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 446, DateTimeKind.Local).AddTicks(5918));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 75,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 446, DateTimeKind.Local).AddTicks(5922));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 76,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 446, DateTimeKind.Local).AddTicks(5925));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 77,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 446, DateTimeKind.Local).AddTicks(5928));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 78,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 446, DateTimeKind.Local).AddTicks(5931));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 79,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 446, DateTimeKind.Local).AddTicks(5934));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 80,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 446, DateTimeKind.Local).AddTicks(5937));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 81,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 446, DateTimeKind.Local).AddTicks(5940));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 82,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 446, DateTimeKind.Local).AddTicks(5943));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 83,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 446, DateTimeKind.Local).AddTicks(5946));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 84,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 446, DateTimeKind.Local).AddTicks(5949));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 85,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 446, DateTimeKind.Local).AddTicks(5952));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 86,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 446, DateTimeKind.Local).AddTicks(5955));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 87,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 446, DateTimeKind.Local).AddTicks(5958));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 88,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 446, DateTimeKind.Local).AddTicks(5961));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 89,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 446, DateTimeKind.Local).AddTicks(5964));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 90,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 446, DateTimeKind.Local).AddTicks(5987));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 91,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 446, DateTimeKind.Local).AddTicks(5991));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 92,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 446, DateTimeKind.Local).AddTicks(5994));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 93,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 446, DateTimeKind.Local).AddTicks(5998));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 94,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 446, DateTimeKind.Local).AddTicks(6001));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 95,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 446, DateTimeKind.Local).AddTicks(6004));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 96,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 446, DateTimeKind.Local).AddTicks(6007));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 97,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 446, DateTimeKind.Local).AddTicks(6010));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 98,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 446, DateTimeKind.Local).AddTicks(6012));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 99,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 446, DateTimeKind.Local).AddTicks(6015));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 100,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 446, DateTimeKind.Local).AddTicks(6018));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 101,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 446, DateTimeKind.Local).AddTicks(6022));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 102,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 446, DateTimeKind.Local).AddTicks(6025));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 103,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 446, DateTimeKind.Local).AddTicks(6028));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 104,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 446, DateTimeKind.Local).AddTicks(6031));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 105,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 446, DateTimeKind.Local).AddTicks(6034));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 106,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 446, DateTimeKind.Local).AddTicks(6036));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 107,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 446, DateTimeKind.Local).AddTicks(6039));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 108,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 446, DateTimeKind.Local).AddTicks(6042));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 109,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 446, DateTimeKind.Local).AddTicks(6045));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 110,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 446, DateTimeKind.Local).AddTicks(6048));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 111,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 446, DateTimeKind.Local).AddTicks(6051));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 112,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 446, DateTimeKind.Local).AddTicks(6055));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 113,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 446, DateTimeKind.Local).AddTicks(6057));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 114,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 446, DateTimeKind.Local).AddTicks(6060));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 115,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 446, DateTimeKind.Local).AddTicks(6064));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 116,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 446, DateTimeKind.Local).AddTicks(6067));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 117,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 446, DateTimeKind.Local).AddTicks(6070));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 118,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 446, DateTimeKind.Local).AddTicks(6073));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 119,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 446, DateTimeKind.Local).AddTicks(6076));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 120,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 446, DateTimeKind.Local).AddTicks(6079));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 121,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 446, DateTimeKind.Local).AddTicks(6082));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 122,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 446, DateTimeKind.Local).AddTicks(6085));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 123,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 446, DateTimeKind.Local).AddTicks(6088));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 124,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 446, DateTimeKind.Local).AddTicks(6091));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 125,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 446, DateTimeKind.Local).AddTicks(6094));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 126,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 446, DateTimeKind.Local).AddTicks(6097));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 127,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 446, DateTimeKind.Local).AddTicks(6100));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 128,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 446, DateTimeKind.Local).AddTicks(6103));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 129,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 446, DateTimeKind.Local).AddTicks(6106));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 130,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 446, DateTimeKind.Local).AddTicks(6110));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 131,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 446, DateTimeKind.Local).AddTicks(6113));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 132,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 446, DateTimeKind.Local).AddTicks(6116));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 133,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 446, DateTimeKind.Local).AddTicks(6119));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 134,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 446, DateTimeKind.Local).AddTicks(6122));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 135,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 446, DateTimeKind.Local).AddTicks(6125));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 136,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 446, DateTimeKind.Local).AddTicks(6128));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 137,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 446, DateTimeKind.Local).AddTicks(6131));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 138,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 446, DateTimeKind.Local).AddTicks(6134));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 139,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 446, DateTimeKind.Local).AddTicks(6137));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 140,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 446, DateTimeKind.Local).AddTicks(6140));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 141,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 446, DateTimeKind.Local).AddTicks(6143));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 142,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 446, DateTimeKind.Local).AddTicks(6146));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 143,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 446, DateTimeKind.Local).AddTicks(6149));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 144,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 446, DateTimeKind.Local).AddTicks(6152));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 145,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 446, DateTimeKind.Local).AddTicks(6155));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 146,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 446, DateTimeKind.Local).AddTicks(6178));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 147,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 446, DateTimeKind.Local).AddTicks(6182));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 148,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 446, DateTimeKind.Local).AddTicks(6185));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 149,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 446, DateTimeKind.Local).AddTicks(6189));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 150,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 446, DateTimeKind.Local).AddTicks(6193));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 151,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 446, DateTimeKind.Local).AddTicks(6196));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 152,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 446, DateTimeKind.Local).AddTicks(6199));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 153,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 446, DateTimeKind.Local).AddTicks(6202));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 154,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 446, DateTimeKind.Local).AddTicks(6205));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 155,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 446, DateTimeKind.Local).AddTicks(6209));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 156,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 446, DateTimeKind.Local).AddTicks(6212));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 157,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 446, DateTimeKind.Local).AddTicks(6215));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 158,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 446, DateTimeKind.Local).AddTicks(6218));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 159,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 446, DateTimeKind.Local).AddTicks(6221));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 160,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 446, DateTimeKind.Local).AddTicks(6224));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 161,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 446, DateTimeKind.Local).AddTicks(6228));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 162,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 446, DateTimeKind.Local).AddTicks(6231));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 163,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 446, DateTimeKind.Local).AddTicks(6234));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 164,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 446, DateTimeKind.Local).AddTicks(6237));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 165,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 446, DateTimeKind.Local).AddTicks(6240));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 166,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 446, DateTimeKind.Local).AddTicks(6243));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 167,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 446, DateTimeKind.Local).AddTicks(6246));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 168,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 446, DateTimeKind.Local).AddTicks(6249));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 169,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 446, DateTimeKind.Local).AddTicks(6252));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 170,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 446, DateTimeKind.Local).AddTicks(6255));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 171,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 446, DateTimeKind.Local).AddTicks(6257));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 172,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 446, DateTimeKind.Local).AddTicks(6261));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 173,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 446, DateTimeKind.Local).AddTicks(6264));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 174,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 446, DateTimeKind.Local).AddTicks(6268));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 175,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 446, DateTimeKind.Local).AddTicks(6271));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 176,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 446, DateTimeKind.Local).AddTicks(6275));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 177,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 446, DateTimeKind.Local).AddTicks(6279));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 178,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 446, DateTimeKind.Local).AddTicks(6282));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 179,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 446, DateTimeKind.Local).AddTicks(6285));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 180,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 446, DateTimeKind.Local).AddTicks(6289));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 181,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 446, DateTimeKind.Local).AddTicks(6292));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 182,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 446, DateTimeKind.Local).AddTicks(6295));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 183,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 446, DateTimeKind.Local).AddTicks(6298));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 184,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 446, DateTimeKind.Local).AddTicks(6301));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 185,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 446, DateTimeKind.Local).AddTicks(6304));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 186,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 446, DateTimeKind.Local).AddTicks(6308));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 187,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 446, DateTimeKind.Local).AddTicks(6311));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 188,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 446, DateTimeKind.Local).AddTicks(6313));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 189,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 446, DateTimeKind.Local).AddTicks(6317));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 190,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 446, DateTimeKind.Local).AddTicks(6320));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 191,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 446, DateTimeKind.Local).AddTicks(6323));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 192,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 446, DateTimeKind.Local).AddTicks(6326));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 193,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 446, DateTimeKind.Local).AddTicks(6330));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 194,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 446, DateTimeKind.Local).AddTicks(6333));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 195,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 446, DateTimeKind.Local).AddTicks(6336));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 196,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 446, DateTimeKind.Local).AddTicks(6339));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 197,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 446, DateTimeKind.Local).AddTicks(6342));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 198,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 446, DateTimeKind.Local).AddTicks(6345));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 199,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 446, DateTimeKind.Local).AddTicks(6348));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 200,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 446, DateTimeKind.Local).AddTicks(6351));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 201,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 446, DateTimeKind.Local).AddTicks(6354));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 202,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 446, DateTimeKind.Local).AddTicks(6357));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 203,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 446, DateTimeKind.Local).AddTicks(6360));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 204,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 446, DateTimeKind.Local).AddTicks(6363));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 205,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 446, DateTimeKind.Local).AddTicks(6366));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 206,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 446, DateTimeKind.Local).AddTicks(6369));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 207,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 446, DateTimeKind.Local).AddTicks(6372));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 208,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 446, DateTimeKind.Local).AddTicks(6375));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 209,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 446, DateTimeKind.Local).AddTicks(6378));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 210,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 446, DateTimeKind.Local).AddTicks(6382));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 211,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 446, DateTimeKind.Local).AddTicks(6385));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 212,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 446, DateTimeKind.Local).AddTicks(6387));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 213,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 446, DateTimeKind.Local).AddTicks(6390));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 214,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 446, DateTimeKind.Local).AddTicks(6413));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 215,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 446, DateTimeKind.Local).AddTicks(6417));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 216,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 446, DateTimeKind.Local).AddTicks(6421));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 217,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 446, DateTimeKind.Local).AddTicks(6424));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 218,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 446, DateTimeKind.Local).AddTicks(6427));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 219,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 446, DateTimeKind.Local).AddTicks(6430));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 220,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 446, DateTimeKind.Local).AddTicks(6433));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 221,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 446, DateTimeKind.Local).AddTicks(6436));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 222,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 446, DateTimeKind.Local).AddTicks(6439));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 223,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 446, DateTimeKind.Local).AddTicks(6442));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 224,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 446, DateTimeKind.Local).AddTicks(6446));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 225,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 446, DateTimeKind.Local).AddTicks(6449));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 226,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 446, DateTimeKind.Local).AddTicks(6452));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 227,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 446, DateTimeKind.Local).AddTicks(6455));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 228,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 446, DateTimeKind.Local).AddTicks(6458));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 439, DateTimeKind.Local).AddTicks(5679));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 439, DateTimeKind.Local).AddTicks(5926));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 439, DateTimeKind.Local).AddTicks(5935));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 439, DateTimeKind.Local).AddTicks(5939));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 439, DateTimeKind.Local).AddTicks(5944));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 439, DateTimeKind.Local).AddTicks(5952));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 439, DateTimeKind.Local).AddTicks(5956));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 439, DateTimeKind.Local).AddTicks(5961));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 439, DateTimeKind.Local).AddTicks(5965));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 439, DateTimeKind.Local).AddTicks(5970));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 439, DateTimeKind.Local).AddTicks(5975));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 439, DateTimeKind.Local).AddTicks(5980));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 13,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 439, DateTimeKind.Local).AddTicks(5984));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 14,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 439, DateTimeKind.Local).AddTicks(5988));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 15,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 439, DateTimeKind.Local).AddTicks(5992));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 16,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 439, DateTimeKind.Local).AddTicks(5996));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 17,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 439, DateTimeKind.Local).AddTicks(6000));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 18,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 439, DateTimeKind.Local).AddTicks(6006));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 19,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 439, DateTimeKind.Local).AddTicks(6010));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 20,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 439, DateTimeKind.Local).AddTicks(6014));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 21,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 439, DateTimeKind.Local).AddTicks(6018));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 22,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 439, DateTimeKind.Local).AddTicks(6022));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 23,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 439, DateTimeKind.Local).AddTicks(6027));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 24,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 439, DateTimeKind.Local).AddTicks(6031));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 25,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 439, DateTimeKind.Local).AddTicks(6035));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 26,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 439, DateTimeKind.Local).AddTicks(6039));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 27,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 439, DateTimeKind.Local).AddTicks(6043));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 28,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 439, DateTimeKind.Local).AddTicks(6047));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 29,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 439, DateTimeKind.Local).AddTicks(6051));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 30,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 439, DateTimeKind.Local).AddTicks(6055));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 31,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 439, DateTimeKind.Local).AddTicks(6059));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 32,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 439, DateTimeKind.Local).AddTicks(6063));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 33,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 439, DateTimeKind.Local).AddTicks(6067));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 34,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 439, DateTimeKind.Local).AddTicks(6073));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 35,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 439, DateTimeKind.Local).AddTicks(6077));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 36,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 439, DateTimeKind.Local).AddTicks(6081));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 37,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 439, DateTimeKind.Local).AddTicks(6085));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 38,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 439, DateTimeKind.Local).AddTicks(6089));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 39,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 439, DateTimeKind.Local).AddTicks(6093));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 40,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 439, DateTimeKind.Local).AddTicks(6098));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 41,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 439, DateTimeKind.Local).AddTicks(6102));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 42,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 439, DateTimeKind.Local).AddTicks(6107));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 43,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 439, DateTimeKind.Local).AddTicks(6113));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 44,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 439, DateTimeKind.Local).AddTicks(6117));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 45,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 439, DateTimeKind.Local).AddTicks(6123));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 46,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 439, DateTimeKind.Local).AddTicks(6127));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 47,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 439, DateTimeKind.Local).AddTicks(6131));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 48,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 439, DateTimeKind.Local).AddTicks(6135));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 49,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 439, DateTimeKind.Local).AddTicks(6139));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 50,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 439, DateTimeKind.Local).AddTicks(6143));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 51,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 439, DateTimeKind.Local).AddTicks(6147));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 52,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 439, DateTimeKind.Local).AddTicks(6151));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 53,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 439, DateTimeKind.Local).AddTicks(6156));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 54,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 439, DateTimeKind.Local).AddTicks(6160));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 55,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 439, DateTimeKind.Local).AddTicks(6163));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 56,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 439, DateTimeKind.Local).AddTicks(6168));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 57,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 439, DateTimeKind.Local).AddTicks(6202));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 58,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 439, DateTimeKind.Local).AddTicks(6207));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 59,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 439, DateTimeKind.Local).AddTicks(6211));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 60,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 439, DateTimeKind.Local).AddTicks(6215));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 61,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 439, DateTimeKind.Local).AddTicks(6220));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 62,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 439, DateTimeKind.Local).AddTicks(6223));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 63,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 439, DateTimeKind.Local).AddTicks(6227));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 64,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 439, DateTimeKind.Local).AddTicks(6231));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 65,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 439, DateTimeKind.Local).AddTicks(6235));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 66,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 439, DateTimeKind.Local).AddTicks(6241));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 67,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 439, DateTimeKind.Local).AddTicks(6245));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 68,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 439, DateTimeKind.Local).AddTicks(6249));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 69,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 439, DateTimeKind.Local).AddTicks(6253));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 70,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 439, DateTimeKind.Local).AddTicks(6257));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 71,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 439, DateTimeKind.Local).AddTicks(6262));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 72,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 439, DateTimeKind.Local).AddTicks(6266));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 73,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 439, DateTimeKind.Local).AddTicks(6270));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 74,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 439, DateTimeKind.Local).AddTicks(6274));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 75,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 439, DateTimeKind.Local).AddTicks(6278));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 76,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 439, DateTimeKind.Local).AddTicks(6282));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 77,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 439, DateTimeKind.Local).AddTicks(6286));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 78,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 439, DateTimeKind.Local).AddTicks(6290));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 79,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 439, DateTimeKind.Local).AddTicks(6327));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 80,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 439, DateTimeKind.Local).AddTicks(6331));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 81,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 439, DateTimeKind.Local).AddTicks(6335));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 82,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 439, DateTimeKind.Local).AddTicks(6340));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 83,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 439, DateTimeKind.Local).AddTicks(6344));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 84,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 439, DateTimeKind.Local).AddTicks(6348));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 85,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 439, DateTimeKind.Local).AddTicks(6352));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 86,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 439, DateTimeKind.Local).AddTicks(6356));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 87,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 439, DateTimeKind.Local).AddTicks(6360));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 88,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 439, DateTimeKind.Local).AddTicks(6364));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 89,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 439, DateTimeKind.Local).AddTicks(6368));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 90,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 439, DateTimeKind.Local).AddTicks(6372));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 91,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 439, DateTimeKind.Local).AddTicks(6376));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 92,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 439, DateTimeKind.Local).AddTicks(6380));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 93,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 439, DateTimeKind.Local).AddTicks(6384));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 94,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 439, DateTimeKind.Local).AddTicks(6388));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 95,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 439, DateTimeKind.Local).AddTicks(6392));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 96,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 439, DateTimeKind.Local).AddTicks(6396));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 97,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 439, DateTimeKind.Local).AddTicks(6400));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 98,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 439, DateTimeKind.Local).AddTicks(6404));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 99,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 439, DateTimeKind.Local).AddTicks(6408));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 100,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 439, DateTimeKind.Local).AddTicks(6412));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 101,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 439, DateTimeKind.Local).AddTicks(6416));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 102,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 439, DateTimeKind.Local).AddTicks(6421));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 103,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 439, DateTimeKind.Local).AddTicks(6425));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 104,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 439, DateTimeKind.Local).AddTicks(6429));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 105,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 439, DateTimeKind.Local).AddTicks(6433));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 106,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 439, DateTimeKind.Local).AddTicks(6437));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 107,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 439, DateTimeKind.Local).AddTicks(6441));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 108,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 439, DateTimeKind.Local).AddTicks(6445));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 109,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 439, DateTimeKind.Local).AddTicks(6449));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 110,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 439, DateTimeKind.Local).AddTicks(6453));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 111,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 439, DateTimeKind.Local).AddTicks(6457));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 112,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 439, DateTimeKind.Local).AddTicks(6461));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 113,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 439, DateTimeKind.Local).AddTicks(6465));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 114,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 439, DateTimeKind.Local).AddTicks(6470));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 115,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 439, DateTimeKind.Local).AddTicks(6474));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 116,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 439, DateTimeKind.Local).AddTicks(6477));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 117,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 439, DateTimeKind.Local).AddTicks(6482));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 118,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 439, DateTimeKind.Local).AddTicks(6486));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 119,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 439, DateTimeKind.Local).AddTicks(6490));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 120,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 439, DateTimeKind.Local).AddTicks(6494));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 121,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 439, DateTimeKind.Local).AddTicks(6498));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 122,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 439, DateTimeKind.Local).AddTicks(6502));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 123,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 439, DateTimeKind.Local).AddTicks(6506));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 124,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 439, DateTimeKind.Local).AddTicks(6510));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 125,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 439, DateTimeKind.Local).AddTicks(6537));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 126,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 439, DateTimeKind.Local).AddTicks(6542));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 127,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 439, DateTimeKind.Local).AddTicks(6546));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 128,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 439, DateTimeKind.Local).AddTicks(6550));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 129,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 439, DateTimeKind.Local).AddTicks(6554));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 130,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 439, DateTimeKind.Local).AddTicks(6560));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 131,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 439, DateTimeKind.Local).AddTicks(6564));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 132,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 439, DateTimeKind.Local).AddTicks(6568));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 133,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 439, DateTimeKind.Local).AddTicks(6573));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 134,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 439, DateTimeKind.Local).AddTicks(6577));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 135,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 439, DateTimeKind.Local).AddTicks(6581));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 136,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 439, DateTimeKind.Local).AddTicks(6586));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 137,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 439, DateTimeKind.Local).AddTicks(6590));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 138,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 439, DateTimeKind.Local).AddTicks(6594));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 139,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 439, DateTimeKind.Local).AddTicks(6598));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 140,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 439, DateTimeKind.Local).AddTicks(6602));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 141,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 439, DateTimeKind.Local).AddTicks(6606));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 142,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 439, DateTimeKind.Local).AddTicks(6610));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 143,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 439, DateTimeKind.Local).AddTicks(6614));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 144,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 439, DateTimeKind.Local).AddTicks(6618));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 145,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 439, DateTimeKind.Local).AddTicks(6622));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 146,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 439, DateTimeKind.Local).AddTicks(6627));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 147,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 439, DateTimeKind.Local).AddTicks(6631));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 148,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 439, DateTimeKind.Local).AddTicks(6635));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 149,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 439, DateTimeKind.Local).AddTicks(6639));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 150,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 439, DateTimeKind.Local).AddTicks(6643));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 151,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 439, DateTimeKind.Local).AddTicks(6647));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 152,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 439, DateTimeKind.Local).AddTicks(6651));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 153,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 439, DateTimeKind.Local).AddTicks(6655));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 154,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 439, DateTimeKind.Local).AddTicks(6659));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 155,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 439, DateTimeKind.Local).AddTicks(6663));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 156,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 439, DateTimeKind.Local).AddTicks(6667));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 157,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 439, DateTimeKind.Local).AddTicks(6671));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 158,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 439, DateTimeKind.Local).AddTicks(6675));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 159,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 439, DateTimeKind.Local).AddTicks(6679));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 160,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 439, DateTimeKind.Local).AddTicks(6683));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 161,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 439, DateTimeKind.Local).AddTicks(6687));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 162,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 439, DateTimeKind.Local).AddTicks(6691));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 459, DateTimeKind.Local).AddTicks(5914));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 459, DateTimeKind.Local).AddTicks(6060));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 459, DateTimeKind.Local).AddTicks(6083));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 459, DateTimeKind.Local).AddTicks(6065));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 459, DateTimeKind.Local).AddTicks(6090));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 459, DateTimeKind.Local).AddTicks(6103));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 459, DateTimeKind.Local).AddTicks(6111));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 459, DateTimeKind.Local).AddTicks(6117));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 459, DateTimeKind.Local).AddTicks(6124));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 459, DateTimeKind.Local).AddTicks(6129));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 459, DateTimeKind.Local).AddTicks(6171));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 459, DateTimeKind.Local).AddTicks(6178));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 13,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 459, DateTimeKind.Local).AddTicks(6184));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 14,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 459, DateTimeKind.Local).AddTicks(6191));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 15,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 459, DateTimeKind.Local).AddTicks(6072));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 16,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 459, DateTimeKind.Local).AddTicks(6053));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 17,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 459, DateTimeKind.Local).AddTicks(6198));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 18,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 459, DateTimeKind.Local).AddTicks(6204));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 19,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 459, DateTimeKind.Local).AddTicks(6210));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 20,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 459, DateTimeKind.Local).AddTicks(6215));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 22,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 459, DateTimeKind.Local).AddTicks(6238));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 23,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 459, DateTimeKind.Local).AddTicks(6226));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 24,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 459, DateTimeKind.Local).AddTicks(6221));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 25,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 459, DateTimeKind.Local).AddTicks(6232));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 26,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 459, DateTimeKind.Local).AddTicks(6244));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 27,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 459, DateTimeKind.Local).AddTicks(6375));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 28,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 459, DateTimeKind.Local).AddTicks(6382));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 30,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 459, DateTimeKind.Local).AddTicks(6387));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 31,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 459, DateTimeKind.Local).AddTicks(6393));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 32,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 459, DateTimeKind.Local).AddTicks(6398));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 33,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 459, DateTimeKind.Local).AddTicks(6403));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 34,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 459, DateTimeKind.Local).AddTicks(6409));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 36,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 459, DateTimeKind.Local).AddTicks(6416));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 37,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 459, DateTimeKind.Local).AddTicks(6422));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 38,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 459, DateTimeKind.Local).AddTicks(6428));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 39,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 459, DateTimeKind.Local).AddTicks(6097));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 40,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 459, DateTimeKind.Local).AddTicks(6434));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 41,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 459, DateTimeKind.Local).AddTicks(6439));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 42,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 459, DateTimeKind.Local).AddTicks(6443));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 43,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 459, DateTimeKind.Local).AddTicks(6448));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 44,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 459, DateTimeKind.Local).AddTicks(6453));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 45,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 459, DateTimeKind.Local).AddTicks(6459));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 46,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 459, DateTimeKind.Local).AddTicks(6464));

            migrationBuilder.UpdateData(
                table: "DeductionTypes",
                keyColumn: "DeductionTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 473, DateTimeKind.Local).AddTicks(2123));

            migrationBuilder.UpdateData(
                table: "DeductionTypes",
                keyColumn: "DeductionTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 473, DateTimeKind.Local).AddTicks(2289));

            migrationBuilder.UpdateData(
                table: "DeductionTypes",
                keyColumn: "DeductionTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 473, DateTimeKind.Local).AddTicks(2298));

            migrationBuilder.UpdateData(
                table: "DocumentFormats",
                keyColumn: "DocumentFormatID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 450, DateTimeKind.Local).AddTicks(6074));

            migrationBuilder.UpdateData(
                table: "DocumentFormats",
                keyColumn: "DocumentFormatID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 450, DateTimeKind.Local).AddTicks(6498));

            migrationBuilder.UpdateData(
                table: "DocumentFormats",
                keyColumn: "DocumentFormatID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 450, DateTimeKind.Local).AddTicks(6508));

            migrationBuilder.UpdateData(
                table: "DocumentFormats",
                keyColumn: "DocumentFormatID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 450, DateTimeKind.Local).AddTicks(6511));

            migrationBuilder.UpdateData(
                table: "DocumentFormats",
                keyColumn: "DocumentFormatID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 450, DateTimeKind.Local).AddTicks(6514));

            migrationBuilder.UpdateData(
                table: "DocumentFormats",
                keyColumn: "DocumentFormatID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 450, DateTimeKind.Local).AddTicks(6519));

            migrationBuilder.UpdateData(
                table: "DocumentTypes",
                keyColumn: "DocumentTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 451, DateTimeKind.Local).AddTicks(7636));

            migrationBuilder.UpdateData(
                table: "DocumentTypes",
                keyColumn: "DocumentTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 451, DateTimeKind.Local).AddTicks(9597));

            migrationBuilder.UpdateData(
                table: "DocumentTypes",
                keyColumn: "DocumentTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 451, DateTimeKind.Local).AddTicks(9616));

            migrationBuilder.UpdateData(
                table: "DocumentTypes",
                keyColumn: "DocumentTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 451, DateTimeKind.Local).AddTicks(9620));

            migrationBuilder.UpdateData(
                table: "EmailTemplates",
                keyColumn: "EmailTemplateID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 457, DateTimeKind.Local).AddTicks(1838));

            migrationBuilder.UpdateData(
                table: "EmailTypes",
                keyColumn: "EmailTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 456, DateTimeKind.Local).AddTicks(9274));

            migrationBuilder.UpdateData(
                table: "EmailTypes",
                keyColumn: "EmailTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 456, DateTimeKind.Local).AddTicks(9484));

            migrationBuilder.UpdateData(
                table: "EmailTypes",
                keyColumn: "EmailTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 456, DateTimeKind.Local).AddTicks(9493));

            migrationBuilder.UpdateData(
                table: "EmailTypes",
                keyColumn: "EmailTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 456, DateTimeKind.Local).AddTicks(9499));

            migrationBuilder.UpdateData(
                table: "FeatureFlags",
                keyColumn: "FeatureFlagID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 449, DateTimeKind.Local).AddTicks(4593));

            migrationBuilder.UpdateData(
                table: "FeatureFlags",
                keyColumn: "FeatureFlagID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 449, DateTimeKind.Local).AddTicks(4798));

            migrationBuilder.UpdateData(
                table: "FeatureFlags",
                keyColumn: "FeatureFlagID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 449, DateTimeKind.Local).AddTicks(4807));

            migrationBuilder.UpdateData(
                table: "Frequencies",
                keyColumn: "FrequencyID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 440, DateTimeKind.Local).AddTicks(9577));

            migrationBuilder.UpdateData(
                table: "Frequencies",
                keyColumn: "FrequencyID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 440, DateTimeKind.Local).AddTicks(9786));

            migrationBuilder.UpdateData(
                table: "FundSources",
                keyColumn: "FundSourceID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 475, DateTimeKind.Local).AddTicks(6786));

            migrationBuilder.UpdateData(
                table: "FundSources",
                keyColumn: "FundSourceID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 475, DateTimeKind.Local).AddTicks(6996));

            migrationBuilder.UpdateData(
                table: "FundSources",
                keyColumn: "FundSourceID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 475, DateTimeKind.Local).AddTicks(7007));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "GenderID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 445, DateTimeKind.Local).AddTicks(1465));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "GenderID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 445, DateTimeKind.Local).AddTicks(1533));

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "InvoiceStatusID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 469, DateTimeKind.Local).AddTicks(2749));

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "InvoiceStatusID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 469, DateTimeKind.Local).AddTicks(2933));

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "InvoiceStatusID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 469, DateTimeKind.Local).AddTicks(2941));

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "InvoiceStatusID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 469, DateTimeKind.Local).AddTicks(2944));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 472, DateTimeKind.Local).AddTicks(794));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 472, DateTimeKind.Local).AddTicks(924));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 472, DateTimeKind.Local).AddTicks(929));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 472, DateTimeKind.Local).AddTicks(932));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 472, DateTimeKind.Local).AddTicks(941));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 472, DateTimeKind.Local).AddTicks(947));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 472, DateTimeKind.Local).AddTicks(951));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 472, DateTimeKind.Local).AddTicks(954));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 472, DateTimeKind.Local).AddTicks(957));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 472, DateTimeKind.Local).AddTicks(961));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 472, DateTimeKind.Local).AddTicks(965));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 472, DateTimeKind.Local).AddTicks(968));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 13,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 472, DateTimeKind.Local).AddTicks(971));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 14,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 472, DateTimeKind.Local).AddTicks(975));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 15,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 472, DateTimeKind.Local).AddTicks(1110));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 16,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 472, DateTimeKind.Local).AddTicks(1123));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 17,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 472, DateTimeKind.Local).AddTicks(1126));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 18,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 472, DateTimeKind.Local).AddTicks(1132));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 19,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 472, DateTimeKind.Local).AddTicks(1135));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 20,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 472, DateTimeKind.Local).AddTicks(1138));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 21,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 472, DateTimeKind.Local).AddTicks(1141));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 22,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 472, DateTimeKind.Local).AddTicks(1145));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 23,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 472, DateTimeKind.Local).AddTicks(1148));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 24,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 472, DateTimeKind.Local).AddTicks(1151));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 25,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 472, DateTimeKind.Local).AddTicks(1154));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 26,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 472, DateTimeKind.Local).AddTicks(1157));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 27,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 472, DateTimeKind.Local).AddTicks(1160));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 28,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 472, DateTimeKind.Local).AddTicks(1163));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 29,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 472, DateTimeKind.Local).AddTicks(1167));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 30,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 472, DateTimeKind.Local).AddTicks(1170));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 31,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 472, DateTimeKind.Local).AddTicks(1173));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 32,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 472, DateTimeKind.Local).AddTicks(1176));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 33,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 472, DateTimeKind.Local).AddTicks(1179));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 34,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 472, DateTimeKind.Local).AddTicks(1183));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 35,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 472, DateTimeKind.Local).AddTicks(1186));

            migrationBuilder.UpdateData(
                table: "Layouts",
                keyColumn: "LayoutID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 470, DateTimeKind.Local).AddTicks(5495));

            migrationBuilder.UpdateData(
                table: "Layouts",
                keyColumn: "LayoutID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 470, DateTimeKind.Local).AddTicks(5664));

            migrationBuilder.UpdateData(
                table: "Layouts",
                keyColumn: "LayoutID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 470, DateTimeKind.Local).AddTicks(5675));

            migrationBuilder.UpdateData(
                table: "Layouts",
                keyColumn: "LayoutID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 470, DateTimeKind.Local).AddTicks(5680));

            migrationBuilder.UpdateData(
                table: "Layouts",
                keyColumn: "LayoutID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 470, DateTimeKind.Local).AddTicks(5683));

            migrationBuilder.UpdateData(
                table: "Layouts",
                keyColumn: "LayoutID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 470, DateTimeKind.Local).AddTicks(5694));

            migrationBuilder.UpdateData(
                table: "Layouts",
                keyColumn: "LayoutID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 470, DateTimeKind.Local).AddTicks(5697));

            migrationBuilder.UpdateData(
                table: "Layouts",
                keyColumn: "LayoutID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 470, DateTimeKind.Local).AddTicks(5701));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 453, DateTimeKind.Local).AddTicks(4113));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 453, DateTimeKind.Local).AddTicks(4287));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 453, DateTimeKind.Local).AddTicks(4299));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 453, DateTimeKind.Local).AddTicks(4305));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 453, DateTimeKind.Local).AddTicks(4311));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 453, DateTimeKind.Local).AddTicks(4351));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 453, DateTimeKind.Local).AddTicks(4322));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 453, DateTimeKind.Local).AddTicks(4333));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 999,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 453, DateTimeKind.Local).AddTicks(4344));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 9998,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 453, DateTimeKind.Local).AddTicks(4338));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 454, DateTimeKind.Local).AddTicks(3082));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 454, DateTimeKind.Local).AddTicks(3271));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 454, DateTimeKind.Local).AddTicks(3279));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 454, DateTimeKind.Local).AddTicks(3282));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 454, DateTimeKind.Local).AddTicks(3286));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 454, DateTimeKind.Local).AddTicks(3292));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 454, DateTimeKind.Local).AddTicks(3296));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 454, DateTimeKind.Local).AddTicks(3300));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 454, DateTimeKind.Local).AddTicks(3303));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 9994,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 454, DateTimeKind.Local).AddTicks(3308));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 9995,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 454, DateTimeKind.Local).AddTicks(3312));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 9996,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 454, DateTimeKind.Local).AddTicks(3316));

            migrationBuilder.UpdateData(
                table: "PaymentStatus",
                keyColumn: "PaymentStatusID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 435, DateTimeKind.Local).AddTicks(990));

            migrationBuilder.UpdateData(
                table: "PaymentStatus",
                keyColumn: "PaymentStatusID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 435, DateTimeKind.Local).AddTicks(1220));

            migrationBuilder.UpdateData(
                table: "PaymentStatus",
                keyColumn: "PaymentStatusID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 435, DateTimeKind.Local).AddTicks(1227));

            migrationBuilder.UpdateData(
                table: "PaymentStatus",
                keyColumn: "PaymentStatusID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 435, DateTimeKind.Local).AddTicks(1231));

            migrationBuilder.UpdateData(
                table: "PaymentStatus",
                keyColumn: "PaymentStatusID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 435, DateTimeKind.Local).AddTicks(1234));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 433, DateTimeKind.Local).AddTicks(1950));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 433, DateTimeKind.Local).AddTicks(2400));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 433, DateTimeKind.Local).AddTicks(2410));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 433, DateTimeKind.Local).AddTicks(2414));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 433, DateTimeKind.Local).AddTicks(2418));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 433, DateTimeKind.Local).AddTicks(2427));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 433, DateTimeKind.Local).AddTicks(2431));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 433, DateTimeKind.Local).AddTicks(2435));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 433, DateTimeKind.Local).AddTicks(2438));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 433, DateTimeKind.Local).AddTicks(2443));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 433, DateTimeKind.Local).AddTicks(2448));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 433, DateTimeKind.Local).AddTicks(2451));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 13,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 433, DateTimeKind.Local).AddTicks(2455));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 14,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 433, DateTimeKind.Local).AddTicks(2468));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 15,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 433, DateTimeKind.Local).AddTicks(2472));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 16,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 433, DateTimeKind.Local).AddTicks(2476));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 17,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 433, DateTimeKind.Local).AddTicks(2482));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 18,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 433, DateTimeKind.Local).AddTicks(2573));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 19,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 433, DateTimeKind.Local).AddTicks(2576));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 20,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 433, DateTimeKind.Local).AddTicks(2583));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 21,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 433, DateTimeKind.Local).AddTicks(2588));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 22,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 433, DateTimeKind.Local).AddTicks(2592));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 23,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 433, DateTimeKind.Local).AddTicks(2596));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 24,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 433, DateTimeKind.Local).AddTicks(2600));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 25,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 433, DateTimeKind.Local).AddTicks(2604));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 26,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 433, DateTimeKind.Local).AddTicks(2607));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 27,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 433, DateTimeKind.Local).AddTicks(2611));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 28,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 433, DateTimeKind.Local).AddTicks(2614));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 29,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 433, DateTimeKind.Local).AddTicks(2618));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 30,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 433, DateTimeKind.Local).AddTicks(2621));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 31,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 433, DateTimeKind.Local).AddTicks(2625));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 32,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 433, DateTimeKind.Local).AddTicks(2629));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 33,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 433, DateTimeKind.Local).AddTicks(2633));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 34,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 433, DateTimeKind.Local).AddTicks(2637));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 35,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 433, DateTimeKind.Local).AddTicks(2641));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 36,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 433, DateTimeKind.Local).AddTicks(2644));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 37,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 433, DateTimeKind.Local).AddTicks(2674));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 38,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 433, DateTimeKind.Local).AddTicks(2679));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 39,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 433, DateTimeKind.Local).AddTicks(2683));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 40,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 433, DateTimeKind.Local).AddTicks(2686));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 41,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 433, DateTimeKind.Local).AddTicks(2690));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 42,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 433, DateTimeKind.Local).AddTicks(2693));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 43,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 433, DateTimeKind.Local).AddTicks(2697));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 44,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 433, DateTimeKind.Local).AddTicks(2700));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 45,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 433, DateTimeKind.Local).AddTicks(2704));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 46,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 433, DateTimeKind.Local).AddTicks(2708));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 47,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 433, DateTimeKind.Local).AddTicks(2712));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 48,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 433, DateTimeKind.Local).AddTicks(2715));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 49,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 433, DateTimeKind.Local).AddTicks(2719));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 50,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 433, DateTimeKind.Local).AddTicks(2722));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 51,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 433, DateTimeKind.Local).AddTicks(2725));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 52,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 433, DateTimeKind.Local).AddTicks(2729));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 53,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 433, DateTimeKind.Local).AddTicks(2732));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 54,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 433, DateTimeKind.Local).AddTicks(2736));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 55,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 433, DateTimeKind.Local).AddTicks(2739));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 56,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 433, DateTimeKind.Local).AddTicks(2743));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 57,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 433, DateTimeKind.Local).AddTicks(2746));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 58,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 433, DateTimeKind.Local).AddTicks(2750));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 59,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 433, DateTimeKind.Local).AddTicks(2754));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 60,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 433, DateTimeKind.Local).AddTicks(2758));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 61,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 433, DateTimeKind.Local).AddTicks(2761));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 62,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 433, DateTimeKind.Local).AddTicks(2765));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 63,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 433, DateTimeKind.Local).AddTicks(2768));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 64,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 433, DateTimeKind.Local).AddTicks(2771));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 65,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 433, DateTimeKind.Local).AddTicks(2775));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 66,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 433, DateTimeKind.Local).AddTicks(2780));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 67,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 433, DateTimeKind.Local).AddTicks(2783));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 68,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 433, DateTimeKind.Local).AddTicks(2786));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 69,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 433, DateTimeKind.Local).AddTicks(2790));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 70,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 433, DateTimeKind.Local).AddTicks(2793));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 71,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 433, DateTimeKind.Local).AddTicks(2796));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 72,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 433, DateTimeKind.Local).AddTicks(2800));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 73,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 433, DateTimeKind.Local).AddTicks(2803));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 74,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 433, DateTimeKind.Local).AddTicks(2806));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 75,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 433, DateTimeKind.Local).AddTicks(2810));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 76,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 433, DateTimeKind.Local).AddTicks(2813));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 77,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 433, DateTimeKind.Local).AddTicks(2816));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 78,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 433, DateTimeKind.Local).AddTicks(2842));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 79,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 433, DateTimeKind.Local).AddTicks(2846));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 80,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 433, DateTimeKind.Local).AddTicks(2850));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 81,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 433, DateTimeKind.Local).AddTicks(2854));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 82,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 433, DateTimeKind.Local).AddTicks(2857));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 83,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 433, DateTimeKind.Local).AddTicks(2861));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 84,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 433, DateTimeKind.Local).AddTicks(2865));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 85,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 433, DateTimeKind.Local).AddTicks(2868));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 86,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 433, DateTimeKind.Local).AddTicks(2872));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 87,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 433, DateTimeKind.Local).AddTicks(2875));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 88,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 433, DateTimeKind.Local).AddTicks(2879));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 89,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 433, DateTimeKind.Local).AddTicks(2882));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 90,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 433, DateTimeKind.Local).AddTicks(2885));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 91,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 433, DateTimeKind.Local).AddTicks(2889));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 92,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 433, DateTimeKind.Local).AddTicks(2892));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 93,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 433, DateTimeKind.Local).AddTicks(2896));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 94,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 433, DateTimeKind.Local).AddTicks(2899));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 95,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 433, DateTimeKind.Local).AddTicks(2903));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 96,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 433, DateTimeKind.Local).AddTicks(2906));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 97,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 433, DateTimeKind.Local).AddTicks(2910));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 98,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 433, DateTimeKind.Local).AddTicks(2913));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 99,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 433, DateTimeKind.Local).AddTicks(2917));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 100,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 433, DateTimeKind.Local).AddTicks(2920));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 101,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 433, DateTimeKind.Local).AddTicks(2924));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 102,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 433, DateTimeKind.Local).AddTicks(2927));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 103,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 433, DateTimeKind.Local).AddTicks(2930));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 104,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 433, DateTimeKind.Local).AddTicks(2933));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 105,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 433, DateTimeKind.Local).AddTicks(2937));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 106,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 433, DateTimeKind.Local).AddTicks(2941));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 107,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 433, DateTimeKind.Local).AddTicks(2945));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 108,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 433, DateTimeKind.Local).AddTicks(2948));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 109,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 433, DateTimeKind.Local).AddTicks(2952));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 110,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 433, DateTimeKind.Local).AddTicks(2956));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 111,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 433, DateTimeKind.Local).AddTicks(2959));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 112,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 433, DateTimeKind.Local).AddTicks(2962));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 113,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 433, DateTimeKind.Local).AddTicks(2966));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 114,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 433, DateTimeKind.Local).AddTicks(2969));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 115,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 433, DateTimeKind.Local).AddTicks(3011));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 116,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 433, DateTimeKind.Local).AddTicks(3014));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 117,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 433, DateTimeKind.Local).AddTicks(3018));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 118,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 433, DateTimeKind.Local).AddTicks(3021));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 119,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 433, DateTimeKind.Local).AddTicks(3024));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 120,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 433, DateTimeKind.Local).AddTicks(3028));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 121,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 433, DateTimeKind.Local).AddTicks(3032));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 122,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 433, DateTimeKind.Local).AddTicks(3035));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 123,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 433, DateTimeKind.Local).AddTicks(3064));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 124,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 433, DateTimeKind.Local).AddTicks(3068));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 125,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 433, DateTimeKind.Local).AddTicks(3072));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 126,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 433, DateTimeKind.Local).AddTicks(3075));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 127,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 433, DateTimeKind.Local).AddTicks(3079));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 128,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 433, DateTimeKind.Local).AddTicks(3082));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 129,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 433, DateTimeKind.Local).AddTicks(3086));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 130,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 433, DateTimeKind.Local).AddTicks(3091));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 131,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 433, DateTimeKind.Local).AddTicks(3095));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 132,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 433, DateTimeKind.Local).AddTicks(3099));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 133,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 433, DateTimeKind.Local).AddTicks(3103));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 134,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 433, DateTimeKind.Local).AddTicks(3107));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 135,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 433, DateTimeKind.Local).AddTicks(3111));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 136,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 433, DateTimeKind.Local).AddTicks(3114));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 137,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 433, DateTimeKind.Local).AddTicks(3117));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 138,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 433, DateTimeKind.Local).AddTicks(3121));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 139,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 433, DateTimeKind.Local).AddTicks(3124));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 140,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 433, DateTimeKind.Local).AddTicks(3127));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 141,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 433, DateTimeKind.Local).AddTicks(3131));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 142,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 433, DateTimeKind.Local).AddTicks(3135));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 143,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 433, DateTimeKind.Local).AddTicks(3139));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 144,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 433, DateTimeKind.Local).AddTicks(3142));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 145,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 433, DateTimeKind.Local).AddTicks(3145));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 146,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 433, DateTimeKind.Local).AddTicks(3149));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 147,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 433, DateTimeKind.Local).AddTicks(3152));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 148,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 433, DateTimeKind.Local).AddTicks(3156));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 149,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 433, DateTimeKind.Local).AddTicks(3160));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 150,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 433, DateTimeKind.Local).AddTicks(3163));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 151,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 433, DateTimeKind.Local).AddTicks(3167));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 152,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 433, DateTimeKind.Local).AddTicks(3170));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 153,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 433, DateTimeKind.Local).AddTicks(3174));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 154,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 433, DateTimeKind.Local).AddTicks(3177));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 155,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 433, DateTimeKind.Local).AddTicks(3180));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 156,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 433, DateTimeKind.Local).AddTicks(3184));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 157,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 433, DateTimeKind.Local).AddTicks(3210));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 158,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 433, DateTimeKind.Local).AddTicks(3213));

            migrationBuilder.UpdateData(
                table: "PinCodeTypes",
                keyColumn: "PinCodeTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 477, DateTimeKind.Local).AddTicks(828));

            migrationBuilder.UpdateData(
                table: "PinCodeTypes",
                keyColumn: "PinCodeTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 477, DateTimeKind.Local).AddTicks(1002));

            migrationBuilder.UpdateData(
                table: "PinCodeTypes",
                keyColumn: "PinCodeTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 477, DateTimeKind.Local).AddTicks(1009));

            migrationBuilder.UpdateData(
                table: "PriorityRanks",
                keyColumn: "PriorityRankID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 447, DateTimeKind.Local).AddTicks(7880));

            migrationBuilder.UpdateData(
                table: "PriorityRanks",
                keyColumn: "PriorityRankID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 447, DateTimeKind.Local).AddTicks(8067));

            migrationBuilder.UpdateData(
                table: "PriorityRanks",
                keyColumn: "PriorityRankID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 447, DateTimeKind.Local).AddTicks(8075));

            migrationBuilder.UpdateData(
                table: "PriorityRanks",
                keyColumn: "PriorityRankID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 447, DateTimeKind.Local).AddTicks(8078));

            migrationBuilder.UpdateData(
                table: "RecordStatus",
                keyColumn: "RecordStatusID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 466, DateTimeKind.Local).AddTicks(9305));

            migrationBuilder.UpdateData(
                table: "RecordStatus",
                keyColumn: "RecordStatusID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 466, DateTimeKind.Local).AddTicks(9502));

            migrationBuilder.UpdateData(
                table: "RecordStatus",
                keyColumn: "RecordStatusID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 466, DateTimeKind.Local).AddTicks(9509));

            migrationBuilder.UpdateData(
                table: "RelationshipTypes",
                keyColumn: "RelationshipTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 443, DateTimeKind.Local).AddTicks(4553));

            migrationBuilder.UpdateData(
                table: "RelationshipTypes",
                keyColumn: "RelationshipTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 443, DateTimeKind.Local).AddTicks(4638));

            migrationBuilder.UpdateData(
                table: "RelationshipTypes",
                keyColumn: "RelationshipTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 443, DateTimeKind.Local).AddTicks(4642));

            migrationBuilder.UpdateData(
                table: "RelationshipTypes",
                keyColumn: "RelationshipTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 443, DateTimeKind.Local).AddTicks(4645));

            migrationBuilder.UpdateData(
                table: "RelationshipTypes",
                keyColumn: "RelationshipTypeID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 443, DateTimeKind.Local).AddTicks(4647));

            migrationBuilder.UpdateData(
                table: "RelationshipTypes",
                keyColumn: "RelationshipTypeID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 443, DateTimeKind.Local).AddTicks(4651));

            migrationBuilder.UpdateData(
                table: "RelationshipTypes",
                keyColumn: "RelationshipTypeID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 443, DateTimeKind.Local).AddTicks(4654));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 459, DateTimeKind.Local).AddTicks(9413));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 459, DateTimeKind.Local).AddTicks(9478));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 459, DateTimeKind.Local).AddTicks(9482));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 459, DateTimeKind.Local).AddTicks(9485));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 459, DateTimeKind.Local).AddTicks(9488));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 459, DateTimeKind.Local).AddTicks(9492));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 459, DateTimeKind.Local).AddTicks(9495));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 459, DateTimeKind.Local).AddTicks(9498));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 459, DateTimeKind.Local).AddTicks(9501));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 459, DateTimeKind.Local).AddTicks(9505));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 459, DateTimeKind.Local).AddTicks(9509));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 459, DateTimeKind.Local).AddTicks(9511));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 433, DateTimeKind.Local).AddTicks(7048));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 433, DateTimeKind.Local).AddTicks(7114));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 433, DateTimeKind.Local).AddTicks(7140));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 433, DateTimeKind.Local).AddTicks(7142));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 433, DateTimeKind.Local).AddTicks(7144));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 433, DateTimeKind.Local).AddTicks(7150));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 433, DateTimeKind.Local).AddTicks(7153));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 433, DateTimeKind.Local).AddTicks(7155));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 433, DateTimeKind.Local).AddTicks(7157));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 433, DateTimeKind.Local).AddTicks(7160));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 433, DateTimeKind.Local).AddTicks(7162));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 433, DateTimeKind.Local).AddTicks(7164));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 13,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 433, DateTimeKind.Local).AddTicks(7166));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 14,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 433, DateTimeKind.Local).AddTicks(7168));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 15,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 433, DateTimeKind.Local).AddTicks(7171));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 16,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 433, DateTimeKind.Local).AddTicks(7173));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 17,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 433, DateTimeKind.Local).AddTicks(7175));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 18,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 433, DateTimeKind.Local).AddTicks(7177));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 19,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 433, DateTimeKind.Local).AddTicks(7180));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 20,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 433, DateTimeKind.Local).AddTicks(7182));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 21,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 433, DateTimeKind.Local).AddTicks(7184));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 22,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 433, DateTimeKind.Local).AddTicks(7186));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 23,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 433, DateTimeKind.Local).AddTicks(7188));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 24,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 433, DateTimeKind.Local).AddTicks(7190));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 25,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 433, DateTimeKind.Local).AddTicks(7192));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 26,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 433, DateTimeKind.Local).AddTicks(7194));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 27,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 433, DateTimeKind.Local).AddTicks(7197));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 28,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 433, DateTimeKind.Local).AddTicks(7199));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 29,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 433, DateTimeKind.Local).AddTicks(7201));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 30,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 433, DateTimeKind.Local).AddTicks(7203));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 31,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 433, DateTimeKind.Local).AddTicks(7205));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 32,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 433, DateTimeKind.Local).AddTicks(7207));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 33,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 433, DateTimeKind.Local).AddTicks(7210));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 34,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 433, DateTimeKind.Local).AddTicks(7214));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 35,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 433, DateTimeKind.Local).AddTicks(7216));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 36,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 433, DateTimeKind.Local).AddTicks(7218));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 37,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 433, DateTimeKind.Local).AddTicks(7220));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 38,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 433, DateTimeKind.Local).AddTicks(7222));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 39,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 433, DateTimeKind.Local).AddTicks(7224));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 40,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 433, DateTimeKind.Local).AddTicks(7226));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 41,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 433, DateTimeKind.Local).AddTicks(7228));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 42,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 433, DateTimeKind.Local).AddTicks(7231));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 43,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 433, DateTimeKind.Local).AddTicks(7233));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 44,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 433, DateTimeKind.Local).AddTicks(7235));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 45,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 433, DateTimeKind.Local).AddTicks(7237));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 46,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 433, DateTimeKind.Local).AddTicks(7239));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 47,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 433, DateTimeKind.Local).AddTicks(7274));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 48,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 433, DateTimeKind.Local).AddTicks(7277));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 49,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 433, DateTimeKind.Local).AddTicks(7279));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 50,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 433, DateTimeKind.Local).AddTicks(7282));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 51,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 433, DateTimeKind.Local).AddTicks(7284));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 52,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 433, DateTimeKind.Local).AddTicks(7286));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 53,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 433, DateTimeKind.Local).AddTicks(7288));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 54,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 433, DateTimeKind.Local).AddTicks(7290));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 55,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 433, DateTimeKind.Local).AddTicks(7292));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 56,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 433, DateTimeKind.Local).AddTicks(7294));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 57,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 433, DateTimeKind.Local).AddTicks(7297));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 58,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 433, DateTimeKind.Local).AddTicks(7299));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 59,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 433, DateTimeKind.Local).AddTicks(7301));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 60,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 433, DateTimeKind.Local).AddTicks(7303));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 61,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 433, DateTimeKind.Local).AddTicks(7305));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 62,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 433, DateTimeKind.Local).AddTicks(7307));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 63,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 433, DateTimeKind.Local).AddTicks(7309));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 64,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 433, DateTimeKind.Local).AddTicks(7311));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 65,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 433, DateTimeKind.Local).AddTicks(7313));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 66,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 433, DateTimeKind.Local).AddTicks(7316));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 67,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 433, DateTimeKind.Local).AddTicks(7319));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 68,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 433, DateTimeKind.Local).AddTicks(7321));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 69,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 433, DateTimeKind.Local).AddTicks(7323));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 70,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 433, DateTimeKind.Local).AddTicks(7325));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 71,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 433, DateTimeKind.Local).AddTicks(7327));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 72,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 433, DateTimeKind.Local).AddTicks(7329));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 73,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 433, DateTimeKind.Local).AddTicks(7331));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 74,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 433, DateTimeKind.Local).AddTicks(7333));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 75,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 433, DateTimeKind.Local).AddTicks(7335));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 76,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 433, DateTimeKind.Local).AddTicks(7337));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 77,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 433, DateTimeKind.Local).AddTicks(7339));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 78,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 433, DateTimeKind.Local).AddTicks(7341));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 79,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 433, DateTimeKind.Local).AddTicks(7344));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 80,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 433, DateTimeKind.Local).AddTicks(7346));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 81,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 433, DateTimeKind.Local).AddTicks(7348));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 82,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 433, DateTimeKind.Local).AddTicks(7350));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 83,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 433, DateTimeKind.Local).AddTicks(7352));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 84,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 433, DateTimeKind.Local).AddTicks(7354));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 85,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 433, DateTimeKind.Local).AddTicks(7356));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 86,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 433, DateTimeKind.Local).AddTicks(7358));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 87,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 433, DateTimeKind.Local).AddTicks(7360));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 88,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 433, DateTimeKind.Local).AddTicks(7362));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 89,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 433, DateTimeKind.Local).AddTicks(7364));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 90,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 433, DateTimeKind.Local).AddTicks(7367));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 91,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 433, DateTimeKind.Local).AddTicks(7369));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 92,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 433, DateTimeKind.Local).AddTicks(7371));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 93,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 433, DateTimeKind.Local).AddTicks(7373));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 94,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 433, DateTimeKind.Local).AddTicks(7375));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 95,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 433, DateTimeKind.Local).AddTicks(7377));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 96,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 433, DateTimeKind.Local).AddTicks(7379));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 97,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 433, DateTimeKind.Local).AddTicks(7381));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 98,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 433, DateTimeKind.Local).AddTicks(7384));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 99,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 433, DateTimeKind.Local).AddTicks(7386));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 100,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 433, DateTimeKind.Local).AddTicks(7388));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 101,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 433, DateTimeKind.Local).AddTicks(7390));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 102,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 433, DateTimeKind.Local).AddTicks(7392));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 103,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 433, DateTimeKind.Local).AddTicks(7394));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 104,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 433, DateTimeKind.Local).AddTicks(7396));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 105,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 433, DateTimeKind.Local).AddTicks(7398));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 106,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 433, DateTimeKind.Local).AddTicks(7400));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 107,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 433, DateTimeKind.Local).AddTicks(7403));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 108,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 433, DateTimeKind.Local).AddTicks(7405));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 109,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 433, DateTimeKind.Local).AddTicks(7407));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 110,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 433, DateTimeKind.Local).AddTicks(7409));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 111,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 433, DateTimeKind.Local).AddTicks(7411));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 112,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 433, DateTimeKind.Local).AddTicks(7413));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 113,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 433, DateTimeKind.Local).AddTicks(7415));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 114,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 433, DateTimeKind.Local).AddTicks(7417));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 115,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 433, DateTimeKind.Local).AddTicks(7419));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 116,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 433, DateTimeKind.Local).AddTicks(7422));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 117,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 433, DateTimeKind.Local).AddTicks(7424));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 118,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 433, DateTimeKind.Local).AddTicks(7426));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 119,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 433, DateTimeKind.Local).AddTicks(7428));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 120,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 433, DateTimeKind.Local).AddTicks(7430));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 121,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 433, DateTimeKind.Local).AddTicks(7432));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 122,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 433, DateTimeKind.Local).AddTicks(7434));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 123,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 433, DateTimeKind.Local).AddTicks(7436));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 124,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 433, DateTimeKind.Local).AddTicks(7439));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 125,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 433, DateTimeKind.Local).AddTicks(7441));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 126,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 433, DateTimeKind.Local).AddTicks(7443));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 127,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 433, DateTimeKind.Local).AddTicks(7445));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 128,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 433, DateTimeKind.Local).AddTicks(7447));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 129,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 433, DateTimeKind.Local).AddTicks(7449));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 130,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 433, DateTimeKind.Local).AddTicks(7484));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 131,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 433, DateTimeKind.Local).AddTicks(7486));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 132,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 433, DateTimeKind.Local).AddTicks(7488));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 133,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 433, DateTimeKind.Local).AddTicks(7490));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 134,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 433, DateTimeKind.Local).AddTicks(7492));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 135,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 433, DateTimeKind.Local).AddTicks(7494));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 136,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 433, DateTimeKind.Local).AddTicks(7496));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 137,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 433, DateTimeKind.Local).AddTicks(7499));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 138,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 433, DateTimeKind.Local).AddTicks(7501));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 139,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 433, DateTimeKind.Local).AddTicks(7503));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 140,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 433, DateTimeKind.Local).AddTicks(7505));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 141,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 433, DateTimeKind.Local).AddTicks(7507));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 142,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 433, DateTimeKind.Local).AddTicks(7509));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 143,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 433, DateTimeKind.Local).AddTicks(7511));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 144,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 433, DateTimeKind.Local).AddTicks(7513));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 145,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 433, DateTimeKind.Local).AddTicks(7515));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 146,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 433, DateTimeKind.Local).AddTicks(7517));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 147,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 433, DateTimeKind.Local).AddTicks(7519));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 148,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 433, DateTimeKind.Local).AddTicks(7521));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 149,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 433, DateTimeKind.Local).AddTicks(7523));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 150,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 433, DateTimeKind.Local).AddTicks(7525));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 151,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 433, DateTimeKind.Local).AddTicks(7528));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 152,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 433, DateTimeKind.Local).AddTicks(7530));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 153,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 433, DateTimeKind.Local).AddTicks(7532));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 154,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 433, DateTimeKind.Local).AddTicks(7534));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 155,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 433, DateTimeKind.Local).AddTicks(7536));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 156,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 433, DateTimeKind.Local).AddTicks(7538));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 157,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 433, DateTimeKind.Local).AddTicks(7540));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 158,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 433, DateTimeKind.Local).AddTicks(7542));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 428, DateTimeKind.Local).AddTicks(892));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 430, DateTimeKind.Local).AddTicks(7256));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 430, DateTimeKind.Local).AddTicks(7307));

            migrationBuilder.UpdateData(
                table: "StatementLists",
                keyColumn: "StatementID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 462, DateTimeKind.Local).AddTicks(5732));

            migrationBuilder.UpdateData(
                table: "StatementLists",
                keyColumn: "StatementID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 462, DateTimeKind.Local).AddTicks(5946));

            migrationBuilder.UpdateData(
                table: "StatementLists",
                keyColumn: "StatementID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 462, DateTimeKind.Local).AddTicks(5955));

            migrationBuilder.UpdateData(
                table: "StatementLists",
                keyColumn: "StatementID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 462, DateTimeKind.Local).AddTicks(5959));

            migrationBuilder.UpdateData(
                table: "TechnicalSupport",
                keyColumn: "TechnicalSupportID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 474, DateTimeKind.Local).AddTicks(3077));

            migrationBuilder.UpdateData(
                table: "TechnicalSupport",
                keyColumn: "TechnicalSupportID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 474, DateTimeKind.Local).AddTicks(3252));

            migrationBuilder.UpdateData(
                table: "TechnicalSupport",
                keyColumn: "TechnicalSupportID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 474, DateTimeKind.Local).AddTicks(3261));

            migrationBuilder.UpdateData(
                table: "TechnicalSupport",
                keyColumn: "TechnicalSupportID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 474, DateTimeKind.Local).AddTicks(3265));

            migrationBuilder.UpdateData(
                table: "TechnicalSupport",
                keyColumn: "TechnicalSupportID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 474, DateTimeKind.Local).AddTicks(3269));

            migrationBuilder.UpdateData(
                table: "TechnicalSupport",
                keyColumn: "TechnicalSupportID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 474, DateTimeKind.Local).AddTicks(3276));

            migrationBuilder.UpdateData(
                table: "TechnicalSupport",
                keyColumn: "TechnicalSupportID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 474, DateTimeKind.Local).AddTicks(3281));

            migrationBuilder.UpdateData(
                table: "Titles",
                keyColumn: "TitleID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 464, DateTimeKind.Local).AddTicks(1990));

            migrationBuilder.UpdateData(
                table: "Titles",
                keyColumn: "TitleID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 464, DateTimeKind.Local).AddTicks(2348));

            migrationBuilder.UpdateData(
                table: "Titles",
                keyColumn: "TitleID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 464, DateTimeKind.Local).AddTicks(2356));

            migrationBuilder.UpdateData(
                table: "Titles",
                keyColumn: "TitleID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 464, DateTimeKind.Local).AddTicks(2360));

            migrationBuilder.UpdateData(
                table: "Titles",
                keyColumn: "TitleID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 464, DateTimeKind.Local).AddTicks(2363));

            migrationBuilder.UpdateData(
                table: "Titles",
                keyColumn: "TitleID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 464, DateTimeKind.Local).AddTicks(2371));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 436, DateTimeKind.Local).AddTicks(5747));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 436, DateTimeKind.Local).AddTicks(6130));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 436, DateTimeKind.Local).AddTicks(6176));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 436, DateTimeKind.Local).AddTicks(6217));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 436, DateTimeKind.Local).AddTicks(6258));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 436, DateTimeKind.Local).AddTicks(6297));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 436, DateTimeKind.Local).AddTicks(6358));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 436, DateTimeKind.Local).AddTicks(6391));

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumns: new[] { "UserID", "RoleID" },
                keyValues: new object[] { 1, 1 },
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 452, DateTimeKind.Local).AddTicks(1403));

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumns: new[] { "UserID", "RoleID" },
                keyValues: new object[] { 2, 3 },
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 452, DateTimeKind.Local).AddTicks(1466));

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "UserTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 442, DateTimeKind.Local).AddTicks(3739));

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "UserTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 442, DateTimeKind.Local).AddTicks(4073));

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "UserTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 442, DateTimeKind.Local).AddTicks(4080));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 1,
                columns: new[] { "GrantAccessToTestEnvironment", "LastChangedDate" },
                values: new object[] { true, new DateTime(2022, 4, 6, 7, 50, 17, 448, DateTimeKind.Local).AddTicks(967) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 2,
                columns: new[] { "FirstName", "IDNumber", "LastChangedDate", "LastName" },
                values: new object[] { "Elroitec", "201703232441609", new DateTime(2022, 4, 6, 7, 50, 17, 448, DateTimeKind.Local).AddTicks(3497), "Employer" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 3,
                columns: new[] { "FirstName", "IDNumber", "LastChangedDate", "LastName" },
                values: new object[] { "Elroitec", "20200716041609", new DateTime(2022, 4, 6, 7, 50, 17, 448, DateTimeKind.Local).AddTicks(3594), "Employee" });

            migrationBuilder.UpdateData(
                table: "VariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 444, DateTimeKind.Local).AddTicks(7849));

            migrationBuilder.UpdateData(
                table: "VariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 444, DateTimeKind.Local).AddTicks(8112));

            migrationBuilder.UpdateData(
                table: "VariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 444, DateTimeKind.Local).AddTicks(8119));

            migrationBuilder.UpdateData(
                table: "VariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 444, DateTimeKind.Local).AddTicks(8122));

            migrationBuilder.UpdateData(
                table: "VariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 444, DateTimeKind.Local).AddTicks(8125));

            migrationBuilder.UpdateData(
                table: "VariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 444, DateTimeKind.Local).AddTicks(8131));

            migrationBuilder.UpdateData(
                table: "VariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 444, DateTimeKind.Local).AddTicks(8137));

            migrationBuilder.UpdateData(
                table: "VariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 444, DateTimeKind.Local).AddTicks(8140));

            migrationBuilder.UpdateData(
                table: "VariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 6, 7, 50, 17, 444, DateTimeKind.Local).AddTicks(8143));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "UserName",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserName",
                table: "Clients",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "BankAccountTypes",
                keyColumn: "BankAccountTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 433, DateTimeKind.Local).AddTicks(4176));

            migrationBuilder.UpdateData(
                table: "BankAccountTypes",
                keyColumn: "BankAccountTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 433, DateTimeKind.Local).AddTicks(4686));

            migrationBuilder.UpdateData(
                table: "BankAccountTypes",
                keyColumn: "BankAccountTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 433, DateTimeKind.Local).AddTicks(4739));

            migrationBuilder.UpdateData(
                table: "BankAccountTypes",
                keyColumn: "BankAccountTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 433, DateTimeKind.Local).AddTicks(4746));

            migrationBuilder.UpdateData(
                table: "ClientAccountTypes",
                keyColumn: "ID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 489, DateTimeKind.Local).AddTicks(1698));

            migrationBuilder.UpdateData(
                table: "ClientAccountTypes",
                keyColumn: "ID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 489, DateTimeKind.Local).AddTicks(2005));

            migrationBuilder.UpdateData(
                table: "ClientGroups",
                keyColumn: "ClientGroupID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 492, DateTimeKind.Local).AddTicks(4300));

            migrationBuilder.UpdateData(
                table: "ClientGroups",
                keyColumn: "ClientGroupID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 492, DateTimeKind.Local).AddTicks(6971));

            migrationBuilder.UpdateData(
                table: "ContactTypes",
                keyColumn: "ContactTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 443, DateTimeKind.Local).AddTicks(697));

            migrationBuilder.UpdateData(
                table: "ContactTypes",
                keyColumn: "ContactTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 443, DateTimeKind.Local).AddTicks(688));

            migrationBuilder.UpdateData(
                table: "ContactTypes",
                keyColumn: "ContactTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 443, DateTimeKind.Local).AddTicks(678));

            migrationBuilder.UpdateData(
                table: "ContactTypes",
                keyColumn: "ContactTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 443, DateTimeKind.Local).AddTicks(525));

            migrationBuilder.UpdateData(
                table: "ContactTypes",
                keyColumn: "ContactTypeID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 443, DateTimeKind.Local).AddTicks(705));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 449, DateTimeKind.Local).AddTicks(9322));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 449, DateTimeKind.Local).AddTicks(9736));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 449, DateTimeKind.Local).AddTicks(9755));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 449, DateTimeKind.Local).AddTicks(9769));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 449, DateTimeKind.Local).AddTicks(9776));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 449, DateTimeKind.Local).AddTicks(9790));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 449, DateTimeKind.Local).AddTicks(9799));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 449, DateTimeKind.Local).AddTicks(9808));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 449, DateTimeKind.Local).AddTicks(9816));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 449, DateTimeKind.Local).AddTicks(9827));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 449, DateTimeKind.Local).AddTicks(9835));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 449, DateTimeKind.Local).AddTicks(9843));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 13,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 449, DateTimeKind.Local).AddTicks(9851));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 14,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 449, DateTimeKind.Local).AddTicks(9858));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 15,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 449, DateTimeKind.Local).AddTicks(9866));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 16,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 449, DateTimeKind.Local).AddTicks(9875));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 17,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 449, DateTimeKind.Local).AddTicks(9882));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 18,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 449, DateTimeKind.Local).AddTicks(9892));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 19,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 449, DateTimeKind.Local).AddTicks(9899));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 20,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 449, DateTimeKind.Local).AddTicks(9907));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 21,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 449, DateTimeKind.Local).AddTicks(9915));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 22,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 449, DateTimeKind.Local).AddTicks(9922));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 23,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 449, DateTimeKind.Local).AddTicks(9930));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 24,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 449, DateTimeKind.Local).AddTicks(9937));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 25,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 449, DateTimeKind.Local).AddTicks(9944));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 26,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 449, DateTimeKind.Local).AddTicks(9951));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 27,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 449, DateTimeKind.Local).AddTicks(9968));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 28,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 449, DateTimeKind.Local).AddTicks(9975));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 29,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 449, DateTimeKind.Local).AddTicks(9983));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 30,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 450, DateTimeKind.Local).AddTicks(110));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 31,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 450, DateTimeKind.Local).AddTicks(118));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 32,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 450, DateTimeKind.Local).AddTicks(125));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 33,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 450, DateTimeKind.Local).AddTicks(134));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 34,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 450, DateTimeKind.Local).AddTicks(144));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 35,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 450, DateTimeKind.Local).AddTicks(151));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 36,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 450, DateTimeKind.Local).AddTicks(159));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 37,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 450, DateTimeKind.Local).AddTicks(167));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 38,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 450, DateTimeKind.Local).AddTicks(174));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 39,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 450, DateTimeKind.Local).AddTicks(182));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 40,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 450, DateTimeKind.Local).AddTicks(190));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 41,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 450, DateTimeKind.Local).AddTicks(200));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 42,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 450, DateTimeKind.Local).AddTicks(207));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 43,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 450, DateTimeKind.Local).AddTicks(215));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 44,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 450, DateTimeKind.Local).AddTicks(223));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 45,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 450, DateTimeKind.Local).AddTicks(231));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 46,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 450, DateTimeKind.Local).AddTicks(239));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 47,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 450, DateTimeKind.Local).AddTicks(247));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 48,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 450, DateTimeKind.Local).AddTicks(258));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 49,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 450, DateTimeKind.Local).AddTicks(267));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 50,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 450, DateTimeKind.Local).AddTicks(275));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 51,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 450, DateTimeKind.Local).AddTicks(282));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 52,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 450, DateTimeKind.Local).AddTicks(290));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 53,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 450, DateTimeKind.Local).AddTicks(297));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 54,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 450, DateTimeKind.Local).AddTicks(305));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 55,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 450, DateTimeKind.Local).AddTicks(313));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 56,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 450, DateTimeKind.Local).AddTicks(321));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 57,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 450, DateTimeKind.Local).AddTicks(328));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 58,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 450, DateTimeKind.Local).AddTicks(336));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 59,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 450, DateTimeKind.Local).AddTicks(346));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 60,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 450, DateTimeKind.Local).AddTicks(355));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 61,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 450, DateTimeKind.Local).AddTicks(363));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 62,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 450, DateTimeKind.Local).AddTicks(370));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 63,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 450, DateTimeKind.Local).AddTicks(378));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 64,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 450, DateTimeKind.Local).AddTicks(392));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 65,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 450, DateTimeKind.Local).AddTicks(401));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 66,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 450, DateTimeKind.Local).AddTicks(411));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 67,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 450, DateTimeKind.Local).AddTicks(418));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 68,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 450, DateTimeKind.Local).AddTicks(426));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 69,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 450, DateTimeKind.Local).AddTicks(433));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 70,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 450, DateTimeKind.Local).AddTicks(441));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 71,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 450, DateTimeKind.Local).AddTicks(448));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 72,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 450, DateTimeKind.Local).AddTicks(457));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 73,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 450, DateTimeKind.Local).AddTicks(465));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 74,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 450, DateTimeKind.Local).AddTicks(473));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 75,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 450, DateTimeKind.Local).AddTicks(481));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 76,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 450, DateTimeKind.Local).AddTicks(490));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 77,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 450, DateTimeKind.Local).AddTicks(497));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 78,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 450, DateTimeKind.Local).AddTicks(504));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 79,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 450, DateTimeKind.Local).AddTicks(511));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 80,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 450, DateTimeKind.Local).AddTicks(520));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 81,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 450, DateTimeKind.Local).AddTicks(527));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 82,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 450, DateTimeKind.Local).AddTicks(535));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 83,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 450, DateTimeKind.Local).AddTicks(582));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 84,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 450, DateTimeKind.Local).AddTicks(591));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 85,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 450, DateTimeKind.Local).AddTicks(598));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 86,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 450, DateTimeKind.Local).AddTicks(606));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 87,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 450, DateTimeKind.Local).AddTicks(614));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 88,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 450, DateTimeKind.Local).AddTicks(621));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 89,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 450, DateTimeKind.Local).AddTicks(629));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 90,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 450, DateTimeKind.Local).AddTicks(636));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 91,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 450, DateTimeKind.Local).AddTicks(643));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 92,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 450, DateTimeKind.Local).AddTicks(651));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 93,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 450, DateTimeKind.Local).AddTicks(659));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 94,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 450, DateTimeKind.Local).AddTicks(666));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 95,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 450, DateTimeKind.Local).AddTicks(673));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 96,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 450, DateTimeKind.Local).AddTicks(680));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 97,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 450, DateTimeKind.Local).AddTicks(687));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 98,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 450, DateTimeKind.Local).AddTicks(694));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 99,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 450, DateTimeKind.Local).AddTicks(701));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 100,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 450, DateTimeKind.Local).AddTicks(708));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 101,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 450, DateTimeKind.Local).AddTicks(717));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 102,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 450, DateTimeKind.Local).AddTicks(724));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 103,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 450, DateTimeKind.Local).AddTicks(731));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 104,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 450, DateTimeKind.Local).AddTicks(738));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 105,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 450, DateTimeKind.Local).AddTicks(746));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 106,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 450, DateTimeKind.Local).AddTicks(753));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 107,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 450, DateTimeKind.Local).AddTicks(760));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 108,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 450, DateTimeKind.Local).AddTicks(769));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 109,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 450, DateTimeKind.Local).AddTicks(776));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 110,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 450, DateTimeKind.Local).AddTicks(783));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 111,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 450, DateTimeKind.Local).AddTicks(791));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 112,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 450, DateTimeKind.Local).AddTicks(799));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 113,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 450, DateTimeKind.Local).AddTicks(806));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 114,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 450, DateTimeKind.Local).AddTicks(814));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 115,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 450, DateTimeKind.Local).AddTicks(822));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 116,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 450, DateTimeKind.Local).AddTicks(829));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 117,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 450, DateTimeKind.Local).AddTicks(836));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 118,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 450, DateTimeKind.Local).AddTicks(844));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 119,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 450, DateTimeKind.Local).AddTicks(851));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 120,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 450, DateTimeKind.Local).AddTicks(858));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 121,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 450, DateTimeKind.Local).AddTicks(866));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 122,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 450, DateTimeKind.Local).AddTicks(874));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 123,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 450, DateTimeKind.Local).AddTicks(881));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 124,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 450, DateTimeKind.Local).AddTicks(888));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 125,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 450, DateTimeKind.Local).AddTicks(895));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 126,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 450, DateTimeKind.Local).AddTicks(902));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 127,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 450, DateTimeKind.Local).AddTicks(909));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 128,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 450, DateTimeKind.Local).AddTicks(916));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 129,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 450, DateTimeKind.Local).AddTicks(924));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 130,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 450, DateTimeKind.Local).AddTicks(934));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 131,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 450, DateTimeKind.Local).AddTicks(941));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 132,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 450, DateTimeKind.Local).AddTicks(949));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 133,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 450, DateTimeKind.Local).AddTicks(956));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 134,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 450, DateTimeKind.Local).AddTicks(963));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 135,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 450, DateTimeKind.Local).AddTicks(970));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 136,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 450, DateTimeKind.Local).AddTicks(978));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 137,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 450, DateTimeKind.Local).AddTicks(984));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 138,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 450, DateTimeKind.Local).AddTicks(1033));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 139,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 450, DateTimeKind.Local).AddTicks(1041));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 140,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 450, DateTimeKind.Local).AddTicks(1049));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 141,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 450, DateTimeKind.Local).AddTicks(1057));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 142,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 450, DateTimeKind.Local).AddTicks(1064));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 143,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 450, DateTimeKind.Local).AddTicks(1072));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 144,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 450, DateTimeKind.Local).AddTicks(1079));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 145,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 450, DateTimeKind.Local).AddTicks(1086));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 146,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 450, DateTimeKind.Local).AddTicks(1094));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 147,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 450, DateTimeKind.Local).AddTicks(1101));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 148,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 450, DateTimeKind.Local).AddTicks(1109));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 149,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 450, DateTimeKind.Local).AddTicks(1117));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 150,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 450, DateTimeKind.Local).AddTicks(1126));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 151,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 450, DateTimeKind.Local).AddTicks(1134));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 152,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 450, DateTimeKind.Local).AddTicks(1142));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 153,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 450, DateTimeKind.Local).AddTicks(1150));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 154,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 450, DateTimeKind.Local).AddTicks(1157));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 155,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 450, DateTimeKind.Local).AddTicks(1165));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 156,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 450, DateTimeKind.Local).AddTicks(1173));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 157,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 450, DateTimeKind.Local).AddTicks(1180));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 158,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 450, DateTimeKind.Local).AddTicks(1187));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 159,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 450, DateTimeKind.Local).AddTicks(1194));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 160,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 450, DateTimeKind.Local).AddTicks(1202));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 161,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 450, DateTimeKind.Local).AddTicks(1211));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 162,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 450, DateTimeKind.Local).AddTicks(1218));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 163,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 450, DateTimeKind.Local).AddTicks(1225));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 164,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 450, DateTimeKind.Local).AddTicks(1233));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 165,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 450, DateTimeKind.Local).AddTicks(1241));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 166,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 450, DateTimeKind.Local).AddTicks(1248));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 167,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 450, DateTimeKind.Local).AddTicks(1256));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 168,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 450, DateTimeKind.Local).AddTicks(1263));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 169,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 450, DateTimeKind.Local).AddTicks(1271));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 170,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 450, DateTimeKind.Local).AddTicks(1279));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 171,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 450, DateTimeKind.Local).AddTicks(1286));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 172,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 450, DateTimeKind.Local).AddTicks(1295));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 173,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 450, DateTimeKind.Local).AddTicks(1304));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 174,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 450, DateTimeKind.Local).AddTicks(1313));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 175,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 450, DateTimeKind.Local).AddTicks(1321));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 176,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 450, DateTimeKind.Local).AddTicks(1330));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 177,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 450, DateTimeKind.Local).AddTicks(1341));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 178,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 450, DateTimeKind.Local).AddTicks(1348));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 179,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 450, DateTimeKind.Local).AddTicks(1357));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 180,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 450, DateTimeKind.Local).AddTicks(1366));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 181,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 450, DateTimeKind.Local).AddTicks(1375));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 182,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 450, DateTimeKind.Local).AddTicks(1383));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 183,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 450, DateTimeKind.Local).AddTicks(1389));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 184,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 450, DateTimeKind.Local).AddTicks(1397));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 185,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 450, DateTimeKind.Local).AddTicks(1404));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 186,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 450, DateTimeKind.Local).AddTicks(1412));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 187,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 450, DateTimeKind.Local).AddTicks(1420));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 188,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 450, DateTimeKind.Local).AddTicks(1427));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 189,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 450, DateTimeKind.Local).AddTicks(1435));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 190,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 450, DateTimeKind.Local).AddTicks(1442));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 191,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 450, DateTimeKind.Local).AddTicks(1450));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 192,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 450, DateTimeKind.Local).AddTicks(1457));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 193,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 450, DateTimeKind.Local).AddTicks(1466));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 194,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 450, DateTimeKind.Local).AddTicks(1473));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 195,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 450, DateTimeKind.Local).AddTicks(1480));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 196,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 450, DateTimeKind.Local).AddTicks(1487));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 197,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 450, DateTimeKind.Local).AddTicks(1494));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 198,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 450, DateTimeKind.Local).AddTicks(1502));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 199,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 450, DateTimeKind.Local).AddTicks(1509));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 200,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 450, DateTimeKind.Local).AddTicks(1516));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 201,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 450, DateTimeKind.Local).AddTicks(1524));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 202,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 450, DateTimeKind.Local).AddTicks(1531));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 203,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 450, DateTimeKind.Local).AddTicks(1538));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 204,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 450, DateTimeKind.Local).AddTicks(1545));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 205,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 450, DateTimeKind.Local).AddTicks(1552));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 206,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 450, DateTimeKind.Local).AddTicks(1561));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 207,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 450, DateTimeKind.Local).AddTicks(1612));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 208,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 450, DateTimeKind.Local).AddTicks(1620));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 209,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 450, DateTimeKind.Local).AddTicks(1628));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 210,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 450, DateTimeKind.Local).AddTicks(1637));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 211,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 450, DateTimeKind.Local).AddTicks(1645));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 212,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 450, DateTimeKind.Local).AddTicks(1652));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 213,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 450, DateTimeKind.Local).AddTicks(1659));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 214,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 450, DateTimeKind.Local).AddTicks(1668));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 215,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 450, DateTimeKind.Local).AddTicks(1676));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 216,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 450, DateTimeKind.Local).AddTicks(1684));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 217,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 450, DateTimeKind.Local).AddTicks(1691));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 218,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 450, DateTimeKind.Local).AddTicks(1699));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 219,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 450, DateTimeKind.Local).AddTicks(1706));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 220,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 450, DateTimeKind.Local).AddTicks(1714));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 221,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 450, DateTimeKind.Local).AddTicks(1721));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 222,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 450, DateTimeKind.Local).AddTicks(1729));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 223,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 450, DateTimeKind.Local).AddTicks(1737));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 224,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 450, DateTimeKind.Local).AddTicks(1745));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 225,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 450, DateTimeKind.Local).AddTicks(1753));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 226,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 450, DateTimeKind.Local).AddTicks(1761));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 227,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 450, DateTimeKind.Local).AddTicks(1769));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 228,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 450, DateTimeKind.Local).AddTicks(1776));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 436, DateTimeKind.Local).AddTicks(7998));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 436, DateTimeKind.Local).AddTicks(8418));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 436, DateTimeKind.Local).AddTicks(8433));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 436, DateTimeKind.Local).AddTicks(8442));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 436, DateTimeKind.Local).AddTicks(8449));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 436, DateTimeKind.Local).AddTicks(8461));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 436, DateTimeKind.Local).AddTicks(8468));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 436, DateTimeKind.Local).AddTicks(8474));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 436, DateTimeKind.Local).AddTicks(8481));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 436, DateTimeKind.Local).AddTicks(8489));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 436, DateTimeKind.Local).AddTicks(8496));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 436, DateTimeKind.Local).AddTicks(8502));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 13,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 436, DateTimeKind.Local).AddTicks(8509));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 14,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 436, DateTimeKind.Local).AddTicks(8515));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 15,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 436, DateTimeKind.Local).AddTicks(8522));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 16,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 436, DateTimeKind.Local).AddTicks(8529));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 17,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 436, DateTimeKind.Local).AddTicks(8536));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 18,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 436, DateTimeKind.Local).AddTicks(8545));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 19,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 436, DateTimeKind.Local).AddTicks(8551));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 20,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 436, DateTimeKind.Local).AddTicks(8557));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 21,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 436, DateTimeKind.Local).AddTicks(8564));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 22,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 436, DateTimeKind.Local).AddTicks(8570));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 23,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 436, DateTimeKind.Local).AddTicks(8577));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 24,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 436, DateTimeKind.Local).AddTicks(8583));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 25,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 436, DateTimeKind.Local).AddTicks(8590));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 26,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 436, DateTimeKind.Local).AddTicks(8596));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 27,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 436, DateTimeKind.Local).AddTicks(8602));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 28,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 436, DateTimeKind.Local).AddTicks(8608));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 29,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 436, DateTimeKind.Local).AddTicks(8615));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 30,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 436, DateTimeKind.Local).AddTicks(8621));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 31,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 436, DateTimeKind.Local).AddTicks(8627));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 32,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 436, DateTimeKind.Local).AddTicks(8635));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 33,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 436, DateTimeKind.Local).AddTicks(8641));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 34,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 436, DateTimeKind.Local).AddTicks(8650));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 35,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 436, DateTimeKind.Local).AddTicks(8656));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 36,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 436, DateTimeKind.Local).AddTicks(8663));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 37,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 436, DateTimeKind.Local).AddTicks(8669));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 38,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 436, DateTimeKind.Local).AddTicks(8675));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 39,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 436, DateTimeKind.Local).AddTicks(8682));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 40,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 436, DateTimeKind.Local).AddTicks(8688));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 41,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 436, DateTimeKind.Local).AddTicks(8694));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 42,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 436, DateTimeKind.Local).AddTicks(8700));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 43,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 436, DateTimeKind.Local).AddTicks(8707));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 44,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 436, DateTimeKind.Local).AddTicks(8713));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 45,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 436, DateTimeKind.Local).AddTicks(8719));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 46,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 436, DateTimeKind.Local).AddTicks(8725));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 47,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 436, DateTimeKind.Local).AddTicks(8732));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 48,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 436, DateTimeKind.Local).AddTicks(8738));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 49,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 436, DateTimeKind.Local).AddTicks(8812));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 50,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 436, DateTimeKind.Local).AddTicks(8819));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 51,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 436, DateTimeKind.Local).AddTicks(8826));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 52,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 436, DateTimeKind.Local).AddTicks(8832));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 53,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 436, DateTimeKind.Local).AddTicks(8839));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 54,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 436, DateTimeKind.Local).AddTicks(8845));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 55,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 436, DateTimeKind.Local).AddTicks(8852));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 56,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 436, DateTimeKind.Local).AddTicks(8858));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 57,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 436, DateTimeKind.Local).AddTicks(8864));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 58,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 436, DateTimeKind.Local).AddTicks(8871));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 59,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 436, DateTimeKind.Local).AddTicks(8878));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 60,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 436, DateTimeKind.Local).AddTicks(8884));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 61,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 436, DateTimeKind.Local).AddTicks(8890));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 62,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 436, DateTimeKind.Local).AddTicks(8897));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 63,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 436, DateTimeKind.Local).AddTicks(8903));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 64,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 436, DateTimeKind.Local).AddTicks(8910));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 65,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 436, DateTimeKind.Local).AddTicks(8916));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 66,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 436, DateTimeKind.Local).AddTicks(8925));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 67,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 436, DateTimeKind.Local).AddTicks(8931));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 68,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 436, DateTimeKind.Local).AddTicks(8937));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 69,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 436, DateTimeKind.Local).AddTicks(8944));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 70,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 436, DateTimeKind.Local).AddTicks(8951));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 71,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 436, DateTimeKind.Local).AddTicks(8958));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 72,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 436, DateTimeKind.Local).AddTicks(8964));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 73,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 436, DateTimeKind.Local).AddTicks(8970));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 74,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 436, DateTimeKind.Local).AddTicks(8977));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 75,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 436, DateTimeKind.Local).AddTicks(8983));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 76,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 436, DateTimeKind.Local).AddTicks(8989));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 77,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 436, DateTimeKind.Local).AddTicks(8996));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 78,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 436, DateTimeKind.Local).AddTicks(9002));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 79,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 436, DateTimeKind.Local).AddTicks(9008));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 80,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 436, DateTimeKind.Local).AddTicks(9015));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 81,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 436, DateTimeKind.Local).AddTicks(9021));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 82,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 436, DateTimeKind.Local).AddTicks(9028));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 83,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 436, DateTimeKind.Local).AddTicks(9034));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 84,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 436, DateTimeKind.Local).AddTicks(9041));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 85,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 436, DateTimeKind.Local).AddTicks(9047));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 86,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 436, DateTimeKind.Local).AddTicks(9053));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 87,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 436, DateTimeKind.Local).AddTicks(9060));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 88,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 436, DateTimeKind.Local).AddTicks(9066));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 89,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 436, DateTimeKind.Local).AddTicks(9073));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 90,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 436, DateTimeKind.Local).AddTicks(9079));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 91,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 436, DateTimeKind.Local).AddTicks(9085));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 92,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 436, DateTimeKind.Local).AddTicks(9092));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 93,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 436, DateTimeKind.Local).AddTicks(9098));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 94,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 436, DateTimeKind.Local).AddTicks(9104));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 95,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 436, DateTimeKind.Local).AddTicks(9110));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 96,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 436, DateTimeKind.Local).AddTicks(9116));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 97,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 436, DateTimeKind.Local).AddTicks(9123));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 98,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 436, DateTimeKind.Local).AddTicks(9129));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 99,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 436, DateTimeKind.Local).AddTicks(9135));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 100,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 436, DateTimeKind.Local).AddTicks(9142));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 101,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 436, DateTimeKind.Local).AddTicks(9148));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 102,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 436, DateTimeKind.Local).AddTicks(9155));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 103,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 436, DateTimeKind.Local).AddTicks(9161));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 104,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 436, DateTimeKind.Local).AddTicks(9167));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 105,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 436, DateTimeKind.Local).AddTicks(9173));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 106,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 436, DateTimeKind.Local).AddTicks(9180));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 107,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 436, DateTimeKind.Local).AddTicks(9186));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 108,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 436, DateTimeKind.Local).AddTicks(9192));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 109,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 436, DateTimeKind.Local).AddTicks(9198));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 110,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 436, DateTimeKind.Local).AddTicks(9205));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 111,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 436, DateTimeKind.Local).AddTicks(9211));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 112,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 436, DateTimeKind.Local).AddTicks(9218));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 113,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 436, DateTimeKind.Local).AddTicks(9225));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 114,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 436, DateTimeKind.Local).AddTicks(9231));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 115,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 436, DateTimeKind.Local).AddTicks(9237));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 116,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 436, DateTimeKind.Local).AddTicks(9243));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 117,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 436, DateTimeKind.Local).AddTicks(9250));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 118,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 436, DateTimeKind.Local).AddTicks(9295));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 119,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 436, DateTimeKind.Local).AddTicks(9301));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 120,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 436, DateTimeKind.Local).AddTicks(9308));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 121,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 436, DateTimeKind.Local).AddTicks(9314));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 122,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 436, DateTimeKind.Local).AddTicks(9320));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 123,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 436, DateTimeKind.Local).AddTicks(9328));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 124,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 436, DateTimeKind.Local).AddTicks(9334));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 125,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 436, DateTimeKind.Local).AddTicks(9340));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 126,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 436, DateTimeKind.Local).AddTicks(9346));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 127,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 436, DateTimeKind.Local).AddTicks(9353));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 128,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 436, DateTimeKind.Local).AddTicks(9359));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 129,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 436, DateTimeKind.Local).AddTicks(9366));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 130,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 436, DateTimeKind.Local).AddTicks(9374));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 131,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 436, DateTimeKind.Local).AddTicks(9381));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 132,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 436, DateTimeKind.Local).AddTicks(9387));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 133,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 436, DateTimeKind.Local).AddTicks(9394));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 134,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 436, DateTimeKind.Local).AddTicks(9400));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 135,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 436, DateTimeKind.Local).AddTicks(9406));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 136,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 436, DateTimeKind.Local).AddTicks(9412));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 137,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 436, DateTimeKind.Local).AddTicks(9419));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 138,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 436, DateTimeKind.Local).AddTicks(9425));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 139,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 436, DateTimeKind.Local).AddTicks(9432));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 140,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 436, DateTimeKind.Local).AddTicks(9438));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 141,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 436, DateTimeKind.Local).AddTicks(9444));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 142,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 436, DateTimeKind.Local).AddTicks(9450));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 143,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 436, DateTimeKind.Local).AddTicks(9457));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 144,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 436, DateTimeKind.Local).AddTicks(9463));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 145,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 436, DateTimeKind.Local).AddTicks(9470));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 146,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 436, DateTimeKind.Local).AddTicks(9476));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 147,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 436, DateTimeKind.Local).AddTicks(9482));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 148,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 436, DateTimeKind.Local).AddTicks(9489));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 149,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 436, DateTimeKind.Local).AddTicks(9495));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 150,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 436, DateTimeKind.Local).AddTicks(9501));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 151,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 436, DateTimeKind.Local).AddTicks(9508));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 152,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 436, DateTimeKind.Local).AddTicks(9515));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 153,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 436, DateTimeKind.Local).AddTicks(9521));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 154,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 436, DateTimeKind.Local).AddTicks(9528));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 155,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 436, DateTimeKind.Local).AddTicks(9534));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 156,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 436, DateTimeKind.Local).AddTicks(9540));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 157,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 436, DateTimeKind.Local).AddTicks(9547));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 158,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 436, DateTimeKind.Local).AddTicks(9553));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 159,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 436, DateTimeKind.Local).AddTicks(9559));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 160,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 436, DateTimeKind.Local).AddTicks(9566));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 161,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 436, DateTimeKind.Local).AddTicks(9572));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 162,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 436, DateTimeKind.Local).AddTicks(9578));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 479, DateTimeKind.Local).AddTicks(8547));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 479, DateTimeKind.Local).AddTicks(8797));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 479, DateTimeKind.Local).AddTicks(8836));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 479, DateTimeKind.Local).AddTicks(8808));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 479, DateTimeKind.Local).AddTicks(8844));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 479, DateTimeKind.Local).AddTicks(8864));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 479, DateTimeKind.Local).AddTicks(8874));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 479, DateTimeKind.Local).AddTicks(8882));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 479, DateTimeKind.Local).AddTicks(8892));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 479, DateTimeKind.Local).AddTicks(8901));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 479, DateTimeKind.Local).AddTicks(8967));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 479, DateTimeKind.Local).AddTicks(8978));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 13,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 479, DateTimeKind.Local).AddTicks(8987));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 14,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 479, DateTimeKind.Local).AddTicks(8997));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 15,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 479, DateTimeKind.Local).AddTicks(8818));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 16,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 479, DateTimeKind.Local).AddTicks(8783));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 17,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 479, DateTimeKind.Local).AddTicks(9008));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 18,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 479, DateTimeKind.Local).AddTicks(9017));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 19,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 479, DateTimeKind.Local).AddTicks(9026));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 20,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 479, DateTimeKind.Local).AddTicks(9036));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 22,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 479, DateTimeKind.Local).AddTicks(9124));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 23,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 479, DateTimeKind.Local).AddTicks(9105));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 24,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 479, DateTimeKind.Local).AddTicks(9045));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 25,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 479, DateTimeKind.Local).AddTicks(9115));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 26,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 479, DateTimeKind.Local).AddTicks(9133));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 27,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 479, DateTimeKind.Local).AddTicks(9143));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 28,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 479, DateTimeKind.Local).AddTicks(9151));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 30,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 479, DateTimeKind.Local).AddTicks(9160));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 31,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 479, DateTimeKind.Local).AddTicks(9168));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 32,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 479, DateTimeKind.Local).AddTicks(9176));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 33,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 479, DateTimeKind.Local).AddTicks(9185));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 34,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 479, DateTimeKind.Local).AddTicks(9194));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 36,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 479, DateTimeKind.Local).AddTicks(9205));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 37,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 479, DateTimeKind.Local).AddTicks(9214));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 38,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 479, DateTimeKind.Local).AddTicks(9223));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 39,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 479, DateTimeKind.Local).AddTicks(8855));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 40,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 479, DateTimeKind.Local).AddTicks(9233));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 41,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 479, DateTimeKind.Local).AddTicks(9243));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 42,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 479, DateTimeKind.Local).AddTicks(9251));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 43,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 479, DateTimeKind.Local).AddTicks(9259));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 44,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 479, DateTimeKind.Local).AddTicks(9269));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 45,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 479, DateTimeKind.Local).AddTicks(9279));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 46,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 479, DateTimeKind.Local).AddTicks(9287));

            migrationBuilder.UpdateData(
                table: "DeductionTypes",
                keyColumn: "DeductionTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 500, DateTimeKind.Local).AddTicks(4942));

            migrationBuilder.UpdateData(
                table: "DeductionTypes",
                keyColumn: "DeductionTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 500, DateTimeKind.Local).AddTicks(5212));

            migrationBuilder.UpdateData(
                table: "DeductionTypes",
                keyColumn: "DeductionTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 500, DateTimeKind.Local).AddTicks(5227));

            migrationBuilder.UpdateData(
                table: "DocumentFormats",
                keyColumn: "DocumentFormatID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 457, DateTimeKind.Local).AddTicks(8898));

            migrationBuilder.UpdateData(
                table: "DocumentFormats",
                keyColumn: "DocumentFormatID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 457, DateTimeKind.Local).AddTicks(9138));

            migrationBuilder.UpdateData(
                table: "DocumentFormats",
                keyColumn: "DocumentFormatID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 457, DateTimeKind.Local).AddTicks(9148));

            migrationBuilder.UpdateData(
                table: "DocumentFormats",
                keyColumn: "DocumentFormatID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 457, DateTimeKind.Local).AddTicks(9153));

            migrationBuilder.UpdateData(
                table: "DocumentFormats",
                keyColumn: "DocumentFormatID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 457, DateTimeKind.Local).AddTicks(9157));

            migrationBuilder.UpdateData(
                table: "DocumentFormats",
                keyColumn: "DocumentFormatID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 457, DateTimeKind.Local).AddTicks(9165));

            migrationBuilder.UpdateData(
                table: "DocumentTypes",
                keyColumn: "DocumentTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 459, DateTimeKind.Local).AddTicks(8256));

            migrationBuilder.UpdateData(
                table: "DocumentTypes",
                keyColumn: "DocumentTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 459, DateTimeKind.Local).AddTicks(8796));

            migrationBuilder.UpdateData(
                table: "DocumentTypes",
                keyColumn: "DocumentTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 459, DateTimeKind.Local).AddTicks(8821));

            migrationBuilder.UpdateData(
                table: "DocumentTypes",
                keyColumn: "DocumentTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 459, DateTimeKind.Local).AddTicks(8828));

            migrationBuilder.UpdateData(
                table: "EmailTemplates",
                keyColumn: "EmailTemplateID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 473, DateTimeKind.Local).AddTicks(5363));

            migrationBuilder.UpdateData(
                table: "EmailTypes",
                keyColumn: "EmailTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 472, DateTimeKind.Local).AddTicks(7831));

            migrationBuilder.UpdateData(
                table: "EmailTypes",
                keyColumn: "EmailTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 472, DateTimeKind.Local).AddTicks(8379));

            migrationBuilder.UpdateData(
                table: "EmailTypes",
                keyColumn: "EmailTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 472, DateTimeKind.Local).AddTicks(8401));

            migrationBuilder.UpdateData(
                table: "EmailTypes",
                keyColumn: "EmailTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 472, DateTimeKind.Local).AddTicks(8419));

            migrationBuilder.UpdateData(
                table: "FeatureFlags",
                keyColumn: "FeatureFlagID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 456, DateTimeKind.Local).AddTicks(3334));

            migrationBuilder.UpdateData(
                table: "FeatureFlags",
                keyColumn: "FeatureFlagID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 456, DateTimeKind.Local).AddTicks(3571));

            migrationBuilder.UpdateData(
                table: "FeatureFlags",
                keyColumn: "FeatureFlagID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 456, DateTimeKind.Local).AddTicks(3584));

            migrationBuilder.UpdateData(
                table: "Frequencies",
                keyColumn: "FrequencyID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 439, DateTimeKind.Local).AddTicks(3257));

            migrationBuilder.UpdateData(
                table: "Frequencies",
                keyColumn: "FrequencyID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 439, DateTimeKind.Local).AddTicks(3825));

            migrationBuilder.UpdateData(
                table: "FundSources",
                keyColumn: "FundSourceID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 504, DateTimeKind.Local).AddTicks(266));

            migrationBuilder.UpdateData(
                table: "FundSources",
                keyColumn: "FundSourceID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 504, DateTimeKind.Local).AddTicks(556));

            migrationBuilder.UpdateData(
                table: "FundSources",
                keyColumn: "FundSourceID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 504, DateTimeKind.Local).AddTicks(569));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "GenderID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 446, DateTimeKind.Local).AddTicks(8637));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "GenderID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 446, DateTimeKind.Local).AddTicks(8765));

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "InvoiceStatusID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 494, DateTimeKind.Local).AddTicks(3408));

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "InvoiceStatusID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 494, DateTimeKind.Local).AddTicks(3641));

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "InvoiceStatusID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 494, DateTimeKind.Local).AddTicks(3651));

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "InvoiceStatusID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 494, DateTimeKind.Local).AddTicks(3655));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 498, DateTimeKind.Local).AddTicks(3489));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 498, DateTimeKind.Local).AddTicks(3617));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 498, DateTimeKind.Local).AddTicks(3624));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 498, DateTimeKind.Local).AddTicks(3630));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 498, DateTimeKind.Local).AddTicks(3636));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 498, DateTimeKind.Local).AddTicks(3643));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 498, DateTimeKind.Local).AddTicks(3648));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 498, DateTimeKind.Local).AddTicks(3652));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 498, DateTimeKind.Local).AddTicks(3657));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 498, DateTimeKind.Local).AddTicks(3663));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 498, DateTimeKind.Local).AddTicks(3668));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 498, DateTimeKind.Local).AddTicks(3673));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 13,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 498, DateTimeKind.Local).AddTicks(3677));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 14,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 498, DateTimeKind.Local).AddTicks(3681));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 15,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 498, DateTimeKind.Local).AddTicks(3884));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 16,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 498, DateTimeKind.Local).AddTicks(3902));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 17,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 498, DateTimeKind.Local).AddTicks(3907));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 18,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 498, DateTimeKind.Local).AddTicks(3915));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 19,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 498, DateTimeKind.Local).AddTicks(3920));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 20,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 498, DateTimeKind.Local).AddTicks(3924));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 21,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 498, DateTimeKind.Local).AddTicks(3929));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 22,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 498, DateTimeKind.Local).AddTicks(3933));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 23,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 498, DateTimeKind.Local).AddTicks(3941));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 24,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 498, DateTimeKind.Local).AddTicks(3947));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 25,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 498, DateTimeKind.Local).AddTicks(3954));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 26,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 498, DateTimeKind.Local).AddTicks(3961));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 27,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 498, DateTimeKind.Local).AddTicks(3968));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 28,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 498, DateTimeKind.Local).AddTicks(3975));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 29,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 498, DateTimeKind.Local).AddTicks(3981));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 30,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 498, DateTimeKind.Local).AddTicks(3988));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 31,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 498, DateTimeKind.Local).AddTicks(3996));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 32,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 498, DateTimeKind.Local).AddTicks(4003));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 33,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 498, DateTimeKind.Local).AddTicks(4010));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 34,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 498, DateTimeKind.Local).AddTicks(4069));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 35,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 498, DateTimeKind.Local).AddTicks(4075));

            migrationBuilder.UpdateData(
                table: "Layouts",
                keyColumn: "LayoutID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 495, DateTimeKind.Local).AddTicks(9774));

            migrationBuilder.UpdateData(
                table: "Layouts",
                keyColumn: "LayoutID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 496, DateTimeKind.Local).AddTicks(5));

            migrationBuilder.UpdateData(
                table: "Layouts",
                keyColumn: "LayoutID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 496, DateTimeKind.Local).AddTicks(17));

            migrationBuilder.UpdateData(
                table: "Layouts",
                keyColumn: "LayoutID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 496, DateTimeKind.Local).AddTicks(24));

            migrationBuilder.UpdateData(
                table: "Layouts",
                keyColumn: "LayoutID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 496, DateTimeKind.Local).AddTicks(29));

            migrationBuilder.UpdateData(
                table: "Layouts",
                keyColumn: "LayoutID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 496, DateTimeKind.Local).AddTicks(37));

            migrationBuilder.UpdateData(
                table: "Layouts",
                keyColumn: "LayoutID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 496, DateTimeKind.Local).AddTicks(92));

            migrationBuilder.UpdateData(
                table: "Layouts",
                keyColumn: "LayoutID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 496, DateTimeKind.Local).AddTicks(97));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 462, DateTimeKind.Local).AddTicks(6559));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 462, DateTimeKind.Local).AddTicks(7190));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 462, DateTimeKind.Local).AddTicks(7214));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 462, DateTimeKind.Local).AddTicks(7229));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 462, DateTimeKind.Local).AddTicks(7243));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 462, DateTimeKind.Local).AddTicks(7331));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 462, DateTimeKind.Local).AddTicks(7265));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 462, DateTimeKind.Local).AddTicks(7286));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 999,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 462, DateTimeKind.Local).AddTicks(7314));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 9998,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 462, DateTimeKind.Local).AddTicks(7299));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 465, DateTimeKind.Local).AddTicks(1531));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 465, DateTimeKind.Local).AddTicks(1781));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 465, DateTimeKind.Local).AddTicks(1929));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 465, DateTimeKind.Local).AddTicks(1992));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 465, DateTimeKind.Local).AddTicks(2005));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 465, DateTimeKind.Local).AddTicks(2040));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 465, DateTimeKind.Local).AddTicks(2051));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 465, DateTimeKind.Local).AddTicks(2063));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 465, DateTimeKind.Local).AddTicks(2074));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 9994,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 465, DateTimeKind.Local).AddTicks(2088));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 9995,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 465, DateTimeKind.Local).AddTicks(2099));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 9996,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 465, DateTimeKind.Local).AddTicks(2110));

            migrationBuilder.UpdateData(
                table: "PaymentStatus",
                keyColumn: "PaymentStatusID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 426, DateTimeKind.Local).AddTicks(8300));

            migrationBuilder.UpdateData(
                table: "PaymentStatus",
                keyColumn: "PaymentStatusID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 426, DateTimeKind.Local).AddTicks(8554));

            migrationBuilder.UpdateData(
                table: "PaymentStatus",
                keyColumn: "PaymentStatusID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 426, DateTimeKind.Local).AddTicks(8567));

            migrationBuilder.UpdateData(
                table: "PaymentStatus",
                keyColumn: "PaymentStatusID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 426, DateTimeKind.Local).AddTicks(8572));

            migrationBuilder.UpdateData(
                table: "PaymentStatus",
                keyColumn: "PaymentStatusID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 426, DateTimeKind.Local).AddTicks(8577));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 424, DateTimeKind.Local).AddTicks(7024));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 424, DateTimeKind.Local).AddTicks(7284));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 424, DateTimeKind.Local).AddTicks(7295));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 424, DateTimeKind.Local).AddTicks(7299));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 424, DateTimeKind.Local).AddTicks(7305));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 424, DateTimeKind.Local).AddTicks(7311));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 424, DateTimeKind.Local).AddTicks(7316));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 424, DateTimeKind.Local).AddTicks(7320));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 424, DateTimeKind.Local).AddTicks(7324));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 424, DateTimeKind.Local).AddTicks(7330));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 424, DateTimeKind.Local).AddTicks(7335));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 424, DateTimeKind.Local).AddTicks(7340));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 13,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 424, DateTimeKind.Local).AddTicks(7344));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 14,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 424, DateTimeKind.Local).AddTicks(7348));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 15,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 424, DateTimeKind.Local).AddTicks(7352));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 16,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 424, DateTimeKind.Local).AddTicks(7357));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 17,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 424, DateTimeKind.Local).AddTicks(7361));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 18,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 424, DateTimeKind.Local).AddTicks(7367));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 19,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 424, DateTimeKind.Local).AddTicks(7370));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 20,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 424, DateTimeKind.Local).AddTicks(7375));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 21,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 424, DateTimeKind.Local).AddTicks(7379));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 22,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 424, DateTimeKind.Local).AddTicks(7383));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 23,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 424, DateTimeKind.Local).AddTicks(7388));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 24,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 424, DateTimeKind.Local).AddTicks(7392));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 25,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 424, DateTimeKind.Local).AddTicks(7396));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 26,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 424, DateTimeKind.Local).AddTicks(7400));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 27,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 424, DateTimeKind.Local).AddTicks(7404));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 28,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 424, DateTimeKind.Local).AddTicks(7409));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 29,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 424, DateTimeKind.Local).AddTicks(7413));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 30,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 424, DateTimeKind.Local).AddTicks(7417));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 31,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 424, DateTimeKind.Local).AddTicks(7422));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 32,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 424, DateTimeKind.Local).AddTicks(7427));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 33,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 424, DateTimeKind.Local).AddTicks(7431));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 34,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 424, DateTimeKind.Local).AddTicks(7465));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 35,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 424, DateTimeKind.Local).AddTicks(7470));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 36,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 424, DateTimeKind.Local).AddTicks(7474));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 37,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 424, DateTimeKind.Local).AddTicks(7479));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 38,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 424, DateTimeKind.Local).AddTicks(7483));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 39,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 424, DateTimeKind.Local).AddTicks(7487));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 40,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 424, DateTimeKind.Local).AddTicks(7492));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 41,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 424, DateTimeKind.Local).AddTicks(7495));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 42,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 424, DateTimeKind.Local).AddTicks(7499));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 43,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 424, DateTimeKind.Local).AddTicks(7504));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 44,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 424, DateTimeKind.Local).AddTicks(7508));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 45,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 424, DateTimeKind.Local).AddTicks(7513));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 46,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 424, DateTimeKind.Local).AddTicks(7517));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 47,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 424, DateTimeKind.Local).AddTicks(7522));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 48,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 424, DateTimeKind.Local).AddTicks(7526));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 49,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 424, DateTimeKind.Local).AddTicks(7530));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 50,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 424, DateTimeKind.Local).AddTicks(7534));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 51,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 424, DateTimeKind.Local).AddTicks(7538));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 52,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 424, DateTimeKind.Local).AddTicks(7543));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 53,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 424, DateTimeKind.Local).AddTicks(7547));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 54,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 424, DateTimeKind.Local).AddTicks(7550));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 55,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 424, DateTimeKind.Local).AddTicks(7554));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 56,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 424, DateTimeKind.Local).AddTicks(7559));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 57,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 424, DateTimeKind.Local).AddTicks(7563));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 58,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 424, DateTimeKind.Local).AddTicks(7567));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 59,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 424, DateTimeKind.Local).AddTicks(7571));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 60,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 424, DateTimeKind.Local).AddTicks(7576));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 61,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 424, DateTimeKind.Local).AddTicks(7581));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 62,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 424, DateTimeKind.Local).AddTicks(7585));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 63,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 424, DateTimeKind.Local).AddTicks(7589));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 64,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 424, DateTimeKind.Local).AddTicks(7594));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 65,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 424, DateTimeKind.Local).AddTicks(7598));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 66,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 424, DateTimeKind.Local).AddTicks(7603));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 67,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 424, DateTimeKind.Local).AddTicks(7607));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 68,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 424, DateTimeKind.Local).AddTicks(7611));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 69,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 424, DateTimeKind.Local).AddTicks(7615));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 70,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 424, DateTimeKind.Local).AddTicks(7619));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 71,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 424, DateTimeKind.Local).AddTicks(7623));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 72,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 424, DateTimeKind.Local).AddTicks(7627));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 73,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 424, DateTimeKind.Local).AddTicks(7652));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 74,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 424, DateTimeKind.Local).AddTicks(7657));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 75,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 424, DateTimeKind.Local).AddTicks(7661));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 76,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 424, DateTimeKind.Local).AddTicks(7666));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 77,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 424, DateTimeKind.Local).AddTicks(7669));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 78,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 424, DateTimeKind.Local).AddTicks(7674));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 79,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 424, DateTimeKind.Local).AddTicks(7678));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 80,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 424, DateTimeKind.Local).AddTicks(7684));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 81,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 424, DateTimeKind.Local).AddTicks(7687));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 82,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 424, DateTimeKind.Local).AddTicks(7692));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 83,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 424, DateTimeKind.Local).AddTicks(7696));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 84,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 424, DateTimeKind.Local).AddTicks(7700));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 85,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 424, DateTimeKind.Local).AddTicks(7704));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 86,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 424, DateTimeKind.Local).AddTicks(7708));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 87,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 424, DateTimeKind.Local).AddTicks(7712));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 88,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 424, DateTimeKind.Local).AddTicks(7717));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 89,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 424, DateTimeKind.Local).AddTicks(7720));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 90,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 424, DateTimeKind.Local).AddTicks(7724));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 91,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 424, DateTimeKind.Local).AddTicks(7728));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 92,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 424, DateTimeKind.Local).AddTicks(7733));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 93,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 424, DateTimeKind.Local).AddTicks(7737));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 94,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 424, DateTimeKind.Local).AddTicks(7742));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 95,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 424, DateTimeKind.Local).AddTicks(7746));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 96,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 424, DateTimeKind.Local).AddTicks(7750));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 97,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 424, DateTimeKind.Local).AddTicks(7755));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 98,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 424, DateTimeKind.Local).AddTicks(7759));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 99,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 424, DateTimeKind.Local).AddTicks(7763));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 100,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 424, DateTimeKind.Local).AddTicks(7768));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 101,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 424, DateTimeKind.Local).AddTicks(7772));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 102,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 424, DateTimeKind.Local).AddTicks(7776));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 103,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 424, DateTimeKind.Local).AddTicks(7781));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 104,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 424, DateTimeKind.Local).AddTicks(7785));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 105,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 424, DateTimeKind.Local).AddTicks(7789));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 106,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 424, DateTimeKind.Local).AddTicks(7794));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 107,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 424, DateTimeKind.Local).AddTicks(7798));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 108,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 424, DateTimeKind.Local).AddTicks(7803));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 109,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 424, DateTimeKind.Local).AddTicks(7807));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 110,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 424, DateTimeKind.Local).AddTicks(7812));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 111,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 424, DateTimeKind.Local).AddTicks(7816));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 112,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 424, DateTimeKind.Local).AddTicks(7820));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 113,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 424, DateTimeKind.Local).AddTicks(7824));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 114,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 424, DateTimeKind.Local).AddTicks(7829));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 115,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 424, DateTimeKind.Local).AddTicks(7833));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 116,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 424, DateTimeKind.Local).AddTicks(7837));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 117,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 424, DateTimeKind.Local).AddTicks(7841));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 118,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 424, DateTimeKind.Local).AddTicks(7845));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 119,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 424, DateTimeKind.Local).AddTicks(7977));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 120,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 424, DateTimeKind.Local).AddTicks(7981));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 121,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 424, DateTimeKind.Local).AddTicks(7985));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 122,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 424, DateTimeKind.Local).AddTicks(7989));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 123,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 424, DateTimeKind.Local).AddTicks(7993));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 124,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 424, DateTimeKind.Local).AddTicks(7997));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 125,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 424, DateTimeKind.Local).AddTicks(8001));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 126,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 424, DateTimeKind.Local).AddTicks(8005));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 127,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 424, DateTimeKind.Local).AddTicks(8008));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 128,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 424, DateTimeKind.Local).AddTicks(8012));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 129,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 424, DateTimeKind.Local).AddTicks(8016));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 130,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 424, DateTimeKind.Local).AddTicks(8022));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 131,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 424, DateTimeKind.Local).AddTicks(8026));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 132,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 424, DateTimeKind.Local).AddTicks(8031));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 133,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 424, DateTimeKind.Local).AddTicks(8035));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 134,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 424, DateTimeKind.Local).AddTicks(8039));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 135,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 424, DateTimeKind.Local).AddTicks(8044));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 136,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 424, DateTimeKind.Local).AddTicks(8047));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 137,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 424, DateTimeKind.Local).AddTicks(8051));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 138,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 424, DateTimeKind.Local).AddTicks(8054));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 139,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 424, DateTimeKind.Local).AddTicks(8058));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 140,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 424, DateTimeKind.Local).AddTicks(8062));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 141,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 424, DateTimeKind.Local).AddTicks(8065));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 142,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 424, DateTimeKind.Local).AddTicks(8070));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 143,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 424, DateTimeKind.Local).AddTicks(8074));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 144,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 424, DateTimeKind.Local).AddTicks(8078));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 145,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 424, DateTimeKind.Local).AddTicks(8081));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 146,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 424, DateTimeKind.Local).AddTicks(8085));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 147,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 424, DateTimeKind.Local).AddTicks(8089));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 148,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 424, DateTimeKind.Local).AddTicks(8092));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 149,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 424, DateTimeKind.Local).AddTicks(8096));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 150,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 424, DateTimeKind.Local).AddTicks(8100));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 151,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 424, DateTimeKind.Local).AddTicks(8103));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 152,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 424, DateTimeKind.Local).AddTicks(8107));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 153,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 424, DateTimeKind.Local).AddTicks(8131));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 154,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 424, DateTimeKind.Local).AddTicks(8135));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 155,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 424, DateTimeKind.Local).AddTicks(8139));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 156,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 424, DateTimeKind.Local).AddTicks(8143));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 157,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 424, DateTimeKind.Local).AddTicks(8147));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 158,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 424, DateTimeKind.Local).AddTicks(8151));

            migrationBuilder.UpdateData(
                table: "PinCodeTypes",
                keyColumn: "PinCodeTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 505, DateTimeKind.Local).AddTicks(3628));

            migrationBuilder.UpdateData(
                table: "PinCodeTypes",
                keyColumn: "PinCodeTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 505, DateTimeKind.Local).AddTicks(3822));

            migrationBuilder.UpdateData(
                table: "PinCodeTypes",
                keyColumn: "PinCodeTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 505, DateTimeKind.Local).AddTicks(3831));

            migrationBuilder.UpdateData(
                table: "PriorityRanks",
                keyColumn: "PriorityRankID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 452, DateTimeKind.Local).AddTicks(7264));

            migrationBuilder.UpdateData(
                table: "PriorityRanks",
                keyColumn: "PriorityRankID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 452, DateTimeKind.Local).AddTicks(7794));

            migrationBuilder.UpdateData(
                table: "PriorityRanks",
                keyColumn: "PriorityRankID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 452, DateTimeKind.Local).AddTicks(7807));

            migrationBuilder.UpdateData(
                table: "PriorityRanks",
                keyColumn: "PriorityRankID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 452, DateTimeKind.Local).AddTicks(7813));

            migrationBuilder.UpdateData(
                table: "RecordStatus",
                keyColumn: "RecordStatusID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 490, DateTimeKind.Local).AddTicks(7694));

            migrationBuilder.UpdateData(
                table: "RecordStatus",
                keyColumn: "RecordStatusID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 490, DateTimeKind.Local).AddTicks(8006));

            migrationBuilder.UpdateData(
                table: "RecordStatus",
                keyColumn: "RecordStatusID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 490, DateTimeKind.Local).AddTicks(8017));

            migrationBuilder.UpdateData(
                table: "RelationshipTypes",
                keyColumn: "RelationshipTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 443, DateTimeKind.Local).AddTicks(7793));

            migrationBuilder.UpdateData(
                table: "RelationshipTypes",
                keyColumn: "RelationshipTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 443, DateTimeKind.Local).AddTicks(7930));

            migrationBuilder.UpdateData(
                table: "RelationshipTypes",
                keyColumn: "RelationshipTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 443, DateTimeKind.Local).AddTicks(7939));

            migrationBuilder.UpdateData(
                table: "RelationshipTypes",
                keyColumn: "RelationshipTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 443, DateTimeKind.Local).AddTicks(7944));

            migrationBuilder.UpdateData(
                table: "RelationshipTypes",
                keyColumn: "RelationshipTypeID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 443, DateTimeKind.Local).AddTicks(7950));

            migrationBuilder.UpdateData(
                table: "RelationshipTypes",
                keyColumn: "RelationshipTypeID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 443, DateTimeKind.Local).AddTicks(7958));

            migrationBuilder.UpdateData(
                table: "RelationshipTypes",
                keyColumn: "RelationshipTypeID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 443, DateTimeKind.Local).AddTicks(7963));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 480, DateTimeKind.Local).AddTicks(4947));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 480, DateTimeKind.Local).AddTicks(5091));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 480, DateTimeKind.Local).AddTicks(5102));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 480, DateTimeKind.Local).AddTicks(5112));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 480, DateTimeKind.Local).AddTicks(5120));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 480, DateTimeKind.Local).AddTicks(5131));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 480, DateTimeKind.Local).AddTicks(5140));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 480, DateTimeKind.Local).AddTicks(5148));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 480, DateTimeKind.Local).AddTicks(5256));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 480, DateTimeKind.Local).AddTicks(5269));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 480, DateTimeKind.Local).AddTicks(5278));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 480, DateTimeKind.Local).AddTicks(5286));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 425, DateTimeKind.Local).AddTicks(2162));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 425, DateTimeKind.Local).AddTicks(2223));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 425, DateTimeKind.Local).AddTicks(2227));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 425, DateTimeKind.Local).AddTicks(2229));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 425, DateTimeKind.Local).AddTicks(2232));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 425, DateTimeKind.Local).AddTicks(2236));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 425, DateTimeKind.Local).AddTicks(2238));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 425, DateTimeKind.Local).AddTicks(2241));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 425, DateTimeKind.Local).AddTicks(2244));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 425, DateTimeKind.Local).AddTicks(2247));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 425, DateTimeKind.Local).AddTicks(2249));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 425, DateTimeKind.Local).AddTicks(2252));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 13,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 425, DateTimeKind.Local).AddTicks(2254));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 14,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 425, DateTimeKind.Local).AddTicks(2256));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 15,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 425, DateTimeKind.Local).AddTicks(2259));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 16,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 425, DateTimeKind.Local).AddTicks(2261));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 17,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 425, DateTimeKind.Local).AddTicks(2263));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 18,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 425, DateTimeKind.Local).AddTicks(2267));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 19,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 425, DateTimeKind.Local).AddTicks(2270));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 20,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 425, DateTimeKind.Local).AddTicks(2273));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 21,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 425, DateTimeKind.Local).AddTicks(2275));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 22,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 425, DateTimeKind.Local).AddTicks(2277));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 23,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 425, DateTimeKind.Local).AddTicks(2280));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 24,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 425, DateTimeKind.Local).AddTicks(2282));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 25,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 425, DateTimeKind.Local).AddTicks(2285));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 26,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 425, DateTimeKind.Local).AddTicks(2287));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 27,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 425, DateTimeKind.Local).AddTicks(2289));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 28,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 425, DateTimeKind.Local).AddTicks(2292));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 29,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 425, DateTimeKind.Local).AddTicks(2294));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 30,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 425, DateTimeKind.Local).AddTicks(2296));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 31,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 425, DateTimeKind.Local).AddTicks(2298));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 32,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 425, DateTimeKind.Local).AddTicks(2301));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 33,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 425, DateTimeKind.Local).AddTicks(2304));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 34,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 425, DateTimeKind.Local).AddTicks(2307));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 35,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 425, DateTimeKind.Local).AddTicks(2337));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 36,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 425, DateTimeKind.Local).AddTicks(2341));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 37,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 425, DateTimeKind.Local).AddTicks(2343));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 38,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 425, DateTimeKind.Local).AddTicks(2346));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 39,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 425, DateTimeKind.Local).AddTicks(2348));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 40,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 425, DateTimeKind.Local).AddTicks(2350));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 41,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 425, DateTimeKind.Local).AddTicks(2353));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 42,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 425, DateTimeKind.Local).AddTicks(2355));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 43,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 425, DateTimeKind.Local).AddTicks(2357));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 44,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 425, DateTimeKind.Local).AddTicks(2360));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 45,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 425, DateTimeKind.Local).AddTicks(2362));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 46,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 425, DateTimeKind.Local).AddTicks(2364));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 47,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 425, DateTimeKind.Local).AddTicks(2367));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 48,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 425, DateTimeKind.Local).AddTicks(2369));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 49,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 425, DateTimeKind.Local).AddTicks(2371));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 50,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 425, DateTimeKind.Local).AddTicks(2374));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 51,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 425, DateTimeKind.Local).AddTicks(2376));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 52,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 425, DateTimeKind.Local).AddTicks(2378));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 53,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 425, DateTimeKind.Local).AddTicks(2381));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 54,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 425, DateTimeKind.Local).AddTicks(2383));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 55,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 425, DateTimeKind.Local).AddTicks(2385));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 56,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 425, DateTimeKind.Local).AddTicks(2388));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 57,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 425, DateTimeKind.Local).AddTicks(2390));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 58,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 425, DateTimeKind.Local).AddTicks(2392));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 59,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 425, DateTimeKind.Local).AddTicks(2395));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 60,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 425, DateTimeKind.Local).AddTicks(2397));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 61,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 425, DateTimeKind.Local).AddTicks(2399));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 62,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 425, DateTimeKind.Local).AddTicks(2402));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 63,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 425, DateTimeKind.Local).AddTicks(2404));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 64,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 425, DateTimeKind.Local).AddTicks(2406));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 65,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 425, DateTimeKind.Local).AddTicks(2409));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 66,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 425, DateTimeKind.Local).AddTicks(2412));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 67,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 425, DateTimeKind.Local).AddTicks(2414));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 68,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 425, DateTimeKind.Local).AddTicks(2417));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 69,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 425, DateTimeKind.Local).AddTicks(2419));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 70,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 425, DateTimeKind.Local).AddTicks(2421));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 71,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 425, DateTimeKind.Local).AddTicks(2424));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 72,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 425, DateTimeKind.Local).AddTicks(2426));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 73,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 425, DateTimeKind.Local).AddTicks(2428));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 74,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 425, DateTimeKind.Local).AddTicks(2431));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 75,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 425, DateTimeKind.Local).AddTicks(2433));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 76,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 425, DateTimeKind.Local).AddTicks(2435));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 77,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 425, DateTimeKind.Local).AddTicks(2438));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 78,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 425, DateTimeKind.Local).AddTicks(2440));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 79,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 425, DateTimeKind.Local).AddTicks(2442));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 80,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 425, DateTimeKind.Local).AddTicks(2445));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 81,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 425, DateTimeKind.Local).AddTicks(2447));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 82,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 425, DateTimeKind.Local).AddTicks(2449));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 83,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 425, DateTimeKind.Local).AddTicks(2452));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 84,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 425, DateTimeKind.Local).AddTicks(2454));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 85,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 425, DateTimeKind.Local).AddTicks(2457));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 86,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 425, DateTimeKind.Local).AddTicks(2459));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 87,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 425, DateTimeKind.Local).AddTicks(2461));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 88,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 425, DateTimeKind.Local).AddTicks(2463));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 89,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 425, DateTimeKind.Local).AddTicks(2466));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 90,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 425, DateTimeKind.Local).AddTicks(2468));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 91,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 425, DateTimeKind.Local).AddTicks(2470));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 92,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 425, DateTimeKind.Local).AddTicks(2473));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 93,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 425, DateTimeKind.Local).AddTicks(2475));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 94,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 425, DateTimeKind.Local).AddTicks(2477));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 95,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 425, DateTimeKind.Local).AddTicks(2479));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 96,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 425, DateTimeKind.Local).AddTicks(2482));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 97,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 425, DateTimeKind.Local).AddTicks(2484));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 98,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 425, DateTimeKind.Local).AddTicks(2486));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 99,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 425, DateTimeKind.Local).AddTicks(2489));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 100,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 425, DateTimeKind.Local).AddTicks(2491));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 101,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 425, DateTimeKind.Local).AddTicks(2493));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 102,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 425, DateTimeKind.Local).AddTicks(2496));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 103,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 425, DateTimeKind.Local).AddTicks(2498));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 104,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 425, DateTimeKind.Local).AddTicks(2500));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 105,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 425, DateTimeKind.Local).AddTicks(2503));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 106,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 425, DateTimeKind.Local).AddTicks(2505));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 107,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 425, DateTimeKind.Local).AddTicks(2507));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 108,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 425, DateTimeKind.Local).AddTicks(2510));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 109,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 425, DateTimeKind.Local).AddTicks(2512));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 110,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 425, DateTimeKind.Local).AddTicks(2514));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 111,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 425, DateTimeKind.Local).AddTicks(2516));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 112,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 425, DateTimeKind.Local).AddTicks(2519));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 113,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 425, DateTimeKind.Local).AddTicks(2521));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 114,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 425, DateTimeKind.Local).AddTicks(2523));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 115,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 425, DateTimeKind.Local).AddTicks(2526));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 116,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 425, DateTimeKind.Local).AddTicks(2528));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 117,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 425, DateTimeKind.Local).AddTicks(2530));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 118,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 425, DateTimeKind.Local).AddTicks(2533));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 119,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 425, DateTimeKind.Local).AddTicks(2535));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 120,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 425, DateTimeKind.Local).AddTicks(2538));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 121,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 425, DateTimeKind.Local).AddTicks(2540));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 122,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 425, DateTimeKind.Local).AddTicks(2542));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 123,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 425, DateTimeKind.Local).AddTicks(2564));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 124,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 425, DateTimeKind.Local).AddTicks(2566));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 125,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 425, DateTimeKind.Local).AddTicks(2569));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 126,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 425, DateTimeKind.Local).AddTicks(2571));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 127,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 425, DateTimeKind.Local).AddTicks(2577));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 128,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 425, DateTimeKind.Local).AddTicks(2580));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 129,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 425, DateTimeKind.Local).AddTicks(2582));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 130,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 425, DateTimeKind.Local).AddTicks(2714));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 131,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 425, DateTimeKind.Local).AddTicks(2717));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 132,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 425, DateTimeKind.Local).AddTicks(2719));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 133,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 425, DateTimeKind.Local).AddTicks(2722));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 134,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 425, DateTimeKind.Local).AddTicks(2724));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 135,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 425, DateTimeKind.Local).AddTicks(2726));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 136,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 425, DateTimeKind.Local).AddTicks(2729));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 137,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 425, DateTimeKind.Local).AddTicks(2731));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 138,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 425, DateTimeKind.Local).AddTicks(2733));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 139,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 425, DateTimeKind.Local).AddTicks(2736));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 140,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 425, DateTimeKind.Local).AddTicks(2738));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 141,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 425, DateTimeKind.Local).AddTicks(2740));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 142,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 425, DateTimeKind.Local).AddTicks(2743));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 143,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 425, DateTimeKind.Local).AddTicks(2746));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 144,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 425, DateTimeKind.Local).AddTicks(2748));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 145,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 425, DateTimeKind.Local).AddTicks(2751));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 146,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 425, DateTimeKind.Local).AddTicks(2753));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 147,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 425, DateTimeKind.Local).AddTicks(2755));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 148,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 425, DateTimeKind.Local).AddTicks(2758));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 149,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 425, DateTimeKind.Local).AddTicks(2760));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 150,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 425, DateTimeKind.Local).AddTicks(2762));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 151,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 425, DateTimeKind.Local).AddTicks(2764));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 152,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 425, DateTimeKind.Local).AddTicks(2767));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 153,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 425, DateTimeKind.Local).AddTicks(2769));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 154,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 425, DateTimeKind.Local).AddTicks(2771));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 155,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 425, DateTimeKind.Local).AddTicks(2774));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 156,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 425, DateTimeKind.Local).AddTicks(2776));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 157,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 425, DateTimeKind.Local).AddTicks(2779));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 158,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 425, DateTimeKind.Local).AddTicks(2781));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 418, DateTimeKind.Local).AddTicks(3323));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 422, DateTimeKind.Local).AddTicks(3187));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 422, DateTimeKind.Local).AddTicks(3233));

            migrationBuilder.UpdateData(
                table: "StatementLists",
                keyColumn: "StatementID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 484, DateTimeKind.Local).AddTicks(6793));

            migrationBuilder.UpdateData(
                table: "StatementLists",
                keyColumn: "StatementID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 484, DateTimeKind.Local).AddTicks(7134));

            migrationBuilder.UpdateData(
                table: "StatementLists",
                keyColumn: "StatementID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 484, DateTimeKind.Local).AddTicks(7147));

            migrationBuilder.UpdateData(
                table: "StatementLists",
                keyColumn: "StatementID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 484, DateTimeKind.Local).AddTicks(7154));

            migrationBuilder.UpdateData(
                table: "TechnicalSupport",
                keyColumn: "TechnicalSupportID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 502, DateTimeKind.Local).AddTicks(3371));

            migrationBuilder.UpdateData(
                table: "TechnicalSupport",
                keyColumn: "TechnicalSupportID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 502, DateTimeKind.Local).AddTicks(4536));

            migrationBuilder.UpdateData(
                table: "TechnicalSupport",
                keyColumn: "TechnicalSupportID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 502, DateTimeKind.Local).AddTicks(4554));

            migrationBuilder.UpdateData(
                table: "TechnicalSupport",
                keyColumn: "TechnicalSupportID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 502, DateTimeKind.Local).AddTicks(4563));

            migrationBuilder.UpdateData(
                table: "TechnicalSupport",
                keyColumn: "TechnicalSupportID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 502, DateTimeKind.Local).AddTicks(4572));

            migrationBuilder.UpdateData(
                table: "TechnicalSupport",
                keyColumn: "TechnicalSupportID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 502, DateTimeKind.Local).AddTicks(4587));

            migrationBuilder.UpdateData(
                table: "TechnicalSupport",
                keyColumn: "TechnicalSupportID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 502, DateTimeKind.Local).AddTicks(4595));

            migrationBuilder.UpdateData(
                table: "Titles",
                keyColumn: "TitleID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 487, DateTimeKind.Local).AddTicks(946));

            migrationBuilder.UpdateData(
                table: "Titles",
                keyColumn: "TitleID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 487, DateTimeKind.Local).AddTicks(1475));

            migrationBuilder.UpdateData(
                table: "Titles",
                keyColumn: "TitleID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 487, DateTimeKind.Local).AddTicks(1494));

            migrationBuilder.UpdateData(
                table: "Titles",
                keyColumn: "TitleID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 487, DateTimeKind.Local).AddTicks(1505));

            migrationBuilder.UpdateData(
                table: "Titles",
                keyColumn: "TitleID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 487, DateTimeKind.Local).AddTicks(1515));

            migrationBuilder.UpdateData(
                table: "Titles",
                keyColumn: "TitleID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 487, DateTimeKind.Local).AddTicks(1533));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 430, DateTimeKind.Local).AddTicks(519));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 430, DateTimeKind.Local).AddTicks(2340));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 430, DateTimeKind.Local).AddTicks(2904));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 430, DateTimeKind.Local).AddTicks(3085));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 430, DateTimeKind.Local).AddTicks(3306));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 430, DateTimeKind.Local).AddTicks(3699));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 430, DateTimeKind.Local).AddTicks(3794));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 430, DateTimeKind.Local).AddTicks(3879));

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumns: new[] { "UserID", "RoleID" },
                keyValues: new object[] { 1, 1 },
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 460, DateTimeKind.Local).AddTicks(2191));

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumns: new[] { "UserID", "RoleID" },
                keyValues: new object[] { 2, 3 },
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 460, DateTimeKind.Local).AddTicks(2255));

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "UserTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 441, DateTimeKind.Local).AddTicks(9927));

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "UserTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 442, DateTimeKind.Local).AddTicks(669));

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "UserTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 442, DateTimeKind.Local).AddTicks(685));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 1,
                columns: new[] { "GrantAccessToTestEnvironment", "LastChangedDate", "UserName" },
                values: new object[] { false, new DateTime(2022, 3, 12, 12, 55, 2, 453, DateTimeKind.Local).AddTicks(3946), "SuperUser" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 2,
                columns: new[] { "FirstName", "IDNumber", "LastChangedDate", "LastName", "UserName" },
                values: new object[] { "John", "0000000000000", new DateTime(2022, 3, 12, 12, 55, 2, 454, DateTimeKind.Local).AddTicks(4955), "Jarani", "Employer" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 3,
                columns: new[] { "FirstName", "IDNumber", "LastChangedDate", "LastName", "UserName" },
                values: new object[] { "Ndini", "1111111111111", new DateTime(2022, 3, 12, 12, 55, 2, 454, DateTimeKind.Local).AddTicks(5322), "Ndadaro", "Employee" });

            migrationBuilder.UpdateData(
                table: "VariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 446, DateTimeKind.Local).AddTicks(905));

            migrationBuilder.UpdateData(
                table: "VariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 446, DateTimeKind.Local).AddTicks(1489));

            migrationBuilder.UpdateData(
                table: "VariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 446, DateTimeKind.Local).AddTicks(1507));

            migrationBuilder.UpdateData(
                table: "VariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 446, DateTimeKind.Local).AddTicks(1515));

            migrationBuilder.UpdateData(
                table: "VariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 446, DateTimeKind.Local).AddTicks(1522));

            migrationBuilder.UpdateData(
                table: "VariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 446, DateTimeKind.Local).AddTicks(1536));

            migrationBuilder.UpdateData(
                table: "VariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 446, DateTimeKind.Local).AddTicks(1548));

            migrationBuilder.UpdateData(
                table: "VariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 446, DateTimeKind.Local).AddTicks(1557));

            migrationBuilder.UpdateData(
                table: "VariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 446, DateTimeKind.Local).AddTicks(1564));
        }
    }
}
