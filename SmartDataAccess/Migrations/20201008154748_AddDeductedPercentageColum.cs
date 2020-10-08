using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SmartDataAccess.Migrations
{
    public partial class AddDeductedPercentageColum : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "DeductionPercentage",
                table: "ClientDeductions",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.UpdateData(
                table: "BankAccountTypes",
                keyColumn: "BankAccountTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 523, DateTimeKind.Local).AddTicks(536));

            migrationBuilder.UpdateData(
                table: "BankAccountTypes",
                keyColumn: "BankAccountTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 523, DateTimeKind.Local).AddTicks(1046));

            migrationBuilder.UpdateData(
                table: "BankAccountTypes",
                keyColumn: "BankAccountTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 523, DateTimeKind.Local).AddTicks(1056));

            migrationBuilder.UpdateData(
                table: "BankAccountTypes",
                keyColumn: "BankAccountTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 523, DateTimeKind.Local).AddTicks(1060));

            migrationBuilder.UpdateData(
                table: "ContactTypes",
                keyColumn: "ContactTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 534, DateTimeKind.Local).AddTicks(1268));

            migrationBuilder.UpdateData(
                table: "ContactTypes",
                keyColumn: "ContactTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 534, DateTimeKind.Local).AddTicks(1262));

            migrationBuilder.UpdateData(
                table: "ContactTypes",
                keyColumn: "ContactTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 534, DateTimeKind.Local).AddTicks(1254));

            migrationBuilder.UpdateData(
                table: "ContactTypes",
                keyColumn: "ContactTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 534, DateTimeKind.Local).AddTicks(1138));

            migrationBuilder.UpdateData(
                table: "ContactTypes",
                keyColumn: "ContactTypeID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 534, DateTimeKind.Local).AddTicks(1274));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 541, DateTimeKind.Local).AddTicks(2625));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 541, DateTimeKind.Local).AddTicks(3080));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 541, DateTimeKind.Local).AddTicks(3093));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 541, DateTimeKind.Local).AddTicks(3104));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 541, DateTimeKind.Local).AddTicks(3108));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 541, DateTimeKind.Local).AddTicks(3118));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 541, DateTimeKind.Local).AddTicks(3123));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 541, DateTimeKind.Local).AddTicks(3128));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 541, DateTimeKind.Local).AddTicks(3132));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 541, DateTimeKind.Local).AddTicks(3138));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 541, DateTimeKind.Local).AddTicks(3142));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 541, DateTimeKind.Local).AddTicks(3146));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 13,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 541, DateTimeKind.Local).AddTicks(3150));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 14,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 541, DateTimeKind.Local).AddTicks(3154));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 15,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 541, DateTimeKind.Local).AddTicks(3158));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 16,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 541, DateTimeKind.Local).AddTicks(3164));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 17,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 541, DateTimeKind.Local).AddTicks(3168));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 18,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 541, DateTimeKind.Local).AddTicks(3175));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 19,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 541, DateTimeKind.Local).AddTicks(3179));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 20,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 541, DateTimeKind.Local).AddTicks(3183));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 21,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 541, DateTimeKind.Local).AddTicks(3186));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 22,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 541, DateTimeKind.Local).AddTicks(3190));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 23,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 541, DateTimeKind.Local).AddTicks(3194));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 24,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 541, DateTimeKind.Local).AddTicks(3198));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 25,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 541, DateTimeKind.Local).AddTicks(3202));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 26,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 541, DateTimeKind.Local).AddTicks(3206));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 27,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 541, DateTimeKind.Local).AddTicks(3211));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 28,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 541, DateTimeKind.Local).AddTicks(3215));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 29,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 541, DateTimeKind.Local).AddTicks(3219));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 30,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 541, DateTimeKind.Local).AddTicks(3226));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 31,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 541, DateTimeKind.Local).AddTicks(3230));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 32,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 541, DateTimeKind.Local).AddTicks(3234));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 33,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 541, DateTimeKind.Local).AddTicks(3239));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 34,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 541, DateTimeKind.Local).AddTicks(3246));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 35,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 541, DateTimeKind.Local).AddTicks(3249));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 36,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 541, DateTimeKind.Local).AddTicks(3253));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 37,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 541, DateTimeKind.Local).AddTicks(3258));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 38,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 541, DateTimeKind.Local).AddTicks(3261));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 39,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 541, DateTimeKind.Local).AddTicks(3266));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 40,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 541, DateTimeKind.Local).AddTicks(3271));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 41,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 541, DateTimeKind.Local).AddTicks(3276));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 42,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 541, DateTimeKind.Local).AddTicks(3280));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 43,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 541, DateTimeKind.Local).AddTicks(3284));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 44,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 541, DateTimeKind.Local).AddTicks(3289));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 45,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 541, DateTimeKind.Local).AddTicks(3293));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 46,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 541, DateTimeKind.Local).AddTicks(3297));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 47,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 541, DateTimeKind.Local).AddTicks(3302));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 48,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 541, DateTimeKind.Local).AddTicks(3320));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 49,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 541, DateTimeKind.Local).AddTicks(3326));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 50,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 541, DateTimeKind.Local).AddTicks(3331));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 51,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 541, DateTimeKind.Local).AddTicks(3336));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 52,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 541, DateTimeKind.Local).AddTicks(3340));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 53,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 541, DateTimeKind.Local).AddTicks(3343));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 54,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 541, DateTimeKind.Local).AddTicks(3347));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 55,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 541, DateTimeKind.Local).AddTicks(3352));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 56,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 541, DateTimeKind.Local).AddTicks(3356));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 57,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 541, DateTimeKind.Local).AddTicks(3359));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 58,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 541, DateTimeKind.Local).AddTicks(3364));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 59,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 541, DateTimeKind.Local).AddTicks(3369));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 60,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 541, DateTimeKind.Local).AddTicks(3374));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 61,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 541, DateTimeKind.Local).AddTicks(3378));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 62,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 541, DateTimeKind.Local).AddTicks(3382));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 63,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 541, DateTimeKind.Local).AddTicks(3386));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 64,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 541, DateTimeKind.Local).AddTicks(3391));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 65,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 541, DateTimeKind.Local).AddTicks(3395));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 66,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 541, DateTimeKind.Local).AddTicks(3402));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 67,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 541, DateTimeKind.Local).AddTicks(3406));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 68,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 541, DateTimeKind.Local).AddTicks(3411));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 69,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 541, DateTimeKind.Local).AddTicks(3414));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 70,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 541, DateTimeKind.Local).AddTicks(3418));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 71,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 541, DateTimeKind.Local).AddTicks(3422));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 72,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 541, DateTimeKind.Local).AddTicks(3426));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 73,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 541, DateTimeKind.Local).AddTicks(3431));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 74,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 541, DateTimeKind.Local).AddTicks(3435));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 75,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 541, DateTimeKind.Local).AddTicks(3440));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 76,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 541, DateTimeKind.Local).AddTicks(3445));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 77,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 541, DateTimeKind.Local).AddTicks(3448));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 78,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 541, DateTimeKind.Local).AddTicks(3452));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 79,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 541, DateTimeKind.Local).AddTicks(3456));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 80,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 541, DateTimeKind.Local).AddTicks(3460));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 81,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 541, DateTimeKind.Local).AddTicks(3464));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 82,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 541, DateTimeKind.Local).AddTicks(3468));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 83,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 541, DateTimeKind.Local).AddTicks(3471));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 84,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 541, DateTimeKind.Local).AddTicks(3476));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 85,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 541, DateTimeKind.Local).AddTicks(3479));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 86,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 541, DateTimeKind.Local).AddTicks(3483));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 87,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 541, DateTimeKind.Local).AddTicks(3487));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 88,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 541, DateTimeKind.Local).AddTicks(3491));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 89,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 541, DateTimeKind.Local).AddTicks(3496));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 90,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 541, DateTimeKind.Local).AddTicks(3500));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 91,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 541, DateTimeKind.Local).AddTicks(3503));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 92,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 541, DateTimeKind.Local).AddTicks(3507));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 93,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 541, DateTimeKind.Local).AddTicks(3512));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 94,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 541, DateTimeKind.Local).AddTicks(3515));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 95,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 541, DateTimeKind.Local).AddTicks(3519));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 96,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 541, DateTimeKind.Local).AddTicks(3523));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 97,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 541, DateTimeKind.Local).AddTicks(3527));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 98,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 541, DateTimeKind.Local).AddTicks(3531));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 99,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 541, DateTimeKind.Local).AddTicks(3535));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 100,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 541, DateTimeKind.Local).AddTicks(3538));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 101,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 541, DateTimeKind.Local).AddTicks(3544));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 102,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 541, DateTimeKind.Local).AddTicks(3548));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 103,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 541, DateTimeKind.Local).AddTicks(3552));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 104,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 541, DateTimeKind.Local).AddTicks(3555));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 105,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 541, DateTimeKind.Local).AddTicks(3559));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 106,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 541, DateTimeKind.Local).AddTicks(3563));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 107,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 541, DateTimeKind.Local).AddTicks(3567));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 108,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 541, DateTimeKind.Local).AddTicks(3571));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 109,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 541, DateTimeKind.Local).AddTicks(3583));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 110,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 541, DateTimeKind.Local).AddTicks(3586));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 111,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 541, DateTimeKind.Local).AddTicks(3591));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 112,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 541, DateTimeKind.Local).AddTicks(3595));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 113,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 541, DateTimeKind.Local).AddTicks(3599));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 114,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 541, DateTimeKind.Local).AddTicks(3603));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 115,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 541, DateTimeKind.Local).AddTicks(3608));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 116,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 541, DateTimeKind.Local).AddTicks(3612));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 117,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 541, DateTimeKind.Local).AddTicks(3616));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 118,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 541, DateTimeKind.Local).AddTicks(3620));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 119,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 541, DateTimeKind.Local).AddTicks(3624));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 120,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 541, DateTimeKind.Local).AddTicks(3627));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 121,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 541, DateTimeKind.Local).AddTicks(3632));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 122,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 541, DateTimeKind.Local).AddTicks(3636));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 123,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 541, DateTimeKind.Local).AddTicks(3640));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 124,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 541, DateTimeKind.Local).AddTicks(3643));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 125,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 541, DateTimeKind.Local).AddTicks(3647));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 126,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 541, DateTimeKind.Local).AddTicks(3651));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 127,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 541, DateTimeKind.Local).AddTicks(3655));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 128,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 541, DateTimeKind.Local).AddTicks(3659));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 129,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 541, DateTimeKind.Local).AddTicks(3663));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 130,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 541, DateTimeKind.Local).AddTicks(3670));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 131,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 541, DateTimeKind.Local).AddTicks(3674));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 132,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 541, DateTimeKind.Local).AddTicks(3678));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 133,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 541, DateTimeKind.Local).AddTicks(3682));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 134,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 541, DateTimeKind.Local).AddTicks(3686));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 135,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 541, DateTimeKind.Local).AddTicks(3690));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 136,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 541, DateTimeKind.Local).AddTicks(3694));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 137,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 541, DateTimeKind.Local).AddTicks(3698));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 138,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 541, DateTimeKind.Local).AddTicks(3703));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 139,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 541, DateTimeKind.Local).AddTicks(3707));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 140,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 541, DateTimeKind.Local).AddTicks(3711));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 141,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 541, DateTimeKind.Local).AddTicks(3715));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 142,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 541, DateTimeKind.Local).AddTicks(3718));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 143,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 541, DateTimeKind.Local).AddTicks(3723));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 144,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 541, DateTimeKind.Local).AddTicks(3726));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 145,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 541, DateTimeKind.Local).AddTicks(3730));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 146,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 541, DateTimeKind.Local).AddTicks(3734));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 147,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 541, DateTimeKind.Local).AddTicks(3738));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 148,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 541, DateTimeKind.Local).AddTicks(3742));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 149,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 541, DateTimeKind.Local).AddTicks(3746));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 150,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 541, DateTimeKind.Local).AddTicks(3752));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 151,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 541, DateTimeKind.Local).AddTicks(3756));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 152,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 541, DateTimeKind.Local).AddTicks(3760));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 153,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 541, DateTimeKind.Local).AddTicks(3764));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 154,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 541, DateTimeKind.Local).AddTicks(3768));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 155,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 541, DateTimeKind.Local).AddTicks(3773));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 156,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 541, DateTimeKind.Local).AddTicks(3777));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 157,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 541, DateTimeKind.Local).AddTicks(3781));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 158,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 541, DateTimeKind.Local).AddTicks(3785));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 159,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 541, DateTimeKind.Local).AddTicks(3789));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 160,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 541, DateTimeKind.Local).AddTicks(3793));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 161,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 541, DateTimeKind.Local).AddTicks(3798));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 162,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 541, DateTimeKind.Local).AddTicks(3802));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 163,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 541, DateTimeKind.Local).AddTicks(3813));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 164,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 541, DateTimeKind.Local).AddTicks(3817));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 165,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 541, DateTimeKind.Local).AddTicks(3821));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 166,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 541, DateTimeKind.Local).AddTicks(3825));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 167,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 541, DateTimeKind.Local).AddTicks(3829));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 168,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 541, DateTimeKind.Local).AddTicks(3833));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 169,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 541, DateTimeKind.Local).AddTicks(3837));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 170,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 541, DateTimeKind.Local).AddTicks(3841));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 171,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 541, DateTimeKind.Local).AddTicks(3845));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 172,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 541, DateTimeKind.Local).AddTicks(3849));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 173,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 541, DateTimeKind.Local).AddTicks(3854));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 174,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 541, DateTimeKind.Local).AddTicks(3858));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 175,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 541, DateTimeKind.Local).AddTicks(3863));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 176,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 541, DateTimeKind.Local).AddTicks(3868));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 177,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 541, DateTimeKind.Local).AddTicks(3875));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 178,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 541, DateTimeKind.Local).AddTicks(3879));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 179,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 541, DateTimeKind.Local).AddTicks(3883));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 180,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 541, DateTimeKind.Local).AddTicks(3889));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 181,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 541, DateTimeKind.Local).AddTicks(3893));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 182,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 541, DateTimeKind.Local).AddTicks(3897));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 183,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 541, DateTimeKind.Local).AddTicks(3901));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 184,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 541, DateTimeKind.Local).AddTicks(3905));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 185,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 541, DateTimeKind.Local).AddTicks(3909));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 186,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 541, DateTimeKind.Local).AddTicks(3913));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 187,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 541, DateTimeKind.Local).AddTicks(3917));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 188,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 541, DateTimeKind.Local).AddTicks(3921));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 189,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 541, DateTimeKind.Local).AddTicks(3926));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 190,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 541, DateTimeKind.Local).AddTicks(3930));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 191,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 541, DateTimeKind.Local).AddTicks(3934));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 192,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 541, DateTimeKind.Local).AddTicks(3938));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 193,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 541, DateTimeKind.Local).AddTicks(3943));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 194,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 541, DateTimeKind.Local).AddTicks(3946));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 195,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 541, DateTimeKind.Local).AddTicks(3951));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 196,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 541, DateTimeKind.Local).AddTicks(3954));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 197,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 541, DateTimeKind.Local).AddTicks(3958));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 198,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 541, DateTimeKind.Local).AddTicks(3962));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 199,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 541, DateTimeKind.Local).AddTicks(3966));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 200,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 541, DateTimeKind.Local).AddTicks(3970));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 201,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 541, DateTimeKind.Local).AddTicks(3974));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 202,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 541, DateTimeKind.Local).AddTicks(3978));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 203,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 541, DateTimeKind.Local).AddTicks(3982));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 204,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 541, DateTimeKind.Local).AddTicks(3986));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 205,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 541, DateTimeKind.Local).AddTicks(3989));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 206,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 541, DateTimeKind.Local).AddTicks(3994));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 207,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 541, DateTimeKind.Local).AddTicks(3997));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 208,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 541, DateTimeKind.Local).AddTicks(4001));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 209,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 541, DateTimeKind.Local).AddTicks(4005));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 210,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 541, DateTimeKind.Local).AddTicks(4010));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 211,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 541, DateTimeKind.Local).AddTicks(4014));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 212,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 541, DateTimeKind.Local).AddTicks(4018));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 213,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 541, DateTimeKind.Local).AddTicks(4022));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 214,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 541, DateTimeKind.Local).AddTicks(4026));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 215,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 541, DateTimeKind.Local).AddTicks(4031));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 216,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 541, DateTimeKind.Local).AddTicks(4036));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 217,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 541, DateTimeKind.Local).AddTicks(4040));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 218,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 541, DateTimeKind.Local).AddTicks(4044));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 219,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 541, DateTimeKind.Local).AddTicks(4048));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 220,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 541, DateTimeKind.Local).AddTicks(4052));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 221,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 541, DateTimeKind.Local).AddTicks(4055));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 222,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 541, DateTimeKind.Local).AddTicks(4060));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 223,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 541, DateTimeKind.Local).AddTicks(4064));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 224,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 541, DateTimeKind.Local).AddTicks(4069));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 225,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 541, DateTimeKind.Local).AddTicks(4073));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 226,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 541, DateTimeKind.Local).AddTicks(4077));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 227,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 541, DateTimeKind.Local).AddTicks(4081));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 228,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 541, DateTimeKind.Local).AddTicks(4085));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 526, DateTimeKind.Local).AddTicks(3737));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 526, DateTimeKind.Local).AddTicks(4239));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 526, DateTimeKind.Local).AddTicks(4249));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 526, DateTimeKind.Local).AddTicks(4254));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 526, DateTimeKind.Local).AddTicks(4259));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 526, DateTimeKind.Local).AddTicks(4273));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 526, DateTimeKind.Local).AddTicks(4278));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 526, DateTimeKind.Local).AddTicks(4282));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 526, DateTimeKind.Local).AddTicks(4286));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 526, DateTimeKind.Local).AddTicks(4303));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 526, DateTimeKind.Local).AddTicks(4307));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 526, DateTimeKind.Local).AddTicks(4311));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 13,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 526, DateTimeKind.Local).AddTicks(4316));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 14,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 526, DateTimeKind.Local).AddTicks(4320));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 15,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 526, DateTimeKind.Local).AddTicks(4324));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 16,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 526, DateTimeKind.Local).AddTicks(4328));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 17,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 526, DateTimeKind.Local).AddTicks(4332));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 18,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 526, DateTimeKind.Local).AddTicks(4339));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 19,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 526, DateTimeKind.Local).AddTicks(4343));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 20,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 526, DateTimeKind.Local).AddTicks(4347));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 21,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 526, DateTimeKind.Local).AddTicks(4352));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 22,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 526, DateTimeKind.Local).AddTicks(4356));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 23,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 526, DateTimeKind.Local).AddTicks(4361));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 24,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 526, DateTimeKind.Local).AddTicks(4365));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 25,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 526, DateTimeKind.Local).AddTicks(4369));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 26,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 526, DateTimeKind.Local).AddTicks(4373));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 27,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 526, DateTimeKind.Local).AddTicks(4377));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 28,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 526, DateTimeKind.Local).AddTicks(4382));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 29,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 526, DateTimeKind.Local).AddTicks(4386));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 30,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 526, DateTimeKind.Local).AddTicks(4389));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 31,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 526, DateTimeKind.Local).AddTicks(4394));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 32,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 526, DateTimeKind.Local).AddTicks(4398));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 33,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 526, DateTimeKind.Local).AddTicks(4402));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 34,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 526, DateTimeKind.Local).AddTicks(4409));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 35,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 526, DateTimeKind.Local).AddTicks(4412));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 36,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 526, DateTimeKind.Local).AddTicks(4417));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 37,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 526, DateTimeKind.Local).AddTicks(4421));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 38,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 526, DateTimeKind.Local).AddTicks(4425));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 39,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 526, DateTimeKind.Local).AddTicks(4429));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 40,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 526, DateTimeKind.Local).AddTicks(4433));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 41,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 526, DateTimeKind.Local).AddTicks(4437));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 42,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 526, DateTimeKind.Local).AddTicks(4441));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 43,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 526, DateTimeKind.Local).AddTicks(4446));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 44,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 526, DateTimeKind.Local).AddTicks(4450));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 45,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 526, DateTimeKind.Local).AddTicks(4453));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 46,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 526, DateTimeKind.Local).AddTicks(4458));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 47,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 526, DateTimeKind.Local).AddTicks(4462));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 48,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 526, DateTimeKind.Local).AddTicks(4466));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 49,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 526, DateTimeKind.Local).AddTicks(4470));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 50,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 526, DateTimeKind.Local).AddTicks(4473));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 51,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 526, DateTimeKind.Local).AddTicks(4478));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 52,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 526, DateTimeKind.Local).AddTicks(4482));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 53,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 526, DateTimeKind.Local).AddTicks(4486));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 54,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 526, DateTimeKind.Local).AddTicks(4491));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 55,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 526, DateTimeKind.Local).AddTicks(4494));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 56,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 526, DateTimeKind.Local).AddTicks(4499));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 57,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 526, DateTimeKind.Local).AddTicks(4503));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 58,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 526, DateTimeKind.Local).AddTicks(4506));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 59,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 526, DateTimeKind.Local).AddTicks(4511));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 60,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 526, DateTimeKind.Local).AddTicks(4514));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 61,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 526, DateTimeKind.Local).AddTicks(4519));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 62,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 526, DateTimeKind.Local).AddTicks(4523));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 63,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 526, DateTimeKind.Local).AddTicks(4527));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 64,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 526, DateTimeKind.Local).AddTicks(4531));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 65,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 526, DateTimeKind.Local).AddTicks(4535));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 66,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 526, DateTimeKind.Local).AddTicks(4542));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 67,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 526, DateTimeKind.Local).AddTicks(4546));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 68,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 526, DateTimeKind.Local).AddTicks(4550));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 69,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 526, DateTimeKind.Local).AddTicks(4562));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 70,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 526, DateTimeKind.Local).AddTicks(4567));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 71,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 526, DateTimeKind.Local).AddTicks(4571));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 72,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 526, DateTimeKind.Local).AddTicks(4576));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 73,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 526, DateTimeKind.Local).AddTicks(4580));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 74,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 526, DateTimeKind.Local).AddTicks(4584));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 75,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 526, DateTimeKind.Local).AddTicks(4588));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 76,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 526, DateTimeKind.Local).AddTicks(4592));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 77,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 526, DateTimeKind.Local).AddTicks(4596));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 78,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 526, DateTimeKind.Local).AddTicks(4600));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 79,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 526, DateTimeKind.Local).AddTicks(4604));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 80,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 526, DateTimeKind.Local).AddTicks(4608));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 81,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 526, DateTimeKind.Local).AddTicks(4612));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 82,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 526, DateTimeKind.Local).AddTicks(4616));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 83,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 526, DateTimeKind.Local).AddTicks(4621));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 84,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 526, DateTimeKind.Local).AddTicks(4625));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 85,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 526, DateTimeKind.Local).AddTicks(4629));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 86,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 526, DateTimeKind.Local).AddTicks(4633));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 87,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 526, DateTimeKind.Local).AddTicks(4637));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 88,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 526, DateTimeKind.Local).AddTicks(4641));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 89,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 526, DateTimeKind.Local).AddTicks(4645));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 90,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 526, DateTimeKind.Local).AddTicks(4649));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 91,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 526, DateTimeKind.Local).AddTicks(4653));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 92,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 526, DateTimeKind.Local).AddTicks(4657));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 93,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 526, DateTimeKind.Local).AddTicks(4661));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 94,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 526, DateTimeKind.Local).AddTicks(4665));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 95,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 526, DateTimeKind.Local).AddTicks(4669));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 96,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 526, DateTimeKind.Local).AddTicks(4673));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 97,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 526, DateTimeKind.Local).AddTicks(4677));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 98,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 526, DateTimeKind.Local).AddTicks(4681));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 99,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 526, DateTimeKind.Local).AddTicks(4685));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 100,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 526, DateTimeKind.Local).AddTicks(4689));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 101,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 526, DateTimeKind.Local).AddTicks(4693));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 102,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 526, DateTimeKind.Local).AddTicks(4697));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 103,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 526, DateTimeKind.Local).AddTicks(4702));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 104,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 526, DateTimeKind.Local).AddTicks(4706));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 105,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 526, DateTimeKind.Local).AddTicks(4710));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 106,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 526, DateTimeKind.Local).AddTicks(4714));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 107,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 526, DateTimeKind.Local).AddTicks(4718));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 108,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 526, DateTimeKind.Local).AddTicks(4722));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 109,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 526, DateTimeKind.Local).AddTicks(4726));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 110,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 526, DateTimeKind.Local).AddTicks(4730));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 111,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 526, DateTimeKind.Local).AddTicks(4734));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 112,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 526, DateTimeKind.Local).AddTicks(4738));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 113,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 526, DateTimeKind.Local).AddTicks(4742));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 114,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 526, DateTimeKind.Local).AddTicks(4746));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 115,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 526, DateTimeKind.Local).AddTicks(4750));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 116,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 526, DateTimeKind.Local).AddTicks(4754));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 117,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 526, DateTimeKind.Local).AddTicks(4758));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 118,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 526, DateTimeKind.Local).AddTicks(4763));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 119,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 526, DateTimeKind.Local).AddTicks(4766));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 120,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 526, DateTimeKind.Local).AddTicks(4770));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 121,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 526, DateTimeKind.Local).AddTicks(4774));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 122,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 526, DateTimeKind.Local).AddTicks(4778));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 123,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 526, DateTimeKind.Local).AddTicks(4783));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 124,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 526, DateTimeKind.Local).AddTicks(4787));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 125,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 526, DateTimeKind.Local).AddTicks(4791));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 126,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 526, DateTimeKind.Local).AddTicks(4795));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 127,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 526, DateTimeKind.Local).AddTicks(4799));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 128,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 526, DateTimeKind.Local).AddTicks(4803));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 129,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 526, DateTimeKind.Local).AddTicks(4807));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 130,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 526, DateTimeKind.Local).AddTicks(4821));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 131,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 526, DateTimeKind.Local).AddTicks(4825));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 132,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 526, DateTimeKind.Local).AddTicks(4829));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 133,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 526, DateTimeKind.Local).AddTicks(4833));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 134,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 526, DateTimeKind.Local).AddTicks(4837));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 135,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 526, DateTimeKind.Local).AddTicks(4841));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 136,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 526, DateTimeKind.Local).AddTicks(4845));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 137,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 526, DateTimeKind.Local).AddTicks(4849));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 138,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 526, DateTimeKind.Local).AddTicks(4854));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 139,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 526, DateTimeKind.Local).AddTicks(4857));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 140,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 526, DateTimeKind.Local).AddTicks(4862));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 141,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 526, DateTimeKind.Local).AddTicks(4866));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 142,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 526, DateTimeKind.Local).AddTicks(4869));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 143,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 526, DateTimeKind.Local).AddTicks(4874));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 144,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 526, DateTimeKind.Local).AddTicks(4878));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 145,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 526, DateTimeKind.Local).AddTicks(4882));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 146,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 526, DateTimeKind.Local).AddTicks(4886));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 147,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 526, DateTimeKind.Local).AddTicks(4890));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 148,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 526, DateTimeKind.Local).AddTicks(4894));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 149,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 526, DateTimeKind.Local).AddTicks(4898));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 150,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 526, DateTimeKind.Local).AddTicks(4902));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 151,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 526, DateTimeKind.Local).AddTicks(4906));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 152,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 526, DateTimeKind.Local).AddTicks(4910));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 153,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 526, DateTimeKind.Local).AddTicks(4914));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 154,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 526, DateTimeKind.Local).AddTicks(4918));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 155,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 526, DateTimeKind.Local).AddTicks(4922));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 156,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 526, DateTimeKind.Local).AddTicks(4926));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 157,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 526, DateTimeKind.Local).AddTicks(4930));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 158,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 526, DateTimeKind.Local).AddTicks(4934));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 159,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 526, DateTimeKind.Local).AddTicks(4938));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 160,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 526, DateTimeKind.Local).AddTicks(4942));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 161,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 526, DateTimeKind.Local).AddTicks(4946));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 162,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 526, DateTimeKind.Local).AddTicks(4950));

            migrationBuilder.UpdateData(
                table: "CustomSettingTypes",
                keyColumn: "CustomSettingTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 536, DateTimeKind.Local).AddTicks(98));

            migrationBuilder.UpdateData(
                table: "CustomSettingTypes",
                keyColumn: "CustomSettingTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 536, DateTimeKind.Local).AddTicks(211));

            migrationBuilder.UpdateData(
                table: "CustomSettingTypes",
                keyColumn: "CustomSettingTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 536, DateTimeKind.Local).AddTicks(236));

            migrationBuilder.UpdateData(
                table: "CustomSettingTypes",
                keyColumn: "CustomSettingTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 536, DateTimeKind.Local).AddTicks(241));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 567, DateTimeKind.Local).AddTicks(3847));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 567, DateTimeKind.Local).AddTicks(4004));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 567, DateTimeKind.Local).AddTicks(4030));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 567, DateTimeKind.Local).AddTicks(4038));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 567, DateTimeKind.Local).AddTicks(4043));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 567, DateTimeKind.Local).AddTicks(4015));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 567, DateTimeKind.Local).AddTicks(4048));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 567, DateTimeKind.Local).AddTicks(4054));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 567, DateTimeKind.Local).AddTicks(4059));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 567, DateTimeKind.Local).AddTicks(4063));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 567, DateTimeKind.Local).AddTicks(4068));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 567, DateTimeKind.Local).AddTicks(4074));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 13,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 567, DateTimeKind.Local).AddTicks(4124));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 14,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 567, DateTimeKind.Local).AddTicks(4129));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 15,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 567, DateTimeKind.Local).AddTicks(4134));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 16,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 567, DateTimeKind.Local).AddTicks(4142));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 17,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 567, DateTimeKind.Local).AddTicks(4020));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 18,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 567, DateTimeKind.Local).AddTicks(3997));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 19,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 567, DateTimeKind.Local).AddTicks(4147));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 20,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 567, DateTimeKind.Local).AddTicks(4152));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 21,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 567, DateTimeKind.Local).AddTicks(4157));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 22,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 567, DateTimeKind.Local).AddTicks(4162));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 23,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 567, DateTimeKind.Local).AddTicks(4167));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 25,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 567, DateTimeKind.Local).AddTicks(4198));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 26,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 567, DateTimeKind.Local).AddTicks(4173));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 27,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 567, DateTimeKind.Local).AddTicks(4178));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 28,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 567, DateTimeKind.Local).AddTicks(4188));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 29,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 567, DateTimeKind.Local).AddTicks(4184));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 30,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 567, DateTimeKind.Local).AddTicks(4193));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 31,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 567, DateTimeKind.Local).AddTicks(4203));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 32,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 567, DateTimeKind.Local).AddTicks(4209));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 33,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 567, DateTimeKind.Local).AddTicks(4213));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 34,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 567, DateTimeKind.Local).AddTicks(4219));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 35,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 567, DateTimeKind.Local).AddTicks(4237));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 36,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 567, DateTimeKind.Local).AddTicks(4242));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 37,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 567, DateTimeKind.Local).AddTicks(4247));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 38,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 567, DateTimeKind.Local).AddTicks(4253));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 39,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 567, DateTimeKind.Local).AddTicks(4258));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 40,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 567, DateTimeKind.Local).AddTicks(4263));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 41,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 567, DateTimeKind.Local).AddTicks(4268));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 42,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 567, DateTimeKind.Local).AddTicks(4273));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 43,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 567, DateTimeKind.Local).AddTicks(4278));

            migrationBuilder.UpdateData(
                table: "DocumentFormats",
                keyColumn: "DocumentFormatID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 551, DateTimeKind.Local).AddTicks(5002));

            migrationBuilder.UpdateData(
                table: "DocumentFormats",
                keyColumn: "DocumentFormatID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 551, DateTimeKind.Local).AddTicks(5407));

            migrationBuilder.UpdateData(
                table: "DocumentFormats",
                keyColumn: "DocumentFormatID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 551, DateTimeKind.Local).AddTicks(5415));

            migrationBuilder.UpdateData(
                table: "DocumentFormats",
                keyColumn: "DocumentFormatID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 551, DateTimeKind.Local).AddTicks(5418));

            migrationBuilder.UpdateData(
                table: "DocumentFormats",
                keyColumn: "DocumentFormatID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 551, DateTimeKind.Local).AddTicks(5422));

            migrationBuilder.UpdateData(
                table: "DocumentFormats",
                keyColumn: "DocumentFormatID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 551, DateTimeKind.Local).AddTicks(5430));

            migrationBuilder.UpdateData(
                table: "DocumentTypes",
                keyColumn: "DocumentTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 554, DateTimeKind.Local).AddTicks(1504));

            migrationBuilder.UpdateData(
                table: "DocumentTypes",
                keyColumn: "DocumentTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 554, DateTimeKind.Local).AddTicks(2341));

            migrationBuilder.UpdateData(
                table: "DocumentTypes",
                keyColumn: "DocumentTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 554, DateTimeKind.Local).AddTicks(2363));

            migrationBuilder.UpdateData(
                table: "DocumentTypes",
                keyColumn: "DocumentTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 554, DateTimeKind.Local).AddTicks(2368));

            migrationBuilder.UpdateData(
                table: "EmailTypes",
                keyColumn: "EmailTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 563, DateTimeKind.Local).AddTicks(3312));

            migrationBuilder.UpdateData(
                table: "EmailTypes",
                keyColumn: "EmailTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 563, DateTimeKind.Local).AddTicks(3740));

            migrationBuilder.UpdateData(
                table: "EmailTypes",
                keyColumn: "EmailTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 563, DateTimeKind.Local).AddTicks(3746));

            migrationBuilder.UpdateData(
                table: "EmailTypes",
                keyColumn: "EmailTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 563, DateTimeKind.Local).AddTicks(3751));

            migrationBuilder.UpdateData(
                table: "FeatureFlags",
                keyColumn: "FeatureFlagID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 548, DateTimeKind.Local).AddTicks(6160));

            migrationBuilder.UpdateData(
                table: "FeatureFlags",
                keyColumn: "FeatureFlagID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 548, DateTimeKind.Local).AddTicks(6748));

            migrationBuilder.UpdateData(
                table: "FeatureFlags",
                keyColumn: "FeatureFlagID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 548, DateTimeKind.Local).AddTicks(6760));

            migrationBuilder.UpdateData(
                table: "Frequencies",
                keyColumn: "FrequencyID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 529, DateTimeKind.Local).AddTicks(6921));

            migrationBuilder.UpdateData(
                table: "Frequencies",
                keyColumn: "FrequencyID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 529, DateTimeKind.Local).AddTicks(7358));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "GenderID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 538, DateTimeKind.Local).AddTicks(3341));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "GenderID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 538, DateTimeKind.Local).AddTicks(3443));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 555, DateTimeKind.Local).AddTicks(9960));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 556, DateTimeKind.Local).AddTicks(637));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 556, DateTimeKind.Local).AddTicks(644));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 556, DateTimeKind.Local).AddTicks(654));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 556, DateTimeKind.Local).AddTicks(649));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 999,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 556, DateTimeKind.Local).AddTicks(675));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 9998,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 556, DateTimeKind.Local).AddTicks(663));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 557, DateTimeKind.Local).AddTicks(9828));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 557, DateTimeKind.Local).AddTicks(9982));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 557, DateTimeKind.Local).AddTicks(9987));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 557, DateTimeKind.Local).AddTicks(9991));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 557, DateTimeKind.Local).AddTicks(9996));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 558, DateTimeKind.Local).AddTicks(6));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 558, DateTimeKind.Local).AddTicks(38));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 558, DateTimeKind.Local).AddTicks(43));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 558, DateTimeKind.Local).AddTicks(46));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 558, DateTimeKind.Local).AddTicks(51));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 558, DateTimeKind.Local).AddTicks(57));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 558, DateTimeKind.Local).AddTicks(60));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 13,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 558, DateTimeKind.Local).AddTicks(63));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 14,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 558, DateTimeKind.Local).AddTicks(68));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 15,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 558, DateTimeKind.Local).AddTicks(71));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 16,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 558, DateTimeKind.Local).AddTicks(74));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 17,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 558, DateTimeKind.Local).AddTicks(77));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 18,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 558, DateTimeKind.Local).AddTicks(82));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 19,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 558, DateTimeKind.Local).AddTicks(85));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 20,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 558, DateTimeKind.Local).AddTicks(88));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 21,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 558, DateTimeKind.Local).AddTicks(91));

            migrationBuilder.UpdateData(
                table: "PaymentStatus",
                keyColumn: "PaymentStatusID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 515, DateTimeKind.Local).AddTicks(8108));

            migrationBuilder.UpdateData(
                table: "PaymentStatus",
                keyColumn: "PaymentStatusID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 515, DateTimeKind.Local).AddTicks(8563));

            migrationBuilder.UpdateData(
                table: "PaymentStatus",
                keyColumn: "PaymentStatusID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 515, DateTimeKind.Local).AddTicks(8572));

            migrationBuilder.UpdateData(
                table: "PaymentStatus",
                keyColumn: "PaymentStatusID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 515, DateTimeKind.Local).AddTicks(8576));

            migrationBuilder.UpdateData(
                table: "PaymentStatus",
                keyColumn: "PaymentStatusID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 515, DateTimeKind.Local).AddTicks(8580));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 511, DateTimeKind.Local).AddTicks(7059));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 511, DateTimeKind.Local).AddTicks(8081));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 511, DateTimeKind.Local).AddTicks(8093));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 511, DateTimeKind.Local).AddTicks(8099));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 511, DateTimeKind.Local).AddTicks(8105));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 511, DateTimeKind.Local).AddTicks(8118));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 511, DateTimeKind.Local).AddTicks(8124));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 511, DateTimeKind.Local).AddTicks(8131));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 511, DateTimeKind.Local).AddTicks(8137));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 511, DateTimeKind.Local).AddTicks(8148));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 511, DateTimeKind.Local).AddTicks(8154));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 511, DateTimeKind.Local).AddTicks(8161));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 13,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 511, DateTimeKind.Local).AddTicks(8167));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 14,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 511, DateTimeKind.Local).AddTicks(8173));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 15,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 511, DateTimeKind.Local).AddTicks(8180));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 16,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 511, DateTimeKind.Local).AddTicks(8187));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 17,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 511, DateTimeKind.Local).AddTicks(8193));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 18,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 511, DateTimeKind.Local).AddTicks(8201));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 19,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 511, DateTimeKind.Local).AddTicks(8207));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 20,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 511, DateTimeKind.Local).AddTicks(8212));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 21,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 511, DateTimeKind.Local).AddTicks(8217));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 22,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 511, DateTimeKind.Local).AddTicks(8222));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 23,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 511, DateTimeKind.Local).AddTicks(8229));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 24,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 511, DateTimeKind.Local).AddTicks(8235));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 25,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 511, DateTimeKind.Local).AddTicks(8242));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 26,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 511, DateTimeKind.Local).AddTicks(8247));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 27,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 511, DateTimeKind.Local).AddTicks(8253));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 28,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 511, DateTimeKind.Local).AddTicks(8274));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 29,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 511, DateTimeKind.Local).AddTicks(8280));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 30,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 511, DateTimeKind.Local).AddTicks(8285));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 31,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 511, DateTimeKind.Local).AddTicks(8291));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 32,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 511, DateTimeKind.Local).AddTicks(8297));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 33,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 511, DateTimeKind.Local).AddTicks(8302));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 34,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 511, DateTimeKind.Local).AddTicks(8310));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 35,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 511, DateTimeKind.Local).AddTicks(8316));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 36,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 511, DateTimeKind.Local).AddTicks(8322));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 37,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 511, DateTimeKind.Local).AddTicks(8328));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 38,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 511, DateTimeKind.Local).AddTicks(8334));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 39,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 511, DateTimeKind.Local).AddTicks(8339));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 40,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 511, DateTimeKind.Local).AddTicks(8345));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 41,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 511, DateTimeKind.Local).AddTicks(8350));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 42,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 511, DateTimeKind.Local).AddTicks(8355));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 43,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 511, DateTimeKind.Local).AddTicks(8360));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 44,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 511, DateTimeKind.Local).AddTicks(8365));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 45,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 511, DateTimeKind.Local).AddTicks(8370));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 46,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 511, DateTimeKind.Local).AddTicks(8375));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 47,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 511, DateTimeKind.Local).AddTicks(8381));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 48,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 511, DateTimeKind.Local).AddTicks(8386));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 49,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 511, DateTimeKind.Local).AddTicks(8391));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 50,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 511, DateTimeKind.Local).AddTicks(8397));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 51,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 511, DateTimeKind.Local).AddTicks(8403));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 52,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 511, DateTimeKind.Local).AddTicks(8408));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 53,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 511, DateTimeKind.Local).AddTicks(8413));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 54,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 511, DateTimeKind.Local).AddTicks(8418));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 55,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 511, DateTimeKind.Local).AddTicks(8423));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 56,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 511, DateTimeKind.Local).AddTicks(8429));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 57,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 511, DateTimeKind.Local).AddTicks(8434));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 58,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 511, DateTimeKind.Local).AddTicks(8439));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 59,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 511, DateTimeKind.Local).AddTicks(8444));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 60,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 511, DateTimeKind.Local).AddTicks(8449));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 61,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 511, DateTimeKind.Local).AddTicks(8454));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 62,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 511, DateTimeKind.Local).AddTicks(8460));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 63,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 511, DateTimeKind.Local).AddTicks(8465));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 64,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 511, DateTimeKind.Local).AddTicks(8470));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 65,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 511, DateTimeKind.Local).AddTicks(8474));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 66,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 511, DateTimeKind.Local).AddTicks(8492));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 67,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 511, DateTimeKind.Local).AddTicks(8497));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 68,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 511, DateTimeKind.Local).AddTicks(8502));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 69,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 511, DateTimeKind.Local).AddTicks(8507));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 70,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 511, DateTimeKind.Local).AddTicks(8512));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 71,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 511, DateTimeKind.Local).AddTicks(8517));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 72,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 511, DateTimeKind.Local).AddTicks(8522));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 73,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 511, DateTimeKind.Local).AddTicks(8527));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 74,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 511, DateTimeKind.Local).AddTicks(8532));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 75,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 511, DateTimeKind.Local).AddTicks(8537));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 76,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 511, DateTimeKind.Local).AddTicks(8542));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 77,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 511, DateTimeKind.Local).AddTicks(8547));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 78,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 511, DateTimeKind.Local).AddTicks(8552));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 79,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 511, DateTimeKind.Local).AddTicks(8557));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 80,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 511, DateTimeKind.Local).AddTicks(8562));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 81,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 511, DateTimeKind.Local).AddTicks(8567));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 82,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 511, DateTimeKind.Local).AddTicks(8573));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 83,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 511, DateTimeKind.Local).AddTicks(8579));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 84,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 511, DateTimeKind.Local).AddTicks(8584));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 85,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 511, DateTimeKind.Local).AddTicks(8589));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 86,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 511, DateTimeKind.Local).AddTicks(8594));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 87,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 511, DateTimeKind.Local).AddTicks(8599));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 88,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 511, DateTimeKind.Local).AddTicks(8604));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 89,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 511, DateTimeKind.Local).AddTicks(8609));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 90,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 511, DateTimeKind.Local).AddTicks(8614));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 91,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 511, DateTimeKind.Local).AddTicks(8619));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 92,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 511, DateTimeKind.Local).AddTicks(8625));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 93,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 511, DateTimeKind.Local).AddTicks(8630));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 94,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 511, DateTimeKind.Local).AddTicks(8636));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 95,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 511, DateTimeKind.Local).AddTicks(8641));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 96,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 511, DateTimeKind.Local).AddTicks(8646));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 97,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 511, DateTimeKind.Local).AddTicks(8651));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 98,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 511, DateTimeKind.Local).AddTicks(8656));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 99,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 511, DateTimeKind.Local).AddTicks(8662));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 100,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 511, DateTimeKind.Local).AddTicks(8666));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 101,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 511, DateTimeKind.Local).AddTicks(8671));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 102,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 511, DateTimeKind.Local).AddTicks(8676));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 103,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 511, DateTimeKind.Local).AddTicks(8681));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 104,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 511, DateTimeKind.Local).AddTicks(8687));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 105,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 511, DateTimeKind.Local).AddTicks(8693));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 106,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 511, DateTimeKind.Local).AddTicks(8698));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 107,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 511, DateTimeKind.Local).AddTicks(8703));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 108,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 511, DateTimeKind.Local).AddTicks(8709));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 109,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 511, DateTimeKind.Local).AddTicks(8714));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 110,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 511, DateTimeKind.Local).AddTicks(8719));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 111,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 511, DateTimeKind.Local).AddTicks(8732));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 112,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 511, DateTimeKind.Local).AddTicks(8738));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 113,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 511, DateTimeKind.Local).AddTicks(8743));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 114,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 511, DateTimeKind.Local).AddTicks(8748));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 115,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 511, DateTimeKind.Local).AddTicks(8753));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 116,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 511, DateTimeKind.Local).AddTicks(8758));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 117,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 511, DateTimeKind.Local).AddTicks(8762));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 118,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 511, DateTimeKind.Local).AddTicks(8767));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 119,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 511, DateTimeKind.Local).AddTicks(8773));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 120,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 511, DateTimeKind.Local).AddTicks(8779));

            migrationBuilder.UpdateData(
                table: "PriorityRanks",
                keyColumn: "PriorityRankID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 542, DateTimeKind.Local).AddTicks(4327));

            migrationBuilder.UpdateData(
                table: "PriorityRanks",
                keyColumn: "PriorityRankID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 542, DateTimeKind.Local).AddTicks(4428));

            migrationBuilder.UpdateData(
                table: "PriorityRanks",
                keyColumn: "PriorityRankID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 542, DateTimeKind.Local).AddTicks(4434));

            migrationBuilder.UpdateData(
                table: "PriorityRanks",
                keyColumn: "PriorityRankID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 542, DateTimeKind.Local).AddTicks(4438));

            migrationBuilder.UpdateData(
                table: "RelationshipTypes",
                keyColumn: "RelationshipTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 534, DateTimeKind.Local).AddTicks(9813));

            migrationBuilder.UpdateData(
                table: "RelationshipTypes",
                keyColumn: "RelationshipTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 534, DateTimeKind.Local).AddTicks(9950));

            migrationBuilder.UpdateData(
                table: "RelationshipTypes",
                keyColumn: "RelationshipTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 534, DateTimeKind.Local).AddTicks(9954));

            migrationBuilder.UpdateData(
                table: "RelationshipTypes",
                keyColumn: "RelationshipTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 534, DateTimeKind.Local).AddTicks(9956));

            migrationBuilder.UpdateData(
                table: "RelationshipTypes",
                keyColumn: "RelationshipTypeID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 534, DateTimeKind.Local).AddTicks(9959));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 567, DateTimeKind.Local).AddTicks(9691));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 567, DateTimeKind.Local).AddTicks(9771));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 567, DateTimeKind.Local).AddTicks(9774));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 567, DateTimeKind.Local).AddTicks(9775));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 567, DateTimeKind.Local).AddTicks(9777));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 567, DateTimeKind.Local).AddTicks(9782));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 567, DateTimeKind.Local).AddTicks(9784));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 567, DateTimeKind.Local).AddTicks(9785));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 567, DateTimeKind.Local).AddTicks(9787));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 567, DateTimeKind.Local).AddTicks(9789));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 567, DateTimeKind.Local).AddTicks(9791));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 567, DateTimeKind.Local).AddTicks(9793));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 13,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 567, DateTimeKind.Local).AddTicks(9794));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 14,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 567, DateTimeKind.Local).AddTicks(9796));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 15,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 567, DateTimeKind.Local).AddTicks(9798));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 16,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 567, DateTimeKind.Local).AddTicks(9799));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 17,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 567, DateTimeKind.Local).AddTicks(9801));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 18,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 567, DateTimeKind.Local).AddTicks(9804));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 19,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 567, DateTimeKind.Local).AddTicks(9806));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 20,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 567, DateTimeKind.Local).AddTicks(9808));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 21,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 567, DateTimeKind.Local).AddTicks(9810));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 512, DateTimeKind.Local).AddTicks(6610));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 512, DateTimeKind.Local).AddTicks(6724));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 512, DateTimeKind.Local).AddTicks(6728));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 512, DateTimeKind.Local).AddTicks(6731));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 512, DateTimeKind.Local).AddTicks(6733));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 512, DateTimeKind.Local).AddTicks(6739));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 512, DateTimeKind.Local).AddTicks(6741));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 512, DateTimeKind.Local).AddTicks(6744));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 512, DateTimeKind.Local).AddTicks(6746));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 512, DateTimeKind.Local).AddTicks(6749));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 512, DateTimeKind.Local).AddTicks(6752));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 512, DateTimeKind.Local).AddTicks(6754));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 13,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 512, DateTimeKind.Local).AddTicks(6756));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 14,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 512, DateTimeKind.Local).AddTicks(6758));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 15,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 512, DateTimeKind.Local).AddTicks(6760));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 16,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 512, DateTimeKind.Local).AddTicks(6762));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 17,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 512, DateTimeKind.Local).AddTicks(6764));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 18,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 512, DateTimeKind.Local).AddTicks(6768));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 19,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 512, DateTimeKind.Local).AddTicks(6770));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 20,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 512, DateTimeKind.Local).AddTicks(6772));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 21,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 512, DateTimeKind.Local).AddTicks(6774));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 22,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 512, DateTimeKind.Local).AddTicks(6776));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 23,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 512, DateTimeKind.Local).AddTicks(6778));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 24,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 512, DateTimeKind.Local).AddTicks(6781));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 25,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 512, DateTimeKind.Local).AddTicks(6783));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 26,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 512, DateTimeKind.Local).AddTicks(6785));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 27,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 512, DateTimeKind.Local).AddTicks(6787));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 28,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 512, DateTimeKind.Local).AddTicks(6789));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 29,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 512, DateTimeKind.Local).AddTicks(6791));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 30,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 512, DateTimeKind.Local).AddTicks(6793));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 31,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 512, DateTimeKind.Local).AddTicks(6796));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 32,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 512, DateTimeKind.Local).AddTicks(6798));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 33,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 512, DateTimeKind.Local).AddTicks(6800));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 34,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 512, DateTimeKind.Local).AddTicks(6804));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 35,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 512, DateTimeKind.Local).AddTicks(6806));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 36,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 512, DateTimeKind.Local).AddTicks(6808));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 37,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 512, DateTimeKind.Local).AddTicks(6810));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 38,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 512, DateTimeKind.Local).AddTicks(6812));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 39,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 512, DateTimeKind.Local).AddTicks(6814));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 40,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 512, DateTimeKind.Local).AddTicks(6816));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 41,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 512, DateTimeKind.Local).AddTicks(6819));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 42,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 512, DateTimeKind.Local).AddTicks(6821));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 43,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 512, DateTimeKind.Local).AddTicks(6823));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 44,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 512, DateTimeKind.Local).AddTicks(6825));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 45,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 512, DateTimeKind.Local).AddTicks(6827));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 46,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 512, DateTimeKind.Local).AddTicks(6829));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 47,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 512, DateTimeKind.Local).AddTicks(6831));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 48,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 512, DateTimeKind.Local).AddTicks(6833));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 49,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 512, DateTimeKind.Local).AddTicks(6835));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 50,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 512, DateTimeKind.Local).AddTicks(6838));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 51,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 512, DateTimeKind.Local).AddTicks(6840));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 52,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 512, DateTimeKind.Local).AddTicks(6842));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 53,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 512, DateTimeKind.Local).AddTicks(6844));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 54,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 512, DateTimeKind.Local).AddTicks(6846));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 55,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 512, DateTimeKind.Local).AddTicks(6848));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 56,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 512, DateTimeKind.Local).AddTicks(6850));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 57,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 512, DateTimeKind.Local).AddTicks(6853));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 58,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 512, DateTimeKind.Local).AddTicks(6855));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 59,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 512, DateTimeKind.Local).AddTicks(6857));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 60,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 512, DateTimeKind.Local).AddTicks(6859));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 61,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 512, DateTimeKind.Local).AddTicks(6861));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 62,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 512, DateTimeKind.Local).AddTicks(6863));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 63,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 512, DateTimeKind.Local).AddTicks(6865));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 64,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 512, DateTimeKind.Local).AddTicks(6867));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 65,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 512, DateTimeKind.Local).AddTicks(6869));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 66,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 512, DateTimeKind.Local).AddTicks(6874));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 67,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 512, DateTimeKind.Local).AddTicks(6876));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 68,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 512, DateTimeKind.Local).AddTicks(6878));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 69,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 512, DateTimeKind.Local).AddTicks(6880));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 70,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 512, DateTimeKind.Local).AddTicks(6883));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 71,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 512, DateTimeKind.Local).AddTicks(6885));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 72,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 512, DateTimeKind.Local).AddTicks(6887));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 73,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 512, DateTimeKind.Local).AddTicks(6889));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 74,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 512, DateTimeKind.Local).AddTicks(6891));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 75,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 512, DateTimeKind.Local).AddTicks(6893));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 76,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 512, DateTimeKind.Local).AddTicks(6895));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 77,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 512, DateTimeKind.Local).AddTicks(6897));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 78,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 512, DateTimeKind.Local).AddTicks(6900));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 79,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 512, DateTimeKind.Local).AddTicks(6902));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 80,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 512, DateTimeKind.Local).AddTicks(6904));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 81,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 512, DateTimeKind.Local).AddTicks(6906));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 82,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 512, DateTimeKind.Local).AddTicks(6908));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 83,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 512, DateTimeKind.Local).AddTicks(6910));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 84,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 512, DateTimeKind.Local).AddTicks(6912));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 85,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 512, DateTimeKind.Local).AddTicks(6914));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 86,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 512, DateTimeKind.Local).AddTicks(6930));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 87,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 512, DateTimeKind.Local).AddTicks(6932));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 88,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 512, DateTimeKind.Local).AddTicks(6935));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 89,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 512, DateTimeKind.Local).AddTicks(6937));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 90,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 512, DateTimeKind.Local).AddTicks(6939));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 91,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 512, DateTimeKind.Local).AddTicks(6941));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 92,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 512, DateTimeKind.Local).AddTicks(6943));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 93,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 512, DateTimeKind.Local).AddTicks(6945));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 94,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 512, DateTimeKind.Local).AddTicks(6947));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 95,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 512, DateTimeKind.Local).AddTicks(6949));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 96,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 512, DateTimeKind.Local).AddTicks(6952));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 97,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 512, DateTimeKind.Local).AddTicks(6954));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 98,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 512, DateTimeKind.Local).AddTicks(6956));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 99,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 512, DateTimeKind.Local).AddTicks(6958));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 100,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 512, DateTimeKind.Local).AddTicks(6960));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 101,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 512, DateTimeKind.Local).AddTicks(6962));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 102,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 512, DateTimeKind.Local).AddTicks(6964));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 103,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 512, DateTimeKind.Local).AddTicks(6967));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 104,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 512, DateTimeKind.Local).AddTicks(6969));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 105,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 512, DateTimeKind.Local).AddTicks(6971));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 106,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 512, DateTimeKind.Local).AddTicks(6973));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 107,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 512, DateTimeKind.Local).AddTicks(6975));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 108,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 512, DateTimeKind.Local).AddTicks(6977));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 109,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 512, DateTimeKind.Local).AddTicks(6979));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 110,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 512, DateTimeKind.Local).AddTicks(6981));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 111,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 512, DateTimeKind.Local).AddTicks(6983));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 112,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 512, DateTimeKind.Local).AddTicks(6986));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 113,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 512, DateTimeKind.Local).AddTicks(6988));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 114,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 512, DateTimeKind.Local).AddTicks(6990));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 115,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 512, DateTimeKind.Local).AddTicks(6992));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 116,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 512, DateTimeKind.Local).AddTicks(6994));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 117,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 512, DateTimeKind.Local).AddTicks(6996));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 118,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 512, DateTimeKind.Local).AddTicks(6998));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 119,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 512, DateTimeKind.Local).AddTicks(7001));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 120,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 512, DateTimeKind.Local).AddTicks(7003));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 505, DateTimeKind.Local).AddTicks(1002));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 506, DateTimeKind.Local).AddTicks(8405));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 506, DateTimeKind.Local).AddTicks(8490));

            migrationBuilder.UpdateData(
                table: "SystemVariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 537, DateTimeKind.Local).AddTicks(4389));

            migrationBuilder.UpdateData(
                table: "SystemVariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 537, DateTimeKind.Local).AddTicks(4541));

            migrationBuilder.UpdateData(
                table: "SystemVariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 537, DateTimeKind.Local).AddTicks(4537));

            migrationBuilder.UpdateData(
                table: "SystemVariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 537, DateTimeKind.Local).AddTicks(4532));

            migrationBuilder.UpdateData(
                table: "SystemVariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 537, DateTimeKind.Local).AddTicks(4524));

            migrationBuilder.UpdateData(
                table: "SystemVariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 537, DateTimeKind.Local).AddTicks(4551));

            migrationBuilder.UpdateData(
                table: "SystemVariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 537, DateTimeKind.Local).AddTicks(4561));

            migrationBuilder.UpdateData(
                table: "SystemVariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 537, DateTimeKind.Local).AddTicks(4566));

            migrationBuilder.UpdateData(
                table: "SystemVariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 537, DateTimeKind.Local).AddTicks(4570));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 519, DateTimeKind.Local).AddTicks(6625));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 519, DateTimeKind.Local).AddTicks(7477));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 519, DateTimeKind.Local).AddTicks(7598));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 519, DateTimeKind.Local).AddTicks(7700));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 519, DateTimeKind.Local).AddTicks(7799));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 519, DateTimeKind.Local).AddTicks(7895));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 519, DateTimeKind.Local).AddTicks(7976));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 519, DateTimeKind.Local).AddTicks(8054));

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumns: new[] { "UserID", "RoleID" },
                keyValues: new object[] { 1, 1 },
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 554, DateTimeKind.Local).AddTicks(6735));

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumns: new[] { "UserID", "RoleID" },
                keyValues: new object[] { 2, 3 },
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 554, DateTimeKind.Local).AddTicks(6807));

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "UserTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 532, DateTimeKind.Local).AddTicks(8279));

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "UserTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 532, DateTimeKind.Local).AddTicks(9269));

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "UserTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 532, DateTimeKind.Local).AddTicks(9280));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 543, DateTimeKind.Local).AddTicks(1958));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 545, DateTimeKind.Local).AddTicks(7017));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 8, 17, 47, 46, 545, DateTimeKind.Local).AddTicks(7983));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DeductionPercentage",
                table: "ClientDeductions");

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
    }
}
