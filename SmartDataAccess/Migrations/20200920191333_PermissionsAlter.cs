using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SmartDataAccess.Migrations
{
    public partial class PermissionsAlter : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "BankAccountTypes",
                keyColumn: "BankAccountTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 166, DateTimeKind.Local).AddTicks(2053));

            migrationBuilder.UpdateData(
                table: "BankAccountTypes",
                keyColumn: "BankAccountTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 166, DateTimeKind.Local).AddTicks(2503));

            migrationBuilder.UpdateData(
                table: "BankAccountTypes",
                keyColumn: "BankAccountTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 166, DateTimeKind.Local).AddTicks(2513));

            migrationBuilder.UpdateData(
                table: "BankAccountTypes",
                keyColumn: "BankAccountTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 166, DateTimeKind.Local).AddTicks(2518));

            migrationBuilder.UpdateData(
                table: "ContactTypes",
                keyColumn: "ContactTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 178, DateTimeKind.Local).AddTicks(7987));

            migrationBuilder.UpdateData(
                table: "ContactTypes",
                keyColumn: "ContactTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 178, DateTimeKind.Local).AddTicks(7982));

            migrationBuilder.UpdateData(
                table: "ContactTypes",
                keyColumn: "ContactTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 178, DateTimeKind.Local).AddTicks(7976));

            migrationBuilder.UpdateData(
                table: "ContactTypes",
                keyColumn: "ContactTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 178, DateTimeKind.Local).AddTicks(7847));

            migrationBuilder.UpdateData(
                table: "ContactTypes",
                keyColumn: "ContactTypeID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 178, DateTimeKind.Local).AddTicks(7990));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(4825));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(5304));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(5312));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(5322));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(5326));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(5334));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(5338));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(5342));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(5346));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(5351));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(5355));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(5358));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 13,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(5362));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 14,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(5365));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 15,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(5368));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 16,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(5373));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 17,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(5376));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 18,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(5382));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 19,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(5385));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 20,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(5389));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 21,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(5392));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 22,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(5396));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 23,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(5399));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 24,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(5402));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 25,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(5406));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 26,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(5409));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 27,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(5414));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 28,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(5417));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 29,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(5421));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 30,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(5426));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 31,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(5429));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 32,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(5433));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 33,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(5437));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 34,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(5442));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 35,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(5445));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 36,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(5449));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 37,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(5452));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 38,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(5455));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 39,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(5459));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 40,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(5463));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 41,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(5468));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 42,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(5471));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 43,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(5474));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 44,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(5478));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 45,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(5481));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 46,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(5485));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 47,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(5489));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 48,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(5494));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 49,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(5498));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 50,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(5502));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 51,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(5506));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 52,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(5510));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 53,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(5513));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 54,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(5517));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 55,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(5521));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 56,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(5525));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 57,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(5528));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 58,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(5531));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 59,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(5536));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 60,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(5556));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 61,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(5560));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 62,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(5564));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 63,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(5568));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 64,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(5572));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 65,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(5576));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 66,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(5582));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 67,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(5585));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 68,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(5590));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 69,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(5593));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 70,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(5596));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 71,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(5599));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 72,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(5604));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 73,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(5608));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 74,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(5612));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 75,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(5616));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 76,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(5619));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 77,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(5623));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 78,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(5626));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 79,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(5629));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 80,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(5633));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 81,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(5636));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 82,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(5640));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 83,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(5643));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 84,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(5647));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 85,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(5650));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 86,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(5654));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 87,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(5657));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 88,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(5661));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 89,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(5665));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 90,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(5669));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 91,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(5672));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 92,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(5675));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 93,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(5679));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 94,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(5683));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 95,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(5686));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 96,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(5689));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 97,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(5693));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 98,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(5696));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 99,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(5700));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 100,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(5703));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 101,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(5707));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 102,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(5711));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 103,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(5714));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 104,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(5718));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 105,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(5721));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 106,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(5724));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 107,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(5728));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 108,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(5731));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 109,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(5735));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 110,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(5738));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 111,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(5742));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 112,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(5746));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 113,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(5749));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 114,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(5753));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 115,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(5758));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 116,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(5761));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 117,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(5764));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 118,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(5768));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 119,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(5771));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 120,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(5774));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 121,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(5778));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 122,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(5781));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 123,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(5792));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 124,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(5795));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 125,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(5798));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 126,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(5802));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 127,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(5805));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 128,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(5808));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 129,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(5812));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 130,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(5817));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 131,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(5821));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 132,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(5825));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 133,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(5829));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 134,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(5832));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 135,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(5835));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 136,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(5839));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 137,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(5842));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 138,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(5847));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 139,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(5850));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 140,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(5854));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 141,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(5857));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 142,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(5860));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 143,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(5864));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 144,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(5868));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 145,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(5871));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 146,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(5875));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 147,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(5878));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 148,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(5881));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 149,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(5886));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 150,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(5890));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 151,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(5894));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 152,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(5897));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 153,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(5901));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 154,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(5904));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 155,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(5909));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 156,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(5912));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 157,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(5916));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 158,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(5919));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 159,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(5923));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 160,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(5926));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 161,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(5931));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 162,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(5934));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 163,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(5937));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 164,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(5941));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 165,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(5944));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 166,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(5948));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 167,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(5952));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 168,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(5955));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 169,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(5959));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 170,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(5962));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 171,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(5965));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 172,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(5969));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 173,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(5973));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 174,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(5978));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 175,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(5982));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 176,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(5993));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 177,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(5999));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 178,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(6002));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 179,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(6006));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 180,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(6011));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 181,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(6014));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 182,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(6018));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 183,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(6021));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 184,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(6025));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 185,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(6029));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 186,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(6032));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 187,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(6036));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 188,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(6039));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 189,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(6043));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 190,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(6047));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 191,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(6051));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 192,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(6054));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 193,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(6058));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 194,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(6061));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 195,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(6065));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 196,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(6068));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 197,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(6071));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 198,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(6075));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 199,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(6078));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 200,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(6082));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 201,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(6085));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 202,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(6089));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 203,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(6093));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 204,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(6096));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 205,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(6099));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 206,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(6103));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 207,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(6106));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 208,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(6110));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 209,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(6114));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 210,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(6118));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 211,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(6121));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 212,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(6124));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 213,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(6128));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 214,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(6132));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 215,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(6136));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 216,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(6140));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 217,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(6143));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 218,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(6147));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 219,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(6150));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 220,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(6153));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 221,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(6157));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 222,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(6161));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 223,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(6165));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 224,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(6168));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 225,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(6172));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 226,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(6176));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 227,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(6179));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 228,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 186, DateTimeKind.Local).AddTicks(6182));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 170, DateTimeKind.Local).AddTicks(1351));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 170, DateTimeKind.Local).AddTicks(1881));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 170, DateTimeKind.Local).AddTicks(1891));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 170, DateTimeKind.Local).AddTicks(1894));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 170, DateTimeKind.Local).AddTicks(1898));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 170, DateTimeKind.Local).AddTicks(1910));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 170, DateTimeKind.Local).AddTicks(1914));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 170, DateTimeKind.Local).AddTicks(1917));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 170, DateTimeKind.Local).AddTicks(1920));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 170, DateTimeKind.Local).AddTicks(1925));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 170, DateTimeKind.Local).AddTicks(1928));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 170, DateTimeKind.Local).AddTicks(1931));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 13,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 170, DateTimeKind.Local).AddTicks(1934));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 14,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 170, DateTimeKind.Local).AddTicks(1938));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 15,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 170, DateTimeKind.Local).AddTicks(1941));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 16,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 170, DateTimeKind.Local).AddTicks(1944));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 17,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 170, DateTimeKind.Local).AddTicks(1947));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 18,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 170, DateTimeKind.Local).AddTicks(1952));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 19,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 170, DateTimeKind.Local).AddTicks(1956));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 20,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 170, DateTimeKind.Local).AddTicks(1958));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 21,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 170, DateTimeKind.Local).AddTicks(1962));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 22,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 170, DateTimeKind.Local).AddTicks(1965));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 23,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 170, DateTimeKind.Local).AddTicks(1968));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 24,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 170, DateTimeKind.Local).AddTicks(1972));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 25,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 170, DateTimeKind.Local).AddTicks(1975));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 26,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 170, DateTimeKind.Local).AddTicks(1978));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 27,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 170, DateTimeKind.Local).AddTicks(1981));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 28,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 170, DateTimeKind.Local).AddTicks(1984));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 29,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 170, DateTimeKind.Local).AddTicks(1987));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 30,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 170, DateTimeKind.Local).AddTicks(1990));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 31,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 170, DateTimeKind.Local).AddTicks(1994));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 32,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 170, DateTimeKind.Local).AddTicks(2017));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 33,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 170, DateTimeKind.Local).AddTicks(2021));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 34,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 170, DateTimeKind.Local).AddTicks(2026));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 35,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 170, DateTimeKind.Local).AddTicks(2029));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 36,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 170, DateTimeKind.Local).AddTicks(2032));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 37,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 170, DateTimeKind.Local).AddTicks(2036));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 38,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 170, DateTimeKind.Local).AddTicks(2039));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 39,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 170, DateTimeKind.Local).AddTicks(2042));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 40,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 170, DateTimeKind.Local).AddTicks(2045));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 41,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 170, DateTimeKind.Local).AddTicks(2048));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 42,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 170, DateTimeKind.Local).AddTicks(2051));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 43,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 170, DateTimeKind.Local).AddTicks(2055));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 44,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 170, DateTimeKind.Local).AddTicks(2058));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 45,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 170, DateTimeKind.Local).AddTicks(2061));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 46,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 170, DateTimeKind.Local).AddTicks(2064));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 47,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 170, DateTimeKind.Local).AddTicks(2067));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 48,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 170, DateTimeKind.Local).AddTicks(2070));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 49,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 170, DateTimeKind.Local).AddTicks(2073));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 50,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 170, DateTimeKind.Local).AddTicks(2076));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 51,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 170, DateTimeKind.Local).AddTicks(2079));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 52,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 170, DateTimeKind.Local).AddTicks(2083));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 53,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 170, DateTimeKind.Local).AddTicks(2086));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 54,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 170, DateTimeKind.Local).AddTicks(2089));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 55,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 170, DateTimeKind.Local).AddTicks(2092));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 56,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 170, DateTimeKind.Local).AddTicks(2095));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 57,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 170, DateTimeKind.Local).AddTicks(2098));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 58,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 170, DateTimeKind.Local).AddTicks(2101));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 59,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 170, DateTimeKind.Local).AddTicks(2104));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 60,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 170, DateTimeKind.Local).AddTicks(2107));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 61,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 170, DateTimeKind.Local).AddTicks(2112));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 62,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 170, DateTimeKind.Local).AddTicks(2115));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 63,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 170, DateTimeKind.Local).AddTicks(2119));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 64,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 170, DateTimeKind.Local).AddTicks(2122));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 65,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 170, DateTimeKind.Local).AddTicks(2125));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 66,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 170, DateTimeKind.Local).AddTicks(2130));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 67,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 170, DateTimeKind.Local).AddTicks(2133));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 68,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 170, DateTimeKind.Local).AddTicks(2136));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 69,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 170, DateTimeKind.Local).AddTicks(2139));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 70,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 170, DateTimeKind.Local).AddTicks(2142));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 71,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 170, DateTimeKind.Local).AddTicks(2145));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 72,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 170, DateTimeKind.Local).AddTicks(2148));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 73,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 170, DateTimeKind.Local).AddTicks(2152));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 74,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 170, DateTimeKind.Local).AddTicks(2155));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 75,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 170, DateTimeKind.Local).AddTicks(2158));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 76,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 170, DateTimeKind.Local).AddTicks(2161));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 77,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 170, DateTimeKind.Local).AddTicks(2164));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 78,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 170, DateTimeKind.Local).AddTicks(2167));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 79,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 170, DateTimeKind.Local).AddTicks(2170));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 80,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 170, DateTimeKind.Local).AddTicks(2173));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 81,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 170, DateTimeKind.Local).AddTicks(2176));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 82,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 170, DateTimeKind.Local).AddTicks(2181));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 83,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 170, DateTimeKind.Local).AddTicks(2184));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 84,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 170, DateTimeKind.Local).AddTicks(2187));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 85,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 170, DateTimeKind.Local).AddTicks(2190));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 86,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 170, DateTimeKind.Local).AddTicks(2193));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 87,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 170, DateTimeKind.Local).AddTicks(2197));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 88,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 170, DateTimeKind.Local).AddTicks(2200));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 89,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 170, DateTimeKind.Local).AddTicks(2203));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 90,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 170, DateTimeKind.Local).AddTicks(2206));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 91,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 170, DateTimeKind.Local).AddTicks(2209));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 92,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 170, DateTimeKind.Local).AddTicks(2212));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 93,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 170, DateTimeKind.Local).AddTicks(2215));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 94,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 170, DateTimeKind.Local).AddTicks(2219));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 95,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 170, DateTimeKind.Local).AddTicks(2229));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 96,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 170, DateTimeKind.Local).AddTicks(2232));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 97,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 170, DateTimeKind.Local).AddTicks(2235));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 98,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 170, DateTimeKind.Local).AddTicks(2238));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 99,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 170, DateTimeKind.Local).AddTicks(2241));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 100,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 170, DateTimeKind.Local).AddTicks(2244));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 101,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 170, DateTimeKind.Local).AddTicks(2247));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 102,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 170, DateTimeKind.Local).AddTicks(2250));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 103,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 170, DateTimeKind.Local).AddTicks(2254));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 104,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 170, DateTimeKind.Local).AddTicks(2257));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 105,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 170, DateTimeKind.Local).AddTicks(2260));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 106,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 170, DateTimeKind.Local).AddTicks(2263));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 107,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 170, DateTimeKind.Local).AddTicks(2266));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 108,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 170, DateTimeKind.Local).AddTicks(2269));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 109,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 170, DateTimeKind.Local).AddTicks(2272));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 110,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 170, DateTimeKind.Local).AddTicks(2275));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 111,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 170, DateTimeKind.Local).AddTicks(2278));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 112,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 170, DateTimeKind.Local).AddTicks(2282));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 113,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 170, DateTimeKind.Local).AddTicks(2285));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 114,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 170, DateTimeKind.Local).AddTicks(2288));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 115,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 170, DateTimeKind.Local).AddTicks(2291));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 116,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 170, DateTimeKind.Local).AddTicks(2294));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 117,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 170, DateTimeKind.Local).AddTicks(2297));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 118,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 170, DateTimeKind.Local).AddTicks(2300));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 119,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 170, DateTimeKind.Local).AddTicks(2303));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 120,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 170, DateTimeKind.Local).AddTicks(2306));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 121,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 170, DateTimeKind.Local).AddTicks(2309));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 122,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 170, DateTimeKind.Local).AddTicks(2312));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 123,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 170, DateTimeKind.Local).AddTicks(2316));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 124,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 170, DateTimeKind.Local).AddTicks(2319));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 125,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 170, DateTimeKind.Local).AddTicks(2322));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 126,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 170, DateTimeKind.Local).AddTicks(2325));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 127,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 170, DateTimeKind.Local).AddTicks(2328));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 128,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 170, DateTimeKind.Local).AddTicks(2331));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 129,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 170, DateTimeKind.Local).AddTicks(2334));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 130,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 170, DateTimeKind.Local).AddTicks(2340));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 131,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 170, DateTimeKind.Local).AddTicks(2343));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 132,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 170, DateTimeKind.Local).AddTicks(2346));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 133,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 170, DateTimeKind.Local).AddTicks(2349));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 134,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 170, DateTimeKind.Local).AddTicks(2352));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 135,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 170, DateTimeKind.Local).AddTicks(2356));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 136,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 170, DateTimeKind.Local).AddTicks(2359));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 137,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 170, DateTimeKind.Local).AddTicks(2362));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 138,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 170, DateTimeKind.Local).AddTicks(2365));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 139,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 170, DateTimeKind.Local).AddTicks(2368));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 140,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 170, DateTimeKind.Local).AddTicks(2371));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 141,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 170, DateTimeKind.Local).AddTicks(2374));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 142,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 170, DateTimeKind.Local).AddTicks(2377));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 143,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 170, DateTimeKind.Local).AddTicks(2380));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 144,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 170, DateTimeKind.Local).AddTicks(2383));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 145,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 170, DateTimeKind.Local).AddTicks(2387));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 146,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 170, DateTimeKind.Local).AddTicks(2390));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 147,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 170, DateTimeKind.Local).AddTicks(2393));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 148,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 170, DateTimeKind.Local).AddTicks(2396));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 149,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 170, DateTimeKind.Local).AddTicks(2399));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 150,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 170, DateTimeKind.Local).AddTicks(2402));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 151,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 170, DateTimeKind.Local).AddTicks(2405));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 152,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 170, DateTimeKind.Local).AddTicks(2408));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 153,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 170, DateTimeKind.Local).AddTicks(2411));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 154,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 170, DateTimeKind.Local).AddTicks(2422));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 155,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 170, DateTimeKind.Local).AddTicks(2425));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 156,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 170, DateTimeKind.Local).AddTicks(2428));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 157,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 170, DateTimeKind.Local).AddTicks(2431));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 158,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 170, DateTimeKind.Local).AddTicks(2434));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 159,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 170, DateTimeKind.Local).AddTicks(2437));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 160,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 170, DateTimeKind.Local).AddTicks(2440));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 161,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 170, DateTimeKind.Local).AddTicks(2443));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 162,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 170, DateTimeKind.Local).AddTicks(2446));

            migrationBuilder.UpdateData(
                table: "CustomSettingTypes",
                keyColumn: "CustomSettingTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 180, DateTimeKind.Local).AddTicks(7957));

            migrationBuilder.UpdateData(
                table: "CustomSettingTypes",
                keyColumn: "CustomSettingTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 180, DateTimeKind.Local).AddTicks(8036));

            migrationBuilder.UpdateData(
                table: "CustomSettingTypes",
                keyColumn: "CustomSettingTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 180, DateTimeKind.Local).AddTicks(8041));

            migrationBuilder.UpdateData(
                table: "CustomSettingTypes",
                keyColumn: "CustomSettingTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 180, DateTimeKind.Local).AddTicks(8045));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 212, DateTimeKind.Local).AddTicks(9670));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 212, DateTimeKind.Local).AddTicks(9861));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 212, DateTimeKind.Local).AddTicks(9884));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 212, DateTimeKind.Local).AddTicks(9891));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 212, DateTimeKind.Local).AddTicks(9898));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 212, DateTimeKind.Local).AddTicks(9869));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 212, DateTimeKind.Local).AddTicks(9903));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 212, DateTimeKind.Local).AddTicks(9910));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 212, DateTimeKind.Local).AddTicks(9915));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 212, DateTimeKind.Local).AddTicks(9920));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 212, DateTimeKind.Local).AddTicks(9925));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 212, DateTimeKind.Local).AddTicks(9931));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 13,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 212, DateTimeKind.Local).AddTicks(9936));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 14,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 212, DateTimeKind.Local).AddTicks(9941));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 15,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 212, DateTimeKind.Local).AddTicks(9945));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 16,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 212, DateTimeKind.Local).AddTicks(9952));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 17,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 212, DateTimeKind.Local).AddTicks(9875));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 18,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 212, DateTimeKind.Local).AddTicks(9854));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 19,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 212, DateTimeKind.Local).AddTicks(9957));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 20,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 212, DateTimeKind.Local).AddTicks(9982));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 21,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 212, DateTimeKind.Local).AddTicks(9987));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 22,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 212, DateTimeKind.Local).AddTicks(9992));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 23,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 212, DateTimeKind.Local).AddTicks(9997));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 25,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 213, DateTimeKind.Local).AddTicks(29));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 26,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 213, DateTimeKind.Local).AddTicks(3));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 27,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 213, DateTimeKind.Local).AddTicks(9));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 28,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 213, DateTimeKind.Local).AddTicks(19));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 29,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 213, DateTimeKind.Local).AddTicks(14));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 30,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 213, DateTimeKind.Local).AddTicks(25));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 31,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 213, DateTimeKind.Local).AddTicks(35));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 32,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 213, DateTimeKind.Local).AddTicks(40));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 33,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 213, DateTimeKind.Local).AddTicks(45));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 34,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 213, DateTimeKind.Local).AddTicks(50));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 35,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 213, DateTimeKind.Local).AddTicks(58));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 36,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 213, DateTimeKind.Local).AddTicks(63));

            migrationBuilder.UpdateData(
                table: "DocumentFormats",
                keyColumn: "DocumentFormatID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 197, DateTimeKind.Local).AddTicks(1854));

            migrationBuilder.UpdateData(
                table: "DocumentFormats",
                keyColumn: "DocumentFormatID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 197, DateTimeKind.Local).AddTicks(2275));

            migrationBuilder.UpdateData(
                table: "DocumentFormats",
                keyColumn: "DocumentFormatID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 197, DateTimeKind.Local).AddTicks(2284));

            migrationBuilder.UpdateData(
                table: "DocumentFormats",
                keyColumn: "DocumentFormatID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 197, DateTimeKind.Local).AddTicks(2288));

            migrationBuilder.UpdateData(
                table: "DocumentFormats",
                keyColumn: "DocumentFormatID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 197, DateTimeKind.Local).AddTicks(2291));

            migrationBuilder.UpdateData(
                table: "DocumentFormats",
                keyColumn: "DocumentFormatID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 197, DateTimeKind.Local).AddTicks(2300));

            migrationBuilder.UpdateData(
                table: "DocumentTypes",
                keyColumn: "DocumentTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 199, DateTimeKind.Local).AddTicks(9450));

            migrationBuilder.UpdateData(
                table: "DocumentTypes",
                keyColumn: "DocumentTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 200, DateTimeKind.Local).AddTicks(427));

            migrationBuilder.UpdateData(
                table: "DocumentTypes",
                keyColumn: "DocumentTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 200, DateTimeKind.Local).AddTicks(449));

            migrationBuilder.UpdateData(
                table: "EmailTypes",
                keyColumn: "EmailTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 209, DateTimeKind.Local).AddTicks(1724));

            migrationBuilder.UpdateData(
                table: "EmailTypes",
                keyColumn: "EmailTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 209, DateTimeKind.Local).AddTicks(2148));

            migrationBuilder.UpdateData(
                table: "EmailTypes",
                keyColumn: "EmailTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 209, DateTimeKind.Local).AddTicks(2156));

            migrationBuilder.UpdateData(
                table: "FeatureFlags",
                keyColumn: "FeatureFlagID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 194, DateTimeKind.Local).AddTicks(4664));

            migrationBuilder.UpdateData(
                table: "FeatureFlags",
                keyColumn: "FeatureFlagID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 194, DateTimeKind.Local).AddTicks(5056));

            migrationBuilder.UpdateData(
                table: "FeatureFlags",
                keyColumn: "FeatureFlagID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 194, DateTimeKind.Local).AddTicks(5065));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "GenderID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 182, DateTimeKind.Local).AddTicks(9219));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "GenderID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 182, DateTimeKind.Local).AddTicks(9347));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 201, DateTimeKind.Local).AddTicks(9754));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 201, DateTimeKind.Local).AddTicks(9894));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 201, DateTimeKind.Local).AddTicks(9902));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 201, DateTimeKind.Local).AddTicks(9912));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 201, DateTimeKind.Local).AddTicks(9908));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 999,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 201, DateTimeKind.Local).AddTicks(9931));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 9998,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 201, DateTimeKind.Local).AddTicks(9922));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 203, DateTimeKind.Local).AddTicks(8753));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 203, DateTimeKind.Local).AddTicks(8927));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 203, DateTimeKind.Local).AddTicks(8932));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 203, DateTimeKind.Local).AddTicks(8936));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 203, DateTimeKind.Local).AddTicks(8939));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 203, DateTimeKind.Local).AddTicks(8949));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 203, DateTimeKind.Local).AddTicks(8953));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 203, DateTimeKind.Local).AddTicks(8957));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 203, DateTimeKind.Local).AddTicks(8961));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 203, DateTimeKind.Local).AddTicks(8966));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 203, DateTimeKind.Local).AddTicks(8970));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 203, DateTimeKind.Local).AddTicks(8973));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 13,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 203, DateTimeKind.Local).AddTicks(8977));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 14,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 203, DateTimeKind.Local).AddTicks(8981));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 15,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 203, DateTimeKind.Local).AddTicks(8984));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 16,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 203, DateTimeKind.Local).AddTicks(8988));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 17,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 203, DateTimeKind.Local).AddTicks(8991));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 18,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 203, DateTimeKind.Local).AddTicks(8996));

            migrationBuilder.UpdateData(
                table: "PaymentStatus",
                keyColumn: "PaymentStatusID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 157, DateTimeKind.Local).AddTicks(9990));

            migrationBuilder.UpdateData(
                table: "PaymentStatus",
                keyColumn: "PaymentStatusID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 158, DateTimeKind.Local).AddTicks(458));

            migrationBuilder.UpdateData(
                table: "PaymentStatus",
                keyColumn: "PaymentStatusID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 158, DateTimeKind.Local).AddTicks(466));

            migrationBuilder.UpdateData(
                table: "PaymentStatus",
                keyColumn: "PaymentStatusID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 158, DateTimeKind.Local).AddTicks(471));

            migrationBuilder.UpdateData(
                table: "PaymentStatus",
                keyColumn: "PaymentStatusID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 158, DateTimeKind.Local).AddTicks(475));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 147, DateTimeKind.Local).AddTicks(3287));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 152, DateTimeKind.Local).AddTicks(2850));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 3,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2020, 9, 20, 21, 13, 32, 152, DateTimeKind.Local).AddTicks(2922), "Delete User" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 4,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2020, 9, 20, 21, 13, 32, 152, DateTimeKind.Local).AddTicks(2929), "View User" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 5,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2020, 9, 20, 21, 13, 32, 152, DateTimeKind.Local).AddTicks(2936), "Change User Password" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 6,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2020, 9, 20, 21, 13, 32, 152, DateTimeKind.Local).AddTicks(2975), "Add Client" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 7,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2020, 9, 20, 21, 13, 32, 152, DateTimeKind.Local).AddTicks(2982), "Update Client" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 8,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2020, 9, 20, 21, 13, 32, 152, DateTimeKind.Local).AddTicks(2988), "Delete Client" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 9,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2020, 9, 20, 21, 13, 32, 152, DateTimeKind.Local).AddTicks(2995), "View Client" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 10,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2020, 9, 20, 21, 13, 32, 152, DateTimeKind.Local).AddTicks(3005), "Change Client Password" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 11,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2020, 9, 20, 21, 13, 32, 152, DateTimeKind.Local).AddTicks(3011), "Add Role" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 12,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2020, 9, 20, 21, 13, 32, 152, DateTimeKind.Local).AddTicks(3017), "Update Role" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 13,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2020, 9, 20, 21, 13, 32, 152, DateTimeKind.Local).AddTicks(3023), "Delete Role" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 14,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2020, 9, 20, 21, 13, 32, 152, DateTimeKind.Local).AddTicks(3028), "View Role" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 15,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2020, 9, 20, 21, 13, 32, 152, DateTimeKind.Local).AddTicks(3035), "Add Permissions" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 16,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2020, 9, 20, 21, 13, 32, 152, DateTimeKind.Local).AddTicks(3041), "Remove Permissions" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 17,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2020, 9, 20, 21, 13, 32, 152, DateTimeKind.Local).AddTicks(3047), "View Permissions" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 18,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2020, 9, 20, 21, 13, 32, 152, DateTimeKind.Local).AddTicks(3176), "Add Product" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 19,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2020, 9, 20, 21, 13, 32, 152, DateTimeKind.Local).AddTicks(3183), "Update Product" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 20,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2020, 9, 20, 21, 13, 32, 152, DateTimeKind.Local).AddTicks(3189), "Delete Product" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 21,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2020, 9, 20, 21, 13, 32, 152, DateTimeKind.Local).AddTicks(3195), "View Product" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 22,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2020, 9, 20, 21, 13, 32, 152, DateTimeKind.Local).AddTicks(3201), "Add Department" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 23,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2020, 9, 20, 21, 13, 32, 152, DateTimeKind.Local).AddTicks(3207), "Update Department" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 24,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2020, 9, 20, 21, 13, 32, 152, DateTimeKind.Local).AddTicks(3213), "Delete Department" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 25,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2020, 9, 20, 21, 13, 32, 152, DateTimeKind.Local).AddTicks(3219), "View Department" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 26,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2020, 9, 20, 21, 13, 32, 152, DateTimeKind.Local).AddTicks(3226), "Respond To Enquiry" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 27,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2020, 9, 20, 21, 13, 32, 152, DateTimeKind.Local).AddTicks(3231), "Route Enquiry" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 28,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2020, 9, 20, 21, 13, 32, 152, DateTimeKind.Local).AddTicks(3237), "Suspend Enquiry" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 29,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2020, 9, 20, 21, 13, 32, 152, DateTimeKind.Local).AddTicks(3243), "Close Enquiry" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 30,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2020, 9, 20, 21, 13, 32, 152, DateTimeKind.Local).AddTicks(3248), "Capture Payment" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 31,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2020, 9, 20, 21, 13, 32, 152, DateTimeKind.Local).AddTicks(3254), "Refund Payment" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 32,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2020, 9, 20, 21, 13, 32, 152, DateTimeKind.Local).AddTicks(3260), "Reverse Payment" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 33,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2020, 9, 20, 21, 13, 32, 152, DateTimeKind.Local).AddTicks(3265), "Void Payment" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 34,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2020, 9, 20, 21, 13, 32, 152, DateTimeKind.Local).AddTicks(3275), "View Payment" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 35,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2020, 9, 20, 21, 13, 32, 152, DateTimeKind.Local).AddTicks(3281), "Make Payment" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 36,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2020, 9, 20, 21, 13, 32, 152, DateTimeKind.Local).AddTicks(3288), "Add Menu" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 37,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2020, 9, 20, 21, 13, 32, 152, DateTimeKind.Local).AddTicks(3294), "Update Menu" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 38,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2020, 9, 20, 21, 13, 32, 152, DateTimeKind.Local).AddTicks(3301), "Activate Menu" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 39,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2020, 9, 20, 21, 13, 32, 152, DateTimeKind.Local).AddTicks(3307), "Deactivate Menu" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 40,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2020, 9, 20, 21, 13, 32, 152, DateTimeKind.Local).AddTicks(3313), "Delete Menu" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 41,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2020, 9, 20, 21, 13, 32, 152, DateTimeKind.Local).AddTicks(3319), "View Menu" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 42,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2020, 9, 20, 21, 13, 32, 152, DateTimeKind.Local).AddTicks(3325), "Add Course" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 43,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2020, 9, 20, 21, 13, 32, 152, DateTimeKind.Local).AddTicks(3330), "Update Course" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 44,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2020, 9, 20, 21, 13, 32, 152, DateTimeKind.Local).AddTicks(3336), "Delete Course" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 45,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2020, 9, 20, 21, 13, 32, 152, DateTimeKind.Local).AddTicks(3341), "View Course" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 46,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2020, 9, 20, 21, 13, 32, 152, DateTimeKind.Local).AddTicks(3348), "Update Custom Setting" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 47,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2020, 9, 20, 21, 13, 32, 152, DateTimeKind.Local).AddTicks(3354), "View Custom Setting" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 48,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2020, 9, 20, 21, 13, 32, 152, DateTimeKind.Local).AddTicks(3361), "Add Document Type" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 49,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2020, 9, 20, 21, 13, 32, 152, DateTimeKind.Local).AddTicks(3367), "Update Document Type" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 50,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2020, 9, 20, 21, 13, 32, 152, DateTimeKind.Local).AddTicks(3373), "Delete Document Type" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 51,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2020, 9, 20, 21, 13, 32, 152, DateTimeKind.Local).AddTicks(3380), "View Document Type" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 52,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2020, 9, 20, 21, 13, 32, 152, DateTimeKind.Local).AddTicks(3385), "Add Company" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 53,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2020, 9, 20, 21, 13, 32, 152, DateTimeKind.Local).AddTicks(3391), "Update Company" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 54,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2020, 9, 20, 21, 13, 32, 152, DateTimeKind.Local).AddTicks(3397), "Delete Company" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 55,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2020, 9, 20, 21, 13, 32, 152, DateTimeKind.Local).AddTicks(3402), "View Company" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 56,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2020, 9, 20, 21, 13, 32, 152, DateTimeKind.Local).AddTicks(3408), "Add Bank Account" });

            migrationBuilder.InsertData(
                table: "Permissions",
                columns: new[] { "PermissionID", "Description", "IsActive", "IsDeleted", "LastChangedBy", "LastChangedDate", "Name" },
                values: new object[,]
                {
                    { 69, null, true, false, "SuperUser", new DateTime(2020, 9, 20, 21, 13, 32, 152, DateTimeKind.Local).AddTicks(3506), "Update Currency" },
                    { 60, null, true, false, "SuperUser", new DateTime(2020, 9, 20, 21, 13, 32, 152, DateTimeKind.Local).AddTicks(3448), "Add Email Template" },
                    { 61, null, true, false, "SuperUser", new DateTime(2020, 9, 20, 21, 13, 32, 152, DateTimeKind.Local).AddTicks(3455), "Update Email Template" },
                    { 62, null, true, false, "SuperUser", new DateTime(2020, 9, 20, 21, 13, 32, 152, DateTimeKind.Local).AddTicks(3462), "Delete Email Template" },
                    { 63, null, true, false, "SuperUser", new DateTime(2020, 9, 20, 21, 13, 32, 152, DateTimeKind.Local).AddTicks(3468), "View Email Template" },
                    { 64, null, true, false, "SuperUser", new DateTime(2020, 9, 20, 21, 13, 32, 152, DateTimeKind.Local).AddTicks(3475), "Add Notice" },
                    { 65, null, true, false, "SuperUser", new DateTime(2020, 9, 20, 21, 13, 32, 152, DateTimeKind.Local).AddTicks(3480), "Update Notice" },
                    { 66, null, true, false, "SuperUser", new DateTime(2020, 9, 20, 21, 13, 32, 152, DateTimeKind.Local).AddTicks(3489), "Delete Notice" },
                    { 67, null, true, false, "SuperUser", new DateTime(2020, 9, 20, 21, 13, 32, 152, DateTimeKind.Local).AddTicks(3495), "View Notice" },
                    { 68, null, true, false, "SuperUser", new DateTime(2020, 9, 20, 21, 13, 32, 152, DateTimeKind.Local).AddTicks(3501), "Update Country" },
                    { 58, null, true, false, "SuperUser", new DateTime(2020, 9, 20, 21, 13, 32, 152, DateTimeKind.Local).AddTicks(3420), "Delete Bank Account" },
                    { 59, null, true, false, "SuperUser", new DateTime(2020, 9, 20, 21, 13, 32, 152, DateTimeKind.Local).AddTicks(3427), "View Bank Account" },
                    { 57, null, true, false, "SuperUser", new DateTime(2020, 9, 20, 21, 13, 32, 152, DateTimeKind.Local).AddTicks(3415), "Update Bank Account" }
                });

            migrationBuilder.UpdateData(
                table: "PriorityRanks",
                keyColumn: "PriorityRankID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 187, DateTimeKind.Local).AddTicks(7451));

            migrationBuilder.UpdateData(
                table: "PriorityRanks",
                keyColumn: "PriorityRankID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 187, DateTimeKind.Local).AddTicks(7801));

            migrationBuilder.UpdateData(
                table: "PriorityRanks",
                keyColumn: "PriorityRankID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 187, DateTimeKind.Local).AddTicks(7806));

            migrationBuilder.UpdateData(
                table: "PriorityRanks",
                keyColumn: "PriorityRankID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 187, DateTimeKind.Local).AddTicks(7810));

            migrationBuilder.UpdateData(
                table: "ProductFrequencies",
                keyColumn: "ProductFrequencyID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 173, DateTimeKind.Local).AddTicks(9113));

            migrationBuilder.UpdateData(
                table: "ProductFrequencies",
                keyColumn: "ProductFrequencyID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 173, DateTimeKind.Local).AddTicks(9518));

            migrationBuilder.UpdateData(
                table: "ProductFrequencies",
                keyColumn: "ProductFrequencyID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 173, DateTimeKind.Local).AddTicks(9547));

            migrationBuilder.UpdateData(
                table: "ProductFrequencies",
                keyColumn: "ProductFrequencyID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 173, DateTimeKind.Local).AddTicks(9557));

            migrationBuilder.UpdateData(
                table: "ProductFrequencies",
                keyColumn: "ProductFrequencyID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 173, DateTimeKind.Local).AddTicks(9560));

            migrationBuilder.UpdateData(
                table: "RelationshipTypes",
                keyColumn: "RelationshipTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 179, DateTimeKind.Local).AddTicks(7272));

            migrationBuilder.UpdateData(
                table: "RelationshipTypes",
                keyColumn: "RelationshipTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 179, DateTimeKind.Local).AddTicks(7352));

            migrationBuilder.UpdateData(
                table: "RelationshipTypes",
                keyColumn: "RelationshipTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 179, DateTimeKind.Local).AddTicks(7355));

            migrationBuilder.UpdateData(
                table: "RelationshipTypes",
                keyColumn: "RelationshipTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 179, DateTimeKind.Local).AddTicks(7357));

            migrationBuilder.UpdateData(
                table: "RelationshipTypes",
                keyColumn: "RelationshipTypeID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 179, DateTimeKind.Local).AddTicks(7359));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 153, DateTimeKind.Local).AddTicks(7500));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 153, DateTimeKind.Local).AddTicks(7707));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 153, DateTimeKind.Local).AddTicks(7712));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 153, DateTimeKind.Local).AddTicks(7715));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 153, DateTimeKind.Local).AddTicks(7717));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 153, DateTimeKind.Local).AddTicks(7725));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 153, DateTimeKind.Local).AddTicks(7727));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 153, DateTimeKind.Local).AddTicks(7729));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 153, DateTimeKind.Local).AddTicks(7731));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 153, DateTimeKind.Local).AddTicks(7735));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 153, DateTimeKind.Local).AddTicks(7737));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 153, DateTimeKind.Local).AddTicks(7739));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 13,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 153, DateTimeKind.Local).AddTicks(7741));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 14,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 153, DateTimeKind.Local).AddTicks(7743));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 15,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 153, DateTimeKind.Local).AddTicks(7745));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 16,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 153, DateTimeKind.Local).AddTicks(7747));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 17,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 153, DateTimeKind.Local).AddTicks(7749));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 18,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 153, DateTimeKind.Local).AddTicks(7754));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 19,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 153, DateTimeKind.Local).AddTicks(7756));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 20,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 153, DateTimeKind.Local).AddTicks(7758));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 21,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 153, DateTimeKind.Local).AddTicks(7760));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 22,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 153, DateTimeKind.Local).AddTicks(7781));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 23,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 153, DateTimeKind.Local).AddTicks(7783));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 24,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 153, DateTimeKind.Local).AddTicks(7785));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 25,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 153, DateTimeKind.Local).AddTicks(7787));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 26,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 153, DateTimeKind.Local).AddTicks(7789));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 27,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 153, DateTimeKind.Local).AddTicks(7792));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 28,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 153, DateTimeKind.Local).AddTicks(7794));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 29,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 153, DateTimeKind.Local).AddTicks(7797));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 30,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 153, DateTimeKind.Local).AddTicks(7799));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 31,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 153, DateTimeKind.Local).AddTicks(7801));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 32,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 153, DateTimeKind.Local).AddTicks(7803));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 33,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 153, DateTimeKind.Local).AddTicks(7805));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 34,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 153, DateTimeKind.Local).AddTicks(7809));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 35,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 153, DateTimeKind.Local).AddTicks(7812));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 36,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 153, DateTimeKind.Local).AddTicks(7814));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 37,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 153, DateTimeKind.Local).AddTicks(7817));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 38,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 153, DateTimeKind.Local).AddTicks(7819));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 39,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 153, DateTimeKind.Local).AddTicks(7821));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 40,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 153, DateTimeKind.Local).AddTicks(7824));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 41,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 153, DateTimeKind.Local).AddTicks(7826));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 42,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 153, DateTimeKind.Local).AddTicks(7828));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 43,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 153, DateTimeKind.Local).AddTicks(7830));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 44,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 153, DateTimeKind.Local).AddTicks(7832));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 45,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 153, DateTimeKind.Local).AddTicks(7834));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 46,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 153, DateTimeKind.Local).AddTicks(7836));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 47,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 153, DateTimeKind.Local).AddTicks(7839));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 48,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 153, DateTimeKind.Local).AddTicks(7841));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 49,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 153, DateTimeKind.Local).AddTicks(7843));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 50,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 153, DateTimeKind.Local).AddTicks(7845));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 51,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 153, DateTimeKind.Local).AddTicks(7847));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 52,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 153, DateTimeKind.Local).AddTicks(7849));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 53,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 153, DateTimeKind.Local).AddTicks(7851));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 54,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 153, DateTimeKind.Local).AddTicks(7853));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 55,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 153, DateTimeKind.Local).AddTicks(7855));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 56,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 153, DateTimeKind.Local).AddTicks(7857));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 140, DateTimeKind.Local).AddTicks(493));

            migrationBuilder.UpdateData(
                table: "SystemVariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 182, DateTimeKind.Local).AddTicks(539));

            migrationBuilder.UpdateData(
                table: "SystemVariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 182, DateTimeKind.Local).AddTicks(660));

            migrationBuilder.UpdateData(
                table: "SystemVariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 182, DateTimeKind.Local).AddTicks(656));

            migrationBuilder.UpdateData(
                table: "SystemVariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 182, DateTimeKind.Local).AddTicks(636));

            migrationBuilder.UpdateData(
                table: "SystemVariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 182, DateTimeKind.Local).AddTicks(631));

            migrationBuilder.UpdateData(
                table: "SystemVariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 182, DateTimeKind.Local).AddTicks(666));

            migrationBuilder.UpdateData(
                table: "SystemVariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 182, DateTimeKind.Local).AddTicks(677));

            migrationBuilder.UpdateData(
                table: "SystemVariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 182, DateTimeKind.Local).AddTicks(681));

            migrationBuilder.UpdateData(
                table: "SystemVariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 182, DateTimeKind.Local).AddTicks(685));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 162, DateTimeKind.Local).AddTicks(1120));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 162, DateTimeKind.Local).AddTicks(1621));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 162, DateTimeKind.Local).AddTicks(1630));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 162, DateTimeKind.Local).AddTicks(1634));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 162, DateTimeKind.Local).AddTicks(1638));

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumns: new[] { "UserID", "RoleID" },
                keyValues: new object[] { 1, 1 },
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 200, DateTimeKind.Local).AddTicks(5851));

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumns: new[] { "UserID", "RoleID" },
                keyValues: new object[] { 2, 1 },
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 200, DateTimeKind.Local).AddTicks(5923));

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "UserTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 177, DateTimeKind.Local).AddTicks(4704));

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "UserTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 177, DateTimeKind.Local).AddTicks(5417));

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "UserTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 177, DateTimeKind.Local).AddTicks(5424));

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "UserTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 177, DateTimeKind.Local).AddTicks(5427));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 188, DateTimeKind.Local).AddTicks(7002));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 191, DateTimeKind.Local).AddTicks(8453));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 191, DateTimeKind.Local).AddTicks(8626));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 21, 13, 32, 191, DateTimeKind.Local).AddTicks(8640));

            migrationBuilder.InsertData(
                table: "RolePermissions",
                columns: new[] { "RolePermissionID", "LastChangedBy", "LastChangedDate", "PermissionID", "RoleID" },
                values: new object[,]
                {
                    { 57, "SuperUser", new DateTime(2020, 9, 20, 21, 13, 32, 153, DateTimeKind.Local).AddTicks(7859), 57, 1 },
                    { 58, "SuperUser", new DateTime(2020, 9, 20, 21, 13, 32, 153, DateTimeKind.Local).AddTicks(7861), 58, 1 },
                    { 59, "SuperUser", new DateTime(2020, 9, 20, 21, 13, 32, 153, DateTimeKind.Local).AddTicks(7863), 59, 1 },
                    { 60, "SuperUser", new DateTime(2020, 9, 20, 21, 13, 32, 153, DateTimeKind.Local).AddTicks(7865), 60, 1 },
                    { 61, "SuperUser", new DateTime(2020, 9, 20, 21, 13, 32, 153, DateTimeKind.Local).AddTicks(7867), 61, 1 },
                    { 62, "SuperUser", new DateTime(2020, 9, 20, 21, 13, 32, 153, DateTimeKind.Local).AddTicks(7869), 62, 1 },
                    { 63, "SuperUser", new DateTime(2020, 9, 20, 21, 13, 32, 153, DateTimeKind.Local).AddTicks(7871), 63, 1 },
                    { 64, "SuperUser", new DateTime(2020, 9, 20, 21, 13, 32, 153, DateTimeKind.Local).AddTicks(7873), 64, 1 },
                    { 65, "SuperUser", new DateTime(2020, 9, 20, 21, 13, 32, 153, DateTimeKind.Local).AddTicks(7875), 65, 1 },
                    { 66, "SuperUser", new DateTime(2020, 9, 20, 21, 13, 32, 153, DateTimeKind.Local).AddTicks(7879), 66, 1 },
                    { 67, "SuperUser", new DateTime(2020, 9, 20, 21, 13, 32, 153, DateTimeKind.Local).AddTicks(7881), 67, 1 },
                    { 68, "SuperUser", new DateTime(2020, 9, 20, 21, 13, 32, 153, DateTimeKind.Local).AddTicks(7883), 68, 1 },
                    { 69, "SuperUser", new DateTime(2020, 9, 20, 21, 13, 32, 153, DateTimeKind.Local).AddTicks(7885), 69, 1 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 69);

            migrationBuilder.UpdateData(
                table: "BankAccountTypes",
                keyColumn: "BankAccountTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 948, DateTimeKind.Local).AddTicks(7216));

            migrationBuilder.UpdateData(
                table: "BankAccountTypes",
                keyColumn: "BankAccountTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 948, DateTimeKind.Local).AddTicks(7676));

            migrationBuilder.UpdateData(
                table: "BankAccountTypes",
                keyColumn: "BankAccountTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 948, DateTimeKind.Local).AddTicks(7684));

            migrationBuilder.UpdateData(
                table: "BankAccountTypes",
                keyColumn: "BankAccountTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 948, DateTimeKind.Local).AddTicks(7687));

            migrationBuilder.UpdateData(
                table: "ContactTypes",
                keyColumn: "ContactTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 958, DateTimeKind.Local).AddTicks(2433));

            migrationBuilder.UpdateData(
                table: "ContactTypes",
                keyColumn: "ContactTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 958, DateTimeKind.Local).AddTicks(2426));

            migrationBuilder.UpdateData(
                table: "ContactTypes",
                keyColumn: "ContactTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 958, DateTimeKind.Local).AddTicks(2417));

            migrationBuilder.UpdateData(
                table: "ContactTypes",
                keyColumn: "ContactTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 958, DateTimeKind.Local).AddTicks(2275));

            migrationBuilder.UpdateData(
                table: "ContactTypes",
                keyColumn: "ContactTypeID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 958, DateTimeKind.Local).AddTicks(2439));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 964, DateTimeKind.Local).AddTicks(3074));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 964, DateTimeKind.Local).AddTicks(3438));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 964, DateTimeKind.Local).AddTicks(3444));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 964, DateTimeKind.Local).AddTicks(3452));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 964, DateTimeKind.Local).AddTicks(3455));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 964, DateTimeKind.Local).AddTicks(3462));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 964, DateTimeKind.Local).AddTicks(3465));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 964, DateTimeKind.Local).AddTicks(3468));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 964, DateTimeKind.Local).AddTicks(3472));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 964, DateTimeKind.Local).AddTicks(3515));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 964, DateTimeKind.Local).AddTicks(3518));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 964, DateTimeKind.Local).AddTicks(3521));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 13,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 964, DateTimeKind.Local).AddTicks(3524));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 14,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 964, DateTimeKind.Local).AddTicks(3527));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 15,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 964, DateTimeKind.Local).AddTicks(3530));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 16,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 964, DateTimeKind.Local).AddTicks(3534));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 17,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 964, DateTimeKind.Local).AddTicks(3537));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 18,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 964, DateTimeKind.Local).AddTicks(3542));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 19,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 964, DateTimeKind.Local).AddTicks(3545));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 20,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 964, DateTimeKind.Local).AddTicks(3548));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 21,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 964, DateTimeKind.Local).AddTicks(3551));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 22,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 964, DateTimeKind.Local).AddTicks(3554));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 23,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 964, DateTimeKind.Local).AddTicks(3557));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 24,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 964, DateTimeKind.Local).AddTicks(3560));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 25,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 964, DateTimeKind.Local).AddTicks(3564));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 26,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 964, DateTimeKind.Local).AddTicks(3567));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 27,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 964, DateTimeKind.Local).AddTicks(3571));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 28,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 964, DateTimeKind.Local).AddTicks(3574));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 29,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 964, DateTimeKind.Local).AddTicks(3578));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 30,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 964, DateTimeKind.Local).AddTicks(3582));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 31,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 964, DateTimeKind.Local).AddTicks(3585));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 32,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 964, DateTimeKind.Local).AddTicks(3588));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 33,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 964, DateTimeKind.Local).AddTicks(3592));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 34,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 964, DateTimeKind.Local).AddTicks(3597));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 35,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 964, DateTimeKind.Local).AddTicks(3600));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 36,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 964, DateTimeKind.Local).AddTicks(3603));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 37,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 964, DateTimeKind.Local).AddTicks(3606));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 38,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 964, DateTimeKind.Local).AddTicks(3608));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 39,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 964, DateTimeKind.Local).AddTicks(3613));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 40,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 964, DateTimeKind.Local).AddTicks(3616));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 41,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 964, DateTimeKind.Local).AddTicks(3620));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 42,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 964, DateTimeKind.Local).AddTicks(3623));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 43,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 964, DateTimeKind.Local).AddTicks(3626));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 44,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 964, DateTimeKind.Local).AddTicks(3629));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 45,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 964, DateTimeKind.Local).AddTicks(3632));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 46,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 964, DateTimeKind.Local).AddTicks(3635));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 47,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 964, DateTimeKind.Local).AddTicks(3639));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 48,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 964, DateTimeKind.Local).AddTicks(3643));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 49,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 964, DateTimeKind.Local).AddTicks(3647));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 50,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 964, DateTimeKind.Local).AddTicks(3650));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 51,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 964, DateTimeKind.Local).AddTicks(3654));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 52,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 964, DateTimeKind.Local).AddTicks(3657));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 53,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 964, DateTimeKind.Local).AddTicks(3660));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 54,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 964, DateTimeKind.Local).AddTicks(3663));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 55,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 964, DateTimeKind.Local).AddTicks(3667));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 56,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 964, DateTimeKind.Local).AddTicks(3670));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 57,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 964, DateTimeKind.Local).AddTicks(3672));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 58,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 964, DateTimeKind.Local).AddTicks(3675));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 59,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 964, DateTimeKind.Local).AddTicks(3680));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 60,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 964, DateTimeKind.Local).AddTicks(3683));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 61,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 964, DateTimeKind.Local).AddTicks(3686));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 62,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 964, DateTimeKind.Local).AddTicks(3689));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 63,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 964, DateTimeKind.Local).AddTicks(3693));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 64,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 964, DateTimeKind.Local).AddTicks(3696));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 65,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 964, DateTimeKind.Local).AddTicks(3700));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 66,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 964, DateTimeKind.Local).AddTicks(3735));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 67,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 964, DateTimeKind.Local).AddTicks(3738));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 68,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 964, DateTimeKind.Local).AddTicks(3741));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 69,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 964, DateTimeKind.Local).AddTicks(3744));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 70,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 964, DateTimeKind.Local).AddTicks(3747));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 71,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 964, DateTimeKind.Local).AddTicks(3750));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 72,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 964, DateTimeKind.Local).AddTicks(3754));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 73,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 964, DateTimeKind.Local).AddTicks(3757));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 74,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 964, DateTimeKind.Local).AddTicks(3760));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 75,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 964, DateTimeKind.Local).AddTicks(3764));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 76,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 964, DateTimeKind.Local).AddTicks(3767));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 77,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 964, DateTimeKind.Local).AddTicks(3770));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 78,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 964, DateTimeKind.Local).AddTicks(3773));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 79,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 964, DateTimeKind.Local).AddTicks(3776));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 80,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 964, DateTimeKind.Local).AddTicks(3779));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 81,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 964, DateTimeKind.Local).AddTicks(3782));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 82,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 964, DateTimeKind.Local).AddTicks(3785));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 83,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 964, DateTimeKind.Local).AddTicks(3788));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 84,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 964, DateTimeKind.Local).AddTicks(3791));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 85,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 964, DateTimeKind.Local).AddTicks(3794));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 86,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 964, DateTimeKind.Local).AddTicks(3797));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 87,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 964, DateTimeKind.Local).AddTicks(3800));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 88,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 964, DateTimeKind.Local).AddTicks(3803));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 89,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 964, DateTimeKind.Local).AddTicks(3806));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 90,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 964, DateTimeKind.Local).AddTicks(3809));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 91,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 964, DateTimeKind.Local).AddTicks(3812));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 92,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 964, DateTimeKind.Local).AddTicks(3815));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 93,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 964, DateTimeKind.Local).AddTicks(3818));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 94,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 964, DateTimeKind.Local).AddTicks(3821));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 95,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 964, DateTimeKind.Local).AddTicks(3824));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 96,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 964, DateTimeKind.Local).AddTicks(3827));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 97,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 964, DateTimeKind.Local).AddTicks(3830));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 98,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 964, DateTimeKind.Local).AddTicks(3833));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 99,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 964, DateTimeKind.Local).AddTicks(3836));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 100,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 964, DateTimeKind.Local).AddTicks(3839));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 101,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 964, DateTimeKind.Local).AddTicks(3843));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 102,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 964, DateTimeKind.Local).AddTicks(3846));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 103,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 964, DateTimeKind.Local).AddTicks(3849));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 104,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 964, DateTimeKind.Local).AddTicks(3852));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 105,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 964, DateTimeKind.Local).AddTicks(3857));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 106,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 964, DateTimeKind.Local).AddTicks(3860));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 107,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 964, DateTimeKind.Local).AddTicks(3863));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 108,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 964, DateTimeKind.Local).AddTicks(3866));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 109,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 964, DateTimeKind.Local).AddTicks(3869));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 110,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 964, DateTimeKind.Local).AddTicks(3872));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 111,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 964, DateTimeKind.Local).AddTicks(3875));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 112,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 964, DateTimeKind.Local).AddTicks(3878));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 113,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 964, DateTimeKind.Local).AddTicks(3881));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 114,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 964, DateTimeKind.Local).AddTicks(3884));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 115,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 964, DateTimeKind.Local).AddTicks(3888));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 116,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 964, DateTimeKind.Local).AddTicks(3891));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 117,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 964, DateTimeKind.Local).AddTicks(3894));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 118,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 964, DateTimeKind.Local).AddTicks(3897));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 119,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 964, DateTimeKind.Local).AddTicks(3899));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 120,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 964, DateTimeKind.Local).AddTicks(3902));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 121,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 964, DateTimeKind.Local).AddTicks(3907));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 122,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 964, DateTimeKind.Local).AddTicks(3910));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 123,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 964, DateTimeKind.Local).AddTicks(3913));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 124,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 964, DateTimeKind.Local).AddTicks(3915));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 125,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 964, DateTimeKind.Local).AddTicks(3918));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 126,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 964, DateTimeKind.Local).AddTicks(3921));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 127,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 964, DateTimeKind.Local).AddTicks(3924));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 128,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 964, DateTimeKind.Local).AddTicks(3927));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 129,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 964, DateTimeKind.Local).AddTicks(3930));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 130,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 964, DateTimeKind.Local).AddTicks(3968));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 131,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 964, DateTimeKind.Local).AddTicks(3971));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 132,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 964, DateTimeKind.Local).AddTicks(3974));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 133,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 964, DateTimeKind.Local).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 134,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 964, DateTimeKind.Local).AddTicks(3980));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 135,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 964, DateTimeKind.Local).AddTicks(3983));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 136,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 964, DateTimeKind.Local).AddTicks(3986));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 137,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 964, DateTimeKind.Local).AddTicks(3989));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 138,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 964, DateTimeKind.Local).AddTicks(3993));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 139,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 964, DateTimeKind.Local).AddTicks(3996));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 140,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 964, DateTimeKind.Local).AddTicks(3999));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 141,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 964, DateTimeKind.Local).AddTicks(4002));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 142,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 964, DateTimeKind.Local).AddTicks(4005));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 143,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 964, DateTimeKind.Local).AddTicks(4008));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 144,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 964, DateTimeKind.Local).AddTicks(4011));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 145,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 964, DateTimeKind.Local).AddTicks(4015));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 146,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 964, DateTimeKind.Local).AddTicks(4018));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 147,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 964, DateTimeKind.Local).AddTicks(4021));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 148,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 964, DateTimeKind.Local).AddTicks(4024));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 149,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 964, DateTimeKind.Local).AddTicks(4027));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 150,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 964, DateTimeKind.Local).AddTicks(4031));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 151,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 964, DateTimeKind.Local).AddTicks(4035));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 152,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 964, DateTimeKind.Local).AddTicks(4038));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 153,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 964, DateTimeKind.Local).AddTicks(4041));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 154,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 964, DateTimeKind.Local).AddTicks(4044));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 155,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 964, DateTimeKind.Local).AddTicks(4048));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 156,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 964, DateTimeKind.Local).AddTicks(4050));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 157,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 964, DateTimeKind.Local).AddTicks(4053));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 158,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 964, DateTimeKind.Local).AddTicks(4057));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 159,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 964, DateTimeKind.Local).AddTicks(4059));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 160,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 964, DateTimeKind.Local).AddTicks(4062));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 161,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 964, DateTimeKind.Local).AddTicks(4066));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 162,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 964, DateTimeKind.Local).AddTicks(4069));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 163,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 964, DateTimeKind.Local).AddTicks(4072));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 164,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 964, DateTimeKind.Local).AddTicks(4075));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 165,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 964, DateTimeKind.Local).AddTicks(4078));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 166,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 964, DateTimeKind.Local).AddTicks(4081));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 167,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 964, DateTimeKind.Local).AddTicks(4085));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 168,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 964, DateTimeKind.Local).AddTicks(4088));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 169,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 964, DateTimeKind.Local).AddTicks(4091));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 170,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 964, DateTimeKind.Local).AddTicks(4094));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 171,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 964, DateTimeKind.Local).AddTicks(4096));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 172,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 964, DateTimeKind.Local).AddTicks(4100));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 173,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 964, DateTimeKind.Local).AddTicks(4103));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 174,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 964, DateTimeKind.Local).AddTicks(4107));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 175,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 964, DateTimeKind.Local).AddTicks(4110));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 176,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 964, DateTimeKind.Local).AddTicks(4114));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 177,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 964, DateTimeKind.Local).AddTicks(4119));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 178,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 964, DateTimeKind.Local).AddTicks(4122));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 179,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 964, DateTimeKind.Local).AddTicks(4125));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 180,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 964, DateTimeKind.Local).AddTicks(4129));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 181,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 964, DateTimeKind.Local).AddTicks(4132));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 182,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 964, DateTimeKind.Local).AddTicks(4135));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 183,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 964, DateTimeKind.Local).AddTicks(4138));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 184,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 964, DateTimeKind.Local).AddTicks(4141));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 185,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 964, DateTimeKind.Local).AddTicks(4211));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 186,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 964, DateTimeKind.Local).AddTicks(4215));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 187,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 964, DateTimeKind.Local).AddTicks(4218));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 188,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 964, DateTimeKind.Local).AddTicks(4221));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 189,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 964, DateTimeKind.Local).AddTicks(4225));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 190,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 964, DateTimeKind.Local).AddTicks(4228));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 191,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 964, DateTimeKind.Local).AddTicks(4231));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 192,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 964, DateTimeKind.Local).AddTicks(4234));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 193,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 964, DateTimeKind.Local).AddTicks(4238));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 194,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 964, DateTimeKind.Local).AddTicks(4241));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 195,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 964, DateTimeKind.Local).AddTicks(4243));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 196,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 964, DateTimeKind.Local).AddTicks(4246));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 197,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 964, DateTimeKind.Local).AddTicks(4249));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 198,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 964, DateTimeKind.Local).AddTicks(4252));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 199,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 964, DateTimeKind.Local).AddTicks(4255));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 200,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 964, DateTimeKind.Local).AddTicks(4258));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 201,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 964, DateTimeKind.Local).AddTicks(4261));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 202,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 964, DateTimeKind.Local).AddTicks(4264));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 203,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 964, DateTimeKind.Local).AddTicks(4268));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 204,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 964, DateTimeKind.Local).AddTicks(4271));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 205,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 964, DateTimeKind.Local).AddTicks(4274));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 206,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 964, DateTimeKind.Local).AddTicks(4277));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 207,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 964, DateTimeKind.Local).AddTicks(4280));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 208,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 964, DateTimeKind.Local).AddTicks(4283));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 209,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 964, DateTimeKind.Local).AddTicks(4286));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 210,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 964, DateTimeKind.Local).AddTicks(4290));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 211,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 964, DateTimeKind.Local).AddTicks(4293));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 212,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 964, DateTimeKind.Local).AddTicks(4296));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 213,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 964, DateTimeKind.Local).AddTicks(4299));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 214,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 964, DateTimeKind.Local).AddTicks(4303));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 215,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 964, DateTimeKind.Local).AddTicks(4306));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 216,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 964, DateTimeKind.Local).AddTicks(4310));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 217,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 964, DateTimeKind.Local).AddTicks(4313));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 218,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 964, DateTimeKind.Local).AddTicks(4315));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 219,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 964, DateTimeKind.Local).AddTicks(4318));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 220,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 964, DateTimeKind.Local).AddTicks(4321));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 221,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 964, DateTimeKind.Local).AddTicks(4324));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 222,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 964, DateTimeKind.Local).AddTicks(4328));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 223,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 964, DateTimeKind.Local).AddTicks(4331));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 224,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 964, DateTimeKind.Local).AddTicks(4338));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 225,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 964, DateTimeKind.Local).AddTicks(4343));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 226,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 964, DateTimeKind.Local).AddTicks(4349));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 227,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 964, DateTimeKind.Local).AddTicks(4352));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 228,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 964, DateTimeKind.Local).AddTicks(4356));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 951, DateTimeKind.Local).AddTicks(2355));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 951, DateTimeKind.Local).AddTicks(2747));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 951, DateTimeKind.Local).AddTicks(2754));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 951, DateTimeKind.Local).AddTicks(2758));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 951, DateTimeKind.Local).AddTicks(2762));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 951, DateTimeKind.Local).AddTicks(2769));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 951, DateTimeKind.Local).AddTicks(2772));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 951, DateTimeKind.Local).AddTicks(2776));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 951, DateTimeKind.Local).AddTicks(2779));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 951, DateTimeKind.Local).AddTicks(2784));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 951, DateTimeKind.Local).AddTicks(2787));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 951, DateTimeKind.Local).AddTicks(2790));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 13,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 951, DateTimeKind.Local).AddTicks(2794));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 14,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 951, DateTimeKind.Local).AddTicks(2797));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 15,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 951, DateTimeKind.Local).AddTicks(2800));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 16,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 951, DateTimeKind.Local).AddTicks(2803));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 17,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 951, DateTimeKind.Local).AddTicks(2806));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 18,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 951, DateTimeKind.Local).AddTicks(2811));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 19,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 951, DateTimeKind.Local).AddTicks(2814));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 20,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 951, DateTimeKind.Local).AddTicks(2817));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 21,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 951, DateTimeKind.Local).AddTicks(2821));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 22,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 951, DateTimeKind.Local).AddTicks(2824));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 23,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 951, DateTimeKind.Local).AddTicks(2827));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 24,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 951, DateTimeKind.Local).AddTicks(2830));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 25,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 951, DateTimeKind.Local).AddTicks(2833));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 26,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 951, DateTimeKind.Local).AddTicks(2836));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 27,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 951, DateTimeKind.Local).AddTicks(2839));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 28,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 951, DateTimeKind.Local).AddTicks(2842));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 29,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 951, DateTimeKind.Local).AddTicks(2846));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 30,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 951, DateTimeKind.Local).AddTicks(2849));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 31,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 951, DateTimeKind.Local).AddTicks(2853));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 32,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 951, DateTimeKind.Local).AddTicks(2856));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 33,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 951, DateTimeKind.Local).AddTicks(2859));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 34,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 951, DateTimeKind.Local).AddTicks(2863));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 35,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 951, DateTimeKind.Local).AddTicks(2866));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 36,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 951, DateTimeKind.Local).AddTicks(2869));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 37,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 951, DateTimeKind.Local).AddTicks(2872));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 38,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 951, DateTimeKind.Local).AddTicks(2876));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 39,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 951, DateTimeKind.Local).AddTicks(2921));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 40,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 951, DateTimeKind.Local).AddTicks(2925));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 41,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 951, DateTimeKind.Local).AddTicks(2928));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 42,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 951, DateTimeKind.Local).AddTicks(2932));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 43,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 951, DateTimeKind.Local).AddTicks(2935));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 44,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 951, DateTimeKind.Local).AddTicks(2938));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 45,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 951, DateTimeKind.Local).AddTicks(2941));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 46,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 951, DateTimeKind.Local).AddTicks(2944));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 47,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 951, DateTimeKind.Local).AddTicks(2947));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 48,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 951, DateTimeKind.Local).AddTicks(2950));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 49,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 951, DateTimeKind.Local).AddTicks(2953));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 50,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 951, DateTimeKind.Local).AddTicks(2956));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 51,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 951, DateTimeKind.Local).AddTicks(2960));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 52,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 951, DateTimeKind.Local).AddTicks(2963));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 53,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 951, DateTimeKind.Local).AddTicks(2966));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 54,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 951, DateTimeKind.Local).AddTicks(2969));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 55,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 951, DateTimeKind.Local).AddTicks(2972));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 56,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 951, DateTimeKind.Local).AddTicks(2976));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 57,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 951, DateTimeKind.Local).AddTicks(2979));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 58,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 951, DateTimeKind.Local).AddTicks(2982));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 59,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 951, DateTimeKind.Local).AddTicks(2985));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 60,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 951, DateTimeKind.Local).AddTicks(2988));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 61,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 951, DateTimeKind.Local).AddTicks(2992));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 62,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 951, DateTimeKind.Local).AddTicks(2995));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 63,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 951, DateTimeKind.Local).AddTicks(2998));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 64,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 951, DateTimeKind.Local).AddTicks(3001));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 65,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 951, DateTimeKind.Local).AddTicks(3004));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 66,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 951, DateTimeKind.Local).AddTicks(3009));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 67,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 951, DateTimeKind.Local).AddTicks(3012));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 68,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 951, DateTimeKind.Local).AddTicks(3015));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 69,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 951, DateTimeKind.Local).AddTicks(3020));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 70,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 951, DateTimeKind.Local).AddTicks(3023));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 71,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 951, DateTimeKind.Local).AddTicks(3026));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 72,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 951, DateTimeKind.Local).AddTicks(3029));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 73,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 951, DateTimeKind.Local).AddTicks(3032));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 74,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 951, DateTimeKind.Local).AddTicks(3035));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 75,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 951, DateTimeKind.Local).AddTicks(3038));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 76,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 951, DateTimeKind.Local).AddTicks(3042));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 77,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 951, DateTimeKind.Local).AddTicks(3045));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 78,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 951, DateTimeKind.Local).AddTicks(3048));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 79,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 951, DateTimeKind.Local).AddTicks(3051));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 80,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 951, DateTimeKind.Local).AddTicks(3054));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 81,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 951, DateTimeKind.Local).AddTicks(3057));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 82,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 951, DateTimeKind.Local).AddTicks(3061));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 83,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 951, DateTimeKind.Local).AddTicks(3064));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 84,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 951, DateTimeKind.Local).AddTicks(3067));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 85,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 951, DateTimeKind.Local).AddTicks(3071));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 86,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 951, DateTimeKind.Local).AddTicks(3074));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 87,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 951, DateTimeKind.Local).AddTicks(3077));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 88,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 951, DateTimeKind.Local).AddTicks(3080));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 89,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 951, DateTimeKind.Local).AddTicks(3083));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 90,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 951, DateTimeKind.Local).AddTicks(3086));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 91,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 951, DateTimeKind.Local).AddTicks(3090));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 92,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 951, DateTimeKind.Local).AddTicks(3093));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 93,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 951, DateTimeKind.Local).AddTicks(3096));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 94,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 951, DateTimeKind.Local).AddTicks(3099));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 95,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 951, DateTimeKind.Local).AddTicks(3102));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 96,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 951, DateTimeKind.Local).AddTicks(3105));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 97,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 951, DateTimeKind.Local).AddTicks(3109));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 98,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 951, DateTimeKind.Local).AddTicks(3112));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 99,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 951, DateTimeKind.Local).AddTicks(3115));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 100,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 951, DateTimeKind.Local).AddTicks(3118));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 101,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 951, DateTimeKind.Local).AddTicks(3121));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 102,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 951, DateTimeKind.Local).AddTicks(3124));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 103,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 951, DateTimeKind.Local).AddTicks(3128));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 104,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 951, DateTimeKind.Local).AddTicks(3131));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 105,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 951, DateTimeKind.Local).AddTicks(3134));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 106,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 951, DateTimeKind.Local).AddTicks(3138));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 107,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 951, DateTimeKind.Local).AddTicks(3175));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 108,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 951, DateTimeKind.Local).AddTicks(3179));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 109,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 951, DateTimeKind.Local).AddTicks(3182));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 110,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 951, DateTimeKind.Local).AddTicks(3185));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 111,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 951, DateTimeKind.Local).AddTicks(3188));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 112,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 951, DateTimeKind.Local).AddTicks(3192));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 113,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 951, DateTimeKind.Local).AddTicks(3195));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 114,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 951, DateTimeKind.Local).AddTicks(3198));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 115,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 951, DateTimeKind.Local).AddTicks(3201));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 116,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 951, DateTimeKind.Local).AddTicks(3204));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 117,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 951, DateTimeKind.Local).AddTicks(3207));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 118,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 951, DateTimeKind.Local).AddTicks(3210));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 119,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 951, DateTimeKind.Local).AddTicks(3214));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 120,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 951, DateTimeKind.Local).AddTicks(3217));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 121,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 951, DateTimeKind.Local).AddTicks(3220));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 122,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 951, DateTimeKind.Local).AddTicks(3223));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 123,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 951, DateTimeKind.Local).AddTicks(3227));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 124,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 951, DateTimeKind.Local).AddTicks(3230));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 125,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 951, DateTimeKind.Local).AddTicks(3233));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 126,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 951, DateTimeKind.Local).AddTicks(3236));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 127,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 951, DateTimeKind.Local).AddTicks(3239));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 128,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 951, DateTimeKind.Local).AddTicks(3242));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 129,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 951, DateTimeKind.Local).AddTicks(3246));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 130,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 951, DateTimeKind.Local).AddTicks(3250));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 131,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 951, DateTimeKind.Local).AddTicks(3253));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 132,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 951, DateTimeKind.Local).AddTicks(3256));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 133,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 951, DateTimeKind.Local).AddTicks(3260));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 134,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 951, DateTimeKind.Local).AddTicks(3263));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 135,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 951, DateTimeKind.Local).AddTicks(3266));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 136,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 951, DateTimeKind.Local).AddTicks(3269));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 137,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 951, DateTimeKind.Local).AddTicks(3272));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 138,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 951, DateTimeKind.Local).AddTicks(3275));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 139,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 951, DateTimeKind.Local).AddTicks(3278));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 140,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 951, DateTimeKind.Local).AddTicks(3281));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 141,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 951, DateTimeKind.Local).AddTicks(3284));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 142,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 951, DateTimeKind.Local).AddTicks(3287));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 143,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 951, DateTimeKind.Local).AddTicks(3291));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 144,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 951, DateTimeKind.Local).AddTicks(3294));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 145,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 951, DateTimeKind.Local).AddTicks(3297));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 146,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 951, DateTimeKind.Local).AddTicks(3301));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 147,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 951, DateTimeKind.Local).AddTicks(3304));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 148,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 951, DateTimeKind.Local).AddTicks(3307));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 149,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 951, DateTimeKind.Local).AddTicks(3310));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 150,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 951, DateTimeKind.Local).AddTicks(3313));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 151,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 951, DateTimeKind.Local).AddTicks(3316));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 152,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 951, DateTimeKind.Local).AddTicks(3319));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 153,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 951, DateTimeKind.Local).AddTicks(3322));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 154,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 951, DateTimeKind.Local).AddTicks(3325));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 155,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 951, DateTimeKind.Local).AddTicks(3329));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 156,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 951, DateTimeKind.Local).AddTicks(3332));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 157,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 951, DateTimeKind.Local).AddTicks(3335));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 158,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 951, DateTimeKind.Local).AddTicks(3338));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 159,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 951, DateTimeKind.Local).AddTicks(3341));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 160,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 951, DateTimeKind.Local).AddTicks(3344));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 161,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 951, DateTimeKind.Local).AddTicks(3347));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 162,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 951, DateTimeKind.Local).AddTicks(3350));

            migrationBuilder.UpdateData(
                table: "CustomSettingTypes",
                keyColumn: "CustomSettingTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 959, DateTimeKind.Local).AddTicks(9451));

            migrationBuilder.UpdateData(
                table: "CustomSettingTypes",
                keyColumn: "CustomSettingTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 959, DateTimeKind.Local).AddTicks(9563));

            migrationBuilder.UpdateData(
                table: "CustomSettingTypes",
                keyColumn: "CustomSettingTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 959, DateTimeKind.Local).AddTicks(9568));

            migrationBuilder.UpdateData(
                table: "CustomSettingTypes",
                keyColumn: "CustomSettingTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 959, DateTimeKind.Local).AddTicks(9572));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 986, DateTimeKind.Local).AddTicks(8083));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 986, DateTimeKind.Local).AddTicks(8234));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 986, DateTimeKind.Local).AddTicks(8258));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 986, DateTimeKind.Local).AddTicks(8263));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 986, DateTimeKind.Local).AddTicks(8269));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 986, DateTimeKind.Local).AddTicks(8242));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 986, DateTimeKind.Local).AddTicks(8273));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 986, DateTimeKind.Local).AddTicks(8280));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 986, DateTimeKind.Local).AddTicks(8284));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 986, DateTimeKind.Local).AddTicks(8289));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 986, DateTimeKind.Local).AddTicks(8295));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 986, DateTimeKind.Local).AddTicks(8300));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 13,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 986, DateTimeKind.Local).AddTicks(8304));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 14,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 986, DateTimeKind.Local).AddTicks(8309));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 15,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 986, DateTimeKind.Local).AddTicks(8314));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 16,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 986, DateTimeKind.Local).AddTicks(8320));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 17,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 986, DateTimeKind.Local).AddTicks(8248));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 18,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 986, DateTimeKind.Local).AddTicks(8227));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 19,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 986, DateTimeKind.Local).AddTicks(8325));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 20,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 986, DateTimeKind.Local).AddTicks(8330));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 21,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 986, DateTimeKind.Local).AddTicks(8335));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 22,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 986, DateTimeKind.Local).AddTicks(8339));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 23,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 986, DateTimeKind.Local).AddTicks(8344));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 25,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 986, DateTimeKind.Local).AddTicks(8418));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 26,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 986, DateTimeKind.Local).AddTicks(8349));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 27,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 986, DateTimeKind.Local).AddTicks(8355));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 28,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 986, DateTimeKind.Local).AddTicks(8408));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 29,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 986, DateTimeKind.Local).AddTicks(8360));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 30,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 986, DateTimeKind.Local).AddTicks(8413));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 31,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 986, DateTimeKind.Local).AddTicks(8424));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 32,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 986, DateTimeKind.Local).AddTicks(8429));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 33,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 986, DateTimeKind.Local).AddTicks(8434));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 34,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 986, DateTimeKind.Local).AddTicks(8439));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 35,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 986, DateTimeKind.Local).AddTicks(8447));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 36,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 986, DateTimeKind.Local).AddTicks(8451));

            migrationBuilder.UpdateData(
                table: "DocumentFormats",
                keyColumn: "DocumentFormatID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 972, DateTimeKind.Local).AddTicks(7312));

            migrationBuilder.UpdateData(
                table: "DocumentFormats",
                keyColumn: "DocumentFormatID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 972, DateTimeKind.Local).AddTicks(7673));

            migrationBuilder.UpdateData(
                table: "DocumentFormats",
                keyColumn: "DocumentFormatID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 972, DateTimeKind.Local).AddTicks(7683));

            migrationBuilder.UpdateData(
                table: "DocumentFormats",
                keyColumn: "DocumentFormatID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 972, DateTimeKind.Local).AddTicks(7686));

            migrationBuilder.UpdateData(
                table: "DocumentFormats",
                keyColumn: "DocumentFormatID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 972, DateTimeKind.Local).AddTicks(7689));

            migrationBuilder.UpdateData(
                table: "DocumentFormats",
                keyColumn: "DocumentFormatID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 972, DateTimeKind.Local).AddTicks(7697));

            migrationBuilder.UpdateData(
                table: "DocumentTypes",
                keyColumn: "DocumentTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 974, DateTimeKind.Local).AddTicks(9540));

            migrationBuilder.UpdateData(
                table: "DocumentTypes",
                keyColumn: "DocumentTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 975, DateTimeKind.Local).AddTicks(445));

            migrationBuilder.UpdateData(
                table: "DocumentTypes",
                keyColumn: "DocumentTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 975, DateTimeKind.Local).AddTicks(466));

            migrationBuilder.UpdateData(
                table: "EmailTypes",
                keyColumn: "EmailTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 983, DateTimeKind.Local).AddTicks(3736));

            migrationBuilder.UpdateData(
                table: "EmailTypes",
                keyColumn: "EmailTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 983, DateTimeKind.Local).AddTicks(4096));

            migrationBuilder.UpdateData(
                table: "EmailTypes",
                keyColumn: "EmailTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 983, DateTimeKind.Local).AddTicks(4104));

            migrationBuilder.UpdateData(
                table: "FeatureFlags",
                keyColumn: "FeatureFlagID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 970, DateTimeKind.Local).AddTicks(3724));

            migrationBuilder.UpdateData(
                table: "FeatureFlags",
                keyColumn: "FeatureFlagID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 970, DateTimeKind.Local).AddTicks(4108));

            migrationBuilder.UpdateData(
                table: "FeatureFlags",
                keyColumn: "FeatureFlagID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 970, DateTimeKind.Local).AddTicks(4117));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "GenderID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 961, DateTimeKind.Local).AddTicks(8236));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "GenderID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 961, DateTimeKind.Local).AddTicks(8388));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 976, DateTimeKind.Local).AddTicks(8437));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 976, DateTimeKind.Local).AddTicks(8855));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 976, DateTimeKind.Local).AddTicks(8862));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 976, DateTimeKind.Local).AddTicks(8872));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 976, DateTimeKind.Local).AddTicks(8868));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 999,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 976, DateTimeKind.Local).AddTicks(8893));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 9998,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 976, DateTimeKind.Local).AddTicks(8882));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 978, DateTimeKind.Local).AddTicks(6762));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 978, DateTimeKind.Local).AddTicks(6941));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 978, DateTimeKind.Local).AddTicks(6946));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 978, DateTimeKind.Local).AddTicks(6951));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 978, DateTimeKind.Local).AddTicks(6954));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 978, DateTimeKind.Local).AddTicks(6962));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 978, DateTimeKind.Local).AddTicks(6966));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 978, DateTimeKind.Local).AddTicks(6971));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 978, DateTimeKind.Local).AddTicks(6974));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 978, DateTimeKind.Local).AddTicks(6980));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 978, DateTimeKind.Local).AddTicks(6985));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 978, DateTimeKind.Local).AddTicks(6988));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 13,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 978, DateTimeKind.Local).AddTicks(6991));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 14,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 978, DateTimeKind.Local).AddTicks(6996));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 15,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 978, DateTimeKind.Local).AddTicks(6999));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 16,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 978, DateTimeKind.Local).AddTicks(7003));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 17,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 978, DateTimeKind.Local).AddTicks(7006));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 18,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 978, DateTimeKind.Local).AddTicks(7011));

            migrationBuilder.UpdateData(
                table: "PaymentStatus",
                keyColumn: "PaymentStatusID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 942, DateTimeKind.Local).AddTicks(4785));

            migrationBuilder.UpdateData(
                table: "PaymentStatus",
                keyColumn: "PaymentStatusID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 942, DateTimeKind.Local).AddTicks(5793));

            migrationBuilder.UpdateData(
                table: "PaymentStatus",
                keyColumn: "PaymentStatusID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 942, DateTimeKind.Local).AddTicks(5805));

            migrationBuilder.UpdateData(
                table: "PaymentStatus",
                keyColumn: "PaymentStatusID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 942, DateTimeKind.Local).AddTicks(5811));

            migrationBuilder.UpdateData(
                table: "PaymentStatus",
                keyColumn: "PaymentStatusID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 942, DateTimeKind.Local).AddTicks(5815));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 938, DateTimeKind.Local).AddTicks(7098));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 938, DateTimeKind.Local).AddTicks(7648));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 3,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2020, 9, 20, 17, 16, 10, 938, DateTimeKind.Local).AddTicks(7658), "Activate User" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 4,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2020, 9, 20, 17, 16, 10, 938, DateTimeKind.Local).AddTicks(7664), "Deactivate User" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 5,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2020, 9, 20, 17, 16, 10, 938, DateTimeKind.Local).AddTicks(7670), "Delete User" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 6,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2020, 9, 20, 17, 16, 10, 938, DateTimeKind.Local).AddTicks(7680), "View User" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 7,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2020, 9, 20, 17, 16, 10, 938, DateTimeKind.Local).AddTicks(7685), "Change User Password" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 8,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2020, 9, 20, 17, 16, 10, 938, DateTimeKind.Local).AddTicks(7689), "Add Client" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 9,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2020, 9, 20, 17, 16, 10, 938, DateTimeKind.Local).AddTicks(7694), "Update Client" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 10,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2020, 9, 20, 17, 16, 10, 938, DateTimeKind.Local).AddTicks(7764), "Activate Client" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 11,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2020, 9, 20, 17, 16, 10, 938, DateTimeKind.Local).AddTicks(7769), "Deactivate Client" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 12,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2020, 9, 20, 17, 16, 10, 938, DateTimeKind.Local).AddTicks(7773), "Delete Client" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 13,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2020, 9, 20, 17, 16, 10, 938, DateTimeKind.Local).AddTicks(7777), "View Client" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 14,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2020, 9, 20, 17, 16, 10, 938, DateTimeKind.Local).AddTicks(7781), "Change Client Password" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 15,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2020, 9, 20, 17, 16, 10, 938, DateTimeKind.Local).AddTicks(7786), "Add Role" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 16,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2020, 9, 20, 17, 16, 10, 938, DateTimeKind.Local).AddTicks(7789), "Update Role" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 17,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2020, 9, 20, 17, 16, 10, 938, DateTimeKind.Local).AddTicks(7793), "Activate Role" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 18,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2020, 9, 20, 17, 16, 10, 938, DateTimeKind.Local).AddTicks(7800), "Deactivate Role" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 19,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2020, 9, 20, 17, 16, 10, 938, DateTimeKind.Local).AddTicks(7804), "Delete Role" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 20,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2020, 9, 20, 17, 16, 10, 938, DateTimeKind.Local).AddTicks(7808), "View Role" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 21,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2020, 9, 20, 17, 16, 10, 938, DateTimeKind.Local).AddTicks(7812), "Add Product" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 22,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2020, 9, 20, 17, 16, 10, 938, DateTimeKind.Local).AddTicks(7816), "Update Product" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 23,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2020, 9, 20, 17, 16, 10, 938, DateTimeKind.Local).AddTicks(7820), "Activate Product" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 24,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2020, 9, 20, 17, 16, 10, 938, DateTimeKind.Local).AddTicks(7824), "Deactivate Product" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 25,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2020, 9, 20, 17, 16, 10, 938, DateTimeKind.Local).AddTicks(7828), "Delete Product" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 26,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2020, 9, 20, 17, 16, 10, 938, DateTimeKind.Local).AddTicks(7832), "View Product" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 27,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2020, 9, 20, 17, 16, 10, 938, DateTimeKind.Local).AddTicks(7836), "Add Department" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 28,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2020, 9, 20, 17, 16, 10, 938, DateTimeKind.Local).AddTicks(7840), "Update Department" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 29,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2020, 9, 20, 17, 16, 10, 938, DateTimeKind.Local).AddTicks(7844), "Activate Department" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 30,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2020, 9, 20, 17, 16, 10, 938, DateTimeKind.Local).AddTicks(7849), "Deactivate Department" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 31,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2020, 9, 20, 17, 16, 10, 938, DateTimeKind.Local).AddTicks(7853), "Delete Department" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 32,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2020, 9, 20, 17, 16, 10, 938, DateTimeKind.Local).AddTicks(7857), "View Department" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 33,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2020, 9, 20, 17, 16, 10, 938, DateTimeKind.Local).AddTicks(7862), "Respond To Enquiry" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 34,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2020, 9, 20, 17, 16, 10, 938, DateTimeKind.Local).AddTicks(7867), "Route Enquiry" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 35,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2020, 9, 20, 17, 16, 10, 938, DateTimeKind.Local).AddTicks(7871), "Suspend Enquiry" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 36,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2020, 9, 20, 17, 16, 10, 938, DateTimeKind.Local).AddTicks(7875), "Close Enquiry" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 37,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2020, 9, 20, 17, 16, 10, 938, DateTimeKind.Local).AddTicks(7879), "Capture Payment" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 38,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2020, 9, 20, 17, 16, 10, 938, DateTimeKind.Local).AddTicks(7883), "Refund Payment" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 39,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2020, 9, 20, 17, 16, 10, 938, DateTimeKind.Local).AddTicks(7887), "Reverse Payment" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 40,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2020, 9, 20, 17, 16, 10, 938, DateTimeKind.Local).AddTicks(7890), "Void Payment" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 41,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2020, 9, 20, 17, 16, 10, 938, DateTimeKind.Local).AddTicks(7894), "Add Menu" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 42,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2020, 9, 20, 17, 16, 10, 938, DateTimeKind.Local).AddTicks(7898), "Update Menu" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 43,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2020, 9, 20, 17, 16, 10, 938, DateTimeKind.Local).AddTicks(7902), "Activate Menu" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 44,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2020, 9, 20, 17, 16, 10, 938, DateTimeKind.Local).AddTicks(7906), "Deactivate Menu" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 45,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2020, 9, 20, 17, 16, 10, 938, DateTimeKind.Local).AddTicks(7910), "Delete Menu" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 46,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2020, 9, 20, 17, 16, 10, 938, DateTimeKind.Local).AddTicks(7914), "View Menu" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 47,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2020, 9, 20, 17, 16, 10, 938, DateTimeKind.Local).AddTicks(7918), "Add Course" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 48,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2020, 9, 20, 17, 16, 10, 938, DateTimeKind.Local).AddTicks(7921), "Update Course" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 49,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2020, 9, 20, 17, 16, 10, 938, DateTimeKind.Local).AddTicks(7925), "Delete Course" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 50,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2020, 9, 20, 17, 16, 10, 938, DateTimeKind.Local).AddTicks(7929), "View Course" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 51,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2020, 9, 20, 17, 16, 10, 938, DateTimeKind.Local).AddTicks(7933), "Update Custom Setting" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 52,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2020, 9, 20, 17, 16, 10, 938, DateTimeKind.Local).AddTicks(7972), "View Custom Setting" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 53,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2020, 9, 20, 17, 16, 10, 938, DateTimeKind.Local).AddTicks(7977), "Add Document Type" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 54,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2020, 9, 20, 17, 16, 10, 938, DateTimeKind.Local).AddTicks(7982), "Update Document Type" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 55,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2020, 9, 20, 17, 16, 10, 938, DateTimeKind.Local).AddTicks(7986), "Delete Document Type" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 56,
                columns: new[] { "LastChangedDate", "Name" },
                values: new object[] { new DateTime(2020, 9, 20, 17, 16, 10, 938, DateTimeKind.Local).AddTicks(7990), "View Document Type" });

            migrationBuilder.UpdateData(
                table: "PriorityRanks",
                keyColumn: "PriorityRankID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 965, DateTimeKind.Local).AddTicks(1630));

            migrationBuilder.UpdateData(
                table: "PriorityRanks",
                keyColumn: "PriorityRankID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 965, DateTimeKind.Local).AddTicks(1717));

            migrationBuilder.UpdateData(
                table: "PriorityRanks",
                keyColumn: "PriorityRankID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 965, DateTimeKind.Local).AddTicks(1721));

            migrationBuilder.UpdateData(
                table: "PriorityRanks",
                keyColumn: "PriorityRankID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 965, DateTimeKind.Local).AddTicks(1725));

            migrationBuilder.UpdateData(
                table: "ProductFrequencies",
                keyColumn: "ProductFrequencyID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 953, DateTimeKind.Local).AddTicks(5907));

            migrationBuilder.UpdateData(
                table: "ProductFrequencies",
                keyColumn: "ProductFrequencyID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 953, DateTimeKind.Local).AddTicks(6288));

            migrationBuilder.UpdateData(
                table: "ProductFrequencies",
                keyColumn: "ProductFrequencyID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 953, DateTimeKind.Local).AddTicks(6296));

            migrationBuilder.UpdateData(
                table: "ProductFrequencies",
                keyColumn: "ProductFrequencyID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 953, DateTimeKind.Local).AddTicks(6304));

            migrationBuilder.UpdateData(
                table: "ProductFrequencies",
                keyColumn: "ProductFrequencyID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 953, DateTimeKind.Local).AddTicks(6308));

            migrationBuilder.UpdateData(
                table: "RelationshipTypes",
                keyColumn: "RelationshipTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 959, DateTimeKind.Local).AddTicks(735));

            migrationBuilder.UpdateData(
                table: "RelationshipTypes",
                keyColumn: "RelationshipTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 959, DateTimeKind.Local).AddTicks(1082));

            migrationBuilder.UpdateData(
                table: "RelationshipTypes",
                keyColumn: "RelationshipTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 959, DateTimeKind.Local).AddTicks(1085));

            migrationBuilder.UpdateData(
                table: "RelationshipTypes",
                keyColumn: "RelationshipTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 959, DateTimeKind.Local).AddTicks(1088));

            migrationBuilder.UpdateData(
                table: "RelationshipTypes",
                keyColumn: "RelationshipTypeID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 959, DateTimeKind.Local).AddTicks(1090));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 939, DateTimeKind.Local).AddTicks(4631));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 939, DateTimeKind.Local).AddTicks(4738));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 939, DateTimeKind.Local).AddTicks(4740));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 939, DateTimeKind.Local).AddTicks(4742));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 939, DateTimeKind.Local).AddTicks(4743));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 939, DateTimeKind.Local).AddTicks(4748));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 939, DateTimeKind.Local).AddTicks(4750));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 939, DateTimeKind.Local).AddTicks(4751));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 939, DateTimeKind.Local).AddTicks(4795));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 939, DateTimeKind.Local).AddTicks(4799));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 939, DateTimeKind.Local).AddTicks(4801));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 939, DateTimeKind.Local).AddTicks(4802));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 13,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 939, DateTimeKind.Local).AddTicks(4804));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 14,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 939, DateTimeKind.Local).AddTicks(4805));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 15,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 939, DateTimeKind.Local).AddTicks(4807));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 16,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 939, DateTimeKind.Local).AddTicks(4808));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 17,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 939, DateTimeKind.Local).AddTicks(4810));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 18,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 939, DateTimeKind.Local).AddTicks(4813));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 19,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 939, DateTimeKind.Local).AddTicks(4814));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 20,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 939, DateTimeKind.Local).AddTicks(4816));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 21,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 939, DateTimeKind.Local).AddTicks(4817));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 22,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 939, DateTimeKind.Local).AddTicks(4819));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 23,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 939, DateTimeKind.Local).AddTicks(4820));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 24,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 939, DateTimeKind.Local).AddTicks(4822));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 25,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 939, DateTimeKind.Local).AddTicks(4823));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 26,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 939, DateTimeKind.Local).AddTicks(4825));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 27,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 939, DateTimeKind.Local).AddTicks(4826));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 28,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 939, DateTimeKind.Local).AddTicks(4828));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 29,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 939, DateTimeKind.Local).AddTicks(4830));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 30,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 939, DateTimeKind.Local).AddTicks(4831));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 31,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 939, DateTimeKind.Local).AddTicks(4833));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 32,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 939, DateTimeKind.Local).AddTicks(4834));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 33,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 939, DateTimeKind.Local).AddTicks(4836));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 34,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 939, DateTimeKind.Local).AddTicks(4839));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 35,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 939, DateTimeKind.Local).AddTicks(4840));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 36,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 939, DateTimeKind.Local).AddTicks(4842));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 37,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 939, DateTimeKind.Local).AddTicks(4843));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 38,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 939, DateTimeKind.Local).AddTicks(4845));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 39,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 939, DateTimeKind.Local).AddTicks(4846));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 40,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 939, DateTimeKind.Local).AddTicks(4848));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 41,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 939, DateTimeKind.Local).AddTicks(4850));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 42,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 939, DateTimeKind.Local).AddTicks(4851));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 43,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 939, DateTimeKind.Local).AddTicks(4853));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 44,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 939, DateTimeKind.Local).AddTicks(4854));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 45,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 939, DateTimeKind.Local).AddTicks(4856));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 46,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 939, DateTimeKind.Local).AddTicks(4857));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 47,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 939, DateTimeKind.Local).AddTicks(4859));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 48,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 939, DateTimeKind.Local).AddTicks(4860));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 49,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 939, DateTimeKind.Local).AddTicks(4862));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 50,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 939, DateTimeKind.Local).AddTicks(4863));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 51,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 939, DateTimeKind.Local).AddTicks(4865));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 52,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 939, DateTimeKind.Local).AddTicks(4866));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 53,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 939, DateTimeKind.Local).AddTicks(4868));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 54,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 939, DateTimeKind.Local).AddTicks(4869));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 55,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 939, DateTimeKind.Local).AddTicks(4871));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 56,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 939, DateTimeKind.Local).AddTicks(4872));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 931, DateTimeKind.Local).AddTicks(594));

            migrationBuilder.UpdateData(
                table: "SystemVariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 961, DateTimeKind.Local).AddTicks(1113));

            migrationBuilder.UpdateData(
                table: "SystemVariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 961, DateTimeKind.Local).AddTicks(1243));

            migrationBuilder.UpdateData(
                table: "SystemVariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 961, DateTimeKind.Local).AddTicks(1239));

            migrationBuilder.UpdateData(
                table: "SystemVariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 961, DateTimeKind.Local).AddTicks(1235));

            migrationBuilder.UpdateData(
                table: "SystemVariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 961, DateTimeKind.Local).AddTicks(1229));

            migrationBuilder.UpdateData(
                table: "SystemVariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 961, DateTimeKind.Local).AddTicks(1251));

            migrationBuilder.UpdateData(
                table: "SystemVariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 961, DateTimeKind.Local).AddTicks(1261));

            migrationBuilder.UpdateData(
                table: "SystemVariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 961, DateTimeKind.Local).AddTicks(1265));

            migrationBuilder.UpdateData(
                table: "SystemVariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 961, DateTimeKind.Local).AddTicks(1269));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 946, DateTimeKind.Local).AddTicks(1572));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 946, DateTimeKind.Local).AddTicks(2010));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 946, DateTimeKind.Local).AddTicks(2018));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 946, DateTimeKind.Local).AddTicks(2021));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 946, DateTimeKind.Local).AddTicks(2024));

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumns: new[] { "UserID", "RoleID" },
                keyValues: new object[] { 1, 1 },
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 975, DateTimeKind.Local).AddTicks(5194));

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumns: new[] { "UserID", "RoleID" },
                keyValues: new object[] { 2, 1 },
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 975, DateTimeKind.Local).AddTicks(5263));

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "UserTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 956, DateTimeKind.Local).AddTicks(8383));

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "UserTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 956, DateTimeKind.Local).AddTicks(9033));

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "UserTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 956, DateTimeKind.Local).AddTicks(9045));

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "UserTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 956, DateTimeKind.Local).AddTicks(9051));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 965, DateTimeKind.Local).AddTicks(8601));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 968, DateTimeKind.Local).AddTicks(1272));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 968, DateTimeKind.Local).AddTicks(1434));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 20, 17, 16, 10, 968, DateTimeKind.Local).AddTicks(1443));
        }
    }
}
