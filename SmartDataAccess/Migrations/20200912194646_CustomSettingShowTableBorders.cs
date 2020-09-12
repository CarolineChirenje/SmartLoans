using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SmartDataAccess.Migrations
{
    public partial class CustomSettingShowTableBorders : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "BankAccountTypes",
                keyColumn: "BankAccountTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 195, DateTimeKind.Local).AddTicks(2345));

            migrationBuilder.UpdateData(
                table: "BankAccountTypes",
                keyColumn: "BankAccountTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 195, DateTimeKind.Local).AddTicks(2915));

            migrationBuilder.UpdateData(
                table: "BankAccountTypes",
                keyColumn: "BankAccountTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 195, DateTimeKind.Local).AddTicks(2922));

            migrationBuilder.UpdateData(
                table: "BankAccountTypes",
                keyColumn: "BankAccountTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 195, DateTimeKind.Local).AddTicks(2925));

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "CompanyID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 526, DateTimeKind.Local).AddTicks(8248));

            migrationBuilder.UpdateData(
                table: "ContactTypes",
                keyColumn: "ContactTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 203, DateTimeKind.Local).AddTicks(8036));

            migrationBuilder.UpdateData(
                table: "ContactTypes",
                keyColumn: "ContactTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 203, DateTimeKind.Local).AddTicks(8031));

            migrationBuilder.UpdateData(
                table: "ContactTypes",
                keyColumn: "ContactTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 203, DateTimeKind.Local).AddTicks(8025));

            migrationBuilder.UpdateData(
                table: "ContactTypes",
                keyColumn: "ContactTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 203, DateTimeKind.Local).AddTicks(7941));

            migrationBuilder.UpdateData(
                table: "ContactTypes",
                keyColumn: "ContactTypeID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 203, DateTimeKind.Local).AddTicks(8040));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 533, DateTimeKind.Local).AddTicks(3868));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 533, DateTimeKind.Local).AddTicks(4321));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 533, DateTimeKind.Local).AddTicks(4328));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 533, DateTimeKind.Local).AddTicks(4337));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 533, DateTimeKind.Local).AddTicks(4341));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 533, DateTimeKind.Local).AddTicks(4350));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 533, DateTimeKind.Local).AddTicks(4353));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 533, DateTimeKind.Local).AddTicks(4357));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 533, DateTimeKind.Local).AddTicks(4360));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 533, DateTimeKind.Local).AddTicks(4365));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 533, DateTimeKind.Local).AddTicks(4369));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 533, DateTimeKind.Local).AddTicks(4372));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 13,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 533, DateTimeKind.Local).AddTicks(4375));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 14,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 533, DateTimeKind.Local).AddTicks(4378));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 15,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 533, DateTimeKind.Local).AddTicks(4382));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 16,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 533, DateTimeKind.Local).AddTicks(4386));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 17,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 533, DateTimeKind.Local).AddTicks(4389));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 18,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 533, DateTimeKind.Local).AddTicks(4394));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 19,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 533, DateTimeKind.Local).AddTicks(4398));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 20,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 533, DateTimeKind.Local).AddTicks(4401));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 21,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 533, DateTimeKind.Local).AddTicks(4404));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 22,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 533, DateTimeKind.Local).AddTicks(4407));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 23,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 533, DateTimeKind.Local).AddTicks(4411));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 24,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 533, DateTimeKind.Local).AddTicks(4414));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 25,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 533, DateTimeKind.Local).AddTicks(4417));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 26,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 533, DateTimeKind.Local).AddTicks(4420));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 27,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 533, DateTimeKind.Local).AddTicks(4425));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 28,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 533, DateTimeKind.Local).AddTicks(4428));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 29,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 533, DateTimeKind.Local).AddTicks(4431));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 30,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 533, DateTimeKind.Local).AddTicks(4436));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 31,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 533, DateTimeKind.Local).AddTicks(4439));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 32,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 533, DateTimeKind.Local).AddTicks(4443));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 33,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 533, DateTimeKind.Local).AddTicks(4447));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 34,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 533, DateTimeKind.Local).AddTicks(4452));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 35,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 533, DateTimeKind.Local).AddTicks(4455));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 36,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 533, DateTimeKind.Local).AddTicks(4459));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 37,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 533, DateTimeKind.Local).AddTicks(4462));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 38,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 533, DateTimeKind.Local).AddTicks(4465));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 39,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 533, DateTimeKind.Local).AddTicks(4469));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 40,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 533, DateTimeKind.Local).AddTicks(4473));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 41,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 533, DateTimeKind.Local).AddTicks(4477));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 42,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 533, DateTimeKind.Local).AddTicks(4480));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 43,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 533, DateTimeKind.Local).AddTicks(4484));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 44,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 533, DateTimeKind.Local).AddTicks(4487));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 45,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 533, DateTimeKind.Local).AddTicks(4490));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 46,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 533, DateTimeKind.Local).AddTicks(4493));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 47,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 533, DateTimeKind.Local).AddTicks(4498));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 48,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 533, DateTimeKind.Local).AddTicks(4502));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 49,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 533, DateTimeKind.Local).AddTicks(4506));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 50,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 533, DateTimeKind.Local).AddTicks(4510));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 51,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 533, DateTimeKind.Local).AddTicks(4513));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 52,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 533, DateTimeKind.Local).AddTicks(4517));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 53,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 533, DateTimeKind.Local).AddTicks(4561));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 54,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 533, DateTimeKind.Local).AddTicks(4565));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 55,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 533, DateTimeKind.Local).AddTicks(4569));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 56,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 533, DateTimeKind.Local).AddTicks(4572));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 57,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 533, DateTimeKind.Local).AddTicks(4575));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 58,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 533, DateTimeKind.Local).AddTicks(4579));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 59,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 533, DateTimeKind.Local).AddTicks(4583));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 60,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 533, DateTimeKind.Local).AddTicks(4587));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 61,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 533, DateTimeKind.Local).AddTicks(4590));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 62,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 533, DateTimeKind.Local).AddTicks(4593));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 63,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 533, DateTimeKind.Local).AddTicks(4597));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 64,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 533, DateTimeKind.Local).AddTicks(4601));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 65,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 533, DateTimeKind.Local).AddTicks(4604));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 66,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 533, DateTimeKind.Local).AddTicks(4610));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 67,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 533, DateTimeKind.Local).AddTicks(4613));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 68,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 533, DateTimeKind.Local).AddTicks(4617));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 69,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 533, DateTimeKind.Local).AddTicks(4620));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 70,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 533, DateTimeKind.Local).AddTicks(4623));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 71,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 533, DateTimeKind.Local).AddTicks(4626));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 72,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 533, DateTimeKind.Local).AddTicks(4630));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 73,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 533, DateTimeKind.Local).AddTicks(4634));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 74,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 533, DateTimeKind.Local).AddTicks(4637));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 75,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 533, DateTimeKind.Local).AddTicks(4641));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 76,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 533, DateTimeKind.Local).AddTicks(4644));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 77,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 533, DateTimeKind.Local).AddTicks(4647));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 78,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 533, DateTimeKind.Local).AddTicks(4650));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 79,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 533, DateTimeKind.Local).AddTicks(4653));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 80,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 533, DateTimeKind.Local).AddTicks(4657));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 81,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 533, DateTimeKind.Local).AddTicks(4660));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 82,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 533, DateTimeKind.Local).AddTicks(4663));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 83,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 533, DateTimeKind.Local).AddTicks(4666));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 84,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 533, DateTimeKind.Local).AddTicks(4670));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 85,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 533, DateTimeKind.Local).AddTicks(4673));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 86,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 533, DateTimeKind.Local).AddTicks(4676));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 87,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 533, DateTimeKind.Local).AddTicks(4680));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 88,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 533, DateTimeKind.Local).AddTicks(4683));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 89,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 533, DateTimeKind.Local).AddTicks(4687));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 90,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 533, DateTimeKind.Local).AddTicks(4690));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 91,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 533, DateTimeKind.Local).AddTicks(4693));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 92,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 533, DateTimeKind.Local).AddTicks(4696));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 93,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 533, DateTimeKind.Local).AddTicks(4700));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 94,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 533, DateTimeKind.Local).AddTicks(4703));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 95,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 533, DateTimeKind.Local).AddTicks(4706));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 96,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 533, DateTimeKind.Local).AddTicks(4710));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 97,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 533, DateTimeKind.Local).AddTicks(4713));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 98,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 533, DateTimeKind.Local).AddTicks(4716));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 99,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 533, DateTimeKind.Local).AddTicks(4719));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 100,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 533, DateTimeKind.Local).AddTicks(4722));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 101,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 533, DateTimeKind.Local).AddTicks(4726));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 102,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 533, DateTimeKind.Local).AddTicks(4729));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 103,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 533, DateTimeKind.Local).AddTicks(4733));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 104,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 533, DateTimeKind.Local).AddTicks(4736));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 105,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 533, DateTimeKind.Local).AddTicks(4739));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 106,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 533, DateTimeKind.Local).AddTicks(4742));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 107,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 533, DateTimeKind.Local).AddTicks(4745));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 108,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 533, DateTimeKind.Local).AddTicks(4749));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 109,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 533, DateTimeKind.Local).AddTicks(4752));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 110,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 533, DateTimeKind.Local).AddTicks(4755));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 111,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 533, DateTimeKind.Local).AddTicks(4758));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 112,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 533, DateTimeKind.Local).AddTicks(4762));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 113,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 533, DateTimeKind.Local).AddTicks(4765));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 114,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 533, DateTimeKind.Local).AddTicks(4818));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 115,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 533, DateTimeKind.Local).AddTicks(4821));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 116,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 533, DateTimeKind.Local).AddTicks(4825));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 117,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 533, DateTimeKind.Local).AddTicks(4828));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 118,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 533, DateTimeKind.Local).AddTicks(4831));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 119,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 533, DateTimeKind.Local).AddTicks(4834));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 120,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 533, DateTimeKind.Local).AddTicks(4837));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 121,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 533, DateTimeKind.Local).AddTicks(4841));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 122,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 533, DateTimeKind.Local).AddTicks(4844));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 123,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 533, DateTimeKind.Local).AddTicks(4847));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 124,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 533, DateTimeKind.Local).AddTicks(4850));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 125,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 533, DateTimeKind.Local).AddTicks(4854));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 126,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 533, DateTimeKind.Local).AddTicks(4857));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 127,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 533, DateTimeKind.Local).AddTicks(4860));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 128,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 533, DateTimeKind.Local).AddTicks(4863));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 129,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 533, DateTimeKind.Local).AddTicks(4866));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 130,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 533, DateTimeKind.Local).AddTicks(4872));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 131,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 533, DateTimeKind.Local).AddTicks(4875));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 132,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 533, DateTimeKind.Local).AddTicks(4879));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 133,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 533, DateTimeKind.Local).AddTicks(4882));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 134,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 533, DateTimeKind.Local).AddTicks(4885));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 135,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 533, DateTimeKind.Local).AddTicks(4888));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 136,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 533, DateTimeKind.Local).AddTicks(4891));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 137,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 533, DateTimeKind.Local).AddTicks(4895));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 138,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 533, DateTimeKind.Local).AddTicks(4899));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 139,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 533, DateTimeKind.Local).AddTicks(4902));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 140,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 533, DateTimeKind.Local).AddTicks(4905));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 141,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 533, DateTimeKind.Local).AddTicks(4908));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 142,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 533, DateTimeKind.Local).AddTicks(4911));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 143,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 533, DateTimeKind.Local).AddTicks(4915));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 144,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 533, DateTimeKind.Local).AddTicks(4918));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 145,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 533, DateTimeKind.Local).AddTicks(4921));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 146,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 533, DateTimeKind.Local).AddTicks(4925));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 147,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 533, DateTimeKind.Local).AddTicks(4928));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 148,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 533, DateTimeKind.Local).AddTicks(4931));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 149,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 533, DateTimeKind.Local).AddTicks(4935));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 150,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 533, DateTimeKind.Local).AddTicks(4939));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 151,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 533, DateTimeKind.Local).AddTicks(4943));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 152,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 533, DateTimeKind.Local).AddTicks(4946));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 153,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 533, DateTimeKind.Local).AddTicks(4949));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 154,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 533, DateTimeKind.Local).AddTicks(4953));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 155,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 533, DateTimeKind.Local).AddTicks(4957));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 156,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 533, DateTimeKind.Local).AddTicks(4960));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 157,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 533, DateTimeKind.Local).AddTicks(4963));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 158,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 533, DateTimeKind.Local).AddTicks(4967));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 159,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 533, DateTimeKind.Local).AddTicks(4970));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 160,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 533, DateTimeKind.Local).AddTicks(4973));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 161,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 533, DateTimeKind.Local).AddTicks(4977));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 162,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 533, DateTimeKind.Local).AddTicks(4980));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 163,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 533, DateTimeKind.Local).AddTicks(4983));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 164,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 533, DateTimeKind.Local).AddTicks(4987));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 165,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 533, DateTimeKind.Local).AddTicks(4990));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 166,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 533, DateTimeKind.Local).AddTicks(4993));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 167,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 533, DateTimeKind.Local).AddTicks(4996));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 168,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 533, DateTimeKind.Local).AddTicks(5031));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 169,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 533, DateTimeKind.Local).AddTicks(5035));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 170,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 533, DateTimeKind.Local).AddTicks(5038));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 171,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 533, DateTimeKind.Local).AddTicks(5041));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 172,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 533, DateTimeKind.Local).AddTicks(5044));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 173,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 533, DateTimeKind.Local).AddTicks(5048));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 174,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 533, DateTimeKind.Local).AddTicks(5052));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 175,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 533, DateTimeKind.Local).AddTicks(5056));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 176,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 533, DateTimeKind.Local).AddTicks(5060));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 177,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 533, DateTimeKind.Local).AddTicks(5066));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 178,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 533, DateTimeKind.Local).AddTicks(5069));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 179,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 533, DateTimeKind.Local).AddTicks(5073));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 180,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 533, DateTimeKind.Local).AddTicks(5077));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 181,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 533, DateTimeKind.Local).AddTicks(5080));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 182,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 533, DateTimeKind.Local).AddTicks(5084));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 183,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 533, DateTimeKind.Local).AddTicks(5087));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 184,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 533, DateTimeKind.Local).AddTicks(5090));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 185,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 533, DateTimeKind.Local).AddTicks(5094));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 186,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 533, DateTimeKind.Local).AddTicks(5097));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 187,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 533, DateTimeKind.Local).AddTicks(5101));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 188,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 533, DateTimeKind.Local).AddTicks(5104));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 189,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 533, DateTimeKind.Local).AddTicks(5107));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 190,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 533, DateTimeKind.Local).AddTicks(5111));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 191,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 533, DateTimeKind.Local).AddTicks(5114));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 192,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 533, DateTimeKind.Local).AddTicks(5117));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 193,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 533, DateTimeKind.Local).AddTicks(5121));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 194,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 533, DateTimeKind.Local).AddTicks(5124));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 195,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 533, DateTimeKind.Local).AddTicks(5127));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 196,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 533, DateTimeKind.Local).AddTicks(5130));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 197,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 533, DateTimeKind.Local).AddTicks(5134));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 198,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 533, DateTimeKind.Local).AddTicks(5137));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 199,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 533, DateTimeKind.Local).AddTicks(5140));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 200,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 533, DateTimeKind.Local).AddTicks(5143));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 201,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 533, DateTimeKind.Local).AddTicks(5146));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 202,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 533, DateTimeKind.Local).AddTicks(5150));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 203,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 533, DateTimeKind.Local).AddTicks(5153));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 204,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 533, DateTimeKind.Local).AddTicks(5156));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 205,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 533, DateTimeKind.Local).AddTicks(5159));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 206,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 533, DateTimeKind.Local).AddTicks(5163));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 207,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 533, DateTimeKind.Local).AddTicks(5166));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 208,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 533, DateTimeKind.Local).AddTicks(5169));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 209,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 533, DateTimeKind.Local).AddTicks(5173));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 210,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 533, DateTimeKind.Local).AddTicks(5177));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 211,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 533, DateTimeKind.Local).AddTicks(5180));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 212,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 533, DateTimeKind.Local).AddTicks(5183));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 213,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 533, DateTimeKind.Local).AddTicks(5186));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 214,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 533, DateTimeKind.Local).AddTicks(5190));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 215,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 533, DateTimeKind.Local).AddTicks(5194));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 216,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 533, DateTimeKind.Local).AddTicks(5197));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 217,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 533, DateTimeKind.Local).AddTicks(5201));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 218,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 533, DateTimeKind.Local).AddTicks(5204));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 219,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 533, DateTimeKind.Local).AddTicks(5207));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 220,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 533, DateTimeKind.Local).AddTicks(5210));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 221,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 533, DateTimeKind.Local).AddTicks(5213));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 222,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 533, DateTimeKind.Local).AddTicks(5217));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 223,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 533, DateTimeKind.Local).AddTicks(5221));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 224,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 533, DateTimeKind.Local).AddTicks(5225));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 225,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 533, DateTimeKind.Local).AddTicks(5229));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 226,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 533, DateTimeKind.Local).AddTicks(5232));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 227,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 533, DateTimeKind.Local).AddTicks(5235));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 228,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 533, DateTimeKind.Local).AddTicks(5239));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 197, DateTimeKind.Local).AddTicks(8670));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 197, DateTimeKind.Local).AddTicks(9392));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 197, DateTimeKind.Local).AddTicks(9400));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 197, DateTimeKind.Local).AddTicks(9404));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 197, DateTimeKind.Local).AddTicks(9407));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 197, DateTimeKind.Local).AddTicks(9417));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 197, DateTimeKind.Local).AddTicks(9420));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 197, DateTimeKind.Local).AddTicks(9423));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 197, DateTimeKind.Local).AddTicks(9430));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 197, DateTimeKind.Local).AddTicks(9486));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 197, DateTimeKind.Local).AddTicks(9491));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 197, DateTimeKind.Local).AddTicks(9494));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 13,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 197, DateTimeKind.Local).AddTicks(9497));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 14,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 197, DateTimeKind.Local).AddTicks(9500));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 15,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 197, DateTimeKind.Local).AddTicks(9504));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 16,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 197, DateTimeKind.Local).AddTicks(9508));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 17,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 197, DateTimeKind.Local).AddTicks(9511));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 18,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 197, DateTimeKind.Local).AddTicks(9518));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 19,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 197, DateTimeKind.Local).AddTicks(9521));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 20,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 197, DateTimeKind.Local).AddTicks(9525));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 21,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 197, DateTimeKind.Local).AddTicks(9529));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 22,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 197, DateTimeKind.Local).AddTicks(9533));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 23,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 197, DateTimeKind.Local).AddTicks(9537));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 24,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 197, DateTimeKind.Local).AddTicks(9540));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 25,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 197, DateTimeKind.Local).AddTicks(9543));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 26,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 197, DateTimeKind.Local).AddTicks(9546));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 27,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 197, DateTimeKind.Local).AddTicks(9549));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 28,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 197, DateTimeKind.Local).AddTicks(9552));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 29,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 197, DateTimeKind.Local).AddTicks(9555));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 30,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 197, DateTimeKind.Local).AddTicks(9558));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 31,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 197, DateTimeKind.Local).AddTicks(9561));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 32,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 197, DateTimeKind.Local).AddTicks(9564));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 33,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 197, DateTimeKind.Local).AddTicks(9567));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 34,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 197, DateTimeKind.Local).AddTicks(9572));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 35,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 197, DateTimeKind.Local).AddTicks(9575));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 36,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 197, DateTimeKind.Local).AddTicks(9578));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 37,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 197, DateTimeKind.Local).AddTicks(9581));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 38,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 197, DateTimeKind.Local).AddTicks(9584));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 39,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 197, DateTimeKind.Local).AddTicks(9588));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 40,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 197, DateTimeKind.Local).AddTicks(9591));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 41,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 197, DateTimeKind.Local).AddTicks(9595));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 42,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 197, DateTimeKind.Local).AddTicks(9598));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 43,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 197, DateTimeKind.Local).AddTicks(9601));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 44,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 197, DateTimeKind.Local).AddTicks(9604));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 45,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 197, DateTimeKind.Local).AddTicks(9607));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 46,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 197, DateTimeKind.Local).AddTicks(9610));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 47,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 197, DateTimeKind.Local).AddTicks(9613));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 48,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 197, DateTimeKind.Local).AddTicks(9616));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 49,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 197, DateTimeKind.Local).AddTicks(9619));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 50,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 197, DateTimeKind.Local).AddTicks(9622));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 51,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 197, DateTimeKind.Local).AddTicks(9625));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 52,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 197, DateTimeKind.Local).AddTicks(9628));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 53,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 197, DateTimeKind.Local).AddTicks(9631));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 54,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 197, DateTimeKind.Local).AddTicks(9634));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 55,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 197, DateTimeKind.Local).AddTicks(9637));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 56,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 197, DateTimeKind.Local).AddTicks(9640));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 57,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 197, DateTimeKind.Local).AddTicks(9643));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 58,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 197, DateTimeKind.Local).AddTicks(9646));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 59,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 197, DateTimeKind.Local).AddTicks(9649));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 60,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 197, DateTimeKind.Local).AddTicks(9652));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 61,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 197, DateTimeKind.Local).AddTicks(9656));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 62,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 197, DateTimeKind.Local).AddTicks(9659));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 63,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 197, DateTimeKind.Local).AddTicks(9662));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 64,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 197, DateTimeKind.Local).AddTicks(9665));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 65,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 197, DateTimeKind.Local).AddTicks(9668));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 66,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 197, DateTimeKind.Local).AddTicks(9673));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 67,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 197, DateTimeKind.Local).AddTicks(9676));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 68,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 197, DateTimeKind.Local).AddTicks(9679));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 69,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 197, DateTimeKind.Local).AddTicks(9681));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 70,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 197, DateTimeKind.Local).AddTicks(9684));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 71,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 197, DateTimeKind.Local).AddTicks(9723));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 72,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 197, DateTimeKind.Local).AddTicks(9727));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 73,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 197, DateTimeKind.Local).AddTicks(9730));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 74,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 197, DateTimeKind.Local).AddTicks(9733));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 75,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 197, DateTimeKind.Local).AddTicks(9736));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 76,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 197, DateTimeKind.Local).AddTicks(9739));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 77,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 197, DateTimeKind.Local).AddTicks(9742));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 78,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 197, DateTimeKind.Local).AddTicks(9745));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 79,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 197, DateTimeKind.Local).AddTicks(9748));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 80,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 197, DateTimeKind.Local).AddTicks(9751));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 81,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 197, DateTimeKind.Local).AddTicks(9753));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 82,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 197, DateTimeKind.Local).AddTicks(9757));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 83,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 197, DateTimeKind.Local).AddTicks(9760));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 84,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 197, DateTimeKind.Local).AddTicks(9764));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 85,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 197, DateTimeKind.Local).AddTicks(9767));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 86,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 197, DateTimeKind.Local).AddTicks(9769));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 87,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 197, DateTimeKind.Local).AddTicks(9773));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 88,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 197, DateTimeKind.Local).AddTicks(9775));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 89,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 197, DateTimeKind.Local).AddTicks(9778));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 90,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 197, DateTimeKind.Local).AddTicks(9781));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 91,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 197, DateTimeKind.Local).AddTicks(9785));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 92,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 197, DateTimeKind.Local).AddTicks(9788));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 93,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 197, DateTimeKind.Local).AddTicks(9791));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 94,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 197, DateTimeKind.Local).AddTicks(9794));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 95,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 197, DateTimeKind.Local).AddTicks(9797));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 96,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 197, DateTimeKind.Local).AddTicks(9800));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 97,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 197, DateTimeKind.Local).AddTicks(9803));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 98,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 197, DateTimeKind.Local).AddTicks(9806));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 99,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 197, DateTimeKind.Local).AddTicks(9809));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 100,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 197, DateTimeKind.Local).AddTicks(9812));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 101,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 197, DateTimeKind.Local).AddTicks(9815));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 102,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 197, DateTimeKind.Local).AddTicks(9818));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 103,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 197, DateTimeKind.Local).AddTicks(9821));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 104,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 197, DateTimeKind.Local).AddTicks(9824));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 105,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 197, DateTimeKind.Local).AddTicks(9827));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 106,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 197, DateTimeKind.Local).AddTicks(9830));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 107,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 197, DateTimeKind.Local).AddTicks(9833));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 108,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 197, DateTimeKind.Local).AddTicks(9836));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 109,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 197, DateTimeKind.Local).AddTicks(9839));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 110,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 197, DateTimeKind.Local).AddTicks(9842));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 111,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 197, DateTimeKind.Local).AddTicks(9845));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 112,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 197, DateTimeKind.Local).AddTicks(9848));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 113,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 197, DateTimeKind.Local).AddTicks(9851));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 114,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 197, DateTimeKind.Local).AddTicks(9854));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 115,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 197, DateTimeKind.Local).AddTicks(9857));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 116,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 197, DateTimeKind.Local).AddTicks(9860));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 117,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 197, DateTimeKind.Local).AddTicks(9863));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 118,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 197, DateTimeKind.Local).AddTicks(9866));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 119,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 197, DateTimeKind.Local).AddTicks(9869));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 120,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 197, DateTimeKind.Local).AddTicks(9872));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 121,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 197, DateTimeKind.Local).AddTicks(9875));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 122,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 197, DateTimeKind.Local).AddTicks(9878));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 123,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 197, DateTimeKind.Local).AddTicks(9882));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 124,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 197, DateTimeKind.Local).AddTicks(9885));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 125,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 197, DateTimeKind.Local).AddTicks(9888));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 126,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 197, DateTimeKind.Local).AddTicks(9891));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 127,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 197, DateTimeKind.Local).AddTicks(9894));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 128,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 197, DateTimeKind.Local).AddTicks(9897));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 129,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 197, DateTimeKind.Local).AddTicks(9900));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 130,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 197, DateTimeKind.Local).AddTicks(9953));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 131,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 197, DateTimeKind.Local).AddTicks(9957));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 132,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 197, DateTimeKind.Local).AddTicks(9960));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 133,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 197, DateTimeKind.Local).AddTicks(9963));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 134,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 197, DateTimeKind.Local).AddTicks(9966));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 135,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 197, DateTimeKind.Local).AddTicks(9969));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 136,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 197, DateTimeKind.Local).AddTicks(9972));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 137,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 197, DateTimeKind.Local).AddTicks(9975));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 138,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 197, DateTimeKind.Local).AddTicks(9978));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 139,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 197, DateTimeKind.Local).AddTicks(9981));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 140,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 197, DateTimeKind.Local).AddTicks(9984));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 141,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 197, DateTimeKind.Local).AddTicks(9987));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 142,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 197, DateTimeKind.Local).AddTicks(9990));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 143,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 197, DateTimeKind.Local).AddTicks(9993));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 144,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 197, DateTimeKind.Local).AddTicks(9996));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 145,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 197, DateTimeKind.Local).AddTicks(9999));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 146,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 198, DateTimeKind.Local).AddTicks(2));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 147,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 198, DateTimeKind.Local).AddTicks(5));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 148,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 198, DateTimeKind.Local).AddTicks(8));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 149,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 198, DateTimeKind.Local).AddTicks(11));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 150,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 198, DateTimeKind.Local).AddTicks(14));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 151,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 198, DateTimeKind.Local).AddTicks(17));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 152,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 198, DateTimeKind.Local).AddTicks(20));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 153,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 198, DateTimeKind.Local).AddTicks(23));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 154,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 198, DateTimeKind.Local).AddTicks(26));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 155,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 198, DateTimeKind.Local).AddTicks(29));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 156,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 198, DateTimeKind.Local).AddTicks(32));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 157,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 198, DateTimeKind.Local).AddTicks(35));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 158,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 198, DateTimeKind.Local).AddTicks(38));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 159,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 198, DateTimeKind.Local).AddTicks(41));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 160,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 198, DateTimeKind.Local).AddTicks(44));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 161,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 198, DateTimeKind.Local).AddTicks(47));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 162,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 198, DateTimeKind.Local).AddTicks(50));

            migrationBuilder.UpdateData(
                table: "CustomSettingTypes",
                keyColumn: "CustomSettingTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 205, DateTimeKind.Local).AddTicks(1917));

            migrationBuilder.UpdateData(
                table: "CustomSettingTypes",
                keyColumn: "CustomSettingTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 205, DateTimeKind.Local).AddTicks(2093));

            migrationBuilder.UpdateData(
                table: "CustomSettingTypes",
                keyColumn: "CustomSettingTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 205, DateTimeKind.Local).AddTicks(2107));

            migrationBuilder.UpdateData(
                table: "CustomSettingTypes",
                keyColumn: "CustomSettingTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 205, DateTimeKind.Local).AddTicks(2117));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 209, DateTimeKind.Local).AddTicks(6801));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 209, DateTimeKind.Local).AddTicks(7024));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 209, DateTimeKind.Local).AddTicks(7032));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 209, DateTimeKind.Local).AddTicks(7040));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 209, DateTimeKind.Local).AddTicks(7048));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 209, DateTimeKind.Local).AddTicks(7068));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 209, DateTimeKind.Local).AddTicks(7082));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 209, DateTimeKind.Local).AddTicks(7090));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 209, DateTimeKind.Local).AddTicks(7098));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 209, DateTimeKind.Local).AddTicks(7105));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 11,
                columns: new[] { "LastChangedDate", "Value" },
                values: new object[] { new DateTime(2020, 9, 12, 21, 46, 44, 209, DateTimeKind.Local).AddTicks(7112), "false" });

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 209, DateTimeKind.Local).AddTicks(7119));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 13,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 209, DateTimeKind.Local).AddTicks(7126));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 14,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 209, DateTimeKind.Local).AddTicks(7135));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 15,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 209, DateTimeKind.Local).AddTicks(7142));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 16,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 209, DateTimeKind.Local).AddTicks(7150));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 17,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 209, DateTimeKind.Local).AddTicks(7076));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 18,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 209, DateTimeKind.Local).AddTicks(7159));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 19,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 209, DateTimeKind.Local).AddTicks(7167));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 20,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 209, DateTimeKind.Local).AddTicks(7173));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 21,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 209, DateTimeKind.Local).AddTicks(7179));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 22,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 209, DateTimeKind.Local).AddTicks(7186));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 23,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 209, DateTimeKind.Local).AddTicks(7193));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 24,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 492, DateTimeKind.Local).AddTicks(5927));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 25,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 525, DateTimeKind.Local).AddTicks(3773));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 26,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 525, DateTimeKind.Local).AddTicks(3846));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 27,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 525, DateTimeKind.Local).AddTicks(3854));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 28,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 525, DateTimeKind.Local).AddTicks(3864));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 29,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 525, DateTimeKind.Local).AddTicks(3859));

            migrationBuilder.InsertData(
                table: "CustomSettings",
                columns: new[] { "CustomSettingID", "CustomSettingTypeID", "CustomVariableTypeID", "Description", "IsActive", "LastChangedBy", "LastChangedDate", "Name", "Value" },
                values: new object[] { 30, 3, 1, "Determines if table borders will be shown on the report", true, "SuperUser", new DateTime(2020, 9, 12, 21, 46, 44, 525, DateTimeKind.Local).AddTicks(4009), "Statement Hide Table Boarders", "true" });

            migrationBuilder.UpdateData(
                table: "DocumentFormats",
                keyColumn: "DocumentFormatID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 537, DateTimeKind.Local).AddTicks(9557));

            migrationBuilder.UpdateData(
                table: "DocumentFormats",
                keyColumn: "DocumentFormatID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 537, DateTimeKind.Local).AddTicks(9932));

            migrationBuilder.UpdateData(
                table: "DocumentFormats",
                keyColumn: "DocumentFormatID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 537, DateTimeKind.Local).AddTicks(9940));

            migrationBuilder.UpdateData(
                table: "DocumentFormats",
                keyColumn: "DocumentFormatID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 537, DateTimeKind.Local).AddTicks(9943));

            migrationBuilder.UpdateData(
                table: "DocumentFormats",
                keyColumn: "DocumentFormatID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 537, DateTimeKind.Local).AddTicks(9947));

            migrationBuilder.UpdateData(
                table: "DocumentFormats",
                keyColumn: "DocumentFormatID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 537, DateTimeKind.Local).AddTicks(9953));

            migrationBuilder.UpdateData(
                table: "DocumentTypes",
                keyColumn: "DocumentTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 540, DateTimeKind.Local).AddTicks(1005));

            migrationBuilder.UpdateData(
                table: "DocumentTypes",
                keyColumn: "DocumentTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 540, DateTimeKind.Local).AddTicks(1892));

            migrationBuilder.UpdateData(
                table: "DocumentTypes",
                keyColumn: "DocumentTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 540, DateTimeKind.Local).AddTicks(1912));

            migrationBuilder.UpdateData(
                table: "FeatureFlags",
                keyColumn: "FeatureFlagID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 535, DateTimeKind.Local).AddTicks(6388));

            migrationBuilder.UpdateData(
                table: "FeatureFlags",
                keyColumn: "FeatureFlagID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 535, DateTimeKind.Local).AddTicks(6817));

            migrationBuilder.UpdateData(
                table: "FeatureFlags",
                keyColumn: "FeatureFlagID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 535, DateTimeKind.Local).AddTicks(6826));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "GenderID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 531, DateTimeKind.Local).AddTicks(781));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "GenderID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 531, DateTimeKind.Local).AddTicks(859));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 542, DateTimeKind.Local).AddTicks(976));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 542, DateTimeKind.Local).AddTicks(1419));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 542, DateTimeKind.Local).AddTicks(1429));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 542, DateTimeKind.Local).AddTicks(1439));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 542, DateTimeKind.Local).AddTicks(1434));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 999,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 542, DateTimeKind.Local).AddTicks(1466));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 9998,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 542, DateTimeKind.Local).AddTicks(1455));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 543, DateTimeKind.Local).AddTicks(8519));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 543, DateTimeKind.Local).AddTicks(8672));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 543, DateTimeKind.Local).AddTicks(8677));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 543, DateTimeKind.Local).AddTicks(8682));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 543, DateTimeKind.Local).AddTicks(8686));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 543, DateTimeKind.Local).AddTicks(8697));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 543, DateTimeKind.Local).AddTicks(8700));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 543, DateTimeKind.Local).AddTicks(8704));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 543, DateTimeKind.Local).AddTicks(8707));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 543, DateTimeKind.Local).AddTicks(8711));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 543, DateTimeKind.Local).AddTicks(8715));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 543, DateTimeKind.Local).AddTicks(8718));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 13,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 543, DateTimeKind.Local).AddTicks(8722));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 14,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 543, DateTimeKind.Local).AddTicks(8729));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 15,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 543, DateTimeKind.Local).AddTicks(8732));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 16,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 543, DateTimeKind.Local).AddTicks(8735));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 17,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 543, DateTimeKind.Local).AddTicks(8739));

            migrationBuilder.UpdateData(
                table: "PaymentStatus",
                keyColumn: "PaymentStatusID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 188, DateTimeKind.Local).AddTicks(1743));

            migrationBuilder.UpdateData(
                table: "PaymentStatus",
                keyColumn: "PaymentStatusID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 188, DateTimeKind.Local).AddTicks(2372));

            migrationBuilder.UpdateData(
                table: "PaymentStatus",
                keyColumn: "PaymentStatusID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 188, DateTimeKind.Local).AddTicks(2387));

            migrationBuilder.UpdateData(
                table: "PaymentStatus",
                keyColumn: "PaymentStatusID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 188, DateTimeKind.Local).AddTicks(2392));

            migrationBuilder.UpdateData(
                table: "PaymentStatus",
                keyColumn: "PaymentStatusID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 188, DateTimeKind.Local).AddTicks(2397));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 183, DateTimeKind.Local).AddTicks(5577));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 183, DateTimeKind.Local).AddTicks(6071));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 183, DateTimeKind.Local).AddTicks(6081));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 183, DateTimeKind.Local).AddTicks(6087));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 183, DateTimeKind.Local).AddTicks(6091));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 183, DateTimeKind.Local).AddTicks(6101));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 183, DateTimeKind.Local).AddTicks(6106));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 183, DateTimeKind.Local).AddTicks(6110));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 183, DateTimeKind.Local).AddTicks(6114));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 183, DateTimeKind.Local).AddTicks(6119));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 183, DateTimeKind.Local).AddTicks(6124));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 183, DateTimeKind.Local).AddTicks(6127));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 13,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 183, DateTimeKind.Local).AddTicks(6131));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 14,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 183, DateTimeKind.Local).AddTicks(6135));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 15,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 183, DateTimeKind.Local).AddTicks(6141));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 16,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 183, DateTimeKind.Local).AddTicks(6145));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 17,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 183, DateTimeKind.Local).AddTicks(6149));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 18,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 183, DateTimeKind.Local).AddTicks(6155));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 19,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 183, DateTimeKind.Local).AddTicks(6159));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 20,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 183, DateTimeKind.Local).AddTicks(6163));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 21,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 183, DateTimeKind.Local).AddTicks(6168));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 22,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 183, DateTimeKind.Local).AddTicks(6172));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 23,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 183, DateTimeKind.Local).AddTicks(6176));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 24,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 183, DateTimeKind.Local).AddTicks(6180));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 25,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 183, DateTimeKind.Local).AddTicks(6183));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 26,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 183, DateTimeKind.Local).AddTicks(6187));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 27,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 183, DateTimeKind.Local).AddTicks(6191));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 28,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 183, DateTimeKind.Local).AddTicks(6195));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 29,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 183, DateTimeKind.Local).AddTicks(6199));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 30,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 183, DateTimeKind.Local).AddTicks(6251));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 31,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 183, DateTimeKind.Local).AddTicks(6256));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 32,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 183, DateTimeKind.Local).AddTicks(6260));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 33,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 183, DateTimeKind.Local).AddTicks(6265));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 34,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 183, DateTimeKind.Local).AddTicks(6272));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 35,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 183, DateTimeKind.Local).AddTicks(6275));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 36,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 183, DateTimeKind.Local).AddTicks(6279));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 37,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 183, DateTimeKind.Local).AddTicks(6284));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 38,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 183, DateTimeKind.Local).AddTicks(6288));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 39,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 183, DateTimeKind.Local).AddTicks(6292));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 40,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 183, DateTimeKind.Local).AddTicks(6295));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 41,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 183, DateTimeKind.Local).AddTicks(6299));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 42,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 183, DateTimeKind.Local).AddTicks(6303));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 43,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 183, DateTimeKind.Local).AddTicks(6307));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 44,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 183, DateTimeKind.Local).AddTicks(6311));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 45,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 183, DateTimeKind.Local).AddTicks(6314));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 46,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 183, DateTimeKind.Local).AddTicks(6318));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 47,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 183, DateTimeKind.Local).AddTicks(6322));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 48,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 183, DateTimeKind.Local).AddTicks(6325));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 49,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 183, DateTimeKind.Local).AddTicks(6329));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 50,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 183, DateTimeKind.Local).AddTicks(6333));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 51,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 183, DateTimeKind.Local).AddTicks(6337));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 52,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 183, DateTimeKind.Local).AddTicks(6341));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 53,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 183, DateTimeKind.Local).AddTicks(6345));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 54,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 183, DateTimeKind.Local).AddTicks(6349));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 55,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 183, DateTimeKind.Local).AddTicks(6353));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 56,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 183, DateTimeKind.Local).AddTicks(6357));

            migrationBuilder.UpdateData(
                table: "PriorityRanks",
                keyColumn: "PriorityRankID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 527, DateTimeKind.Local).AddTicks(7503));

            migrationBuilder.UpdateData(
                table: "PriorityRanks",
                keyColumn: "PriorityRankID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 527, DateTimeKind.Local).AddTicks(7594));

            migrationBuilder.UpdateData(
                table: "PriorityRanks",
                keyColumn: "PriorityRankID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 527, DateTimeKind.Local).AddTicks(7599));

            migrationBuilder.UpdateData(
                table: "PriorityRanks",
                keyColumn: "PriorityRankID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 527, DateTimeKind.Local).AddTicks(7602));

            migrationBuilder.UpdateData(
                table: "ProductFrequencies",
                keyColumn: "ProductFrequencyID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 200, DateTimeKind.Local).AddTicks(3939));

            migrationBuilder.UpdateData(
                table: "ProductFrequencies",
                keyColumn: "ProductFrequencyID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 200, DateTimeKind.Local).AddTicks(4394));

            migrationBuilder.UpdateData(
                table: "ProductFrequencies",
                keyColumn: "ProductFrequencyID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 200, DateTimeKind.Local).AddTicks(4402));

            migrationBuilder.UpdateData(
                table: "ProductFrequencies",
                keyColumn: "ProductFrequencyID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 200, DateTimeKind.Local).AddTicks(4415));

            migrationBuilder.UpdateData(
                table: "ProductFrequencies",
                keyColumn: "ProductFrequencyID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 200, DateTimeKind.Local).AddTicks(4418));

            migrationBuilder.UpdateData(
                table: "RelationshipTypes",
                keyColumn: "RelationshipTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 204, DateTimeKind.Local).AddTicks(4044));

            migrationBuilder.UpdateData(
                table: "RelationshipTypes",
                keyColumn: "RelationshipTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 204, DateTimeKind.Local).AddTicks(4125));

            migrationBuilder.UpdateData(
                table: "RelationshipTypes",
                keyColumn: "RelationshipTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 204, DateTimeKind.Local).AddTicks(4128));

            migrationBuilder.UpdateData(
                table: "RelationshipTypes",
                keyColumn: "RelationshipTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 204, DateTimeKind.Local).AddTicks(4130));

            migrationBuilder.UpdateData(
                table: "RelationshipTypes",
                keyColumn: "RelationshipTypeID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 204, DateTimeKind.Local).AddTicks(4132));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 184, DateTimeKind.Local).AddTicks(6647));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 184, DateTimeKind.Local).AddTicks(6902));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 184, DateTimeKind.Local).AddTicks(6909));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 184, DateTimeKind.Local).AddTicks(6914));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 184, DateTimeKind.Local).AddTicks(6916));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 184, DateTimeKind.Local).AddTicks(6927));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 184, DateTimeKind.Local).AddTicks(6929));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 184, DateTimeKind.Local).AddTicks(6932));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 184, DateTimeKind.Local).AddTicks(6936));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 184, DateTimeKind.Local).AddTicks(6940));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 184, DateTimeKind.Local).AddTicks(6942));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 184, DateTimeKind.Local).AddTicks(6945));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 13,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 184, DateTimeKind.Local).AddTicks(6948));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 14,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 184, DateTimeKind.Local).AddTicks(6951));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 15,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 184, DateTimeKind.Local).AddTicks(6954));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 16,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 184, DateTimeKind.Local).AddTicks(6957));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 17,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 184, DateTimeKind.Local).AddTicks(6960));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 18,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 184, DateTimeKind.Local).AddTicks(6967));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 19,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 184, DateTimeKind.Local).AddTicks(6970));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 20,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 184, DateTimeKind.Local).AddTicks(6973));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 21,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 184, DateTimeKind.Local).AddTicks(6976));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 22,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 184, DateTimeKind.Local).AddTicks(6979));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 23,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 184, DateTimeKind.Local).AddTicks(6982));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 24,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 184, DateTimeKind.Local).AddTicks(6985));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 25,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 184, DateTimeKind.Local).AddTicks(6988));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 26,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 184, DateTimeKind.Local).AddTicks(6991));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 27,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 184, DateTimeKind.Local).AddTicks(6994));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 28,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 184, DateTimeKind.Local).AddTicks(6997));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 29,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 184, DateTimeKind.Local).AddTicks(6999));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 30,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 184, DateTimeKind.Local).AddTicks(7002));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 31,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 184, DateTimeKind.Local).AddTicks(7004));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 32,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 184, DateTimeKind.Local).AddTicks(7006));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 33,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 184, DateTimeKind.Local).AddTicks(7009));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 34,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 184, DateTimeKind.Local).AddTicks(7013));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 35,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 184, DateTimeKind.Local).AddTicks(7016));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 36,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 184, DateTimeKind.Local).AddTicks(7018));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 37,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 184, DateTimeKind.Local).AddTicks(7020));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 38,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 184, DateTimeKind.Local).AddTicks(7023));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 39,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 184, DateTimeKind.Local).AddTicks(7025));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 40,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 184, DateTimeKind.Local).AddTicks(7028));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 41,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 184, DateTimeKind.Local).AddTicks(7030));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 42,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 184, DateTimeKind.Local).AddTicks(7033));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 43,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 184, DateTimeKind.Local).AddTicks(7035));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 44,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 184, DateTimeKind.Local).AddTicks(7037));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 45,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 184, DateTimeKind.Local).AddTicks(7040));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 46,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 184, DateTimeKind.Local).AddTicks(7043));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 47,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 184, DateTimeKind.Local).AddTicks(7045));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 48,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 184, DateTimeKind.Local).AddTicks(7048));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 49,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 184, DateTimeKind.Local).AddTicks(7050));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 50,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 184, DateTimeKind.Local).AddTicks(7052));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 51,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 184, DateTimeKind.Local).AddTicks(7054));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 52,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 184, DateTimeKind.Local).AddTicks(7058));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 53,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 184, DateTimeKind.Local).AddTicks(7061));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 54,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 184, DateTimeKind.Local).AddTicks(7064));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 55,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 184, DateTimeKind.Local).AddTicks(7151));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 56,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 184, DateTimeKind.Local).AddTicks(7155));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 177, DateTimeKind.Local).AddTicks(7016));

            migrationBuilder.UpdateData(
                table: "SystemVariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 206, DateTimeKind.Local).AddTicks(4770));

            migrationBuilder.UpdateData(
                table: "SystemVariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 206, DateTimeKind.Local).AddTicks(4913));

            migrationBuilder.UpdateData(
                table: "SystemVariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 206, DateTimeKind.Local).AddTicks(4910));

            migrationBuilder.UpdateData(
                table: "SystemVariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 206, DateTimeKind.Local).AddTicks(4906));

            migrationBuilder.UpdateData(
                table: "SystemVariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 206, DateTimeKind.Local).AddTicks(4901));

            migrationBuilder.UpdateData(
                table: "SystemVariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 206, DateTimeKind.Local).AddTicks(4923));

            migrationBuilder.UpdateData(
                table: "SystemVariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 206, DateTimeKind.Local).AddTicks(4934));

            migrationBuilder.UpdateData(
                table: "SystemVariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 206, DateTimeKind.Local).AddTicks(4938));

            migrationBuilder.UpdateData(
                table: "SystemVariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 206, DateTimeKind.Local).AddTicks(4942));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 191, DateTimeKind.Local).AddTicks(6159));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 191, DateTimeKind.Local).AddTicks(6828));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 191, DateTimeKind.Local).AddTicks(6848));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 191, DateTimeKind.Local).AddTicks(6854));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 191, DateTimeKind.Local).AddTicks(6860));

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumns: new[] { "UserID", "RoleID" },
                keyValues: new object[] { 1, 1 },
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 540, DateTimeKind.Local).AddTicks(7595));

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumns: new[] { "UserID", "RoleID" },
                keyValues: new object[] { 2, 1 },
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 540, DateTimeKind.Local).AddTicks(7678));

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "UserTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 202, DateTimeKind.Local).AddTicks(8947));

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "UserTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 202, DateTimeKind.Local).AddTicks(9351));

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "UserTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 202, DateTimeKind.Local).AddTicks(9359));

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "UserTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 202, DateTimeKind.Local).AddTicks(9362));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 528, DateTimeKind.Local).AddTicks(3412));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 530, DateTimeKind.Local).AddTicks(4302));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 530, DateTimeKind.Local).AddTicks(4451));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 21, 46, 44, 530, DateTimeKind.Local).AddTicks(4460));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 30);

            migrationBuilder.UpdateData(
                table: "BankAccountTypes",
                keyColumn: "BankAccountTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 35, 969, DateTimeKind.Local).AddTicks(8732));

            migrationBuilder.UpdateData(
                table: "BankAccountTypes",
                keyColumn: "BankAccountTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 35, 969, DateTimeKind.Local).AddTicks(9283));

            migrationBuilder.UpdateData(
                table: "BankAccountTypes",
                keyColumn: "BankAccountTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 35, 969, DateTimeKind.Local).AddTicks(9290));

            migrationBuilder.UpdateData(
                table: "BankAccountTypes",
                keyColumn: "BankAccountTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 35, 969, DateTimeKind.Local).AddTicks(9294));

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "CompanyID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 36, 279, DateTimeKind.Local).AddTicks(5163));

            migrationBuilder.UpdateData(
                table: "ContactTypes",
                keyColumn: "ContactTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 35, 981, DateTimeKind.Local).AddTicks(9740));

            migrationBuilder.UpdateData(
                table: "ContactTypes",
                keyColumn: "ContactTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 35, 981, DateTimeKind.Local).AddTicks(9735));

            migrationBuilder.UpdateData(
                table: "ContactTypes",
                keyColumn: "ContactTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 35, 981, DateTimeKind.Local).AddTicks(9728));

            migrationBuilder.UpdateData(
                table: "ContactTypes",
                keyColumn: "ContactTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 35, 981, DateTimeKind.Local).AddTicks(9102));

            migrationBuilder.UpdateData(
                table: "ContactTypes",
                keyColumn: "ContactTypeID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 35, 981, DateTimeKind.Local).AddTicks(9745));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 36, 287, DateTimeKind.Local).AddTicks(244));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 36, 287, DateTimeKind.Local).AddTicks(787));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 36, 287, DateTimeKind.Local).AddTicks(795));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 36, 287, DateTimeKind.Local).AddTicks(803));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 36, 287, DateTimeKind.Local).AddTicks(806));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 36, 287, DateTimeKind.Local).AddTicks(816));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 36, 287, DateTimeKind.Local).AddTicks(820));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 36, 287, DateTimeKind.Local).AddTicks(824));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 36, 287, DateTimeKind.Local).AddTicks(827));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 36, 287, DateTimeKind.Local).AddTicks(832));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 36, 287, DateTimeKind.Local).AddTicks(835));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 36, 287, DateTimeKind.Local).AddTicks(838));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 13,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 36, 287, DateTimeKind.Local).AddTicks(842));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 14,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 36, 287, DateTimeKind.Local).AddTicks(845));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 15,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 36, 287, DateTimeKind.Local).AddTicks(848));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 16,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 36, 287, DateTimeKind.Local).AddTicks(852));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 17,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 36, 287, DateTimeKind.Local).AddTicks(855));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 18,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 36, 287, DateTimeKind.Local).AddTicks(860));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 19,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 36, 287, DateTimeKind.Local).AddTicks(864));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 20,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 36, 287, DateTimeKind.Local).AddTicks(868));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 21,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 36, 287, DateTimeKind.Local).AddTicks(871));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 22,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 36, 287, DateTimeKind.Local).AddTicks(874));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 23,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 36, 287, DateTimeKind.Local).AddTicks(877));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 24,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 36, 287, DateTimeKind.Local).AddTicks(880));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 25,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 36, 287, DateTimeKind.Local).AddTicks(884));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 26,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 36, 287, DateTimeKind.Local).AddTicks(887));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 27,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 36, 287, DateTimeKind.Local).AddTicks(891));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 28,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 36, 287, DateTimeKind.Local).AddTicks(894));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 29,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 36, 287, DateTimeKind.Local).AddTicks(897));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 30,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 36, 287, DateTimeKind.Local).AddTicks(902));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 31,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 36, 287, DateTimeKind.Local).AddTicks(906));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 32,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 36, 287, DateTimeKind.Local).AddTicks(909));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 33,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 36, 287, DateTimeKind.Local).AddTicks(913));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 34,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 36, 287, DateTimeKind.Local).AddTicks(917));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 35,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 36, 287, DateTimeKind.Local).AddTicks(921));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 36,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 36, 287, DateTimeKind.Local).AddTicks(957));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 37,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 36, 287, DateTimeKind.Local).AddTicks(961));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 38,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 36, 287, DateTimeKind.Local).AddTicks(964));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 39,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 36, 287, DateTimeKind.Local).AddTicks(968));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 40,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 36, 287, DateTimeKind.Local).AddTicks(972));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 41,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 36, 287, DateTimeKind.Local).AddTicks(977));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 42,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 36, 287, DateTimeKind.Local).AddTicks(980));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 43,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 36, 287, DateTimeKind.Local).AddTicks(983));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 44,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 36, 287, DateTimeKind.Local).AddTicks(987));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 45,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 36, 287, DateTimeKind.Local).AddTicks(990));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 46,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 36, 287, DateTimeKind.Local).AddTicks(993));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 47,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 36, 287, DateTimeKind.Local).AddTicks(997));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 48,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 36, 287, DateTimeKind.Local).AddTicks(1002));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 49,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 36, 287, DateTimeKind.Local).AddTicks(1006));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 50,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 36, 287, DateTimeKind.Local).AddTicks(1009));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 51,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 36, 287, DateTimeKind.Local).AddTicks(1013));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 52,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 36, 287, DateTimeKind.Local).AddTicks(1017));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 53,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 36, 287, DateTimeKind.Local).AddTicks(1020));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 54,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 36, 287, DateTimeKind.Local).AddTicks(1023));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 55,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 36, 287, DateTimeKind.Local).AddTicks(1027));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 56,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 36, 287, DateTimeKind.Local).AddTicks(1031));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 57,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 36, 287, DateTimeKind.Local).AddTicks(1034));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 58,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 36, 287, DateTimeKind.Local).AddTicks(1037));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 59,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 36, 287, DateTimeKind.Local).AddTicks(1042));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 60,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 36, 287, DateTimeKind.Local).AddTicks(1045));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 61,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 36, 287, DateTimeKind.Local).AddTicks(1049));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 62,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 36, 287, DateTimeKind.Local).AddTicks(1056));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 63,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 36, 287, DateTimeKind.Local).AddTicks(1060));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 64,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 36, 287, DateTimeKind.Local).AddTicks(1064));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 65,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 36, 287, DateTimeKind.Local).AddTicks(1067));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 66,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 36, 287, DateTimeKind.Local).AddTicks(1073));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 67,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 36, 287, DateTimeKind.Local).AddTicks(1076));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 68,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 36, 287, DateTimeKind.Local).AddTicks(1080));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 69,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 36, 287, DateTimeKind.Local).AddTicks(1083));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 70,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 36, 287, DateTimeKind.Local).AddTicks(1086));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 71,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 36, 287, DateTimeKind.Local).AddTicks(1089));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 72,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 36, 287, DateTimeKind.Local).AddTicks(1093));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 73,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 36, 287, DateTimeKind.Local).AddTicks(1097));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 74,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 36, 287, DateTimeKind.Local).AddTicks(1100));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 75,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 36, 287, DateTimeKind.Local).AddTicks(1104));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 76,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 36, 287, DateTimeKind.Local).AddTicks(1107));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 77,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 36, 287, DateTimeKind.Local).AddTicks(1111));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 78,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 36, 287, DateTimeKind.Local).AddTicks(1113));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 79,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 36, 287, DateTimeKind.Local).AddTicks(1117));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 80,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 36, 287, DateTimeKind.Local).AddTicks(1120));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 81,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 36, 287, DateTimeKind.Local).AddTicks(1123));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 82,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 36, 287, DateTimeKind.Local).AddTicks(1126));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 83,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 36, 287, DateTimeKind.Local).AddTicks(1130));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 84,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 36, 287, DateTimeKind.Local).AddTicks(1133));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 85,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 36, 287, DateTimeKind.Local).AddTicks(1136));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 86,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 36, 287, DateTimeKind.Local).AddTicks(1140));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 87,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 36, 287, DateTimeKind.Local).AddTicks(1143));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 88,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 36, 287, DateTimeKind.Local).AddTicks(1146));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 89,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 36, 287, DateTimeKind.Local).AddTicks(1150));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 90,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 36, 287, DateTimeKind.Local).AddTicks(1153));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 91,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 36, 287, DateTimeKind.Local).AddTicks(1157));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 92,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 36, 287, DateTimeKind.Local).AddTicks(1160));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 93,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 36, 287, DateTimeKind.Local).AddTicks(1163));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 94,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 36, 287, DateTimeKind.Local).AddTicks(1239));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 95,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 36, 287, DateTimeKind.Local).AddTicks(1243));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 96,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 36, 287, DateTimeKind.Local).AddTicks(1246));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 97,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 36, 287, DateTimeKind.Local).AddTicks(1249));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 98,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 36, 287, DateTimeKind.Local).AddTicks(1252));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 99,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 36, 287, DateTimeKind.Local).AddTicks(1255));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 100,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 36, 287, DateTimeKind.Local).AddTicks(1258));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 101,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 36, 287, DateTimeKind.Local).AddTicks(1262));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 102,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 36, 287, DateTimeKind.Local).AddTicks(1265));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 103,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 36, 287, DateTimeKind.Local).AddTicks(1269));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 104,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 36, 287, DateTimeKind.Local).AddTicks(1272));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 105,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 36, 287, DateTimeKind.Local).AddTicks(1275));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 106,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 36, 287, DateTimeKind.Local).AddTicks(1278));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 107,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 36, 287, DateTimeKind.Local).AddTicks(1281));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 108,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 36, 287, DateTimeKind.Local).AddTicks(1284));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 109,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 36, 287, DateTimeKind.Local).AddTicks(1287));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 110,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 36, 287, DateTimeKind.Local).AddTicks(1290));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 111,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 36, 287, DateTimeKind.Local).AddTicks(1294));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 112,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 36, 287, DateTimeKind.Local).AddTicks(1298));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 113,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 36, 287, DateTimeKind.Local).AddTicks(1301));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 114,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 36, 287, DateTimeKind.Local).AddTicks(1304));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 115,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 36, 287, DateTimeKind.Local).AddTicks(1309));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 116,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 36, 287, DateTimeKind.Local).AddTicks(1312));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 117,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 36, 287, DateTimeKind.Local).AddTicks(1315));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 118,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 36, 287, DateTimeKind.Local).AddTicks(1319));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 119,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 36, 287, DateTimeKind.Local).AddTicks(1322));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 120,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 36, 287, DateTimeKind.Local).AddTicks(1325));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 121,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 36, 287, DateTimeKind.Local).AddTicks(1328));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 122,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 36, 287, DateTimeKind.Local).AddTicks(1331));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 123,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 36, 287, DateTimeKind.Local).AddTicks(1335));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 124,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 36, 287, DateTimeKind.Local).AddTicks(1338));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 125,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 36, 287, DateTimeKind.Local).AddTicks(1341));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 126,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 36, 287, DateTimeKind.Local).AddTicks(1344));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 127,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 36, 287, DateTimeKind.Local).AddTicks(1347));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 128,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 36, 287, DateTimeKind.Local).AddTicks(1350));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 129,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 36, 287, DateTimeKind.Local).AddTicks(1354));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 130,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 36, 287, DateTimeKind.Local).AddTicks(1359));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 131,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 36, 287, DateTimeKind.Local).AddTicks(1363));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 132,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 36, 287, DateTimeKind.Local).AddTicks(1367));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 133,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 36, 287, DateTimeKind.Local).AddTicks(1370));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 134,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 36, 287, DateTimeKind.Local).AddTicks(1373));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 135,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 36, 287, DateTimeKind.Local).AddTicks(1376));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 136,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 36, 287, DateTimeKind.Local).AddTicks(1379));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 137,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 36, 287, DateTimeKind.Local).AddTicks(1383));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 138,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 36, 287, DateTimeKind.Local).AddTicks(1387));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 139,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 36, 287, DateTimeKind.Local).AddTicks(1390));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 140,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 36, 287, DateTimeKind.Local).AddTicks(1394));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 141,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 36, 287, DateTimeKind.Local).AddTicks(1397));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 142,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 36, 287, DateTimeKind.Local).AddTicks(1400));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 143,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 36, 287, DateTimeKind.Local).AddTicks(1403));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 144,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 36, 287, DateTimeKind.Local).AddTicks(1407));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 145,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 36, 287, DateTimeKind.Local).AddTicks(1410));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 146,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 36, 287, DateTimeKind.Local).AddTicks(1413));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 147,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 36, 287, DateTimeKind.Local).AddTicks(1417));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 148,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 36, 287, DateTimeKind.Local).AddTicks(1420));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 149,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 36, 287, DateTimeKind.Local).AddTicks(1424));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 150,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 36, 287, DateTimeKind.Local).AddTicks(1463));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 151,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 36, 287, DateTimeKind.Local).AddTicks(1467));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 152,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 36, 287, DateTimeKind.Local).AddTicks(1470));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 153,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 36, 287, DateTimeKind.Local).AddTicks(1474));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 154,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 36, 287, DateTimeKind.Local).AddTicks(1477));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 155,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 36, 287, DateTimeKind.Local).AddTicks(1481));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 156,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 36, 287, DateTimeKind.Local).AddTicks(1484));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 157,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 36, 287, DateTimeKind.Local).AddTicks(1488));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 158,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 36, 287, DateTimeKind.Local).AddTicks(1491));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 159,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 36, 287, DateTimeKind.Local).AddTicks(1494));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 160,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 36, 287, DateTimeKind.Local).AddTicks(1498));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 161,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 36, 287, DateTimeKind.Local).AddTicks(1502));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 162,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 36, 287, DateTimeKind.Local).AddTicks(1505));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 163,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 36, 287, DateTimeKind.Local).AddTicks(1508));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 164,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 36, 287, DateTimeKind.Local).AddTicks(1512));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 165,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 36, 287, DateTimeKind.Local).AddTicks(1515));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 166,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 36, 287, DateTimeKind.Local).AddTicks(1519));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 167,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 36, 287, DateTimeKind.Local).AddTicks(1522));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 168,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 36, 287, DateTimeKind.Local).AddTicks(1525));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 169,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 36, 287, DateTimeKind.Local).AddTicks(1529));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 170,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 36, 287, DateTimeKind.Local).AddTicks(1532));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 171,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 36, 287, DateTimeKind.Local).AddTicks(1535));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 172,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 36, 287, DateTimeKind.Local).AddTicks(1539));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 173,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 36, 287, DateTimeKind.Local).AddTicks(1543));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 174,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 36, 287, DateTimeKind.Local).AddTicks(1547));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 175,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 36, 287, DateTimeKind.Local).AddTicks(1550));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 176,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 36, 287, DateTimeKind.Local).AddTicks(1555));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 177,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 36, 287, DateTimeKind.Local).AddTicks(1560));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 178,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 36, 287, DateTimeKind.Local).AddTicks(1563));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 179,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 36, 287, DateTimeKind.Local).AddTicks(1567));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 180,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 36, 287, DateTimeKind.Local).AddTicks(1571));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 181,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 36, 287, DateTimeKind.Local).AddTicks(1575));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 182,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 36, 287, DateTimeKind.Local).AddTicks(1578));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 183,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 36, 287, DateTimeKind.Local).AddTicks(1581));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 184,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 36, 287, DateTimeKind.Local).AddTicks(1585));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 185,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 36, 287, DateTimeKind.Local).AddTicks(1588));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 186,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 36, 287, DateTimeKind.Local).AddTicks(1592));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 187,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 36, 287, DateTimeKind.Local).AddTicks(1595));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 188,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 36, 287, DateTimeKind.Local).AddTicks(1598));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 189,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 36, 287, DateTimeKind.Local).AddTicks(1602));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 190,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 36, 287, DateTimeKind.Local).AddTicks(1605));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 191,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 36, 287, DateTimeKind.Local).AddTicks(1609));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 192,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 36, 287, DateTimeKind.Local).AddTicks(1612));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 193,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 36, 287, DateTimeKind.Local).AddTicks(1616));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 194,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 36, 287, DateTimeKind.Local).AddTicks(1619));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 195,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 36, 287, DateTimeKind.Local).AddTicks(1622));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 196,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 36, 287, DateTimeKind.Local).AddTicks(1625));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 197,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 36, 287, DateTimeKind.Local).AddTicks(1628));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 198,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 36, 287, DateTimeKind.Local).AddTicks(1632));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 199,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 36, 287, DateTimeKind.Local).AddTicks(1635));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 200,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 36, 287, DateTimeKind.Local).AddTicks(1638));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 201,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 36, 287, DateTimeKind.Local).AddTicks(1642));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 202,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 36, 287, DateTimeKind.Local).AddTicks(1645));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 203,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 36, 287, DateTimeKind.Local).AddTicks(1648));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 204,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 36, 287, DateTimeKind.Local).AddTicks(1651));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 205,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 36, 287, DateTimeKind.Local).AddTicks(1655));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 206,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 36, 287, DateTimeKind.Local).AddTicks(1658));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 207,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 36, 287, DateTimeKind.Local).AddTicks(1661));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 208,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 36, 287, DateTimeKind.Local).AddTicks(1665));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 209,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 36, 287, DateTimeKind.Local).AddTicks(1668));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 210,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 36, 287, DateTimeKind.Local).AddTicks(1672));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 211,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 36, 287, DateTimeKind.Local).AddTicks(1676));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 212,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 36, 287, DateTimeKind.Local).AddTicks(1679));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 213,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 36, 287, DateTimeKind.Local).AddTicks(1682));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 214,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 36, 287, DateTimeKind.Local).AddTicks(1686));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 215,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 36, 287, DateTimeKind.Local).AddTicks(1690));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 216,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 36, 287, DateTimeKind.Local).AddTicks(1693));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 217,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 36, 287, DateTimeKind.Local).AddTicks(1730));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 218,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 36, 287, DateTimeKind.Local).AddTicks(1733));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 219,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 36, 287, DateTimeKind.Local).AddTicks(1736));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 220,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 36, 287, DateTimeKind.Local).AddTicks(1740));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 221,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 36, 287, DateTimeKind.Local).AddTicks(1743));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 222,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 36, 287, DateTimeKind.Local).AddTicks(1746));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 223,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 36, 287, DateTimeKind.Local).AddTicks(1750));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 224,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 36, 287, DateTimeKind.Local).AddTicks(1754));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 225,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 36, 287, DateTimeKind.Local).AddTicks(1758));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 226,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 36, 287, DateTimeKind.Local).AddTicks(1761));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 227,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 36, 287, DateTimeKind.Local).AddTicks(1764));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 228,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 36, 287, DateTimeKind.Local).AddTicks(1767));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 35, 972, DateTimeKind.Local).AddTicks(9915));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 35, 973, DateTimeKind.Local).AddTicks(387));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 35, 973, DateTimeKind.Local).AddTicks(396));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 35, 973, DateTimeKind.Local).AddTicks(400));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 35, 973, DateTimeKind.Local).AddTicks(404));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 35, 973, DateTimeKind.Local).AddTicks(413));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 35, 973, DateTimeKind.Local).AddTicks(416));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 35, 973, DateTimeKind.Local).AddTicks(419));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 35, 973, DateTimeKind.Local).AddTicks(423));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 35, 973, DateTimeKind.Local).AddTicks(428));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 35, 973, DateTimeKind.Local).AddTicks(432));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 35, 973, DateTimeKind.Local).AddTicks(435));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 13,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 35, 973, DateTimeKind.Local).AddTicks(439));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 14,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 35, 973, DateTimeKind.Local).AddTicks(442));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 15,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 35, 973, DateTimeKind.Local).AddTicks(445));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 16,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 35, 973, DateTimeKind.Local).AddTicks(449));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 17,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 35, 973, DateTimeKind.Local).AddTicks(452));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 18,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 35, 973, DateTimeKind.Local).AddTicks(457));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 19,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 35, 973, DateTimeKind.Local).AddTicks(460));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 20,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 35, 973, DateTimeKind.Local).AddTicks(464));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 21,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 35, 973, DateTimeKind.Local).AddTicks(467));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 22,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 35, 973, DateTimeKind.Local).AddTicks(471));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 23,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 35, 973, DateTimeKind.Local).AddTicks(474));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 24,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 35, 973, DateTimeKind.Local).AddTicks(478));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 25,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 35, 973, DateTimeKind.Local).AddTicks(481));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 26,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 35, 973, DateTimeKind.Local).AddTicks(485));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 27,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 35, 973, DateTimeKind.Local).AddTicks(488));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 28,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 35, 973, DateTimeKind.Local).AddTicks(491));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 29,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 35, 973, DateTimeKind.Local).AddTicks(494));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 30,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 35, 973, DateTimeKind.Local).AddTicks(498));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 31,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 35, 973, DateTimeKind.Local).AddTicks(501));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 32,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 35, 973, DateTimeKind.Local).AddTicks(505));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 33,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 35, 973, DateTimeKind.Local).AddTicks(508));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 34,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 35, 973, DateTimeKind.Local).AddTicks(556));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 35,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 35, 973, DateTimeKind.Local).AddTicks(560));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 36,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 35, 973, DateTimeKind.Local).AddTicks(563));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 37,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 35, 973, DateTimeKind.Local).AddTicks(566));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 38,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 35, 973, DateTimeKind.Local).AddTicks(570));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 39,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 35, 973, DateTimeKind.Local).AddTicks(573));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 40,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 35, 973, DateTimeKind.Local).AddTicks(576));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 41,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 35, 973, DateTimeKind.Local).AddTicks(580));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 42,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 35, 973, DateTimeKind.Local).AddTicks(583));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 43,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 35, 973, DateTimeKind.Local).AddTicks(587));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 44,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 35, 973, DateTimeKind.Local).AddTicks(590));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 45,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 35, 973, DateTimeKind.Local).AddTicks(593));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 46,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 35, 973, DateTimeKind.Local).AddTicks(597));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 47,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 35, 973, DateTimeKind.Local).AddTicks(600));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 48,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 35, 973, DateTimeKind.Local).AddTicks(603));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 49,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 35, 973, DateTimeKind.Local).AddTicks(608));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 50,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 35, 973, DateTimeKind.Local).AddTicks(611));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 51,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 35, 973, DateTimeKind.Local).AddTicks(614));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 52,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 35, 973, DateTimeKind.Local).AddTicks(618));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 53,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 35, 973, DateTimeKind.Local).AddTicks(621));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 54,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 35, 973, DateTimeKind.Local).AddTicks(624));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 55,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 35, 973, DateTimeKind.Local).AddTicks(627));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 56,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 35, 973, DateTimeKind.Local).AddTicks(631));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 57,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 35, 973, DateTimeKind.Local).AddTicks(634));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 58,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 35, 973, DateTimeKind.Local).AddTicks(637));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 59,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 35, 973, DateTimeKind.Local).AddTicks(640));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 60,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 35, 973, DateTimeKind.Local).AddTicks(644));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 61,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 35, 973, DateTimeKind.Local).AddTicks(647));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 62,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 35, 973, DateTimeKind.Local).AddTicks(650));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 63,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 35, 973, DateTimeKind.Local).AddTicks(654));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 64,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 35, 973, DateTimeKind.Local).AddTicks(657));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 65,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 35, 973, DateTimeKind.Local).AddTicks(660));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 66,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 35, 973, DateTimeKind.Local).AddTicks(666));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 67,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 35, 973, DateTimeKind.Local).AddTicks(670));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 68,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 35, 973, DateTimeKind.Local).AddTicks(673));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 69,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 35, 973, DateTimeKind.Local).AddTicks(676));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 70,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 35, 973, DateTimeKind.Local).AddTicks(679));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 71,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 35, 973, DateTimeKind.Local).AddTicks(683));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 72,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 35, 973, DateTimeKind.Local).AddTicks(686));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 73,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 35, 973, DateTimeKind.Local).AddTicks(689));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 74,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 35, 973, DateTimeKind.Local).AddTicks(693));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 75,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 35, 973, DateTimeKind.Local).AddTicks(696));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 76,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 35, 973, DateTimeKind.Local).AddTicks(699));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 77,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 35, 973, DateTimeKind.Local).AddTicks(703));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 78,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 35, 973, DateTimeKind.Local).AddTicks(706));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 79,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 35, 973, DateTimeKind.Local).AddTicks(709));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 80,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 35, 973, DateTimeKind.Local).AddTicks(712));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 81,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 35, 973, DateTimeKind.Local).AddTicks(715));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 82,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 35, 973, DateTimeKind.Local).AddTicks(719));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 83,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 35, 973, DateTimeKind.Local).AddTicks(723));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 84,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 35, 973, DateTimeKind.Local).AddTicks(726));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 85,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 35, 973, DateTimeKind.Local).AddTicks(730));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 86,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 35, 973, DateTimeKind.Local).AddTicks(733));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 87,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 35, 973, DateTimeKind.Local).AddTicks(736));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 88,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 35, 973, DateTimeKind.Local).AddTicks(739));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 89,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 35, 973, DateTimeKind.Local).AddTicks(743));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 90,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 35, 973, DateTimeKind.Local).AddTicks(746));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 91,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 35, 973, DateTimeKind.Local).AddTicks(749));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 92,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 35, 973, DateTimeKind.Local).AddTicks(753));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 93,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 35, 973, DateTimeKind.Local).AddTicks(756));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 94,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 35, 973, DateTimeKind.Local).AddTicks(759));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 95,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 35, 973, DateTimeKind.Local).AddTicks(762));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 96,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 35, 973, DateTimeKind.Local).AddTicks(766));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 97,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 35, 973, DateTimeKind.Local).AddTicks(769));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 98,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 35, 973, DateTimeKind.Local).AddTicks(772));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 99,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 35, 973, DateTimeKind.Local).AddTicks(775));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 100,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 35, 973, DateTimeKind.Local).AddTicks(779));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 101,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 35, 973, DateTimeKind.Local).AddTicks(782));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 102,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 35, 973, DateTimeKind.Local).AddTicks(820));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 103,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 35, 973, DateTimeKind.Local).AddTicks(824));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 104,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 35, 973, DateTimeKind.Local).AddTicks(828));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 105,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 35, 973, DateTimeKind.Local).AddTicks(832));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 106,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 35, 973, DateTimeKind.Local).AddTicks(835));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 107,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 35, 973, DateTimeKind.Local).AddTicks(838));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 108,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 35, 973, DateTimeKind.Local).AddTicks(842));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 109,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 35, 973, DateTimeKind.Local).AddTicks(845));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 110,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 35, 973, DateTimeKind.Local).AddTicks(849));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 111,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 35, 973, DateTimeKind.Local).AddTicks(852));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 112,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 35, 973, DateTimeKind.Local).AddTicks(856));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 113,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 35, 973, DateTimeKind.Local).AddTicks(860));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 114,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 35, 973, DateTimeKind.Local).AddTicks(863));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 115,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 35, 973, DateTimeKind.Local).AddTicks(867));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 116,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 35, 973, DateTimeKind.Local).AddTicks(870));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 117,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 35, 973, DateTimeKind.Local).AddTicks(873));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 118,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 35, 973, DateTimeKind.Local).AddTicks(877));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 119,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 35, 973, DateTimeKind.Local).AddTicks(880));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 120,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 35, 973, DateTimeKind.Local).AddTicks(883));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 121,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 35, 973, DateTimeKind.Local).AddTicks(887));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 122,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 35, 973, DateTimeKind.Local).AddTicks(890));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 123,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 35, 973, DateTimeKind.Local).AddTicks(894));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 124,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 35, 973, DateTimeKind.Local).AddTicks(897));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 125,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 35, 973, DateTimeKind.Local).AddTicks(901));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 126,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 35, 973, DateTimeKind.Local).AddTicks(904));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 127,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 35, 973, DateTimeKind.Local).AddTicks(907));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 128,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 35, 973, DateTimeKind.Local).AddTicks(911));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 129,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 35, 973, DateTimeKind.Local).AddTicks(914));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 130,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 35, 973, DateTimeKind.Local).AddTicks(920));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 131,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 35, 973, DateTimeKind.Local).AddTicks(923));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 132,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 35, 973, DateTimeKind.Local).AddTicks(926));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 133,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 35, 973, DateTimeKind.Local).AddTicks(930));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 134,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 35, 973, DateTimeKind.Local).AddTicks(933));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 135,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 35, 973, DateTimeKind.Local).AddTicks(936));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 136,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 35, 973, DateTimeKind.Local).AddTicks(939));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 137,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 35, 973, DateTimeKind.Local).AddTicks(943));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 138,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 35, 973, DateTimeKind.Local).AddTicks(946));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 139,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 35, 973, DateTimeKind.Local).AddTicks(949));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 140,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 35, 973, DateTimeKind.Local).AddTicks(952));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 141,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 35, 973, DateTimeKind.Local).AddTicks(956));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 142,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 35, 973, DateTimeKind.Local).AddTicks(959));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 143,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 35, 973, DateTimeKind.Local).AddTicks(963));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 144,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 35, 973, DateTimeKind.Local).AddTicks(966));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 145,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 35, 973, DateTimeKind.Local).AddTicks(969));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 146,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 35, 973, DateTimeKind.Local).AddTicks(973));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 147,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 35, 973, DateTimeKind.Local).AddTicks(976));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 148,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 35, 973, DateTimeKind.Local).AddTicks(979));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 149,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 35, 973, DateTimeKind.Local).AddTicks(982));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 150,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 35, 973, DateTimeKind.Local).AddTicks(986));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 151,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 35, 973, DateTimeKind.Local).AddTicks(989));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 152,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 35, 973, DateTimeKind.Local).AddTicks(992));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 153,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 35, 973, DateTimeKind.Local).AddTicks(996));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 154,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 35, 973, DateTimeKind.Local).AddTicks(999));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 155,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 35, 973, DateTimeKind.Local).AddTicks(1002));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 156,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 35, 973, DateTimeKind.Local).AddTicks(1005));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 157,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 35, 973, DateTimeKind.Local).AddTicks(1009));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 158,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 35, 973, DateTimeKind.Local).AddTicks(1012));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 159,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 35, 973, DateTimeKind.Local).AddTicks(1015));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 160,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 35, 973, DateTimeKind.Local).AddTicks(1019));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 161,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 35, 973, DateTimeKind.Local).AddTicks(1052));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 162,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 35, 973, DateTimeKind.Local).AddTicks(1055));

            migrationBuilder.UpdateData(
                table: "CustomSettingTypes",
                keyColumn: "CustomSettingTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 35, 983, DateTimeKind.Local).AddTicks(5714));

            migrationBuilder.UpdateData(
                table: "CustomSettingTypes",
                keyColumn: "CustomSettingTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 35, 983, DateTimeKind.Local).AddTicks(5843));

            migrationBuilder.UpdateData(
                table: "CustomSettingTypes",
                keyColumn: "CustomSettingTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 35, 983, DateTimeKind.Local).AddTicks(5848));

            migrationBuilder.UpdateData(
                table: "CustomSettingTypes",
                keyColumn: "CustomSettingTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 35, 983, DateTimeKind.Local).AddTicks(5853));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 35, 988, DateTimeKind.Local).AddTicks(6289));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 35, 988, DateTimeKind.Local).AddTicks(6530));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 35, 988, DateTimeKind.Local).AddTicks(6605));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 35, 988, DateTimeKind.Local).AddTicks(6613));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 35, 988, DateTimeKind.Local).AddTicks(6620));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 35, 988, DateTimeKind.Local).AddTicks(6632));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 35, 988, DateTimeKind.Local).AddTicks(6643));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 35, 988, DateTimeKind.Local).AddTicks(6649));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 35, 988, DateTimeKind.Local).AddTicks(6655));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 35, 988, DateTimeKind.Local).AddTicks(6661));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 11,
                columns: new[] { "LastChangedDate", "Value" },
                values: new object[] { new DateTime(2020, 9, 12, 17, 16, 35, 988, DateTimeKind.Local).AddTicks(6667), "true" });

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 35, 988, DateTimeKind.Local).AddTicks(6673));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 13,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 35, 988, DateTimeKind.Local).AddTicks(6678));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 14,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 35, 988, DateTimeKind.Local).AddTicks(6683));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 15,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 35, 988, DateTimeKind.Local).AddTicks(6688));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 16,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 35, 988, DateTimeKind.Local).AddTicks(6694));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 17,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 35, 988, DateTimeKind.Local).AddTicks(6638));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 18,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 35, 988, DateTimeKind.Local).AddTicks(6702));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 19,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 35, 988, DateTimeKind.Local).AddTicks(6707));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 20,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 35, 988, DateTimeKind.Local).AddTicks(6712));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 21,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 35, 988, DateTimeKind.Local).AddTicks(6717));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 22,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 35, 988, DateTimeKind.Local).AddTicks(6723));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 23,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 35, 988, DateTimeKind.Local).AddTicks(6728));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 24,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 36, 247, DateTimeKind.Local).AddTicks(7493));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 25,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 36, 277, DateTimeKind.Local).AddTicks(3036));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 26,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 36, 277, DateTimeKind.Local).AddTicks(3147));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 27,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 36, 277, DateTimeKind.Local).AddTicks(3160));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 28,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 36, 277, DateTimeKind.Local).AddTicks(3176));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 29,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 36, 277, DateTimeKind.Local).AddTicks(3169));

            migrationBuilder.UpdateData(
                table: "DocumentFormats",
                keyColumn: "DocumentFormatID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 36, 292, DateTimeKind.Local).AddTicks(6395));

            migrationBuilder.UpdateData(
                table: "DocumentFormats",
                keyColumn: "DocumentFormatID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 36, 292, DateTimeKind.Local).AddTicks(6875));

            migrationBuilder.UpdateData(
                table: "DocumentFormats",
                keyColumn: "DocumentFormatID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 36, 292, DateTimeKind.Local).AddTicks(6884));

            migrationBuilder.UpdateData(
                table: "DocumentFormats",
                keyColumn: "DocumentFormatID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 36, 292, DateTimeKind.Local).AddTicks(6888));

            migrationBuilder.UpdateData(
                table: "DocumentFormats",
                keyColumn: "DocumentFormatID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 36, 292, DateTimeKind.Local).AddTicks(6891));

            migrationBuilder.UpdateData(
                table: "DocumentFormats",
                keyColumn: "DocumentFormatID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 36, 292, DateTimeKind.Local).AddTicks(6901));

            migrationBuilder.UpdateData(
                table: "DocumentTypes",
                keyColumn: "DocumentTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 36, 295, DateTimeKind.Local).AddTicks(4375));

            migrationBuilder.UpdateData(
                table: "DocumentTypes",
                keyColumn: "DocumentTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 36, 295, DateTimeKind.Local).AddTicks(5479));

            migrationBuilder.UpdateData(
                table: "DocumentTypes",
                keyColumn: "DocumentTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 36, 295, DateTimeKind.Local).AddTicks(5504));

            migrationBuilder.UpdateData(
                table: "FeatureFlags",
                keyColumn: "FeatureFlagID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 36, 289, DateTimeKind.Local).AddTicks(6751));

            migrationBuilder.UpdateData(
                table: "FeatureFlags",
                keyColumn: "FeatureFlagID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 36, 289, DateTimeKind.Local).AddTicks(7319));

            migrationBuilder.UpdateData(
                table: "FeatureFlags",
                keyColumn: "FeatureFlagID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 36, 289, DateTimeKind.Local).AddTicks(7328));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "GenderID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 36, 284, DateTimeKind.Local).AddTicks(3471));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "GenderID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 36, 284, DateTimeKind.Local).AddTicks(3570));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 36, 297, DateTimeKind.Local).AddTicks(8681));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 36, 297, DateTimeKind.Local).AddTicks(9667));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 36, 297, DateTimeKind.Local).AddTicks(9678));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 36, 297, DateTimeKind.Local).AddTicks(9691));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 36, 297, DateTimeKind.Local).AddTicks(9685));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 999,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 36, 297, DateTimeKind.Local).AddTicks(9717));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 9998,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 36, 297, DateTimeKind.Local).AddTicks(9705));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 36, 299, DateTimeKind.Local).AddTicks(7748));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 36, 299, DateTimeKind.Local).AddTicks(7900));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 36, 299, DateTimeKind.Local).AddTicks(7905));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 36, 299, DateTimeKind.Local).AddTicks(7909));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 36, 299, DateTimeKind.Local).AddTicks(7912));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 36, 299, DateTimeKind.Local).AddTicks(7925));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 36, 299, DateTimeKind.Local).AddTicks(7928));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 36, 299, DateTimeKind.Local).AddTicks(7933));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 36, 299, DateTimeKind.Local).AddTicks(7936));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 36, 299, DateTimeKind.Local).AddTicks(7942));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 36, 299, DateTimeKind.Local).AddTicks(7945));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 36, 299, DateTimeKind.Local).AddTicks(7948));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 13,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 36, 299, DateTimeKind.Local).AddTicks(7952));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 14,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 36, 299, DateTimeKind.Local).AddTicks(7956));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 15,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 36, 299, DateTimeKind.Local).AddTicks(7959));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 16,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 36, 299, DateTimeKind.Local).AddTicks(7963));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 17,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 36, 299, DateTimeKind.Local).AddTicks(7966));

            migrationBuilder.UpdateData(
                table: "PaymentStatus",
                keyColumn: "PaymentStatusID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 35, 964, DateTimeKind.Local).AddTicks(1217));

            migrationBuilder.UpdateData(
                table: "PaymentStatus",
                keyColumn: "PaymentStatusID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 35, 964, DateTimeKind.Local).AddTicks(1796));

            migrationBuilder.UpdateData(
                table: "PaymentStatus",
                keyColumn: "PaymentStatusID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 35, 964, DateTimeKind.Local).AddTicks(1805));

            migrationBuilder.UpdateData(
                table: "PaymentStatus",
                keyColumn: "PaymentStatusID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 35, 964, DateTimeKind.Local).AddTicks(1808));

            migrationBuilder.UpdateData(
                table: "PaymentStatus",
                keyColumn: "PaymentStatusID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 35, 964, DateTimeKind.Local).AddTicks(1812));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 35, 960, DateTimeKind.Local).AddTicks(5909));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 35, 960, DateTimeKind.Local).AddTicks(6485));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 35, 960, DateTimeKind.Local).AddTicks(6495));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 35, 960, DateTimeKind.Local).AddTicks(6502));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 35, 960, DateTimeKind.Local).AddTicks(6638));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 35, 960, DateTimeKind.Local).AddTicks(6649));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 35, 960, DateTimeKind.Local).AddTicks(6654));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 35, 960, DateTimeKind.Local).AddTicks(6659));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 35, 960, DateTimeKind.Local).AddTicks(6663));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 35, 960, DateTimeKind.Local).AddTicks(6669));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 35, 960, DateTimeKind.Local).AddTicks(6673));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 35, 960, DateTimeKind.Local).AddTicks(6677));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 13,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 35, 960, DateTimeKind.Local).AddTicks(6682));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 14,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 35, 960, DateTimeKind.Local).AddTicks(6686));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 15,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 35, 960, DateTimeKind.Local).AddTicks(6690));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 16,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 35, 960, DateTimeKind.Local).AddTicks(6695));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 17,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 35, 960, DateTimeKind.Local).AddTicks(6699));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 18,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 35, 960, DateTimeKind.Local).AddTicks(6705));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 19,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 35, 960, DateTimeKind.Local).AddTicks(6709));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 20,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 35, 960, DateTimeKind.Local).AddTicks(6713));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 21,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 35, 960, DateTimeKind.Local).AddTicks(6717));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 22,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 35, 960, DateTimeKind.Local).AddTicks(6721));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 23,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 35, 960, DateTimeKind.Local).AddTicks(6725));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 24,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 35, 960, DateTimeKind.Local).AddTicks(6729));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 25,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 35, 960, DateTimeKind.Local).AddTicks(6733));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 26,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 35, 960, DateTimeKind.Local).AddTicks(6737));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 27,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 35, 960, DateTimeKind.Local).AddTicks(6742));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 28,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 35, 960, DateTimeKind.Local).AddTicks(6746));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 29,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 35, 960, DateTimeKind.Local).AddTicks(6750));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 30,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 35, 960, DateTimeKind.Local).AddTicks(6755));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 31,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 35, 960, DateTimeKind.Local).AddTicks(6759));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 32,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 35, 960, DateTimeKind.Local).AddTicks(6763));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 33,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 35, 960, DateTimeKind.Local).AddTicks(6767));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 34,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 35, 960, DateTimeKind.Local).AddTicks(6773));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 35,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 35, 960, DateTimeKind.Local).AddTicks(6777));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 36,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 35, 960, DateTimeKind.Local).AddTicks(6781));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 37,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 35, 960, DateTimeKind.Local).AddTicks(6785));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 38,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 35, 960, DateTimeKind.Local).AddTicks(6789));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 39,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 35, 960, DateTimeKind.Local).AddTicks(6792));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 40,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 35, 960, DateTimeKind.Local).AddTicks(6796));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 41,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 35, 960, DateTimeKind.Local).AddTicks(6801));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 42,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 35, 960, DateTimeKind.Local).AddTicks(6804));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 43,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 35, 960, DateTimeKind.Local).AddTicks(6809));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 44,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 35, 960, DateTimeKind.Local).AddTicks(6813));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 45,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 35, 960, DateTimeKind.Local).AddTicks(6817));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 46,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 35, 960, DateTimeKind.Local).AddTicks(6857));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 47,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 35, 960, DateTimeKind.Local).AddTicks(6862));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 48,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 35, 960, DateTimeKind.Local).AddTicks(6866));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 49,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 35, 960, DateTimeKind.Local).AddTicks(6869));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 50,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 35, 960, DateTimeKind.Local).AddTicks(6874));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 51,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 35, 960, DateTimeKind.Local).AddTicks(6878));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 52,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 35, 960, DateTimeKind.Local).AddTicks(6883));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 53,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 35, 960, DateTimeKind.Local).AddTicks(6887));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 54,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 35, 960, DateTimeKind.Local).AddTicks(6891));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 55,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 35, 960, DateTimeKind.Local).AddTicks(6896));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 56,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 35, 960, DateTimeKind.Local).AddTicks(6900));

            migrationBuilder.UpdateData(
                table: "PriorityRanks",
                keyColumn: "PriorityRankID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 36, 280, DateTimeKind.Local).AddTicks(5301));

            migrationBuilder.UpdateData(
                table: "PriorityRanks",
                keyColumn: "PriorityRankID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 36, 280, DateTimeKind.Local).AddTicks(5419));

            migrationBuilder.UpdateData(
                table: "PriorityRanks",
                keyColumn: "PriorityRankID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 36, 280, DateTimeKind.Local).AddTicks(5423));

            migrationBuilder.UpdateData(
                table: "PriorityRanks",
                keyColumn: "PriorityRankID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 36, 280, DateTimeKind.Local).AddTicks(5426));

            migrationBuilder.UpdateData(
                table: "ProductFrequencies",
                keyColumn: "ProductFrequencyID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 35, 976, DateTimeKind.Local).AddTicks(5501));

            migrationBuilder.UpdateData(
                table: "ProductFrequencies",
                keyColumn: "ProductFrequencyID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 35, 976, DateTimeKind.Local).AddTicks(6676));

            migrationBuilder.UpdateData(
                table: "ProductFrequencies",
                keyColumn: "ProductFrequencyID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 35, 976, DateTimeKind.Local).AddTicks(6687));

            migrationBuilder.UpdateData(
                table: "ProductFrequencies",
                keyColumn: "ProductFrequencyID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 35, 976, DateTimeKind.Local).AddTicks(6699));

            migrationBuilder.UpdateData(
                table: "ProductFrequencies",
                keyColumn: "ProductFrequencyID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 35, 976, DateTimeKind.Local).AddTicks(6704));

            migrationBuilder.UpdateData(
                table: "RelationshipTypes",
                keyColumn: "RelationshipTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 35, 982, DateTimeKind.Local).AddTicks(7038));

            migrationBuilder.UpdateData(
                table: "RelationshipTypes",
                keyColumn: "RelationshipTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 35, 982, DateTimeKind.Local).AddTicks(7133));

            migrationBuilder.UpdateData(
                table: "RelationshipTypes",
                keyColumn: "RelationshipTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 35, 982, DateTimeKind.Local).AddTicks(7137));

            migrationBuilder.UpdateData(
                table: "RelationshipTypes",
                keyColumn: "RelationshipTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 35, 982, DateTimeKind.Local).AddTicks(7139));

            migrationBuilder.UpdateData(
                table: "RelationshipTypes",
                keyColumn: "RelationshipTypeID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 35, 982, DateTimeKind.Local).AddTicks(7141));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 35, 961, DateTimeKind.Local).AddTicks(5199));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 35, 961, DateTimeKind.Local).AddTicks(5325));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 35, 961, DateTimeKind.Local).AddTicks(5328));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 35, 961, DateTimeKind.Local).AddTicks(5330));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 35, 961, DateTimeKind.Local).AddTicks(5332));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 35, 961, DateTimeKind.Local).AddTicks(5337));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 35, 961, DateTimeKind.Local).AddTicks(5339));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 35, 961, DateTimeKind.Local).AddTicks(5341));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 35, 961, DateTimeKind.Local).AddTicks(5342));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 35, 961, DateTimeKind.Local).AddTicks(5346));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 35, 961, DateTimeKind.Local).AddTicks(5347));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 35, 961, DateTimeKind.Local).AddTicks(5349));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 13,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 35, 961, DateTimeKind.Local).AddTicks(5351));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 14,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 35, 961, DateTimeKind.Local).AddTicks(5353));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 15,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 35, 961, DateTimeKind.Local).AddTicks(5354));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 16,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 35, 961, DateTimeKind.Local).AddTicks(5356));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 17,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 35, 961, DateTimeKind.Local).AddTicks(5358));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 18,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 35, 961, DateTimeKind.Local).AddTicks(5361));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 19,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 35, 961, DateTimeKind.Local).AddTicks(5363));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 20,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 35, 961, DateTimeKind.Local).AddTicks(5365));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 21,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 35, 961, DateTimeKind.Local).AddTicks(5367));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 22,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 35, 961, DateTimeKind.Local).AddTicks(5369));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 23,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 35, 961, DateTimeKind.Local).AddTicks(5371));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 24,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 35, 961, DateTimeKind.Local).AddTicks(5372));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 25,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 35, 961, DateTimeKind.Local).AddTicks(5374));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 26,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 35, 961, DateTimeKind.Local).AddTicks(5376));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 27,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 35, 961, DateTimeKind.Local).AddTicks(5378));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 28,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 35, 961, DateTimeKind.Local).AddTicks(5379));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 29,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 35, 961, DateTimeKind.Local).AddTicks(5381));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 30,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 35, 961, DateTimeKind.Local).AddTicks(5383));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 31,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 35, 961, DateTimeKind.Local).AddTicks(5385));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 32,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 35, 961, DateTimeKind.Local).AddTicks(5386));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 33,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 35, 961, DateTimeKind.Local).AddTicks(5388));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 34,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 35, 961, DateTimeKind.Local).AddTicks(5391));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 35,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 35, 961, DateTimeKind.Local).AddTicks(5393));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 36,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 35, 961, DateTimeKind.Local).AddTicks(5395));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 37,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 35, 961, DateTimeKind.Local).AddTicks(5397));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 38,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 35, 961, DateTimeKind.Local).AddTicks(5398));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 39,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 35, 961, DateTimeKind.Local).AddTicks(5400));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 40,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 35, 961, DateTimeKind.Local).AddTicks(5402));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 41,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 35, 961, DateTimeKind.Local).AddTicks(5404));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 42,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 35, 961, DateTimeKind.Local).AddTicks(5405));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 43,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 35, 961, DateTimeKind.Local).AddTicks(5407));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 44,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 35, 961, DateTimeKind.Local).AddTicks(5409));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 45,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 35, 961, DateTimeKind.Local).AddTicks(5411));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 46,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 35, 961, DateTimeKind.Local).AddTicks(5413));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 47,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 35, 961, DateTimeKind.Local).AddTicks(5415));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 48,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 35, 961, DateTimeKind.Local).AddTicks(5416));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 49,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 35, 961, DateTimeKind.Local).AddTicks(5418));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 50,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 35, 961, DateTimeKind.Local).AddTicks(5420));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 51,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 35, 961, DateTimeKind.Local).AddTicks(5422));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 52,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 35, 961, DateTimeKind.Local).AddTicks(5423));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 53,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 35, 961, DateTimeKind.Local).AddTicks(5425));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 54,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 35, 961, DateTimeKind.Local).AddTicks(5427));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 55,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 35, 961, DateTimeKind.Local).AddTicks(5429));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 56,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 35, 961, DateTimeKind.Local).AddTicks(5430));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 35, 951, DateTimeKind.Local).AddTicks(9586));

            migrationBuilder.UpdateData(
                table: "SystemVariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 35, 984, DateTimeKind.Local).AddTicks(8773));

            migrationBuilder.UpdateData(
                table: "SystemVariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 35, 984, DateTimeKind.Local).AddTicks(8919));

            migrationBuilder.UpdateData(
                table: "SystemVariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 35, 984, DateTimeKind.Local).AddTicks(8915));

            migrationBuilder.UpdateData(
                table: "SystemVariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 35, 984, DateTimeKind.Local).AddTicks(8911));

            migrationBuilder.UpdateData(
                table: "SystemVariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 35, 984, DateTimeKind.Local).AddTicks(8905));

            migrationBuilder.UpdateData(
                table: "SystemVariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 35, 984, DateTimeKind.Local).AddTicks(8929));

            migrationBuilder.UpdateData(
                table: "SystemVariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 35, 984, DateTimeKind.Local).AddTicks(8939));

            migrationBuilder.UpdateData(
                table: "SystemVariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 35, 984, DateTimeKind.Local).AddTicks(8944));

            migrationBuilder.UpdateData(
                table: "SystemVariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 35, 984, DateTimeKind.Local).AddTicks(8948));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 35, 967, DateTimeKind.Local).AddTicks(1740));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 35, 967, DateTimeKind.Local).AddTicks(2177));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 35, 967, DateTimeKind.Local).AddTicks(2184));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 35, 967, DateTimeKind.Local).AddTicks(2187));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 35, 967, DateTimeKind.Local).AddTicks(2191));

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumns: new[] { "UserID", "RoleID" },
                keyValues: new object[] { 1, 1 },
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 36, 296, DateTimeKind.Local).AddTicks(1691));

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumns: new[] { "UserID", "RoleID" },
                keyValues: new object[] { 2, 1 },
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 36, 296, DateTimeKind.Local).AddTicks(1818));

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "UserTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 35, 980, DateTimeKind.Local).AddTicks(7265));

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "UserTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 35, 980, DateTimeKind.Local).AddTicks(7847));

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "UserTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 35, 980, DateTimeKind.Local).AddTicks(7856));

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "UserTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 35, 980, DateTimeKind.Local).AddTicks(7860));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 36, 281, DateTimeKind.Local).AddTicks(1865));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 36, 283, DateTimeKind.Local).AddTicks(5092));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 36, 283, DateTimeKind.Local).AddTicks(5296));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2020, 9, 12, 17, 16, 36, 283, DateTimeKind.Local).AddTicks(5305));
        }
    }
}
