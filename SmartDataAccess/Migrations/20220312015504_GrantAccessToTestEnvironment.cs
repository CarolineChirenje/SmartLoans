using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SmartDataAccess.Migrations
{
    public partial class GrantAccessToTestEnvironment : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "GrantAccessToTestEnvironment",
                table: "Users",
                nullable: false,
                defaultValue: false);

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
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 453, DateTimeKind.Local).AddTicks(3946));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 454, DateTimeKind.Local).AddTicks(4955));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 3, 12, 12, 55, 2, 454, DateTimeKind.Local).AddTicks(5322));

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "GrantAccessToTestEnvironment",
                table: "Users");

            migrationBuilder.UpdateData(
                table: "BankAccountTypes",
                keyColumn: "BankAccountTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 648, DateTimeKind.Local).AddTicks(3426));

            migrationBuilder.UpdateData(
                table: "BankAccountTypes",
                keyColumn: "BankAccountTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 648, DateTimeKind.Local).AddTicks(3693));

            migrationBuilder.UpdateData(
                table: "BankAccountTypes",
                keyColumn: "BankAccountTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 648, DateTimeKind.Local).AddTicks(3706));

            migrationBuilder.UpdateData(
                table: "BankAccountTypes",
                keyColumn: "BankAccountTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 648, DateTimeKind.Local).AddTicks(3711));

            migrationBuilder.UpdateData(
                table: "ClientAccountTypes",
                keyColumn: "ID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 677, DateTimeKind.Local).AddTicks(8330));

            migrationBuilder.UpdateData(
                table: "ClientAccountTypes",
                keyColumn: "ID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 677, DateTimeKind.Local).AddTicks(8549));

            migrationBuilder.UpdateData(
                table: "ClientGroups",
                keyColumn: "ClientGroupID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 680, DateTimeKind.Local).AddTicks(6107));

            migrationBuilder.UpdateData(
                table: "ClientGroups",
                keyColumn: "ClientGroupID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 680, DateTimeKind.Local).AddTicks(8504));

            migrationBuilder.UpdateData(
                table: "ContactTypes",
                keyColumn: "ContactTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 653, DateTimeKind.Local).AddTicks(4709));

            migrationBuilder.UpdateData(
                table: "ContactTypes",
                keyColumn: "ContactTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 653, DateTimeKind.Local).AddTicks(4703));

            migrationBuilder.UpdateData(
                table: "ContactTypes",
                keyColumn: "ContactTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 653, DateTimeKind.Local).AddTicks(4696));

            migrationBuilder.UpdateData(
                table: "ContactTypes",
                keyColumn: "ContactTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 653, DateTimeKind.Local).AddTicks(4625));

            migrationBuilder.UpdateData(
                table: "ContactTypes",
                keyColumn: "ContactTypeID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 653, DateTimeKind.Local).AddTicks(4713));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(14));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(235));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(261));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(268));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(272));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(278));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(283));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(287));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(292));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(296));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(301));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(305));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 13,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(309));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 14,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(313));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 15,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(317));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 16,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(322));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 17,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(325));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 18,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(330));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 19,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(335));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 20,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(339));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 21,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(342));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 22,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(346));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 23,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(350));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 24,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(354));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 25,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(358));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 26,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(362));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 27,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(366));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 28,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(370));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 29,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(374));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 30,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(379));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 31,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(383));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 32,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(387));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 33,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(391));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 34,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(396));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 35,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(400));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 36,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(404));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 37,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(408));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 38,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(411));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 39,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(416));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 40,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(420));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 41,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(425));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 42,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(429));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 43,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(433));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 44,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(436));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 45,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(440));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 46,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(444));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 47,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(449));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 48,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(454));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 49,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(492));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 50,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(498));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 51,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(502));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 52,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(506));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 53,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(510));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 54,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(514));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 55,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(519));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 56,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(523));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 57,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(527));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 58,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(532));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 59,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(537));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 60,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(541));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 61,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(546));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 62,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(549));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 63,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(554));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 64,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(559));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 65,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(563));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 66,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(568));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 67,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(572));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 68,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(576));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 69,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(580));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 70,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(584));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 71,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(588));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 72,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(592));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 73,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(597));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 74,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(601));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 75,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(606));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 76,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(610));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 77,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(614));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 78,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(618));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 79,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(622));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 80,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(626));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 81,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(630));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 82,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(634));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 83,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(638));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 84,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(642));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 85,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(645));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 86,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(650));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 87,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(653));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 88,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(657));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 89,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(662));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 90,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(665));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 91,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(669));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 92,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(673));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 93,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(677));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 94,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(681));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 95,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(685));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 96,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(689));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 97,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(693));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 98,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(697));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 99,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(701));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 100,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(705));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 101,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(710));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 102,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(713));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 103,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(718));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 104,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(722));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 105,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(726));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 106,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(729));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 107,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(733));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 108,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(737));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 109,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(764));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 110,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(769));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 111,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(774));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 112,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(778));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 113,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(782));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 114,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(786));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 115,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(791));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 116,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(795));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 117,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(798));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 118,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(802));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 119,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(806));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 120,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(810));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 121,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(814));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 122,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(818));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 123,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(821));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 124,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(825));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 125,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(829));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 126,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(833));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 127,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(837));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 128,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(840));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 129,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(845));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 130,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(850));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 131,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(854));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 132,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(859));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 133,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(862));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 134,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(866));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 135,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(870));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 136,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(873));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 137,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(877));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 138,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(882));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 139,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(886));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 140,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(889));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 141,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(893));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 142,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(897));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 143,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(901));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 144,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(905));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 145,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(908));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 146,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(912));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 147,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(916));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 148,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(920));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 149,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(925));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 150,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(929));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 151,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(934));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 152,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(938));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 153,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(942));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 154,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(946));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 155,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(950));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 156,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(954));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 157,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(958));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 158,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(961));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 159,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(965));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 160,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(969));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 161,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(973));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 162,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(977));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 163,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(1004));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 164,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(1010));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 165,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(1014));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 166,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(1018));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 167,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(1022));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 168,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(1026));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 169,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(1030));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 170,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(1033));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 171,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(1037));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 172,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(1041));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 173,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(1046));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 174,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(1050));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 175,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(1055));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 176,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(1059));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 177,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(1065));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 178,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(1069));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 179,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(1073));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 180,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(1078));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 181,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(1082));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 182,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(1087));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 183,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(1091));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 184,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(1095));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 185,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(1098));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 186,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(1103));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 187,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(1106));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 188,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(1111));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 189,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(1115));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 190,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(1119));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 191,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(1123));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 192,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(1127));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 193,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(1131));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 194,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(1135));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 195,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(1139));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 196,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(1143));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 197,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(1147));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 198,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(1151));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 199,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(1154));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 200,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(1158));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 201,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(1162));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 202,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(1166));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 203,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(1170));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 204,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(1173));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 205,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(1177));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 206,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(1182));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 207,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(1185));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 208,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(1189));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 209,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(1193));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 210,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(1198));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 211,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(1202));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 212,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(1205));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 213,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(1209));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 214,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(1214));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 215,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(1218));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 216,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(1223));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 217,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(1226));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 218,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(1231));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 219,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(1234));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 220,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(1238));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 221,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(1242));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 222,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(1246));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 223,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(1251));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 224,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(1255));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 225,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(1259));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 226,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(1262));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 227,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(1281));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 228,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 657, DateTimeKind.Local).AddTicks(1286));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 650, DateTimeKind.Local).AddTicks(53));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 650, DateTimeKind.Local).AddTicks(300));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 650, DateTimeKind.Local).AddTicks(311));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 650, DateTimeKind.Local).AddTicks(316));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 650, DateTimeKind.Local).AddTicks(320));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 650, DateTimeKind.Local).AddTicks(328));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 650, DateTimeKind.Local).AddTicks(333));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 650, DateTimeKind.Local).AddTicks(371));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 650, DateTimeKind.Local).AddTicks(377));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 650, DateTimeKind.Local).AddTicks(383));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 650, DateTimeKind.Local).AddTicks(388));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 650, DateTimeKind.Local).AddTicks(392));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 13,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 650, DateTimeKind.Local).AddTicks(397));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 14,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 650, DateTimeKind.Local).AddTicks(402));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 15,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 650, DateTimeKind.Local).AddTicks(406));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 16,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 650, DateTimeKind.Local).AddTicks(411));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 17,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 650, DateTimeKind.Local).AddTicks(415));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 18,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 650, DateTimeKind.Local).AddTicks(421));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 19,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 650, DateTimeKind.Local).AddTicks(426));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 20,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 650, DateTimeKind.Local).AddTicks(430));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 21,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 650, DateTimeKind.Local).AddTicks(435));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 22,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 650, DateTimeKind.Local).AddTicks(440));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 23,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 650, DateTimeKind.Local).AddTicks(445));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 24,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 650, DateTimeKind.Local).AddTicks(449));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 25,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 650, DateTimeKind.Local).AddTicks(454));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 26,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 650, DateTimeKind.Local).AddTicks(459));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 27,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 650, DateTimeKind.Local).AddTicks(463));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 28,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 650, DateTimeKind.Local).AddTicks(468));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 29,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 650, DateTimeKind.Local).AddTicks(473));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 30,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 650, DateTimeKind.Local).AddTicks(477));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 31,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 650, DateTimeKind.Local).AddTicks(482));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 32,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 650, DateTimeKind.Local).AddTicks(487));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 33,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 650, DateTimeKind.Local).AddTicks(491));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 34,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 650, DateTimeKind.Local).AddTicks(497));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 35,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 650, DateTimeKind.Local).AddTicks(501));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 36,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 650, DateTimeKind.Local).AddTicks(506));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 37,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 650, DateTimeKind.Local).AddTicks(511));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 38,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 650, DateTimeKind.Local).AddTicks(515));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 39,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 650, DateTimeKind.Local).AddTicks(520));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 40,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 650, DateTimeKind.Local).AddTicks(524));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 41,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 650, DateTimeKind.Local).AddTicks(529));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 42,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 650, DateTimeKind.Local).AddTicks(534));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 43,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 650, DateTimeKind.Local).AddTicks(539));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 44,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 650, DateTimeKind.Local).AddTicks(543));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 45,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 650, DateTimeKind.Local).AddTicks(548));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 46,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 650, DateTimeKind.Local).AddTicks(552));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 47,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 650, DateTimeKind.Local).AddTicks(557));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 48,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 650, DateTimeKind.Local).AddTicks(561));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 49,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 650, DateTimeKind.Local).AddTicks(566));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 50,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 650, DateTimeKind.Local).AddTicks(570));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 51,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 650, DateTimeKind.Local).AddTicks(575));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 52,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 650, DateTimeKind.Local).AddTicks(580));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 53,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 650, DateTimeKind.Local).AddTicks(584));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 54,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 650, DateTimeKind.Local).AddTicks(589));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 55,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 650, DateTimeKind.Local).AddTicks(593));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 56,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 650, DateTimeKind.Local).AddTicks(598));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 57,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 650, DateTimeKind.Local).AddTicks(603));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 58,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 650, DateTimeKind.Local).AddTicks(607));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 59,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 650, DateTimeKind.Local).AddTicks(612));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 60,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 650, DateTimeKind.Local).AddTicks(616));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 61,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 650, DateTimeKind.Local).AddTicks(621));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 62,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 650, DateTimeKind.Local).AddTicks(626));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 63,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 650, DateTimeKind.Local).AddTicks(630));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 64,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 650, DateTimeKind.Local).AddTicks(635));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 65,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 650, DateTimeKind.Local).AddTicks(639));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 66,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 650, DateTimeKind.Local).AddTicks(645));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 67,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 650, DateTimeKind.Local).AddTicks(676));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 68,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 650, DateTimeKind.Local).AddTicks(681));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 69,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 650, DateTimeKind.Local).AddTicks(685));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 70,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 650, DateTimeKind.Local).AddTicks(690));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 71,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 650, DateTimeKind.Local).AddTicks(695));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 72,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 650, DateTimeKind.Local).AddTicks(699));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 73,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 650, DateTimeKind.Local).AddTicks(704));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 74,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 650, DateTimeKind.Local).AddTicks(708));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 75,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 650, DateTimeKind.Local).AddTicks(713));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 76,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 650, DateTimeKind.Local).AddTicks(717));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 77,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 650, DateTimeKind.Local).AddTicks(722));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 78,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 650, DateTimeKind.Local).AddTicks(726));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 79,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 650, DateTimeKind.Local).AddTicks(731));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 80,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 650, DateTimeKind.Local).AddTicks(736));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 81,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 650, DateTimeKind.Local).AddTicks(740));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 82,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 650, DateTimeKind.Local).AddTicks(745));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 83,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 650, DateTimeKind.Local).AddTicks(750));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 84,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 650, DateTimeKind.Local).AddTicks(755));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 85,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 650, DateTimeKind.Local).AddTicks(760));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 86,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 650, DateTimeKind.Local).AddTicks(764));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 87,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 650, DateTimeKind.Local).AddTicks(769));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 88,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 650, DateTimeKind.Local).AddTicks(773));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 89,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 650, DateTimeKind.Local).AddTicks(778));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 90,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 650, DateTimeKind.Local).AddTicks(783));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 91,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 650, DateTimeKind.Local).AddTicks(787));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 92,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 650, DateTimeKind.Local).AddTicks(792));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 93,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 650, DateTimeKind.Local).AddTicks(797));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 94,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 650, DateTimeKind.Local).AddTicks(802));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 95,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 650, DateTimeKind.Local).AddTicks(806));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 96,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 650, DateTimeKind.Local).AddTicks(811));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 97,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 650, DateTimeKind.Local).AddTicks(815));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 98,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 650, DateTimeKind.Local).AddTicks(820));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 99,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 650, DateTimeKind.Local).AddTicks(824));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 100,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 650, DateTimeKind.Local).AddTicks(829));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 101,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 650, DateTimeKind.Local).AddTicks(834));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 102,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 650, DateTimeKind.Local).AddTicks(839));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 103,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 650, DateTimeKind.Local).AddTicks(843));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 104,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 650, DateTimeKind.Local).AddTicks(848));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 105,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 650, DateTimeKind.Local).AddTicks(852));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 106,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 650, DateTimeKind.Local).AddTicks(857));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 107,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 650, DateTimeKind.Local).AddTicks(862));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 108,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 650, DateTimeKind.Local).AddTicks(866));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 109,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 650, DateTimeKind.Local).AddTicks(871));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 110,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 650, DateTimeKind.Local).AddTicks(875));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 111,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 650, DateTimeKind.Local).AddTicks(880));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 112,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 650, DateTimeKind.Local).AddTicks(885));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 113,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 650, DateTimeKind.Local).AddTicks(889));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 114,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 650, DateTimeKind.Local).AddTicks(894));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 115,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 650, DateTimeKind.Local).AddTicks(898));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 116,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 650, DateTimeKind.Local).AddTicks(903));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 117,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 650, DateTimeKind.Local).AddTicks(907));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 118,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 650, DateTimeKind.Local).AddTicks(912));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 119,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 650, DateTimeKind.Local).AddTicks(917));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 120,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 650, DateTimeKind.Local).AddTicks(921));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 121,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 650, DateTimeKind.Local).AddTicks(926));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 122,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 650, DateTimeKind.Local).AddTicks(930));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 123,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 650, DateTimeKind.Local).AddTicks(935));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 124,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 650, DateTimeKind.Local).AddTicks(940));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 125,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 650, DateTimeKind.Local).AddTicks(944));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 126,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 650, DateTimeKind.Local).AddTicks(949));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 127,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 650, DateTimeKind.Local).AddTicks(954));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 128,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 650, DateTimeKind.Local).AddTicks(958));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 129,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 650, DateTimeKind.Local).AddTicks(963));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 130,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 650, DateTimeKind.Local).AddTicks(994));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 131,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 650, DateTimeKind.Local).AddTicks(999));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 132,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 650, DateTimeKind.Local).AddTicks(1004));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 133,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 650, DateTimeKind.Local).AddTicks(1008));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 134,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 650, DateTimeKind.Local).AddTicks(1013));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 135,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 650, DateTimeKind.Local).AddTicks(1017));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 136,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 650, DateTimeKind.Local).AddTicks(1022));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 137,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 650, DateTimeKind.Local).AddTicks(1026));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 138,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 650, DateTimeKind.Local).AddTicks(1031));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 139,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 650, DateTimeKind.Local).AddTicks(1036));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 140,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 650, DateTimeKind.Local).AddTicks(1040));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 141,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 650, DateTimeKind.Local).AddTicks(1045));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 142,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 650, DateTimeKind.Local).AddTicks(1049));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 143,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 650, DateTimeKind.Local).AddTicks(1054));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 144,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 650, DateTimeKind.Local).AddTicks(1059));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 145,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 650, DateTimeKind.Local).AddTicks(1063));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 146,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 650, DateTimeKind.Local).AddTicks(1068));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 147,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 650, DateTimeKind.Local).AddTicks(1072));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 148,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 650, DateTimeKind.Local).AddTicks(1077));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 149,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 650, DateTimeKind.Local).AddTicks(1081));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 150,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 650, DateTimeKind.Local).AddTicks(1086));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 151,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 650, DateTimeKind.Local).AddTicks(1091));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 152,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 650, DateTimeKind.Local).AddTicks(1095));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 153,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 650, DateTimeKind.Local).AddTicks(1100));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 154,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 650, DateTimeKind.Local).AddTicks(1104));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 155,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 650, DateTimeKind.Local).AddTicks(1109));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 156,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 650, DateTimeKind.Local).AddTicks(1113));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 157,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 650, DateTimeKind.Local).AddTicks(1118));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 158,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 650, DateTimeKind.Local).AddTicks(1123));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 159,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 650, DateTimeKind.Local).AddTicks(1127));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 160,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 650, DateTimeKind.Local).AddTicks(1132));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 161,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 650, DateTimeKind.Local).AddTicks(1136));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 162,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 650, DateTimeKind.Local).AddTicks(1141));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 671, DateTimeKind.Local).AddTicks(7628));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 671, DateTimeKind.Local).AddTicks(7729));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 671, DateTimeKind.Local).AddTicks(7750));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 671, DateTimeKind.Local).AddTicks(7735));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 671, DateTimeKind.Local).AddTicks(7755));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 671, DateTimeKind.Local).AddTicks(7765));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 671, DateTimeKind.Local).AddTicks(7771));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 671, DateTimeKind.Local).AddTicks(7777));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 671, DateTimeKind.Local).AddTicks(7782));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 671, DateTimeKind.Local).AddTicks(7788));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 671, DateTimeKind.Local).AddTicks(7829));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 671, DateTimeKind.Local).AddTicks(7835));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 13,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 671, DateTimeKind.Local).AddTicks(7840));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 14,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 671, DateTimeKind.Local).AddTicks(7846));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 15,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 671, DateTimeKind.Local).AddTicks(7740));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 16,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 671, DateTimeKind.Local).AddTicks(7722));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 17,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 671, DateTimeKind.Local).AddTicks(7852));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 18,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 671, DateTimeKind.Local).AddTicks(7858));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 19,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 671, DateTimeKind.Local).AddTicks(7863));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 20,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 671, DateTimeKind.Local).AddTicks(7869));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 22,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 671, DateTimeKind.Local).AddTicks(7890));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 23,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 671, DateTimeKind.Local).AddTicks(7880));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 24,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 671, DateTimeKind.Local).AddTicks(7874));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 25,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 671, DateTimeKind.Local).AddTicks(7885));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 26,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 671, DateTimeKind.Local).AddTicks(7895));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 27,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 671, DateTimeKind.Local).AddTicks(7900));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 28,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 671, DateTimeKind.Local).AddTicks(7905));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 30,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 671, DateTimeKind.Local).AddTicks(7910));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 31,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 671, DateTimeKind.Local).AddTicks(7916));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 32,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 671, DateTimeKind.Local).AddTicks(7921));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 33,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 671, DateTimeKind.Local).AddTicks(7930));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 34,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 671, DateTimeKind.Local).AddTicks(7935));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 36,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 671, DateTimeKind.Local).AddTicks(7941));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 37,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 671, DateTimeKind.Local).AddTicks(7946));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 38,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 671, DateTimeKind.Local).AddTicks(7978));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 39,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 671, DateTimeKind.Local).AddTicks(7760));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 40,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 671, DateTimeKind.Local).AddTicks(7985));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 41,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 671, DateTimeKind.Local).AddTicks(7990));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 42,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 671, DateTimeKind.Local).AddTicks(7995));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 43,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 671, DateTimeKind.Local).AddTicks(8000));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 44,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 671, DateTimeKind.Local).AddTicks(8005));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 45,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 671, DateTimeKind.Local).AddTicks(8010));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 46,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 671, DateTimeKind.Local).AddTicks(8015));

            migrationBuilder.UpdateData(
                table: "DeductionTypes",
                keyColumn: "DeductionTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 686, DateTimeKind.Local).AddTicks(9378));

            migrationBuilder.UpdateData(
                table: "DeductionTypes",
                keyColumn: "DeductionTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 686, DateTimeKind.Local).AddTicks(9658));

            migrationBuilder.UpdateData(
                table: "DeductionTypes",
                keyColumn: "DeductionTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 686, DateTimeKind.Local).AddTicks(9671));

            migrationBuilder.UpdateData(
                table: "DocumentFormats",
                keyColumn: "DocumentFormatID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 662, DateTimeKind.Local).AddTicks(9520));

            migrationBuilder.UpdateData(
                table: "DocumentFormats",
                keyColumn: "DocumentFormatID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 662, DateTimeKind.Local).AddTicks(9726));

            migrationBuilder.UpdateData(
                table: "DocumentFormats",
                keyColumn: "DocumentFormatID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 662, DateTimeKind.Local).AddTicks(9736));

            migrationBuilder.UpdateData(
                table: "DocumentFormats",
                keyColumn: "DocumentFormatID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 662, DateTimeKind.Local).AddTicks(9742));

            migrationBuilder.UpdateData(
                table: "DocumentFormats",
                keyColumn: "DocumentFormatID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 662, DateTimeKind.Local).AddTicks(9747));

            migrationBuilder.UpdateData(
                table: "DocumentFormats",
                keyColumn: "DocumentFormatID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 662, DateTimeKind.Local).AddTicks(9754));

            migrationBuilder.UpdateData(
                table: "DocumentTypes",
                keyColumn: "DocumentTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 664, DateTimeKind.Local).AddTicks(3555));

            migrationBuilder.UpdateData(
                table: "DocumentTypes",
                keyColumn: "DocumentTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 664, DateTimeKind.Local).AddTicks(3959));

            migrationBuilder.UpdateData(
                table: "DocumentTypes",
                keyColumn: "DocumentTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 664, DateTimeKind.Local).AddTicks(3980));

            migrationBuilder.UpdateData(
                table: "DocumentTypes",
                keyColumn: "DocumentTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 664, DateTimeKind.Local).AddTicks(3985));

            migrationBuilder.UpdateData(
                table: "EmailTemplates",
                keyColumn: "EmailTemplateID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 669, DateTimeKind.Local).AddTicks(3204));

            migrationBuilder.UpdateData(
                table: "EmailTypes",
                keyColumn: "EmailTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 669, DateTimeKind.Local).AddTicks(537));

            migrationBuilder.UpdateData(
                table: "EmailTypes",
                keyColumn: "EmailTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 669, DateTimeKind.Local).AddTicks(750));

            migrationBuilder.UpdateData(
                table: "EmailTypes",
                keyColumn: "EmailTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 669, DateTimeKind.Local).AddTicks(759));

            migrationBuilder.UpdateData(
                table: "EmailTypes",
                keyColumn: "EmailTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 669, DateTimeKind.Local).AddTicks(765));

            migrationBuilder.UpdateData(
                table: "FeatureFlags",
                keyColumn: "FeatureFlagID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 661, DateTimeKind.Local).AddTicks(5395));

            migrationBuilder.UpdateData(
                table: "FeatureFlags",
                keyColumn: "FeatureFlagID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 661, DateTimeKind.Local).AddTicks(5611));

            migrationBuilder.UpdateData(
                table: "FeatureFlags",
                keyColumn: "FeatureFlagID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 661, DateTimeKind.Local).AddTicks(5622));

            migrationBuilder.UpdateData(
                table: "Frequencies",
                keyColumn: "FrequencyID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 651, DateTimeKind.Local).AddTicks(5665));

            migrationBuilder.UpdateData(
                table: "Frequencies",
                keyColumn: "FrequencyID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 651, DateTimeKind.Local).AddTicks(5871));

            migrationBuilder.UpdateData(
                table: "FundSources",
                keyColumn: "FundSourceID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 689, DateTimeKind.Local).AddTicks(9808));

            migrationBuilder.UpdateData(
                table: "FundSources",
                keyColumn: "FundSourceID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 690, DateTimeKind.Local).AddTicks(44));

            migrationBuilder.UpdateData(
                table: "FundSources",
                keyColumn: "FundSourceID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 690, DateTimeKind.Local).AddTicks(55));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "GenderID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 655, DateTimeKind.Local).AddTicks(5658));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "GenderID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 655, DateTimeKind.Local).AddTicks(5732));

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "InvoiceStatusID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 682, DateTimeKind.Local).AddTicks(2450));

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "InvoiceStatusID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 682, DateTimeKind.Local).AddTicks(2653));

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "InvoiceStatusID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 682, DateTimeKind.Local).AddTicks(2663));

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "InvoiceStatusID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 682, DateTimeKind.Local).AddTicks(2668));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 685, DateTimeKind.Local).AddTicks(5204));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 685, DateTimeKind.Local).AddTicks(5320));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 685, DateTimeKind.Local).AddTicks(5328));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 685, DateTimeKind.Local).AddTicks(5333));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 685, DateTimeKind.Local).AddTicks(5339));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 685, DateTimeKind.Local).AddTicks(5346));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 685, DateTimeKind.Local).AddTicks(5352));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 685, DateTimeKind.Local).AddTicks(5356));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 685, DateTimeKind.Local).AddTicks(5362));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 685, DateTimeKind.Local).AddTicks(5368));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 685, DateTimeKind.Local).AddTicks(5373));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 685, DateTimeKind.Local).AddTicks(5378));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 13,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 685, DateTimeKind.Local).AddTicks(5382));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 14,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 685, DateTimeKind.Local).AddTicks(5387));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 15,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 685, DateTimeKind.Local).AddTicks(5549));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 16,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 685, DateTimeKind.Local).AddTicks(5565));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 17,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 685, DateTimeKind.Local).AddTicks(5570));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 18,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 685, DateTimeKind.Local).AddTicks(5577));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 19,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 685, DateTimeKind.Local).AddTicks(5582));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 20,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 685, DateTimeKind.Local).AddTicks(5586));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 21,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 685, DateTimeKind.Local).AddTicks(5591));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 22,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 685, DateTimeKind.Local).AddTicks(5596));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 23,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 685, DateTimeKind.Local).AddTicks(5600));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 24,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 685, DateTimeKind.Local).AddTicks(5605));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 25,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 685, DateTimeKind.Local).AddTicks(5609));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 26,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 685, DateTimeKind.Local).AddTicks(5614));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 27,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 685, DateTimeKind.Local).AddTicks(5619));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 28,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 685, DateTimeKind.Local).AddTicks(5624));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 29,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 685, DateTimeKind.Local).AddTicks(5628));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 30,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 685, DateTimeKind.Local).AddTicks(5632));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 31,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 685, DateTimeKind.Local).AddTicks(5636));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 32,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 685, DateTimeKind.Local).AddTicks(5640));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 33,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 685, DateTimeKind.Local).AddTicks(5644));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 34,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 685, DateTimeKind.Local).AddTicks(5649));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 35,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 685, DateTimeKind.Local).AddTicks(5653));

            migrationBuilder.UpdateData(
                table: "Layouts",
                keyColumn: "LayoutID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 683, DateTimeKind.Local).AddTicks(6525));

            migrationBuilder.UpdateData(
                table: "Layouts",
                keyColumn: "LayoutID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 683, DateTimeKind.Local).AddTicks(6728));

            migrationBuilder.UpdateData(
                table: "Layouts",
                keyColumn: "LayoutID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 683, DateTimeKind.Local).AddTicks(6741));

            migrationBuilder.UpdateData(
                table: "Layouts",
                keyColumn: "LayoutID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 683, DateTimeKind.Local).AddTicks(6750));

            migrationBuilder.UpdateData(
                table: "Layouts",
                keyColumn: "LayoutID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 683, DateTimeKind.Local).AddTicks(6756));

            migrationBuilder.UpdateData(
                table: "Layouts",
                keyColumn: "LayoutID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 683, DateTimeKind.Local).AddTicks(6763));

            migrationBuilder.UpdateData(
                table: "Layouts",
                keyColumn: "LayoutID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 683, DateTimeKind.Local).AddTicks(6768));

            migrationBuilder.UpdateData(
                table: "Layouts",
                keyColumn: "LayoutID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 683, DateTimeKind.Local).AddTicks(6773));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 665, DateTimeKind.Local).AddTicks(6244));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 665, DateTimeKind.Local).AddTicks(6348));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 665, DateTimeKind.Local).AddTicks(6359));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 665, DateTimeKind.Local).AddTicks(6366));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 665, DateTimeKind.Local).AddTicks(6371));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 665, DateTimeKind.Local).AddTicks(6407));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 665, DateTimeKind.Local).AddTicks(6380));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 665, DateTimeKind.Local).AddTicks(6386));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 999,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 665, DateTimeKind.Local).AddTicks(6399));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 9998,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 665, DateTimeKind.Local).AddTicks(6392));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 666, DateTimeKind.Local).AddTicks(4181));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 666, DateTimeKind.Local).AddTicks(4279));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 666, DateTimeKind.Local).AddTicks(4285));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 666, DateTimeKind.Local).AddTicks(4290));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 666, DateTimeKind.Local).AddTicks(4294));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 666, DateTimeKind.Local).AddTicks(4301));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 666, DateTimeKind.Local).AddTicks(4305));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 666, DateTimeKind.Local).AddTicks(4309));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 666, DateTimeKind.Local).AddTicks(4313));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 9994,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 666, DateTimeKind.Local).AddTicks(4318));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 9995,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 666, DateTimeKind.Local).AddTicks(4322));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 9996,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 666, DateTimeKind.Local).AddTicks(4358));

            migrationBuilder.UpdateData(
                table: "PaymentStatus",
                keyColumn: "PaymentStatusID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 644, DateTimeKind.Local).AddTicks(1147));

            migrationBuilder.UpdateData(
                table: "PaymentStatus",
                keyColumn: "PaymentStatusID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 644, DateTimeKind.Local).AddTicks(1445));

            migrationBuilder.UpdateData(
                table: "PaymentStatus",
                keyColumn: "PaymentStatusID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 644, DateTimeKind.Local).AddTicks(1459));

            migrationBuilder.UpdateData(
                table: "PaymentStatus",
                keyColumn: "PaymentStatusID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 644, DateTimeKind.Local).AddTicks(1465));

            migrationBuilder.UpdateData(
                table: "PaymentStatus",
                keyColumn: "PaymentStatusID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 644, DateTimeKind.Local).AddTicks(1471));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 640, DateTimeKind.Local).AddTicks(8776));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 640, DateTimeKind.Local).AddTicks(9727));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 640, DateTimeKind.Local).AddTicks(9775));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 640, DateTimeKind.Local).AddTicks(9798));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 640, DateTimeKind.Local).AddTicks(9825));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 640, DateTimeKind.Local).AddTicks(9862));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 640, DateTimeKind.Local).AddTicks(9887));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 640, DateTimeKind.Local).AddTicks(9909));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(92));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(125));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(150));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(174));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 13,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(194));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 14,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(216));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 15,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(239));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 16,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(261));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 17,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(283));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 18,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(311));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 19,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(333));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 20,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(358));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 21,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(380));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 22,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(402));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 23,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(426));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 24,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(448));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 25,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(474));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 26,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(496));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 27,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(518));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 28,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(541));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 29,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(562));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 30,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(586));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 31,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(610));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 32,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(634));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 33,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(657));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 34,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(684));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 35,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(707));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 36,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(730));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 37,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(753));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 38,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(776));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 39,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(796));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 40,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(819));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 41,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(840));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 42,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(862));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 43,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(887));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 44,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(910));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 45,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(933));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 46,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(957));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 47,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(980));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 48,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(1000));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 49,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(1041));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 50,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(1048));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 51,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(1054));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 52,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(1062));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 53,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(1069));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 54,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(1075));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 55,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(1082));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 56,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(1089));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 57,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(1095));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 58,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(1102));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 59,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(1109));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 60,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(1117));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 61,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(1124));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 62,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(1131));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 63,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(1138));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 64,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(1144));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 65,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(1151));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 66,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(1160));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 67,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(1166));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 68,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(1172));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 69,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(1179));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 70,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(1185));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 71,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(1192));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 72,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(1199));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 73,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(1206));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 74,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(1212));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 75,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(1219));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 76,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(1225));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 77,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(1232));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 78,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(1239));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 79,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(1246));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 80,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(1253));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 81,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(1260));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 82,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(1267));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 83,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(1274));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 84,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(1281));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 85,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(1288));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 86,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(1294));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 87,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(1300));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 88,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(1311));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 89,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(1390));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 90,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(1403));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 91,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(1414));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 92,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(1425));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 93,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(1435));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 94,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(1444));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 95,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(1455));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 96,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(1465));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 97,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(1474));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 98,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(1484));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 99,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(1494));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 100,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(1504));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 101,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(1513));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 102,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(1523));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 103,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(1532));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 104,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(1541));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 105,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(1550));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 106,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(1560));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 107,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(1570));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 108,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(1580));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 109,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(1590));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 110,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(1600));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 111,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(1608));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 112,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(1619));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 113,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(1629));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 114,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(1639));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 115,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(1649));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 116,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(1658));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 117,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(1669));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 118,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(1679));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 119,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(1689));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 120,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(1698));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 121,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(1708));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 122,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(1719));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 123,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(1729));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 124,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(1739));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 125,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(1749));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 126,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(1760));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 127,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(1769));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 128,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(1779));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 129,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(1790));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 130,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(1843));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 131,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(1853));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 132,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(1864));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 133,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(1873));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 134,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(1883));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 135,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(1894));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 136,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(1903));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 137,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(1912));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 138,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(1921));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 139,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(1931));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 140,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(1941));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 141,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(1951));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 142,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(1962));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 143,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(1973));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 144,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(1982));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 145,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(1991));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 146,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(2002));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 147,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(2011));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 148,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(2021));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 149,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(2031));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 150,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(2041));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 151,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(2050));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 152,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(2059));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 153,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(2068));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 154,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(2077));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 155,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(2085));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 156,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(2094));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 157,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(2103));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 158,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(2113));

            migrationBuilder.UpdateData(
                table: "PinCodeTypes",
                keyColumn: "PinCodeTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 691, DateTimeKind.Local).AddTicks(3653));

            migrationBuilder.UpdateData(
                table: "PinCodeTypes",
                keyColumn: "PinCodeTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 691, DateTimeKind.Local).AddTicks(3920));

            migrationBuilder.UpdateData(
                table: "PinCodeTypes",
                keyColumn: "PinCodeTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 691, DateTimeKind.Local).AddTicks(3931));

            migrationBuilder.UpdateData(
                table: "PriorityRanks",
                keyColumn: "PriorityRankID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 658, DateTimeKind.Local).AddTicks(6839));

            migrationBuilder.UpdateData(
                table: "PriorityRanks",
                keyColumn: "PriorityRankID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 658, DateTimeKind.Local).AddTicks(7040));

            migrationBuilder.UpdateData(
                table: "PriorityRanks",
                keyColumn: "PriorityRankID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 658, DateTimeKind.Local).AddTicks(7050));

            migrationBuilder.UpdateData(
                table: "PriorityRanks",
                keyColumn: "PriorityRankID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 658, DateTimeKind.Local).AddTicks(7055));

            migrationBuilder.UpdateData(
                table: "RecordStatus",
                keyColumn: "RecordStatusID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 679, DateTimeKind.Local).AddTicks(2096));

            migrationBuilder.UpdateData(
                table: "RecordStatus",
                keyColumn: "RecordStatusID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 679, DateTimeKind.Local).AddTicks(2289));

            migrationBuilder.UpdateData(
                table: "RecordStatus",
                keyColumn: "RecordStatusID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 679, DateTimeKind.Local).AddTicks(2299));

            migrationBuilder.UpdateData(
                table: "RelationshipTypes",
                keyColumn: "RelationshipTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 653, DateTimeKind.Local).AddTicks(8480));

            migrationBuilder.UpdateData(
                table: "RelationshipTypes",
                keyColumn: "RelationshipTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 653, DateTimeKind.Local).AddTicks(8576));

            migrationBuilder.UpdateData(
                table: "RelationshipTypes",
                keyColumn: "RelationshipTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 653, DateTimeKind.Local).AddTicks(8581));

            migrationBuilder.UpdateData(
                table: "RelationshipTypes",
                keyColumn: "RelationshipTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 653, DateTimeKind.Local).AddTicks(8585));

            migrationBuilder.UpdateData(
                table: "RelationshipTypes",
                keyColumn: "RelationshipTypeID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 653, DateTimeKind.Local).AddTicks(8588));

            migrationBuilder.UpdateData(
                table: "RelationshipTypes",
                keyColumn: "RelationshipTypeID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 653, DateTimeKind.Local).AddTicks(8594));

            migrationBuilder.UpdateData(
                table: "RelationshipTypes",
                keyColumn: "RelationshipTypeID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 653, DateTimeKind.Local).AddTicks(8598));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 672, DateTimeKind.Local).AddTicks(1112));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 672, DateTimeKind.Local).AddTicks(1173));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 672, DateTimeKind.Local).AddTicks(1178));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 672, DateTimeKind.Local).AddTicks(1181));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 672, DateTimeKind.Local).AddTicks(1184));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 672, DateTimeKind.Local).AddTicks(1188));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 672, DateTimeKind.Local).AddTicks(1191));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 672, DateTimeKind.Local).AddTicks(1194));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 672, DateTimeKind.Local).AddTicks(1197));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 672, DateTimeKind.Local).AddTicks(1200));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 672, DateTimeKind.Local).AddTicks(1203));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 672, DateTimeKind.Local).AddTicks(1206));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(8711));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(8860));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(8869));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(8876));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(8883));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(8893));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(8900));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(8907));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(8913));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(8921));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(8929));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(8936));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 13,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(8943));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 14,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(8950));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 15,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(8957));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 16,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(8963));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 17,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(8970));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 18,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(8979));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 19,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(8986));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 20,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(8993));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 21,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(8999));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 22,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(9004));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 23,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(9011));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 24,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(9018));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 25,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(9025));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 26,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(9032));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 27,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(9040));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 28,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(9046));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 29,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(9053));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 30,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(9059));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 31,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(9066));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 32,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(9073));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 33,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(9080));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 34,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(9089));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 35,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(9097));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 36,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(9104));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 37,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(9111));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 38,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(9118));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 39,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(9125));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 40,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(9131));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 41,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(9138));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 42,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(9145));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 43,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(9152));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 44,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(9159));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 45,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(9165));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 46,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(9170));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 47,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(9177));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 48,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(9183));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 49,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(9188));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 50,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(9193));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 51,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(9199));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 52,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(9206));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 53,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(9212));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 54,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(9219));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 55,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(9226));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 56,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(9232));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 57,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(9239));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 58,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(9246));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 59,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(9253));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 60,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(9260));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 61,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(9270));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 62,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(9276));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 63,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(9284));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 64,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(9290));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 65,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(9297));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 66,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(9382));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 67,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(9390));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 68,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(9397));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 69,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(9404));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 70,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(9411));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 71,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(9418));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 72,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(9425));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 73,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(9432));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 74,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(9439));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 75,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(9447));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 76,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(9454));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 77,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(9461));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 78,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(9467));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 79,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(9475));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 80,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(9481));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 81,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(9488));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 82,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(9495));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 83,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(9502));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 84,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(9509));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 85,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(9516));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 86,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(9523));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 87,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(9530));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 88,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(9537));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 89,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(9545));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 90,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(9551));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 91,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(9559));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 92,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(9566));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 93,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(9573));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 94,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(9580));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 95,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(9587));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 96,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(9595));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 97,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(9601));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 98,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(9607));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 99,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(9613));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 100,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(9619));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 101,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(9625));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 102,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(9632));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 103,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(9637));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 104,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(9644));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 105,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(9650));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 106,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(9656));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 107,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(9661));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 108,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(9667));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 109,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(9673));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 110,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(9679));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 111,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(9684));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 112,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(9689));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 113,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(9693));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 114,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(9698));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 115,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(9703));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 116,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(9708));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 117,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(9720));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 118,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(9726));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 119,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(9732));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 120,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(9737));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 121,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(9744));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 122,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(9749));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 123,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(9755));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 124,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(9759));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 125,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(9764));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 126,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(9770));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 127,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(9775));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 128,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(9781));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 129,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(9788));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 130,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(9797));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 131,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(9804));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 132,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(9810));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 133,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(9816));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 134,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(9822));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 135,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(9827));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 136,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(9833));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 137,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(9840));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 138,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(9845));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 139,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(9851));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 140,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(9857));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 141,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(9863));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 142,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(9869));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 143,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(9876));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 144,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(9883));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 145,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(9889));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 146,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(9896));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 147,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(9903));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 148,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(9909));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 149,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(9915));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 150,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(9922));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 151,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(9929));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 152,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(9935));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 153,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(9942));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 154,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(9948));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 155,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(9955));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 156,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(9961));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 157,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 641, DateTimeKind.Local).AddTicks(9968));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 158,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 642, DateTimeKind.Local).AddTicks(15));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 634, DateTimeKind.Local).AddTicks(5812));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 637, DateTimeKind.Local).AddTicks(9400));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 637, DateTimeKind.Local).AddTicks(9465));

            migrationBuilder.UpdateData(
                table: "StatementLists",
                keyColumn: "StatementID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 675, DateTimeKind.Local).AddTicks(1096));

            migrationBuilder.UpdateData(
                table: "StatementLists",
                keyColumn: "StatementID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 675, DateTimeKind.Local).AddTicks(1279));

            migrationBuilder.UpdateData(
                table: "StatementLists",
                keyColumn: "StatementID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 675, DateTimeKind.Local).AddTicks(1288));

            migrationBuilder.UpdateData(
                table: "StatementLists",
                keyColumn: "StatementID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 675, DateTimeKind.Local).AddTicks(1293));

            migrationBuilder.UpdateData(
                table: "TechnicalSupport",
                keyColumn: "TechnicalSupportID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 688, DateTimeKind.Local).AddTicks(4441));

            migrationBuilder.UpdateData(
                table: "TechnicalSupport",
                keyColumn: "TechnicalSupportID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 688, DateTimeKind.Local).AddTicks(4659));

            migrationBuilder.UpdateData(
                table: "TechnicalSupport",
                keyColumn: "TechnicalSupportID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 688, DateTimeKind.Local).AddTicks(4670));

            migrationBuilder.UpdateData(
                table: "TechnicalSupport",
                keyColumn: "TechnicalSupportID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 688, DateTimeKind.Local).AddTicks(4675));

            migrationBuilder.UpdateData(
                table: "TechnicalSupport",
                keyColumn: "TechnicalSupportID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 688, DateTimeKind.Local).AddTicks(4681));

            migrationBuilder.UpdateData(
                table: "TechnicalSupport",
                keyColumn: "TechnicalSupportID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 688, DateTimeKind.Local).AddTicks(4690));

            migrationBuilder.UpdateData(
                table: "TechnicalSupport",
                keyColumn: "TechnicalSupportID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 688, DateTimeKind.Local).AddTicks(4696));

            migrationBuilder.UpdateData(
                table: "Titles",
                keyColumn: "TitleID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 676, DateTimeKind.Local).AddTicks(4603));

            migrationBuilder.UpdateData(
                table: "Titles",
                keyColumn: "TitleID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 676, DateTimeKind.Local).AddTicks(4868));

            migrationBuilder.UpdateData(
                table: "Titles",
                keyColumn: "TitleID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 676, DateTimeKind.Local).AddTicks(4878));

            migrationBuilder.UpdateData(
                table: "Titles",
                keyColumn: "TitleID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 676, DateTimeKind.Local).AddTicks(4883));

            migrationBuilder.UpdateData(
                table: "Titles",
                keyColumn: "TitleID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 676, DateTimeKind.Local).AddTicks(4887));

            migrationBuilder.UpdateData(
                table: "Titles",
                keyColumn: "TitleID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 676, DateTimeKind.Local).AddTicks(4894));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 646, DateTimeKind.Local).AddTicks(5858));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 646, DateTimeKind.Local).AddTicks(6411));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 646, DateTimeKind.Local).AddTicks(6492));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 646, DateTimeKind.Local).AddTicks(6564));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 646, DateTimeKind.Local).AddTicks(6627));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 646, DateTimeKind.Local).AddTicks(6693));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 646, DateTimeKind.Local).AddTicks(6751));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 646, DateTimeKind.Local).AddTicks(6806));

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumns: new[] { "UserID", "RoleID" },
                keyValues: new object[] { 1, 1 },
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 664, DateTimeKind.Local).AddTicks(6485));

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumns: new[] { "UserID", "RoleID" },
                keyValues: new object[] { 2, 3 },
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 664, DateTimeKind.Local).AddTicks(6542));

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "UserTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 652, DateTimeKind.Local).AddTicks(9600));

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "UserTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 652, DateTimeKind.Local).AddTicks(9804));

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "UserTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 652, DateTimeKind.Local).AddTicks(9814));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 659, DateTimeKind.Local).AddTicks(1283));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 660, DateTimeKind.Local).AddTicks(1090));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 660, DateTimeKind.Local).AddTicks(1334));

            migrationBuilder.UpdateData(
                table: "VariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 655, DateTimeKind.Local).AddTicks(1797));

            migrationBuilder.UpdateData(
                table: "VariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 655, DateTimeKind.Local).AddTicks(2007));

            migrationBuilder.UpdateData(
                table: "VariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 655, DateTimeKind.Local).AddTicks(2018));

            migrationBuilder.UpdateData(
                table: "VariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 655, DateTimeKind.Local).AddTicks(2022));

            migrationBuilder.UpdateData(
                table: "VariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 655, DateTimeKind.Local).AddTicks(2027));

            migrationBuilder.UpdateData(
                table: "VariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 655, DateTimeKind.Local).AddTicks(2035));

            migrationBuilder.UpdateData(
                table: "VariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 655, DateTimeKind.Local).AddTicks(2042));

            migrationBuilder.UpdateData(
                table: "VariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 655, DateTimeKind.Local).AddTicks(2047));

            migrationBuilder.UpdateData(
                table: "VariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2022, 2, 13, 21, 23, 4, 655, DateTimeKind.Local).AddTicks(2052));
        }
    }
}
