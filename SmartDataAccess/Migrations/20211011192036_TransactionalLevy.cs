using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SmartDataAccess.Migrations
{
    public partial class TransactionalLevy : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "TransactionalLevy",
                table: "Products",
                type: "decimal(18,2)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "TransactionalLevy",
                table: "ProductHistory",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.UpdateData(
                table: "BankAccountTypes",
                keyColumn: "BankAccountTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 192, DateTimeKind.Local).AddTicks(6671));

            migrationBuilder.UpdateData(
                table: "BankAccountTypes",
                keyColumn: "BankAccountTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 192, DateTimeKind.Local).AddTicks(7238));

            migrationBuilder.UpdateData(
                table: "BankAccountTypes",
                keyColumn: "BankAccountTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 192, DateTimeKind.Local).AddTicks(7248));

            migrationBuilder.UpdateData(
                table: "BankAccountTypes",
                keyColumn: "BankAccountTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 192, DateTimeKind.Local).AddTicks(7253));

            migrationBuilder.UpdateData(
                table: "ClientAccountTypes",
                keyColumn: "ID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 267, DateTimeKind.Local).AddTicks(4899));

            migrationBuilder.UpdateData(
                table: "ClientAccountTypes",
                keyColumn: "ID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 267, DateTimeKind.Local).AddTicks(5673));

            migrationBuilder.UpdateData(
                table: "ClientGroups",
                keyColumn: "ClientGroupID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 273, DateTimeKind.Local).AddTicks(7424));

            migrationBuilder.UpdateData(
                table: "ClientGroups",
                keyColumn: "ClientGroupID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 273, DateTimeKind.Local).AddTicks(8007));

            migrationBuilder.UpdateData(
                table: "ContactTypes",
                keyColumn: "ContactTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 205, DateTimeKind.Local).AddTicks(4827));

            migrationBuilder.UpdateData(
                table: "ContactTypes",
                keyColumn: "ContactTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 205, DateTimeKind.Local).AddTicks(4821));

            migrationBuilder.UpdateData(
                table: "ContactTypes",
                keyColumn: "ContactTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 205, DateTimeKind.Local).AddTicks(4812));

            migrationBuilder.UpdateData(
                table: "ContactTypes",
                keyColumn: "ContactTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 205, DateTimeKind.Local).AddTicks(4603));

            migrationBuilder.UpdateData(
                table: "ContactTypes",
                keyColumn: "ContactTypeID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 205, DateTimeKind.Local).AddTicks(4831));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(2498));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(3510));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(3531));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(3546));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(3553));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(3575));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(3580));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(3588));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(3593));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(3599));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(3608));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(3613));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 13,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(3618));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 14,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(3622));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 15,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(3627));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 16,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(3634));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 17,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(3639));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 18,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(3647));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 19,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(3653));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 20,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(3659));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 21,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(3663));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 22,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(3668));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 23,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(3672));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 24,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(3677));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 25,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(3682));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 26,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(3686));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 27,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(3692));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 28,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(3697));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 29,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(3702));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 30,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(3709));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 31,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(3713));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 32,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(3718));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 33,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(3724));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 34,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(3755));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 35,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(3763));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 36,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(3767));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 37,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(3771));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 38,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(3776));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 39,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(3782));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 40,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(3788));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 41,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(3795));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 42,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(3799));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 43,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(3803));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 44,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(3807));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 45,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(3812));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 46,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(3816));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 47,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(3822));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 48,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(3828));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 49,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(3833));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 50,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(3839));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 51,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(3844));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 52,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(3849));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 53,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(3853));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 54,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(3858));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 55,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(3862));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 56,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(3867));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 57,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(3871));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 58,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(3880));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 59,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(3886));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 60,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(3891));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 61,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(3896));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 62,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(3901));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 63,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(3906));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 64,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(3912));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 65,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(3917));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 66,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(3925));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 67,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(3929));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 68,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(3939));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 69,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(3943));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 70,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(3948));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 71,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(3952));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 72,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(3959));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 73,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(3965));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 74,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(3970));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 75,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(3974));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 76,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(3979));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 77,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(3984));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 78,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(3988));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 79,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(3992));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 80,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(3996));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 81,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(4000));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 82,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(4005));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 83,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(4012));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 84,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(4017));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 85,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(4021));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 86,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(4026));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 87,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(4031));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 88,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(4036));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 89,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(4041));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 90,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(4046));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 91,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(4050));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 92,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(4055));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 93,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(4071));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 94,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(4076));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 95,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(4081));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 96,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(4085));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 97,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(4093));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 98,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(4097));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 99,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(4101));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 100,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(4106));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 101,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(4113));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 102,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(4118));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 103,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(4122));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 104,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(4126));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 105,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(4131));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 106,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(4135));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 107,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(4140));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 108,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(4145));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 109,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(4149));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 110,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(4154));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 111,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(4160));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 112,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(4167));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 113,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(4171));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 114,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(4176));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 115,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(4181));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 116,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(4186));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 117,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(4190));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 118,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(4195));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 119,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(4199));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 120,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(4205));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 121,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(4212));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 122,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(4216));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 123,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(4221));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 124,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(4225));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 125,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(4230));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 126,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(4234));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 127,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(4238));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 128,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(4242));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 129,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(4248));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 130,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(4257));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 131,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(4261));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 132,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(4267));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 133,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(4272));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 134,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(4276));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 135,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(4280));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 136,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(4285));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 137,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(4290));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 138,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(4297));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 139,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(4302));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 140,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(4306));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 141,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(4311));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 142,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(4315));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 143,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(4320));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 144,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(4326));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 145,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(4330));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 146,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(4341));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 147,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(4345));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 148,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(4349));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 149,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(4368));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 150,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(4374));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 151,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(4380));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 152,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(4388));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 153,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(4392));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 154,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(4397));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 155,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(4403));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 156,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(4407));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 157,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(4412));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 158,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(4417));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 159,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(4421));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 160,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(4425));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 161,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(4431));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 162,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(4435));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 163,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(4440));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 164,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(4445));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 165,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(4450));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 166,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(4455));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 167,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(4460));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 168,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(4465));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 169,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(4469));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 170,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(4473));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 171,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(4477));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 172,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(4482));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 173,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(4488));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 174,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(4494));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 175,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(4499));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 176,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(4505));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 177,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(4514));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 178,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(4519));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 179,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(4525));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 180,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(4531));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 181,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(4538));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 182,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(4542));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 183,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(4547));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 184,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(4551));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 185,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(4556));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 186,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(4560));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 187,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(4565));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 188,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(4569));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 189,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(4575));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 190,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(4580));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 191,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(4585));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 192,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(4590));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 193,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(4595));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 194,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(4600));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 195,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(4605));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 196,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(4610));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 197,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(4614));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 198,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(4618));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 199,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(4623));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 200,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(4628));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 201,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(4632));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 202,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(4643));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 203,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(4648));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 204,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(4652));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 205,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(4657));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 206,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(4662));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 207,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(4667));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 208,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(4672));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 209,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(4677));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 210,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(4683));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 211,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(4687));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 212,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(4692));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 213,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(4697));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 214,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(4702));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 215,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(4707));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 216,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(4726));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 217,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(4732));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 218,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(4737));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 219,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(4741));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 220,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(4745));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 221,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(4750));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 222,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(4755));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 223,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(4761));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 224,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(4766));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 225,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(4771));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 226,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(4776));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 227,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(4781));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 228,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 214, DateTimeKind.Local).AddTicks(4785));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 195, DateTimeKind.Local).AddTicks(6797));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 195, DateTimeKind.Local).AddTicks(7892));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 195, DateTimeKind.Local).AddTicks(7946));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 195, DateTimeKind.Local).AddTicks(7953));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 195, DateTimeKind.Local).AddTicks(7960));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 195, DateTimeKind.Local).AddTicks(7990));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 195, DateTimeKind.Local).AddTicks(7996));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 195, DateTimeKind.Local).AddTicks(8002));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 195, DateTimeKind.Local).AddTicks(8007));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 195, DateTimeKind.Local).AddTicks(8015));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 195, DateTimeKind.Local).AddTicks(8020));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 195, DateTimeKind.Local).AddTicks(8026));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 13,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 195, DateTimeKind.Local).AddTicks(8031));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 14,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 195, DateTimeKind.Local).AddTicks(8036));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 15,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 195, DateTimeKind.Local).AddTicks(8042));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 16,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 195, DateTimeKind.Local).AddTicks(8047));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 17,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 195, DateTimeKind.Local).AddTicks(8052));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 18,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 195, DateTimeKind.Local).AddTicks(8060));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 19,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 195, DateTimeKind.Local).AddTicks(8066));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 20,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 195, DateTimeKind.Local).AddTicks(8071));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 21,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 195, DateTimeKind.Local).AddTicks(8077));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 22,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 195, DateTimeKind.Local).AddTicks(8082));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 23,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 195, DateTimeKind.Local).AddTicks(8088));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 24,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 195, DateTimeKind.Local).AddTicks(8093));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 25,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 195, DateTimeKind.Local).AddTicks(8098));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 26,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 195, DateTimeKind.Local).AddTicks(8103));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 27,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 195, DateTimeKind.Local).AddTicks(8108));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 28,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 195, DateTimeKind.Local).AddTicks(8113));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 29,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 195, DateTimeKind.Local).AddTicks(8119));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 30,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 195, DateTimeKind.Local).AddTicks(8124));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 31,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 195, DateTimeKind.Local).AddTicks(8129));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 32,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 195, DateTimeKind.Local).AddTicks(8135));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 33,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 195, DateTimeKind.Local).AddTicks(8140));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 34,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 195, DateTimeKind.Local).AddTicks(8148));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 35,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 195, DateTimeKind.Local).AddTicks(8153));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 36,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 195, DateTimeKind.Local).AddTicks(8159));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 37,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 195, DateTimeKind.Local).AddTicks(8163));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 38,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 195, DateTimeKind.Local).AddTicks(8169));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 39,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 195, DateTimeKind.Local).AddTicks(8174));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 40,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 195, DateTimeKind.Local).AddTicks(8179));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 41,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 195, DateTimeKind.Local).AddTicks(8185));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 42,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 195, DateTimeKind.Local).AddTicks(8191));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 43,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 195, DateTimeKind.Local).AddTicks(8196));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 44,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 195, DateTimeKind.Local).AddTicks(8202));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 45,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 195, DateTimeKind.Local).AddTicks(8207));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 46,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 195, DateTimeKind.Local).AddTicks(8213));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 47,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 195, DateTimeKind.Local).AddTicks(8218));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 48,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 195, DateTimeKind.Local).AddTicks(8223));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 49,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 195, DateTimeKind.Local).AddTicks(8228));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 50,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 195, DateTimeKind.Local).AddTicks(8233));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 51,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 195, DateTimeKind.Local).AddTicks(8239));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 52,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 195, DateTimeKind.Local).AddTicks(8244));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 53,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 195, DateTimeKind.Local).AddTicks(8249));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 54,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 195, DateTimeKind.Local).AddTicks(8254));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 55,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 195, DateTimeKind.Local).AddTicks(8259));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 56,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 195, DateTimeKind.Local).AddTicks(8264));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 57,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 195, DateTimeKind.Local).AddTicks(8269));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 58,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 195, DateTimeKind.Local).AddTicks(8274));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 59,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 195, DateTimeKind.Local).AddTicks(8280));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 60,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 195, DateTimeKind.Local).AddTicks(8285));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 61,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 195, DateTimeKind.Local).AddTicks(8290));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 62,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 195, DateTimeKind.Local).AddTicks(8296));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 63,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 195, DateTimeKind.Local).AddTicks(8301));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 64,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 195, DateTimeKind.Local).AddTicks(8306));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 65,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 195, DateTimeKind.Local).AddTicks(8311));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 66,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 195, DateTimeKind.Local).AddTicks(8356));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 67,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 195, DateTimeKind.Local).AddTicks(8362));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 68,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 195, DateTimeKind.Local).AddTicks(8367));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 69,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 195, DateTimeKind.Local).AddTicks(8372));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 70,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 195, DateTimeKind.Local).AddTicks(8377));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 71,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 195, DateTimeKind.Local).AddTicks(8382));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 72,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 195, DateTimeKind.Local).AddTicks(8387));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 73,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 195, DateTimeKind.Local).AddTicks(8392));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 74,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 195, DateTimeKind.Local).AddTicks(8398));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 75,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 195, DateTimeKind.Local).AddTicks(8403));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 76,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 195, DateTimeKind.Local).AddTicks(8408));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 77,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 195, DateTimeKind.Local).AddTicks(8413));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 78,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 195, DateTimeKind.Local).AddTicks(8418));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 79,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 195, DateTimeKind.Local).AddTicks(8423));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 80,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 195, DateTimeKind.Local).AddTicks(8428));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 81,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 195, DateTimeKind.Local).AddTicks(8433));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 82,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 195, DateTimeKind.Local).AddTicks(8440));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 83,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 195, DateTimeKind.Local).AddTicks(8445));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 84,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 195, DateTimeKind.Local).AddTicks(8451));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 85,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 195, DateTimeKind.Local).AddTicks(8456));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 86,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 195, DateTimeKind.Local).AddTicks(8461));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 87,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 195, DateTimeKind.Local).AddTicks(8466));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 88,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 195, DateTimeKind.Local).AddTicks(8471));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 89,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 195, DateTimeKind.Local).AddTicks(8476));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 90,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 195, DateTimeKind.Local).AddTicks(8481));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 91,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 195, DateTimeKind.Local).AddTicks(8486));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 92,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 195, DateTimeKind.Local).AddTicks(8491));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 93,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 195, DateTimeKind.Local).AddTicks(8496));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 94,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 195, DateTimeKind.Local).AddTicks(8502));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 95,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 195, DateTimeKind.Local).AddTicks(8507));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 96,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 195, DateTimeKind.Local).AddTicks(8512));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 97,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 195, DateTimeKind.Local).AddTicks(8517));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 98,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 195, DateTimeKind.Local).AddTicks(8522));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 99,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 195, DateTimeKind.Local).AddTicks(8527));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 100,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 195, DateTimeKind.Local).AddTicks(8532));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 101,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 195, DateTimeKind.Local).AddTicks(8537));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 102,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 195, DateTimeKind.Local).AddTicks(8544));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 103,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 195, DateTimeKind.Local).AddTicks(8549));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 104,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 195, DateTimeKind.Local).AddTicks(8554));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 105,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 195, DateTimeKind.Local).AddTicks(8559));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 106,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 195, DateTimeKind.Local).AddTicks(8564));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 107,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 195, DateTimeKind.Local).AddTicks(8569));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 108,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 195, DateTimeKind.Local).AddTicks(8574));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 109,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 195, DateTimeKind.Local).AddTicks(8579));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 110,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 195, DateTimeKind.Local).AddTicks(8584));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 111,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 195, DateTimeKind.Local).AddTicks(8589));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 112,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 195, DateTimeKind.Local).AddTicks(8595));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 113,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 195, DateTimeKind.Local).AddTicks(8600));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 114,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 195, DateTimeKind.Local).AddTicks(8606));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 115,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 195, DateTimeKind.Local).AddTicks(8611));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 116,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 195, DateTimeKind.Local).AddTicks(8616));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 117,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 195, DateTimeKind.Local).AddTicks(8621));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 118,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 195, DateTimeKind.Local).AddTicks(8626));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 119,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 195, DateTimeKind.Local).AddTicks(8631));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 120,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 195, DateTimeKind.Local).AddTicks(8636));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 121,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 195, DateTimeKind.Local).AddTicks(8641));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 122,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 195, DateTimeKind.Local).AddTicks(8646));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 123,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 195, DateTimeKind.Local).AddTicks(8652));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 124,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 195, DateTimeKind.Local).AddTicks(8657));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 125,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 195, DateTimeKind.Local).AddTicks(8662));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 126,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 195, DateTimeKind.Local).AddTicks(8667));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 127,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 195, DateTimeKind.Local).AddTicks(8672));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 128,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 195, DateTimeKind.Local).AddTicks(8677));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 129,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 195, DateTimeKind.Local).AddTicks(8682));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 130,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 195, DateTimeKind.Local).AddTicks(8702));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 131,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 195, DateTimeKind.Local).AddTicks(8707));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 132,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 195, DateTimeKind.Local).AddTicks(8712));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 133,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 195, DateTimeKind.Local).AddTicks(8717));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 134,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 195, DateTimeKind.Local).AddTicks(8722));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 135,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 195, DateTimeKind.Local).AddTicks(8727));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 136,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 195, DateTimeKind.Local).AddTicks(8732));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 137,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 195, DateTimeKind.Local).AddTicks(8737));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 138,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 195, DateTimeKind.Local).AddTicks(8742));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 139,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 195, DateTimeKind.Local).AddTicks(8747));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 140,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 195, DateTimeKind.Local).AddTicks(8752));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 141,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 195, DateTimeKind.Local).AddTicks(8757));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 142,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 195, DateTimeKind.Local).AddTicks(8762));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 143,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 195, DateTimeKind.Local).AddTicks(8768));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 144,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 195, DateTimeKind.Local).AddTicks(8773));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 145,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 195, DateTimeKind.Local).AddTicks(8778));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 146,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 195, DateTimeKind.Local).AddTicks(8783));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 147,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 195, DateTimeKind.Local).AddTicks(8788));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 148,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 195, DateTimeKind.Local).AddTicks(8793));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 149,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 195, DateTimeKind.Local).AddTicks(8798));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 150,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 195, DateTimeKind.Local).AddTicks(8803));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 151,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 195, DateTimeKind.Local).AddTicks(8808));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 152,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 195, DateTimeKind.Local).AddTicks(8813));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 153,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 195, DateTimeKind.Local).AddTicks(8818));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 154,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 195, DateTimeKind.Local).AddTicks(8823));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 155,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 195, DateTimeKind.Local).AddTicks(8829));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 156,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 195, DateTimeKind.Local).AddTicks(8834));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 157,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 195, DateTimeKind.Local).AddTicks(8838));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 158,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 195, DateTimeKind.Local).AddTicks(8844));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 159,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 195, DateTimeKind.Local).AddTicks(8849));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 160,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 195, DateTimeKind.Local).AddTicks(8854));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 161,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 195, DateTimeKind.Local).AddTicks(8859));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 162,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 195, DateTimeKind.Local).AddTicks(8864));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 252, DateTimeKind.Local).AddTicks(7487));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 252, DateTimeKind.Local).AddTicks(7729));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 252, DateTimeKind.Local).AddTicks(7773));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 252, DateTimeKind.Local).AddTicks(7742));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 252, DateTimeKind.Local).AddTicks(7780));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 252, DateTimeKind.Local).AddTicks(7792));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 252, DateTimeKind.Local).AddTicks(7798));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 252, DateTimeKind.Local).AddTicks(7804));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 252, DateTimeKind.Local).AddTicks(7810));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 252, DateTimeKind.Local).AddTicks(7815));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 252, DateTimeKind.Local).AddTicks(7869));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 252, DateTimeKind.Local).AddTicks(7875));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 13,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 252, DateTimeKind.Local).AddTicks(7880));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 14,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 252, DateTimeKind.Local).AddTicks(7886));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 15,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 252, DateTimeKind.Local).AddTicks(7750));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 16,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 252, DateTimeKind.Local).AddTicks(7719));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 17,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 252, DateTimeKind.Local).AddTicks(8038));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 18,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 252, DateTimeKind.Local).AddTicks(8046));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 19,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 252, DateTimeKind.Local).AddTicks(8055));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 20,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 252, DateTimeKind.Local).AddTicks(8064));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 22,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 252, DateTimeKind.Local).AddTicks(8100));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 23,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 252, DateTimeKind.Local).AddTicks(8083));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 24,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 252, DateTimeKind.Local).AddTicks(8074));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 25,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 252, DateTimeKind.Local).AddTicks(8092));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 26,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 252, DateTimeKind.Local).AddTicks(8110));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 27,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 252, DateTimeKind.Local).AddTicks(8119));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 28,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 252, DateTimeKind.Local).AddTicks(8128));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 30,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 252, DateTimeKind.Local).AddTicks(8138));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 31,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 252, DateTimeKind.Local).AddTicks(8147));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 32,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 252, DateTimeKind.Local).AddTicks(8155));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 33,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 252, DateTimeKind.Local).AddTicks(8164));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 34,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 252, DateTimeKind.Local).AddTicks(8172));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 36,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 252, DateTimeKind.Local).AddTicks(8181));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 37,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 252, DateTimeKind.Local).AddTicks(8189));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 38,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 252, DateTimeKind.Local).AddTicks(8197));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 39,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 252, DateTimeKind.Local).AddTicks(7786));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 40,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 252, DateTimeKind.Local).AddTicks(8206));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 41,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 252, DateTimeKind.Local).AddTicks(8213));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 42,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 252, DateTimeKind.Local).AddTicks(8221));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 43,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 252, DateTimeKind.Local).AddTicks(8229));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 44,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 252, DateTimeKind.Local).AddTicks(8237));

            migrationBuilder.UpdateData(
                table: "DeductionTypes",
                keyColumn: "DeductionTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 284, DateTimeKind.Local).AddTicks(9556));

            migrationBuilder.UpdateData(
                table: "DeductionTypes",
                keyColumn: "DeductionTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 285, DateTimeKind.Local).AddTicks(241));

            migrationBuilder.UpdateData(
                table: "DeductionTypes",
                keyColumn: "DeductionTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 285, DateTimeKind.Local).AddTicks(258));

            migrationBuilder.UpdateData(
                table: "DocumentFormats",
                keyColumn: "DocumentFormatID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 229, DateTimeKind.Local).AddTicks(3137));

            migrationBuilder.UpdateData(
                table: "DocumentFormats",
                keyColumn: "DocumentFormatID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 229, DateTimeKind.Local).AddTicks(3797));

            migrationBuilder.UpdateData(
                table: "DocumentFormats",
                keyColumn: "DocumentFormatID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 229, DateTimeKind.Local).AddTicks(3811));

            migrationBuilder.UpdateData(
                table: "DocumentFormats",
                keyColumn: "DocumentFormatID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 229, DateTimeKind.Local).AddTicks(3819));

            migrationBuilder.UpdateData(
                table: "DocumentFormats",
                keyColumn: "DocumentFormatID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 229, DateTimeKind.Local).AddTicks(3860));

            migrationBuilder.UpdateData(
                table: "DocumentFormats",
                keyColumn: "DocumentFormatID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 229, DateTimeKind.Local).AddTicks(3873));

            migrationBuilder.UpdateData(
                table: "DocumentTypes",
                keyColumn: "DocumentTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 232, DateTimeKind.Local).AddTicks(9551));

            migrationBuilder.UpdateData(
                table: "DocumentTypes",
                keyColumn: "DocumentTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 233, DateTimeKind.Local).AddTicks(700));

            migrationBuilder.UpdateData(
                table: "DocumentTypes",
                keyColumn: "DocumentTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 233, DateTimeKind.Local).AddTicks(732));

            migrationBuilder.UpdateData(
                table: "DocumentTypes",
                keyColumn: "DocumentTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 233, DateTimeKind.Local).AddTicks(738));

            migrationBuilder.UpdateData(
                table: "EmailTemplates",
                keyColumn: "EmailTemplateID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 247, DateTimeKind.Local).AddTicks(2953));

            migrationBuilder.UpdateData(
                table: "EmailTypes",
                keyColumn: "EmailTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 246, DateTimeKind.Local).AddTicks(5928));

            migrationBuilder.UpdateData(
                table: "EmailTypes",
                keyColumn: "EmailTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 246, DateTimeKind.Local).AddTicks(6577));

            migrationBuilder.UpdateData(
                table: "EmailTypes",
                keyColumn: "EmailTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 246, DateTimeKind.Local).AddTicks(6587));

            migrationBuilder.UpdateData(
                table: "EmailTypes",
                keyColumn: "EmailTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 246, DateTimeKind.Local).AddTicks(6596));

            migrationBuilder.UpdateData(
                table: "FeatureFlags",
                keyColumn: "FeatureFlagID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 225, DateTimeKind.Local).AddTicks(8845));

            migrationBuilder.UpdateData(
                table: "FeatureFlags",
                keyColumn: "FeatureFlagID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 225, DateTimeKind.Local).AddTicks(9528));

            migrationBuilder.UpdateData(
                table: "FeatureFlags",
                keyColumn: "FeatureFlagID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 225, DateTimeKind.Local).AddTicks(9546));

            migrationBuilder.UpdateData(
                table: "Frequencies",
                keyColumn: "FrequencyID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 200, DateTimeKind.Local).AddTicks(1537));

            migrationBuilder.UpdateData(
                table: "Frequencies",
                keyColumn: "FrequencyID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 200, DateTimeKind.Local).AddTicks(2262));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "GenderID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 210, DateTimeKind.Local).AddTicks(8044));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "GenderID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 210, DateTimeKind.Local).AddTicks(8196));

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "InvoiceStatusID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 276, DateTimeKind.Local).AddTicks(6926));

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "InvoiceStatusID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 276, DateTimeKind.Local).AddTicks(8324));

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "InvoiceStatusID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 276, DateTimeKind.Local).AddTicks(8409));

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "InvoiceStatusID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 276, DateTimeKind.Local).AddTicks(8417));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 282, DateTimeKind.Local).AddTicks(4168));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 282, DateTimeKind.Local).AddTicks(4385));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 282, DateTimeKind.Local).AddTicks(4392));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 282, DateTimeKind.Local).AddTicks(4398));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 282, DateTimeKind.Local).AddTicks(4404));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 282, DateTimeKind.Local).AddTicks(4418));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 282, DateTimeKind.Local).AddTicks(4423));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 282, DateTimeKind.Local).AddTicks(4427));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 282, DateTimeKind.Local).AddTicks(4431));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 282, DateTimeKind.Local).AddTicks(4438));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 282, DateTimeKind.Local).AddTicks(4442));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 282, DateTimeKind.Local).AddTicks(4446));

            migrationBuilder.UpdateData(
                table: "Layouts",
                keyColumn: "LayoutID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 280, DateTimeKind.Local).AddTicks(7978));

            migrationBuilder.UpdateData(
                table: "Layouts",
                keyColumn: "LayoutID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 280, DateTimeKind.Local).AddTicks(8533));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 236, DateTimeKind.Local).AddTicks(1243));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 236, DateTimeKind.Local).AddTicks(1578));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 236, DateTimeKind.Local).AddTicks(1597));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 236, DateTimeKind.Local).AddTicks(1607));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 236, DateTimeKind.Local).AddTicks(1614));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 236, DateTimeKind.Local).AddTicks(1650));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 999,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 236, DateTimeKind.Local).AddTicks(1644));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 9998,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 236, DateTimeKind.Local).AddTicks(1636));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 239, DateTimeKind.Local).AddTicks(7750));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 239, DateTimeKind.Local).AddTicks(8036));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 239, DateTimeKind.Local).AddTicks(8046));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 239, DateTimeKind.Local).AddTicks(8052));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 239, DateTimeKind.Local).AddTicks(8057));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 239, DateTimeKind.Local).AddTicks(8069));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 239, DateTimeKind.Local).AddTicks(8074));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 239, DateTimeKind.Local).AddTicks(8079));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 239, DateTimeKind.Local).AddTicks(8084));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 239, DateTimeKind.Local).AddTicks(8090));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 239, DateTimeKind.Local).AddTicks(8096));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 13,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 239, DateTimeKind.Local).AddTicks(8101));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 14,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 239, DateTimeKind.Local).AddTicks(8105));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 15,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 239, DateTimeKind.Local).AddTicks(8110));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 16,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 239, DateTimeKind.Local).AddTicks(8115));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 17,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 239, DateTimeKind.Local).AddTicks(8120));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 18,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 239, DateTimeKind.Local).AddTicks(8125));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 19,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 239, DateTimeKind.Local).AddTicks(8132));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 20,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 239, DateTimeKind.Local).AddTicks(8136));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 9994,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 239, DateTimeKind.Local).AddTicks(8141));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 9995,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 239, DateTimeKind.Local).AddTicks(8145));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 9996,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 239, DateTimeKind.Local).AddTicks(8149));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 9997,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 239, DateTimeKind.Local).AddTicks(8154));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 9998,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 239, DateTimeKind.Local).AddTicks(8158));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 9999,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 239, DateTimeKind.Local).AddTicks(8163));

            migrationBuilder.UpdateData(
                table: "PaymentStatus",
                keyColumn: "PaymentStatusID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 186, DateTimeKind.Local).AddTicks(1175));

            migrationBuilder.UpdateData(
                table: "PaymentStatus",
                keyColumn: "PaymentStatusID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 186, DateTimeKind.Local).AddTicks(1775));

            migrationBuilder.UpdateData(
                table: "PaymentStatus",
                keyColumn: "PaymentStatusID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 186, DateTimeKind.Local).AddTicks(1783));

            migrationBuilder.UpdateData(
                table: "PaymentStatus",
                keyColumn: "PaymentStatusID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 186, DateTimeKind.Local).AddTicks(1788));

            migrationBuilder.UpdateData(
                table: "PaymentStatus",
                keyColumn: "PaymentStatusID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 186, DateTimeKind.Local).AddTicks(1830));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(734));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(1310));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(1320));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(1325));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(1331));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(1359));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(1371));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(1375));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(1380));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(1387));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(1394));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(1398));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 13,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(1403));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 14,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(1408));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 15,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(1413));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 16,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(1418));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 17,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(1422));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 18,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(1429));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 19,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(1434));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 20,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(1439));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 21,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(1444));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 22,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(1448));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 23,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(1455));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 24,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(1460));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 25,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(1465));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 26,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(1470));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 27,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(1476));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 28,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(1481));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 29,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(1486));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 30,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(1490));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 31,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(1495));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 32,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(1500));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 33,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(1505));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 34,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(1512));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 35,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(1517));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 36,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(1523));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 37,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(1527));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 38,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(1532));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 39,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(1537));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 40,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(1541));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 41,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(1545));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 42,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(1550));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 43,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(1556));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 44,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(1560));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 45,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(1565));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 46,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(1581));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 47,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(1587));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 48,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(1591));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 49,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(1595));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 50,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(1600));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 51,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(1604));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 52,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(1609));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 53,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(1613));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 54,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(1618));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 55,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(1622));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 56,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(1627));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 57,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(1631));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 58,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(1636));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 59,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(1644));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 60,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(1648));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 61,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(1653));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 62,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(1657));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 63,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(1662));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 64,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(1666));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 65,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(1670));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 66,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(1677));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 67,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(1682));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 68,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(1686));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 69,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(1691));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 70,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(1695));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 71,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(1699));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 72,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(1704));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 73,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(1708));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 74,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(1713));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 75,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(1717));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 76,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(1722));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 77,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(1726));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 78,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(1731));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 79,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(1735));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 80,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(1740));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 81,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(1745));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 82,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(1749));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 83,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(1754));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 84,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(1759));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 85,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(1763));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 86,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(1779));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 87,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(1784));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 88,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(1788));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 89,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(1793));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 90,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(1797));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 91,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(1801));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 92,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(1806));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 93,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(1811));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 94,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(1816));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 95,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(1820));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 96,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(1825));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 97,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(1830));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 98,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(1835));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 99,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(1839));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 100,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(1844));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 101,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(1848));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 102,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(1852));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 103,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(1856));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 104,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(1861));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 105,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(1865));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 106,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(1870));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 107,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(1875));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 108,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(1880));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 109,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(1885));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 110,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(1890));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 111,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(1895));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 112,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(1899));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 113,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(1904));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 114,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(1909));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 115,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(1913));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 116,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(1918));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 117,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(1923));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 118,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(1927));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 119,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(1931));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 120,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(1936));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 121,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(1940));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 122,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(1945));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 123,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(1949));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 124,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(1954));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 125,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(1958));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 126,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(1963));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 127,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(1967));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 128,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(1971));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 129,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(1976));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 130,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(1992));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 131,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(1997));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 132,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(2003));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 133,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(2008));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 134,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(2013));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 135,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(2018));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 136,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(2023));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 137,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(2027));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 138,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(2032));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 139,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(2036));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 140,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(2040));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 141,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(2045));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 142,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(2050));

            migrationBuilder.UpdateData(
                table: "PriorityRanks",
                keyColumn: "PriorityRankID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 217, DateTimeKind.Local).AddTicks(8562));

            migrationBuilder.UpdateData(
                table: "PriorityRanks",
                keyColumn: "PriorityRankID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 217, DateTimeKind.Local).AddTicks(9256));

            migrationBuilder.UpdateData(
                table: "PriorityRanks",
                keyColumn: "PriorityRankID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 217, DateTimeKind.Local).AddTicks(9271));

            migrationBuilder.UpdateData(
                table: "PriorityRanks",
                keyColumn: "PriorityRankID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 217, DateTimeKind.Local).AddTicks(9276));

            migrationBuilder.UpdateData(
                table: "RecordStatus",
                keyColumn: "RecordStatusID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 270, DateTimeKind.Local).AddTicks(7985));

            migrationBuilder.UpdateData(
                table: "RecordStatus",
                keyColumn: "RecordStatusID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 270, DateTimeKind.Local).AddTicks(8679));

            migrationBuilder.UpdateData(
                table: "RecordStatus",
                keyColumn: "RecordStatusID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 270, DateTimeKind.Local).AddTicks(8693));

            migrationBuilder.UpdateData(
                table: "RelationshipTypes",
                keyColumn: "RelationshipTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 206, DateTimeKind.Local).AddTicks(4815));

            migrationBuilder.UpdateData(
                table: "RelationshipTypes",
                keyColumn: "RelationshipTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 206, DateTimeKind.Local).AddTicks(5090));

            migrationBuilder.UpdateData(
                table: "RelationshipTypes",
                keyColumn: "RelationshipTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 206, DateTimeKind.Local).AddTicks(5096));

            migrationBuilder.UpdateData(
                table: "RelationshipTypes",
                keyColumn: "RelationshipTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 206, DateTimeKind.Local).AddTicks(5099));

            migrationBuilder.UpdateData(
                table: "RelationshipTypes",
                keyColumn: "RelationshipTypeID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 206, DateTimeKind.Local).AddTicks(5102));

            migrationBuilder.UpdateData(
                table: "RelationshipTypes",
                keyColumn: "RelationshipTypeID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 206, DateTimeKind.Local).AddTicks(5111));

            migrationBuilder.UpdateData(
                table: "RelationshipTypes",
                keyColumn: "RelationshipTypeID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 206, DateTimeKind.Local).AddTicks(5114));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 253, DateTimeKind.Local).AddTicks(4990));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 253, DateTimeKind.Local).AddTicks(5111));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 253, DateTimeKind.Local).AddTicks(5118));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 253, DateTimeKind.Local).AddTicks(5120));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 253, DateTimeKind.Local).AddTicks(5122));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 253, DateTimeKind.Local).AddTicks(5128));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 253, DateTimeKind.Local).AddTicks(5130));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 253, DateTimeKind.Local).AddTicks(5132));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 253, DateTimeKind.Local).AddTicks(5135));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 253, DateTimeKind.Local).AddTicks(5139));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 253, DateTimeKind.Local).AddTicks(5141));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 253, DateTimeKind.Local).AddTicks(5143));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 13,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 253, DateTimeKind.Local).AddTicks(5145));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 14,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 253, DateTimeKind.Local).AddTicks(5147));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 15,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 253, DateTimeKind.Local).AddTicks(5149));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 16,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 253, DateTimeKind.Local).AddTicks(5151));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 17,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 253, DateTimeKind.Local).AddTicks(5153));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 18,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 253, DateTimeKind.Local).AddTicks(5157));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 19,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 253, DateTimeKind.Local).AddTicks(5160));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 20,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 253, DateTimeKind.Local).AddTicks(5162));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 21,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 253, DateTimeKind.Local).AddTicks(5164));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 22,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 253, DateTimeKind.Local).AddTicks(5166));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 23,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 253, DateTimeKind.Local).AddTicks(5168));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 24,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 253, DateTimeKind.Local).AddTicks(5170));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 25,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 253, DateTimeKind.Local).AddTicks(5172));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(8876));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(9069));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(9076));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(9078));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(9081));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(9089));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(9092));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(9094));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(9096));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(9100));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(9103));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(9106));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 13,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(9108));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 14,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(9111));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 15,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(9113));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 16,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(9117));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 17,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(9119));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 18,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(9123));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 19,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(9126));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 20,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(9128));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 21,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(9130));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 22,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(9132));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 23,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(9134));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 24,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(9136));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 25,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(9138));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 26,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(9140));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 27,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(9143));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 28,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(9144));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 29,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(9146));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 30,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(9150));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 31,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(9152));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 32,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(9154));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 33,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(9156));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 34,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(9159));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 35,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(9162));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 36,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(9164));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 37,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(9166));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 38,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(9169));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 39,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(9171));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 40,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(9173));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 41,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(9176));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 42,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(9178));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 43,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(9180));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 44,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(9182));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 45,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(9184));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 46,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(9187));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 47,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(9191));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 48,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(9193));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 49,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(9197));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 50,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(9231));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 51,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(9233));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 52,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(9236));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 53,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(9238));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 54,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(9240));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 55,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(9243));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 56,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(9246));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 57,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(9248));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 58,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(9250));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 59,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(9252));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 60,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(9257));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 61,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(9259));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 62,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(9261));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 63,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(9263));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 64,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(9265));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 65,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(9268));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 66,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(9274));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 67,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(9276));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 68,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(9278));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 69,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(9281));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 70,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(9283));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 71,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(9285));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 72,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(9288));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 73,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(9291));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 74,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(9293));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 75,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(9295));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 76,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(9297));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 77,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(9300));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 78,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(9304));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 79,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(9306));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 80,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(9308));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 81,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(9310));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 82,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(9313));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 83,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(9315));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 84,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(9316));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 85,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(9318));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 86,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(9321));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 87,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(9323));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 88,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(9325));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 89,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(9327));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 90,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(9329));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 91,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(9331));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 92,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(9333));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 93,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(9335));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 94,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(9337));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 95,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(9339));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 96,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(9341));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 97,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(9344));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 98,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(9346));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 99,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(9348));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 100,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(9350));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 101,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(9352));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 102,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(9354));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 103,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(9356));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 104,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(9358));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 105,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(9360));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 106,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(9362));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 107,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(9365));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 108,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(9367));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 109,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(9369));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 110,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(9372));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 111,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(9374));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 112,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(9376));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 113,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(9378));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 114,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(9381));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 115,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(9383));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 116,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(9385));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 117,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(9387));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 118,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(9389));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 119,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(9391));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 120,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(9393));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 121,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(9395));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 122,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(9397));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 123,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(9399));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 124,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(9402));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 125,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(9404));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 126,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(9406));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 127,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(9408));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 128,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(9410));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 129,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(9412));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 130,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(9432));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 131,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(9434));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 132,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(9440));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 133,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(9443));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 134,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(9445));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 135,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(9448));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 136,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(9450));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 137,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(9453));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 138,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(9455));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 139,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(9460));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 140,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(9463));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 141,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(9465));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 142,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 182, DateTimeKind.Local).AddTicks(9468));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 176, DateTimeKind.Local).AddTicks(6270));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 178, DateTimeKind.Local).AddTicks(1474));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 178, DateTimeKind.Local).AddTicks(1563));

            migrationBuilder.UpdateData(
                table: "StatementLists",
                keyColumn: "StatementID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 259, DateTimeKind.Local).AddTicks(8487));

            migrationBuilder.UpdateData(
                table: "StatementLists",
                keyColumn: "StatementID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 260, DateTimeKind.Local).AddTicks(5481));

            migrationBuilder.UpdateData(
                table: "StatementLists",
                keyColumn: "StatementID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 260, DateTimeKind.Local).AddTicks(5496));

            migrationBuilder.UpdateData(
                table: "StatementLists",
                keyColumn: "StatementID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 260, DateTimeKind.Local).AddTicks(5502));

            migrationBuilder.UpdateData(
                table: "TechnicalSupport",
                keyColumn: "TechnicalSupportID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 287, DateTimeKind.Local).AddTicks(4570));

            migrationBuilder.UpdateData(
                table: "TechnicalSupport",
                keyColumn: "TechnicalSupportID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 287, DateTimeKind.Local).AddTicks(5170));

            migrationBuilder.UpdateData(
                table: "TechnicalSupport",
                keyColumn: "TechnicalSupportID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 287, DateTimeKind.Local).AddTicks(5180));

            migrationBuilder.UpdateData(
                table: "TechnicalSupport",
                keyColumn: "TechnicalSupportID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 287, DateTimeKind.Local).AddTicks(5185));

            migrationBuilder.UpdateData(
                table: "TechnicalSupport",
                keyColumn: "TechnicalSupportID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 287, DateTimeKind.Local).AddTicks(5190));

            migrationBuilder.UpdateData(
                table: "TechnicalSupport",
                keyColumn: "TechnicalSupportID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 287, DateTimeKind.Local).AddTicks(5203));

            migrationBuilder.UpdateData(
                table: "Titles",
                keyColumn: "TitleID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 264, DateTimeKind.Local).AddTicks(1453));

            migrationBuilder.UpdateData(
                table: "Titles",
                keyColumn: "TitleID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 264, DateTimeKind.Local).AddTicks(2678));

            migrationBuilder.UpdateData(
                table: "Titles",
                keyColumn: "TitleID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 264, DateTimeKind.Local).AddTicks(2697));

            migrationBuilder.UpdateData(
                table: "Titles",
                keyColumn: "TitleID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 264, DateTimeKind.Local).AddTicks(2702));

            migrationBuilder.UpdateData(
                table: "Titles",
                keyColumn: "TitleID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 264, DateTimeKind.Local).AddTicks(2706));

            migrationBuilder.UpdateData(
                table: "Titles",
                keyColumn: "TitleID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 264, DateTimeKind.Local).AddTicks(2719));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 189, DateTimeKind.Local).AddTicks(4665));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 189, DateTimeKind.Local).AddTicks(5755));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 189, DateTimeKind.Local).AddTicks(5857));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 189, DateTimeKind.Local).AddTicks(5982));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 189, DateTimeKind.Local).AddTicks(6082));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 189, DateTimeKind.Local).AddTicks(6170));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 189, DateTimeKind.Local).AddTicks(6241));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 189, DateTimeKind.Local).AddTicks(6311));

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumns: new[] { "UserID", "RoleID" },
                keyValues: new object[] { 1, 1 },
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 233, DateTimeKind.Local).AddTicks(6798));

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumns: new[] { "UserID", "RoleID" },
                keyValues: new object[] { 2, 3 },
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 233, DateTimeKind.Local).AddTicks(6959));

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "UserTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 204, DateTimeKind.Local).AddTicks(1415));

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "UserTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 204, DateTimeKind.Local).AddTicks(2089));

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "UserTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 204, DateTimeKind.Local).AddTicks(2105));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 219, DateTimeKind.Local).AddTicks(854));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 222, DateTimeKind.Local).AddTicks(5366));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 222, DateTimeKind.Local).AddTicks(6143));

            migrationBuilder.UpdateData(
                table: "VariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 209, DateTimeKind.Local).AddTicks(8357));

            migrationBuilder.UpdateData(
                table: "VariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 209, DateTimeKind.Local).AddTicks(9185));

            migrationBuilder.UpdateData(
                table: "VariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 209, DateTimeKind.Local).AddTicks(9198));

            migrationBuilder.UpdateData(
                table: "VariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 209, DateTimeKind.Local).AddTicks(9203));

            migrationBuilder.UpdateData(
                table: "VariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 209, DateTimeKind.Local).AddTicks(9207));

            migrationBuilder.UpdateData(
                table: "VariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 209, DateTimeKind.Local).AddTicks(9225));

            migrationBuilder.UpdateData(
                table: "VariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 209, DateTimeKind.Local).AddTicks(9238));

            migrationBuilder.UpdateData(
                table: "VariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 209, DateTimeKind.Local).AddTicks(9243));

            migrationBuilder.UpdateData(
                table: "VariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2021, 10, 11, 21, 20, 34, 209, DateTimeKind.Local).AddTicks(9248));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TransactionalLevy",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "TransactionalLevy",
                table: "ProductHistory");

            migrationBuilder.UpdateData(
                table: "BankAccountTypes",
                keyColumn: "BankAccountTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 628, DateTimeKind.Local).AddTicks(5864));

            migrationBuilder.UpdateData(
                table: "BankAccountTypes",
                keyColumn: "BankAccountTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 628, DateTimeKind.Local).AddTicks(6698));

            migrationBuilder.UpdateData(
                table: "BankAccountTypes",
                keyColumn: "BankAccountTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 628, DateTimeKind.Local).AddTicks(6713));

            migrationBuilder.UpdateData(
                table: "BankAccountTypes",
                keyColumn: "BankAccountTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 628, DateTimeKind.Local).AddTicks(6721));

            migrationBuilder.UpdateData(
                table: "ClientAccountTypes",
                keyColumn: "ID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 698, DateTimeKind.Local).AddTicks(4182));

            migrationBuilder.UpdateData(
                table: "ClientAccountTypes",
                keyColumn: "ID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 698, DateTimeKind.Local).AddTicks(5098));

            migrationBuilder.UpdateData(
                table: "ClientGroups",
                keyColumn: "ClientGroupID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 706, DateTimeKind.Local).AddTicks(4123));

            migrationBuilder.UpdateData(
                table: "ClientGroups",
                keyColumn: "ClientGroupID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 706, DateTimeKind.Local).AddTicks(4932));

            migrationBuilder.UpdateData(
                table: "ContactTypes",
                keyColumn: "ContactTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 639, DateTimeKind.Local).AddTicks(792));

            migrationBuilder.UpdateData(
                table: "ContactTypes",
                keyColumn: "ContactTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 639, DateTimeKind.Local).AddTicks(787));

            migrationBuilder.UpdateData(
                table: "ContactTypes",
                keyColumn: "ContactTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 639, DateTimeKind.Local).AddTicks(779));

            migrationBuilder.UpdateData(
                table: "ContactTypes",
                keyColumn: "ContactTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 639, DateTimeKind.Local).AddTicks(626));

            migrationBuilder.UpdateData(
                table: "ContactTypes",
                keyColumn: "ContactTypeID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 639, DateTimeKind.Local).AddTicks(796));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 648, DateTimeKind.Local).AddTicks(820));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 648, DateTimeKind.Local).AddTicks(1506));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 648, DateTimeKind.Local).AddTicks(1513));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 648, DateTimeKind.Local).AddTicks(1528));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 648, DateTimeKind.Local).AddTicks(1535));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 648, DateTimeKind.Local).AddTicks(1550));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 648, DateTimeKind.Local).AddTicks(1555));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 648, DateTimeKind.Local).AddTicks(1594));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 648, DateTimeKind.Local).AddTicks(1601));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 648, DateTimeKind.Local).AddTicks(1607));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 648, DateTimeKind.Local).AddTicks(1611));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 648, DateTimeKind.Local).AddTicks(1615));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 13,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 648, DateTimeKind.Local).AddTicks(1619));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 14,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 648, DateTimeKind.Local).AddTicks(1622));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 15,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 648, DateTimeKind.Local).AddTicks(1628));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 16,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 648, DateTimeKind.Local).AddTicks(1633));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 17,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 648, DateTimeKind.Local).AddTicks(1645));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 18,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 648, DateTimeKind.Local).AddTicks(1654));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 19,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 648, DateTimeKind.Local).AddTicks(1660));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 20,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 648, DateTimeKind.Local).AddTicks(1664));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 21,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 648, DateTimeKind.Local).AddTicks(1670));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 22,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 648, DateTimeKind.Local).AddTicks(1675));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 23,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 648, DateTimeKind.Local).AddTicks(1684));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 24,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 648, DateTimeKind.Local).AddTicks(1691));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 25,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 648, DateTimeKind.Local).AddTicks(1697));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 26,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 648, DateTimeKind.Local).AddTicks(1703));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 27,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 648, DateTimeKind.Local).AddTicks(1708));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 28,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 648, DateTimeKind.Local).AddTicks(1718));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 29,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 648, DateTimeKind.Local).AddTicks(1721));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 30,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 648, DateTimeKind.Local).AddTicks(1731));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 31,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 648, DateTimeKind.Local).AddTicks(1738));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 32,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 648, DateTimeKind.Local).AddTicks(1743));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 33,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 648, DateTimeKind.Local).AddTicks(1748));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 34,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 648, DateTimeKind.Local).AddTicks(1862));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 35,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 648, DateTimeKind.Local).AddTicks(1869));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 36,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 648, DateTimeKind.Local).AddTicks(1874));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 37,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 648, DateTimeKind.Local).AddTicks(1882));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 38,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 648, DateTimeKind.Local).AddTicks(1886));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 39,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 648, DateTimeKind.Local).AddTicks(1895));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 40,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 648, DateTimeKind.Local).AddTicks(1901));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 41,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 648, DateTimeKind.Local).AddTicks(1913));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 42,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 648, DateTimeKind.Local).AddTicks(1918));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 43,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 648, DateTimeKind.Local).AddTicks(1923));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 44,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 648, DateTimeKind.Local).AddTicks(1929));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 45,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 648, DateTimeKind.Local).AddTicks(1937));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 46,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 648, DateTimeKind.Local).AddTicks(1942));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 47,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 648, DateTimeKind.Local).AddTicks(1953));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 48,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 648, DateTimeKind.Local).AddTicks(1961));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 49,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 648, DateTimeKind.Local).AddTicks(1965));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 50,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 648, DateTimeKind.Local).AddTicks(1973));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 51,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 648, DateTimeKind.Local).AddTicks(1981));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 52,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 648, DateTimeKind.Local).AddTicks(1987));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 53,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 648, DateTimeKind.Local).AddTicks(1994));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 54,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 648, DateTimeKind.Local).AddTicks(1999));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 55,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 648, DateTimeKind.Local).AddTicks(2007));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 56,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 648, DateTimeKind.Local).AddTicks(2012));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 57,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 648, DateTimeKind.Local).AddTicks(2018));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 58,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 648, DateTimeKind.Local).AddTicks(2025));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 59,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 648, DateTimeKind.Local).AddTicks(2030));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 60,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 648, DateTimeKind.Local).AddTicks(2038));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 61,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 648, DateTimeKind.Local).AddTicks(2044));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 62,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 648, DateTimeKind.Local).AddTicks(2048));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 63,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 648, DateTimeKind.Local).AddTicks(2057));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 64,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 648, DateTimeKind.Local).AddTicks(2064));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 65,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 648, DateTimeKind.Local).AddTicks(2071));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 66,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 648, DateTimeKind.Local).AddTicks(2081));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 67,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 648, DateTimeKind.Local).AddTicks(2086));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 68,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 648, DateTimeKind.Local).AddTicks(2093));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 69,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 648, DateTimeKind.Local).AddTicks(2098));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 70,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 648, DateTimeKind.Local).AddTicks(2105));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 71,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 648, DateTimeKind.Local).AddTicks(2111));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 72,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 648, DateTimeKind.Local).AddTicks(2121));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 73,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 648, DateTimeKind.Local).AddTicks(2126));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 74,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 648, DateTimeKind.Local).AddTicks(2133));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 75,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 648, DateTimeKind.Local).AddTicks(2139));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 76,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 648, DateTimeKind.Local).AddTicks(2150));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 77,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 648, DateTimeKind.Local).AddTicks(2154));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 78,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 648, DateTimeKind.Local).AddTicks(2160));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 79,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 648, DateTimeKind.Local).AddTicks(2165));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 80,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 648, DateTimeKind.Local).AddTicks(2169));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 81,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 648, DateTimeKind.Local).AddTicks(2182));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 82,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 648, DateTimeKind.Local).AddTicks(2188));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 83,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 648, DateTimeKind.Local).AddTicks(2199));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 84,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 648, DateTimeKind.Local).AddTicks(2204));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 85,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 648, DateTimeKind.Local).AddTicks(2208));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 86,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 648, DateTimeKind.Local).AddTicks(2212));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 87,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 648, DateTimeKind.Local).AddTicks(2217));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 88,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 648, DateTimeKind.Local).AddTicks(2224));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 89,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 648, DateTimeKind.Local).AddTicks(2233));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 90,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 648, DateTimeKind.Local).AddTicks(2239));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 91,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 648, DateTimeKind.Local).AddTicks(2308));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 92,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 648, DateTimeKind.Local).AddTicks(2315));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 93,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 648, DateTimeKind.Local).AddTicks(2322));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 94,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 648, DateTimeKind.Local).AddTicks(2328));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 95,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 648, DateTimeKind.Local).AddTicks(2332));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 96,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 648, DateTimeKind.Local).AddTicks(2338));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 97,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 648, DateTimeKind.Local).AddTicks(2344));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 98,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 648, DateTimeKind.Local).AddTicks(2348));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 99,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 648, DateTimeKind.Local).AddTicks(2356));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 100,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 648, DateTimeKind.Local).AddTicks(2363));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 101,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 648, DateTimeKind.Local).AddTicks(2369));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 102,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 648, DateTimeKind.Local).AddTicks(2373));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 103,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 648, DateTimeKind.Local).AddTicks(2377));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 104,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 648, DateTimeKind.Local).AddTicks(2383));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 105,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 648, DateTimeKind.Local).AddTicks(2387));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 106,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 648, DateTimeKind.Local).AddTicks(2393));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 107,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 648, DateTimeKind.Local).AddTicks(2399));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 108,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 648, DateTimeKind.Local).AddTicks(2403));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 109,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 648, DateTimeKind.Local).AddTicks(2408));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 110,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 648, DateTimeKind.Local).AddTicks(2416));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 111,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 648, DateTimeKind.Local).AddTicks(2420));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 112,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 648, DateTimeKind.Local).AddTicks(2431));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 113,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 648, DateTimeKind.Local).AddTicks(2439));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 114,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 648, DateTimeKind.Local).AddTicks(2446));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 115,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 648, DateTimeKind.Local).AddTicks(2453));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 116,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 648, DateTimeKind.Local).AddTicks(2460));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 117,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 648, DateTimeKind.Local).AddTicks(2465));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 118,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 648, DateTimeKind.Local).AddTicks(2473));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 119,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 648, DateTimeKind.Local).AddTicks(2480));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 120,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 648, DateTimeKind.Local).AddTicks(2486));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 121,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 648, DateTimeKind.Local).AddTicks(2492));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 122,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 648, DateTimeKind.Local).AddTicks(2499));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 123,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 648, DateTimeKind.Local).AddTicks(2504));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 124,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 648, DateTimeKind.Local).AddTicks(2511));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 125,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 648, DateTimeKind.Local).AddTicks(2518));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 126,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 648, DateTimeKind.Local).AddTicks(2525));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 127,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 648, DateTimeKind.Local).AddTicks(2530));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 128,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 648, DateTimeKind.Local).AddTicks(2535));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 129,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 648, DateTimeKind.Local).AddTicks(2541));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 130,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 648, DateTimeKind.Local).AddTicks(2551));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 131,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 648, DateTimeKind.Local).AddTicks(2557));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 132,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 648, DateTimeKind.Local).AddTicks(2565));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 133,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 648, DateTimeKind.Local).AddTicks(2572));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 134,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 648, DateTimeKind.Local).AddTicks(2583));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 135,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 648, DateTimeKind.Local).AddTicks(2589));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 136,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 648, DateTimeKind.Local).AddTicks(2595));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 137,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 648, DateTimeKind.Local).AddTicks(2605));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 138,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 648, DateTimeKind.Local).AddTicks(2611));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 139,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 648, DateTimeKind.Local).AddTicks(2615));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 140,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 648, DateTimeKind.Local).AddTicks(2620));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 141,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 648, DateTimeKind.Local).AddTicks(2624));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 142,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 648, DateTimeKind.Local).AddTicks(2631));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 143,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 648, DateTimeKind.Local).AddTicks(2666));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 144,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 648, DateTimeKind.Local).AddTicks(2671));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 145,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 648, DateTimeKind.Local).AddTicks(2675));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 146,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 648, DateTimeKind.Local).AddTicks(2682));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 147,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 648, DateTimeKind.Local).AddTicks(2747));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 148,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 648, DateTimeKind.Local).AddTicks(2756));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 149,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 648, DateTimeKind.Local).AddTicks(2774));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 150,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 648, DateTimeKind.Local).AddTicks(2785));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 151,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 648, DateTimeKind.Local).AddTicks(2791));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 152,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 648, DateTimeKind.Local).AddTicks(2801));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 153,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 648, DateTimeKind.Local).AddTicks(2818));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 154,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 648, DateTimeKind.Local).AddTicks(2827));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 155,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 648, DateTimeKind.Local).AddTicks(2834));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 156,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 648, DateTimeKind.Local).AddTicks(2839));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 157,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 648, DateTimeKind.Local).AddTicks(2846));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 158,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 648, DateTimeKind.Local).AddTicks(2852));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 159,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 648, DateTimeKind.Local).AddTicks(2857));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 160,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 648, DateTimeKind.Local).AddTicks(2863));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 161,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 648, DateTimeKind.Local).AddTicks(2869));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 162,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 648, DateTimeKind.Local).AddTicks(2879));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 163,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 648, DateTimeKind.Local).AddTicks(2886));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 164,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 648, DateTimeKind.Local).AddTicks(2892));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 165,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 648, DateTimeKind.Local).AddTicks(2904));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 166,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 648, DateTimeKind.Local).AddTicks(2914));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 167,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 648, DateTimeKind.Local).AddTicks(2922));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 168,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 648, DateTimeKind.Local).AddTicks(2929));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 169,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 648, DateTimeKind.Local).AddTicks(2936));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 170,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 648, DateTimeKind.Local).AddTicks(2948));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 171,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 648, DateTimeKind.Local).AddTicks(2954));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 172,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 648, DateTimeKind.Local).AddTicks(2965));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 173,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 648, DateTimeKind.Local).AddTicks(2973));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 174,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 648, DateTimeKind.Local).AddTicks(2980));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 175,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 648, DateTimeKind.Local).AddTicks(2988));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 176,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 648, DateTimeKind.Local).AddTicks(2993));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 177,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 648, DateTimeKind.Local).AddTicks(3001));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 178,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 648, DateTimeKind.Local).AddTicks(3007));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 179,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 648, DateTimeKind.Local).AddTicks(3018));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 180,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 648, DateTimeKind.Local).AddTicks(3024));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 181,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 648, DateTimeKind.Local).AddTicks(3032));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 182,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 648, DateTimeKind.Local).AddTicks(3038));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 183,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 648, DateTimeKind.Local).AddTicks(3043));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 184,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 648, DateTimeKind.Local).AddTicks(3048));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 185,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 648, DateTimeKind.Local).AddTicks(3055));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 186,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 648, DateTimeKind.Local).AddTicks(3061));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 187,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 648, DateTimeKind.Local).AddTicks(3068));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 188,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 648, DateTimeKind.Local).AddTicks(3080));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 189,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 648, DateTimeKind.Local).AddTicks(3092));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 190,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 648, DateTimeKind.Local).AddTicks(3099));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 191,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 648, DateTimeKind.Local).AddTicks(3107));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 192,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 648, DateTimeKind.Local).AddTicks(3112));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 193,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 648, DateTimeKind.Local).AddTicks(3117));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 194,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 648, DateTimeKind.Local).AddTicks(3127));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 195,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 648, DateTimeKind.Local).AddTicks(3135));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 196,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 648, DateTimeKind.Local).AddTicks(3140));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 197,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 648, DateTimeKind.Local).AddTicks(3147));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 198,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 648, DateTimeKind.Local).AddTicks(3153));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 199,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 648, DateTimeKind.Local).AddTicks(3157));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 200,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 648, DateTimeKind.Local).AddTicks(3162));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 201,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 648, DateTimeKind.Local).AddTicks(3169));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 202,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 648, DateTimeKind.Local).AddTicks(3177));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 203,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 648, DateTimeKind.Local).AddTicks(3181));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 204,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 648, DateTimeKind.Local).AddTicks(3188));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 205,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 648, DateTimeKind.Local).AddTicks(3196));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 206,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 648, DateTimeKind.Local).AddTicks(3203));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 207,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 648, DateTimeKind.Local).AddTicks(3209));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 208,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 648, DateTimeKind.Local).AddTicks(3213));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 209,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 648, DateTimeKind.Local).AddTicks(3218));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 210,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 648, DateTimeKind.Local).AddTicks(3223));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 211,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 648, DateTimeKind.Local).AddTicks(3228));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 212,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 648, DateTimeKind.Local).AddTicks(3233));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 213,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 648, DateTimeKind.Local).AddTicks(3242));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 214,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 648, DateTimeKind.Local).AddTicks(3250));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 215,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 648, DateTimeKind.Local).AddTicks(3314));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 216,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 648, DateTimeKind.Local).AddTicks(3322));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 217,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 648, DateTimeKind.Local).AddTicks(3328));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 218,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 648, DateTimeKind.Local).AddTicks(3337));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 219,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 648, DateTimeKind.Local).AddTicks(3341));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 220,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 648, DateTimeKind.Local).AddTicks(3349));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 221,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 648, DateTimeKind.Local).AddTicks(3354));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 222,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 648, DateTimeKind.Local).AddTicks(3364));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 223,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 648, DateTimeKind.Local).AddTicks(3372));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 224,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 648, DateTimeKind.Local).AddTicks(3377));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 225,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 648, DateTimeKind.Local).AddTicks(3382));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 226,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 648, DateTimeKind.Local).AddTicks(3388));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 227,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 648, DateTimeKind.Local).AddTicks(3391));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 228,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 648, DateTimeKind.Local).AddTicks(3395));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 631, DateTimeKind.Local).AddTicks(9881));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 632, DateTimeKind.Local).AddTicks(490));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 632, DateTimeKind.Local).AddTicks(498));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 632, DateTimeKind.Local).AddTicks(501));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 632, DateTimeKind.Local).AddTicks(505));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 632, DateTimeKind.Local).AddTicks(515));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 632, DateTimeKind.Local).AddTicks(518));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 632, DateTimeKind.Local).AddTicks(522));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 632, DateTimeKind.Local).AddTicks(525));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 632, DateTimeKind.Local).AddTicks(531));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 632, DateTimeKind.Local).AddTicks(534));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 632, DateTimeKind.Local).AddTicks(538));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 13,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 632, DateTimeKind.Local).AddTicks(542));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 14,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 632, DateTimeKind.Local).AddTicks(545));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 15,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 632, DateTimeKind.Local).AddTicks(548));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 16,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 632, DateTimeKind.Local).AddTicks(552));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 17,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 632, DateTimeKind.Local).AddTicks(555));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 18,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 632, DateTimeKind.Local).AddTicks(562));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 19,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 632, DateTimeKind.Local).AddTicks(565));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 20,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 632, DateTimeKind.Local).AddTicks(569));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 21,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 632, DateTimeKind.Local).AddTicks(572));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 22,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 632, DateTimeKind.Local).AddTicks(576));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 23,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 632, DateTimeKind.Local).AddTicks(579));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 24,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 632, DateTimeKind.Local).AddTicks(583));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 25,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 632, DateTimeKind.Local).AddTicks(586));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 26,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 632, DateTimeKind.Local).AddTicks(590));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 27,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 632, DateTimeKind.Local).AddTicks(593));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 28,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 632, DateTimeKind.Local).AddTicks(596));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 29,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 632, DateTimeKind.Local).AddTicks(600));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 30,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 632, DateTimeKind.Local).AddTicks(603));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 31,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 632, DateTimeKind.Local).AddTicks(606));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 32,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 632, DateTimeKind.Local).AddTicks(610));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 33,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 632, DateTimeKind.Local).AddTicks(613));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 34,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 632, DateTimeKind.Local).AddTicks(619));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 35,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 632, DateTimeKind.Local).AddTicks(622));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 36,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 632, DateTimeKind.Local).AddTicks(625));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 37,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 632, DateTimeKind.Local).AddTicks(629));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 38,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 632, DateTimeKind.Local).AddTicks(632));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 39,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 632, DateTimeKind.Local).AddTicks(636));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 40,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 632, DateTimeKind.Local).AddTicks(639));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 41,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 632, DateTimeKind.Local).AddTicks(643));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 42,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 632, DateTimeKind.Local).AddTicks(646));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 43,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 632, DateTimeKind.Local).AddTicks(649));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 44,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 632, DateTimeKind.Local).AddTicks(653));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 45,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 632, DateTimeKind.Local).AddTicks(656));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 46,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 632, DateTimeKind.Local).AddTicks(659));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 47,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 632, DateTimeKind.Local).AddTicks(663));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 48,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 632, DateTimeKind.Local).AddTicks(666));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 49,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 632, DateTimeKind.Local).AddTicks(670));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 50,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 632, DateTimeKind.Local).AddTicks(673));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 51,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 632, DateTimeKind.Local).AddTicks(676));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 52,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 632, DateTimeKind.Local).AddTicks(680));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 53,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 632, DateTimeKind.Local).AddTicks(683));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 54,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 632, DateTimeKind.Local).AddTicks(686));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 55,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 632, DateTimeKind.Local).AddTicks(689));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 56,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 632, DateTimeKind.Local).AddTicks(693));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 57,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 632, DateTimeKind.Local).AddTicks(696));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 58,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 632, DateTimeKind.Local).AddTicks(700));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 59,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 632, DateTimeKind.Local).AddTicks(703));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 60,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 632, DateTimeKind.Local).AddTicks(706));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 61,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 632, DateTimeKind.Local).AddTicks(711));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 62,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 632, DateTimeKind.Local).AddTicks(714));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 63,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 632, DateTimeKind.Local).AddTicks(718));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 64,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 632, DateTimeKind.Local).AddTicks(721));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 65,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 632, DateTimeKind.Local).AddTicks(724));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 66,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 632, DateTimeKind.Local).AddTicks(861));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 67,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 632, DateTimeKind.Local).AddTicks(865));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 68,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 632, DateTimeKind.Local).AddTicks(868));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 69,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 632, DateTimeKind.Local).AddTicks(872));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 70,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 632, DateTimeKind.Local).AddTicks(875));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 71,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 632, DateTimeKind.Local).AddTicks(879));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 72,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 632, DateTimeKind.Local).AddTicks(883));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 73,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 632, DateTimeKind.Local).AddTicks(886));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 74,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 632, DateTimeKind.Local).AddTicks(890));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 75,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 632, DateTimeKind.Local).AddTicks(893));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 76,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 632, DateTimeKind.Local).AddTicks(896));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 77,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 632, DateTimeKind.Local).AddTicks(900));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 78,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 632, DateTimeKind.Local).AddTicks(903));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 79,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 632, DateTimeKind.Local).AddTicks(907));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 80,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 632, DateTimeKind.Local).AddTicks(911));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 81,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 632, DateTimeKind.Local).AddTicks(915));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 82,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 632, DateTimeKind.Local).AddTicks(920));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 83,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 632, DateTimeKind.Local).AddTicks(924));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 84,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 632, DateTimeKind.Local).AddTicks(929));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 85,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 632, DateTimeKind.Local).AddTicks(933));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 86,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 632, DateTimeKind.Local).AddTicks(937));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 87,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 632, DateTimeKind.Local).AddTicks(942));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 88,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 632, DateTimeKind.Local).AddTicks(946));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 89,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 632, DateTimeKind.Local).AddTicks(950));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 90,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 632, DateTimeKind.Local).AddTicks(954));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 91,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 632, DateTimeKind.Local).AddTicks(958));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 92,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 632, DateTimeKind.Local).AddTicks(963));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 93,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 632, DateTimeKind.Local).AddTicks(966));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 94,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 632, DateTimeKind.Local).AddTicks(970));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 95,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 632, DateTimeKind.Local).AddTicks(973));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 96,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 632, DateTimeKind.Local).AddTicks(976));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 97,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 632, DateTimeKind.Local).AddTicks(980));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 98,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 632, DateTimeKind.Local).AddTicks(983));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 99,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 632, DateTimeKind.Local).AddTicks(987));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 100,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 632, DateTimeKind.Local).AddTicks(990));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 101,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 632, DateTimeKind.Local).AddTicks(993));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 102,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 632, DateTimeKind.Local).AddTicks(997));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 103,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 632, DateTimeKind.Local).AddTicks(1000));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 104,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 632, DateTimeKind.Local).AddTicks(1004));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 105,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 632, DateTimeKind.Local).AddTicks(1007));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 106,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 632, DateTimeKind.Local).AddTicks(1011));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 107,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 632, DateTimeKind.Local).AddTicks(1014));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 108,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 632, DateTimeKind.Local).AddTicks(1017));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 109,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 632, DateTimeKind.Local).AddTicks(1021));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 110,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 632, DateTimeKind.Local).AddTicks(1024));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 111,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 632, DateTimeKind.Local).AddTicks(1027));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 112,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 632, DateTimeKind.Local).AddTicks(1031));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 113,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 632, DateTimeKind.Local).AddTicks(1035));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 114,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 632, DateTimeKind.Local).AddTicks(1038));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 115,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 632, DateTimeKind.Local).AddTicks(1042));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 116,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 632, DateTimeKind.Local).AddTicks(1045));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 117,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 632, DateTimeKind.Local).AddTicks(1049));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 118,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 632, DateTimeKind.Local).AddTicks(1052));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 119,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 632, DateTimeKind.Local).AddTicks(1055));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 120,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 632, DateTimeKind.Local).AddTicks(1059));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 121,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 632, DateTimeKind.Local).AddTicks(1062));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 122,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 632, DateTimeKind.Local).AddTicks(1065));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 123,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 632, DateTimeKind.Local).AddTicks(1069));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 124,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 632, DateTimeKind.Local).AddTicks(1073));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 125,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 632, DateTimeKind.Local).AddTicks(1076));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 126,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 632, DateTimeKind.Local).AddTicks(1080));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 127,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 632, DateTimeKind.Local).AddTicks(1083));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 128,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 632, DateTimeKind.Local).AddTicks(1086));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 129,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 632, DateTimeKind.Local).AddTicks(1090));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 130,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 632, DateTimeKind.Local).AddTicks(1129));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 131,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 632, DateTimeKind.Local).AddTicks(1132));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 132,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 632, DateTimeKind.Local).AddTicks(1135));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 133,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 632, DateTimeKind.Local).AddTicks(1139));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 134,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 632, DateTimeKind.Local).AddTicks(1142));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 135,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 632, DateTimeKind.Local).AddTicks(1146));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 136,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 632, DateTimeKind.Local).AddTicks(1149));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 137,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 632, DateTimeKind.Local).AddTicks(1152));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 138,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 632, DateTimeKind.Local).AddTicks(1156));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 139,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 632, DateTimeKind.Local).AddTicks(1159));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 140,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 632, DateTimeKind.Local).AddTicks(1162));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 141,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 632, DateTimeKind.Local).AddTicks(1166));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 142,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 632, DateTimeKind.Local).AddTicks(1169));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 143,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 632, DateTimeKind.Local).AddTicks(1173));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 144,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 632, DateTimeKind.Local).AddTicks(1176));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 145,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 632, DateTimeKind.Local).AddTicks(1179));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 146,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 632, DateTimeKind.Local).AddTicks(1182));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 147,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 632, DateTimeKind.Local).AddTicks(1186));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 148,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 632, DateTimeKind.Local).AddTicks(1189));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 149,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 632, DateTimeKind.Local).AddTicks(1192));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 150,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 632, DateTimeKind.Local).AddTicks(1195));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 151,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 632, DateTimeKind.Local).AddTicks(1199));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 152,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 632, DateTimeKind.Local).AddTicks(1202));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 153,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 632, DateTimeKind.Local).AddTicks(1205));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 154,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 632, DateTimeKind.Local).AddTicks(1209));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 155,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 632, DateTimeKind.Local).AddTicks(1212));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 156,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 632, DateTimeKind.Local).AddTicks(1215));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 157,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 632, DateTimeKind.Local).AddTicks(1219));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 158,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 632, DateTimeKind.Local).AddTicks(1222));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 159,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 632, DateTimeKind.Local).AddTicks(1226));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 160,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 632, DateTimeKind.Local).AddTicks(1229));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 161,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 632, DateTimeKind.Local).AddTicks(1232));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 162,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 632, DateTimeKind.Local).AddTicks(1235));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 684, DateTimeKind.Local).AddTicks(6233));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 684, DateTimeKind.Local).AddTicks(6437));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 684, DateTimeKind.Local).AddTicks(6464));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 684, DateTimeKind.Local).AddTicks(6444));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 684, DateTimeKind.Local).AddTicks(6469));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 684, DateTimeKind.Local).AddTicks(6480));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 684, DateTimeKind.Local).AddTicks(6488));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 684, DateTimeKind.Local).AddTicks(6493));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 684, DateTimeKind.Local).AddTicks(6499));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 684, DateTimeKind.Local).AddTicks(6507));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 684, DateTimeKind.Local).AddTicks(6563));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 684, DateTimeKind.Local).AddTicks(6569));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 13,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 684, DateTimeKind.Local).AddTicks(6574));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 14,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 684, DateTimeKind.Local).AddTicks(6583));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 15,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 684, DateTimeKind.Local).AddTicks(6449));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 16,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 684, DateTimeKind.Local).AddTicks(6428));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 17,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 684, DateTimeKind.Local).AddTicks(6658));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 18,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 684, DateTimeKind.Local).AddTicks(6663));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 19,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 684, DateTimeKind.Local).AddTicks(6668));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 20,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 684, DateTimeKind.Local).AddTicks(6674));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 22,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 684, DateTimeKind.Local).AddTicks(6696));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 23,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 684, DateTimeKind.Local).AddTicks(6685));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 24,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 684, DateTimeKind.Local).AddTicks(6680));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 25,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 684, DateTimeKind.Local).AddTicks(6691));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 26,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 684, DateTimeKind.Local).AddTicks(6701));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 27,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 684, DateTimeKind.Local).AddTicks(6707));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 28,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 684, DateTimeKind.Local).AddTicks(6712));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 30,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 684, DateTimeKind.Local).AddTicks(6717));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 31,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 684, DateTimeKind.Local).AddTicks(6723));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 32,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 684, DateTimeKind.Local).AddTicks(6728));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 33,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 684, DateTimeKind.Local).AddTicks(6734));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 34,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 684, DateTimeKind.Local).AddTicks(6739));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 36,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 684, DateTimeKind.Local).AddTicks(6747));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 37,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 684, DateTimeKind.Local).AddTicks(6753));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 38,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 684, DateTimeKind.Local).AddTicks(6759));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 39,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 684, DateTimeKind.Local).AddTicks(6474));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 40,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 684, DateTimeKind.Local).AddTicks(6765));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 41,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 684, DateTimeKind.Local).AddTicks(6770));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 42,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 684, DateTimeKind.Local).AddTicks(6776));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 43,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 684, DateTimeKind.Local).AddTicks(6781));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 44,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 684, DateTimeKind.Local).AddTicks(6786));

            migrationBuilder.UpdateData(
                table: "DeductionTypes",
                keyColumn: "DeductionTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 718, DateTimeKind.Local).AddTicks(8985));

            migrationBuilder.UpdateData(
                table: "DeductionTypes",
                keyColumn: "DeductionTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 718, DateTimeKind.Local).AddTicks(9500));

            migrationBuilder.UpdateData(
                table: "DeductionTypes",
                keyColumn: "DeductionTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 718, DateTimeKind.Local).AddTicks(9515));

            migrationBuilder.UpdateData(
                table: "DocumentFormats",
                keyColumn: "DocumentFormatID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 664, DateTimeKind.Local).AddTicks(5672));

            migrationBuilder.UpdateData(
                table: "DocumentFormats",
                keyColumn: "DocumentFormatID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 664, DateTimeKind.Local).AddTicks(6266));

            migrationBuilder.UpdateData(
                table: "DocumentFormats",
                keyColumn: "DocumentFormatID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 664, DateTimeKind.Local).AddTicks(6406));

            migrationBuilder.UpdateData(
                table: "DocumentFormats",
                keyColumn: "DocumentFormatID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 664, DateTimeKind.Local).AddTicks(6414));

            migrationBuilder.UpdateData(
                table: "DocumentFormats",
                keyColumn: "DocumentFormatID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 664, DateTimeKind.Local).AddTicks(6417));

            migrationBuilder.UpdateData(
                table: "DocumentFormats",
                keyColumn: "DocumentFormatID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 664, DateTimeKind.Local).AddTicks(6428));

            migrationBuilder.UpdateData(
                table: "DocumentTypes",
                keyColumn: "DocumentTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 667, DateTimeKind.Local).AddTicks(3322));

            migrationBuilder.UpdateData(
                table: "DocumentTypes",
                keyColumn: "DocumentTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 667, DateTimeKind.Local).AddTicks(4449));

            migrationBuilder.UpdateData(
                table: "DocumentTypes",
                keyColumn: "DocumentTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 667, DateTimeKind.Local).AddTicks(4477));

            migrationBuilder.UpdateData(
                table: "DocumentTypes",
                keyColumn: "DocumentTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 667, DateTimeKind.Local).AddTicks(4484));

            migrationBuilder.UpdateData(
                table: "EmailTemplates",
                keyColumn: "EmailTemplateID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 679, DateTimeKind.Local).AddTicks(8013));

            migrationBuilder.UpdateData(
                table: "EmailTypes",
                keyColumn: "EmailTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 678, DateTimeKind.Local).AddTicks(6168));

            migrationBuilder.UpdateData(
                table: "EmailTypes",
                keyColumn: "EmailTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 679, DateTimeKind.Local).AddTicks(778));

            migrationBuilder.UpdateData(
                table: "EmailTypes",
                keyColumn: "EmailTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 679, DateTimeKind.Local).AddTicks(793));

            migrationBuilder.UpdateData(
                table: "EmailTypes",
                keyColumn: "EmailTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 679, DateTimeKind.Local).AddTicks(799));

            migrationBuilder.UpdateData(
                table: "FeatureFlags",
                keyColumn: "FeatureFlagID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 661, DateTimeKind.Local).AddTicks(6158));

            migrationBuilder.UpdateData(
                table: "FeatureFlags",
                keyColumn: "FeatureFlagID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 661, DateTimeKind.Local).AddTicks(6783));

            migrationBuilder.UpdateData(
                table: "FeatureFlags",
                keyColumn: "FeatureFlagID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 661, DateTimeKind.Local).AddTicks(6800));

            migrationBuilder.UpdateData(
                table: "Frequencies",
                keyColumn: "FrequencyID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 634, DateTimeKind.Local).AddTicks(8722));

            migrationBuilder.UpdateData(
                table: "Frequencies",
                keyColumn: "FrequencyID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 634, DateTimeKind.Local).AddTicks(9270));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "GenderID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 643, DateTimeKind.Local).AddTicks(9667));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "GenderID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 643, DateTimeKind.Local).AddTicks(9838));

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "InvoiceStatusID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 710, DateTimeKind.Local).AddTicks(6214));

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "InvoiceStatusID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 710, DateTimeKind.Local).AddTicks(6849));

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "InvoiceStatusID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 710, DateTimeKind.Local).AddTicks(6857));

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "InvoiceStatusID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 710, DateTimeKind.Local).AddTicks(6861));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 716, DateTimeKind.Local).AddTicks(2615));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 716, DateTimeKind.Local).AddTicks(2850));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 716, DateTimeKind.Local).AddTicks(2856));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 716, DateTimeKind.Local).AddTicks(2862));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 716, DateTimeKind.Local).AddTicks(2866));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 716, DateTimeKind.Local).AddTicks(2877));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 716, DateTimeKind.Local).AddTicks(2884));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 716, DateTimeKind.Local).AddTicks(2888));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 716, DateTimeKind.Local).AddTicks(2894));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 716, DateTimeKind.Local).AddTicks(2899));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 716, DateTimeKind.Local).AddTicks(2903));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 716, DateTimeKind.Local).AddTicks(2908));

            migrationBuilder.UpdateData(
                table: "Layouts",
                keyColumn: "LayoutID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 713, DateTimeKind.Local).AddTicks(9787));

            migrationBuilder.UpdateData(
                table: "Layouts",
                keyColumn: "LayoutID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 714, DateTimeKind.Local).AddTicks(1121));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 669, DateTimeKind.Local).AddTicks(8911));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 669, DateTimeKind.Local).AddTicks(9153));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 669, DateTimeKind.Local).AddTicks(9170));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 669, DateTimeKind.Local).AddTicks(9177));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 669, DateTimeKind.Local).AddTicks(9185));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 669, DateTimeKind.Local).AddTicks(9217));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 999,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 669, DateTimeKind.Local).AddTicks(9210));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 9998,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 669, DateTimeKind.Local).AddTicks(9202));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 672, DateTimeKind.Local).AddTicks(7084));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 672, DateTimeKind.Local).AddTicks(7280));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 672, DateTimeKind.Local).AddTicks(7285));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 672, DateTimeKind.Local).AddTicks(7290));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 672, DateTimeKind.Local).AddTicks(7294));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 672, DateTimeKind.Local).AddTicks(7312));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 672, DateTimeKind.Local).AddTicks(7316));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 672, DateTimeKind.Local).AddTicks(7321));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 672, DateTimeKind.Local).AddTicks(7326));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 672, DateTimeKind.Local).AddTicks(7333));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 672, DateTimeKind.Local).AddTicks(7338));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 13,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 672, DateTimeKind.Local).AddTicks(7342));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 14,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 672, DateTimeKind.Local).AddTicks(7346));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 15,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 672, DateTimeKind.Local).AddTicks(7350));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 16,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 672, DateTimeKind.Local).AddTicks(7356));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 17,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 672, DateTimeKind.Local).AddTicks(7360));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 18,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 672, DateTimeKind.Local).AddTicks(7363));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 19,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 672, DateTimeKind.Local).AddTicks(7369));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 20,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 672, DateTimeKind.Local).AddTicks(7373));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 9994,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 672, DateTimeKind.Local).AddTicks(7376));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 9995,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 672, DateTimeKind.Local).AddTicks(7380));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 9996,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 672, DateTimeKind.Local).AddTicks(7384));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 9997,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 672, DateTimeKind.Local).AddTicks(7388));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 9998,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 672, DateTimeKind.Local).AddTicks(7393));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 9999,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 672, DateTimeKind.Local).AddTicks(7397));

            migrationBuilder.UpdateData(
                table: "PaymentStatus",
                keyColumn: "PaymentStatusID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 618, DateTimeKind.Local).AddTicks(387));

            migrationBuilder.UpdateData(
                table: "PaymentStatus",
                keyColumn: "PaymentStatusID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 618, DateTimeKind.Local).AddTicks(1095));

            migrationBuilder.UpdateData(
                table: "PaymentStatus",
                keyColumn: "PaymentStatusID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 618, DateTimeKind.Local).AddTicks(1276));

            migrationBuilder.UpdateData(
                table: "PaymentStatus",
                keyColumn: "PaymentStatusID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 618, DateTimeKind.Local).AddTicks(1283));

            migrationBuilder.UpdateData(
                table: "PaymentStatus",
                keyColumn: "PaymentStatusID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 618, DateTimeKind.Local).AddTicks(1288));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 612, DateTimeKind.Local).AddTicks(5768));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 612, DateTimeKind.Local).AddTicks(6591));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 612, DateTimeKind.Local).AddTicks(6601));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 612, DateTimeKind.Local).AddTicks(6606));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 612, DateTimeKind.Local).AddTicks(6613));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 612, DateTimeKind.Local).AddTicks(6696));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 612, DateTimeKind.Local).AddTicks(6705));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 612, DateTimeKind.Local).AddTicks(6710));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 612, DateTimeKind.Local).AddTicks(6715));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 612, DateTimeKind.Local).AddTicks(6723));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 612, DateTimeKind.Local).AddTicks(6728));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 612, DateTimeKind.Local).AddTicks(6732));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 13,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 612, DateTimeKind.Local).AddTicks(6736));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 14,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 612, DateTimeKind.Local).AddTicks(6741));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 15,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 612, DateTimeKind.Local).AddTicks(6746));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 16,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 612, DateTimeKind.Local).AddTicks(6750));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 17,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 612, DateTimeKind.Local).AddTicks(6754));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 18,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 612, DateTimeKind.Local).AddTicks(6761));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 19,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 612, DateTimeKind.Local).AddTicks(6766));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 20,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 612, DateTimeKind.Local).AddTicks(6770));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 21,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 612, DateTimeKind.Local).AddTicks(6775));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 22,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 612, DateTimeKind.Local).AddTicks(6779));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 23,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 612, DateTimeKind.Local).AddTicks(6784));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 24,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 612, DateTimeKind.Local).AddTicks(6789));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 25,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 612, DateTimeKind.Local).AddTicks(6794));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 26,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 612, DateTimeKind.Local).AddTicks(6799));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 27,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 612, DateTimeKind.Local).AddTicks(6804));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 28,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 612, DateTimeKind.Local).AddTicks(6808));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 29,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 612, DateTimeKind.Local).AddTicks(6813));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 30,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 612, DateTimeKind.Local).AddTicks(6817));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 31,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 612, DateTimeKind.Local).AddTicks(6823));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 32,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 612, DateTimeKind.Local).AddTicks(6828));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 33,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 612, DateTimeKind.Local).AddTicks(6833));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 34,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 612, DateTimeKind.Local).AddTicks(6840));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 35,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 612, DateTimeKind.Local).AddTicks(6844));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 36,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 612, DateTimeKind.Local).AddTicks(6849));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 37,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 612, DateTimeKind.Local).AddTicks(6854));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 38,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 612, DateTimeKind.Local).AddTicks(6858));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 39,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 612, DateTimeKind.Local).AddTicks(6864));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 40,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 612, DateTimeKind.Local).AddTicks(6868));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 41,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 612, DateTimeKind.Local).AddTicks(6872));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 42,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 612, DateTimeKind.Local).AddTicks(6876));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 43,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 612, DateTimeKind.Local).AddTicks(6881));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 44,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 612, DateTimeKind.Local).AddTicks(6885));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 45,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 612, DateTimeKind.Local).AddTicks(6931));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 46,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 612, DateTimeKind.Local).AddTicks(6937));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 47,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 612, DateTimeKind.Local).AddTicks(6942));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 48,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 612, DateTimeKind.Local).AddTicks(6946));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 49,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 612, DateTimeKind.Local).AddTicks(6950));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 50,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 612, DateTimeKind.Local).AddTicks(6954));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 51,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 612, DateTimeKind.Local).AddTicks(6958));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 52,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 612, DateTimeKind.Local).AddTicks(6963));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 53,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 612, DateTimeKind.Local).AddTicks(6967));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 54,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 612, DateTimeKind.Local).AddTicks(6972));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 55,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 612, DateTimeKind.Local).AddTicks(6981));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 56,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 612, DateTimeKind.Local).AddTicks(6986));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 57,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 612, DateTimeKind.Local).AddTicks(6993));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 58,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 612, DateTimeKind.Local).AddTicks(6998));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 59,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 612, DateTimeKind.Local).AddTicks(7005));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 60,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 612, DateTimeKind.Local).AddTicks(7012));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 61,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 612, DateTimeKind.Local).AddTicks(7018));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 62,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 612, DateTimeKind.Local).AddTicks(7024));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 63,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 612, DateTimeKind.Local).AddTicks(7030));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 64,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 612, DateTimeKind.Local).AddTicks(7036));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 65,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 612, DateTimeKind.Local).AddTicks(7042));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 66,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 612, DateTimeKind.Local).AddTicks(7050));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 67,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 612, DateTimeKind.Local).AddTicks(7054));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 68,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 612, DateTimeKind.Local).AddTicks(7059));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 69,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 612, DateTimeKind.Local).AddTicks(7064));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 70,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 612, DateTimeKind.Local).AddTicks(7069));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 71,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 612, DateTimeKind.Local).AddTicks(7075));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 72,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 612, DateTimeKind.Local).AddTicks(7081));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 73,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 612, DateTimeKind.Local).AddTicks(7085));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 74,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 612, DateTimeKind.Local).AddTicks(7091));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 75,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 612, DateTimeKind.Local).AddTicks(7095));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 76,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 612, DateTimeKind.Local).AddTicks(7101));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 77,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 612, DateTimeKind.Local).AddTicks(7105));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 78,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 612, DateTimeKind.Local).AddTicks(7110));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 79,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 612, DateTimeKind.Local).AddTicks(7115));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 80,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 612, DateTimeKind.Local).AddTicks(7120));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 81,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 612, DateTimeKind.Local).AddTicks(7126));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 82,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 612, DateTimeKind.Local).AddTicks(7131));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 83,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 612, DateTimeKind.Local).AddTicks(7137));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 84,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 612, DateTimeKind.Local).AddTicks(7143));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 85,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 612, DateTimeKind.Local).AddTicks(7202));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 86,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 612, DateTimeKind.Local).AddTicks(7209));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 87,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 612, DateTimeKind.Local).AddTicks(7215));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 88,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 612, DateTimeKind.Local).AddTicks(7220));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 89,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 612, DateTimeKind.Local).AddTicks(7225));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 90,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 612, DateTimeKind.Local).AddTicks(7230));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 91,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 612, DateTimeKind.Local).AddTicks(7236));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 92,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 612, DateTimeKind.Local).AddTicks(7241));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 93,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 612, DateTimeKind.Local).AddTicks(7248));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 94,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 612, DateTimeKind.Local).AddTicks(7253));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 95,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 612, DateTimeKind.Local).AddTicks(7258));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 96,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 612, DateTimeKind.Local).AddTicks(7265));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 97,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 612, DateTimeKind.Local).AddTicks(7271));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 98,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 612, DateTimeKind.Local).AddTicks(7278));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 99,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 612, DateTimeKind.Local).AddTicks(7284));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 100,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 612, DateTimeKind.Local).AddTicks(7293));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 101,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 612, DateTimeKind.Local).AddTicks(7299));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 102,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 612, DateTimeKind.Local).AddTicks(7305));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 103,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 612, DateTimeKind.Local).AddTicks(7310));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 104,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 612, DateTimeKind.Local).AddTicks(7315));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 105,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 612, DateTimeKind.Local).AddTicks(7322));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 106,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 612, DateTimeKind.Local).AddTicks(7330));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 107,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 612, DateTimeKind.Local).AddTicks(7338));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 108,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 612, DateTimeKind.Local).AddTicks(7346));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 109,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 612, DateTimeKind.Local).AddTicks(7355));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 110,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 612, DateTimeKind.Local).AddTicks(7362));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 111,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 612, DateTimeKind.Local).AddTicks(7367));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 112,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 612, DateTimeKind.Local).AddTicks(7373));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 113,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 612, DateTimeKind.Local).AddTicks(7378));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 114,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 612, DateTimeKind.Local).AddTicks(7384));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 115,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 612, DateTimeKind.Local).AddTicks(7390));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 116,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 612, DateTimeKind.Local).AddTicks(7396));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 117,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 612, DateTimeKind.Local).AddTicks(7404));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 118,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 612, DateTimeKind.Local).AddTicks(7409));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 119,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 612, DateTimeKind.Local).AddTicks(7415));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 120,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 612, DateTimeKind.Local).AddTicks(7419));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 121,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 612, DateTimeKind.Local).AddTicks(7424));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 122,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 612, DateTimeKind.Local).AddTicks(7430));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 123,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 612, DateTimeKind.Local).AddTicks(7436));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 124,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 612, DateTimeKind.Local).AddTicks(7444));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 125,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 612, DateTimeKind.Local).AddTicks(7452));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 126,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 612, DateTimeKind.Local).AddTicks(7458));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 127,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 612, DateTimeKind.Local).AddTicks(7463));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 128,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 612, DateTimeKind.Local).AddTicks(7471));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 129,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 612, DateTimeKind.Local).AddTicks(7479));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 130,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 612, DateTimeKind.Local).AddTicks(7672));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 131,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 612, DateTimeKind.Local).AddTicks(7681));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 132,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 612, DateTimeKind.Local).AddTicks(7690));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 133,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 612, DateTimeKind.Local).AddTicks(7697));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 134,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 612, DateTimeKind.Local).AddTicks(7704));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 135,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 612, DateTimeKind.Local).AddTicks(7712));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 136,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 612, DateTimeKind.Local).AddTicks(7718));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 137,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 612, DateTimeKind.Local).AddTicks(7726));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 138,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 612, DateTimeKind.Local).AddTicks(7734));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 139,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 612, DateTimeKind.Local).AddTicks(7740));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 140,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 612, DateTimeKind.Local).AddTicks(7747));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 141,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 612, DateTimeKind.Local).AddTicks(7754));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 142,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 612, DateTimeKind.Local).AddTicks(7760));

            migrationBuilder.UpdateData(
                table: "PriorityRanks",
                keyColumn: "PriorityRankID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 652, DateTimeKind.Local).AddTicks(6395));

            migrationBuilder.UpdateData(
                table: "PriorityRanks",
                keyColumn: "PriorityRankID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 652, DateTimeKind.Local).AddTicks(7170));

            migrationBuilder.UpdateData(
                table: "PriorityRanks",
                keyColumn: "PriorityRankID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 652, DateTimeKind.Local).AddTicks(7186));

            migrationBuilder.UpdateData(
                table: "PriorityRanks",
                keyColumn: "PriorityRankID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 652, DateTimeKind.Local).AddTicks(7194));

            migrationBuilder.UpdateData(
                table: "RecordStatus",
                keyColumn: "RecordStatusID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 702, DateTimeKind.Local).AddTicks(5865));

            migrationBuilder.UpdateData(
                table: "RecordStatus",
                keyColumn: "RecordStatusID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 702, DateTimeKind.Local).AddTicks(6687));

            migrationBuilder.UpdateData(
                table: "RecordStatus",
                keyColumn: "RecordStatusID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 702, DateTimeKind.Local).AddTicks(6695));

            migrationBuilder.UpdateData(
                table: "RelationshipTypes",
                keyColumn: "RelationshipTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 639, DateTimeKind.Local).AddTicks(8990));

            migrationBuilder.UpdateData(
                table: "RelationshipTypes",
                keyColumn: "RelationshipTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 639, DateTimeKind.Local).AddTicks(9310));

            migrationBuilder.UpdateData(
                table: "RelationshipTypes",
                keyColumn: "RelationshipTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 639, DateTimeKind.Local).AddTicks(9314));

            migrationBuilder.UpdateData(
                table: "RelationshipTypes",
                keyColumn: "RelationshipTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 639, DateTimeKind.Local).AddTicks(9316));

            migrationBuilder.UpdateData(
                table: "RelationshipTypes",
                keyColumn: "RelationshipTypeID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 639, DateTimeKind.Local).AddTicks(9319));

            migrationBuilder.UpdateData(
                table: "RelationshipTypes",
                keyColumn: "RelationshipTypeID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 639, DateTimeKind.Local).AddTicks(9327));

            migrationBuilder.UpdateData(
                table: "RelationshipTypes",
                keyColumn: "RelationshipTypeID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 639, DateTimeKind.Local).AddTicks(9330));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 685, DateTimeKind.Local).AddTicks(3242));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 685, DateTimeKind.Local).AddTicks(3329));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 685, DateTimeKind.Local).AddTicks(3332));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 685, DateTimeKind.Local).AddTicks(3334));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 685, DateTimeKind.Local).AddTicks(3336));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 685, DateTimeKind.Local).AddTicks(3341));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 685, DateTimeKind.Local).AddTicks(3343));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 685, DateTimeKind.Local).AddTicks(3345));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 685, DateTimeKind.Local).AddTicks(3347));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 685, DateTimeKind.Local).AddTicks(3350));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 685, DateTimeKind.Local).AddTicks(3352));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 685, DateTimeKind.Local).AddTicks(3354));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 13,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 685, DateTimeKind.Local).AddTicks(3355));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 14,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 685, DateTimeKind.Local).AddTicks(3357));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 15,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 685, DateTimeKind.Local).AddTicks(3359));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 16,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 685, DateTimeKind.Local).AddTicks(3361));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 17,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 685, DateTimeKind.Local).AddTicks(3363));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 18,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 685, DateTimeKind.Local).AddTicks(3366));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 19,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 685, DateTimeKind.Local).AddTicks(3368));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 20,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 685, DateTimeKind.Local).AddTicks(3370));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 21,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 685, DateTimeKind.Local).AddTicks(3372));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 22,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 685, DateTimeKind.Local).AddTicks(3373));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 23,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 685, DateTimeKind.Local).AddTicks(3375));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 24,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 685, DateTimeKind.Local).AddTicks(3377));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 25,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 685, DateTimeKind.Local).AddTicks(3379));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 613, DateTimeKind.Local).AddTicks(7198));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 613, DateTimeKind.Local).AddTicks(7364));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 613, DateTimeKind.Local).AddTicks(7368));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 613, DateTimeKind.Local).AddTicks(7371));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 613, DateTimeKind.Local).AddTicks(7374));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 613, DateTimeKind.Local).AddTicks(7381));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 613, DateTimeKind.Local).AddTicks(7383));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 613, DateTimeKind.Local).AddTicks(7385));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 613, DateTimeKind.Local).AddTicks(7387));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 613, DateTimeKind.Local).AddTicks(7391));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 613, DateTimeKind.Local).AddTicks(7393));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 613, DateTimeKind.Local).AddTicks(7395));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 13,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 613, DateTimeKind.Local).AddTicks(7397));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 14,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 613, DateTimeKind.Local).AddTicks(7399));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 15,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 613, DateTimeKind.Local).AddTicks(7401));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 16,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 613, DateTimeKind.Local).AddTicks(7404));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 17,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 613, DateTimeKind.Local).AddTicks(7406));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 18,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 613, DateTimeKind.Local).AddTicks(7410));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 19,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 613, DateTimeKind.Local).AddTicks(7412));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 20,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 613, DateTimeKind.Local).AddTicks(7414));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 21,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 613, DateTimeKind.Local).AddTicks(7416));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 22,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 613, DateTimeKind.Local).AddTicks(7418));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 23,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 613, DateTimeKind.Local).AddTicks(7420));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 24,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 613, DateTimeKind.Local).AddTicks(7422));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 25,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 613, DateTimeKind.Local).AddTicks(7425));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 26,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 613, DateTimeKind.Local).AddTicks(7427));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 27,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 613, DateTimeKind.Local).AddTicks(7429));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 28,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 613, DateTimeKind.Local).AddTicks(7431));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 29,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 613, DateTimeKind.Local).AddTicks(7433));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 30,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 613, DateTimeKind.Local).AddTicks(7435));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 31,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 613, DateTimeKind.Local).AddTicks(7437));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 32,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 613, DateTimeKind.Local).AddTicks(7440));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 33,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 613, DateTimeKind.Local).AddTicks(7442));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 34,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 613, DateTimeKind.Local).AddTicks(7446));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 35,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 613, DateTimeKind.Local).AddTicks(7448));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 36,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 613, DateTimeKind.Local).AddTicks(7450));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 37,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 613, DateTimeKind.Local).AddTicks(7453));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 38,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 613, DateTimeKind.Local).AddTicks(7456));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 39,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 613, DateTimeKind.Local).AddTicks(7459));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 40,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 613, DateTimeKind.Local).AddTicks(7461));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 41,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 613, DateTimeKind.Local).AddTicks(7463));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 42,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 613, DateTimeKind.Local).AddTicks(7466));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 43,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 613, DateTimeKind.Local).AddTicks(7470));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 44,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 613, DateTimeKind.Local).AddTicks(7472));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 45,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 613, DateTimeKind.Local).AddTicks(7474));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 46,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 613, DateTimeKind.Local).AddTicks(7477));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 47,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 613, DateTimeKind.Local).AddTicks(7544));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 48,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 613, DateTimeKind.Local).AddTicks(7548));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 49,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 613, DateTimeKind.Local).AddTicks(7550));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 50,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 613, DateTimeKind.Local).AddTicks(7552));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 51,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 613, DateTimeKind.Local).AddTicks(7554));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 52,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 613, DateTimeKind.Local).AddTicks(7557));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 53,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 613, DateTimeKind.Local).AddTicks(7559));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 54,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 613, DateTimeKind.Local).AddTicks(7561));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 55,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 613, DateTimeKind.Local).AddTicks(7563));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 56,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 613, DateTimeKind.Local).AddTicks(7569));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 57,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 613, DateTimeKind.Local).AddTicks(7572));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 58,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 613, DateTimeKind.Local).AddTicks(7574));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 59,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 613, DateTimeKind.Local).AddTicks(7576));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 60,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 613, DateTimeKind.Local).AddTicks(7585));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 61,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 613, DateTimeKind.Local).AddTicks(7587));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 62,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 613, DateTimeKind.Local).AddTicks(7590));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 63,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 613, DateTimeKind.Local).AddTicks(7592));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 64,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 613, DateTimeKind.Local).AddTicks(7594));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 65,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 613, DateTimeKind.Local).AddTicks(7596));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 66,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 613, DateTimeKind.Local).AddTicks(7601));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 67,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 613, DateTimeKind.Local).AddTicks(7603));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 68,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 613, DateTimeKind.Local).AddTicks(7606));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 69,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 613, DateTimeKind.Local).AddTicks(7608));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 70,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 613, DateTimeKind.Local).AddTicks(7611));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 71,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 613, DateTimeKind.Local).AddTicks(7615));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 72,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 613, DateTimeKind.Local).AddTicks(7619));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 73,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 613, DateTimeKind.Local).AddTicks(7622));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 74,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 613, DateTimeKind.Local).AddTicks(7624));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 75,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 613, DateTimeKind.Local).AddTicks(7626));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 76,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 613, DateTimeKind.Local).AddTicks(7628));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 77,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 613, DateTimeKind.Local).AddTicks(7631));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 78,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 613, DateTimeKind.Local).AddTicks(7634));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 79,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 613, DateTimeKind.Local).AddTicks(7637));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 80,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 613, DateTimeKind.Local).AddTicks(7639));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 81,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 613, DateTimeKind.Local).AddTicks(7642));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 82,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 613, DateTimeKind.Local).AddTicks(7645));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 83,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 613, DateTimeKind.Local).AddTicks(7647));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 84,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 613, DateTimeKind.Local).AddTicks(7656));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 85,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 613, DateTimeKind.Local).AddTicks(7660));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 86,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 613, DateTimeKind.Local).AddTicks(7663));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 87,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 613, DateTimeKind.Local).AddTicks(7667));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 88,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 613, DateTimeKind.Local).AddTicks(7671));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 89,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 613, DateTimeKind.Local).AddTicks(7674));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 90,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 613, DateTimeKind.Local).AddTicks(7676));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 91,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 613, DateTimeKind.Local).AddTicks(7678));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 92,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 613, DateTimeKind.Local).AddTicks(7680));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 93,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 613, DateTimeKind.Local).AddTicks(7682));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 94,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 613, DateTimeKind.Local).AddTicks(7686));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 95,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 613, DateTimeKind.Local).AddTicks(7688));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 96,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 613, DateTimeKind.Local).AddTicks(7690));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 97,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 613, DateTimeKind.Local).AddTicks(7692));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 98,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 613, DateTimeKind.Local).AddTicks(7694));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 99,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 613, DateTimeKind.Local).AddTicks(7696));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 100,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 613, DateTimeKind.Local).AddTicks(7698));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 101,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 613, DateTimeKind.Local).AddTicks(7700));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 102,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 613, DateTimeKind.Local).AddTicks(7702));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 103,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 613, DateTimeKind.Local).AddTicks(7704));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 104,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 613, DateTimeKind.Local).AddTicks(7707));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 105,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 613, DateTimeKind.Local).AddTicks(7709));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 106,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 613, DateTimeKind.Local).AddTicks(7711));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 107,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 613, DateTimeKind.Local).AddTicks(7714));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 108,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 613, DateTimeKind.Local).AddTicks(7717));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 109,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 613, DateTimeKind.Local).AddTicks(7720));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 110,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 613, DateTimeKind.Local).AddTicks(7722));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 111,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 613, DateTimeKind.Local).AddTicks(7724));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 112,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 613, DateTimeKind.Local).AddTicks(7726));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 113,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 613, DateTimeKind.Local).AddTicks(7728));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 114,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 613, DateTimeKind.Local).AddTicks(7731));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 115,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 613, DateTimeKind.Local).AddTicks(7733));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 116,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 613, DateTimeKind.Local).AddTicks(7735));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 117,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 613, DateTimeKind.Local).AddTicks(7737));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 118,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 613, DateTimeKind.Local).AddTicks(7739));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 119,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 613, DateTimeKind.Local).AddTicks(7741));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 120,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 613, DateTimeKind.Local).AddTicks(7744));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 121,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 613, DateTimeKind.Local).AddTicks(7746));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 122,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 613, DateTimeKind.Local).AddTicks(7748));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 123,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 613, DateTimeKind.Local).AddTicks(7751));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 124,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 613, DateTimeKind.Local).AddTicks(7753));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 125,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 613, DateTimeKind.Local).AddTicks(7755));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 126,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 613, DateTimeKind.Local).AddTicks(7758));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 127,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 613, DateTimeKind.Local).AddTicks(7761));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 128,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 613, DateTimeKind.Local).AddTicks(7770));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 129,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 613, DateTimeKind.Local).AddTicks(7772));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 130,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 613, DateTimeKind.Local).AddTicks(7819));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 131,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 613, DateTimeKind.Local).AddTicks(7822));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 132,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 613, DateTimeKind.Local).AddTicks(7825));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 133,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 613, DateTimeKind.Local).AddTicks(7827));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 134,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 613, DateTimeKind.Local).AddTicks(7829));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 135,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 613, DateTimeKind.Local).AddTicks(7831));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 136,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 613, DateTimeKind.Local).AddTicks(7833));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 137,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 613, DateTimeKind.Local).AddTicks(7835));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 138,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 613, DateTimeKind.Local).AddTicks(7837));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 139,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 613, DateTimeKind.Local).AddTicks(7839));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 140,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 613, DateTimeKind.Local).AddTicks(7841));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 141,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 613, DateTimeKind.Local).AddTicks(7844));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 142,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 613, DateTimeKind.Local).AddTicks(7846));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 605, DateTimeKind.Local).AddTicks(2220));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 607, DateTimeKind.Local).AddTicks(3380));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 607, DateTimeKind.Local).AddTicks(3477));

            migrationBuilder.UpdateData(
                table: "StatementLists",
                keyColumn: "StatementID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 690, DateTimeKind.Local).AddTicks(7783));

            migrationBuilder.UpdateData(
                table: "StatementLists",
                keyColumn: "StatementID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 690, DateTimeKind.Local).AddTicks(8441));

            migrationBuilder.UpdateData(
                table: "StatementLists",
                keyColumn: "StatementID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 690, DateTimeKind.Local).AddTicks(8451));

            migrationBuilder.UpdateData(
                table: "StatementLists",
                keyColumn: "StatementID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 690, DateTimeKind.Local).AddTicks(8455));

            migrationBuilder.UpdateData(
                table: "TechnicalSupport",
                keyColumn: "TechnicalSupportID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 721, DateTimeKind.Local).AddTicks(5152));

            migrationBuilder.UpdateData(
                table: "TechnicalSupport",
                keyColumn: "TechnicalSupportID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 721, DateTimeKind.Local).AddTicks(5640));

            migrationBuilder.UpdateData(
                table: "TechnicalSupport",
                keyColumn: "TechnicalSupportID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 721, DateTimeKind.Local).AddTicks(5648));

            migrationBuilder.UpdateData(
                table: "TechnicalSupport",
                keyColumn: "TechnicalSupportID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 721, DateTimeKind.Local).AddTicks(5653));

            migrationBuilder.UpdateData(
                table: "TechnicalSupport",
                keyColumn: "TechnicalSupportID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 721, DateTimeKind.Local).AddTicks(5659));

            migrationBuilder.UpdateData(
                table: "TechnicalSupport",
                keyColumn: "TechnicalSupportID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 721, DateTimeKind.Local).AddTicks(5669));

            migrationBuilder.UpdateData(
                table: "Titles",
                keyColumn: "TitleID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 693, DateTimeKind.Local).AddTicks(9431));

            migrationBuilder.UpdateData(
                table: "Titles",
                keyColumn: "TitleID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 694, DateTimeKind.Local).AddTicks(589));

            migrationBuilder.UpdateData(
                table: "Titles",
                keyColumn: "TitleID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 694, DateTimeKind.Local).AddTicks(599));

            migrationBuilder.UpdateData(
                table: "Titles",
                keyColumn: "TitleID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 694, DateTimeKind.Local).AddTicks(604));

            migrationBuilder.UpdateData(
                table: "Titles",
                keyColumn: "TitleID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 694, DateTimeKind.Local).AddTicks(607));

            migrationBuilder.UpdateData(
                table: "Titles",
                keyColumn: "TitleID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 694, DateTimeKind.Local).AddTicks(622));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 623, DateTimeKind.Local).AddTicks(7664));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 623, DateTimeKind.Local).AddTicks(9116));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 623, DateTimeKind.Local).AddTicks(9973));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 624, DateTimeKind.Local).AddTicks(1718));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 624, DateTimeKind.Local).AddTicks(1817));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 624, DateTimeKind.Local).AddTicks(1945));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 624, DateTimeKind.Local).AddTicks(2038));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 624, DateTimeKind.Local).AddTicks(2145));

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumns: new[] { "UserID", "RoleID" },
                keyValues: new object[] { 1, 1 },
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 668, DateTimeKind.Local).AddTicks(270));

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumns: new[] { "UserID", "RoleID" },
                keyValues: new object[] { 2, 3 },
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 668, DateTimeKind.Local).AddTicks(361));

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "UserTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 638, DateTimeKind.Local).AddTicks(455));

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "UserTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 638, DateTimeKind.Local).AddTicks(996));

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "UserTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 638, DateTimeKind.Local).AddTicks(1003));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 654, DateTimeKind.Local).AddTicks(88));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 657, DateTimeKind.Local).AddTicks(8771));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 657, DateTimeKind.Local).AddTicks(9230));

            migrationBuilder.UpdateData(
                table: "VariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 642, DateTimeKind.Local).AddTicks(9778));

            migrationBuilder.UpdateData(
                table: "VariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 643, DateTimeKind.Local).AddTicks(440));

            migrationBuilder.UpdateData(
                table: "VariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 643, DateTimeKind.Local).AddTicks(452));

            migrationBuilder.UpdateData(
                table: "VariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 643, DateTimeKind.Local).AddTicks(457));

            migrationBuilder.UpdateData(
                table: "VariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 643, DateTimeKind.Local).AddTicks(460));

            migrationBuilder.UpdateData(
                table: "VariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 643, DateTimeKind.Local).AddTicks(472));

            migrationBuilder.UpdateData(
                table: "VariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 643, DateTimeKind.Local).AddTicks(485));

            migrationBuilder.UpdateData(
                table: "VariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 643, DateTimeKind.Local).AddTicks(490));

            migrationBuilder.UpdateData(
                table: "VariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2021, 9, 29, 17, 17, 10, 643, DateTimeKind.Local).AddTicks(493));
        }
    }
}
