using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SmartDataAccess.Migrations
{
    public partial class NewMenu : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "BankAccountTypes",
                keyColumn: "BankAccountTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 805, DateTimeKind.Local).AddTicks(4849));

            migrationBuilder.UpdateData(
                table: "BankAccountTypes",
                keyColumn: "BankAccountTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 805, DateTimeKind.Local).AddTicks(5368));

            migrationBuilder.UpdateData(
                table: "BankAccountTypes",
                keyColumn: "BankAccountTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 805, DateTimeKind.Local).AddTicks(5375));

            migrationBuilder.UpdateData(
                table: "BankAccountTypes",
                keyColumn: "BankAccountTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 805, DateTimeKind.Local).AddTicks(5379));

            migrationBuilder.UpdateData(
                table: "ClientAccountTypes",
                keyColumn: "ID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 884, DateTimeKind.Local).AddTicks(2632));

            migrationBuilder.UpdateData(
                table: "ClientAccountTypes",
                keyColumn: "ID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 884, DateTimeKind.Local).AddTicks(3773));

            migrationBuilder.UpdateData(
                table: "ClientGroups",
                keyColumn: "ClientGroupID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 894, DateTimeKind.Local).AddTicks(4420));

            migrationBuilder.UpdateData(
                table: "ClientGroups",
                keyColumn: "ClientGroupID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 894, DateTimeKind.Local).AddTicks(5211));

            migrationBuilder.UpdateData(
                table: "ContactTypes",
                keyColumn: "ContactTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 816, DateTimeKind.Local).AddTicks(8511));

            migrationBuilder.UpdateData(
                table: "ContactTypes",
                keyColumn: "ContactTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 816, DateTimeKind.Local).AddTicks(8505));

            migrationBuilder.UpdateData(
                table: "ContactTypes",
                keyColumn: "ContactTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 816, DateTimeKind.Local).AddTicks(8496));

            migrationBuilder.UpdateData(
                table: "ContactTypes",
                keyColumn: "ContactTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 816, DateTimeKind.Local).AddTicks(8288));

            migrationBuilder.UpdateData(
                table: "ContactTypes",
                keyColumn: "ContactTypeID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 816, DateTimeKind.Local).AddTicks(8516));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 826, DateTimeKind.Local).AddTicks(2470));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 826, DateTimeKind.Local).AddTicks(3340));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 826, DateTimeKind.Local).AddTicks(3354));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 826, DateTimeKind.Local).AddTicks(3368));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 826, DateTimeKind.Local).AddTicks(3373));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 826, DateTimeKind.Local).AddTicks(3389));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 826, DateTimeKind.Local).AddTicks(3394));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 826, DateTimeKind.Local).AddTicks(3400));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 826, DateTimeKind.Local).AddTicks(3405));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 826, DateTimeKind.Local).AddTicks(3484));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 826, DateTimeKind.Local).AddTicks(3491));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 826, DateTimeKind.Local).AddTicks(3495));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 13,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 826, DateTimeKind.Local).AddTicks(3499));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 14,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 826, DateTimeKind.Local).AddTicks(3502));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 15,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 826, DateTimeKind.Local).AddTicks(3507));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 16,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 826, DateTimeKind.Local).AddTicks(3512));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 17,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 826, DateTimeKind.Local).AddTicks(3516));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 18,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 826, DateTimeKind.Local).AddTicks(3524));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 19,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 826, DateTimeKind.Local).AddTicks(3529));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 20,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 826, DateTimeKind.Local).AddTicks(3533));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 21,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 826, DateTimeKind.Local).AddTicks(3537));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 22,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 826, DateTimeKind.Local).AddTicks(3543));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 23,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 826, DateTimeKind.Local).AddTicks(3548));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 24,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 826, DateTimeKind.Local).AddTicks(3552));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 25,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 826, DateTimeKind.Local).AddTicks(3556));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 26,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 826, DateTimeKind.Local).AddTicks(3560));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 27,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 826, DateTimeKind.Local).AddTicks(3565));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 28,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 826, DateTimeKind.Local).AddTicks(3570));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 29,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 826, DateTimeKind.Local).AddTicks(3574));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 30,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 826, DateTimeKind.Local).AddTicks(3581));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 31,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 826, DateTimeKind.Local).AddTicks(3585));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 32,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 826, DateTimeKind.Local).AddTicks(3590));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 33,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 826, DateTimeKind.Local).AddTicks(3595));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 34,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 826, DateTimeKind.Local).AddTicks(3602));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 35,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 826, DateTimeKind.Local).AddTicks(3607));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 36,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 826, DateTimeKind.Local).AddTicks(3612));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 37,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 826, DateTimeKind.Local).AddTicks(3616));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 38,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 826, DateTimeKind.Local).AddTicks(3620));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 39,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 826, DateTimeKind.Local).AddTicks(3626));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 40,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 826, DateTimeKind.Local).AddTicks(3631));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 41,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 826, DateTimeKind.Local).AddTicks(3638));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 42,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 826, DateTimeKind.Local).AddTicks(3642));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 43,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 826, DateTimeKind.Local).AddTicks(3650));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 44,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 826, DateTimeKind.Local).AddTicks(3654));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 45,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 826, DateTimeKind.Local).AddTicks(3658));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 46,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 826, DateTimeKind.Local).AddTicks(3663));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 47,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 826, DateTimeKind.Local).AddTicks(3670));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 48,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 826, DateTimeKind.Local).AddTicks(3676));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 49,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 826, DateTimeKind.Local).AddTicks(3681));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 50,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 826, DateTimeKind.Local).AddTicks(3687));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 51,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 826, DateTimeKind.Local).AddTicks(3692));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 52,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 826, DateTimeKind.Local).AddTicks(3707));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 53,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 826, DateTimeKind.Local).AddTicks(3713));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 54,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 826, DateTimeKind.Local).AddTicks(3718));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 55,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 826, DateTimeKind.Local).AddTicks(3722));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 56,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 826, DateTimeKind.Local).AddTicks(3727));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 57,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 826, DateTimeKind.Local).AddTicks(3731));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 58,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 826, DateTimeKind.Local).AddTicks(3736));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 59,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 826, DateTimeKind.Local).AddTicks(3742));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 60,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 826, DateTimeKind.Local).AddTicks(3747));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 61,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 826, DateTimeKind.Local).AddTicks(3751));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 62,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 826, DateTimeKind.Local).AddTicks(3756));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 63,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 826, DateTimeKind.Local).AddTicks(3761));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 64,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 826, DateTimeKind.Local).AddTicks(3770));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 65,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 826, DateTimeKind.Local).AddTicks(3775));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 66,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 826, DateTimeKind.Local).AddTicks(3827));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 67,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 826, DateTimeKind.Local).AddTicks(3832));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 68,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 826, DateTimeKind.Local).AddTicks(3837));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 69,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 826, DateTimeKind.Local).AddTicks(3842));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 70,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 826, DateTimeKind.Local).AddTicks(3846));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 71,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 826, DateTimeKind.Local).AddTicks(3851));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 72,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 826, DateTimeKind.Local).AddTicks(3856));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 73,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 826, DateTimeKind.Local).AddTicks(3862));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 74,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 826, DateTimeKind.Local).AddTicks(3866));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 75,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 826, DateTimeKind.Local).AddTicks(3872));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 76,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 826, DateTimeKind.Local).AddTicks(3877));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 77,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 826, DateTimeKind.Local).AddTicks(3881));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 78,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 826, DateTimeKind.Local).AddTicks(3885));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 79,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 826, DateTimeKind.Local).AddTicks(3890));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 80,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 826, DateTimeKind.Local).AddTicks(3896));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 81,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 826, DateTimeKind.Local).AddTicks(3900));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 82,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 826, DateTimeKind.Local).AddTicks(3905));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 83,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 826, DateTimeKind.Local).AddTicks(3910));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 84,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 826, DateTimeKind.Local).AddTicks(3915));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 85,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 826, DateTimeKind.Local).AddTicks(3919));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 86,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 826, DateTimeKind.Local).AddTicks(3923));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 87,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 826, DateTimeKind.Local).AddTicks(3928));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 88,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 826, DateTimeKind.Local).AddTicks(3933));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 89,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 826, DateTimeKind.Local).AddTicks(3938));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 90,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 826, DateTimeKind.Local).AddTicks(3942));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 91,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 826, DateTimeKind.Local).AddTicks(3947));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 92,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 826, DateTimeKind.Local).AddTicks(3951));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 93,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 826, DateTimeKind.Local).AddTicks(3956));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 94,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 826, DateTimeKind.Local).AddTicks(3961));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 95,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 826, DateTimeKind.Local).AddTicks(3965));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 96,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 826, DateTimeKind.Local).AddTicks(3969));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 97,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 826, DateTimeKind.Local).AddTicks(3974));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 98,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 826, DateTimeKind.Local).AddTicks(3978));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 99,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 826, DateTimeKind.Local).AddTicks(3982));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 100,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 826, DateTimeKind.Local).AddTicks(3987));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 101,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 826, DateTimeKind.Local).AddTicks(3992));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 102,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 826, DateTimeKind.Local).AddTicks(3996));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 103,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 826, DateTimeKind.Local).AddTicks(4001));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 104,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 826, DateTimeKind.Local).AddTicks(4005));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 105,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 826, DateTimeKind.Local).AddTicks(4010));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 106,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 826, DateTimeKind.Local).AddTicks(4014));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 107,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 826, DateTimeKind.Local).AddTicks(4018));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 108,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 826, DateTimeKind.Local).AddTicks(4023));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 109,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 826, DateTimeKind.Local).AddTicks(4027));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 110,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 826, DateTimeKind.Local).AddTicks(4031));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 111,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 826, DateTimeKind.Local).AddTicks(4040));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 112,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 826, DateTimeKind.Local).AddTicks(4045));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 113,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 826, DateTimeKind.Local).AddTicks(4049));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 114,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 826, DateTimeKind.Local).AddTicks(4054));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 115,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 826, DateTimeKind.Local).AddTicks(4059));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 116,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 826, DateTimeKind.Local).AddTicks(4064));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 117,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 826, DateTimeKind.Local).AddTicks(4069));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 118,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 826, DateTimeKind.Local).AddTicks(4074));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 119,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 826, DateTimeKind.Local).AddTicks(4078));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 120,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 826, DateTimeKind.Local).AddTicks(4081));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 121,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 826, DateTimeKind.Local).AddTicks(4086));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 122,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 826, DateTimeKind.Local).AddTicks(4090));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 123,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 826, DateTimeKind.Local).AddTicks(4095));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 124,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 826, DateTimeKind.Local).AddTicks(4099));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 125,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 826, DateTimeKind.Local).AddTicks(4103));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 126,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 826, DateTimeKind.Local).AddTicks(4107));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 127,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 826, DateTimeKind.Local).AddTicks(4111));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 128,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 826, DateTimeKind.Local).AddTicks(4116));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 129,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 826, DateTimeKind.Local).AddTicks(4121));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 130,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 826, DateTimeKind.Local).AddTicks(4184));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 131,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 826, DateTimeKind.Local).AddTicks(4196));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 132,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 826, DateTimeKind.Local).AddTicks(4203));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 133,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 826, DateTimeKind.Local).AddTicks(4209));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 134,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 826, DateTimeKind.Local).AddTicks(4214));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 135,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 826, DateTimeKind.Local).AddTicks(4219));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 136,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 826, DateTimeKind.Local).AddTicks(4223));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 137,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 826, DateTimeKind.Local).AddTicks(4228));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 138,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 826, DateTimeKind.Local).AddTicks(4234));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 139,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 826, DateTimeKind.Local).AddTicks(4238));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 140,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 826, DateTimeKind.Local).AddTicks(4243));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 141,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 826, DateTimeKind.Local).AddTicks(4247));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 142,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 826, DateTimeKind.Local).AddTicks(4251));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 143,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 826, DateTimeKind.Local).AddTicks(4256));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 144,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 826, DateTimeKind.Local).AddTicks(4260));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 145,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 826, DateTimeKind.Local).AddTicks(4265));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 146,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 826, DateTimeKind.Local).AddTicks(4270));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 147,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 826, DateTimeKind.Local).AddTicks(4274));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 148,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 826, DateTimeKind.Local).AddTicks(4279));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 149,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 826, DateTimeKind.Local).AddTicks(4286));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 150,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 826, DateTimeKind.Local).AddTicks(4292));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 151,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 826, DateTimeKind.Local).AddTicks(4297));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 152,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 826, DateTimeKind.Local).AddTicks(4302));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 153,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 826, DateTimeKind.Local).AddTicks(4306));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 154,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 826, DateTimeKind.Local).AddTicks(4311));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 155,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 826, DateTimeKind.Local).AddTicks(4317));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 156,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 826, DateTimeKind.Local).AddTicks(4321));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 157,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 826, DateTimeKind.Local).AddTicks(4326));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 158,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 826, DateTimeKind.Local).AddTicks(4330));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 159,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 826, DateTimeKind.Local).AddTicks(4335));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 160,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 826, DateTimeKind.Local).AddTicks(4339));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 161,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 826, DateTimeKind.Local).AddTicks(4345));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 162,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 826, DateTimeKind.Local).AddTicks(4349));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 163,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 826, DateTimeKind.Local).AddTicks(4353));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 164,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 826, DateTimeKind.Local).AddTicks(4357));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 165,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 826, DateTimeKind.Local).AddTicks(4362));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 166,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 826, DateTimeKind.Local).AddTicks(4366));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 167,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 826, DateTimeKind.Local).AddTicks(4371));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 168,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 826, DateTimeKind.Local).AddTicks(4375));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 169,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 826, DateTimeKind.Local).AddTicks(4379));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 170,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 826, DateTimeKind.Local).AddTicks(4383));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 171,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 826, DateTimeKind.Local).AddTicks(4387));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 172,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 826, DateTimeKind.Local).AddTicks(4391));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 173,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 826, DateTimeKind.Local).AddTicks(4396));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 174,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 826, DateTimeKind.Local).AddTicks(4402));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 175,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 826, DateTimeKind.Local).AddTicks(4407));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 176,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 826, DateTimeKind.Local).AddTicks(4412));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 177,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 826, DateTimeKind.Local).AddTicks(4419));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 178,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 826, DateTimeKind.Local).AddTicks(4423));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 179,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 826, DateTimeKind.Local).AddTicks(4428));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 180,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 826, DateTimeKind.Local).AddTicks(4433));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 181,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 826, DateTimeKind.Local).AddTicks(4437));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 182,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 826, DateTimeKind.Local).AddTicks(4442));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 183,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 826, DateTimeKind.Local).AddTicks(4446));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 184,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 826, DateTimeKind.Local).AddTicks(4451));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 185,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 826, DateTimeKind.Local).AddTicks(4455));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 186,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 826, DateTimeKind.Local).AddTicks(4530));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 187,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 826, DateTimeKind.Local).AddTicks(4536));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 188,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 826, DateTimeKind.Local).AddTicks(4541));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 189,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 826, DateTimeKind.Local).AddTicks(4547));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 190,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 826, DateTimeKind.Local).AddTicks(4551));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 191,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 826, DateTimeKind.Local).AddTicks(4556));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 192,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 826, DateTimeKind.Local).AddTicks(4561));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 193,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 826, DateTimeKind.Local).AddTicks(4566));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 194,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 826, DateTimeKind.Local).AddTicks(4671));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 195,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 826, DateTimeKind.Local).AddTicks(4677));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 196,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 826, DateTimeKind.Local).AddTicks(4681));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 197,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 826, DateTimeKind.Local).AddTicks(4686));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 198,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 826, DateTimeKind.Local).AddTicks(4691));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 199,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 826, DateTimeKind.Local).AddTicks(4695));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 200,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 826, DateTimeKind.Local).AddTicks(4699));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 201,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 826, DateTimeKind.Local).AddTicks(4704));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 202,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 826, DateTimeKind.Local).AddTicks(4708));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 203,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 826, DateTimeKind.Local).AddTicks(4713));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 204,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 826, DateTimeKind.Local).AddTicks(4717));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 205,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 826, DateTimeKind.Local).AddTicks(4723));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 206,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 826, DateTimeKind.Local).AddTicks(4728));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 207,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 826, DateTimeKind.Local).AddTicks(4733));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 208,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 826, DateTimeKind.Local).AddTicks(4736));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 209,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 826, DateTimeKind.Local).AddTicks(4741));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 210,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 826, DateTimeKind.Local).AddTicks(4746));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 211,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 826, DateTimeKind.Local).AddTicks(4752));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 212,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 826, DateTimeKind.Local).AddTicks(4756));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 213,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 826, DateTimeKind.Local).AddTicks(4760));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 214,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 826, DateTimeKind.Local).AddTicks(4766));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 215,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 826, DateTimeKind.Local).AddTicks(4771));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 216,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 826, DateTimeKind.Local).AddTicks(4777));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 217,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 826, DateTimeKind.Local).AddTicks(4782));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 218,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 826, DateTimeKind.Local).AddTicks(4786));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 219,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 826, DateTimeKind.Local).AddTicks(4790));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 220,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 826, DateTimeKind.Local).AddTicks(4794));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 221,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 826, DateTimeKind.Local).AddTicks(4798));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 222,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 826, DateTimeKind.Local).AddTicks(4802));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 223,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 826, DateTimeKind.Local).AddTicks(4807));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 224,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 826, DateTimeKind.Local).AddTicks(4812));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 225,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 826, DateTimeKind.Local).AddTicks(4816));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 226,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 826, DateTimeKind.Local).AddTicks(4820));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 227,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 826, DateTimeKind.Local).AddTicks(4825));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 228,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 826, DateTimeKind.Local).AddTicks(4829));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 808, DateTimeKind.Local).AddTicks(6318));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 808, DateTimeKind.Local).AddTicks(6875));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 808, DateTimeKind.Local).AddTicks(6884));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 808, DateTimeKind.Local).AddTicks(6888));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 808, DateTimeKind.Local).AddTicks(6892));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 808, DateTimeKind.Local).AddTicks(6906));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 808, DateTimeKind.Local).AddTicks(6909));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 808, DateTimeKind.Local).AddTicks(6913));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 808, DateTimeKind.Local).AddTicks(6916));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 808, DateTimeKind.Local).AddTicks(6921));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 808, DateTimeKind.Local).AddTicks(6925));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 808, DateTimeKind.Local).AddTicks(6928));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 13,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 808, DateTimeKind.Local).AddTicks(6932));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 14,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 808, DateTimeKind.Local).AddTicks(6935));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 15,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 808, DateTimeKind.Local).AddTicks(6938));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 16,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 808, DateTimeKind.Local).AddTicks(6942));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 17,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 808, DateTimeKind.Local).AddTicks(6945));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 18,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 808, DateTimeKind.Local).AddTicks(6951));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 19,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 808, DateTimeKind.Local).AddTicks(6954));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 20,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 808, DateTimeKind.Local).AddTicks(6957));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 21,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 808, DateTimeKind.Local).AddTicks(6962));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 22,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 808, DateTimeKind.Local).AddTicks(6965));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 23,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 808, DateTimeKind.Local).AddTicks(6969));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 24,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 808, DateTimeKind.Local).AddTicks(6972));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 25,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 808, DateTimeKind.Local).AddTicks(6977));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 26,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 808, DateTimeKind.Local).AddTicks(6980));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 27,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 808, DateTimeKind.Local).AddTicks(6983));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 28,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 808, DateTimeKind.Local).AddTicks(6987));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 29,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 808, DateTimeKind.Local).AddTicks(6990));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 30,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 808, DateTimeKind.Local).AddTicks(6994));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 31,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 808, DateTimeKind.Local).AddTicks(6997));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 32,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 808, DateTimeKind.Local).AddTicks(7001));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 33,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 808, DateTimeKind.Local).AddTicks(7004));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 34,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 808, DateTimeKind.Local).AddTicks(7077));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 35,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 808, DateTimeKind.Local).AddTicks(7081));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 36,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 808, DateTimeKind.Local).AddTicks(7085));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 37,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 808, DateTimeKind.Local).AddTicks(7088));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 38,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 808, DateTimeKind.Local).AddTicks(7091));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 39,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 808, DateTimeKind.Local).AddTicks(7095));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 40,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 808, DateTimeKind.Local).AddTicks(7098));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 41,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 808, DateTimeKind.Local).AddTicks(7103));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 42,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 808, DateTimeKind.Local).AddTicks(7107));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 43,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 808, DateTimeKind.Local).AddTicks(7110));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 44,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 808, DateTimeKind.Local).AddTicks(7114));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 45,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 808, DateTimeKind.Local).AddTicks(7117));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 46,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 808, DateTimeKind.Local).AddTicks(7121));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 47,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 808, DateTimeKind.Local).AddTicks(7124));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 48,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 808, DateTimeKind.Local).AddTicks(7127));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 49,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 808, DateTimeKind.Local).AddTicks(7131));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 50,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 808, DateTimeKind.Local).AddTicks(7134));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 51,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 808, DateTimeKind.Local).AddTicks(7138));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 52,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 808, DateTimeKind.Local).AddTicks(7141));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 53,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 808, DateTimeKind.Local).AddTicks(7145));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 54,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 808, DateTimeKind.Local).AddTicks(7148));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 55,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 808, DateTimeKind.Local).AddTicks(7151));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 56,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 808, DateTimeKind.Local).AddTicks(7155));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 57,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 808, DateTimeKind.Local).AddTicks(7158));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 58,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 808, DateTimeKind.Local).AddTicks(7162));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 59,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 808, DateTimeKind.Local).AddTicks(7165));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 60,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 808, DateTimeKind.Local).AddTicks(7168));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 61,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 808, DateTimeKind.Local).AddTicks(7172));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 62,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 808, DateTimeKind.Local).AddTicks(7176));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 63,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 808, DateTimeKind.Local).AddTicks(7179));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 64,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 808, DateTimeKind.Local).AddTicks(7183));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 65,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 808, DateTimeKind.Local).AddTicks(7186));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 66,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 808, DateTimeKind.Local).AddTicks(7192));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 67,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 808, DateTimeKind.Local).AddTicks(7196));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 68,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 808, DateTimeKind.Local).AddTicks(7199));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 69,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 808, DateTimeKind.Local).AddTicks(7203));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 70,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 808, DateTimeKind.Local).AddTicks(7206));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 71,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 808, DateTimeKind.Local).AddTicks(7209));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 72,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 808, DateTimeKind.Local).AddTicks(7213));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 73,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 808, DateTimeKind.Local).AddTicks(7216));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 74,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 808, DateTimeKind.Local).AddTicks(7220));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 75,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 808, DateTimeKind.Local).AddTicks(7223));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 76,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 808, DateTimeKind.Local).AddTicks(7226));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 77,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 808, DateTimeKind.Local).AddTicks(7230));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 78,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 808, DateTimeKind.Local).AddTicks(7233));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 79,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 808, DateTimeKind.Local).AddTicks(7237));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 80,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 808, DateTimeKind.Local).AddTicks(7240));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 81,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 808, DateTimeKind.Local).AddTicks(7243));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 82,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 808, DateTimeKind.Local).AddTicks(7247));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 83,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 808, DateTimeKind.Local).AddTicks(7251));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 84,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 808, DateTimeKind.Local).AddTicks(7254));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 85,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 808, DateTimeKind.Local).AddTicks(7258));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 86,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 808, DateTimeKind.Local).AddTicks(7261));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 87,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 808, DateTimeKind.Local).AddTicks(7265));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 88,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 808, DateTimeKind.Local).AddTicks(7268));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 89,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 808, DateTimeKind.Local).AddTicks(7271));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 90,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 808, DateTimeKind.Local).AddTicks(7275));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 91,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 808, DateTimeKind.Local).AddTicks(7278));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 92,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 808, DateTimeKind.Local).AddTicks(7281));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 93,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 808, DateTimeKind.Local).AddTicks(7285));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 94,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 808, DateTimeKind.Local).AddTicks(7288));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 95,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 808, DateTimeKind.Local).AddTicks(7292));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 96,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 808, DateTimeKind.Local).AddTicks(7295));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 97,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 808, DateTimeKind.Local).AddTicks(7298));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 98,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 808, DateTimeKind.Local).AddTicks(7343));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 99,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 808, DateTimeKind.Local).AddTicks(7347));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 100,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 808, DateTimeKind.Local).AddTicks(7351));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 101,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 808, DateTimeKind.Local).AddTicks(7354));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 102,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 808, DateTimeKind.Local).AddTicks(7358));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 103,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 808, DateTimeKind.Local).AddTicks(7361));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 104,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 808, DateTimeKind.Local).AddTicks(7365));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 105,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 808, DateTimeKind.Local).AddTicks(7369));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 106,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 808, DateTimeKind.Local).AddTicks(7372));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 107,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 808, DateTimeKind.Local).AddTicks(7376));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 108,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 808, DateTimeKind.Local).AddTicks(7379));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 109,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 808, DateTimeKind.Local).AddTicks(7383));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 110,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 808, DateTimeKind.Local).AddTicks(7386));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 111,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 808, DateTimeKind.Local).AddTicks(7389));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 112,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 808, DateTimeKind.Local).AddTicks(7393));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 113,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 808, DateTimeKind.Local).AddTicks(7396));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 114,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 808, DateTimeKind.Local).AddTicks(7400));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 115,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 808, DateTimeKind.Local).AddTicks(7403));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 116,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 808, DateTimeKind.Local).AddTicks(7406));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 117,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 808, DateTimeKind.Local).AddTicks(7410));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 118,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 808, DateTimeKind.Local).AddTicks(7413));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 119,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 808, DateTimeKind.Local).AddTicks(7416));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 120,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 808, DateTimeKind.Local).AddTicks(7420));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 121,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 808, DateTimeKind.Local).AddTicks(7423));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 122,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 808, DateTimeKind.Local).AddTicks(7426));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 123,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 808, DateTimeKind.Local).AddTicks(7430));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 124,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 808, DateTimeKind.Local).AddTicks(7434));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 125,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 808, DateTimeKind.Local).AddTicks(7437));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 126,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 808, DateTimeKind.Local).AddTicks(7441));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 127,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 808, DateTimeKind.Local).AddTicks(7444));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 128,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 808, DateTimeKind.Local).AddTicks(7447));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 129,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 808, DateTimeKind.Local).AddTicks(7451));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 130,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 808, DateTimeKind.Local).AddTicks(7457));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 131,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 808, DateTimeKind.Local).AddTicks(7460));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 132,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 808, DateTimeKind.Local).AddTicks(7463));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 133,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 808, DateTimeKind.Local).AddTicks(7467));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 134,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 808, DateTimeKind.Local).AddTicks(7470));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 135,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 808, DateTimeKind.Local).AddTicks(7474));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 136,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 808, DateTimeKind.Local).AddTicks(7477));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 137,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 808, DateTimeKind.Local).AddTicks(7481));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 138,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 808, DateTimeKind.Local).AddTicks(7484));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 139,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 808, DateTimeKind.Local).AddTicks(7487));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 140,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 808, DateTimeKind.Local).AddTicks(7491));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 141,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 808, DateTimeKind.Local).AddTicks(7494));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 142,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 808, DateTimeKind.Local).AddTicks(7497));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 143,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 808, DateTimeKind.Local).AddTicks(7501));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 144,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 808, DateTimeKind.Local).AddTicks(7504));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 145,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 808, DateTimeKind.Local).AddTicks(7508));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 146,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 808, DateTimeKind.Local).AddTicks(7511));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 147,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 808, DateTimeKind.Local).AddTicks(7515));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 148,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 808, DateTimeKind.Local).AddTicks(7518));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 149,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 808, DateTimeKind.Local).AddTicks(7522));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 150,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 808, DateTimeKind.Local).AddTicks(7525));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 151,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 808, DateTimeKind.Local).AddTicks(7528));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 152,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 808, DateTimeKind.Local).AddTicks(7531));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 153,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 808, DateTimeKind.Local).AddTicks(7535));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 154,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 808, DateTimeKind.Local).AddTicks(7538));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 155,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 808, DateTimeKind.Local).AddTicks(7542));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 156,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 808, DateTimeKind.Local).AddTicks(7545));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 157,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 808, DateTimeKind.Local).AddTicks(7583));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 158,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 808, DateTimeKind.Local).AddTicks(7587));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 159,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 808, DateTimeKind.Local).AddTicks(7590));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 160,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 808, DateTimeKind.Local).AddTicks(7594));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 161,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 808, DateTimeKind.Local).AddTicks(7597));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 162,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 808, DateTimeKind.Local).AddTicks(7600));

            migrationBuilder.UpdateData(
                table: "CustomSettingTypes",
                keyColumn: "CustomSettingTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 819, DateTimeKind.Local).AddTicks(2842));

            migrationBuilder.UpdateData(
                table: "CustomSettingTypes",
                keyColumn: "CustomSettingTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 819, DateTimeKind.Local).AddTicks(3010));

            migrationBuilder.UpdateData(
                table: "CustomSettingTypes",
                keyColumn: "CustomSettingTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 819, DateTimeKind.Local).AddTicks(3015));

            migrationBuilder.UpdateData(
                table: "CustomSettingTypes",
                keyColumn: "CustomSettingTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 819, DateTimeKind.Local).AddTicks(3019));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 864, DateTimeKind.Local).AddTicks(7598));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 864, DateTimeKind.Local).AddTicks(7872));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 864, DateTimeKind.Local).AddTicks(8011));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 864, DateTimeKind.Local).AddTicks(7881));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 864, DateTimeKind.Local).AddTicks(8024));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 864, DateTimeKind.Local).AddTicks(8039));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 864, DateTimeKind.Local).AddTicks(8050));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 864, DateTimeKind.Local).AddTicks(8058));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 864, DateTimeKind.Local).AddTicks(8067));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 864, DateTimeKind.Local).AddTicks(8075));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 864, DateTimeKind.Local).AddTicks(8141));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 864, DateTimeKind.Local).AddTicks(8150));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 13,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 864, DateTimeKind.Local).AddTicks(8158));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 14,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 864, DateTimeKind.Local).AddTicks(8166));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 15,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 864, DateTimeKind.Local).AddTicks(7889));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 16,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 864, DateTimeKind.Local).AddTicks(7862));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 17,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 864, DateTimeKind.Local).AddTicks(8176));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 18,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 864, DateTimeKind.Local).AddTicks(8183));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 19,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 864, DateTimeKind.Local).AddTicks(8190));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 20,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 864, DateTimeKind.Local).AddTicks(8198));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 22,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 864, DateTimeKind.Local).AddTicks(8225));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 23,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 864, DateTimeKind.Local).AddTicks(8213));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 24,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 864, DateTimeKind.Local).AddTicks(8206));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 25,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 864, DateTimeKind.Local).AddTicks(8220));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 26,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 864, DateTimeKind.Local).AddTicks(8233));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 27,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 864, DateTimeKind.Local).AddTicks(8240));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 28,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 864, DateTimeKind.Local).AddTicks(8246));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 30,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 864, DateTimeKind.Local).AddTicks(8253));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 31,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 864, DateTimeKind.Local).AddTicks(8259));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 32,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 864, DateTimeKind.Local).AddTicks(8265));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 33,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 864, DateTimeKind.Local).AddTicks(8272));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 34,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 864, DateTimeKind.Local).AddTicks(8280));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 36,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 864, DateTimeKind.Local).AddTicks(8290));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 37,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 864, DateTimeKind.Local).AddTicks(8297));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 38,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 864, DateTimeKind.Local).AddTicks(8304));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 39,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 864, DateTimeKind.Local).AddTicks(8031));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 40,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 864, DateTimeKind.Local).AddTicks(8312));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 41,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 864, DateTimeKind.Local).AddTicks(8319));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 42,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 864, DateTimeKind.Local).AddTicks(8326));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 43,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 864, DateTimeKind.Local).AddTicks(8333));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 44,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 864, DateTimeKind.Local).AddTicks(8339));

            migrationBuilder.UpdateData(
                table: "DocumentFormats",
                keyColumn: "DocumentFormatID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 841, DateTimeKind.Local).AddTicks(5742));

            migrationBuilder.UpdateData(
                table: "DocumentFormats",
                keyColumn: "DocumentFormatID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 841, DateTimeKind.Local).AddTicks(6461));

            migrationBuilder.UpdateData(
                table: "DocumentFormats",
                keyColumn: "DocumentFormatID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 841, DateTimeKind.Local).AddTicks(6474));

            migrationBuilder.UpdateData(
                table: "DocumentFormats",
                keyColumn: "DocumentFormatID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 841, DateTimeKind.Local).AddTicks(6479));

            migrationBuilder.UpdateData(
                table: "DocumentFormats",
                keyColumn: "DocumentFormatID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 841, DateTimeKind.Local).AddTicks(6483));

            migrationBuilder.UpdateData(
                table: "DocumentFormats",
                keyColumn: "DocumentFormatID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 841, DateTimeKind.Local).AddTicks(6496));

            migrationBuilder.UpdateData(
                table: "DocumentTypes",
                keyColumn: "DocumentTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 845, DateTimeKind.Local).AddTicks(9476));

            migrationBuilder.UpdateData(
                table: "DocumentTypes",
                keyColumn: "DocumentTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 846, DateTimeKind.Local).AddTicks(2449));

            migrationBuilder.UpdateData(
                table: "DocumentTypes",
                keyColumn: "DocumentTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 846, DateTimeKind.Local).AddTicks(2515));

            migrationBuilder.UpdateData(
                table: "DocumentTypes",
                keyColumn: "DocumentTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 846, DateTimeKind.Local).AddTicks(2525));

            migrationBuilder.UpdateData(
                table: "EmailTemplates",
                keyColumn: "EmailTemplateID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 858, DateTimeKind.Local).AddTicks(9038));

            migrationBuilder.UpdateData(
                table: "EmailTypes",
                keyColumn: "EmailTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 858, DateTimeKind.Local).AddTicks(1730));

            migrationBuilder.UpdateData(
                table: "EmailTypes",
                keyColumn: "EmailTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 858, DateTimeKind.Local).AddTicks(2236));

            migrationBuilder.UpdateData(
                table: "EmailTypes",
                keyColumn: "EmailTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 858, DateTimeKind.Local).AddTicks(2244));

            migrationBuilder.UpdateData(
                table: "EmailTypes",
                keyColumn: "EmailTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 858, DateTimeKind.Local).AddTicks(2251));

            migrationBuilder.UpdateData(
                table: "FeatureFlags",
                keyColumn: "FeatureFlagID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 837, DateTimeKind.Local).AddTicks(6038));

            migrationBuilder.UpdateData(
                table: "FeatureFlags",
                keyColumn: "FeatureFlagID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 837, DateTimeKind.Local).AddTicks(6796));

            migrationBuilder.UpdateData(
                table: "FeatureFlags",
                keyColumn: "FeatureFlagID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 837, DateTimeKind.Local).AddTicks(6814));

            migrationBuilder.UpdateData(
                table: "Frequencies",
                keyColumn: "FrequencyID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 811, DateTimeKind.Local).AddTicks(7730));

            migrationBuilder.UpdateData(
                table: "Frequencies",
                keyColumn: "FrequencyID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 811, DateTimeKind.Local).AddTicks(8226));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "GenderID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 822, DateTimeKind.Local).AddTicks(2139));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "GenderID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 822, DateTimeKind.Local).AddTicks(2573));

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "InvoiceStatusID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 898, DateTimeKind.Local).AddTicks(2441));

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "InvoiceStatusID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 898, DateTimeKind.Local).AddTicks(2898));

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "InvoiceStatusID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 898, DateTimeKind.Local).AddTicks(2904));

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "InvoiceStatusID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 898, DateTimeKind.Local).AddTicks(2907));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 849, DateTimeKind.Local).AddTicks(3900));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 849, DateTimeKind.Local).AddTicks(4119));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 849, DateTimeKind.Local).AddTicks(4135));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 849, DateTimeKind.Local).AddTicks(4232));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 849, DateTimeKind.Local).AddTicks(4240));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 849, DateTimeKind.Local).AddTicks(4266));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 999,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 849, DateTimeKind.Local).AddTicks(4260));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 9998,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 849, DateTimeKind.Local).AddTicks(4253));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 852, DateTimeKind.Local).AddTicks(681));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 852, DateTimeKind.Local).AddTicks(895));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 852, DateTimeKind.Local).AddTicks(902));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 852, DateTimeKind.Local).AddTicks(906));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 852, DateTimeKind.Local).AddTicks(910));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 852, DateTimeKind.Local).AddTicks(921));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 852, DateTimeKind.Local).AddTicks(925));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 852, DateTimeKind.Local).AddTicks(929));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 852, DateTimeKind.Local).AddTicks(934));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 852, DateTimeKind.Local).AddTicks(940));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 852, DateTimeKind.Local).AddTicks(943));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 13,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 852, DateTimeKind.Local).AddTicks(948));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 14,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 852, DateTimeKind.Local).AddTicks(952));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 15,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 852, DateTimeKind.Local).AddTicks(956));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 16,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 852, DateTimeKind.Local).AddTicks(960));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 17,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 852, DateTimeKind.Local).AddTicks(964));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 18,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 852, DateTimeKind.Local).AddTicks(968));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 19,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 852, DateTimeKind.Local).AddTicks(973));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 20,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 852, DateTimeKind.Local).AddTicks(977));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 9998,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 852, DateTimeKind.Local).AddTicks(985));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 9999,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 852, DateTimeKind.Local).AddTicks(989));

            migrationBuilder.InsertData(
                table: "Menus",
                columns: new[] { "MenuID", "ActionName", "CSSClass", "ControllerName", "DisplayName", "IsActive", "LastChangedBy", "LastChangedDate", "MenuGroupID", "OrderNo" },
                values: new object[] { 9997, "Maintanance", "fa  fa-wrench", "Maintanance", "Maintanance", true, "SuperUser", new DateTime(2021, 5, 1, 14, 42, 29, 852, DateTimeKind.Local).AddTicks(981), 999, 9997 });

            migrationBuilder.UpdateData(
                table: "PaymentStatus",
                keyColumn: "PaymentStatusID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 797, DateTimeKind.Local).AddTicks(8502));

            migrationBuilder.UpdateData(
                table: "PaymentStatus",
                keyColumn: "PaymentStatusID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 797, DateTimeKind.Local).AddTicks(9049));

            migrationBuilder.UpdateData(
                table: "PaymentStatus",
                keyColumn: "PaymentStatusID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 797, DateTimeKind.Local).AddTicks(9056));

            migrationBuilder.UpdateData(
                table: "PaymentStatus",
                keyColumn: "PaymentStatusID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 797, DateTimeKind.Local).AddTicks(9060));

            migrationBuilder.UpdateData(
                table: "PaymentStatus",
                keyColumn: "PaymentStatusID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 797, DateTimeKind.Local).AddTicks(9065));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 793, DateTimeKind.Local).AddTicks(2184));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 793, DateTimeKind.Local).AddTicks(3010));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 793, DateTimeKind.Local).AddTicks(3024));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 793, DateTimeKind.Local).AddTicks(3030));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 793, DateTimeKind.Local).AddTicks(3036));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 793, DateTimeKind.Local).AddTicks(3053));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 793, DateTimeKind.Local).AddTicks(3187));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 793, DateTimeKind.Local).AddTicks(3198));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 793, DateTimeKind.Local).AddTicks(3205));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 793, DateTimeKind.Local).AddTicks(3215));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 793, DateTimeKind.Local).AddTicks(3221));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 793, DateTimeKind.Local).AddTicks(3226));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 13,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 793, DateTimeKind.Local).AddTicks(3233));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 14,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 793, DateTimeKind.Local).AddTicks(3239));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 15,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 793, DateTimeKind.Local).AddTicks(3245));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 16,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 793, DateTimeKind.Local).AddTicks(3251));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 17,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 793, DateTimeKind.Local).AddTicks(3259));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 18,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 793, DateTimeKind.Local).AddTicks(3268));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 19,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 793, DateTimeKind.Local).AddTicks(3274));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 20,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 793, DateTimeKind.Local).AddTicks(3280));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 21,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 793, DateTimeKind.Local).AddTicks(3287));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 22,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 793, DateTimeKind.Local).AddTicks(3293));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 23,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 793, DateTimeKind.Local).AddTicks(3299));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 24,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 793, DateTimeKind.Local).AddTicks(3305));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 25,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 793, DateTimeKind.Local).AddTicks(3311));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 26,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 793, DateTimeKind.Local).AddTicks(3317));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 27,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 793, DateTimeKind.Local).AddTicks(3324));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 28,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 793, DateTimeKind.Local).AddTicks(3330));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 29,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 793, DateTimeKind.Local).AddTicks(3335));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 30,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 793, DateTimeKind.Local).AddTicks(3340));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 31,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 793, DateTimeKind.Local).AddTicks(3349));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 32,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 793, DateTimeKind.Local).AddTicks(3356));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 33,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 793, DateTimeKind.Local).AddTicks(3362));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 34,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 793, DateTimeKind.Local).AddTicks(3372));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 35,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 793, DateTimeKind.Local).AddTicks(3378));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 36,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 793, DateTimeKind.Local).AddTicks(3384));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 37,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 793, DateTimeKind.Local).AddTicks(3390));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 38,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 793, DateTimeKind.Local).AddTicks(3396));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 39,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 793, DateTimeKind.Local).AddTicks(3401));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 40,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 793, DateTimeKind.Local).AddTicks(3407));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 41,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 793, DateTimeKind.Local).AddTicks(3412));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 42,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 793, DateTimeKind.Local).AddTicks(3418));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 43,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 793, DateTimeKind.Local).AddTicks(3424));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 44,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 793, DateTimeKind.Local).AddTicks(3430));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 45,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 793, DateTimeKind.Local).AddTicks(3436));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 46,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 793, DateTimeKind.Local).AddTicks(3443));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 47,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 793, DateTimeKind.Local).AddTicks(3494));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 48,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 793, DateTimeKind.Local).AddTicks(3500));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 49,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 793, DateTimeKind.Local).AddTicks(3507));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 50,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 793, DateTimeKind.Local).AddTicks(3512));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 51,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 793, DateTimeKind.Local).AddTicks(3518));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 52,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 793, DateTimeKind.Local).AddTicks(3523));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 53,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 793, DateTimeKind.Local).AddTicks(3529));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 54,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 793, DateTimeKind.Local).AddTicks(3534));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 55,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 793, DateTimeKind.Local).AddTicks(3539));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 56,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 793, DateTimeKind.Local).AddTicks(3544));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 57,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 793, DateTimeKind.Local).AddTicks(3549));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 58,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 793, DateTimeKind.Local).AddTicks(3553));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 59,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 793, DateTimeKind.Local).AddTicks(3560));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 60,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 793, DateTimeKind.Local).AddTicks(3566));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 61,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 793, DateTimeKind.Local).AddTicks(3571));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 62,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 793, DateTimeKind.Local).AddTicks(3577));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 63,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 793, DateTimeKind.Local).AddTicks(3582));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 64,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 793, DateTimeKind.Local).AddTicks(3587));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 65,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 793, DateTimeKind.Local).AddTicks(3592));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 66,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 793, DateTimeKind.Local).AddTicks(3601));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 67,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 793, DateTimeKind.Local).AddTicks(3605));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 68,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 793, DateTimeKind.Local).AddTicks(3612));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 69,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 793, DateTimeKind.Local).AddTicks(3617));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 70,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 793, DateTimeKind.Local).AddTicks(3622));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 71,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 793, DateTimeKind.Local).AddTicks(3628));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 72,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 793, DateTimeKind.Local).AddTicks(3633));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 73,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 793, DateTimeKind.Local).AddTicks(3637));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 74,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 793, DateTimeKind.Local).AddTicks(3643));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 75,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 793, DateTimeKind.Local).AddTicks(3648));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 76,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 793, DateTimeKind.Local).AddTicks(3653));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 77,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 793, DateTimeKind.Local).AddTicks(3659));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 78,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 793, DateTimeKind.Local).AddTicks(3665));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 79,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 793, DateTimeKind.Local).AddTicks(3670));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 80,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 793, DateTimeKind.Local).AddTicks(3676));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 81,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 793, DateTimeKind.Local).AddTicks(3680));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 82,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 793, DateTimeKind.Local).AddTicks(3686));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 83,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 793, DateTimeKind.Local).AddTicks(3691));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 84,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 793, DateTimeKind.Local).AddTicks(3697));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 85,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 793, DateTimeKind.Local).AddTicks(3703));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 86,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 793, DateTimeKind.Local).AddTicks(3709));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 87,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 793, DateTimeKind.Local).AddTicks(3826));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 88,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 793, DateTimeKind.Local).AddTicks(3835));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 89,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 793, DateTimeKind.Local).AddTicks(3840));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 90,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 793, DateTimeKind.Local).AddTicks(3845));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 91,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 793, DateTimeKind.Local).AddTicks(3850));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 92,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 793, DateTimeKind.Local).AddTicks(3856));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 93,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 793, DateTimeKind.Local).AddTicks(3861));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 94,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 793, DateTimeKind.Local).AddTicks(3867));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 95,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 793, DateTimeKind.Local).AddTicks(3875));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 96,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 793, DateTimeKind.Local).AddTicks(3880));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 97,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 793, DateTimeKind.Local).AddTicks(3886));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 98,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 793, DateTimeKind.Local).AddTicks(3891));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 99,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 793, DateTimeKind.Local).AddTicks(3897));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 100,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 793, DateTimeKind.Local).AddTicks(3903));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 101,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 793, DateTimeKind.Local).AddTicks(3909));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 102,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 793, DateTimeKind.Local).AddTicks(3914));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 103,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 793, DateTimeKind.Local).AddTicks(3919));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 104,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 793, DateTimeKind.Local).AddTicks(3924));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 105,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 793, DateTimeKind.Local).AddTicks(3929));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 106,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 793, DateTimeKind.Local).AddTicks(3936));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 107,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 793, DateTimeKind.Local).AddTicks(3942));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 108,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 793, DateTimeKind.Local).AddTicks(3950));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 109,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 793, DateTimeKind.Local).AddTicks(3957));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 110,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 793, DateTimeKind.Local).AddTicks(3962));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 111,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 793, DateTimeKind.Local).AddTicks(3968));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 112,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 793, DateTimeKind.Local).AddTicks(3973));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 113,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 793, DateTimeKind.Local).AddTicks(3978));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 114,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 793, DateTimeKind.Local).AddTicks(3984));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 115,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 793, DateTimeKind.Local).AddTicks(3991));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 116,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 793, DateTimeKind.Local).AddTicks(3996));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 117,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 793, DateTimeKind.Local).AddTicks(4001));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 118,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 793, DateTimeKind.Local).AddTicks(4006));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 119,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 793, DateTimeKind.Local).AddTicks(4011));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 120,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 793, DateTimeKind.Local).AddTicks(4016));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 121,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 793, DateTimeKind.Local).AddTicks(4022));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 122,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 793, DateTimeKind.Local).AddTicks(4029));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 123,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 793, DateTimeKind.Local).AddTicks(4034));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 124,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 793, DateTimeKind.Local).AddTicks(4039));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 125,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 793, DateTimeKind.Local).AddTicks(4045));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 126,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 793, DateTimeKind.Local).AddTicks(4050));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 127,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 793, DateTimeKind.Local).AddTicks(4055));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 128,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 793, DateTimeKind.Local).AddTicks(4060));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 129,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 793, DateTimeKind.Local).AddTicks(4067));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 130,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 793, DateTimeKind.Local).AddTicks(4124));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 131,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 793, DateTimeKind.Local).AddTicks(4130));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 132,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 793, DateTimeKind.Local).AddTicks(4137));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 133,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 793, DateTimeKind.Local).AddTicks(4142));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 134,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 793, DateTimeKind.Local).AddTicks(4148));

            migrationBuilder.UpdateData(
                table: "PriorityRanks",
                keyColumn: "PriorityRankID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 827, DateTimeKind.Local).AddTicks(9785));

            migrationBuilder.UpdateData(
                table: "PriorityRanks",
                keyColumn: "PriorityRankID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 827, DateTimeKind.Local).AddTicks(9960));

            migrationBuilder.UpdateData(
                table: "PriorityRanks",
                keyColumn: "PriorityRankID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 827, DateTimeKind.Local).AddTicks(9967));

            migrationBuilder.UpdateData(
                table: "PriorityRanks",
                keyColumn: "PriorityRankID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 827, DateTimeKind.Local).AddTicks(9971));

            migrationBuilder.UpdateData(
                table: "RecordStatus",
                keyColumn: "RecordStatusID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 889, DateTimeKind.Local).AddTicks(4441));

            migrationBuilder.UpdateData(
                table: "RecordStatus",
                keyColumn: "RecordStatusID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 889, DateTimeKind.Local).AddTicks(5246));

            migrationBuilder.UpdateData(
                table: "RecordStatus",
                keyColumn: "RecordStatusID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 889, DateTimeKind.Local).AddTicks(5262));

            migrationBuilder.UpdateData(
                table: "RelationshipTypes",
                keyColumn: "RelationshipTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 817, DateTimeKind.Local).AddTicks(9321));

            migrationBuilder.UpdateData(
                table: "RelationshipTypes",
                keyColumn: "RelationshipTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 817, DateTimeKind.Local).AddTicks(9665));

            migrationBuilder.UpdateData(
                table: "RelationshipTypes",
                keyColumn: "RelationshipTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 817, DateTimeKind.Local).AddTicks(9671));

            migrationBuilder.UpdateData(
                table: "RelationshipTypes",
                keyColumn: "RelationshipTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 817, DateTimeKind.Local).AddTicks(9675));

            migrationBuilder.UpdateData(
                table: "RelationshipTypes",
                keyColumn: "RelationshipTypeID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 817, DateTimeKind.Local).AddTicks(9677));

            migrationBuilder.UpdateData(
                table: "RelationshipTypes",
                keyColumn: "RelationshipTypeID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 817, DateTimeKind.Local).AddTicks(9686));

            migrationBuilder.UpdateData(
                table: "RelationshipTypes",
                keyColumn: "RelationshipTypeID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 817, DateTimeKind.Local).AddTicks(9690));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 865, DateTimeKind.Local).AddTicks(8031));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 865, DateTimeKind.Local).AddTicks(8182));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 865, DateTimeKind.Local).AddTicks(8186));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 865, DateTimeKind.Local).AddTicks(8189));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 865, DateTimeKind.Local).AddTicks(8191));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 865, DateTimeKind.Local).AddTicks(8200));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 865, DateTimeKind.Local).AddTicks(8203));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 865, DateTimeKind.Local).AddTicks(8205));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 865, DateTimeKind.Local).AddTicks(8207));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 865, DateTimeKind.Local).AddTicks(8211));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 865, DateTimeKind.Local).AddTicks(8213));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 865, DateTimeKind.Local).AddTicks(8216));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 13,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 865, DateTimeKind.Local).AddTicks(8218));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 14,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 865, DateTimeKind.Local).AddTicks(8220));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 15,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 865, DateTimeKind.Local).AddTicks(8225));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 16,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 865, DateTimeKind.Local).AddTicks(8227));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 17,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 865, DateTimeKind.Local).AddTicks(8229));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 18,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 865, DateTimeKind.Local).AddTicks(8234));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 19,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 865, DateTimeKind.Local).AddTicks(8236));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 21,
                columns: new[] { "LastChangedDate", "MenuID" },
                values: new object[] { new DateTime(2021, 5, 1, 14, 42, 29, 865, DateTimeKind.Local).AddTicks(8241), 9998 });

            migrationBuilder.InsertData(
                table: "RoleMenus",
                columns: new[] { "RoleMenuID", "LastChangedBy", "LastChangedDate", "MenuID", "RoleID" },
                values: new object[] { 22, "SuperUser", new DateTime(2021, 5, 1, 14, 42, 29, 865, DateTimeKind.Local).AddTicks(8243), 9999, 1 });

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 794, DateTimeKind.Local).AddTicks(7223));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 794, DateTimeKind.Local).AddTicks(7450));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 794, DateTimeKind.Local).AddTicks(7456));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 794, DateTimeKind.Local).AddTicks(7458));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 794, DateTimeKind.Local).AddTicks(7461));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 794, DateTimeKind.Local).AddTicks(7469));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 794, DateTimeKind.Local).AddTicks(7472));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 794, DateTimeKind.Local).AddTicks(7475));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 794, DateTimeKind.Local).AddTicks(7478));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 794, DateTimeKind.Local).AddTicks(7482));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 794, DateTimeKind.Local).AddTicks(7485));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 794, DateTimeKind.Local).AddTicks(7487));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 13,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 794, DateTimeKind.Local).AddTicks(7490));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 14,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 794, DateTimeKind.Local).AddTicks(7492));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 15,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 794, DateTimeKind.Local).AddTicks(7495));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 16,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 794, DateTimeKind.Local).AddTicks(7497));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 17,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 794, DateTimeKind.Local).AddTicks(7500));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 18,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 794, DateTimeKind.Local).AddTicks(7505));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 19,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 794, DateTimeKind.Local).AddTicks(7507));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 20,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 794, DateTimeKind.Local).AddTicks(7510));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 21,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 794, DateTimeKind.Local).AddTicks(7512));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 22,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 794, DateTimeKind.Local).AddTicks(7515));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 23,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 794, DateTimeKind.Local).AddTicks(7517));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 24,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 794, DateTimeKind.Local).AddTicks(7520));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 25,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 794, DateTimeKind.Local).AddTicks(7522));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 26,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 794, DateTimeKind.Local).AddTicks(7525));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 27,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 794, DateTimeKind.Local).AddTicks(7528));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 28,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 794, DateTimeKind.Local).AddTicks(7530));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 29,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 794, DateTimeKind.Local).AddTicks(7533));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 30,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 794, DateTimeKind.Local).AddTicks(7535));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 31,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 794, DateTimeKind.Local).AddTicks(7538));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 32,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 794, DateTimeKind.Local).AddTicks(7540));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 33,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 794, DateTimeKind.Local).AddTicks(7543));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 34,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 794, DateTimeKind.Local).AddTicks(7547));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 35,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 794, DateTimeKind.Local).AddTicks(7550));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 36,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 794, DateTimeKind.Local).AddTicks(7552));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 37,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 794, DateTimeKind.Local).AddTicks(7555));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 38,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 794, DateTimeKind.Local).AddTicks(7557));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 39,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 794, DateTimeKind.Local).AddTicks(7560));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 40,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 794, DateTimeKind.Local).AddTicks(7562));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 41,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 794, DateTimeKind.Local).AddTicks(7565));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 42,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 794, DateTimeKind.Local).AddTicks(7568));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 43,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 794, DateTimeKind.Local).AddTicks(7570));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 44,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 794, DateTimeKind.Local).AddTicks(7573));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 45,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 794, DateTimeKind.Local).AddTicks(7575));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 46,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 794, DateTimeKind.Local).AddTicks(7578));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 47,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 794, DateTimeKind.Local).AddTicks(7580));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 48,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 794, DateTimeKind.Local).AddTicks(7583));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 49,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 794, DateTimeKind.Local).AddTicks(7585));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 50,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 794, DateTimeKind.Local).AddTicks(7588));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 51,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 794, DateTimeKind.Local).AddTicks(7591));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 52,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 794, DateTimeKind.Local).AddTicks(7593));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 53,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 794, DateTimeKind.Local).AddTicks(7596));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 54,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 794, DateTimeKind.Local).AddTicks(7598));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 55,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 794, DateTimeKind.Local).AddTicks(7601));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 56,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 794, DateTimeKind.Local).AddTicks(7603));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 57,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 794, DateTimeKind.Local).AddTicks(7606));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 58,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 794, DateTimeKind.Local).AddTicks(7608));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 59,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 794, DateTimeKind.Local).AddTicks(7611));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 60,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 794, DateTimeKind.Local).AddTicks(7613));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 61,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 794, DateTimeKind.Local).AddTicks(7616));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 62,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 794, DateTimeKind.Local).AddTicks(7618));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 63,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 794, DateTimeKind.Local).AddTicks(7621));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 64,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 794, DateTimeKind.Local).AddTicks(7623));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 65,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 794, DateTimeKind.Local).AddTicks(7626));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 66,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 794, DateTimeKind.Local).AddTicks(7631));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 67,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 794, DateTimeKind.Local).AddTicks(7633));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 68,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 794, DateTimeKind.Local).AddTicks(7636));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 69,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 794, DateTimeKind.Local).AddTicks(7638));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 70,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 794, DateTimeKind.Local).AddTicks(7641));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 71,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 794, DateTimeKind.Local).AddTicks(7643));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 72,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 794, DateTimeKind.Local).AddTicks(7646));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 73,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 794, DateTimeKind.Local).AddTicks(7648));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 74,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 794, DateTimeKind.Local).AddTicks(7651));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 75,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 794, DateTimeKind.Local).AddTicks(7653));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 76,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 794, DateTimeKind.Local).AddTicks(7656));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 77,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 794, DateTimeKind.Local).AddTicks(7658));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 78,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 794, DateTimeKind.Local).AddTicks(7661));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 79,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 794, DateTimeKind.Local).AddTicks(7663));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 80,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 794, DateTimeKind.Local).AddTicks(7666));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 81,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 794, DateTimeKind.Local).AddTicks(7668));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 82,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 794, DateTimeKind.Local).AddTicks(7671));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 83,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 794, DateTimeKind.Local).AddTicks(7674));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 84,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 794, DateTimeKind.Local).AddTicks(7677));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 85,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 794, DateTimeKind.Local).AddTicks(7679));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 86,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 794, DateTimeKind.Local).AddTicks(7682));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 87,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 794, DateTimeKind.Local).AddTicks(7765));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 88,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 794, DateTimeKind.Local).AddTicks(7769));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 89,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 794, DateTimeKind.Local).AddTicks(7771));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 90,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 794, DateTimeKind.Local).AddTicks(7774));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 91,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 794, DateTimeKind.Local).AddTicks(7776));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 92,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 794, DateTimeKind.Local).AddTicks(7779));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 93,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 794, DateTimeKind.Local).AddTicks(7781));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 94,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 794, DateTimeKind.Local).AddTicks(7784));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 95,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 794, DateTimeKind.Local).AddTicks(7787));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 96,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 794, DateTimeKind.Local).AddTicks(7789));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 97,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 794, DateTimeKind.Local).AddTicks(7792));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 98,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 794, DateTimeKind.Local).AddTicks(7794));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 99,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 794, DateTimeKind.Local).AddTicks(7797));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 100,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 794, DateTimeKind.Local).AddTicks(7799));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 101,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 794, DateTimeKind.Local).AddTicks(7802));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 102,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 794, DateTimeKind.Local).AddTicks(7804));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 103,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 794, DateTimeKind.Local).AddTicks(7807));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 104,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 794, DateTimeKind.Local).AddTicks(7809));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 105,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 794, DateTimeKind.Local).AddTicks(7812));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 106,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 794, DateTimeKind.Local).AddTicks(7814));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 107,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 794, DateTimeKind.Local).AddTicks(7817));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 108,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 794, DateTimeKind.Local).AddTicks(7819));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 109,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 794, DateTimeKind.Local).AddTicks(7822));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 110,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 794, DateTimeKind.Local).AddTicks(7824));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 111,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 794, DateTimeKind.Local).AddTicks(7827));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 112,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 794, DateTimeKind.Local).AddTicks(7829));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 113,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 794, DateTimeKind.Local).AddTicks(7832));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 114,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 794, DateTimeKind.Local).AddTicks(7834));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 115,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 794, DateTimeKind.Local).AddTicks(7837));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 116,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 794, DateTimeKind.Local).AddTicks(7839));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 117,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 794, DateTimeKind.Local).AddTicks(7842));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 118,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 794, DateTimeKind.Local).AddTicks(7844));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 119,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 794, DateTimeKind.Local).AddTicks(7847));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 120,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 794, DateTimeKind.Local).AddTicks(7849));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 121,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 794, DateTimeKind.Local).AddTicks(7852));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 122,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 794, DateTimeKind.Local).AddTicks(7855));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 123,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 794, DateTimeKind.Local).AddTicks(7857));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 124,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 794, DateTimeKind.Local).AddTicks(7860));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 125,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 794, DateTimeKind.Local).AddTicks(7862));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 126,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 794, DateTimeKind.Local).AddTicks(7865));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 127,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 794, DateTimeKind.Local).AddTicks(7867));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 128,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 794, DateTimeKind.Local).AddTicks(7870));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 129,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 794, DateTimeKind.Local).AddTicks(7872));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 130,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 794, DateTimeKind.Local).AddTicks(7879));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 131,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 794, DateTimeKind.Local).AddTicks(7881));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 132,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 794, DateTimeKind.Local).AddTicks(7884));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 133,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 794, DateTimeKind.Local).AddTicks(7886));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 134,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 794, DateTimeKind.Local).AddTicks(7889));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 785, DateTimeKind.Local).AddTicks(6457));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 787, DateTimeKind.Local).AddTicks(3667));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 787, DateTimeKind.Local).AddTicks(3734));

            migrationBuilder.UpdateData(
                table: "StatementLists",
                keyColumn: "StatementID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 873, DateTimeKind.Local).AddTicks(7435));

            migrationBuilder.UpdateData(
                table: "StatementLists",
                keyColumn: "StatementID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 874, DateTimeKind.Local).AddTicks(3058));

            migrationBuilder.UpdateData(
                table: "SystemVariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 820, DateTimeKind.Local).AddTicks(9370));

            migrationBuilder.UpdateData(
                table: "SystemVariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 820, DateTimeKind.Local).AddTicks(9590));

            migrationBuilder.UpdateData(
                table: "SystemVariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 820, DateTimeKind.Local).AddTicks(9584));

            migrationBuilder.UpdateData(
                table: "SystemVariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 820, DateTimeKind.Local).AddTicks(9578));

            migrationBuilder.UpdateData(
                table: "SystemVariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 820, DateTimeKind.Local).AddTicks(9567));

            migrationBuilder.UpdateData(
                table: "SystemVariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 820, DateTimeKind.Local).AddTicks(9603));

            migrationBuilder.UpdateData(
                table: "SystemVariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 820, DateTimeKind.Local).AddTicks(9616));

            migrationBuilder.UpdateData(
                table: "SystemVariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 820, DateTimeKind.Local).AddTicks(9623));

            migrationBuilder.UpdateData(
                table: "SystemVariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 820, DateTimeKind.Local).AddTicks(9628));

            migrationBuilder.UpdateData(
                table: "Titles",
                keyColumn: "TitleID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 878, DateTimeKind.Local).AddTicks(6804));

            migrationBuilder.UpdateData(
                table: "Titles",
                keyColumn: "TitleID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 878, DateTimeKind.Local).AddTicks(7880));

            migrationBuilder.UpdateData(
                table: "Titles",
                keyColumn: "TitleID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 878, DateTimeKind.Local).AddTicks(7902));

            migrationBuilder.UpdateData(
                table: "Titles",
                keyColumn: "TitleID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 878, DateTimeKind.Local).AddTicks(7911));

            migrationBuilder.UpdateData(
                table: "Titles",
                keyColumn: "TitleID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 878, DateTimeKind.Local).AddTicks(7918));

            migrationBuilder.UpdateData(
                table: "Titles",
                keyColumn: "TitleID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 878, DateTimeKind.Local).AddTicks(7937));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 802, DateTimeKind.Local).AddTicks(2671));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 802, DateTimeKind.Local).AddTicks(3892));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 802, DateTimeKind.Local).AddTicks(4106));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 802, DateTimeKind.Local).AddTicks(4199));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 802, DateTimeKind.Local).AddTicks(4278));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 802, DateTimeKind.Local).AddTicks(4355));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 802, DateTimeKind.Local).AddTicks(4417));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 802, DateTimeKind.Local).AddTicks(4475));

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumns: new[] { "UserID", "RoleID" },
                keyValues: new object[] { 1, 1 },
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 847, DateTimeKind.Local).AddTicks(1617));

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumns: new[] { "UserID", "RoleID" },
                keyValues: new object[] { 2, 3 },
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 847, DateTimeKind.Local).AddTicks(1804));

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "UserTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 815, DateTimeKind.Local).AddTicks(1043));

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "UserTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 815, DateTimeKind.Local).AddTicks(1975));

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "UserTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 815, DateTimeKind.Local).AddTicks(1991));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 829, DateTimeKind.Local).AddTicks(3387));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 833, DateTimeKind.Local).AddTicks(7664));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 42, 29, 833, DateTimeKind.Local).AddTicks(7971));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 20,
                columns: new[] { "LastChangedDate", "MenuID" },
                values: new object[] { new DateTime(2021, 5, 1, 14, 42, 29, 865, DateTimeKind.Local).AddTicks(8239), 9997 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 9997);

            migrationBuilder.UpdateData(
                table: "BankAccountTypes",
                keyColumn: "BankAccountTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 427, DateTimeKind.Local).AddTicks(4678));

            migrationBuilder.UpdateData(
                table: "BankAccountTypes",
                keyColumn: "BankAccountTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 427, DateTimeKind.Local).AddTicks(5474));

            migrationBuilder.UpdateData(
                table: "BankAccountTypes",
                keyColumn: "BankAccountTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 427, DateTimeKind.Local).AddTicks(5489));

            migrationBuilder.UpdateData(
                table: "BankAccountTypes",
                keyColumn: "BankAccountTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 427, DateTimeKind.Local).AddTicks(5498));

            migrationBuilder.UpdateData(
                table: "ClientAccountTypes",
                keyColumn: "ID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 531, DateTimeKind.Local).AddTicks(915));

            migrationBuilder.UpdateData(
                table: "ClientAccountTypes",
                keyColumn: "ID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 531, DateTimeKind.Local).AddTicks(1632));

            migrationBuilder.UpdateData(
                table: "ClientGroups",
                keyColumn: "ClientGroupID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 541, DateTimeKind.Local).AddTicks(2525));

            migrationBuilder.UpdateData(
                table: "ClientGroups",
                keyColumn: "ClientGroupID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 541, DateTimeKind.Local).AddTicks(3258));

            migrationBuilder.UpdateData(
                table: "ContactTypes",
                keyColumn: "ContactTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 444, DateTimeKind.Local).AddTicks(5087));

            migrationBuilder.UpdateData(
                table: "ContactTypes",
                keyColumn: "ContactTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 444, DateTimeKind.Local).AddTicks(5076));

            migrationBuilder.UpdateData(
                table: "ContactTypes",
                keyColumn: "ContactTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 444, DateTimeKind.Local).AddTicks(5061));

            migrationBuilder.UpdateData(
                table: "ContactTypes",
                keyColumn: "ContactTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 444, DateTimeKind.Local).AddTicks(4766));

            migrationBuilder.UpdateData(
                table: "ContactTypes",
                keyColumn: "ContactTypeID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 444, DateTimeKind.Local).AddTicks(5096));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 456, DateTimeKind.Local).AddTicks(6719));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 456, DateTimeKind.Local).AddTicks(7483));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 456, DateTimeKind.Local).AddTicks(7496));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 456, DateTimeKind.Local).AddTicks(7512));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 456, DateTimeKind.Local).AddTicks(7520));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 456, DateTimeKind.Local).AddTicks(7537));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 456, DateTimeKind.Local).AddTicks(7544));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 456, DateTimeKind.Local).AddTicks(7555));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 456, DateTimeKind.Local).AddTicks(7562));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 456, DateTimeKind.Local).AddTicks(7573));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 456, DateTimeKind.Local).AddTicks(7581));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 456, DateTimeKind.Local).AddTicks(7588));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 13,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 456, DateTimeKind.Local).AddTicks(7597));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 14,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 456, DateTimeKind.Local).AddTicks(7604));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 15,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 456, DateTimeKind.Local).AddTicks(7612));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 16,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 456, DateTimeKind.Local).AddTicks(7621));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 17,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 456, DateTimeKind.Local).AddTicks(7628));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 18,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 456, DateTimeKind.Local).AddTicks(7640));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 19,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 456, DateTimeKind.Local).AddTicks(7647));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 20,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 456, DateTimeKind.Local).AddTicks(7654));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 21,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 456, DateTimeKind.Local).AddTicks(7661));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 22,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 456, DateTimeKind.Local).AddTicks(7668));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 23,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 456, DateTimeKind.Local).AddTicks(7675));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 24,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 456, DateTimeKind.Local).AddTicks(7681));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 25,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 456, DateTimeKind.Local).AddTicks(7689));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 26,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 456, DateTimeKind.Local).AddTicks(7696));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 27,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 456, DateTimeKind.Local).AddTicks(7705));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 28,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 456, DateTimeKind.Local).AddTicks(7712));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 29,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 456, DateTimeKind.Local).AddTicks(7719));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 30,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 456, DateTimeKind.Local).AddTicks(7730));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 31,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 456, DateTimeKind.Local).AddTicks(7737));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 32,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 456, DateTimeKind.Local).AddTicks(7744));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 33,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 456, DateTimeKind.Local).AddTicks(7753));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 34,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 456, DateTimeKind.Local).AddTicks(7764));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 35,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 456, DateTimeKind.Local).AddTicks(7771));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 36,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 456, DateTimeKind.Local).AddTicks(7778));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 37,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 456, DateTimeKind.Local).AddTicks(7786));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 38,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 456, DateTimeKind.Local).AddTicks(7792));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 39,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 456, DateTimeKind.Local).AddTicks(7801));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 40,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 456, DateTimeKind.Local).AddTicks(7809));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 41,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 456, DateTimeKind.Local).AddTicks(7818));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 42,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 456, DateTimeKind.Local).AddTicks(7825));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 43,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 456, DateTimeKind.Local).AddTicks(7832));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 44,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 456, DateTimeKind.Local).AddTicks(7839));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 45,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 456, DateTimeKind.Local).AddTicks(7846));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 46,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 456, DateTimeKind.Local).AddTicks(7854));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 47,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 456, DateTimeKind.Local).AddTicks(7863));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 48,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 456, DateTimeKind.Local).AddTicks(7873));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 49,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 456, DateTimeKind.Local).AddTicks(7880));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 50,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 456, DateTimeKind.Local).AddTicks(8083));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 51,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 456, DateTimeKind.Local).AddTicks(8095));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 52,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 456, DateTimeKind.Local).AddTicks(8103));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 53,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 456, DateTimeKind.Local).AddTicks(8110));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 54,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 456, DateTimeKind.Local).AddTicks(8117));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 55,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 456, DateTimeKind.Local).AddTicks(8126));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 56,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 456, DateTimeKind.Local).AddTicks(8133));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 57,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 456, DateTimeKind.Local).AddTicks(8140));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 58,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 456, DateTimeKind.Local).AddTicks(8148));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 59,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 456, DateTimeKind.Local).AddTicks(8158));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 60,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 456, DateTimeKind.Local).AddTicks(8166));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 61,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 456, DateTimeKind.Local).AddTicks(8173));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 62,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 456, DateTimeKind.Local).AddTicks(8180));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 63,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 456, DateTimeKind.Local).AddTicks(8188));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 64,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 456, DateTimeKind.Local).AddTicks(8197));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 65,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 456, DateTimeKind.Local).AddTicks(8204));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 66,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 456, DateTimeKind.Local).AddTicks(8216));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 67,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 456, DateTimeKind.Local).AddTicks(8223));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 68,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 456, DateTimeKind.Local).AddTicks(8232));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 69,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 456, DateTimeKind.Local).AddTicks(8239));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 70,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 456, DateTimeKind.Local).AddTicks(8245));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 71,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 456, DateTimeKind.Local).AddTicks(8252));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 72,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 456, DateTimeKind.Local).AddTicks(8260));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 73,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 456, DateTimeKind.Local).AddTicks(8270));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 74,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 456, DateTimeKind.Local).AddTicks(8276));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 75,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 456, DateTimeKind.Local).AddTicks(8285));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 76,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 456, DateTimeKind.Local).AddTicks(8293));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 77,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 456, DateTimeKind.Local).AddTicks(8299));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 78,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 456, DateTimeKind.Local).AddTicks(8306));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 79,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 456, DateTimeKind.Local).AddTicks(8313));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 80,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 456, DateTimeKind.Local).AddTicks(8320));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 81,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 456, DateTimeKind.Local).AddTicks(8328));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 82,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 456, DateTimeKind.Local).AddTicks(8336));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 83,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 456, DateTimeKind.Local).AddTicks(8342));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 84,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 456, DateTimeKind.Local).AddTicks(8350));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 85,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 456, DateTimeKind.Local).AddTicks(8357));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 86,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 456, DateTimeKind.Local).AddTicks(8364));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 87,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 456, DateTimeKind.Local).AddTicks(8371));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 88,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 456, DateTimeKind.Local).AddTicks(8378));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 89,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 456, DateTimeKind.Local).AddTicks(8387));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 90,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 456, DateTimeKind.Local).AddTicks(8394));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 91,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 456, DateTimeKind.Local).AddTicks(8402));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 92,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 456, DateTimeKind.Local).AddTicks(8409));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 93,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 456, DateTimeKind.Local).AddTicks(8417));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 94,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 456, DateTimeKind.Local).AddTicks(8425));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 95,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 456, DateTimeKind.Local).AddTicks(8432));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 96,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 456, DateTimeKind.Local).AddTicks(8440));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 97,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 456, DateTimeKind.Local).AddTicks(8447));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 98,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 456, DateTimeKind.Local).AddTicks(8455));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 99,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 456, DateTimeKind.Local).AddTicks(8462));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 100,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 456, DateTimeKind.Local).AddTicks(8469));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 101,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 456, DateTimeKind.Local).AddTicks(8482));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 102,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 456, DateTimeKind.Local).AddTicks(8489));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 103,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 456, DateTimeKind.Local).AddTicks(8496));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 104,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 456, DateTimeKind.Local).AddTicks(8503));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 105,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 456, DateTimeKind.Local).AddTicks(8510));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 106,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 456, DateTimeKind.Local).AddTicks(8517));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 107,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 456, DateTimeKind.Local).AddTicks(8524));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 108,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 456, DateTimeKind.Local).AddTicks(8532));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 109,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 456, DateTimeKind.Local).AddTicks(8539));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 110,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 456, DateTimeKind.Local).AddTicks(8547));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 111,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 456, DateTimeKind.Local).AddTicks(8557));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 112,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 456, DateTimeKind.Local).AddTicks(8623));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 113,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 456, DateTimeKind.Local).AddTicks(8632));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 114,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 456, DateTimeKind.Local).AddTicks(8638));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 115,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 456, DateTimeKind.Local).AddTicks(8646));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 116,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 456, DateTimeKind.Local).AddTicks(8654));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 117,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 456, DateTimeKind.Local).AddTicks(8661));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 118,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 456, DateTimeKind.Local).AddTicks(8668));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 119,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 456, DateTimeKind.Local).AddTicks(8675));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 120,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 456, DateTimeKind.Local).AddTicks(8682));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 121,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 456, DateTimeKind.Local).AddTicks(8689));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 122,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 456, DateTimeKind.Local).AddTicks(8697));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 123,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 456, DateTimeKind.Local).AddTicks(8704));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 124,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 456, DateTimeKind.Local).AddTicks(8711));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 125,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 456, DateTimeKind.Local).AddTicks(8718));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 126,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 456, DateTimeKind.Local).AddTicks(8726));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 127,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 456, DateTimeKind.Local).AddTicks(8733));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 128,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 456, DateTimeKind.Local).AddTicks(8740));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 129,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 456, DateTimeKind.Local).AddTicks(8747));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 130,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 456, DateTimeKind.Local).AddTicks(8759));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 131,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 456, DateTimeKind.Local).AddTicks(8767));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 132,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 456, DateTimeKind.Local).AddTicks(8775));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 133,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 456, DateTimeKind.Local).AddTicks(8783));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 134,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 456, DateTimeKind.Local).AddTicks(8791));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 135,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 456, DateTimeKind.Local).AddTicks(8799));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 136,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 456, DateTimeKind.Local).AddTicks(8806));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 137,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 456, DateTimeKind.Local).AddTicks(8813));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 138,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 456, DateTimeKind.Local).AddTicks(8823));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 139,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 456, DateTimeKind.Local).AddTicks(8830));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 140,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 456, DateTimeKind.Local).AddTicks(8837));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 141,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 456, DateTimeKind.Local).AddTicks(8844));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 142,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 456, DateTimeKind.Local).AddTicks(8853));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 143,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 456, DateTimeKind.Local).AddTicks(8861));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 144,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 456, DateTimeKind.Local).AddTicks(8868));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 145,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 456, DateTimeKind.Local).AddTicks(8875));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 146,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 456, DateTimeKind.Local).AddTicks(8883));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 147,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 456, DateTimeKind.Local).AddTicks(8890));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 148,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 456, DateTimeKind.Local).AddTicks(8897));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 149,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 456, DateTimeKind.Local).AddTicks(8906));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 150,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 456, DateTimeKind.Local).AddTicks(8916));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 151,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 456, DateTimeKind.Local).AddTicks(8924));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 152,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 456, DateTimeKind.Local).AddTicks(8931));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 153,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 456, DateTimeKind.Local).AddTicks(8939));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 154,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 456, DateTimeKind.Local).AddTicks(8946));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 155,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 456, DateTimeKind.Local).AddTicks(8955));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 156,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 456, DateTimeKind.Local).AddTicks(8962));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 157,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 456, DateTimeKind.Local).AddTicks(8970));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 158,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 456, DateTimeKind.Local).AddTicks(8978));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 159,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 456, DateTimeKind.Local).AddTicks(8986));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 160,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 456, DateTimeKind.Local).AddTicks(8994));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 161,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 456, DateTimeKind.Local).AddTicks(9003));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 162,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 456, DateTimeKind.Local).AddTicks(9010));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 163,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 456, DateTimeKind.Local).AddTicks(9016));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 164,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 456, DateTimeKind.Local).AddTicks(9024));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 165,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 456, DateTimeKind.Local).AddTicks(9031));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 166,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 456, DateTimeKind.Local).AddTicks(9095));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 167,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 456, DateTimeKind.Local).AddTicks(9105));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 168,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 456, DateTimeKind.Local).AddTicks(9112));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 169,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 456, DateTimeKind.Local).AddTicks(9119));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 170,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 456, DateTimeKind.Local).AddTicks(9126));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 171,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 456, DateTimeKind.Local).AddTicks(9132));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 172,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 456, DateTimeKind.Local).AddTicks(9140));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 173,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 456, DateTimeKind.Local).AddTicks(9149));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 174,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 456, DateTimeKind.Local).AddTicks(9159));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 175,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 456, DateTimeKind.Local).AddTicks(9169));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 176,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 456, DateTimeKind.Local).AddTicks(9180));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 177,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 456, DateTimeKind.Local).AddTicks(9191));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 178,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 456, DateTimeKind.Local).AddTicks(9198));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 179,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 456, DateTimeKind.Local).AddTicks(9207));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 180,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 456, DateTimeKind.Local).AddTicks(9215));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 181,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 456, DateTimeKind.Local).AddTicks(9223));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 182,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 456, DateTimeKind.Local).AddTicks(9232));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 183,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 456, DateTimeKind.Local).AddTicks(9239));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 184,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 456, DateTimeKind.Local).AddTicks(9247));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 185,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 456, DateTimeKind.Local).AddTicks(9254));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 186,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 456, DateTimeKind.Local).AddTicks(9261));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 187,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 456, DateTimeKind.Local).AddTicks(9269));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 188,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 456, DateTimeKind.Local).AddTicks(9276));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 189,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 456, DateTimeKind.Local).AddTicks(9285));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 190,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 456, DateTimeKind.Local).AddTicks(9292));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 191,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 456, DateTimeKind.Local).AddTicks(9300));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 192,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 456, DateTimeKind.Local).AddTicks(9307));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 193,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 456, DateTimeKind.Local).AddTicks(9316));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 194,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 456, DateTimeKind.Local).AddTicks(9323));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 195,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 456, DateTimeKind.Local).AddTicks(9330));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 196,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 456, DateTimeKind.Local).AddTicks(9337));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 197,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 456, DateTimeKind.Local).AddTicks(9344));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 198,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 456, DateTimeKind.Local).AddTicks(9352));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 199,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 456, DateTimeKind.Local).AddTicks(9360));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 200,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 456, DateTimeKind.Local).AddTicks(9367));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 201,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 456, DateTimeKind.Local).AddTicks(9374));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 202,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 456, DateTimeKind.Local).AddTicks(9381));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 203,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 456, DateTimeKind.Local).AddTicks(9388));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 204,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 456, DateTimeKind.Local).AddTicks(9395));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 205,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 456, DateTimeKind.Local).AddTicks(9402));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 206,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 456, DateTimeKind.Local).AddTicks(9410));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 207,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 456, DateTimeKind.Local).AddTicks(9418));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 208,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 456, DateTimeKind.Local).AddTicks(9425));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 209,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 456, DateTimeKind.Local).AddTicks(9432));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 210,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 456, DateTimeKind.Local).AddTicks(9441));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 211,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 456, DateTimeKind.Local).AddTicks(9448));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 212,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 456, DateTimeKind.Local).AddTicks(9455));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 213,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 456, DateTimeKind.Local).AddTicks(9462));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 214,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 456, DateTimeKind.Local).AddTicks(9471));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 215,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 456, DateTimeKind.Local).AddTicks(9480));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 216,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 456, DateTimeKind.Local).AddTicks(9488));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 217,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 456, DateTimeKind.Local).AddTicks(9496));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 218,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 456, DateTimeKind.Local).AddTicks(9503));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 219,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 456, DateTimeKind.Local).AddTicks(9510));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 220,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 456, DateTimeKind.Local).AddTicks(9517));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 221,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 456, DateTimeKind.Local).AddTicks(9523));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 222,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 456, DateTimeKind.Local).AddTicks(9532));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 223,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 456, DateTimeKind.Local).AddTicks(9540));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 224,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 456, DateTimeKind.Local).AddTicks(9548));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 225,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 456, DateTimeKind.Local).AddTicks(9556));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 226,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 456, DateTimeKind.Local).AddTicks(9562));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 227,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 456, DateTimeKind.Local).AddTicks(9569));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 228,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 456, DateTimeKind.Local).AddTicks(9576));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 432, DateTimeKind.Local).AddTicks(5242));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 432, DateTimeKind.Local).AddTicks(5987));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 432, DateTimeKind.Local).AddTicks(6004));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 432, DateTimeKind.Local).AddTicks(6013));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 432, DateTimeKind.Local).AddTicks(6021));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 432, DateTimeKind.Local).AddTicks(6038));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 432, DateTimeKind.Local).AddTicks(6046));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 432, DateTimeKind.Local).AddTicks(6054));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 432, DateTimeKind.Local).AddTicks(6060));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 432, DateTimeKind.Local).AddTicks(6073));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 432, DateTimeKind.Local).AddTicks(6080));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 432, DateTimeKind.Local).AddTicks(6182));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 13,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 432, DateTimeKind.Local).AddTicks(6191));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 14,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 432, DateTimeKind.Local).AddTicks(6199));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 15,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 432, DateTimeKind.Local).AddTicks(6205));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 16,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 432, DateTimeKind.Local).AddTicks(6212));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 17,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 432, DateTimeKind.Local).AddTicks(6219));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 18,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 432, DateTimeKind.Local).AddTicks(6229));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 19,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 432, DateTimeKind.Local).AddTicks(6238));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 20,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 432, DateTimeKind.Local).AddTicks(6246));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 21,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 432, DateTimeKind.Local).AddTicks(6255));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 22,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 432, DateTimeKind.Local).AddTicks(6263));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 23,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 432, DateTimeKind.Local).AddTicks(6270));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 24,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 432, DateTimeKind.Local).AddTicks(6281));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 25,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 432, DateTimeKind.Local).AddTicks(6287));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 26,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 432, DateTimeKind.Local).AddTicks(6294));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 27,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 432, DateTimeKind.Local).AddTicks(6301));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 28,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 432, DateTimeKind.Local).AddTicks(6308));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 29,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 432, DateTimeKind.Local).AddTicks(6315));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 30,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 432, DateTimeKind.Local).AddTicks(6321));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 31,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 432, DateTimeKind.Local).AddTicks(6330));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 32,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 432, DateTimeKind.Local).AddTicks(6338));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 33,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 432, DateTimeKind.Local).AddTicks(6346));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 34,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 432, DateTimeKind.Local).AddTicks(6358));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 35,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 432, DateTimeKind.Local).AddTicks(6365));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 36,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 432, DateTimeKind.Local).AddTicks(6373));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 37,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 432, DateTimeKind.Local).AddTicks(6383));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 38,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 432, DateTimeKind.Local).AddTicks(6390));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 39,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 432, DateTimeKind.Local).AddTicks(6397));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 40,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 432, DateTimeKind.Local).AddTicks(6405));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 41,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 432, DateTimeKind.Local).AddTicks(6413));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 42,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 432, DateTimeKind.Local).AddTicks(6421));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 43,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 432, DateTimeKind.Local).AddTicks(6429));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 44,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 432, DateTimeKind.Local).AddTicks(6436));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 45,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 432, DateTimeKind.Local).AddTicks(6443));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 46,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 432, DateTimeKind.Local).AddTicks(6450));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 47,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 432, DateTimeKind.Local).AddTicks(6457));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 48,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 432, DateTimeKind.Local).AddTicks(6467));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 49,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 432, DateTimeKind.Local).AddTicks(6476));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 50,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 432, DateTimeKind.Local).AddTicks(6482));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 51,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 432, DateTimeKind.Local).AddTicks(6489));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 52,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 432, DateTimeKind.Local).AddTicks(6497));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 53,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 432, DateTimeKind.Local).AddTicks(6504));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 54,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 432, DateTimeKind.Local).AddTicks(6511));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 55,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 432, DateTimeKind.Local).AddTicks(6518));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 56,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 432, DateTimeKind.Local).AddTicks(6524));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 57,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 432, DateTimeKind.Local).AddTicks(6532));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 58,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 432, DateTimeKind.Local).AddTicks(6541));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 59,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 432, DateTimeKind.Local).AddTicks(6548));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 60,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 432, DateTimeKind.Local).AddTicks(6554));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 61,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 432, DateTimeKind.Local).AddTicks(6562));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 62,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 432, DateTimeKind.Local).AddTicks(6569));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 63,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 432, DateTimeKind.Local).AddTicks(6576));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 64,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 432, DateTimeKind.Local).AddTicks(6583));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 65,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 432, DateTimeKind.Local).AddTicks(6590));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 66,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 432, DateTimeKind.Local).AddTicks(6601));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 67,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 432, DateTimeKind.Local).AddTicks(6608));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 68,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 432, DateTimeKind.Local).AddTicks(6614));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 69,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 432, DateTimeKind.Local).AddTicks(6621));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 70,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 432, DateTimeKind.Local).AddTicks(6627));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 71,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 432, DateTimeKind.Local).AddTicks(6635));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 72,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 432, DateTimeKind.Local).AddTicks(6643));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 73,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 432, DateTimeKind.Local).AddTicks(6706));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 74,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 432, DateTimeKind.Local).AddTicks(6714));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 75,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 432, DateTimeKind.Local).AddTicks(6720));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 76,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 432, DateTimeKind.Local).AddTicks(6727));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 77,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 432, DateTimeKind.Local).AddTicks(6734));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 78,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 432, DateTimeKind.Local).AddTicks(6741));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 79,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 432, DateTimeKind.Local).AddTicks(6749));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 80,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 432, DateTimeKind.Local).AddTicks(6756));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 81,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 432, DateTimeKind.Local).AddTicks(6768));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 82,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 432, DateTimeKind.Local).AddTicks(6776));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 83,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 432, DateTimeKind.Local).AddTicks(6784));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 84,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 432, DateTimeKind.Local).AddTicks(6792));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 85,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 432, DateTimeKind.Local).AddTicks(6798));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 86,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 432, DateTimeKind.Local).AddTicks(6809));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 87,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 432, DateTimeKind.Local).AddTicks(6815));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 88,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 432, DateTimeKind.Local).AddTicks(6822));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 89,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 432, DateTimeKind.Local).AddTicks(6830));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 90,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 432, DateTimeKind.Local).AddTicks(6837));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 91,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 432, DateTimeKind.Local).AddTicks(6843));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 92,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 432, DateTimeKind.Local).AddTicks(6850));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 93,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 432, DateTimeKind.Local).AddTicks(6858));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 94,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 432, DateTimeKind.Local).AddTicks(6864));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 95,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 432, DateTimeKind.Local).AddTicks(6871));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 96,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 432, DateTimeKind.Local).AddTicks(6878));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 97,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 432, DateTimeKind.Local).AddTicks(6888));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 98,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 432, DateTimeKind.Local).AddTicks(6896));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 99,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 432, DateTimeKind.Local).AddTicks(6903));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 100,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 432, DateTimeKind.Local).AddTicks(6909));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 101,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 432, DateTimeKind.Local).AddTicks(6916));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 102,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 432, DateTimeKind.Local).AddTicks(6923));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 103,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 432, DateTimeKind.Local).AddTicks(6930));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 104,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 432, DateTimeKind.Local).AddTicks(6938));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 105,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 432, DateTimeKind.Local).AddTicks(6944));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 106,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 432, DateTimeKind.Local).AddTicks(6952));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 107,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 432, DateTimeKind.Local).AddTicks(6959));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 108,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 432, DateTimeKind.Local).AddTicks(6965));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 109,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 432, DateTimeKind.Local).AddTicks(6972));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 110,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 432, DateTimeKind.Local).AddTicks(6979));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 111,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 432, DateTimeKind.Local).AddTicks(6986));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 112,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 432, DateTimeKind.Local).AddTicks(6993));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 113,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 432, DateTimeKind.Local).AddTicks(7002));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 114,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 432, DateTimeKind.Local).AddTicks(7009));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 115,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 432, DateTimeKind.Local).AddTicks(7015));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 116,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 432, DateTimeKind.Local).AddTicks(7021));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 117,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 432, DateTimeKind.Local).AddTicks(7028));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 118,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 432, DateTimeKind.Local).AddTicks(7035));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 119,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 432, DateTimeKind.Local).AddTicks(7042));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 120,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 432, DateTimeKind.Local).AddTicks(7048));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 121,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 432, DateTimeKind.Local).AddTicks(7057));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 122,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 432, DateTimeKind.Local).AddTicks(7064));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 123,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 432, DateTimeKind.Local).AddTicks(7071));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 124,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 432, DateTimeKind.Local).AddTicks(7078));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 125,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 432, DateTimeKind.Local).AddTicks(7086));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 126,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 432, DateTimeKind.Local).AddTicks(7094));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 127,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 432, DateTimeKind.Local).AddTicks(7100));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 128,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 432, DateTimeKind.Local).AddTicks(7107));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 129,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 432, DateTimeKind.Local).AddTicks(7113));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 130,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 432, DateTimeKind.Local).AddTicks(7125));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 131,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 432, DateTimeKind.Local).AddTicks(7132));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 132,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 432, DateTimeKind.Local).AddTicks(7193));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 133,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 432, DateTimeKind.Local).AddTicks(7201));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 134,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 432, DateTimeKind.Local).AddTicks(7207));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 135,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 432, DateTimeKind.Local).AddTicks(7215));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 136,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 432, DateTimeKind.Local).AddTicks(7222));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 137,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 432, DateTimeKind.Local).AddTicks(7229));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 138,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 432, DateTimeKind.Local).AddTicks(7236));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 139,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 432, DateTimeKind.Local).AddTicks(7242));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 140,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 432, DateTimeKind.Local).AddTicks(7248));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 141,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 432, DateTimeKind.Local).AddTicks(7255));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 142,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 432, DateTimeKind.Local).AddTicks(7261));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 143,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 432, DateTimeKind.Local).AddTicks(7270));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 144,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 432, DateTimeKind.Local).AddTicks(7276));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 145,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 432, DateTimeKind.Local).AddTicks(7283));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 146,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 432, DateTimeKind.Local).AddTicks(7289));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 147,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 432, DateTimeKind.Local).AddTicks(7296));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 148,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 432, DateTimeKind.Local).AddTicks(7303));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 149,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 432, DateTimeKind.Local).AddTicks(7309));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 150,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 432, DateTimeKind.Local).AddTicks(7317));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 151,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 432, DateTimeKind.Local).AddTicks(7324));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 152,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 432, DateTimeKind.Local).AddTicks(7330));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 153,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 432, DateTimeKind.Local).AddTicks(7337));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 154,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 432, DateTimeKind.Local).AddTicks(7344));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 155,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 432, DateTimeKind.Local).AddTicks(7350));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 156,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 432, DateTimeKind.Local).AddTicks(7356));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 157,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 432, DateTimeKind.Local).AddTicks(7363));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 158,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 432, DateTimeKind.Local).AddTicks(7370));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 159,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 432, DateTimeKind.Local).AddTicks(7376));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 160,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 432, DateTimeKind.Local).AddTicks(7383));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 161,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 432, DateTimeKind.Local).AddTicks(7391));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 162,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 432, DateTimeKind.Local).AddTicks(7397));

            migrationBuilder.UpdateData(
                table: "CustomSettingTypes",
                keyColumn: "CustomSettingTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 447, DateTimeKind.Local).AddTicks(5979));

            migrationBuilder.UpdateData(
                table: "CustomSettingTypes",
                keyColumn: "CustomSettingTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 447, DateTimeKind.Local).AddTicks(6183));

            migrationBuilder.UpdateData(
                table: "CustomSettingTypes",
                keyColumn: "CustomSettingTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 447, DateTimeKind.Local).AddTicks(6193));

            migrationBuilder.UpdateData(
                table: "CustomSettingTypes",
                keyColumn: "CustomSettingTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 447, DateTimeKind.Local).AddTicks(6200));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 510, DateTimeKind.Local).AddTicks(432));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 510, DateTimeKind.Local).AddTicks(747));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 510, DateTimeKind.Local).AddTicks(796));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 510, DateTimeKind.Local).AddTicks(760));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 510, DateTimeKind.Local).AddTicks(809));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 510, DateTimeKind.Local).AddTicks(837));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 510, DateTimeKind.Local).AddTicks(851));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 510, DateTimeKind.Local).AddTicks(863));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 510, DateTimeKind.Local).AddTicks(874));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 510, DateTimeKind.Local).AddTicks(886));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 510, DateTimeKind.Local).AddTicks(960));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 510, DateTimeKind.Local).AddTicks(971));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 13,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 510, DateTimeKind.Local).AddTicks(980));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 14,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 510, DateTimeKind.Local).AddTicks(990));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 15,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 510, DateTimeKind.Local).AddTicks(772));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 16,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 510, DateTimeKind.Local).AddTicks(730));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 17,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 510, DateTimeKind.Local).AddTicks(1004));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 18,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 510, DateTimeKind.Local).AddTicks(1013));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 19,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 510, DateTimeKind.Local).AddTicks(1024));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 20,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 510, DateTimeKind.Local).AddTicks(1035));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 22,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 510, DateTimeKind.Local).AddTicks(1078));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 23,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 510, DateTimeKind.Local).AddTicks(1057));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 24,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 510, DateTimeKind.Local).AddTicks(1047));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 25,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 510, DateTimeKind.Local).AddTicks(1068));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 26,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 510, DateTimeKind.Local).AddTicks(1089));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 27,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 510, DateTimeKind.Local).AddTicks(1103));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 28,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 510, DateTimeKind.Local).AddTicks(1112));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 30,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 510, DateTimeKind.Local).AddTicks(1144));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 31,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 510, DateTimeKind.Local).AddTicks(1156));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 32,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 510, DateTimeKind.Local).AddTicks(1169));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 33,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 510, DateTimeKind.Local).AddTicks(1180));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 34,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 510, DateTimeKind.Local).AddTicks(1192));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 36,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 510, DateTimeKind.Local).AddTicks(1207));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 37,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 510, DateTimeKind.Local).AddTicks(1219));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 38,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 510, DateTimeKind.Local).AddTicks(1230));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 39,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 510, DateTimeKind.Local).AddTicks(822));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 40,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 510, DateTimeKind.Local).AddTicks(1244));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 41,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 510, DateTimeKind.Local).AddTicks(1255));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 42,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 510, DateTimeKind.Local).AddTicks(1265));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 43,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 510, DateTimeKind.Local).AddTicks(1275));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 44,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 510, DateTimeKind.Local).AddTicks(1286));

            migrationBuilder.UpdateData(
                table: "DocumentFormats",
                keyColumn: "DocumentFormatID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 475, DateTimeKind.Local).AddTicks(7638));

            migrationBuilder.UpdateData(
                table: "DocumentFormats",
                keyColumn: "DocumentFormatID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 475, DateTimeKind.Local).AddTicks(8439));

            migrationBuilder.UpdateData(
                table: "DocumentFormats",
                keyColumn: "DocumentFormatID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 475, DateTimeKind.Local).AddTicks(8449));

            migrationBuilder.UpdateData(
                table: "DocumentFormats",
                keyColumn: "DocumentFormatID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 475, DateTimeKind.Local).AddTicks(8454));

            migrationBuilder.UpdateData(
                table: "DocumentFormats",
                keyColumn: "DocumentFormatID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 475, DateTimeKind.Local).AddTicks(8458));

            migrationBuilder.UpdateData(
                table: "DocumentFormats",
                keyColumn: "DocumentFormatID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 475, DateTimeKind.Local).AddTicks(8475));

            migrationBuilder.UpdateData(
                table: "DocumentTypes",
                keyColumn: "DocumentTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 480, DateTimeKind.Local).AddTicks(3656));

            migrationBuilder.UpdateData(
                table: "DocumentTypes",
                keyColumn: "DocumentTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 480, DateTimeKind.Local).AddTicks(5049));

            migrationBuilder.UpdateData(
                table: "DocumentTypes",
                keyColumn: "DocumentTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 480, DateTimeKind.Local).AddTicks(5084));

            migrationBuilder.UpdateData(
                table: "DocumentTypes",
                keyColumn: "DocumentTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 480, DateTimeKind.Local).AddTicks(5091));

            migrationBuilder.UpdateData(
                table: "EmailTemplates",
                keyColumn: "EmailTemplateID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 501, DateTimeKind.Local).AddTicks(2240));

            migrationBuilder.UpdateData(
                table: "EmailTypes",
                keyColumn: "EmailTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 499, DateTimeKind.Local).AddTicks(8070));

            migrationBuilder.UpdateData(
                table: "EmailTypes",
                keyColumn: "EmailTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 499, DateTimeKind.Local).AddTicks(9099));

            migrationBuilder.UpdateData(
                table: "EmailTypes",
                keyColumn: "EmailTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 499, DateTimeKind.Local).AddTicks(9123));

            migrationBuilder.UpdateData(
                table: "EmailTypes",
                keyColumn: "EmailTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 499, DateTimeKind.Local).AddTicks(9134));

            migrationBuilder.UpdateData(
                table: "FeatureFlags",
                keyColumn: "FeatureFlagID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 471, DateTimeKind.Local).AddTicks(749));

            migrationBuilder.UpdateData(
                table: "FeatureFlags",
                keyColumn: "FeatureFlagID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 471, DateTimeKind.Local).AddTicks(5016));

            migrationBuilder.UpdateData(
                table: "FeatureFlags",
                keyColumn: "FeatureFlagID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 471, DateTimeKind.Local).AddTicks(5067));

            migrationBuilder.UpdateData(
                table: "Frequencies",
                keyColumn: "FrequencyID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 437, DateTimeKind.Local).AddTicks(6218));

            migrationBuilder.UpdateData(
                table: "Frequencies",
                keyColumn: "FrequencyID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 437, DateTimeKind.Local).AddTicks(6979));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "GenderID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 451, DateTimeKind.Local).AddTicks(5805));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "GenderID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 451, DateTimeKind.Local).AddTicks(5986));

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "InvoiceStatusID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 546, DateTimeKind.Local).AddTicks(3386));

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "InvoiceStatusID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 546, DateTimeKind.Local).AddTicks(4060));

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "InvoiceStatusID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 546, DateTimeKind.Local).AddTicks(4073));

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "InvoiceStatusID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 546, DateTimeKind.Local).AddTicks(4080));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 484, DateTimeKind.Local).AddTicks(9099));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 484, DateTimeKind.Local).AddTicks(9516));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 484, DateTimeKind.Local).AddTicks(9541));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 484, DateTimeKind.Local).AddTicks(9552));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 484, DateTimeKind.Local).AddTicks(9564));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 484, DateTimeKind.Local).AddTicks(9612));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 999,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 484, DateTimeKind.Local).AddTicks(9602));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 9998,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 484, DateTimeKind.Local).AddTicks(9586));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 489, DateTimeKind.Local).AddTicks(5014));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 489, DateTimeKind.Local).AddTicks(5346));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 489, DateTimeKind.Local).AddTicks(5358));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 489, DateTimeKind.Local).AddTicks(5365));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 489, DateTimeKind.Local).AddTicks(5373));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 489, DateTimeKind.Local).AddTicks(5426));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 489, DateTimeKind.Local).AddTicks(5435));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 489, DateTimeKind.Local).AddTicks(5444));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 489, DateTimeKind.Local).AddTicks(5455));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 489, DateTimeKind.Local).AddTicks(5467));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 489, DateTimeKind.Local).AddTicks(5475));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 13,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 489, DateTimeKind.Local).AddTicks(5483));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 14,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 489, DateTimeKind.Local).AddTicks(5490));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 15,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 489, DateTimeKind.Local).AddTicks(5498));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 16,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 489, DateTimeKind.Local).AddTicks(5505));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 17,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 489, DateTimeKind.Local).AddTicks(5512));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 18,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 489, DateTimeKind.Local).AddTicks(5519));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 19,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 489, DateTimeKind.Local).AddTicks(5529));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 20,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 489, DateTimeKind.Local).AddTicks(5536));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 9998,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 489, DateTimeKind.Local).AddTicks(5544));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 9999,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 489, DateTimeKind.Local).AddTicks(5551));

            migrationBuilder.UpdateData(
                table: "PaymentStatus",
                keyColumn: "PaymentStatusID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 416, DateTimeKind.Local).AddTicks(5125));

            migrationBuilder.UpdateData(
                table: "PaymentStatus",
                keyColumn: "PaymentStatusID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 416, DateTimeKind.Local).AddTicks(5899));

            migrationBuilder.UpdateData(
                table: "PaymentStatus",
                keyColumn: "PaymentStatusID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 416, DateTimeKind.Local).AddTicks(5913));

            migrationBuilder.UpdateData(
                table: "PaymentStatus",
                keyColumn: "PaymentStatusID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 416, DateTimeKind.Local).AddTicks(5921));

            migrationBuilder.UpdateData(
                table: "PaymentStatus",
                keyColumn: "PaymentStatusID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 416, DateTimeKind.Local).AddTicks(5928));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 410, DateTimeKind.Local).AddTicks(45));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 410, DateTimeKind.Local).AddTicks(933));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 410, DateTimeKind.Local).AddTicks(950));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 410, DateTimeKind.Local).AddTicks(960));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 410, DateTimeKind.Local).AddTicks(971));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 410, DateTimeKind.Local).AddTicks(993));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 410, DateTimeKind.Local).AddTicks(1002));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 410, DateTimeKind.Local).AddTicks(1011));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 410, DateTimeKind.Local).AddTicks(1020));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 410, DateTimeKind.Local).AddTicks(1036));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 410, DateTimeKind.Local).AddTicks(1050));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 410, DateTimeKind.Local).AddTicks(1064));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 13,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 410, DateTimeKind.Local).AddTicks(1076));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 14,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 410, DateTimeKind.Local).AddTicks(1086));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 15,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 410, DateTimeKind.Local).AddTicks(1101));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 16,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 410, DateTimeKind.Local).AddTicks(1109));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 17,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 410, DateTimeKind.Local).AddTicks(1121));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 18,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 410, DateTimeKind.Local).AddTicks(1135));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 19,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 410, DateTimeKind.Local).AddTicks(1146));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 20,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 410, DateTimeKind.Local).AddTicks(1155));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 21,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 410, DateTimeKind.Local).AddTicks(1165));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 22,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 410, DateTimeKind.Local).AddTicks(1177));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 23,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 410, DateTimeKind.Local).AddTicks(1187));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 24,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 410, DateTimeKind.Local).AddTicks(1199));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 25,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 410, DateTimeKind.Local).AddTicks(1215));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 26,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 410, DateTimeKind.Local).AddTicks(1227));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 27,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 410, DateTimeKind.Local).AddTicks(1241));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 28,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 410, DateTimeKind.Local).AddTicks(1250));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 29,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 410, DateTimeKind.Local).AddTicks(1259));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 30,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 410, DateTimeKind.Local).AddTicks(1272));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 31,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 410, DateTimeKind.Local).AddTicks(1282));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 32,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 410, DateTimeKind.Local).AddTicks(1293));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 33,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 410, DateTimeKind.Local).AddTicks(1303));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 34,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 410, DateTimeKind.Local).AddTicks(1412));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 35,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 410, DateTimeKind.Local).AddTicks(1427));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 36,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 410, DateTimeKind.Local).AddTicks(1439));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 37,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 410, DateTimeKind.Local).AddTicks(1448));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 38,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 410, DateTimeKind.Local).AddTicks(1457));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 39,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 410, DateTimeKind.Local).AddTicks(1467));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 40,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 410, DateTimeKind.Local).AddTicks(1476));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 41,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 410, DateTimeKind.Local).AddTicks(1484));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 42,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 410, DateTimeKind.Local).AddTicks(1492));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 43,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 410, DateTimeKind.Local).AddTicks(1501));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 44,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 410, DateTimeKind.Local).AddTicks(1511));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 45,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 410, DateTimeKind.Local).AddTicks(1522));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 46,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 410, DateTimeKind.Local).AddTicks(1533));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 47,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 410, DateTimeKind.Local).AddTicks(1542));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 48,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 410, DateTimeKind.Local).AddTicks(1551));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 49,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 410, DateTimeKind.Local).AddTicks(1560));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 50,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 410, DateTimeKind.Local).AddTicks(1568));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 51,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 410, DateTimeKind.Local).AddTicks(1577));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 52,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 410, DateTimeKind.Local).AddTicks(1588));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 53,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 410, DateTimeKind.Local).AddTicks(1598));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 54,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 410, DateTimeKind.Local).AddTicks(1606));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 55,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 410, DateTimeKind.Local).AddTicks(1616));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 56,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 410, DateTimeKind.Local).AddTicks(1626));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 57,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 410, DateTimeKind.Local).AddTicks(1634));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 58,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 410, DateTimeKind.Local).AddTicks(1642));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 59,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 410, DateTimeKind.Local).AddTicks(1653));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 60,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 410, DateTimeKind.Local).AddTicks(1662));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 61,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 410, DateTimeKind.Local).AddTicks(1673));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 62,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 410, DateTimeKind.Local).AddTicks(1683));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 63,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 410, DateTimeKind.Local).AddTicks(1691));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 64,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 410, DateTimeKind.Local).AddTicks(1699));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 65,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 410, DateTimeKind.Local).AddTicks(1707));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 66,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 410, DateTimeKind.Local).AddTicks(1721));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 67,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 410, DateTimeKind.Local).AddTicks(1731));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 68,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 410, DateTimeKind.Local).AddTicks(1741));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 69,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 410, DateTimeKind.Local).AddTicks(1751));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 70,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 410, DateTimeKind.Local).AddTicks(1759));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 71,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 410, DateTimeKind.Local).AddTicks(1769));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 72,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 410, DateTimeKind.Local).AddTicks(1780));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 73,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 410, DateTimeKind.Local).AddTicks(1789));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 74,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 410, DateTimeKind.Local).AddTicks(1860));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 75,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 410, DateTimeKind.Local).AddTicks(1869));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 76,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 410, DateTimeKind.Local).AddTicks(1879));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 77,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 410, DateTimeKind.Local).AddTicks(1890));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 78,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 410, DateTimeKind.Local).AddTicks(1899));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 79,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 410, DateTimeKind.Local).AddTicks(1909));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 80,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 410, DateTimeKind.Local).AddTicks(1924));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 81,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 410, DateTimeKind.Local).AddTicks(1932));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 82,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 410, DateTimeKind.Local).AddTicks(1946));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 83,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 410, DateTimeKind.Local).AddTicks(1955));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 84,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 410, DateTimeKind.Local).AddTicks(1966));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 85,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 410, DateTimeKind.Local).AddTicks(1975));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 86,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 410, DateTimeKind.Local).AddTicks(1984));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 87,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 410, DateTimeKind.Local).AddTicks(1994));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 88,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 410, DateTimeKind.Local).AddTicks(2002));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 89,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 410, DateTimeKind.Local).AddTicks(2011));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 90,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 410, DateTimeKind.Local).AddTicks(2018));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 91,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 410, DateTimeKind.Local).AddTicks(2027));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 92,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 410, DateTimeKind.Local).AddTicks(2037));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 93,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 410, DateTimeKind.Local).AddTicks(2046));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 94,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 410, DateTimeKind.Local).AddTicks(2054));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 95,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 410, DateTimeKind.Local).AddTicks(2064));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 96,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 410, DateTimeKind.Local).AddTicks(2072));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 97,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 410, DateTimeKind.Local).AddTicks(2085));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 98,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 410, DateTimeKind.Local).AddTicks(2095));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 99,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 410, DateTimeKind.Local).AddTicks(2104));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 100,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 410, DateTimeKind.Local).AddTicks(2113));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 101,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 410, DateTimeKind.Local).AddTicks(2121));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 102,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 410, DateTimeKind.Local).AddTicks(2132));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 103,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 410, DateTimeKind.Local).AddTicks(2141));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 104,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 410, DateTimeKind.Local).AddTicks(2150));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 105,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 410, DateTimeKind.Local).AddTicks(2161));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 106,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 410, DateTimeKind.Local).AddTicks(2171));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 107,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 410, DateTimeKind.Local).AddTicks(2181));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 108,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 410, DateTimeKind.Local).AddTicks(2190));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 109,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 410, DateTimeKind.Local).AddTicks(2201));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 110,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 410, DateTimeKind.Local).AddTicks(2212));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 111,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 410, DateTimeKind.Local).AddTicks(2221));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 112,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 410, DateTimeKind.Local).AddTicks(2234));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 113,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 410, DateTimeKind.Local).AddTicks(2244));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 114,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 410, DateTimeKind.Local).AddTicks(2255));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 115,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 410, DateTimeKind.Local).AddTicks(2266));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 116,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 410, DateTimeKind.Local).AddTicks(2274));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 117,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 410, DateTimeKind.Local).AddTicks(2285));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 118,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 410, DateTimeKind.Local).AddTicks(2294));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 119,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 410, DateTimeKind.Local).AddTicks(2303));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 120,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 410, DateTimeKind.Local).AddTicks(2368));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 121,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 410, DateTimeKind.Local).AddTicks(2378));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 122,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 410, DateTimeKind.Local).AddTicks(2388));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 123,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 410, DateTimeKind.Local).AddTicks(2398));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 124,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 410, DateTimeKind.Local).AddTicks(2408));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 125,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 410, DateTimeKind.Local).AddTicks(2418));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 126,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 410, DateTimeKind.Local).AddTicks(2427));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 127,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 410, DateTimeKind.Local).AddTicks(2436));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 128,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 410, DateTimeKind.Local).AddTicks(2446));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 129,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 410, DateTimeKind.Local).AddTicks(2456));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 130,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 410, DateTimeKind.Local).AddTicks(2472));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 131,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 410, DateTimeKind.Local).AddTicks(2481));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 132,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 410, DateTimeKind.Local).AddTicks(2494));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 133,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 410, DateTimeKind.Local).AddTicks(2506));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 134,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 410, DateTimeKind.Local).AddTicks(2519));

            migrationBuilder.UpdateData(
                table: "PriorityRanks",
                keyColumn: "PriorityRankID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 458, DateTimeKind.Local).AddTicks(6294));

            migrationBuilder.UpdateData(
                table: "PriorityRanks",
                keyColumn: "PriorityRankID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 458, DateTimeKind.Local).AddTicks(6478));

            migrationBuilder.UpdateData(
                table: "PriorityRanks",
                keyColumn: "PriorityRankID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 458, DateTimeKind.Local).AddTicks(6488));

            migrationBuilder.UpdateData(
                table: "PriorityRanks",
                keyColumn: "PriorityRankID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 458, DateTimeKind.Local).AddTicks(6495));

            migrationBuilder.UpdateData(
                table: "RecordStatus",
                keyColumn: "RecordStatusID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 536, DateTimeKind.Local).AddTicks(3768));

            migrationBuilder.UpdateData(
                table: "RecordStatus",
                keyColumn: "RecordStatusID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 536, DateTimeKind.Local).AddTicks(4706));

            migrationBuilder.UpdateData(
                table: "RecordStatus",
                keyColumn: "RecordStatusID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 536, DateTimeKind.Local).AddTicks(4720));

            migrationBuilder.UpdateData(
                table: "RelationshipTypes",
                keyColumn: "RelationshipTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 445, DateTimeKind.Local).AddTicks(9733));

            migrationBuilder.UpdateData(
                table: "RelationshipTypes",
                keyColumn: "RelationshipTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 445, DateTimeKind.Local).AddTicks(9918));

            migrationBuilder.UpdateData(
                table: "RelationshipTypes",
                keyColumn: "RelationshipTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 445, DateTimeKind.Local).AddTicks(9925));

            migrationBuilder.UpdateData(
                table: "RelationshipTypes",
                keyColumn: "RelationshipTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 445, DateTimeKind.Local).AddTicks(9930));

            migrationBuilder.UpdateData(
                table: "RelationshipTypes",
                keyColumn: "RelationshipTypeID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 445, DateTimeKind.Local).AddTicks(9934));

            migrationBuilder.UpdateData(
                table: "RelationshipTypes",
                keyColumn: "RelationshipTypeID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 445, DateTimeKind.Local).AddTicks(9946));

            migrationBuilder.UpdateData(
                table: "RelationshipTypes",
                keyColumn: "RelationshipTypeID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 445, DateTimeKind.Local).AddTicks(9950));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 511, DateTimeKind.Local).AddTicks(3832));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 511, DateTimeKind.Local).AddTicks(4010));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 511, DateTimeKind.Local).AddTicks(4018));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 511, DateTimeKind.Local).AddTicks(4021));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 511, DateTimeKind.Local).AddTicks(4024));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 511, DateTimeKind.Local).AddTicks(4033));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 511, DateTimeKind.Local).AddTicks(4037));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 511, DateTimeKind.Local).AddTicks(4045));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 511, DateTimeKind.Local).AddTicks(4058));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 511, DateTimeKind.Local).AddTicks(4088));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 511, DateTimeKind.Local).AddTicks(4093));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 511, DateTimeKind.Local).AddTicks(4096));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 13,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 511, DateTimeKind.Local).AddTicks(4100));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 14,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 511, DateTimeKind.Local).AddTicks(4104));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 15,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 511, DateTimeKind.Local).AddTicks(4107));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 16,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 511, DateTimeKind.Local).AddTicks(4110));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 17,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 511, DateTimeKind.Local).AddTicks(4113));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 18,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 511, DateTimeKind.Local).AddTicks(4120));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 19,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 511, DateTimeKind.Local).AddTicks(4123));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 21,
                columns: new[] { "LastChangedDate", "MenuID" },
                values: new object[] { new DateTime(2021, 5, 1, 14, 14, 16, 511, DateTimeKind.Local).AddTicks(4130), 9999 });

            migrationBuilder.InsertData(
                table: "RoleMenus",
                columns: new[] { "RoleMenuID", "LastChangedBy", "LastChangedDate", "MenuID", "RoleID" },
                values: new object[] { 20, "SuperUser", new DateTime(2021, 5, 1, 14, 14, 16, 511, DateTimeKind.Local).AddTicks(4127), 9998, 1 });

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 411, DateTimeKind.Local).AddTicks(5614));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 411, DateTimeKind.Local).AddTicks(5779));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 411, DateTimeKind.Local).AddTicks(5785));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 411, DateTimeKind.Local).AddTicks(5790));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 411, DateTimeKind.Local).AddTicks(5793));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 411, DateTimeKind.Local).AddTicks(5803));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 411, DateTimeKind.Local).AddTicks(5807));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 411, DateTimeKind.Local).AddTicks(5810));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 411, DateTimeKind.Local).AddTicks(5813));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 411, DateTimeKind.Local).AddTicks(5819));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 411, DateTimeKind.Local).AddTicks(5823));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 411, DateTimeKind.Local).AddTicks(5827));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 13,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 411, DateTimeKind.Local).AddTicks(5830));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 14,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 411, DateTimeKind.Local).AddTicks(5834));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 15,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 411, DateTimeKind.Local).AddTicks(5838));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 16,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 411, DateTimeKind.Local).AddTicks(5841));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 17,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 411, DateTimeKind.Local).AddTicks(5845));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 18,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 411, DateTimeKind.Local).AddTicks(5851));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 19,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 411, DateTimeKind.Local).AddTicks(5855));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 20,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 411, DateTimeKind.Local).AddTicks(5858));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 21,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 411, DateTimeKind.Local).AddTicks(5862));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 22,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 411, DateTimeKind.Local).AddTicks(5865));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 23,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 411, DateTimeKind.Local).AddTicks(5868));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 24,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 411, DateTimeKind.Local).AddTicks(5872));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 25,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 411, DateTimeKind.Local).AddTicks(5875));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 26,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 411, DateTimeKind.Local).AddTicks(5879));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 27,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 411, DateTimeKind.Local).AddTicks(5883));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 28,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 411, DateTimeKind.Local).AddTicks(5886));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 29,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 411, DateTimeKind.Local).AddTicks(5890));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 30,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 411, DateTimeKind.Local).AddTicks(5893));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 31,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 411, DateTimeKind.Local).AddTicks(5897));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 32,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 411, DateTimeKind.Local).AddTicks(5902));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 33,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 411, DateTimeKind.Local).AddTicks(5905));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 34,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 411, DateTimeKind.Local).AddTicks(5913));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 35,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 411, DateTimeKind.Local).AddTicks(5916));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 36,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 411, DateTimeKind.Local).AddTicks(5919));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 37,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 411, DateTimeKind.Local).AddTicks(5923));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 38,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 411, DateTimeKind.Local).AddTicks(5927));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 39,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 411, DateTimeKind.Local).AddTicks(5930));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 40,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 411, DateTimeKind.Local).AddTicks(5934));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 41,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 411, DateTimeKind.Local).AddTicks(5938));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 42,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 411, DateTimeKind.Local).AddTicks(5942));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 43,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 411, DateTimeKind.Local).AddTicks(5945));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 44,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 411, DateTimeKind.Local).AddTicks(5949));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 45,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 411, DateTimeKind.Local).AddTicks(5952));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 46,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 411, DateTimeKind.Local).AddTicks(5956));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 47,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 411, DateTimeKind.Local).AddTicks(5960));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 48,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 411, DateTimeKind.Local).AddTicks(5963));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 49,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 411, DateTimeKind.Local).AddTicks(5967));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 50,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 411, DateTimeKind.Local).AddTicks(5972));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 51,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 411, DateTimeKind.Local).AddTicks(5975));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 52,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 411, DateTimeKind.Local).AddTicks(5979));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 53,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 411, DateTimeKind.Local).AddTicks(5982));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 54,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 411, DateTimeKind.Local).AddTicks(5986));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 55,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 411, DateTimeKind.Local).AddTicks(5990));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 56,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 411, DateTimeKind.Local).AddTicks(5993));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 57,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 411, DateTimeKind.Local).AddTicks(5997));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 58,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 411, DateTimeKind.Local).AddTicks(6001));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 59,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 411, DateTimeKind.Local).AddTicks(6004));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 60,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 411, DateTimeKind.Local).AddTicks(6007));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 61,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 411, DateTimeKind.Local).AddTicks(6011));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 62,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 411, DateTimeKind.Local).AddTicks(6014));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 63,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 411, DateTimeKind.Local).AddTicks(6018));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 64,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 411, DateTimeKind.Local).AddTicks(6022));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 65,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 411, DateTimeKind.Local).AddTicks(6025));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 66,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 411, DateTimeKind.Local).AddTicks(6109));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 67,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 411, DateTimeKind.Local).AddTicks(6113));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 68,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 411, DateTimeKind.Local).AddTicks(6118));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 69,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 411, DateTimeKind.Local).AddTicks(6122));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 70,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 411, DateTimeKind.Local).AddTicks(6126));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 71,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 411, DateTimeKind.Local).AddTicks(6131));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 72,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 411, DateTimeKind.Local).AddTicks(6134));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 73,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 411, DateTimeKind.Local).AddTicks(6139));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 74,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 411, DateTimeKind.Local).AddTicks(6143));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 75,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 411, DateTimeKind.Local).AddTicks(6146));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 76,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 411, DateTimeKind.Local).AddTicks(6150));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 77,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 411, DateTimeKind.Local).AddTicks(6153));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 78,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 411, DateTimeKind.Local).AddTicks(6157));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 79,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 411, DateTimeKind.Local).AddTicks(6160));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 80,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 411, DateTimeKind.Local).AddTicks(6163));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 81,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 411, DateTimeKind.Local).AddTicks(6167));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 82,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 411, DateTimeKind.Local).AddTicks(6171));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 83,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 411, DateTimeKind.Local).AddTicks(6174));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 84,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 411, DateTimeKind.Local).AddTicks(6178));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 85,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 411, DateTimeKind.Local).AddTicks(6182));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 86,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 411, DateTimeKind.Local).AddTicks(6186));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 87,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 411, DateTimeKind.Local).AddTicks(6189));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 88,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 411, DateTimeKind.Local).AddTicks(6193));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 89,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 411, DateTimeKind.Local).AddTicks(6196));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 90,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 411, DateTimeKind.Local).AddTicks(6200));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 91,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 411, DateTimeKind.Local).AddTicks(6204));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 92,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 411, DateTimeKind.Local).AddTicks(6209));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 93,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 411, DateTimeKind.Local).AddTicks(6213));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 94,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 411, DateTimeKind.Local).AddTicks(6218));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 95,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 411, DateTimeKind.Local).AddTicks(6222));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 96,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 411, DateTimeKind.Local).AddTicks(6225));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 97,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 411, DateTimeKind.Local).AddTicks(6230));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 98,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 411, DateTimeKind.Local).AddTicks(6233));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 99,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 411, DateTimeKind.Local).AddTicks(6237));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 100,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 411, DateTimeKind.Local).AddTicks(6240));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 101,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 411, DateTimeKind.Local).AddTicks(6244));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 102,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 411, DateTimeKind.Local).AddTicks(6247));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 103,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 411, DateTimeKind.Local).AddTicks(6251));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 104,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 411, DateTimeKind.Local).AddTicks(6254));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 105,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 411, DateTimeKind.Local).AddTicks(6258));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 106,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 411, DateTimeKind.Local).AddTicks(6261));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 107,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 411, DateTimeKind.Local).AddTicks(6265));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 108,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 411, DateTimeKind.Local).AddTicks(6268));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 109,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 411, DateTimeKind.Local).AddTicks(6272));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 110,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 411, DateTimeKind.Local).AddTicks(6275));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 111,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 411, DateTimeKind.Local).AddTicks(6278));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 112,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 411, DateTimeKind.Local).AddTicks(6282));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 113,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 411, DateTimeKind.Local).AddTicks(6285));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 114,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 411, DateTimeKind.Local).AddTicks(6289));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 115,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 411, DateTimeKind.Local).AddTicks(6292));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 116,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 411, DateTimeKind.Local).AddTicks(6296));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 117,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 411, DateTimeKind.Local).AddTicks(6301));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 118,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 411, DateTimeKind.Local).AddTicks(6304));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 119,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 411, DateTimeKind.Local).AddTicks(6308));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 120,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 411, DateTimeKind.Local).AddTicks(6312));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 121,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 411, DateTimeKind.Local).AddTicks(6319));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 122,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 411, DateTimeKind.Local).AddTicks(6322));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 123,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 411, DateTimeKind.Local).AddTicks(6327));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 124,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 411, DateTimeKind.Local).AddTicks(6332));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 125,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 411, DateTimeKind.Local).AddTicks(6336));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 126,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 411, DateTimeKind.Local).AddTicks(6339));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 127,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 411, DateTimeKind.Local).AddTicks(6343));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 128,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 411, DateTimeKind.Local).AddTicks(6347));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 129,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 411, DateTimeKind.Local).AddTicks(6350));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 130,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 411, DateTimeKind.Local).AddTicks(6358));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 131,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 411, DateTimeKind.Local).AddTicks(6362));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 132,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 411, DateTimeKind.Local).AddTicks(6365));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 133,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 411, DateTimeKind.Local).AddTicks(6369));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 134,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 411, DateTimeKind.Local).AddTicks(6373));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 400, DateTimeKind.Local).AddTicks(154));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 402, DateTimeKind.Local).AddTicks(1964));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 402, DateTimeKind.Local).AddTicks(2070));

            migrationBuilder.UpdateData(
                table: "StatementLists",
                keyColumn: "StatementID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 521, DateTimeKind.Local).AddTicks(5474));

            migrationBuilder.UpdateData(
                table: "StatementLists",
                keyColumn: "StatementID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 521, DateTimeKind.Local).AddTicks(6089));

            migrationBuilder.UpdateData(
                table: "SystemVariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 450, DateTimeKind.Local).AddTicks(1908));

            migrationBuilder.UpdateData(
                table: "SystemVariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 450, DateTimeKind.Local).AddTicks(2399));

            migrationBuilder.UpdateData(
                table: "SystemVariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 450, DateTimeKind.Local).AddTicks(2391));

            migrationBuilder.UpdateData(
                table: "SystemVariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 450, DateTimeKind.Local).AddTicks(2383));

            migrationBuilder.UpdateData(
                table: "SystemVariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 450, DateTimeKind.Local).AddTicks(2373));

            migrationBuilder.UpdateData(
                table: "SystemVariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 450, DateTimeKind.Local).AddTicks(2415));

            migrationBuilder.UpdateData(
                table: "SystemVariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 450, DateTimeKind.Local).AddTicks(2433));

            migrationBuilder.UpdateData(
                table: "SystemVariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 450, DateTimeKind.Local).AddTicks(2442));

            migrationBuilder.UpdateData(
                table: "SystemVariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 450, DateTimeKind.Local).AddTicks(2450));

            migrationBuilder.UpdateData(
                table: "Titles",
                keyColumn: "TitleID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 525, DateTimeKind.Local).AddTicks(8112));

            migrationBuilder.UpdateData(
                table: "Titles",
                keyColumn: "TitleID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 525, DateTimeKind.Local).AddTicks(8979));

            migrationBuilder.UpdateData(
                table: "Titles",
                keyColumn: "TitleID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 525, DateTimeKind.Local).AddTicks(8992));

            migrationBuilder.UpdateData(
                table: "Titles",
                keyColumn: "TitleID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 525, DateTimeKind.Local).AddTicks(8997));

            migrationBuilder.UpdateData(
                table: "Titles",
                keyColumn: "TitleID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 525, DateTimeKind.Local).AddTicks(9002));

            migrationBuilder.UpdateData(
                table: "Titles",
                keyColumn: "TitleID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 525, DateTimeKind.Local).AddTicks(9017));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 422, DateTimeKind.Local).AddTicks(2538));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 422, DateTimeKind.Local).AddTicks(3753));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 422, DateTimeKind.Local).AddTicks(3917));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 422, DateTimeKind.Local).AddTicks(4069));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 422, DateTimeKind.Local).AddTicks(4214));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 422, DateTimeKind.Local).AddTicks(4364));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 422, DateTimeKind.Local).AddTicks(4519));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 422, DateTimeKind.Local).AddTicks(4948));

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumns: new[] { "UserID", "RoleID" },
                keyValues: new object[] { 1, 1 },
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 481, DateTimeKind.Local).AddTicks(3514));

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumns: new[] { "UserID", "RoleID" },
                keyValues: new object[] { 2, 3 },
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 481, DateTimeKind.Local).AddTicks(3660));

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "UserTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 442, DateTimeKind.Local).AddTicks(6238));

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "UserTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 442, DateTimeKind.Local).AddTicks(7057));

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "UserTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 442, DateTimeKind.Local).AddTicks(7073));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 460, DateTimeKind.Local).AddTicks(795));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 465, DateTimeKind.Local).AddTicks(7858));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2021, 5, 1, 14, 14, 16, 465, DateTimeKind.Local).AddTicks(8467));
        }
    }
}
