using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SmartDataAccess.Migrations
{
    public partial class NewPermission : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "BankAccountTypes",
                keyColumn: "BankAccountTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 104, DateTimeKind.Local).AddTicks(9290));

            migrationBuilder.UpdateData(
                table: "BankAccountTypes",
                keyColumn: "BankAccountTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 104, DateTimeKind.Local).AddTicks(9676));

            migrationBuilder.UpdateData(
                table: "BankAccountTypes",
                keyColumn: "BankAccountTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 104, DateTimeKind.Local).AddTicks(9683));

            migrationBuilder.UpdateData(
                table: "BankAccountTypes",
                keyColumn: "BankAccountTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 104, DateTimeKind.Local).AddTicks(9686));

            migrationBuilder.UpdateData(
                table: "ClientAccountTypes",
                keyColumn: "ID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 152, DateTimeKind.Local).AddTicks(6292));

            migrationBuilder.UpdateData(
                table: "ClientAccountTypes",
                keyColumn: "ID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 153, DateTimeKind.Local).AddTicks(227));

            migrationBuilder.UpdateData(
                table: "ContactTypes",
                keyColumn: "ContactTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 113, DateTimeKind.Local).AddTicks(2031));

            migrationBuilder.UpdateData(
                table: "ContactTypes",
                keyColumn: "ContactTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 113, DateTimeKind.Local).AddTicks(2025));

            migrationBuilder.UpdateData(
                table: "ContactTypes",
                keyColumn: "ContactTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 113, DateTimeKind.Local).AddTicks(2018));

            migrationBuilder.UpdateData(
                table: "ContactTypes",
                keyColumn: "ContactTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 113, DateTimeKind.Local).AddTicks(1944));

            migrationBuilder.UpdateData(
                table: "ContactTypes",
                keyColumn: "ContactTypeID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 113, DateTimeKind.Local).AddTicks(2036));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 118, DateTimeKind.Local).AddTicks(9338));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 118, DateTimeKind.Local).AddTicks(9785));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 118, DateTimeKind.Local).AddTicks(9793));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 118, DateTimeKind.Local).AddTicks(9804));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 118, DateTimeKind.Local).AddTicks(9808));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 118, DateTimeKind.Local).AddTicks(9817));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 118, DateTimeKind.Local).AddTicks(9820));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 118, DateTimeKind.Local).AddTicks(9824));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 118, DateTimeKind.Local).AddTicks(9828));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 118, DateTimeKind.Local).AddTicks(9834));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 118, DateTimeKind.Local).AddTicks(9839));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 118, DateTimeKind.Local).AddTicks(9842));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 13,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 118, DateTimeKind.Local).AddTicks(9846));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 14,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 118, DateTimeKind.Local).AddTicks(9850));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 15,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 118, DateTimeKind.Local).AddTicks(9853));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 16,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 118, DateTimeKind.Local).AddTicks(9858));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 17,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 118, DateTimeKind.Local).AddTicks(9861));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 18,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 118, DateTimeKind.Local).AddTicks(9867));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 19,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 118, DateTimeKind.Local).AddTicks(9871));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 20,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 118, DateTimeKind.Local).AddTicks(9874));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 21,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 118, DateTimeKind.Local).AddTicks(9877));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 22,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 118, DateTimeKind.Local).AddTicks(9881));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 23,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 118, DateTimeKind.Local).AddTicks(9884));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 24,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 118, DateTimeKind.Local).AddTicks(9888));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 25,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 118, DateTimeKind.Local).AddTicks(9891));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 26,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 118, DateTimeKind.Local).AddTicks(9895));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 27,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 118, DateTimeKind.Local).AddTicks(9900));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 28,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 118, DateTimeKind.Local).AddTicks(9903));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 29,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 118, DateTimeKind.Local).AddTicks(9907));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 30,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 118, DateTimeKind.Local).AddTicks(9912));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 31,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 118, DateTimeKind.Local).AddTicks(9915));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 32,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 118, DateTimeKind.Local).AddTicks(9919));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 33,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 118, DateTimeKind.Local).AddTicks(9923));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 34,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 118, DateTimeKind.Local).AddTicks(9929));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 35,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 118, DateTimeKind.Local).AddTicks(9932));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 36,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 118, DateTimeKind.Local).AddTicks(9936));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 37,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 118, DateTimeKind.Local).AddTicks(9939));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 38,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 118, DateTimeKind.Local).AddTicks(9942));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 39,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 118, DateTimeKind.Local).AddTicks(9947));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 40,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 118, DateTimeKind.Local).AddTicks(9951));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 41,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 118, DateTimeKind.Local).AddTicks(9955));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 42,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 118, DateTimeKind.Local).AddTicks(9959));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 43,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 118, DateTimeKind.Local).AddTicks(9962));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 44,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 118, DateTimeKind.Local).AddTicks(9966));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 45,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 118, DateTimeKind.Local).AddTicks(9969));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 46,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 118, DateTimeKind.Local).AddTicks(9973));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 47,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 118, DateTimeKind.Local).AddTicks(9977));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 48,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 118, DateTimeKind.Local).AddTicks(9982));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 49,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 118, DateTimeKind.Local).AddTicks(9986));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 50,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 118, DateTimeKind.Local).AddTicks(9990));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 51,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 118, DateTimeKind.Local).AddTicks(9994));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 52,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 118, DateTimeKind.Local).AddTicks(9998));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 53,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 119, DateTimeKind.Local).AddTicks(2));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 54,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 119, DateTimeKind.Local).AddTicks(5));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 55,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 119, DateTimeKind.Local).AddTicks(9));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 56,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 119, DateTimeKind.Local).AddTicks(13));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 57,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 119, DateTimeKind.Local).AddTicks(16));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 58,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 119, DateTimeKind.Local).AddTicks(70));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 59,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 119, DateTimeKind.Local).AddTicks(76));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 60,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 119, DateTimeKind.Local).AddTicks(80));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 61,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 119, DateTimeKind.Local).AddTicks(84));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 62,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 119, DateTimeKind.Local).AddTicks(87));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 63,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 119, DateTimeKind.Local).AddTicks(91));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 64,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 119, DateTimeKind.Local).AddTicks(95));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 65,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 119, DateTimeKind.Local).AddTicks(99));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 66,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 119, DateTimeKind.Local).AddTicks(105));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 67,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 119, DateTimeKind.Local).AddTicks(108));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 68,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 119, DateTimeKind.Local).AddTicks(112));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 69,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 119, DateTimeKind.Local).AddTicks(116));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 70,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 119, DateTimeKind.Local).AddTicks(119));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 71,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 119, DateTimeKind.Local).AddTicks(122));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 72,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 119, DateTimeKind.Local).AddTicks(127));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 73,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 119, DateTimeKind.Local).AddTicks(131));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 74,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 119, DateTimeKind.Local).AddTicks(134));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 75,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 119, DateTimeKind.Local).AddTicks(138));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 76,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 119, DateTimeKind.Local).AddTicks(142));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 77,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 119, DateTimeKind.Local).AddTicks(145));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 78,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 119, DateTimeKind.Local).AddTicks(149));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 79,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 119, DateTimeKind.Local).AddTicks(152));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 80,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 119, DateTimeKind.Local).AddTicks(156));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 81,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 119, DateTimeKind.Local).AddTicks(159));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 82,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 119, DateTimeKind.Local).AddTicks(163));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 83,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 119, DateTimeKind.Local).AddTicks(166));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 84,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 119, DateTimeKind.Local).AddTicks(169));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 85,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 119, DateTimeKind.Local).AddTicks(173));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 86,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 119, DateTimeKind.Local).AddTicks(177));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 87,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 119, DateTimeKind.Local).AddTicks(180));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 88,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 119, DateTimeKind.Local).AddTicks(184));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 89,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 119, DateTimeKind.Local).AddTicks(188));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 90,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 119, DateTimeKind.Local).AddTicks(191));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 91,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 119, DateTimeKind.Local).AddTicks(195));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 92,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 119, DateTimeKind.Local).AddTicks(198));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 93,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 119, DateTimeKind.Local).AddTicks(202));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 94,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 119, DateTimeKind.Local).AddTicks(205));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 95,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 119, DateTimeKind.Local).AddTicks(209));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 96,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 119, DateTimeKind.Local).AddTicks(212));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 97,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 119, DateTimeKind.Local).AddTicks(215));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 98,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 119, DateTimeKind.Local).AddTicks(219));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 99,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 119, DateTimeKind.Local).AddTicks(222));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 100,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 119, DateTimeKind.Local).AddTicks(225));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 101,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 119, DateTimeKind.Local).AddTicks(230));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 102,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 119, DateTimeKind.Local).AddTicks(233));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 103,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 119, DateTimeKind.Local).AddTicks(237));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 104,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 119, DateTimeKind.Local).AddTicks(240));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 105,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 119, DateTimeKind.Local).AddTicks(243));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 106,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 119, DateTimeKind.Local).AddTicks(247));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 107,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 119, DateTimeKind.Local).AddTicks(250));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 108,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 119, DateTimeKind.Local).AddTicks(254));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 109,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 119, DateTimeKind.Local).AddTicks(258));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 110,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 119, DateTimeKind.Local).AddTicks(261));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 111,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 119, DateTimeKind.Local).AddTicks(265));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 112,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 119, DateTimeKind.Local).AddTicks(269));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 113,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 119, DateTimeKind.Local).AddTicks(272));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 114,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 119, DateTimeKind.Local).AddTicks(276));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 115,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 119, DateTimeKind.Local).AddTicks(279));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 116,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 119, DateTimeKind.Local).AddTicks(283));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 117,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 119, DateTimeKind.Local).AddTicks(287));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 118,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 119, DateTimeKind.Local).AddTicks(290));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 119,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 119, DateTimeKind.Local).AddTicks(327));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 120,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 119, DateTimeKind.Local).AddTicks(331));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 121,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 119, DateTimeKind.Local).AddTicks(335));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 122,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 119, DateTimeKind.Local).AddTicks(338));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 123,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 119, DateTimeKind.Local).AddTicks(342));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 124,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 119, DateTimeKind.Local).AddTicks(345));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 125,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 119, DateTimeKind.Local).AddTicks(348));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 126,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 119, DateTimeKind.Local).AddTicks(352));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 127,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 119, DateTimeKind.Local).AddTicks(355));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 128,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 119, DateTimeKind.Local).AddTicks(359));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 129,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 119, DateTimeKind.Local).AddTicks(362));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 130,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 119, DateTimeKind.Local).AddTicks(368));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 131,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 119, DateTimeKind.Local).AddTicks(372));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 132,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 119, DateTimeKind.Local).AddTicks(376));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 133,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 119, DateTimeKind.Local).AddTicks(380));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 134,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 119, DateTimeKind.Local).AddTicks(383));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 135,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 119, DateTimeKind.Local).AddTicks(386));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 136,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 119, DateTimeKind.Local).AddTicks(390));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 137,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 119, DateTimeKind.Local).AddTicks(393));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 138,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 119, DateTimeKind.Local).AddTicks(398));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 139,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 119, DateTimeKind.Local).AddTicks(401));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 140,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 119, DateTimeKind.Local).AddTicks(405));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 141,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 119, DateTimeKind.Local).AddTicks(408));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 142,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 119, DateTimeKind.Local).AddTicks(411));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 143,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 119, DateTimeKind.Local).AddTicks(415));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 144,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 119, DateTimeKind.Local).AddTicks(419));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 145,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 119, DateTimeKind.Local).AddTicks(422));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 146,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 119, DateTimeKind.Local).AddTicks(426));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 147,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 119, DateTimeKind.Local).AddTicks(429));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 148,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 119, DateTimeKind.Local).AddTicks(432));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 149,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 119, DateTimeKind.Local).AddTicks(437));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 150,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 119, DateTimeKind.Local).AddTicks(441));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 151,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 119, DateTimeKind.Local).AddTicks(445));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 152,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 119, DateTimeKind.Local).AddTicks(448));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 153,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 119, DateTimeKind.Local).AddTicks(452));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 154,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 119, DateTimeKind.Local).AddTicks(455));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 155,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 119, DateTimeKind.Local).AddTicks(460));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 156,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 119, DateTimeKind.Local).AddTicks(463));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 157,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 119, DateTimeKind.Local).AddTicks(467));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 158,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 119, DateTimeKind.Local).AddTicks(470));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 159,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 119, DateTimeKind.Local).AddTicks(474));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 160,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 119, DateTimeKind.Local).AddTicks(477));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 161,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 119, DateTimeKind.Local).AddTicks(482));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 162,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 119, DateTimeKind.Local).AddTicks(485));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 163,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 119, DateTimeKind.Local).AddTicks(488));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 164,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 119, DateTimeKind.Local).AddTicks(492));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 165,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 119, DateTimeKind.Local).AddTicks(495));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 166,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 119, DateTimeKind.Local).AddTicks(499));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 167,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 119, DateTimeKind.Local).AddTicks(503));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 168,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 119, DateTimeKind.Local).AddTicks(506));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 169,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 119, DateTimeKind.Local).AddTicks(509));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 170,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 119, DateTimeKind.Local).AddTicks(513));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 171,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 119, DateTimeKind.Local).AddTicks(516));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 172,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 119, DateTimeKind.Local).AddTicks(520));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 173,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 119, DateTimeKind.Local).AddTicks(561));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 174,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 119, DateTimeKind.Local).AddTicks(567));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 175,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 119, DateTimeKind.Local).AddTicks(571));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 176,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 119, DateTimeKind.Local).AddTicks(576));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 177,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 119, DateTimeKind.Local).AddTicks(581));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 178,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 119, DateTimeKind.Local).AddTicks(585));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 179,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 119, DateTimeKind.Local).AddTicks(589));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 180,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 119, DateTimeKind.Local).AddTicks(593));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 181,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 119, DateTimeKind.Local).AddTicks(597));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 182,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 119, DateTimeKind.Local).AddTicks(601));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 183,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 119, DateTimeKind.Local).AddTicks(604));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 184,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 119, DateTimeKind.Local).AddTicks(608));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 185,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 119, DateTimeKind.Local).AddTicks(611));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 186,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 119, DateTimeKind.Local).AddTicks(615));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 187,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 119, DateTimeKind.Local).AddTicks(618));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 188,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 119, DateTimeKind.Local).AddTicks(622));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 189,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 119, DateTimeKind.Local).AddTicks(626));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 190,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 119, DateTimeKind.Local).AddTicks(629));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 191,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 119, DateTimeKind.Local).AddTicks(633));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 192,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 119, DateTimeKind.Local).AddTicks(636));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 193,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 119, DateTimeKind.Local).AddTicks(640));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 194,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 119, DateTimeKind.Local).AddTicks(644));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 195,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 119, DateTimeKind.Local).AddTicks(647));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 196,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 119, DateTimeKind.Local).AddTicks(650));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 197,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 119, DateTimeKind.Local).AddTicks(653));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 198,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 119, DateTimeKind.Local).AddTicks(657));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 199,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 119, DateTimeKind.Local).AddTicks(660));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 200,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 119, DateTimeKind.Local).AddTicks(663));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 201,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 119, DateTimeKind.Local).AddTicks(667));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 202,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 119, DateTimeKind.Local).AddTicks(671));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 203,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 119, DateTimeKind.Local).AddTicks(674));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 204,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 119, DateTimeKind.Local).AddTicks(678));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 205,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 119, DateTimeKind.Local).AddTicks(681));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 206,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 119, DateTimeKind.Local).AddTicks(685));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 207,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 119, DateTimeKind.Local).AddTicks(688));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 208,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 119, DateTimeKind.Local).AddTicks(692));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 209,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 119, DateTimeKind.Local).AddTicks(696));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 210,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 119, DateTimeKind.Local).AddTicks(700));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 211,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 119, DateTimeKind.Local).AddTicks(703));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 212,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 119, DateTimeKind.Local).AddTicks(706));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 213,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 119, DateTimeKind.Local).AddTicks(710));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 214,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 119, DateTimeKind.Local).AddTicks(714));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 215,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 119, DateTimeKind.Local).AddTicks(718));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 216,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 119, DateTimeKind.Local).AddTicks(722));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 217,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 119, DateTimeKind.Local).AddTicks(725));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 218,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 119, DateTimeKind.Local).AddTicks(729));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 219,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 119, DateTimeKind.Local).AddTicks(732));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 220,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 119, DateTimeKind.Local).AddTicks(735));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 221,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 119, DateTimeKind.Local).AddTicks(738));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 222,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 119, DateTimeKind.Local).AddTicks(743));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 223,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 119, DateTimeKind.Local).AddTicks(746));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 224,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 119, DateTimeKind.Local).AddTicks(750));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 225,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 119, DateTimeKind.Local).AddTicks(754));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 226,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 119, DateTimeKind.Local).AddTicks(758));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 227,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 119, DateTimeKind.Local).AddTicks(761));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 228,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 119, DateTimeKind.Local).AddTicks(764));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 107, DateTimeKind.Local).AddTicks(3044));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 107, DateTimeKind.Local).AddTicks(3551));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 107, DateTimeKind.Local).AddTicks(3558));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 107, DateTimeKind.Local).AddTicks(3563));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 107, DateTimeKind.Local).AddTicks(3567));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 107, DateTimeKind.Local).AddTicks(3577));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 107, DateTimeKind.Local).AddTicks(3581));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 107, DateTimeKind.Local).AddTicks(3584));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 107, DateTimeKind.Local).AddTicks(3587));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 107, DateTimeKind.Local).AddTicks(3593));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 107, DateTimeKind.Local).AddTicks(3596));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 107, DateTimeKind.Local).AddTicks(3600));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 13,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 107, DateTimeKind.Local).AddTicks(3603));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 14,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 107, DateTimeKind.Local).AddTicks(3607));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 15,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 107, DateTimeKind.Local).AddTicks(3610));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 16,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 107, DateTimeKind.Local).AddTicks(3614));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 17,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 107, DateTimeKind.Local).AddTicks(3617));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 18,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 107, DateTimeKind.Local).AddTicks(3622));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 19,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 107, DateTimeKind.Local).AddTicks(3626));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 20,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 107, DateTimeKind.Local).AddTicks(3688));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 21,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 107, DateTimeKind.Local).AddTicks(3692));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 22,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 107, DateTimeKind.Local).AddTicks(3696));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 23,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 107, DateTimeKind.Local).AddTicks(3700));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 24,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 107, DateTimeKind.Local).AddTicks(3703));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 25,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 107, DateTimeKind.Local).AddTicks(3706));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 26,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 107, DateTimeKind.Local).AddTicks(3710));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 27,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 107, DateTimeKind.Local).AddTicks(3713));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 28,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 107, DateTimeKind.Local).AddTicks(3716));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 29,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 107, DateTimeKind.Local).AddTicks(3720));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 30,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 107, DateTimeKind.Local).AddTicks(3723));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 31,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 107, DateTimeKind.Local).AddTicks(3727));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 32,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 107, DateTimeKind.Local).AddTicks(3730));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 33,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 107, DateTimeKind.Local).AddTicks(3733));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 34,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 107, DateTimeKind.Local).AddTicks(3739));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 35,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 107, DateTimeKind.Local).AddTicks(3742));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 36,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 107, DateTimeKind.Local).AddTicks(3745));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 37,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 107, DateTimeKind.Local).AddTicks(3749));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 38,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 107, DateTimeKind.Local).AddTicks(3752));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 39,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 107, DateTimeKind.Local).AddTicks(3756));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 40,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 107, DateTimeKind.Local).AddTicks(3759));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 41,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 107, DateTimeKind.Local).AddTicks(3763));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 42,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 107, DateTimeKind.Local).AddTicks(3766));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 43,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 107, DateTimeKind.Local).AddTicks(3770));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 44,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 107, DateTimeKind.Local).AddTicks(3773));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 45,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 107, DateTimeKind.Local).AddTicks(3776));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 46,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 107, DateTimeKind.Local).AddTicks(3779));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 47,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 107, DateTimeKind.Local).AddTicks(3783));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 48,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 107, DateTimeKind.Local).AddTicks(3786));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 49,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 107, DateTimeKind.Local).AddTicks(3789));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 50,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 107, DateTimeKind.Local).AddTicks(3793));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 51,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 107, DateTimeKind.Local).AddTicks(3796));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 52,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 107, DateTimeKind.Local).AddTicks(3799));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 53,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 107, DateTimeKind.Local).AddTicks(3803));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 54,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 107, DateTimeKind.Local).AddTicks(3806));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 55,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 107, DateTimeKind.Local).AddTicks(3809));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 56,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 107, DateTimeKind.Local).AddTicks(3813));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 57,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 107, DateTimeKind.Local).AddTicks(3816));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 58,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 107, DateTimeKind.Local).AddTicks(3819));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 59,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 107, DateTimeKind.Local).AddTicks(3823));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 60,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 107, DateTimeKind.Local).AddTicks(3826));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 61,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 107, DateTimeKind.Local).AddTicks(3829));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 62,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 107, DateTimeKind.Local).AddTicks(3833));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 63,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 107, DateTimeKind.Local).AddTicks(3836));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 64,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 107, DateTimeKind.Local).AddTicks(3840));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 65,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 107, DateTimeKind.Local).AddTicks(3843));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 66,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 107, DateTimeKind.Local).AddTicks(3849));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 67,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 107, DateTimeKind.Local).AddTicks(3852));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 68,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 107, DateTimeKind.Local).AddTicks(3855));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 69,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 107, DateTimeKind.Local).AddTicks(3859));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 70,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 107, DateTimeKind.Local).AddTicks(3862));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 71,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 107, DateTimeKind.Local).AddTicks(3865));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 72,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 107, DateTimeKind.Local).AddTicks(3869));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 73,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 107, DateTimeKind.Local).AddTicks(3872));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 74,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 107, DateTimeKind.Local).AddTicks(3875));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 75,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 107, DateTimeKind.Local).AddTicks(3878));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 76,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 107, DateTimeKind.Local).AddTicks(3882));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 77,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 107, DateTimeKind.Local).AddTicks(3885));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 78,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 107, DateTimeKind.Local).AddTicks(3888));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 79,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 107, DateTimeKind.Local).AddTicks(3892));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 80,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 107, DateTimeKind.Local).AddTicks(3895));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 81,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 107, DateTimeKind.Local).AddTicks(3898));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 82,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 107, DateTimeKind.Local).AddTicks(3902));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 83,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 107, DateTimeKind.Local).AddTicks(3943));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 84,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 107, DateTimeKind.Local).AddTicks(3947));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 85,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 107, DateTimeKind.Local).AddTicks(3951));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 86,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 107, DateTimeKind.Local).AddTicks(3954));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 87,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 107, DateTimeKind.Local).AddTicks(3957));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 88,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 107, DateTimeKind.Local).AddTicks(3961));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 89,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 107, DateTimeKind.Local).AddTicks(3964));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 90,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 107, DateTimeKind.Local).AddTicks(3967));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 91,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 107, DateTimeKind.Local).AddTicks(3971));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 92,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 107, DateTimeKind.Local).AddTicks(3974));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 93,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 107, DateTimeKind.Local).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 94,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 107, DateTimeKind.Local).AddTicks(3980));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 95,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 107, DateTimeKind.Local).AddTicks(3984));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 96,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 107, DateTimeKind.Local).AddTicks(3987));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 97,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 107, DateTimeKind.Local).AddTicks(3990));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 98,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 107, DateTimeKind.Local).AddTicks(3993));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 99,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 107, DateTimeKind.Local).AddTicks(3997));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 100,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 107, DateTimeKind.Local).AddTicks(4000));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 101,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 107, DateTimeKind.Local).AddTicks(4003));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 102,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 107, DateTimeKind.Local).AddTicks(4007));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 103,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 107, DateTimeKind.Local).AddTicks(4010));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 104,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 107, DateTimeKind.Local).AddTicks(4014));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 105,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 107, DateTimeKind.Local).AddTicks(4017));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 106,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 107, DateTimeKind.Local).AddTicks(4020));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 107,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 107, DateTimeKind.Local).AddTicks(4024));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 108,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 107, DateTimeKind.Local).AddTicks(4027));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 109,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 107, DateTimeKind.Local).AddTicks(4030));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 110,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 107, DateTimeKind.Local).AddTicks(4033));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 111,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 107, DateTimeKind.Local).AddTicks(4036));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 112,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 107, DateTimeKind.Local).AddTicks(4040));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 113,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 107, DateTimeKind.Local).AddTicks(4043));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 114,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 107, DateTimeKind.Local).AddTicks(4047));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 115,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 107, DateTimeKind.Local).AddTicks(4050));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 116,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 107, DateTimeKind.Local).AddTicks(4053));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 117,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 107, DateTimeKind.Local).AddTicks(4057));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 118,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 107, DateTimeKind.Local).AddTicks(4060));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 119,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 107, DateTimeKind.Local).AddTicks(4063));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 120,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 107, DateTimeKind.Local).AddTicks(4067));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 121,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 107, DateTimeKind.Local).AddTicks(4070));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 122,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 107, DateTimeKind.Local).AddTicks(4073));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 123,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 107, DateTimeKind.Local).AddTicks(4077));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 124,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 107, DateTimeKind.Local).AddTicks(4081));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 125,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 107, DateTimeKind.Local).AddTicks(4084));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 126,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 107, DateTimeKind.Local).AddTicks(4088));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 127,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 107, DateTimeKind.Local).AddTicks(4091));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 128,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 107, DateTimeKind.Local).AddTicks(4094));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 129,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 107, DateTimeKind.Local).AddTicks(4098));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 130,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 107, DateTimeKind.Local).AddTicks(4104));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 131,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 107, DateTimeKind.Local).AddTicks(4107));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 132,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 107, DateTimeKind.Local).AddTicks(4110));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 133,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 107, DateTimeKind.Local).AddTicks(4113));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 134,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 107, DateTimeKind.Local).AddTicks(4117));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 135,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 107, DateTimeKind.Local).AddTicks(4120));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 136,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 107, DateTimeKind.Local).AddTicks(4124));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 137,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 107, DateTimeKind.Local).AddTicks(4127));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 138,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 107, DateTimeKind.Local).AddTicks(4130));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 139,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 107, DateTimeKind.Local).AddTicks(4133));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 140,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 107, DateTimeKind.Local).AddTicks(4137));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 141,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 107, DateTimeKind.Local).AddTicks(4140));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 142,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 107, DateTimeKind.Local).AddTicks(4179));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 143,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 107, DateTimeKind.Local).AddTicks(4183));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 144,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 107, DateTimeKind.Local).AddTicks(4186));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 145,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 107, DateTimeKind.Local).AddTicks(4190));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 146,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 107, DateTimeKind.Local).AddTicks(4193));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 147,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 107, DateTimeKind.Local).AddTicks(4196));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 148,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 107, DateTimeKind.Local).AddTicks(4199));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 149,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 107, DateTimeKind.Local).AddTicks(4203));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 150,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 107, DateTimeKind.Local).AddTicks(4206));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 151,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 107, DateTimeKind.Local).AddTicks(4209));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 152,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 107, DateTimeKind.Local).AddTicks(4212));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 153,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 107, DateTimeKind.Local).AddTicks(4216));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 154,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 107, DateTimeKind.Local).AddTicks(4219));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 155,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 107, DateTimeKind.Local).AddTicks(4222));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 156,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 107, DateTimeKind.Local).AddTicks(4225));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 157,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 107, DateTimeKind.Local).AddTicks(4229));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 158,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 107, DateTimeKind.Local).AddTicks(4232));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 159,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 107, DateTimeKind.Local).AddTicks(4235));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 160,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 107, DateTimeKind.Local).AddTicks(4239));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 161,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 107, DateTimeKind.Local).AddTicks(4242));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 162,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 107, DateTimeKind.Local).AddTicks(4245));

            migrationBuilder.UpdateData(
                table: "CustomSettingTypes",
                keyColumn: "CustomSettingTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 114, DateTimeKind.Local).AddTicks(5765));

            migrationBuilder.UpdateData(
                table: "CustomSettingTypes",
                keyColumn: "CustomSettingTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 114, DateTimeKind.Local).AddTicks(5846));

            migrationBuilder.UpdateData(
                table: "CustomSettingTypes",
                keyColumn: "CustomSettingTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 114, DateTimeKind.Local).AddTicks(5851));

            migrationBuilder.UpdateData(
                table: "CustomSettingTypes",
                keyColumn: "CustomSettingTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 114, DateTimeKind.Local).AddTicks(5855));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 142, DateTimeKind.Local).AddTicks(8686));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 142, DateTimeKind.Local).AddTicks(8854));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 142, DateTimeKind.Local).AddTicks(8878));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 142, DateTimeKind.Local).AddTicks(8860));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 142, DateTimeKind.Local).AddTicks(8883));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 142, DateTimeKind.Local).AddTicks(8894));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 142, DateTimeKind.Local).AddTicks(8900));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 142, DateTimeKind.Local).AddTicks(8904));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 142, DateTimeKind.Local).AddTicks(8911));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 142, DateTimeKind.Local).AddTicks(8917));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 142, DateTimeKind.Local).AddTicks(8970));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 142, DateTimeKind.Local).AddTicks(8977));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 13,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 142, DateTimeKind.Local).AddTicks(8982));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 14,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 142, DateTimeKind.Local).AddTicks(8988));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 15,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 142, DateTimeKind.Local).AddTicks(8866));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 16,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 142, DateTimeKind.Local).AddTicks(8847));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 17,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 142, DateTimeKind.Local).AddTicks(8995));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 18,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 142, DateTimeKind.Local).AddTicks(9000));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 19,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 142, DateTimeKind.Local).AddTicks(9004));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 20,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 142, DateTimeKind.Local).AddTicks(9010));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 22,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 142, DateTimeKind.Local).AddTicks(9031));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 23,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 142, DateTimeKind.Local).AddTicks(9021));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 24,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 142, DateTimeKind.Local).AddTicks(9016));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 25,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 142, DateTimeKind.Local).AddTicks(9027));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 26,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 142, DateTimeKind.Local).AddTicks(9037));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 27,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 142, DateTimeKind.Local).AddTicks(9043));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 28,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 142, DateTimeKind.Local).AddTicks(9048));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 30,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 142, DateTimeKind.Local).AddTicks(9053));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 31,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 142, DateTimeKind.Local).AddTicks(9058));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 32,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 142, DateTimeKind.Local).AddTicks(9063));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 33,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 142, DateTimeKind.Local).AddTicks(9068));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 34,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 142, DateTimeKind.Local).AddTicks(9073));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 36,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 142, DateTimeKind.Local).AddTicks(9230));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 37,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 142, DateTimeKind.Local).AddTicks(9236));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 38,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 142, DateTimeKind.Local).AddTicks(9241));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 39,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 142, DateTimeKind.Local).AddTicks(8889));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 40,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 142, DateTimeKind.Local).AddTicks(9246));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 41,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 142, DateTimeKind.Local).AddTicks(9256));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 42,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 142, DateTimeKind.Local).AddTicks(9260));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 43,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 142, DateTimeKind.Local).AddTicks(9251));

            migrationBuilder.UpdateData(
                table: "DocumentFormats",
                keyColumn: "DocumentFormatID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 127, DateTimeKind.Local).AddTicks(8434));

            migrationBuilder.UpdateData(
                table: "DocumentFormats",
                keyColumn: "DocumentFormatID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 127, DateTimeKind.Local).AddTicks(8831));

            migrationBuilder.UpdateData(
                table: "DocumentFormats",
                keyColumn: "DocumentFormatID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 127, DateTimeKind.Local).AddTicks(8838));

            migrationBuilder.UpdateData(
                table: "DocumentFormats",
                keyColumn: "DocumentFormatID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 127, DateTimeKind.Local).AddTicks(8841));

            migrationBuilder.UpdateData(
                table: "DocumentFormats",
                keyColumn: "DocumentFormatID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 127, DateTimeKind.Local).AddTicks(8844));

            migrationBuilder.UpdateData(
                table: "DocumentFormats",
                keyColumn: "DocumentFormatID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 127, DateTimeKind.Local).AddTicks(8853));

            migrationBuilder.UpdateData(
                table: "DocumentTypes",
                keyColumn: "DocumentTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 130, DateTimeKind.Local).AddTicks(2130));

            migrationBuilder.UpdateData(
                table: "DocumentTypes",
                keyColumn: "DocumentTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 130, DateTimeKind.Local).AddTicks(3081));

            migrationBuilder.UpdateData(
                table: "DocumentTypes",
                keyColumn: "DocumentTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 130, DateTimeKind.Local).AddTicks(3100));

            migrationBuilder.UpdateData(
                table: "DocumentTypes",
                keyColumn: "DocumentTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 130, DateTimeKind.Local).AddTicks(3104));

            migrationBuilder.UpdateData(
                table: "EmailTemplates",
                keyColumn: "EmailTemplateID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 139, DateTimeKind.Local).AddTicks(1228));

            migrationBuilder.UpdateData(
                table: "EmailTypes",
                keyColumn: "EmailTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 138, DateTimeKind.Local).AddTicks(5667));

            migrationBuilder.UpdateData(
                table: "EmailTypes",
                keyColumn: "EmailTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 138, DateTimeKind.Local).AddTicks(6028));

            migrationBuilder.UpdateData(
                table: "EmailTypes",
                keyColumn: "EmailTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 138, DateTimeKind.Local).AddTicks(6036));

            migrationBuilder.UpdateData(
                table: "EmailTypes",
                keyColumn: "EmailTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 138, DateTimeKind.Local).AddTicks(6042));

            migrationBuilder.UpdateData(
                table: "FeatureFlags",
                keyColumn: "FeatureFlagID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 125, DateTimeKind.Local).AddTicks(4838));

            migrationBuilder.UpdateData(
                table: "FeatureFlags",
                keyColumn: "FeatureFlagID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 125, DateTimeKind.Local).AddTicks(5398));

            migrationBuilder.UpdateData(
                table: "FeatureFlags",
                keyColumn: "FeatureFlagID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 125, DateTimeKind.Local).AddTicks(5408));

            migrationBuilder.UpdateData(
                table: "Frequencies",
                keyColumn: "FrequencyID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 109, DateTimeKind.Local).AddTicks(9602));

            migrationBuilder.UpdateData(
                table: "Frequencies",
                keyColumn: "FrequencyID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 110, DateTimeKind.Local).AddTicks(55));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "GenderID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 116, DateTimeKind.Local).AddTicks(5030));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "GenderID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 116, DateTimeKind.Local).AddTicks(5120));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 132, DateTimeKind.Local).AddTicks(2547));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 132, DateTimeKind.Local).AddTicks(2678));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 132, DateTimeKind.Local).AddTicks(2691));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 132, DateTimeKind.Local).AddTicks(2697));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 132, DateTimeKind.Local).AddTicks(2702));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 999,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 132, DateTimeKind.Local).AddTicks(2716));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 9998,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 132, DateTimeKind.Local).AddTicks(2710));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 134, DateTimeKind.Local).AddTicks(2059));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 134, DateTimeKind.Local).AddTicks(2222));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 134, DateTimeKind.Local).AddTicks(2227));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 134, DateTimeKind.Local).AddTicks(2231));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 134, DateTimeKind.Local).AddTicks(2234));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 134, DateTimeKind.Local).AddTicks(2242));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 134, DateTimeKind.Local).AddTicks(2245));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 134, DateTimeKind.Local).AddTicks(2249));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 134, DateTimeKind.Local).AddTicks(2253));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 134, DateTimeKind.Local).AddTicks(2258));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 134, DateTimeKind.Local).AddTicks(2261));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 134, DateTimeKind.Local).AddTicks(2264));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 13,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 134, DateTimeKind.Local).AddTicks(2268));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 14,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 134, DateTimeKind.Local).AddTicks(2272));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 15,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 134, DateTimeKind.Local).AddTicks(2275));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 16,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 134, DateTimeKind.Local).AddTicks(2342));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 17,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 134, DateTimeKind.Local).AddTicks(2346));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 18,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 134, DateTimeKind.Local).AddTicks(2351));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 19,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 134, DateTimeKind.Local).AddTicks(2354));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 20,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 134, DateTimeKind.Local).AddTicks(2358));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 9998,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 134, DateTimeKind.Local).AddTicks(2361));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 9999,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 134, DateTimeKind.Local).AddTicks(2365));

            migrationBuilder.UpdateData(
                table: "PaymentStatus",
                keyColumn: "PaymentStatusID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 99, DateTimeKind.Local).AddTicks(5202));

            migrationBuilder.UpdateData(
                table: "PaymentStatus",
                keyColumn: "PaymentStatusID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 99, DateTimeKind.Local).AddTicks(5602));

            migrationBuilder.UpdateData(
                table: "PaymentStatus",
                keyColumn: "PaymentStatusID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 99, DateTimeKind.Local).AddTicks(5608));

            migrationBuilder.UpdateData(
                table: "PaymentStatus",
                keyColumn: "PaymentStatusID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 99, DateTimeKind.Local).AddTicks(5611));

            migrationBuilder.UpdateData(
                table: "PaymentStatus",
                keyColumn: "PaymentStatusID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 99, DateTimeKind.Local).AddTicks(5615));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 96, DateTimeKind.Local).AddTicks(5321));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 96, DateTimeKind.Local).AddTicks(5728));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 96, DateTimeKind.Local).AddTicks(5736));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 96, DateTimeKind.Local).AddTicks(5741));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 96, DateTimeKind.Local).AddTicks(5746));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 96, DateTimeKind.Local).AddTicks(5759));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 96, DateTimeKind.Local).AddTicks(5763));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 96, DateTimeKind.Local).AddTicks(5767));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 96, DateTimeKind.Local).AddTicks(5771));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 96, DateTimeKind.Local).AddTicks(5777));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 96, DateTimeKind.Local).AddTicks(5782));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 96, DateTimeKind.Local).AddTicks(5834));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 13,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 96, DateTimeKind.Local).AddTicks(5839));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 14,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 96, DateTimeKind.Local).AddTicks(5844));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 15,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 96, DateTimeKind.Local).AddTicks(5848));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 16,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 96, DateTimeKind.Local).AddTicks(5852));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 17,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 96, DateTimeKind.Local).AddTicks(5857));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 18,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 96, DateTimeKind.Local).AddTicks(5863));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 19,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 96, DateTimeKind.Local).AddTicks(5868));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 20,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 96, DateTimeKind.Local).AddTicks(5872));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 21,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 96, DateTimeKind.Local).AddTicks(5876));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 22,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 96, DateTimeKind.Local).AddTicks(5880));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 23,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 96, DateTimeKind.Local).AddTicks(5885));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 24,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 96, DateTimeKind.Local).AddTicks(5889));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 25,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 96, DateTimeKind.Local).AddTicks(5894));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 26,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 96, DateTimeKind.Local).AddTicks(5899));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 27,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 96, DateTimeKind.Local).AddTicks(5904));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 28,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 96, DateTimeKind.Local).AddTicks(5908));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 29,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 96, DateTimeKind.Local).AddTicks(5912));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 30,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 96, DateTimeKind.Local).AddTicks(5917));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 31,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 96, DateTimeKind.Local).AddTicks(5922));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 32,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 96, DateTimeKind.Local).AddTicks(5926));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 33,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 96, DateTimeKind.Local).AddTicks(5931));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 34,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 96, DateTimeKind.Local).AddTicks(5938));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 35,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 96, DateTimeKind.Local).AddTicks(5942));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 36,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 96, DateTimeKind.Local).AddTicks(5947));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 37,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 96, DateTimeKind.Local).AddTicks(5951));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 38,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 96, DateTimeKind.Local).AddTicks(5955));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 39,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 96, DateTimeKind.Local).AddTicks(5959));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 40,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 96, DateTimeKind.Local).AddTicks(5963));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 41,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 96, DateTimeKind.Local).AddTicks(5967));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 42,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 96, DateTimeKind.Local).AddTicks(5971));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 43,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 96, DateTimeKind.Local).AddTicks(5975));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 44,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 96, DateTimeKind.Local).AddTicks(5979));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 45,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 96, DateTimeKind.Local).AddTicks(5983));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 46,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 96, DateTimeKind.Local).AddTicks(5988));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 47,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 96, DateTimeKind.Local).AddTicks(5992));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 48,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 96, DateTimeKind.Local).AddTicks(5996));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 49,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 96, DateTimeKind.Local).AddTicks(6000));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 50,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 96, DateTimeKind.Local).AddTicks(6004));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 51,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 96, DateTimeKind.Local).AddTicks(6008));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 52,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 96, DateTimeKind.Local).AddTicks(6049));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 53,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 96, DateTimeKind.Local).AddTicks(6054));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 54,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 96, DateTimeKind.Local).AddTicks(6058));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 55,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 96, DateTimeKind.Local).AddTicks(6062));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 56,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 96, DateTimeKind.Local).AddTicks(6066));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 57,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 96, DateTimeKind.Local).AddTicks(6070));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 58,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 96, DateTimeKind.Local).AddTicks(6074));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 59,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 96, DateTimeKind.Local).AddTicks(6079));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 60,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 96, DateTimeKind.Local).AddTicks(6083));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 61,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 96, DateTimeKind.Local).AddTicks(6087));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 62,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 96, DateTimeKind.Local).AddTicks(6091));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 63,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 96, DateTimeKind.Local).AddTicks(6095));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 64,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 96, DateTimeKind.Local).AddTicks(6099));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 65,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 96, DateTimeKind.Local).AddTicks(6103));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 66,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 96, DateTimeKind.Local).AddTicks(6109));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 67,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 96, DateTimeKind.Local).AddTicks(6114));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 68,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 96, DateTimeKind.Local).AddTicks(6117));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 69,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 96, DateTimeKind.Local).AddTicks(6121));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 70,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 96, DateTimeKind.Local).AddTicks(6125));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 71,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 96, DateTimeKind.Local).AddTicks(6129));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 72,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 96, DateTimeKind.Local).AddTicks(6132));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 73,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 96, DateTimeKind.Local).AddTicks(6136));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 74,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 96, DateTimeKind.Local).AddTicks(6140));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 75,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 96, DateTimeKind.Local).AddTicks(6144));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 76,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 96, DateTimeKind.Local).AddTicks(6148));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 77,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 96, DateTimeKind.Local).AddTicks(6152));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 78,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 96, DateTimeKind.Local).AddTicks(6156));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 79,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 96, DateTimeKind.Local).AddTicks(6160));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 80,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 96, DateTimeKind.Local).AddTicks(6165));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 81,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 96, DateTimeKind.Local).AddTicks(6169));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 82,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 96, DateTimeKind.Local).AddTicks(6173));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 83,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 96, DateTimeKind.Local).AddTicks(6178));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 84,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 96, DateTimeKind.Local).AddTicks(6182));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 85,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 96, DateTimeKind.Local).AddTicks(6186));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 86,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 96, DateTimeKind.Local).AddTicks(6189));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 87,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 96, DateTimeKind.Local).AddTicks(6193));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 88,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 96, DateTimeKind.Local).AddTicks(6197));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 89,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 96, DateTimeKind.Local).AddTicks(6202));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 90,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 96, DateTimeKind.Local).AddTicks(6206));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 91,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 96, DateTimeKind.Local).AddTicks(6210));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 92,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 96, DateTimeKind.Local).AddTicks(6214));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 93,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 96, DateTimeKind.Local).AddTicks(6255));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 94,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 96, DateTimeKind.Local).AddTicks(6260));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 95,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 96, DateTimeKind.Local).AddTicks(6264));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 96,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 96, DateTimeKind.Local).AddTicks(6268));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 97,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 96, DateTimeKind.Local).AddTicks(6272));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 98,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 96, DateTimeKind.Local).AddTicks(6276));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 99,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 96, DateTimeKind.Local).AddTicks(6280));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 100,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 96, DateTimeKind.Local).AddTicks(6284));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 101,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 96, DateTimeKind.Local).AddTicks(6288));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 102,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 96, DateTimeKind.Local).AddTicks(6292));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 103,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 96, DateTimeKind.Local).AddTicks(6297));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 104,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 96, DateTimeKind.Local).AddTicks(6301));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 105,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 96, DateTimeKind.Local).AddTicks(6305));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 106,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 96, DateTimeKind.Local).AddTicks(6309));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 107,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 96, DateTimeKind.Local).AddTicks(6313));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 108,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 96, DateTimeKind.Local).AddTicks(6317));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 109,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 96, DateTimeKind.Local).AddTicks(6321));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 110,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 96, DateTimeKind.Local).AddTicks(6326));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 111,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 96, DateTimeKind.Local).AddTicks(6330));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 112,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 96, DateTimeKind.Local).AddTicks(6333));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 113,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 96, DateTimeKind.Local).AddTicks(6337));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 114,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 96, DateTimeKind.Local).AddTicks(6341));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 115,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 96, DateTimeKind.Local).AddTicks(6345));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 116,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 96, DateTimeKind.Local).AddTicks(6349));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 117,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 96, DateTimeKind.Local).AddTicks(6353));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 118,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 96, DateTimeKind.Local).AddTicks(6357));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 119,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 96, DateTimeKind.Local).AddTicks(6361));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 120,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 96, DateTimeKind.Local).AddTicks(6365));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 121,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 96, DateTimeKind.Local).AddTicks(6369));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 122,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 96, DateTimeKind.Local).AddTicks(6373));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 123,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 96, DateTimeKind.Local).AddTicks(6377));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 124,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 96, DateTimeKind.Local).AddTicks(6381));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 125,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 96, DateTimeKind.Local).AddTicks(6385));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 126,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 96, DateTimeKind.Local).AddTicks(6390));

            migrationBuilder.InsertData(
                table: "Permissions",
                columns: new[] { "PermissionID", "Description", "IsActive", "IsDeleted", "LastChangedBy", "LastChangedDate", "Name" },
                values: new object[] { 127, null, true, false, "SuperUser", new DateTime(2021, 4, 4, 20, 50, 29, 96, DateTimeKind.Local).AddTicks(6394), "View Invoice Details" });

            migrationBuilder.UpdateData(
                table: "PriorityRanks",
                keyColumn: "PriorityRankID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 119, DateTimeKind.Local).AddTicks(9021));

            migrationBuilder.UpdateData(
                table: "PriorityRanks",
                keyColumn: "PriorityRankID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 119, DateTimeKind.Local).AddTicks(9124));

            migrationBuilder.UpdateData(
                table: "PriorityRanks",
                keyColumn: "PriorityRankID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 119, DateTimeKind.Local).AddTicks(9130));

            migrationBuilder.UpdateData(
                table: "PriorityRanks",
                keyColumn: "PriorityRankID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 119, DateTimeKind.Local).AddTicks(9133));

            migrationBuilder.UpdateData(
                table: "RecordStatus",
                keyColumn: "RecordStatusID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 155, DateTimeKind.Local).AddTicks(5371));

            migrationBuilder.UpdateData(
                table: "RecordStatus",
                keyColumn: "RecordStatusID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 155, DateTimeKind.Local).AddTicks(5797));

            migrationBuilder.UpdateData(
                table: "RecordStatus",
                keyColumn: "RecordStatusID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 155, DateTimeKind.Local).AddTicks(5804));

            migrationBuilder.UpdateData(
                table: "RelationshipTypes",
                keyColumn: "RelationshipTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 113, DateTimeKind.Local).AddTicks(8679));

            migrationBuilder.UpdateData(
                table: "RelationshipTypes",
                keyColumn: "RelationshipTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 113, DateTimeKind.Local).AddTicks(8796));

            migrationBuilder.UpdateData(
                table: "RelationshipTypes",
                keyColumn: "RelationshipTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 113, DateTimeKind.Local).AddTicks(8800));

            migrationBuilder.UpdateData(
                table: "RelationshipTypes",
                keyColumn: "RelationshipTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 113, DateTimeKind.Local).AddTicks(8802));

            migrationBuilder.UpdateData(
                table: "RelationshipTypes",
                keyColumn: "RelationshipTypeID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 113, DateTimeKind.Local).AddTicks(8804));

            migrationBuilder.UpdateData(
                table: "RelationshipTypes",
                keyColumn: "RelationshipTypeID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 113, DateTimeKind.Local).AddTicks(8809));

            migrationBuilder.UpdateData(
                table: "RelationshipTypes",
                keyColumn: "RelationshipTypeID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 113, DateTimeKind.Local).AddTicks(8812));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 143, DateTimeKind.Local).AddTicks(5185));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 143, DateTimeKind.Local).AddTicks(5260));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 143, DateTimeKind.Local).AddTicks(5262));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 143, DateTimeKind.Local).AddTicks(5264));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 143, DateTimeKind.Local).AddTicks(5266));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 143, DateTimeKind.Local).AddTicks(5269));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 143, DateTimeKind.Local).AddTicks(5271));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 143, DateTimeKind.Local).AddTicks(5273));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 143, DateTimeKind.Local).AddTicks(5274));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 143, DateTimeKind.Local).AddTicks(5277));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 143, DateTimeKind.Local).AddTicks(5279));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 143, DateTimeKind.Local).AddTicks(5280));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 13,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 143, DateTimeKind.Local).AddTicks(5282));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 14,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 143, DateTimeKind.Local).AddTicks(5283));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 15,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 143, DateTimeKind.Local).AddTicks(5285));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 16,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 143, DateTimeKind.Local).AddTicks(5286));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 17,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 143, DateTimeKind.Local).AddTicks(5288));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 18,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 143, DateTimeKind.Local).AddTicks(5291));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 19,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 143, DateTimeKind.Local).AddTicks(5292));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 20,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 143, DateTimeKind.Local).AddTicks(5294));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 21,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 143, DateTimeKind.Local).AddTicks(5295));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 22,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 143, DateTimeKind.Local).AddTicks(5297));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 97, DateTimeKind.Local).AddTicks(2868));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 97, DateTimeKind.Local).AddTicks(2967));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 97, DateTimeKind.Local).AddTicks(2970));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 97, DateTimeKind.Local).AddTicks(2972));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 97, DateTimeKind.Local).AddTicks(2974));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 97, DateTimeKind.Local).AddTicks(2978));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 97, DateTimeKind.Local).AddTicks(2980));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 97, DateTimeKind.Local).AddTicks(2982));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 97, DateTimeKind.Local).AddTicks(2984));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 97, DateTimeKind.Local).AddTicks(2987));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 97, DateTimeKind.Local).AddTicks(2989));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 97, DateTimeKind.Local).AddTicks(2991));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 13,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 97, DateTimeKind.Local).AddTicks(2992));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 14,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 97, DateTimeKind.Local).AddTicks(2994));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 15,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 97, DateTimeKind.Local).AddTicks(2996));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 16,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 97, DateTimeKind.Local).AddTicks(2998));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 17,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 97, DateTimeKind.Local).AddTicks(2999));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 18,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 97, DateTimeKind.Local).AddTicks(3044));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 19,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 97, DateTimeKind.Local).AddTicks(3046));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 20,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 97, DateTimeKind.Local).AddTicks(3047));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 21,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 97, DateTimeKind.Local).AddTicks(3049));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 22,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 97, DateTimeKind.Local).AddTicks(3051));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 23,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 97, DateTimeKind.Local).AddTicks(3053));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 24,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 97, DateTimeKind.Local).AddTicks(3055));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 25,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 97, DateTimeKind.Local).AddTicks(3056));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 26,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 97, DateTimeKind.Local).AddTicks(3058));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 27,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 97, DateTimeKind.Local).AddTicks(3060));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 28,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 97, DateTimeKind.Local).AddTicks(3062));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 29,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 97, DateTimeKind.Local).AddTicks(3064));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 30,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 97, DateTimeKind.Local).AddTicks(3065));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 31,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 97, DateTimeKind.Local).AddTicks(3067));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 32,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 97, DateTimeKind.Local).AddTicks(3069));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 33,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 97, DateTimeKind.Local).AddTicks(3071));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 34,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 97, DateTimeKind.Local).AddTicks(3074));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 35,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 97, DateTimeKind.Local).AddTicks(3076));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 36,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 97, DateTimeKind.Local).AddTicks(3078));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 37,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 97, DateTimeKind.Local).AddTicks(3080));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 38,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 97, DateTimeKind.Local).AddTicks(3082));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 39,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 97, DateTimeKind.Local).AddTicks(3084));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 40,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 97, DateTimeKind.Local).AddTicks(3086));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 41,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 97, DateTimeKind.Local).AddTicks(3087));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 42,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 97, DateTimeKind.Local).AddTicks(3089));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 43,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 97, DateTimeKind.Local).AddTicks(3091));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 44,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 97, DateTimeKind.Local).AddTicks(3093));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 45,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 97, DateTimeKind.Local).AddTicks(3094));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 46,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 97, DateTimeKind.Local).AddTicks(3096));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 47,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 97, DateTimeKind.Local).AddTicks(3098));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 48,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 97, DateTimeKind.Local).AddTicks(3100));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 49,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 97, DateTimeKind.Local).AddTicks(3101));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 50,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 97, DateTimeKind.Local).AddTicks(3103));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 51,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 97, DateTimeKind.Local).AddTicks(3105));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 52,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 97, DateTimeKind.Local).AddTicks(3107));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 53,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 97, DateTimeKind.Local).AddTicks(3108));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 54,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 97, DateTimeKind.Local).AddTicks(3110));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 55,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 97, DateTimeKind.Local).AddTicks(3112));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 56,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 97, DateTimeKind.Local).AddTicks(3114));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 57,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 97, DateTimeKind.Local).AddTicks(3116));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 58,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 97, DateTimeKind.Local).AddTicks(3117));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 59,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 97, DateTimeKind.Local).AddTicks(3119));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 60,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 97, DateTimeKind.Local).AddTicks(3121));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 61,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 97, DateTimeKind.Local).AddTicks(3122));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 62,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 97, DateTimeKind.Local).AddTicks(3124));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 63,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 97, DateTimeKind.Local).AddTicks(3126));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 64,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 97, DateTimeKind.Local).AddTicks(3128));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 65,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 97, DateTimeKind.Local).AddTicks(3130));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 66,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 97, DateTimeKind.Local).AddTicks(3133));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 67,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 97, DateTimeKind.Local).AddTicks(3135));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 68,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 97, DateTimeKind.Local).AddTicks(3137));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 69,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 97, DateTimeKind.Local).AddTicks(3138));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 70,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 97, DateTimeKind.Local).AddTicks(3140));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 71,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 97, DateTimeKind.Local).AddTicks(3142));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 72,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 97, DateTimeKind.Local).AddTicks(3144));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 73,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 97, DateTimeKind.Local).AddTicks(3145));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 74,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 97, DateTimeKind.Local).AddTicks(3147));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 75,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 97, DateTimeKind.Local).AddTicks(3149));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 76,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 97, DateTimeKind.Local).AddTicks(3151));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 77,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 97, DateTimeKind.Local).AddTicks(3153));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 78,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 97, DateTimeKind.Local).AddTicks(3154));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 79,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 97, DateTimeKind.Local).AddTicks(3156));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 80,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 97, DateTimeKind.Local).AddTicks(3158));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 81,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 97, DateTimeKind.Local).AddTicks(3160));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 82,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 97, DateTimeKind.Local).AddTicks(3161));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 83,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 97, DateTimeKind.Local).AddTicks(3163));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 84,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 97, DateTimeKind.Local).AddTicks(3165));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 85,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 97, DateTimeKind.Local).AddTicks(3167));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 86,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 97, DateTimeKind.Local).AddTicks(3169));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 87,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 97, DateTimeKind.Local).AddTicks(3170));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 88,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 97, DateTimeKind.Local).AddTicks(3172));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 89,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 97, DateTimeKind.Local).AddTicks(3174));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 90,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 97, DateTimeKind.Local).AddTicks(3176));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 91,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 97, DateTimeKind.Local).AddTicks(3177));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 92,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 97, DateTimeKind.Local).AddTicks(3179));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 93,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 97, DateTimeKind.Local).AddTicks(3181));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 94,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 97, DateTimeKind.Local).AddTicks(3183));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 95,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 97, DateTimeKind.Local).AddTicks(3185));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 96,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 97, DateTimeKind.Local).AddTicks(3186));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 97,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 97, DateTimeKind.Local).AddTicks(3188));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 98,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 97, DateTimeKind.Local).AddTicks(3190));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 99,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 97, DateTimeKind.Local).AddTicks(3192));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 100,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 97, DateTimeKind.Local).AddTicks(3193));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 101,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 97, DateTimeKind.Local).AddTicks(3195));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 102,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 97, DateTimeKind.Local).AddTicks(3197));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 103,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 97, DateTimeKind.Local).AddTicks(3199));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 104,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 97, DateTimeKind.Local).AddTicks(3200));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 105,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 97, DateTimeKind.Local).AddTicks(3202));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 106,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 97, DateTimeKind.Local).AddTicks(3204));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 107,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 97, DateTimeKind.Local).AddTicks(3206));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 108,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 97, DateTimeKind.Local).AddTicks(3207));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 109,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 97, DateTimeKind.Local).AddTicks(3209));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 110,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 97, DateTimeKind.Local).AddTicks(3211));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 111,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 97, DateTimeKind.Local).AddTicks(3213));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 112,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 97, DateTimeKind.Local).AddTicks(3214));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 113,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 97, DateTimeKind.Local).AddTicks(3216));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 114,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 97, DateTimeKind.Local).AddTicks(3218));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 115,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 97, DateTimeKind.Local).AddTicks(3220));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 116,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 97, DateTimeKind.Local).AddTicks(3259));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 117,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 97, DateTimeKind.Local).AddTicks(3261));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 118,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 97, DateTimeKind.Local).AddTicks(3263));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 119,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 97, DateTimeKind.Local).AddTicks(3265));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 120,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 97, DateTimeKind.Local).AddTicks(3267));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 121,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 97, DateTimeKind.Local).AddTicks(3269));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 122,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 97, DateTimeKind.Local).AddTicks(3271));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 123,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 97, DateTimeKind.Local).AddTicks(3272));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 124,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 97, DateTimeKind.Local).AddTicks(3274));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 125,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 97, DateTimeKind.Local).AddTicks(3276));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 126,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 97, DateTimeKind.Local).AddTicks(3278));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 91, DateTimeKind.Local).AddTicks(2064));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 92, DateTimeKind.Local).AddTicks(5904));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 92, DateTimeKind.Local).AddTicks(5959));

            migrationBuilder.UpdateData(
                table: "StatementLists",
                keyColumn: "StatementID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 148, DateTimeKind.Local).AddTicks(1564));

            migrationBuilder.UpdateData(
                table: "StatementLists",
                keyColumn: "StatementID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 148, DateTimeKind.Local).AddTicks(1935));

            migrationBuilder.UpdateData(
                table: "SystemVariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 115, DateTimeKind.Local).AddTicks(8304));

            migrationBuilder.UpdateData(
                table: "SystemVariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 115, DateTimeKind.Local).AddTicks(8461));

            migrationBuilder.UpdateData(
                table: "SystemVariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 115, DateTimeKind.Local).AddTicks(8458));

            migrationBuilder.UpdateData(
                table: "SystemVariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 115, DateTimeKind.Local).AddTicks(8454));

            migrationBuilder.UpdateData(
                table: "SystemVariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 115, DateTimeKind.Local).AddTicks(8448));

            migrationBuilder.UpdateData(
                table: "SystemVariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 115, DateTimeKind.Local).AddTicks(8471));

            migrationBuilder.UpdateData(
                table: "SystemVariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 115, DateTimeKind.Local).AddTicks(8481));

            migrationBuilder.UpdateData(
                table: "SystemVariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 115, DateTimeKind.Local).AddTicks(8485));

            migrationBuilder.UpdateData(
                table: "SystemVariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 115, DateTimeKind.Local).AddTicks(8489));

            migrationBuilder.UpdateData(
                table: "Titles",
                keyColumn: "TitleID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 150, DateTimeKind.Local).AddTicks(3929));

            migrationBuilder.UpdateData(
                table: "Titles",
                keyColumn: "TitleID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 150, DateTimeKind.Local).AddTicks(4339));

            migrationBuilder.UpdateData(
                table: "Titles",
                keyColumn: "TitleID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 150, DateTimeKind.Local).AddTicks(4347));

            migrationBuilder.UpdateData(
                table: "Titles",
                keyColumn: "TitleID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 150, DateTimeKind.Local).AddTicks(4350));

            migrationBuilder.UpdateData(
                table: "Titles",
                keyColumn: "TitleID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 150, DateTimeKind.Local).AddTicks(4353));

            migrationBuilder.UpdateData(
                table: "Titles",
                keyColumn: "TitleID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 150, DateTimeKind.Local).AddTicks(4361));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 102, DateTimeKind.Local).AddTicks(5070));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 102, DateTimeKind.Local).AddTicks(5839));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 102, DateTimeKind.Local).AddTicks(5922));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 102, DateTimeKind.Local).AddTicks(5997));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 102, DateTimeKind.Local).AddTicks(6075));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 102, DateTimeKind.Local).AddTicks(6149));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 102, DateTimeKind.Local).AddTicks(6211));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 102, DateTimeKind.Local).AddTicks(6270));

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumns: new[] { "UserID", "RoleID" },
                keyValues: new object[] { 1, 1 },
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 130, DateTimeKind.Local).AddTicks(7990));

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumns: new[] { "UserID", "RoleID" },
                keyValues: new object[] { 2, 3 },
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 130, DateTimeKind.Local).AddTicks(8056));

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "UserTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 112, DateTimeKind.Local).AddTicks(3123));

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "UserTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 112, DateTimeKind.Local).AddTicks(3534));

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "UserTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 112, DateTimeKind.Local).AddTicks(3543));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 120, DateTimeKind.Local).AddTicks(5686));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 123, DateTimeKind.Local).AddTicks(703));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 20, 50, 29, 123, DateTimeKind.Local).AddTicks(1030));

            migrationBuilder.InsertData(
                table: "RolePermissions",
                columns: new[] { "RolePermissionID", "LastChangedBy", "LastChangedDate", "PermissionID", "RoleID" },
                values: new object[] { 127, "SuperUser", new DateTime(2021, 4, 4, 20, 50, 29, 97, DateTimeKind.Local).AddTicks(3279), 127, 1 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 127);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 127);

            migrationBuilder.UpdateData(
                table: "BankAccountTypes",
                keyColumn: "BankAccountTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 675, DateTimeKind.Local).AddTicks(2325));

            migrationBuilder.UpdateData(
                table: "BankAccountTypes",
                keyColumn: "BankAccountTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 675, DateTimeKind.Local).AddTicks(2781));

            migrationBuilder.UpdateData(
                table: "BankAccountTypes",
                keyColumn: "BankAccountTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 675, DateTimeKind.Local).AddTicks(2789));

            migrationBuilder.UpdateData(
                table: "BankAccountTypes",
                keyColumn: "BankAccountTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 675, DateTimeKind.Local).AddTicks(2793));

            migrationBuilder.UpdateData(
                table: "ClientAccountTypes",
                keyColumn: "ID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 725, DateTimeKind.Local).AddTicks(6596));

            migrationBuilder.UpdateData(
                table: "ClientAccountTypes",
                keyColumn: "ID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 725, DateTimeKind.Local).AddTicks(6962));

            migrationBuilder.UpdateData(
                table: "ContactTypes",
                keyColumn: "ContactTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 685, DateTimeKind.Local).AddTicks(5016));

            migrationBuilder.UpdateData(
                table: "ContactTypes",
                keyColumn: "ContactTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 685, DateTimeKind.Local).AddTicks(5011));

            migrationBuilder.UpdateData(
                table: "ContactTypes",
                keyColumn: "ContactTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 685, DateTimeKind.Local).AddTicks(5005));

            migrationBuilder.UpdateData(
                table: "ContactTypes",
                keyColumn: "ContactTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 685, DateTimeKind.Local).AddTicks(4924));

            migrationBuilder.UpdateData(
                table: "ContactTypes",
                keyColumn: "ContactTypeID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 685, DateTimeKind.Local).AddTicks(5020));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 691, DateTimeKind.Local).AddTicks(1535));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 691, DateTimeKind.Local).AddTicks(1874));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 691, DateTimeKind.Local).AddTicks(1881));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 691, DateTimeKind.Local).AddTicks(1889));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 691, DateTimeKind.Local).AddTicks(1892));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 691, DateTimeKind.Local).AddTicks(1900));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 691, DateTimeKind.Local).AddTicks(1903));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 691, DateTimeKind.Local).AddTicks(1907));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 691, DateTimeKind.Local).AddTicks(1910));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 691, DateTimeKind.Local).AddTicks(1914));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 691, DateTimeKind.Local).AddTicks(1917));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 691, DateTimeKind.Local).AddTicks(1920));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 13,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 691, DateTimeKind.Local).AddTicks(1923));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 14,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 691, DateTimeKind.Local).AddTicks(1926));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 15,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 691, DateTimeKind.Local).AddTicks(1929));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 16,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 691, DateTimeKind.Local).AddTicks(1933));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 17,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 691, DateTimeKind.Local).AddTicks(1936));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 18,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 691, DateTimeKind.Local).AddTicks(1951));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 19,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 691, DateTimeKind.Local).AddTicks(1954));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 20,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 691, DateTimeKind.Local).AddTicks(1957));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 21,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 691, DateTimeKind.Local).AddTicks(1960));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 22,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 691, DateTimeKind.Local).AddTicks(1963));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 23,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 691, DateTimeKind.Local).AddTicks(1966));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 24,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 691, DateTimeKind.Local).AddTicks(1968));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 25,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 691, DateTimeKind.Local).AddTicks(1971));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 26,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 691, DateTimeKind.Local).AddTicks(1974));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 27,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 691, DateTimeKind.Local).AddTicks(1978));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 28,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 691, DateTimeKind.Local).AddTicks(1981));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 29,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 691, DateTimeKind.Local).AddTicks(1984));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 30,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 691, DateTimeKind.Local).AddTicks(1989));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 31,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 691, DateTimeKind.Local).AddTicks(1992));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 32,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 691, DateTimeKind.Local).AddTicks(1995));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 33,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 691, DateTimeKind.Local).AddTicks(1998));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 34,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 691, DateTimeKind.Local).AddTicks(2003));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 35,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 691, DateTimeKind.Local).AddTicks(2006));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 36,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 691, DateTimeKind.Local).AddTicks(2008));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 37,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 691, DateTimeKind.Local).AddTicks(2011));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 38,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 691, DateTimeKind.Local).AddTicks(2014));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 39,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 691, DateTimeKind.Local).AddTicks(2017));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 40,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 691, DateTimeKind.Local).AddTicks(2021));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 41,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 691, DateTimeKind.Local).AddTicks(2025));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 42,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 691, DateTimeKind.Local).AddTicks(2028));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 43,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 691, DateTimeKind.Local).AddTicks(2030));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 44,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 691, DateTimeKind.Local).AddTicks(2033));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 45,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 691, DateTimeKind.Local).AddTicks(2036));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 46,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 691, DateTimeKind.Local).AddTicks(2039));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 47,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 691, DateTimeKind.Local).AddTicks(2043));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 48,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 691, DateTimeKind.Local).AddTicks(2048));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 49,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 691, DateTimeKind.Local).AddTicks(2051));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 50,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 691, DateTimeKind.Local).AddTicks(2054));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 51,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 691, DateTimeKind.Local).AddTicks(2058));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 52,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 691, DateTimeKind.Local).AddTicks(2060));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 53,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 691, DateTimeKind.Local).AddTicks(2063));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 54,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 691, DateTimeKind.Local).AddTicks(2066));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 55,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 691, DateTimeKind.Local).AddTicks(2069));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 56,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 691, DateTimeKind.Local).AddTicks(2072));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 57,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 691, DateTimeKind.Local).AddTicks(2075));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 58,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 691, DateTimeKind.Local).AddTicks(2078));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 59,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 691, DateTimeKind.Local).AddTicks(2082));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 60,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 691, DateTimeKind.Local).AddTicks(2085));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 61,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 691, DateTimeKind.Local).AddTicks(2088));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 62,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 691, DateTimeKind.Local).AddTicks(2091));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 63,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 691, DateTimeKind.Local).AddTicks(2094));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 64,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 691, DateTimeKind.Local).AddTicks(2098));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 65,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 691, DateTimeKind.Local).AddTicks(2101));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 66,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 691, DateTimeKind.Local).AddTicks(2106));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 67,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 691, DateTimeKind.Local).AddTicks(2108));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 68,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 691, DateTimeKind.Local).AddTicks(2112));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 69,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 691, DateTimeKind.Local).AddTicks(2115));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 70,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 691, DateTimeKind.Local).AddTicks(2117));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 71,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 691, DateTimeKind.Local).AddTicks(2120));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 72,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 691, DateTimeKind.Local).AddTicks(2130));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 73,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 691, DateTimeKind.Local).AddTicks(2133));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 74,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 691, DateTimeKind.Local).AddTicks(2136));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 75,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 691, DateTimeKind.Local).AddTicks(2140));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 76,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 691, DateTimeKind.Local).AddTicks(2143));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 77,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 691, DateTimeKind.Local).AddTicks(2146));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 78,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 691, DateTimeKind.Local).AddTicks(2148));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 79,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 691, DateTimeKind.Local).AddTicks(2151));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 80,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 691, DateTimeKind.Local).AddTicks(2154));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 81,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 691, DateTimeKind.Local).AddTicks(2157));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 82,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 691, DateTimeKind.Local).AddTicks(2160));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 83,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 691, DateTimeKind.Local).AddTicks(2162));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 84,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 691, DateTimeKind.Local).AddTicks(2165));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 85,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 691, DateTimeKind.Local).AddTicks(2168));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 86,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 691, DateTimeKind.Local).AddTicks(2175));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 87,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 691, DateTimeKind.Local).AddTicks(2178));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 88,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 691, DateTimeKind.Local).AddTicks(2181));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 89,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 691, DateTimeKind.Local).AddTicks(2184));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 90,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 691, DateTimeKind.Local).AddTicks(2187));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 91,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 691, DateTimeKind.Local).AddTicks(2190));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 92,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 691, DateTimeKind.Local).AddTicks(2193));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 93,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 691, DateTimeKind.Local).AddTicks(2196));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 94,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 691, DateTimeKind.Local).AddTicks(2199));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 95,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 691, DateTimeKind.Local).AddTicks(2201));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 96,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 691, DateTimeKind.Local).AddTicks(2204));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 97,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 691, DateTimeKind.Local).AddTicks(2207));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 98,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 691, DateTimeKind.Local).AddTicks(2210));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 99,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 691, DateTimeKind.Local).AddTicks(2213));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 100,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 691, DateTimeKind.Local).AddTicks(2215));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 101,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 691, DateTimeKind.Local).AddTicks(2219));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 102,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 691, DateTimeKind.Local).AddTicks(2222));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 103,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 691, DateTimeKind.Local).AddTicks(2225));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 104,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 691, DateTimeKind.Local).AddTicks(2227));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 105,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 691, DateTimeKind.Local).AddTicks(2230));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 106,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 691, DateTimeKind.Local).AddTicks(2233));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 107,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 691, DateTimeKind.Local).AddTicks(2236));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 108,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 691, DateTimeKind.Local).AddTicks(2239));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 109,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 691, DateTimeKind.Local).AddTicks(2242));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 110,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 691, DateTimeKind.Local).AddTicks(2244));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 111,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 691, DateTimeKind.Local).AddTicks(2248));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 112,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 691, DateTimeKind.Local).AddTicks(2251));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 113,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 691, DateTimeKind.Local).AddTicks(2254));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 114,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 691, DateTimeKind.Local).AddTicks(2257));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 115,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 691, DateTimeKind.Local).AddTicks(2265));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 116,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 691, DateTimeKind.Local).AddTicks(2268));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 117,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 691, DateTimeKind.Local).AddTicks(2271));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 118,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 691, DateTimeKind.Local).AddTicks(2274));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 119,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 691, DateTimeKind.Local).AddTicks(2277));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 120,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 691, DateTimeKind.Local).AddTicks(2280));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 121,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 691, DateTimeKind.Local).AddTicks(2283));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 122,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 691, DateTimeKind.Local).AddTicks(2285));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 123,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 691, DateTimeKind.Local).AddTicks(2288));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 124,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 691, DateTimeKind.Local).AddTicks(2291));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 125,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 691, DateTimeKind.Local).AddTicks(2294));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 126,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 691, DateTimeKind.Local).AddTicks(2297));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 127,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 691, DateTimeKind.Local).AddTicks(2299));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 128,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 691, DateTimeKind.Local).AddTicks(2302));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 129,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 691, DateTimeKind.Local).AddTicks(2305));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 130,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 691, DateTimeKind.Local).AddTicks(2316));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 131,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 691, DateTimeKind.Local).AddTicks(2319));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 132,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 691, DateTimeKind.Local).AddTicks(2323));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 133,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 691, DateTimeKind.Local).AddTicks(2326));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 134,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 691, DateTimeKind.Local).AddTicks(2329));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 135,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 691, DateTimeKind.Local).AddTicks(2331));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 136,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 691, DateTimeKind.Local).AddTicks(2334));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 137,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 691, DateTimeKind.Local).AddTicks(2337));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 138,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 691, DateTimeKind.Local).AddTicks(2341));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 139,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 691, DateTimeKind.Local).AddTicks(2344));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 140,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 691, DateTimeKind.Local).AddTicks(2346));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 141,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 691, DateTimeKind.Local).AddTicks(2349));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 142,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 691, DateTimeKind.Local).AddTicks(2353));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 143,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 691, DateTimeKind.Local).AddTicks(2356));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 144,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 691, DateTimeKind.Local).AddTicks(2359));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 145,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 691, DateTimeKind.Local).AddTicks(2362));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 146,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 691, DateTimeKind.Local).AddTicks(2365));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 147,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 691, DateTimeKind.Local).AddTicks(2368));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 148,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 691, DateTimeKind.Local).AddTicks(2371));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 149,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 691, DateTimeKind.Local).AddTicks(2374));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 150,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 691, DateTimeKind.Local).AddTicks(2378));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 151,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 691, DateTimeKind.Local).AddTicks(2381));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 152,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 691, DateTimeKind.Local).AddTicks(2384));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 153,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 691, DateTimeKind.Local).AddTicks(2387));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 154,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 691, DateTimeKind.Local).AddTicks(2390));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 155,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 691, DateTimeKind.Local).AddTicks(2394));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 156,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 691, DateTimeKind.Local).AddTicks(2396));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 157,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 691, DateTimeKind.Local).AddTicks(2399));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 158,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 691, DateTimeKind.Local).AddTicks(2402));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 159,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 691, DateTimeKind.Local).AddTicks(2405));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 160,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 691, DateTimeKind.Local).AddTicks(2408));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 161,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 691, DateTimeKind.Local).AddTicks(2412));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 162,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 691, DateTimeKind.Local).AddTicks(2414));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 163,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 691, DateTimeKind.Local).AddTicks(2417));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 164,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 691, DateTimeKind.Local).AddTicks(2420));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 165,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 691, DateTimeKind.Local).AddTicks(2423));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 166,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 691, DateTimeKind.Local).AddTicks(2426));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 167,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 691, DateTimeKind.Local).AddTicks(2429));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 168,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 691, DateTimeKind.Local).AddTicks(2432));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 169,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 691, DateTimeKind.Local).AddTicks(2435));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 170,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 691, DateTimeKind.Local).AddTicks(2438));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 171,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 691, DateTimeKind.Local).AddTicks(2440));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 172,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 691, DateTimeKind.Local).AddTicks(2444));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 173,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 691, DateTimeKind.Local).AddTicks(2447));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 174,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 691, DateTimeKind.Local).AddTicks(2451));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 175,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 691, DateTimeKind.Local).AddTicks(2454));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 176,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 691, DateTimeKind.Local).AddTicks(2458));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 177,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 691, DateTimeKind.Local).AddTicks(2463));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 178,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 691, DateTimeKind.Local).AddTicks(2465));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 179,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 691, DateTimeKind.Local).AddTicks(2469));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 180,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 691, DateTimeKind.Local).AddTicks(2473));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 181,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 691, DateTimeKind.Local).AddTicks(2476));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 182,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 691, DateTimeKind.Local).AddTicks(2479));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 183,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 691, DateTimeKind.Local).AddTicks(2481));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 184,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 691, DateTimeKind.Local).AddTicks(2484));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 185,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 691, DateTimeKind.Local).AddTicks(2487));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 186,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 691, DateTimeKind.Local).AddTicks(2490));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 187,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 691, DateTimeKind.Local).AddTicks(2493));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 188,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 691, DateTimeKind.Local).AddTicks(2496));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 189,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 691, DateTimeKind.Local).AddTicks(2499));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 190,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 691, DateTimeKind.Local).AddTicks(2502));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 191,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 691, DateTimeKind.Local).AddTicks(2505));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 192,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 691, DateTimeKind.Local).AddTicks(2508));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 193,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 691, DateTimeKind.Local).AddTicks(2511));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 194,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 691, DateTimeKind.Local).AddTicks(2514));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 195,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 691, DateTimeKind.Local).AddTicks(2523));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 196,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 691, DateTimeKind.Local).AddTicks(2526));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 197,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 691, DateTimeKind.Local).AddTicks(2529));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 198,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 691, DateTimeKind.Local).AddTicks(2532));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 199,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 691, DateTimeKind.Local).AddTicks(2534));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 200,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 691, DateTimeKind.Local).AddTicks(2537));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 201,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 691, DateTimeKind.Local).AddTicks(2540));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 202,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 691, DateTimeKind.Local).AddTicks(2543));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 203,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 691, DateTimeKind.Local).AddTicks(2546));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 204,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 691, DateTimeKind.Local).AddTicks(2548));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 205,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 691, DateTimeKind.Local).AddTicks(2551));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 206,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 691, DateTimeKind.Local).AddTicks(2555));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 207,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 691, DateTimeKind.Local).AddTicks(2557));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 208,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 691, DateTimeKind.Local).AddTicks(2560));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 209,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 691, DateTimeKind.Local).AddTicks(2563));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 210,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 691, DateTimeKind.Local).AddTicks(2567));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 211,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 691, DateTimeKind.Local).AddTicks(2569));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 212,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 691, DateTimeKind.Local).AddTicks(2572));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 213,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 691, DateTimeKind.Local).AddTicks(2575));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 214,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 691, DateTimeKind.Local).AddTicks(2579));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 215,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 691, DateTimeKind.Local).AddTicks(2582));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 216,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 691, DateTimeKind.Local).AddTicks(2585));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 217,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 691, DateTimeKind.Local).AddTicks(2588));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 218,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 691, DateTimeKind.Local).AddTicks(2591));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 219,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 691, DateTimeKind.Local).AddTicks(2593));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 220,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 691, DateTimeKind.Local).AddTicks(2596));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 221,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 691, DateTimeKind.Local).AddTicks(2599));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 222,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 691, DateTimeKind.Local).AddTicks(2602));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 223,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 691, DateTimeKind.Local).AddTicks(2605));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 224,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 691, DateTimeKind.Local).AddTicks(2608));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 225,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 691, DateTimeKind.Local).AddTicks(2612));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 226,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 691, DateTimeKind.Local).AddTicks(2615));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 227,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 691, DateTimeKind.Local).AddTicks(2619));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 228,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 691, DateTimeKind.Local).AddTicks(2622));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 678, DateTimeKind.Local).AddTicks(4192));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 678, DateTimeKind.Local).AddTicks(4694));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 678, DateTimeKind.Local).AddTicks(4703));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 678, DateTimeKind.Local).AddTicks(4708));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 678, DateTimeKind.Local).AddTicks(4712));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 678, DateTimeKind.Local).AddTicks(4724));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 678, DateTimeKind.Local).AddTicks(4729));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 678, DateTimeKind.Local).AddTicks(4733));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 678, DateTimeKind.Local).AddTicks(4738));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 678, DateTimeKind.Local).AddTicks(4744));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 678, DateTimeKind.Local).AddTicks(4748));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 678, DateTimeKind.Local).AddTicks(4752));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 13,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 678, DateTimeKind.Local).AddTicks(4756));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 14,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 678, DateTimeKind.Local).AddTicks(4760));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 15,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 678, DateTimeKind.Local).AddTicks(4764));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 16,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 678, DateTimeKind.Local).AddTicks(4768));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 17,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 678, DateTimeKind.Local).AddTicks(4771));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 18,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 678, DateTimeKind.Local).AddTicks(4778));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 19,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 678, DateTimeKind.Local).AddTicks(4782));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 20,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 678, DateTimeKind.Local).AddTicks(4786));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 21,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 678, DateTimeKind.Local).AddTicks(4790));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 22,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 678, DateTimeKind.Local).AddTicks(4794));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 23,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 678, DateTimeKind.Local).AddTicks(4798));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 24,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 678, DateTimeKind.Local).AddTicks(4802));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 25,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 678, DateTimeKind.Local).AddTicks(4806));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 26,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 678, DateTimeKind.Local).AddTicks(4809));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 27,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 678, DateTimeKind.Local).AddTicks(4813));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 28,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 678, DateTimeKind.Local).AddTicks(4817));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 29,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 678, DateTimeKind.Local).AddTicks(4822));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 30,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 678, DateTimeKind.Local).AddTicks(4826));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 31,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 678, DateTimeKind.Local).AddTicks(4830));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 32,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 678, DateTimeKind.Local).AddTicks(4834));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 33,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 678, DateTimeKind.Local).AddTicks(4838));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 34,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 678, DateTimeKind.Local).AddTicks(4844));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 35,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 678, DateTimeKind.Local).AddTicks(4848));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 36,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 678, DateTimeKind.Local).AddTicks(4852));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 37,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 678, DateTimeKind.Local).AddTicks(4856));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 38,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 678, DateTimeKind.Local).AddTicks(4860));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 39,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 678, DateTimeKind.Local).AddTicks(4864));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 40,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 678, DateTimeKind.Local).AddTicks(4867));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 41,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 678, DateTimeKind.Local).AddTicks(4871));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 42,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 678, DateTimeKind.Local).AddTicks(4892));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 43,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 678, DateTimeKind.Local).AddTicks(4896));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 44,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 678, DateTimeKind.Local).AddTicks(4901));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 45,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 678, DateTimeKind.Local).AddTicks(4905));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 46,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 678, DateTimeKind.Local).AddTicks(4909));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 47,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 678, DateTimeKind.Local).AddTicks(4913));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 48,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 678, DateTimeKind.Local).AddTicks(4917));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 49,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 678, DateTimeKind.Local).AddTicks(4921));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 50,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 678, DateTimeKind.Local).AddTicks(4924));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 51,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 678, DateTimeKind.Local).AddTicks(4928));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 52,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 678, DateTimeKind.Local).AddTicks(4932));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 53,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 678, DateTimeKind.Local).AddTicks(4936));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 54,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 678, DateTimeKind.Local).AddTicks(4940));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 55,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 678, DateTimeKind.Local).AddTicks(4943));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 56,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 678, DateTimeKind.Local).AddTicks(4947));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 57,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 678, DateTimeKind.Local).AddTicks(4951));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 58,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 678, DateTimeKind.Local).AddTicks(4955));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 59,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 678, DateTimeKind.Local).AddTicks(4959));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 60,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 678, DateTimeKind.Local).AddTicks(4962));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 61,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 678, DateTimeKind.Local).AddTicks(4967));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 62,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 678, DateTimeKind.Local).AddTicks(4971));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 63,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 678, DateTimeKind.Local).AddTicks(4975));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 64,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 678, DateTimeKind.Local).AddTicks(4979));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 65,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 678, DateTimeKind.Local).AddTicks(4982));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 66,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 678, DateTimeKind.Local).AddTicks(4989));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 67,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 678, DateTimeKind.Local).AddTicks(4993));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 68,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 678, DateTimeKind.Local).AddTicks(4997));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 69,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 678, DateTimeKind.Local).AddTicks(5000));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 70,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 678, DateTimeKind.Local).AddTicks(5004));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 71,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 678, DateTimeKind.Local).AddTicks(5008));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 72,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 678, DateTimeKind.Local).AddTicks(5011));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 73,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 678, DateTimeKind.Local).AddTicks(5015));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 74,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 678, DateTimeKind.Local).AddTicks(5019));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 75,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 678, DateTimeKind.Local).AddTicks(5023));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 76,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 678, DateTimeKind.Local).AddTicks(5027));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 77,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 678, DateTimeKind.Local).AddTicks(5031));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 78,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 678, DateTimeKind.Local).AddTicks(5034));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 79,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 678, DateTimeKind.Local).AddTicks(5038));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 80,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 678, DateTimeKind.Local).AddTicks(5042));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 81,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 678, DateTimeKind.Local).AddTicks(5046));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 82,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 678, DateTimeKind.Local).AddTicks(5050));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 83,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 678, DateTimeKind.Local).AddTicks(5054));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 84,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 678, DateTimeKind.Local).AddTicks(5058));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 85,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 678, DateTimeKind.Local).AddTicks(5063));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 86,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 678, DateTimeKind.Local).AddTicks(5066));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 87,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 678, DateTimeKind.Local).AddTicks(5070));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 88,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 678, DateTimeKind.Local).AddTicks(5074));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 89,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 678, DateTimeKind.Local).AddTicks(5078));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 90,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 678, DateTimeKind.Local).AddTicks(5082));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 91,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 678, DateTimeKind.Local).AddTicks(5085));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 92,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 678, DateTimeKind.Local).AddTicks(5089));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 93,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 678, DateTimeKind.Local).AddTicks(5093));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 94,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 678, DateTimeKind.Local).AddTicks(5097));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 95,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 678, DateTimeKind.Local).AddTicks(5101));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 96,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 678, DateTimeKind.Local).AddTicks(5105));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 97,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 678, DateTimeKind.Local).AddTicks(5109));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 98,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 678, DateTimeKind.Local).AddTicks(5112));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 99,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 678, DateTimeKind.Local).AddTicks(5116));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 100,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 678, DateTimeKind.Local).AddTicks(5120));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 101,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 678, DateTimeKind.Local).AddTicks(5124));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 102,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 678, DateTimeKind.Local).AddTicks(5128));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 103,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 678, DateTimeKind.Local).AddTicks(5132));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 104,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 678, DateTimeKind.Local).AddTicks(5136));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 105,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 678, DateTimeKind.Local).AddTicks(5140));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 106,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 678, DateTimeKind.Local).AddTicks(5143));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 107,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 678, DateTimeKind.Local).AddTicks(5147));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 108,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 678, DateTimeKind.Local).AddTicks(5151));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 109,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 678, DateTimeKind.Local).AddTicks(5155));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 110,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 678, DateTimeKind.Local).AddTicks(5166));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 111,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 678, DateTimeKind.Local).AddTicks(5170));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 112,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 678, DateTimeKind.Local).AddTicks(5174));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 113,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 678, DateTimeKind.Local).AddTicks(5178));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 114,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 678, DateTimeKind.Local).AddTicks(5182));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 115,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 678, DateTimeKind.Local).AddTicks(5185));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 116,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 678, DateTimeKind.Local).AddTicks(5189));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 117,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 678, DateTimeKind.Local).AddTicks(5193));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 118,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 678, DateTimeKind.Local).AddTicks(5197));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 119,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 678, DateTimeKind.Local).AddTicks(5201));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 120,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 678, DateTimeKind.Local).AddTicks(5204));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 121,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 678, DateTimeKind.Local).AddTicks(5208));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 122,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 678, DateTimeKind.Local).AddTicks(5212));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 123,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 678, DateTimeKind.Local).AddTicks(5216));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 124,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 678, DateTimeKind.Local).AddTicks(5220));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 125,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 678, DateTimeKind.Local).AddTicks(5224));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 126,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 678, DateTimeKind.Local).AddTicks(5228));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 127,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 678, DateTimeKind.Local).AddTicks(5232));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 128,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 678, DateTimeKind.Local).AddTicks(5236));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 129,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 678, DateTimeKind.Local).AddTicks(5239));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 130,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 678, DateTimeKind.Local).AddTicks(5246));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 131,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 678, DateTimeKind.Local).AddTicks(5250));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 132,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 678, DateTimeKind.Local).AddTicks(5254));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 133,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 678, DateTimeKind.Local).AddTicks(5258));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 134,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 678, DateTimeKind.Local).AddTicks(5262));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 135,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 678, DateTimeKind.Local).AddTicks(5265));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 136,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 678, DateTimeKind.Local).AddTicks(5269));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 137,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 678, DateTimeKind.Local).AddTicks(5273));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 138,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 678, DateTimeKind.Local).AddTicks(5277));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 139,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 678, DateTimeKind.Local).AddTicks(5281));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 140,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 678, DateTimeKind.Local).AddTicks(5284));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 141,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 678, DateTimeKind.Local).AddTicks(5288));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 142,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 678, DateTimeKind.Local).AddTicks(5292));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 143,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 678, DateTimeKind.Local).AddTicks(5296));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 144,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 678, DateTimeKind.Local).AddTicks(5300));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 145,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 678, DateTimeKind.Local).AddTicks(5304));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 146,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 678, DateTimeKind.Local).AddTicks(5308));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 147,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 678, DateTimeKind.Local).AddTicks(5311));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 148,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 678, DateTimeKind.Local).AddTicks(5315));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 149,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 678, DateTimeKind.Local).AddTicks(5319));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 150,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 678, DateTimeKind.Local).AddTicks(5322));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 151,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 678, DateTimeKind.Local).AddTicks(5326));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 152,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 678, DateTimeKind.Local).AddTicks(5330));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 153,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 678, DateTimeKind.Local).AddTicks(5334));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 154,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 678, DateTimeKind.Local).AddTicks(5337));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 155,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 678, DateTimeKind.Local).AddTicks(5341));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 156,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 678, DateTimeKind.Local).AddTicks(5345));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 157,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 678, DateTimeKind.Local).AddTicks(5348));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 158,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 678, DateTimeKind.Local).AddTicks(5352));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 159,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 678, DateTimeKind.Local).AddTicks(5356));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 160,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 678, DateTimeKind.Local).AddTicks(5360));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 161,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 678, DateTimeKind.Local).AddTicks(5364));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 162,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 678, DateTimeKind.Local).AddTicks(5367));

            migrationBuilder.UpdateData(
                table: "CustomSettingTypes",
                keyColumn: "CustomSettingTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 686, DateTimeKind.Local).AddTicks(9977));

            migrationBuilder.UpdateData(
                table: "CustomSettingTypes",
                keyColumn: "CustomSettingTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 687, DateTimeKind.Local).AddTicks(57));

            migrationBuilder.UpdateData(
                table: "CustomSettingTypes",
                keyColumn: "CustomSettingTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 687, DateTimeKind.Local).AddTicks(62));

            migrationBuilder.UpdateData(
                table: "CustomSettingTypes",
                keyColumn: "CustomSettingTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 687, DateTimeKind.Local).AddTicks(65));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 715, DateTimeKind.Local).AddTicks(4113));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 715, DateTimeKind.Local).AddTicks(4299));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 715, DateTimeKind.Local).AddTicks(4326));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 715, DateTimeKind.Local).AddTicks(4305));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 715, DateTimeKind.Local).AddTicks(4331));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 715, DateTimeKind.Local).AddTicks(4342));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 715, DateTimeKind.Local).AddTicks(4375));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 715, DateTimeKind.Local).AddTicks(4381));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 715, DateTimeKind.Local).AddTicks(4387));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 715, DateTimeKind.Local).AddTicks(4393));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 715, DateTimeKind.Local).AddTicks(4447));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 715, DateTimeKind.Local).AddTicks(4452));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 13,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 715, DateTimeKind.Local).AddTicks(4457));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 14,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 715, DateTimeKind.Local).AddTicks(4463));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 15,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 715, DateTimeKind.Local).AddTicks(4312));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 16,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 715, DateTimeKind.Local).AddTicks(4291));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 17,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 715, DateTimeKind.Local).AddTicks(4470));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 18,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 715, DateTimeKind.Local).AddTicks(4475));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 19,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 715, DateTimeKind.Local).AddTicks(4480));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 20,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 715, DateTimeKind.Local).AddTicks(4485));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 22,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 715, DateTimeKind.Local).AddTicks(4507));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 23,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 715, DateTimeKind.Local).AddTicks(4497));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 24,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 715, DateTimeKind.Local).AddTicks(4491));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 25,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 715, DateTimeKind.Local).AddTicks(4502));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 26,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 715, DateTimeKind.Local).AddTicks(4513));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 27,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 715, DateTimeKind.Local).AddTicks(4518));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 28,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 715, DateTimeKind.Local).AddTicks(4523));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 30,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 715, DateTimeKind.Local).AddTicks(4530));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 31,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 715, DateTimeKind.Local).AddTicks(4536));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 32,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 715, DateTimeKind.Local).AddTicks(4541));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 33,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 715, DateTimeKind.Local).AddTicks(4546));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 34,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 715, DateTimeKind.Local).AddTicks(4552));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 36,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 715, DateTimeKind.Local).AddTicks(4559));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 37,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 715, DateTimeKind.Local).AddTicks(4564));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 38,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 715, DateTimeKind.Local).AddTicks(4570));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 39,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 715, DateTimeKind.Local).AddTicks(4337));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 40,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 715, DateTimeKind.Local).AddTicks(4576));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 41,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 715, DateTimeKind.Local).AddTicks(4585));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 42,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 715, DateTimeKind.Local).AddTicks(4590));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 43,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 715, DateTimeKind.Local).AddTicks(4581));

            migrationBuilder.UpdateData(
                table: "DocumentFormats",
                keyColumn: "DocumentFormatID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 699, DateTimeKind.Local).AddTicks(9333));

            migrationBuilder.UpdateData(
                table: "DocumentFormats",
                keyColumn: "DocumentFormatID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 699, DateTimeKind.Local).AddTicks(9766));

            migrationBuilder.UpdateData(
                table: "DocumentFormats",
                keyColumn: "DocumentFormatID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 699, DateTimeKind.Local).AddTicks(9772));

            migrationBuilder.UpdateData(
                table: "DocumentFormats",
                keyColumn: "DocumentFormatID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 699, DateTimeKind.Local).AddTicks(9775));

            migrationBuilder.UpdateData(
                table: "DocumentFormats",
                keyColumn: "DocumentFormatID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 699, DateTimeKind.Local).AddTicks(9778));

            migrationBuilder.UpdateData(
                table: "DocumentFormats",
                keyColumn: "DocumentFormatID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 699, DateTimeKind.Local).AddTicks(9787));

            migrationBuilder.UpdateData(
                table: "DocumentTypes",
                keyColumn: "DocumentTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 702, DateTimeKind.Local).AddTicks(4345));

            migrationBuilder.UpdateData(
                table: "DocumentTypes",
                keyColumn: "DocumentTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 702, DateTimeKind.Local).AddTicks(5387));

            migrationBuilder.UpdateData(
                table: "DocumentTypes",
                keyColumn: "DocumentTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 702, DateTimeKind.Local).AddTicks(5410));

            migrationBuilder.UpdateData(
                table: "DocumentTypes",
                keyColumn: "DocumentTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 702, DateTimeKind.Local).AddTicks(5415));

            migrationBuilder.UpdateData(
                table: "EmailTemplates",
                keyColumn: "EmailTemplateID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 711, DateTimeKind.Local).AddTicks(7843));

            migrationBuilder.UpdateData(
                table: "EmailTypes",
                keyColumn: "EmailTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 711, DateTimeKind.Local).AddTicks(1711));

            migrationBuilder.UpdateData(
                table: "EmailTypes",
                keyColumn: "EmailTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 711, DateTimeKind.Local).AddTicks(2117));

            migrationBuilder.UpdateData(
                table: "EmailTypes",
                keyColumn: "EmailTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 711, DateTimeKind.Local).AddTicks(2124));

            migrationBuilder.UpdateData(
                table: "EmailTypes",
                keyColumn: "EmailTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 711, DateTimeKind.Local).AddTicks(2130));

            migrationBuilder.UpdateData(
                table: "FeatureFlags",
                keyColumn: "FeatureFlagID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 697, DateTimeKind.Local).AddTicks(4112));

            migrationBuilder.UpdateData(
                table: "FeatureFlags",
                keyColumn: "FeatureFlagID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 697, DateTimeKind.Local).AddTicks(4587));

            migrationBuilder.UpdateData(
                table: "FeatureFlags",
                keyColumn: "FeatureFlagID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 697, DateTimeKind.Local).AddTicks(4597));

            migrationBuilder.UpdateData(
                table: "Frequencies",
                keyColumn: "FrequencyID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 681, DateTimeKind.Local).AddTicks(5777));

            migrationBuilder.UpdateData(
                table: "Frequencies",
                keyColumn: "FrequencyID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 681, DateTimeKind.Local).AddTicks(6306));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "GenderID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 688, DateTimeKind.Local).AddTicks(6929));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "GenderID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 688, DateTimeKind.Local).AddTicks(6999));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 704, DateTimeKind.Local).AddTicks(5120));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 704, DateTimeKind.Local).AddTicks(5257));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 704, DateTimeKind.Local).AddTicks(5271));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 704, DateTimeKind.Local).AddTicks(5277));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 704, DateTimeKind.Local).AddTicks(5308));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 999,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 704, DateTimeKind.Local).AddTicks(5326));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 9998,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 704, DateTimeKind.Local).AddTicks(5321));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 706, DateTimeKind.Local).AddTicks(5354));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 706, DateTimeKind.Local).AddTicks(5493));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 706, DateTimeKind.Local).AddTicks(5498));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 706, DateTimeKind.Local).AddTicks(5502));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 706, DateTimeKind.Local).AddTicks(5506));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 706, DateTimeKind.Local).AddTicks(5514));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 706, DateTimeKind.Local).AddTicks(5519));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 706, DateTimeKind.Local).AddTicks(5522));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 706, DateTimeKind.Local).AddTicks(5525));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 706, DateTimeKind.Local).AddTicks(5529));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 706, DateTimeKind.Local).AddTicks(5532));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 706, DateTimeKind.Local).AddTicks(5535));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 13,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 706, DateTimeKind.Local).AddTicks(5539));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 14,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 706, DateTimeKind.Local).AddTicks(5542));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 15,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 706, DateTimeKind.Local).AddTicks(5545));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 16,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 706, DateTimeKind.Local).AddTicks(5548));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 17,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 706, DateTimeKind.Local).AddTicks(5551));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 18,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 706, DateTimeKind.Local).AddTicks(5556));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 19,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 706, DateTimeKind.Local).AddTicks(5559));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 20,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 706, DateTimeKind.Local).AddTicks(5562));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 9998,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 706, DateTimeKind.Local).AddTicks(5565));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 9999,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 706, DateTimeKind.Local).AddTicks(5568));

            migrationBuilder.UpdateData(
                table: "PaymentStatus",
                keyColumn: "PaymentStatusID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 668, DateTimeKind.Local).AddTicks(4588));

            migrationBuilder.UpdateData(
                table: "PaymentStatus",
                keyColumn: "PaymentStatusID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 668, DateTimeKind.Local).AddTicks(5072));

            migrationBuilder.UpdateData(
                table: "PaymentStatus",
                keyColumn: "PaymentStatusID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 668, DateTimeKind.Local).AddTicks(5086));

            migrationBuilder.UpdateData(
                table: "PaymentStatus",
                keyColumn: "PaymentStatusID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 668, DateTimeKind.Local).AddTicks(5090));

            migrationBuilder.UpdateData(
                table: "PaymentStatus",
                keyColumn: "PaymentStatusID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 668, DateTimeKind.Local).AddTicks(5094));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 664, DateTimeKind.Local).AddTicks(2858));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 664, DateTimeKind.Local).AddTicks(3341));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 664, DateTimeKind.Local).AddTicks(3351));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 664, DateTimeKind.Local).AddTicks(3357));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 664, DateTimeKind.Local).AddTicks(3363));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 664, DateTimeKind.Local).AddTicks(3373));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 664, DateTimeKind.Local).AddTicks(3378));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 664, DateTimeKind.Local).AddTicks(3383));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 664, DateTimeKind.Local).AddTicks(3388));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 664, DateTimeKind.Local).AddTicks(3396));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 664, DateTimeKind.Local).AddTicks(3401));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 664, DateTimeKind.Local).AddTicks(3407));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 13,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 664, DateTimeKind.Local).AddTicks(3412));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 14,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 664, DateTimeKind.Local).AddTicks(3417));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 15,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 664, DateTimeKind.Local).AddTicks(3422));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 16,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 664, DateTimeKind.Local).AddTicks(3427));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 17,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 664, DateTimeKind.Local).AddTicks(3432));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 18,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 664, DateTimeKind.Local).AddTicks(3439));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 19,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 664, DateTimeKind.Local).AddTicks(3445));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 20,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 664, DateTimeKind.Local).AddTicks(3449));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 21,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 664, DateTimeKind.Local).AddTicks(3454));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 22,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 664, DateTimeKind.Local).AddTicks(3459));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 23,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 664, DateTimeKind.Local).AddTicks(3480));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 24,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 664, DateTimeKind.Local).AddTicks(3486));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 25,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 664, DateTimeKind.Local).AddTicks(3491));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 26,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 664, DateTimeKind.Local).AddTicks(3499));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 27,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 664, DateTimeKind.Local).AddTicks(3504));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 28,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 664, DateTimeKind.Local).AddTicks(3510));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 29,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 664, DateTimeKind.Local).AddTicks(3515));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 30,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 664, DateTimeKind.Local).AddTicks(3520));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 31,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 664, DateTimeKind.Local).AddTicks(3526));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 32,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 664, DateTimeKind.Local).AddTicks(3532));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 33,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 664, DateTimeKind.Local).AddTicks(3537));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 34,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 664, DateTimeKind.Local).AddTicks(3545));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 35,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 664, DateTimeKind.Local).AddTicks(3550));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 36,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 664, DateTimeKind.Local).AddTicks(3555));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 37,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 664, DateTimeKind.Local).AddTicks(3560));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 38,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 664, DateTimeKind.Local).AddTicks(3565));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 39,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 664, DateTimeKind.Local).AddTicks(3570));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 40,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 664, DateTimeKind.Local).AddTicks(3575));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 41,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 664, DateTimeKind.Local).AddTicks(3579));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 42,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 664, DateTimeKind.Local).AddTicks(3584));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 43,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 664, DateTimeKind.Local).AddTicks(3591));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 44,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 664, DateTimeKind.Local).AddTicks(3596));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 45,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 664, DateTimeKind.Local).AddTicks(3601));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 46,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 664, DateTimeKind.Local).AddTicks(3607));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 47,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 664, DateTimeKind.Local).AddTicks(3612));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 48,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 664, DateTimeKind.Local).AddTicks(3617));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 49,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 664, DateTimeKind.Local).AddTicks(3622));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 50,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 664, DateTimeKind.Local).AddTicks(3627));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 51,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 664, DateTimeKind.Local).AddTicks(3631));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 52,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 664, DateTimeKind.Local).AddTicks(3636));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 53,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 664, DateTimeKind.Local).AddTicks(3641));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 54,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 664, DateTimeKind.Local).AddTicks(3646));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 55,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 664, DateTimeKind.Local).AddTicks(3650));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 56,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 664, DateTimeKind.Local).AddTicks(3655));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 57,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 664, DateTimeKind.Local).AddTicks(3660));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 58,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 664, DateTimeKind.Local).AddTicks(3665));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 59,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 664, DateTimeKind.Local).AddTicks(3670));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 60,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 664, DateTimeKind.Local).AddTicks(3675));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 61,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 664, DateTimeKind.Local).AddTicks(3680));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 62,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 664, DateTimeKind.Local).AddTicks(3685));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 63,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 664, DateTimeKind.Local).AddTicks(3690));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 64,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 664, DateTimeKind.Local).AddTicks(3695));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 65,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 664, DateTimeKind.Local).AddTicks(3700));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 66,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 664, DateTimeKind.Local).AddTicks(3717));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 67,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 664, DateTimeKind.Local).AddTicks(3722));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 68,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 664, DateTimeKind.Local).AddTicks(3727));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 69,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 664, DateTimeKind.Local).AddTicks(3731));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 70,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 664, DateTimeKind.Local).AddTicks(3736));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 71,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 664, DateTimeKind.Local).AddTicks(3740));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 72,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 664, DateTimeKind.Local).AddTicks(3745));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 73,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 664, DateTimeKind.Local).AddTicks(3749));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 74,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 664, DateTimeKind.Local).AddTicks(3754));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 75,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 664, DateTimeKind.Local).AddTicks(3759));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 76,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 664, DateTimeKind.Local).AddTicks(3764));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 77,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 664, DateTimeKind.Local).AddTicks(3769));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 78,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 664, DateTimeKind.Local).AddTicks(3774));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 79,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 664, DateTimeKind.Local).AddTicks(3778));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 80,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 664, DateTimeKind.Local).AddTicks(3784));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 81,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 664, DateTimeKind.Local).AddTicks(3788));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 82,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 664, DateTimeKind.Local).AddTicks(3793));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 83,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 664, DateTimeKind.Local).AddTicks(3798));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 84,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 664, DateTimeKind.Local).AddTicks(3803));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 85,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 664, DateTimeKind.Local).AddTicks(3808));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 86,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 664, DateTimeKind.Local).AddTicks(3812));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 87,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 664, DateTimeKind.Local).AddTicks(3817));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 88,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 664, DateTimeKind.Local).AddTicks(3822));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 89,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 664, DateTimeKind.Local).AddTicks(3827));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 90,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 664, DateTimeKind.Local).AddTicks(3832));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 91,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 664, DateTimeKind.Local).AddTicks(3837));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 92,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 664, DateTimeKind.Local).AddTicks(3842));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 93,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 664, DateTimeKind.Local).AddTicks(3847));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 94,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 664, DateTimeKind.Local).AddTicks(3852));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 95,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 664, DateTimeKind.Local).AddTicks(3856));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 96,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 664, DateTimeKind.Local).AddTicks(3862));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 97,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 664, DateTimeKind.Local).AddTicks(3867));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 98,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 664, DateTimeKind.Local).AddTicks(3872));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 99,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 664, DateTimeKind.Local).AddTicks(3876));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 100,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 664, DateTimeKind.Local).AddTicks(3881));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 101,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 664, DateTimeKind.Local).AddTicks(3885));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 102,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 664, DateTimeKind.Local).AddTicks(3891));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 103,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 664, DateTimeKind.Local).AddTicks(3896));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 104,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 664, DateTimeKind.Local).AddTicks(3901));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 105,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 664, DateTimeKind.Local).AddTicks(3906));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 106,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 664, DateTimeKind.Local).AddTicks(3923));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 107,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 664, DateTimeKind.Local).AddTicks(3928));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 108,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 664, DateTimeKind.Local).AddTicks(3934));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 109,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 664, DateTimeKind.Local).AddTicks(3939));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 110,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 664, DateTimeKind.Local).AddTicks(3944));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 111,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 664, DateTimeKind.Local).AddTicks(3948));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 112,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 664, DateTimeKind.Local).AddTicks(3954));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 113,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 664, DateTimeKind.Local).AddTicks(3958));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 114,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 664, DateTimeKind.Local).AddTicks(3963));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 115,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 664, DateTimeKind.Local).AddTicks(3967));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 116,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 664, DateTimeKind.Local).AddTicks(3972));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 117,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 664, DateTimeKind.Local).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 118,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 664, DateTimeKind.Local).AddTicks(3982));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 119,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 664, DateTimeKind.Local).AddTicks(3986));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 120,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 664, DateTimeKind.Local).AddTicks(3991));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 121,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 664, DateTimeKind.Local).AddTicks(3996));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 122,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 664, DateTimeKind.Local).AddTicks(4001));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 123,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 664, DateTimeKind.Local).AddTicks(4005));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 124,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 664, DateTimeKind.Local).AddTicks(4010));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 125,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 664, DateTimeKind.Local).AddTicks(4015));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 126,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 664, DateTimeKind.Local).AddTicks(4021));

            migrationBuilder.UpdateData(
                table: "PriorityRanks",
                keyColumn: "PriorityRankID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 692, DateTimeKind.Local).AddTicks(204));

            migrationBuilder.UpdateData(
                table: "PriorityRanks",
                keyColumn: "PriorityRankID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 692, DateTimeKind.Local).AddTicks(289));

            migrationBuilder.UpdateData(
                table: "PriorityRanks",
                keyColumn: "PriorityRankID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 692, DateTimeKind.Local).AddTicks(294));

            migrationBuilder.UpdateData(
                table: "PriorityRanks",
                keyColumn: "PriorityRankID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 692, DateTimeKind.Local).AddTicks(297));

            migrationBuilder.UpdateData(
                table: "RecordStatus",
                keyColumn: "RecordStatusID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 727, DateTimeKind.Local).AddTicks(7912));

            migrationBuilder.UpdateData(
                table: "RecordStatus",
                keyColumn: "RecordStatusID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 727, DateTimeKind.Local).AddTicks(8276));

            migrationBuilder.UpdateData(
                table: "RecordStatus",
                keyColumn: "RecordStatusID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 727, DateTimeKind.Local).AddTicks(8283));

            migrationBuilder.UpdateData(
                table: "RelationshipTypes",
                keyColumn: "RelationshipTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 686, DateTimeKind.Local).AddTicks(2302));

            migrationBuilder.UpdateData(
                table: "RelationshipTypes",
                keyColumn: "RelationshipTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 686, DateTimeKind.Local).AddTicks(2421));

            migrationBuilder.UpdateData(
                table: "RelationshipTypes",
                keyColumn: "RelationshipTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 686, DateTimeKind.Local).AddTicks(2424));

            migrationBuilder.UpdateData(
                table: "RelationshipTypes",
                keyColumn: "RelationshipTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 686, DateTimeKind.Local).AddTicks(2427));

            migrationBuilder.UpdateData(
                table: "RelationshipTypes",
                keyColumn: "RelationshipTypeID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 686, DateTimeKind.Local).AddTicks(2429));

            migrationBuilder.UpdateData(
                table: "RelationshipTypes",
                keyColumn: "RelationshipTypeID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 686, DateTimeKind.Local).AddTicks(2433));

            migrationBuilder.UpdateData(
                table: "RelationshipTypes",
                keyColumn: "RelationshipTypeID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 686, DateTimeKind.Local).AddTicks(2435));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 716, DateTimeKind.Local).AddTicks(793));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 716, DateTimeKind.Local).AddTicks(884));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 716, DateTimeKind.Local).AddTicks(887));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 716, DateTimeKind.Local).AddTicks(889));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 716, DateTimeKind.Local).AddTicks(891));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 716, DateTimeKind.Local).AddTicks(895));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 716, DateTimeKind.Local).AddTicks(897));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 716, DateTimeKind.Local).AddTicks(898));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 716, DateTimeKind.Local).AddTicks(900));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 716, DateTimeKind.Local).AddTicks(903));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 716, DateTimeKind.Local).AddTicks(904));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 716, DateTimeKind.Local).AddTicks(906));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 13,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 716, DateTimeKind.Local).AddTicks(907));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 14,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 716, DateTimeKind.Local).AddTicks(909));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 15,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 716, DateTimeKind.Local).AddTicks(910));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 16,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 716, DateTimeKind.Local).AddTicks(912));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 17,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 716, DateTimeKind.Local).AddTicks(914));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 18,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 716, DateTimeKind.Local).AddTicks(917));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 19,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 716, DateTimeKind.Local).AddTicks(918));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 20,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 716, DateTimeKind.Local).AddTicks(920));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 21,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 716, DateTimeKind.Local).AddTicks(922));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 22,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 716, DateTimeKind.Local).AddTicks(923));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 665, DateTimeKind.Local).AddTicks(1768));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 665, DateTimeKind.Local).AddTicks(1881));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 665, DateTimeKind.Local).AddTicks(1884));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 665, DateTimeKind.Local).AddTicks(1887));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 665, DateTimeKind.Local).AddTicks(1889));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 665, DateTimeKind.Local).AddTicks(1894));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 665, DateTimeKind.Local).AddTicks(1896));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 665, DateTimeKind.Local).AddTicks(1898));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 665, DateTimeKind.Local).AddTicks(1900));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 665, DateTimeKind.Local).AddTicks(1903));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 665, DateTimeKind.Local).AddTicks(1905));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 665, DateTimeKind.Local).AddTicks(1907));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 13,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 665, DateTimeKind.Local).AddTicks(1913));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 14,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 665, DateTimeKind.Local).AddTicks(1915));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 15,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 665, DateTimeKind.Local).AddTicks(1916));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 16,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 665, DateTimeKind.Local).AddTicks(1918));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 17,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 665, DateTimeKind.Local).AddTicks(1920));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 18,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 665, DateTimeKind.Local).AddTicks(1924));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 19,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 665, DateTimeKind.Local).AddTicks(1926));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 20,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 665, DateTimeKind.Local).AddTicks(1928));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 21,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 665, DateTimeKind.Local).AddTicks(1929));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 22,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 665, DateTimeKind.Local).AddTicks(1931));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 23,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 665, DateTimeKind.Local).AddTicks(1933));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 24,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 665, DateTimeKind.Local).AddTicks(1935));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 25,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 665, DateTimeKind.Local).AddTicks(1937));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 26,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 665, DateTimeKind.Local).AddTicks(1939));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 27,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 665, DateTimeKind.Local).AddTicks(1941));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 28,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 665, DateTimeKind.Local).AddTicks(1942));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 29,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 665, DateTimeKind.Local).AddTicks(1944));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 30,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 665, DateTimeKind.Local).AddTicks(1946));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 31,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 665, DateTimeKind.Local).AddTicks(1948));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 32,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 665, DateTimeKind.Local).AddTicks(1950));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 33,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 665, DateTimeKind.Local).AddTicks(1951));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 34,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 665, DateTimeKind.Local).AddTicks(1955));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 35,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 665, DateTimeKind.Local).AddTicks(1957));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 36,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 665, DateTimeKind.Local).AddTicks(1959));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 37,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 665, DateTimeKind.Local).AddTicks(1960));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 38,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 665, DateTimeKind.Local).AddTicks(1962));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 39,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 665, DateTimeKind.Local).AddTicks(1964));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 40,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 665, DateTimeKind.Local).AddTicks(1966));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 41,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 665, DateTimeKind.Local).AddTicks(1968));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 42,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 665, DateTimeKind.Local).AddTicks(1970));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 43,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 665, DateTimeKind.Local).AddTicks(1972));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 44,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 665, DateTimeKind.Local).AddTicks(1974));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 45,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 665, DateTimeKind.Local).AddTicks(1975));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 46,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 665, DateTimeKind.Local).AddTicks(1977));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 47,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 665, DateTimeKind.Local).AddTicks(1979));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 48,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 665, DateTimeKind.Local).AddTicks(1997));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 49,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 665, DateTimeKind.Local).AddTicks(1999));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 50,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 665, DateTimeKind.Local).AddTicks(2001));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 51,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 665, DateTimeKind.Local).AddTicks(2003));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 52,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 665, DateTimeKind.Local).AddTicks(2005));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 53,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 665, DateTimeKind.Local).AddTicks(2007));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 54,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 665, DateTimeKind.Local).AddTicks(2009));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 55,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 665, DateTimeKind.Local).AddTicks(2011));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 56,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 665, DateTimeKind.Local).AddTicks(2013));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 57,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 665, DateTimeKind.Local).AddTicks(2014));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 58,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 665, DateTimeKind.Local).AddTicks(2016));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 59,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 665, DateTimeKind.Local).AddTicks(2018));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 60,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 665, DateTimeKind.Local).AddTicks(2020));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 61,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 665, DateTimeKind.Local).AddTicks(2022));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 62,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 665, DateTimeKind.Local).AddTicks(2024));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 63,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 665, DateTimeKind.Local).AddTicks(2026));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 64,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 665, DateTimeKind.Local).AddTicks(2028));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 65,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 665, DateTimeKind.Local).AddTicks(2030));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 66,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 665, DateTimeKind.Local).AddTicks(2034));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 67,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 665, DateTimeKind.Local).AddTicks(2036));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 68,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 665, DateTimeKind.Local).AddTicks(2037));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 69,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 665, DateTimeKind.Local).AddTicks(2039));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 70,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 665, DateTimeKind.Local).AddTicks(2041));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 71,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 665, DateTimeKind.Local).AddTicks(2043));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 72,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 665, DateTimeKind.Local).AddTicks(2045));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 73,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 665, DateTimeKind.Local).AddTicks(2047));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 74,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 665, DateTimeKind.Local).AddTicks(2049));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 75,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 665, DateTimeKind.Local).AddTicks(2050));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 76,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 665, DateTimeKind.Local).AddTicks(2052));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 77,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 665, DateTimeKind.Local).AddTicks(2054));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 78,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 665, DateTimeKind.Local).AddTicks(2056));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 79,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 665, DateTimeKind.Local).AddTicks(2058));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 80,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 665, DateTimeKind.Local).AddTicks(2060));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 81,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 665, DateTimeKind.Local).AddTicks(2062));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 82,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 665, DateTimeKind.Local).AddTicks(2063));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 83,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 665, DateTimeKind.Local).AddTicks(2065));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 84,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 665, DateTimeKind.Local).AddTicks(2067));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 85,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 665, DateTimeKind.Local).AddTicks(2069));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 86,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 665, DateTimeKind.Local).AddTicks(2071));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 87,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 665, DateTimeKind.Local).AddTicks(2073));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 88,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 665, DateTimeKind.Local).AddTicks(2075));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 89,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 665, DateTimeKind.Local).AddTicks(2077));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 90,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 665, DateTimeKind.Local).AddTicks(2078));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 91,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 665, DateTimeKind.Local).AddTicks(2080));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 92,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 665, DateTimeKind.Local).AddTicks(2082));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 93,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 665, DateTimeKind.Local).AddTicks(2084));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 94,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 665, DateTimeKind.Local).AddTicks(2086));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 95,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 665, DateTimeKind.Local).AddTicks(2091));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 96,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 665, DateTimeKind.Local).AddTicks(2093));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 97,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 665, DateTimeKind.Local).AddTicks(2095));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 98,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 665, DateTimeKind.Local).AddTicks(2097));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 99,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 665, DateTimeKind.Local).AddTicks(2099));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 100,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 665, DateTimeKind.Local).AddTicks(2101));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 101,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 665, DateTimeKind.Local).AddTicks(2103));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 102,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 665, DateTimeKind.Local).AddTicks(2104));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 103,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 665, DateTimeKind.Local).AddTicks(2106));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 104,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 665, DateTimeKind.Local).AddTicks(2108));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 105,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 665, DateTimeKind.Local).AddTicks(2110));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 106,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 665, DateTimeKind.Local).AddTicks(2112));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 107,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 665, DateTimeKind.Local).AddTicks(2114));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 108,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 665, DateTimeKind.Local).AddTicks(2116));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 109,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 665, DateTimeKind.Local).AddTicks(2118));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 110,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 665, DateTimeKind.Local).AddTicks(2119));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 111,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 665, DateTimeKind.Local).AddTicks(2121));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 112,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 665, DateTimeKind.Local).AddTicks(2123));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 113,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 665, DateTimeKind.Local).AddTicks(2125));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 114,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 665, DateTimeKind.Local).AddTicks(2127));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 115,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 665, DateTimeKind.Local).AddTicks(2129));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 116,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 665, DateTimeKind.Local).AddTicks(2131));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 117,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 665, DateTimeKind.Local).AddTicks(2132));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 118,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 665, DateTimeKind.Local).AddTicks(2134));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 119,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 665, DateTimeKind.Local).AddTicks(2136));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 120,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 665, DateTimeKind.Local).AddTicks(2138));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 121,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 665, DateTimeKind.Local).AddTicks(2140));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 122,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 665, DateTimeKind.Local).AddTicks(2142));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 123,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 665, DateTimeKind.Local).AddTicks(2144));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 124,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 665, DateTimeKind.Local).AddTicks(2146));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 125,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 665, DateTimeKind.Local).AddTicks(2147));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 126,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 665, DateTimeKind.Local).AddTicks(2149));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 657, DateTimeKind.Local).AddTicks(7446));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 659, DateTimeKind.Local).AddTicks(2259));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 659, DateTimeKind.Local).AddTicks(2324));

            migrationBuilder.UpdateData(
                table: "StatementLists",
                keyColumn: "StatementID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 720, DateTimeKind.Local).AddTicks(7033));

            migrationBuilder.UpdateData(
                table: "StatementLists",
                keyColumn: "StatementID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 721, DateTimeKind.Local).AddTicks(1586));

            migrationBuilder.UpdateData(
                table: "SystemVariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 688, DateTimeKind.Local).AddTicks(677));

            migrationBuilder.UpdateData(
                table: "SystemVariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 688, DateTimeKind.Local).AddTicks(778));

            migrationBuilder.UpdateData(
                table: "SystemVariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 688, DateTimeKind.Local).AddTicks(774));

            migrationBuilder.UpdateData(
                table: "SystemVariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 688, DateTimeKind.Local).AddTicks(769));

            migrationBuilder.UpdateData(
                table: "SystemVariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 688, DateTimeKind.Local).AddTicks(762));

            migrationBuilder.UpdateData(
                table: "SystemVariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 688, DateTimeKind.Local).AddTicks(786));

            migrationBuilder.UpdateData(
                table: "SystemVariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 688, DateTimeKind.Local).AddTicks(794));

            migrationBuilder.UpdateData(
                table: "SystemVariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 688, DateTimeKind.Local).AddTicks(798));

            migrationBuilder.UpdateData(
                table: "SystemVariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 688, DateTimeKind.Local).AddTicks(801));

            migrationBuilder.UpdateData(
                table: "Titles",
                keyColumn: "TitleID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 723, DateTimeKind.Local).AddTicks(4919));

            migrationBuilder.UpdateData(
                table: "Titles",
                keyColumn: "TitleID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 723, DateTimeKind.Local).AddTicks(5457));

            migrationBuilder.UpdateData(
                table: "Titles",
                keyColumn: "TitleID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 723, DateTimeKind.Local).AddTicks(5464));

            migrationBuilder.UpdateData(
                table: "Titles",
                keyColumn: "TitleID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 723, DateTimeKind.Local).AddTicks(5468));

            migrationBuilder.UpdateData(
                table: "Titles",
                keyColumn: "TitleID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 723, DateTimeKind.Local).AddTicks(5471));

            migrationBuilder.UpdateData(
                table: "Titles",
                keyColumn: "TitleID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 723, DateTimeKind.Local).AddTicks(5482));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 672, DateTimeKind.Local).AddTicks(1635));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 672, DateTimeKind.Local).AddTicks(2405));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 672, DateTimeKind.Local).AddTicks(2510));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 672, DateTimeKind.Local).AddTicks(2602));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 672, DateTimeKind.Local).AddTicks(2733));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 672, DateTimeKind.Local).AddTicks(2821));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 672, DateTimeKind.Local).AddTicks(2896));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 672, DateTimeKind.Local).AddTicks(2964));

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumns: new[] { "UserID", "RoleID" },
                keyValues: new object[] { 1, 1 },
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 703, DateTimeKind.Local).AddTicks(309));

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumns: new[] { "UserID", "RoleID" },
                keyValues: new object[] { 2, 3 },
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 703, DateTimeKind.Local).AddTicks(374));

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "UserTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 684, DateTimeKind.Local).AddTicks(4630));

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "UserTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 684, DateTimeKind.Local).AddTicks(5063));

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "UserTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 684, DateTimeKind.Local).AddTicks(5074));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 692, DateTimeKind.Local).AddTicks(6740));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 695, DateTimeKind.Local).AddTicks(527));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 4, 4, 16, 40, 26, 695, DateTimeKind.Local).AddTicks(749));
        }
    }
}
