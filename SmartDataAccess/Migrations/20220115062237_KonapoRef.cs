using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SmartDataAccess.Migrations
{
    public partial class KonapoRef : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "KonapoRef",
                table: "KonapoFunds",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "BankAccountTypes",
                keyColumn: "BankAccountTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 129, DateTimeKind.Local).AddTicks(5877));

            migrationBuilder.UpdateData(
                table: "BankAccountTypes",
                keyColumn: "BankAccountTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 129, DateTimeKind.Local).AddTicks(6320));

            migrationBuilder.UpdateData(
                table: "BankAccountTypes",
                keyColumn: "BankAccountTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 129, DateTimeKind.Local).AddTicks(6332));

            migrationBuilder.UpdateData(
                table: "BankAccountTypes",
                keyColumn: "BankAccountTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 129, DateTimeKind.Local).AddTicks(6337));

            migrationBuilder.UpdateData(
                table: "ClientAccountTypes",
                keyColumn: "ID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 168, DateTimeKind.Local).AddTicks(5830));

            migrationBuilder.UpdateData(
                table: "ClientAccountTypes",
                keyColumn: "ID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 168, DateTimeKind.Local).AddTicks(6069));

            migrationBuilder.UpdateData(
                table: "ClientGroups",
                keyColumn: "ClientGroupID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 174, DateTimeKind.Local).AddTicks(63));

            migrationBuilder.UpdateData(
                table: "ClientGroups",
                keyColumn: "ClientGroupID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 174, DateTimeKind.Local).AddTicks(419));

            migrationBuilder.UpdateData(
                table: "ContactTypes",
                keyColumn: "ContactTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 137, DateTimeKind.Local).AddTicks(3459));

            migrationBuilder.UpdateData(
                table: "ContactTypes",
                keyColumn: "ContactTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 137, DateTimeKind.Local).AddTicks(3453));

            migrationBuilder.UpdateData(
                table: "ContactTypes",
                keyColumn: "ContactTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 137, DateTimeKind.Local).AddTicks(3445));

            migrationBuilder.UpdateData(
                table: "ContactTypes",
                keyColumn: "ContactTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 137, DateTimeKind.Local).AddTicks(3360));

            migrationBuilder.UpdateData(
                table: "ContactTypes",
                keyColumn: "ContactTypeID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 137, DateTimeKind.Local).AddTicks(3465));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 142, DateTimeKind.Local).AddTicks(2180));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 142, DateTimeKind.Local).AddTicks(2376));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 142, DateTimeKind.Local).AddTicks(2385));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 142, DateTimeKind.Local).AddTicks(2393));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 142, DateTimeKind.Local).AddTicks(2397));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 142, DateTimeKind.Local).AddTicks(2404));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 142, DateTimeKind.Local).AddTicks(2408));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 142, DateTimeKind.Local).AddTicks(2413));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 142, DateTimeKind.Local).AddTicks(2417));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 142, DateTimeKind.Local).AddTicks(2422));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 142, DateTimeKind.Local).AddTicks(2427));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 142, DateTimeKind.Local).AddTicks(2430));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 13,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 142, DateTimeKind.Local).AddTicks(2434));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 14,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 142, DateTimeKind.Local).AddTicks(2438));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 15,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 142, DateTimeKind.Local).AddTicks(2443));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 16,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 142, DateTimeKind.Local).AddTicks(2447));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 17,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 142, DateTimeKind.Local).AddTicks(2485));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 18,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 142, DateTimeKind.Local).AddTicks(2491));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 19,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 142, DateTimeKind.Local).AddTicks(2496));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 20,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 142, DateTimeKind.Local).AddTicks(2500));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 21,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 142, DateTimeKind.Local).AddTicks(2503));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 22,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 142, DateTimeKind.Local).AddTicks(2507));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 23,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 142, DateTimeKind.Local).AddTicks(2511));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 24,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 142, DateTimeKind.Local).AddTicks(2516));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 25,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 142, DateTimeKind.Local).AddTicks(2519));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 26,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 142, DateTimeKind.Local).AddTicks(2523));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 27,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 142, DateTimeKind.Local).AddTicks(2528));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 28,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 142, DateTimeKind.Local).AddTicks(2532));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 29,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 142, DateTimeKind.Local).AddTicks(2536));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 30,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 142, DateTimeKind.Local).AddTicks(2541));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 31,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 142, DateTimeKind.Local).AddTicks(2544));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 32,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 142, DateTimeKind.Local).AddTicks(2548));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 33,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 142, DateTimeKind.Local).AddTicks(2553));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 34,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 142, DateTimeKind.Local).AddTicks(2557));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 35,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 142, DateTimeKind.Local).AddTicks(2561));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 36,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 142, DateTimeKind.Local).AddTicks(2565));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 37,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 142, DateTimeKind.Local).AddTicks(2569));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 38,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 142, DateTimeKind.Local).AddTicks(2572));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 39,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 142, DateTimeKind.Local).AddTicks(2577));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 40,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 142, DateTimeKind.Local).AddTicks(2581));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 41,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 142, DateTimeKind.Local).AddTicks(2586));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 42,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 142, DateTimeKind.Local).AddTicks(2590));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 43,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 142, DateTimeKind.Local).AddTicks(2594));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 44,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 142, DateTimeKind.Local).AddTicks(2598));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 45,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 142, DateTimeKind.Local).AddTicks(2601));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 46,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 142, DateTimeKind.Local).AddTicks(2605));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 47,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 142, DateTimeKind.Local).AddTicks(2610));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 48,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 142, DateTimeKind.Local).AddTicks(2615));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 49,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 142, DateTimeKind.Local).AddTicks(2620));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 50,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 142, DateTimeKind.Local).AddTicks(2624));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 51,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 142, DateTimeKind.Local).AddTicks(2628));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 52,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 142, DateTimeKind.Local).AddTicks(2632));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 53,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 142, DateTimeKind.Local).AddTicks(2635));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 54,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 142, DateTimeKind.Local).AddTicks(2639));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 55,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 142, DateTimeKind.Local).AddTicks(2644));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 56,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 142, DateTimeKind.Local).AddTicks(2648));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 57,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 142, DateTimeKind.Local).AddTicks(2651));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 58,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 142, DateTimeKind.Local).AddTicks(2655));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 59,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 142, DateTimeKind.Local).AddTicks(2660));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 60,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 142, DateTimeKind.Local).AddTicks(2664));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 61,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 142, DateTimeKind.Local).AddTicks(2668));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 62,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 142, DateTimeKind.Local).AddTicks(2672));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 63,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 142, DateTimeKind.Local).AddTicks(2676));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 64,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 142, DateTimeKind.Local).AddTicks(2680));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 65,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 142, DateTimeKind.Local).AddTicks(2684));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 66,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 142, DateTimeKind.Local).AddTicks(2689));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 67,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 142, DateTimeKind.Local).AddTicks(2693));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 68,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 142, DateTimeKind.Local).AddTicks(2724));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 69,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 142, DateTimeKind.Local).AddTicks(2729));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 70,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 142, DateTimeKind.Local).AddTicks(2732));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 71,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 142, DateTimeKind.Local).AddTicks(2736));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 72,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 142, DateTimeKind.Local).AddTicks(2740));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 73,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 142, DateTimeKind.Local).AddTicks(2745));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 74,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 142, DateTimeKind.Local).AddTicks(2749));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 75,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 142, DateTimeKind.Local).AddTicks(2753));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 76,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 142, DateTimeKind.Local).AddTicks(2757));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 77,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 142, DateTimeKind.Local).AddTicks(2761));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 78,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 142, DateTimeKind.Local).AddTicks(2764));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 79,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 142, DateTimeKind.Local).AddTicks(2768));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 80,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 142, DateTimeKind.Local).AddTicks(2772));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 81,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 142, DateTimeKind.Local).AddTicks(2776));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 82,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 142, DateTimeKind.Local).AddTicks(2780));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 83,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 142, DateTimeKind.Local).AddTicks(2784));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 84,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 142, DateTimeKind.Local).AddTicks(2788));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 85,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 142, DateTimeKind.Local).AddTicks(2791));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 86,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 142, DateTimeKind.Local).AddTicks(2795));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 87,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 142, DateTimeKind.Local).AddTicks(2800));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 88,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 142, DateTimeKind.Local).AddTicks(2803));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 89,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 142, DateTimeKind.Local).AddTicks(2807));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 90,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 142, DateTimeKind.Local).AddTicks(2811));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 91,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 142, DateTimeKind.Local).AddTicks(2815));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 92,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 142, DateTimeKind.Local).AddTicks(2819));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 93,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 142, DateTimeKind.Local).AddTicks(2823));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 94,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 142, DateTimeKind.Local).AddTicks(2827));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 95,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 142, DateTimeKind.Local).AddTicks(2831));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 96,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 142, DateTimeKind.Local).AddTicks(2836));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 97,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 142, DateTimeKind.Local).AddTicks(2839));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 98,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 142, DateTimeKind.Local).AddTicks(2843));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 99,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 142, DateTimeKind.Local).AddTicks(2847));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 100,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 142, DateTimeKind.Local).AddTicks(2851));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 101,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 142, DateTimeKind.Local).AddTicks(2855));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 102,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 142, DateTimeKind.Local).AddTicks(2859));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 103,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 142, DateTimeKind.Local).AddTicks(2863));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 104,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 142, DateTimeKind.Local).AddTicks(2866));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 105,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 142, DateTimeKind.Local).AddTicks(2870));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 106,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 142, DateTimeKind.Local).AddTicks(2874));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 107,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 142, DateTimeKind.Local).AddTicks(2878));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 108,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 142, DateTimeKind.Local).AddTicks(2881));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 109,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 142, DateTimeKind.Local).AddTicks(2885));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 110,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 142, DateTimeKind.Local).AddTicks(2889));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 111,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 142, DateTimeKind.Local).AddTicks(2893));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 112,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 142, DateTimeKind.Local).AddTicks(2896));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 113,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 142, DateTimeKind.Local).AddTicks(2900));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 114,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 142, DateTimeKind.Local).AddTicks(2904));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 115,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 142, DateTimeKind.Local).AddTicks(2909));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 116,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 142, DateTimeKind.Local).AddTicks(2912));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 117,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 142, DateTimeKind.Local).AddTicks(2916));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 118,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 142, DateTimeKind.Local).AddTicks(2919));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 119,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 142, DateTimeKind.Local).AddTicks(2923));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 120,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 142, DateTimeKind.Local).AddTicks(2927));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 121,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 142, DateTimeKind.Local).AddTicks(2931));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 122,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 142, DateTimeKind.Local).AddTicks(2935));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 123,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 142, DateTimeKind.Local).AddTicks(2938));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 124,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 142, DateTimeKind.Local).AddTicks(2942));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 125,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 142, DateTimeKind.Local).AddTicks(2946));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 126,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 142, DateTimeKind.Local).AddTicks(2950));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 127,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 142, DateTimeKind.Local).AddTicks(2953));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 128,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 142, DateTimeKind.Local).AddTicks(2957));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 129,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 142, DateTimeKind.Local).AddTicks(2961));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 130,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 142, DateTimeKind.Local).AddTicks(2991));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 131,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 142, DateTimeKind.Local).AddTicks(2995));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 132,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 142, DateTimeKind.Local).AddTicks(3000));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 133,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 142, DateTimeKind.Local).AddTicks(3004));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 134,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 142, DateTimeKind.Local).AddTicks(3008));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 135,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 142, DateTimeKind.Local).AddTicks(3011));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 136,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 142, DateTimeKind.Local).AddTicks(3015));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 137,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 142, DateTimeKind.Local).AddTicks(3019));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 138,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 142, DateTimeKind.Local).AddTicks(3024));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 139,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 142, DateTimeKind.Local).AddTicks(3028));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 140,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 142, DateTimeKind.Local).AddTicks(3032));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 141,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 142, DateTimeKind.Local).AddTicks(3036));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 142,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 142, DateTimeKind.Local).AddTicks(3040));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 143,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 142, DateTimeKind.Local).AddTicks(3044));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 144,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 142, DateTimeKind.Local).AddTicks(3047));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 145,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 142, DateTimeKind.Local).AddTicks(3052));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 146,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 142, DateTimeKind.Local).AddTicks(3056));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 147,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 142, DateTimeKind.Local).AddTicks(3060));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 148,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 142, DateTimeKind.Local).AddTicks(3064));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 149,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 142, DateTimeKind.Local).AddTicks(3068));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 150,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 142, DateTimeKind.Local).AddTicks(3073));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 151,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 142, DateTimeKind.Local).AddTicks(3077));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 152,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 142, DateTimeKind.Local).AddTicks(3081));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 153,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 142, DateTimeKind.Local).AddTicks(3085));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 154,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 142, DateTimeKind.Local).AddTicks(3088));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 155,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 142, DateTimeKind.Local).AddTicks(3093));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 156,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 142, DateTimeKind.Local).AddTicks(3097));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 157,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 142, DateTimeKind.Local).AddTicks(3100));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 158,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 142, DateTimeKind.Local).AddTicks(3104));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 159,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 142, DateTimeKind.Local).AddTicks(3108));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 160,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 142, DateTimeKind.Local).AddTicks(3112));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 161,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 142, DateTimeKind.Local).AddTicks(3117));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 162,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 142, DateTimeKind.Local).AddTicks(3121));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 163,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 142, DateTimeKind.Local).AddTicks(3124));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 164,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 142, DateTimeKind.Local).AddTicks(3128));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 165,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 142, DateTimeKind.Local).AddTicks(3132));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 166,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 142, DateTimeKind.Local).AddTicks(3136));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 167,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 142, DateTimeKind.Local).AddTicks(3141));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 168,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 142, DateTimeKind.Local).AddTicks(3145));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 169,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 142, DateTimeKind.Local).AddTicks(3148));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 170,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 142, DateTimeKind.Local).AddTicks(3152));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 171,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 142, DateTimeKind.Local).AddTicks(3156));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 172,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 142, DateTimeKind.Local).AddTicks(3160));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 173,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 142, DateTimeKind.Local).AddTicks(3164));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 174,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 142, DateTimeKind.Local).AddTicks(3169));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 175,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 142, DateTimeKind.Local).AddTicks(3173));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 176,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 142, DateTimeKind.Local).AddTicks(3178));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 177,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 142, DateTimeKind.Local).AddTicks(3184));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 178,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 142, DateTimeKind.Local).AddTicks(3188));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 179,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 142, DateTimeKind.Local).AddTicks(3192));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 180,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 142, DateTimeKind.Local).AddTicks(3197));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 181,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 142, DateTimeKind.Local).AddTicks(3202));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 182,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 142, DateTimeKind.Local).AddTicks(3206));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 183,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 142, DateTimeKind.Local).AddTicks(3209));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 184,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 142, DateTimeKind.Local).AddTicks(3213));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 185,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 142, DateTimeKind.Local).AddTicks(3217));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 186,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 142, DateTimeKind.Local).AddTicks(3221));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 187,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 142, DateTimeKind.Local).AddTicks(3225));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 188,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 142, DateTimeKind.Local).AddTicks(3229));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 189,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 142, DateTimeKind.Local).AddTicks(3233));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 190,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 142, DateTimeKind.Local).AddTicks(3236));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 191,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 142, DateTimeKind.Local).AddTicks(3291));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 192,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 142, DateTimeKind.Local).AddTicks(3295));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 193,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 142, DateTimeKind.Local).AddTicks(3300));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 194,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 142, DateTimeKind.Local).AddTicks(3303));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 195,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 142, DateTimeKind.Local).AddTicks(3307));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 196,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 142, DateTimeKind.Local).AddTicks(3312));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 197,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 142, DateTimeKind.Local).AddTicks(3316));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 198,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 142, DateTimeKind.Local).AddTicks(3320));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 199,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 142, DateTimeKind.Local).AddTicks(3324));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 200,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 142, DateTimeKind.Local).AddTicks(3328));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 201,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 142, DateTimeKind.Local).AddTicks(3332));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 202,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 142, DateTimeKind.Local).AddTicks(3336));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 203,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 142, DateTimeKind.Local).AddTicks(3339));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 204,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 142, DateTimeKind.Local).AddTicks(3343));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 205,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 142, DateTimeKind.Local).AddTicks(3348));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 206,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 142, DateTimeKind.Local).AddTicks(3352));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 207,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 142, DateTimeKind.Local).AddTicks(3355));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 208,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 142, DateTimeKind.Local).AddTicks(3359));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 209,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 142, DateTimeKind.Local).AddTicks(3363));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 210,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 142, DateTimeKind.Local).AddTicks(3368));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 211,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 142, DateTimeKind.Local).AddTicks(3372));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 212,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 142, DateTimeKind.Local).AddTicks(3376));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 213,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 142, DateTimeKind.Local).AddTicks(3379));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 214,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 142, DateTimeKind.Local).AddTicks(3384));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 215,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 142, DateTimeKind.Local).AddTicks(3388));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 216,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 142, DateTimeKind.Local).AddTicks(3393));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 217,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 142, DateTimeKind.Local).AddTicks(3396));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 218,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 142, DateTimeKind.Local).AddTicks(3400));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 219,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 142, DateTimeKind.Local).AddTicks(3404));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 220,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 142, DateTimeKind.Local).AddTicks(3407));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 221,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 142, DateTimeKind.Local).AddTicks(3411));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 222,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 142, DateTimeKind.Local).AddTicks(3415));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 223,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 142, DateTimeKind.Local).AddTicks(3419));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 224,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 142, DateTimeKind.Local).AddTicks(3423));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 225,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 142, DateTimeKind.Local).AddTicks(3428));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 226,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 142, DateTimeKind.Local).AddTicks(3431));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 227,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 142, DateTimeKind.Local).AddTicks(3435));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 228,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 142, DateTimeKind.Local).AddTicks(3438));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 131, DateTimeKind.Local).AddTicks(7294));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 131, DateTimeKind.Local).AddTicks(7593));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 131, DateTimeKind.Local).AddTicks(7606));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 131, DateTimeKind.Local).AddTicks(7612));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 131, DateTimeKind.Local).AddTicks(7619));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 131, DateTimeKind.Local).AddTicks(7629));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 131, DateTimeKind.Local).AddTicks(7634));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 131, DateTimeKind.Local).AddTicks(7640));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 131, DateTimeKind.Local).AddTicks(7647));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 131, DateTimeKind.Local).AddTicks(7654));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 131, DateTimeKind.Local).AddTicks(7661));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 131, DateTimeKind.Local).AddTicks(7667));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 13,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 131, DateTimeKind.Local).AddTicks(7673));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 14,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 131, DateTimeKind.Local).AddTicks(7678));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 15,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 131, DateTimeKind.Local).AddTicks(7684));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 16,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 131, DateTimeKind.Local).AddTicks(7691));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 17,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 131, DateTimeKind.Local).AddTicks(7697));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 18,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 131, DateTimeKind.Local).AddTicks(7705));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 19,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 131, DateTimeKind.Local).AddTicks(7711));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 20,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 131, DateTimeKind.Local).AddTicks(7717));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 21,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 131, DateTimeKind.Local).AddTicks(7723));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 22,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 131, DateTimeKind.Local).AddTicks(7729));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 23,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 131, DateTimeKind.Local).AddTicks(7734));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 24,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 131, DateTimeKind.Local).AddTicks(7740));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 25,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 131, DateTimeKind.Local).AddTicks(7746));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 26,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 131, DateTimeKind.Local).AddTicks(7753));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 27,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 131, DateTimeKind.Local).AddTicks(7758));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 28,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 131, DateTimeKind.Local).AddTicks(7764));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 29,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 131, DateTimeKind.Local).AddTicks(7770));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 30,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 131, DateTimeKind.Local).AddTicks(7776));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 31,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 131, DateTimeKind.Local).AddTicks(7782));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 32,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 131, DateTimeKind.Local).AddTicks(7787));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 33,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 131, DateTimeKind.Local).AddTicks(7793));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 34,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 131, DateTimeKind.Local).AddTicks(7801));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 35,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 131, DateTimeKind.Local).AddTicks(7807));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 36,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 131, DateTimeKind.Local).AddTicks(7813));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 37,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 131, DateTimeKind.Local).AddTicks(7818));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 38,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 131, DateTimeKind.Local).AddTicks(7824));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 39,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 131, DateTimeKind.Local).AddTicks(7830));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 40,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 131, DateTimeKind.Local).AddTicks(7835));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 41,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 131, DateTimeKind.Local).AddTicks(7841));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 42,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 131, DateTimeKind.Local).AddTicks(7847));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 43,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 131, DateTimeKind.Local).AddTicks(7922));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 44,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 131, DateTimeKind.Local).AddTicks(7928));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 45,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 131, DateTimeKind.Local).AddTicks(7933));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 46,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 131, DateTimeKind.Local).AddTicks(7938));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 47,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 131, DateTimeKind.Local).AddTicks(7943));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 48,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 131, DateTimeKind.Local).AddTicks(7948));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 49,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 131, DateTimeKind.Local).AddTicks(7952));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 50,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 131, DateTimeKind.Local).AddTicks(7957));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 51,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 131, DateTimeKind.Local).AddTicks(7963));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 52,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 131, DateTimeKind.Local).AddTicks(7968));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 53,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 131, DateTimeKind.Local).AddTicks(7973));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 54,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 131, DateTimeKind.Local).AddTicks(7977));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 55,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 131, DateTimeKind.Local).AddTicks(7982));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 56,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 131, DateTimeKind.Local).AddTicks(7987));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 57,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 131, DateTimeKind.Local).AddTicks(7992));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 58,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 131, DateTimeKind.Local).AddTicks(7997));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 59,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 131, DateTimeKind.Local).AddTicks(8002));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 60,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 131, DateTimeKind.Local).AddTicks(8006));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 61,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 131, DateTimeKind.Local).AddTicks(8012));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 62,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 131, DateTimeKind.Local).AddTicks(8016));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 63,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 131, DateTimeKind.Local).AddTicks(8021));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 64,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 131, DateTimeKind.Local).AddTicks(8026));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 65,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 131, DateTimeKind.Local).AddTicks(8031));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 66,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 131, DateTimeKind.Local).AddTicks(8038));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 67,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 131, DateTimeKind.Local).AddTicks(8044));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 68,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 131, DateTimeKind.Local).AddTicks(8049));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 69,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 131, DateTimeKind.Local).AddTicks(8054));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 70,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 131, DateTimeKind.Local).AddTicks(8059));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 71,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 131, DateTimeKind.Local).AddTicks(8064));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 72,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 131, DateTimeKind.Local).AddTicks(8068));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 73,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 131, DateTimeKind.Local).AddTicks(8073));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 74,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 131, DateTimeKind.Local).AddTicks(8079));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 75,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 131, DateTimeKind.Local).AddTicks(8084));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 76,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 131, DateTimeKind.Local).AddTicks(8089));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 77,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 131, DateTimeKind.Local).AddTicks(8094));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 78,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 131, DateTimeKind.Local).AddTicks(8099));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 79,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 131, DateTimeKind.Local).AddTicks(8104));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 80,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 131, DateTimeKind.Local).AddTicks(8108));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 81,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 131, DateTimeKind.Local).AddTicks(8113));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 82,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 131, DateTimeKind.Local).AddTicks(8189));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 83,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 131, DateTimeKind.Local).AddTicks(8193));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 84,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 131, DateTimeKind.Local).AddTicks(8198));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 85,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 131, DateTimeKind.Local).AddTicks(8203));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 86,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 131, DateTimeKind.Local).AddTicks(8208));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 87,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 131, DateTimeKind.Local).AddTicks(8213));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 88,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 131, DateTimeKind.Local).AddTicks(8218));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 89,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 131, DateTimeKind.Local).AddTicks(8222));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 90,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 131, DateTimeKind.Local).AddTicks(8227));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 91,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 131, DateTimeKind.Local).AddTicks(8232));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 92,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 131, DateTimeKind.Local).AddTicks(8237));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 93,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 131, DateTimeKind.Local).AddTicks(8242));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 94,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 131, DateTimeKind.Local).AddTicks(8247));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 95,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 131, DateTimeKind.Local).AddTicks(8252));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 96,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 131, DateTimeKind.Local).AddTicks(8257));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 97,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 131, DateTimeKind.Local).AddTicks(8262));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 98,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 131, DateTimeKind.Local).AddTicks(8266));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 99,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 131, DateTimeKind.Local).AddTicks(8272));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 100,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 131, DateTimeKind.Local).AddTicks(8276));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 101,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 131, DateTimeKind.Local).AddTicks(8281));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 102,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 131, DateTimeKind.Local).AddTicks(8307));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 103,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 131, DateTimeKind.Local).AddTicks(8312));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 104,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 131, DateTimeKind.Local).AddTicks(8317));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 105,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 131, DateTimeKind.Local).AddTicks(8323));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 106,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 131, DateTimeKind.Local).AddTicks(8327));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 107,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 131, DateTimeKind.Local).AddTicks(8333));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 108,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 131, DateTimeKind.Local).AddTicks(8338));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 109,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 131, DateTimeKind.Local).AddTicks(8343));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 110,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 131, DateTimeKind.Local).AddTicks(8348));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 111,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 131, DateTimeKind.Local).AddTicks(8384));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 112,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 131, DateTimeKind.Local).AddTicks(8389));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 113,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 131, DateTimeKind.Local).AddTicks(8394));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 114,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 131, DateTimeKind.Local).AddTicks(8399));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 115,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 131, DateTimeKind.Local).AddTicks(8404));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 116,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 131, DateTimeKind.Local).AddTicks(8408));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 117,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 131, DateTimeKind.Local).AddTicks(8413));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 118,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 131, DateTimeKind.Local).AddTicks(8418));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 119,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 131, DateTimeKind.Local).AddTicks(8423));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 120,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 131, DateTimeKind.Local).AddTicks(8427));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 121,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 131, DateTimeKind.Local).AddTicks(8432));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 122,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 131, DateTimeKind.Local).AddTicks(8437));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 123,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 131, DateTimeKind.Local).AddTicks(8442));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 124,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 131, DateTimeKind.Local).AddTicks(8447));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 125,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 131, DateTimeKind.Local).AddTicks(8451));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 126,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 131, DateTimeKind.Local).AddTicks(8456));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 127,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 131, DateTimeKind.Local).AddTicks(8461));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 128,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 131, DateTimeKind.Local).AddTicks(8466));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 129,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 131, DateTimeKind.Local).AddTicks(8470));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 130,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 131, DateTimeKind.Local).AddTicks(8477));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 131,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 131, DateTimeKind.Local).AddTicks(8483));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 132,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 131, DateTimeKind.Local).AddTicks(8488));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 133,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 131, DateTimeKind.Local).AddTicks(8493));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 134,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 131, DateTimeKind.Local).AddTicks(8498));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 135,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 131, DateTimeKind.Local).AddTicks(8503));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 136,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 131, DateTimeKind.Local).AddTicks(8508));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 137,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 131, DateTimeKind.Local).AddTicks(8512));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 138,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 131, DateTimeKind.Local).AddTicks(8517));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 139,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 131, DateTimeKind.Local).AddTicks(8522));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 140,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 131, DateTimeKind.Local).AddTicks(8527));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 141,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 131, DateTimeKind.Local).AddTicks(8532));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 142,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 131, DateTimeKind.Local).AddTicks(8536));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 143,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 131, DateTimeKind.Local).AddTicks(8541));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 144,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 131, DateTimeKind.Local).AddTicks(8546));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 145,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 131, DateTimeKind.Local).AddTicks(8551));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 146,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 131, DateTimeKind.Local).AddTicks(8556));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 147,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 131, DateTimeKind.Local).AddTicks(8561));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 148,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 131, DateTimeKind.Local).AddTicks(8566));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 149,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 131, DateTimeKind.Local).AddTicks(8571));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 150,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 131, DateTimeKind.Local).AddTicks(8575));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 151,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 131, DateTimeKind.Local).AddTicks(8580));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 152,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 131, DateTimeKind.Local).AddTicks(8585));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 153,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 131, DateTimeKind.Local).AddTicks(8589));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 154,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 131, DateTimeKind.Local).AddTicks(8595));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 155,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 131, DateTimeKind.Local).AddTicks(8599));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 156,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 131, DateTimeKind.Local).AddTicks(8604));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 157,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 131, DateTimeKind.Local).AddTicks(8609));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 158,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 131, DateTimeKind.Local).AddTicks(8614));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 159,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 131, DateTimeKind.Local).AddTicks(8619));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 160,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 131, DateTimeKind.Local).AddTicks(8623));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 161,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 131, DateTimeKind.Local).AddTicks(8628));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 162,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 131, DateTimeKind.Local).AddTicks(8633));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 160, DateTimeKind.Local).AddTicks(1883));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 160, DateTimeKind.Local).AddTicks(2003));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 160, DateTimeKind.Local).AddTicks(2028));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 160, DateTimeKind.Local).AddTicks(2010));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 160, DateTimeKind.Local).AddTicks(2034));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 160, DateTimeKind.Local).AddTicks(2047));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 160, DateTimeKind.Local).AddTicks(2055));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 160, DateTimeKind.Local).AddTicks(2062));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 160, DateTimeKind.Local).AddTicks(2070));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 160, DateTimeKind.Local).AddTicks(2076));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 160, DateTimeKind.Local).AddTicks(2121));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 160, DateTimeKind.Local).AddTicks(2128));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 13,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 160, DateTimeKind.Local).AddTicks(2134));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 14,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 160, DateTimeKind.Local).AddTicks(2141));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 15,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 160, DateTimeKind.Local).AddTicks(2017));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 16,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 160, DateTimeKind.Local).AddTicks(1993));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 17,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 160, DateTimeKind.Local).AddTicks(2150));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 18,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 160, DateTimeKind.Local).AddTicks(2156));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 19,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 160, DateTimeKind.Local).AddTicks(2162));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 20,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 160, DateTimeKind.Local).AddTicks(2169));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 22,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 160, DateTimeKind.Local).AddTicks(2197));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 23,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 160, DateTimeKind.Local).AddTicks(2183));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 24,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 160, DateTimeKind.Local).AddTicks(2177));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 25,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 160, DateTimeKind.Local).AddTicks(2191));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 26,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 160, DateTimeKind.Local).AddTicks(2205));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 27,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 160, DateTimeKind.Local).AddTicks(2218));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 28,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 160, DateTimeKind.Local).AddTicks(2225));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 30,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 160, DateTimeKind.Local).AddTicks(2232));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 31,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 160, DateTimeKind.Local).AddTicks(2239));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 32,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 160, DateTimeKind.Local).AddTicks(2245));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 33,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 160, DateTimeKind.Local).AddTicks(2253));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 34,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 160, DateTimeKind.Local).AddTicks(2260));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 36,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 160, DateTimeKind.Local).AddTicks(2268));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 37,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 160, DateTimeKind.Local).AddTicks(2275));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 38,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 160, DateTimeKind.Local).AddTicks(2283));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 39,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 160, DateTimeKind.Local).AddTicks(2041));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 40,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 160, DateTimeKind.Local).AddTicks(2290));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 41,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 160, DateTimeKind.Local).AddTicks(2297));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 42,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 160, DateTimeKind.Local).AddTicks(2304));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 43,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 160, DateTimeKind.Local).AddTicks(2311));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 44,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 160, DateTimeKind.Local).AddTicks(2579));

            migrationBuilder.UpdateData(
                table: "DeductionTypes",
                keyColumn: "DeductionTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 181, DateTimeKind.Local).AddTicks(9050));

            migrationBuilder.UpdateData(
                table: "DeductionTypes",
                keyColumn: "DeductionTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 181, DateTimeKind.Local).AddTicks(9389));

            migrationBuilder.UpdateData(
                table: "DeductionTypes",
                keyColumn: "DeductionTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 181, DateTimeKind.Local).AddTicks(9409));

            migrationBuilder.UpdateData(
                table: "DocumentFormats",
                keyColumn: "DocumentFormatID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 148, DateTimeKind.Local).AddTicks(749));

            migrationBuilder.UpdateData(
                table: "DocumentFormats",
                keyColumn: "DocumentFormatID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 148, DateTimeKind.Local).AddTicks(994));

            migrationBuilder.UpdateData(
                table: "DocumentFormats",
                keyColumn: "DocumentFormatID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 148, DateTimeKind.Local).AddTicks(1003));

            migrationBuilder.UpdateData(
                table: "DocumentFormats",
                keyColumn: "DocumentFormatID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 148, DateTimeKind.Local).AddTicks(1008));

            migrationBuilder.UpdateData(
                table: "DocumentFormats",
                keyColumn: "DocumentFormatID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 148, DateTimeKind.Local).AddTicks(1012));

            migrationBuilder.UpdateData(
                table: "DocumentFormats",
                keyColumn: "DocumentFormatID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 148, DateTimeKind.Local).AddTicks(1019));

            migrationBuilder.UpdateData(
                table: "DocumentTypes",
                keyColumn: "DocumentTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 149, DateTimeKind.Local).AddTicks(4248));

            migrationBuilder.UpdateData(
                table: "DocumentTypes",
                keyColumn: "DocumentTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 149, DateTimeKind.Local).AddTicks(4621));

            migrationBuilder.UpdateData(
                table: "DocumentTypes",
                keyColumn: "DocumentTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 149, DateTimeKind.Local).AddTicks(4643));

            migrationBuilder.UpdateData(
                table: "DocumentTypes",
                keyColumn: "DocumentTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 149, DateTimeKind.Local).AddTicks(4649));

            migrationBuilder.UpdateData(
                table: "EmailTemplates",
                keyColumn: "EmailTemplateID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 156, DateTimeKind.Local).AddTicks(21));

            migrationBuilder.UpdateData(
                table: "EmailTypes",
                keyColumn: "EmailTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 155, DateTimeKind.Local).AddTicks(5509));

            migrationBuilder.UpdateData(
                table: "EmailTypes",
                keyColumn: "EmailTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 155, DateTimeKind.Local).AddTicks(5731));

            migrationBuilder.UpdateData(
                table: "EmailTypes",
                keyColumn: "EmailTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 155, DateTimeKind.Local).AddTicks(5743));

            migrationBuilder.UpdateData(
                table: "EmailTypes",
                keyColumn: "EmailTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 155, DateTimeKind.Local).AddTicks(5751));

            migrationBuilder.UpdateData(
                table: "FeatureFlags",
                keyColumn: "FeatureFlagID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 146, DateTimeKind.Local).AddTicks(6142));

            migrationBuilder.UpdateData(
                table: "FeatureFlags",
                keyColumn: "FeatureFlagID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 146, DateTimeKind.Local).AddTicks(6359));

            migrationBuilder.UpdateData(
                table: "FeatureFlags",
                keyColumn: "FeatureFlagID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 146, DateTimeKind.Local).AddTicks(6370));

            migrationBuilder.UpdateData(
                table: "Frequencies",
                keyColumn: "FrequencyID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 134, DateTimeKind.Local).AddTicks(3242));

            migrationBuilder.UpdateData(
                table: "Frequencies",
                keyColumn: "FrequencyID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 134, DateTimeKind.Local).AddTicks(3500));

            migrationBuilder.UpdateData(
                table: "FundSources",
                keyColumn: "FundSourceID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 186, DateTimeKind.Local).AddTicks(9728));

            migrationBuilder.UpdateData(
                table: "FundSources",
                keyColumn: "FundSourceID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 187, DateTimeKind.Local).AddTicks(83));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "GenderID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 140, DateTimeKind.Local).AddTicks(6393));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "GenderID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 140, DateTimeKind.Local).AddTicks(6487));

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "InvoiceStatusID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 176, DateTimeKind.Local).AddTicks(762));

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "InvoiceStatusID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 176, DateTimeKind.Local).AddTicks(1022));

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "InvoiceStatusID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 176, DateTimeKind.Local).AddTicks(1034));

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "InvoiceStatusID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 176, DateTimeKind.Local).AddTicks(1040));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 180, DateTimeKind.Local).AddTicks(208));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 180, DateTimeKind.Local).AddTicks(348));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 180, DateTimeKind.Local).AddTicks(356));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 180, DateTimeKind.Local).AddTicks(362));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 180, DateTimeKind.Local).AddTicks(368));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 180, DateTimeKind.Local).AddTicks(376));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 180, DateTimeKind.Local).AddTicks(382));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 180, DateTimeKind.Local).AddTicks(387));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 180, DateTimeKind.Local).AddTicks(392));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 180, DateTimeKind.Local).AddTicks(399));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 180, DateTimeKind.Local).AddTicks(404));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 180, DateTimeKind.Local).AddTicks(409));

            migrationBuilder.InsertData(
                table: "LayoutMenus",
                columns: new[] { "LayoutMenuID", "ActionName", "CSSClass", "ControllerName", "DisplayName", "IsActive", "LastChangedBy", "LastChangedDate", "LayoutID", "OrderNo" },
                values: new object[] { 13, "KonapoFunds", "fas fa-chart-line", "KonapoFund", "Konapo Fund", true, "SuperUser", new DateTime(2022, 1, 15, 17, 22, 36, 180, DateTimeKind.Local).AddTicks(415), 1, 13 });

            migrationBuilder.UpdateData(
                table: "Layouts",
                keyColumn: "LayoutID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 178, DateTimeKind.Local).AddTicks(4848));

            migrationBuilder.UpdateData(
                table: "Layouts",
                keyColumn: "LayoutID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 178, DateTimeKind.Local).AddTicks(5451));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 150, DateTimeKind.Local).AddTicks(6544));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 150, DateTimeKind.Local).AddTicks(6650));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 150, DateTimeKind.Local).AddTicks(6663));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 150, DateTimeKind.Local).AddTicks(6669));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 150, DateTimeKind.Local).AddTicks(6675));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 150, DateTimeKind.Local).AddTicks(6737));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 150, DateTimeKind.Local).AddTicks(6683));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 8,
                columns: new[] { "CSSClass", "DisplayName", "LastChangedDate" },
                values: new object[] { "fas fa-chart-line", "Konapo Fund Set Up", new DateTime(2022, 1, 15, 17, 22, 36, 150, DateTimeKind.Local).AddTicks(6690) });

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 999,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 150, DateTimeKind.Local).AddTicks(6702));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 9998,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 150, DateTimeKind.Local).AddTicks(6696));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 152, DateTimeKind.Local).AddTicks(2347));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 152, DateTimeKind.Local).AddTicks(2449));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 152, DateTimeKind.Local).AddTicks(2455));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 152, DateTimeKind.Local).AddTicks(2459));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 152, DateTimeKind.Local).AddTicks(2463));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 152, DateTimeKind.Local).AddTicks(2469));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 152, DateTimeKind.Local).AddTicks(2473));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 152, DateTimeKind.Local).AddTicks(2477));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 152, DateTimeKind.Local).AddTicks(2481));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 152, DateTimeKind.Local).AddTicks(2486));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 152, DateTimeKind.Local).AddTicks(2490));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 13,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 152, DateTimeKind.Local).AddTicks(2494));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 14,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 152, DateTimeKind.Local).AddTicks(2498));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 15,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 152, DateTimeKind.Local).AddTicks(2501));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 16,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 152, DateTimeKind.Local).AddTicks(2505));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 17,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 152, DateTimeKind.Local).AddTicks(2509));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 18,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 152, DateTimeKind.Local).AddTicks(2513));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 19,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 152, DateTimeKind.Local).AddTicks(2517));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 20,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 152, DateTimeKind.Local).AddTicks(2521));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 21,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 152, DateTimeKind.Local).AddTicks(2525));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 22,
                columns: new[] { "CSSClass", "LastChangedDate" },
                values: new object[] { "fas fa-tasks", new DateTime(2022, 1, 15, 17, 22, 36, 152, DateTimeKind.Local).AddTicks(2528) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 23,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 152, DateTimeKind.Local).AddTicks(2532));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 9994,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 152, DateTimeKind.Local).AddTicks(2540));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 9995,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 152, DateTimeKind.Local).AddTicks(2544));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 9996,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 152, DateTimeKind.Local).AddTicks(2547));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 9997,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 152, DateTimeKind.Local).AddTicks(2551));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 9998,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 152, DateTimeKind.Local).AddTicks(2556));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 9999,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 152, DateTimeKind.Local).AddTicks(2559));

            migrationBuilder.InsertData(
                table: "Menus",
                columns: new[] { "MenuID", "ActionName", "CSSClass", "ControllerName", "DisplayName", "IsActive", "LastChangedBy", "LastChangedDate", "MenuGroupID", "OrderNo" },
                values: new object[] { 24, "KonapoFunds", "fas fa-chart-line", "KonapoFund", "Konpo Funds", true, "SuperUser", new DateTime(2022, 1, 15, 17, 22, 36, 152, DateTimeKind.Local).AddTicks(2536), 2, 24 });

            migrationBuilder.UpdateData(
                table: "PaymentStatus",
                keyColumn: "PaymentStatusID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 124, DateTimeKind.Local).AddTicks(3162));

            migrationBuilder.UpdateData(
                table: "PaymentStatus",
                keyColumn: "PaymentStatusID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 124, DateTimeKind.Local).AddTicks(3826));

            migrationBuilder.UpdateData(
                table: "PaymentStatus",
                keyColumn: "PaymentStatusID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 124, DateTimeKind.Local).AddTicks(3842));

            migrationBuilder.UpdateData(
                table: "PaymentStatus",
                keyColumn: "PaymentStatusID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 124, DateTimeKind.Local).AddTicks(3849));

            migrationBuilder.UpdateData(
                table: "PaymentStatus",
                keyColumn: "PaymentStatusID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 124, DateTimeKind.Local).AddTicks(3856));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 121, DateTimeKind.Local).AddTicks(2159));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 121, DateTimeKind.Local).AddTicks(2462));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 121, DateTimeKind.Local).AddTicks(2474));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 121, DateTimeKind.Local).AddTicks(2480));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 121, DateTimeKind.Local).AddTicks(2487));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 121, DateTimeKind.Local).AddTicks(2497));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 121, DateTimeKind.Local).AddTicks(2502));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 121, DateTimeKind.Local).AddTicks(2508));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 121, DateTimeKind.Local).AddTicks(2513));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 121, DateTimeKind.Local).AddTicks(2521));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 121, DateTimeKind.Local).AddTicks(2527));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 121, DateTimeKind.Local).AddTicks(2533));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 13,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 121, DateTimeKind.Local).AddTicks(2538));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 14,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 121, DateTimeKind.Local).AddTicks(2544));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 15,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 121, DateTimeKind.Local).AddTicks(2549));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 16,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 121, DateTimeKind.Local).AddTicks(2555));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 17,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 121, DateTimeKind.Local).AddTicks(2560));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 18,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 121, DateTimeKind.Local).AddTicks(2567));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 19,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 121, DateTimeKind.Local).AddTicks(2573));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 20,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 121, DateTimeKind.Local).AddTicks(2579));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 21,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 121, DateTimeKind.Local).AddTicks(2584));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 22,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 121, DateTimeKind.Local).AddTicks(2590));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 23,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 121, DateTimeKind.Local).AddTicks(2596));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 24,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 121, DateTimeKind.Local).AddTicks(2601));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 25,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 121, DateTimeKind.Local).AddTicks(2607));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 26,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 121, DateTimeKind.Local).AddTicks(2612));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 27,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 121, DateTimeKind.Local).AddTicks(2618));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 28,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 121, DateTimeKind.Local).AddTicks(2623));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 29,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 121, DateTimeKind.Local).AddTicks(2690));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 30,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 121, DateTimeKind.Local).AddTicks(2697));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 31,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 121, DateTimeKind.Local).AddTicks(2703));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 32,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 121, DateTimeKind.Local).AddTicks(2710));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 33,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 121, DateTimeKind.Local).AddTicks(2715));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 34,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 121, DateTimeKind.Local).AddTicks(2723));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 35,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 121, DateTimeKind.Local).AddTicks(2728));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 36,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 121, DateTimeKind.Local).AddTicks(2734));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 37,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 121, DateTimeKind.Local).AddTicks(2739));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 38,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 121, DateTimeKind.Local).AddTicks(2745));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 39,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 121, DateTimeKind.Local).AddTicks(2750));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 40,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 121, DateTimeKind.Local).AddTicks(2755));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 41,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 121, DateTimeKind.Local).AddTicks(2760));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 42,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 121, DateTimeKind.Local).AddTicks(2765));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 43,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 121, DateTimeKind.Local).AddTicks(2770));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 44,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 121, DateTimeKind.Local).AddTicks(2775));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 45,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 121, DateTimeKind.Local).AddTicks(2780));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 46,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 121, DateTimeKind.Local).AddTicks(2786));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 47,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 121, DateTimeKind.Local).AddTicks(2792));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 48,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 121, DateTimeKind.Local).AddTicks(2797));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 49,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 121, DateTimeKind.Local).AddTicks(2802));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 50,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 121, DateTimeKind.Local).AddTicks(2807));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 51,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 121, DateTimeKind.Local).AddTicks(2812));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 52,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 121, DateTimeKind.Local).AddTicks(2816));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 53,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 121, DateTimeKind.Local).AddTicks(2822));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 54,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 121, DateTimeKind.Local).AddTicks(2827));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 55,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 121, DateTimeKind.Local).AddTicks(2833));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 56,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 121, DateTimeKind.Local).AddTicks(2838));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 57,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 121, DateTimeKind.Local).AddTicks(2842));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 58,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 121, DateTimeKind.Local).AddTicks(2847));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 59,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 121, DateTimeKind.Local).AddTicks(2853));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 60,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 121, DateTimeKind.Local).AddTicks(2858));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 61,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 121, DateTimeKind.Local).AddTicks(2863));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 62,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 121, DateTimeKind.Local).AddTicks(2869));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 63,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 121, DateTimeKind.Local).AddTicks(2873));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 64,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 121, DateTimeKind.Local).AddTicks(2878));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 65,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 121, DateTimeKind.Local).AddTicks(2883));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 66,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 121, DateTimeKind.Local).AddTicks(2981));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 67,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 121, DateTimeKind.Local).AddTicks(2987));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 68,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 121, DateTimeKind.Local).AddTicks(2993));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 69,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 121, DateTimeKind.Local).AddTicks(2998));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 70,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 121, DateTimeKind.Local).AddTicks(3004));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 71,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 121, DateTimeKind.Local).AddTicks(3010));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 72,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 121, DateTimeKind.Local).AddTicks(3016));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 73,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 121, DateTimeKind.Local).AddTicks(3021));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 74,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 121, DateTimeKind.Local).AddTicks(3026));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 75,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 121, DateTimeKind.Local).AddTicks(3032));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 76,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 121, DateTimeKind.Local).AddTicks(3038));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 77,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 121, DateTimeKind.Local).AddTicks(3043));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 78,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 121, DateTimeKind.Local).AddTicks(3049));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 79,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 121, DateTimeKind.Local).AddTicks(3054));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 80,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 121, DateTimeKind.Local).AddTicks(3060));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 81,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 121, DateTimeKind.Local).AddTicks(3066));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 82,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 121, DateTimeKind.Local).AddTicks(3072));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 83,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 121, DateTimeKind.Local).AddTicks(3078));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 84,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 121, DateTimeKind.Local).AddTicks(3084));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 85,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 121, DateTimeKind.Local).AddTicks(3090));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 86,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 121, DateTimeKind.Local).AddTicks(3096));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 87,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 121, DateTimeKind.Local).AddTicks(3101));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 88,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 121, DateTimeKind.Local).AddTicks(3107));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 89,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 121, DateTimeKind.Local).AddTicks(3112));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 90,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 121, DateTimeKind.Local).AddTicks(3117));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 91,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 121, DateTimeKind.Local).AddTicks(3122));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 92,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 121, DateTimeKind.Local).AddTicks(3128));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 93,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 121, DateTimeKind.Local).AddTicks(3134));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 94,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 121, DateTimeKind.Local).AddTicks(3140));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 95,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 121, DateTimeKind.Local).AddTicks(3145));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 96,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 121, DateTimeKind.Local).AddTicks(3151));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 97,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 121, DateTimeKind.Local).AddTicks(3156));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 98,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 121, DateTimeKind.Local).AddTicks(3162));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 99,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 121, DateTimeKind.Local).AddTicks(3167));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 100,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 121, DateTimeKind.Local).AddTicks(3173));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 101,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 121, DateTimeKind.Local).AddTicks(3178));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 102,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 121, DateTimeKind.Local).AddTicks(3184));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 103,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 121, DateTimeKind.Local).AddTicks(3189));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 104,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 121, DateTimeKind.Local).AddTicks(3194));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 105,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 121, DateTimeKind.Local).AddTicks(3200));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 106,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 121, DateTimeKind.Local).AddTicks(3206));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 107,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 121, DateTimeKind.Local).AddTicks(3212));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 108,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 121, DateTimeKind.Local).AddTicks(3218));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 109,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 121, DateTimeKind.Local).AddTicks(3224));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 110,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 121, DateTimeKind.Local).AddTicks(3230));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 111,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 121, DateTimeKind.Local).AddTicks(3235));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 112,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 121, DateTimeKind.Local).AddTicks(3322));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 113,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 121, DateTimeKind.Local).AddTicks(3328));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 114,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 121, DateTimeKind.Local).AddTicks(3333));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 115,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 121, DateTimeKind.Local).AddTicks(3339));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 116,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 121, DateTimeKind.Local).AddTicks(3344));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 117,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 121, DateTimeKind.Local).AddTicks(3350));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 118,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 121, DateTimeKind.Local).AddTicks(3355));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 119,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 121, DateTimeKind.Local).AddTicks(3360));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 120,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 121, DateTimeKind.Local).AddTicks(3366));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 121,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 121, DateTimeKind.Local).AddTicks(3372));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 122,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 121, DateTimeKind.Local).AddTicks(3377));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 123,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 121, DateTimeKind.Local).AddTicks(3383));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 124,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 121, DateTimeKind.Local).AddTicks(3388));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 125,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 121, DateTimeKind.Local).AddTicks(3394));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 126,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 121, DateTimeKind.Local).AddTicks(3400));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 127,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 121, DateTimeKind.Local).AddTicks(3405));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 128,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 121, DateTimeKind.Local).AddTicks(3411));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 129,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 121, DateTimeKind.Local).AddTicks(3417));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 130,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 121, DateTimeKind.Local).AddTicks(3425));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 131,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 121, DateTimeKind.Local).AddTicks(3431));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 132,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 121, DateTimeKind.Local).AddTicks(3437));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 133,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 121, DateTimeKind.Local).AddTicks(3444));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 134,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 121, DateTimeKind.Local).AddTicks(3449));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 135,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 121, DateTimeKind.Local).AddTicks(3456));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 136,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 121, DateTimeKind.Local).AddTicks(3461));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 137,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 121, DateTimeKind.Local).AddTicks(3467));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 138,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 121, DateTimeKind.Local).AddTicks(3472));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 139,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 121, DateTimeKind.Local).AddTicks(3477));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 140,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 121, DateTimeKind.Local).AddTicks(3483));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 141,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 121, DateTimeKind.Local).AddTicks(3489));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 142,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 121, DateTimeKind.Local).AddTicks(3495));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 143,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 121, DateTimeKind.Local).AddTicks(3501));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 144,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 121, DateTimeKind.Local).AddTicks(3506));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 145,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 121, DateTimeKind.Local).AddTicks(3511));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 146,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 121, DateTimeKind.Local).AddTicks(3573));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 147,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 121, DateTimeKind.Local).AddTicks(3579));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 148,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 121, DateTimeKind.Local).AddTicks(3585));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 149,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 121, DateTimeKind.Local).AddTicks(3589));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 150,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 121, DateTimeKind.Local).AddTicks(3594));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 151,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 121, DateTimeKind.Local).AddTicks(3599));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 152,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 121, DateTimeKind.Local).AddTicks(3604));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 153,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 121, DateTimeKind.Local).AddTicks(3609));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 154,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 121, DateTimeKind.Local).AddTicks(3614));

            migrationBuilder.InsertData(
                table: "Permissions",
                columns: new[] { "PermissionID", "Description", "IsActive", "IsDeleted", "LastChangedBy", "LastChangedDate", "Name" },
                values: new object[,]
                {
                    { 155, null, true, false, "SuperUser", new DateTime(2022, 1, 15, 17, 22, 36, 121, DateTimeKind.Local).AddTicks(3619), "Add Konapo Fund" },
                    { 156, null, true, false, "SuperUser", new DateTime(2022, 1, 15, 17, 22, 36, 121, DateTimeKind.Local).AddTicks(3624), "Update Konapo Fund" },
                    { 157, null, true, false, "SuperUser", new DateTime(2022, 1, 15, 17, 22, 36, 121, DateTimeKind.Local).AddTicks(3628), "Delete Konapo Fund" },
                    { 158, null, true, false, "SuperUser", new DateTime(2022, 1, 15, 17, 22, 36, 121, DateTimeKind.Local).AddTicks(3633), "View Konapo Fund" }
                });

            migrationBuilder.UpdateData(
                table: "PriorityRanks",
                keyColumn: "PriorityRankID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 143, DateTimeKind.Local).AddTicks(6120));

            migrationBuilder.UpdateData(
                table: "PriorityRanks",
                keyColumn: "PriorityRankID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 143, DateTimeKind.Local).AddTicks(6391));

            migrationBuilder.UpdateData(
                table: "PriorityRanks",
                keyColumn: "PriorityRankID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 143, DateTimeKind.Local).AddTicks(6403));

            migrationBuilder.UpdateData(
                table: "PriorityRanks",
                keyColumn: "PriorityRankID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 143, DateTimeKind.Local).AddTicks(6407));

            migrationBuilder.UpdateData(
                table: "RecordStatus",
                keyColumn: "RecordStatusID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 171, DateTimeKind.Local).AddTicks(3315));

            migrationBuilder.UpdateData(
                table: "RecordStatus",
                keyColumn: "RecordStatusID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 171, DateTimeKind.Local).AddTicks(3851));

            migrationBuilder.UpdateData(
                table: "RecordStatus",
                keyColumn: "RecordStatusID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 171, DateTimeKind.Local).AddTicks(3872));

            migrationBuilder.UpdateData(
                table: "RelationshipTypes",
                keyColumn: "RelationshipTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 137, DateTimeKind.Local).AddTicks(8431));

            migrationBuilder.UpdateData(
                table: "RelationshipTypes",
                keyColumn: "RelationshipTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 137, DateTimeKind.Local).AddTicks(8535));

            migrationBuilder.UpdateData(
                table: "RelationshipTypes",
                keyColumn: "RelationshipTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 137, DateTimeKind.Local).AddTicks(8540));

            migrationBuilder.UpdateData(
                table: "RelationshipTypes",
                keyColumn: "RelationshipTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 137, DateTimeKind.Local).AddTicks(8544));

            migrationBuilder.UpdateData(
                table: "RelationshipTypes",
                keyColumn: "RelationshipTypeID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 137, DateTimeKind.Local).AddTicks(8547));

            migrationBuilder.UpdateData(
                table: "RelationshipTypes",
                keyColumn: "RelationshipTypeID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 137, DateTimeKind.Local).AddTicks(8554));

            migrationBuilder.UpdateData(
                table: "RelationshipTypes",
                keyColumn: "RelationshipTypeID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 137, DateTimeKind.Local).AddTicks(8557));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 160, DateTimeKind.Local).AddTicks(5518));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 160, DateTimeKind.Local).AddTicks(5584));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 160, DateTimeKind.Local).AddTicks(5589));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 160, DateTimeKind.Local).AddTicks(5592));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 160, DateTimeKind.Local).AddTicks(5596));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 160, DateTimeKind.Local).AddTicks(5600));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 160, DateTimeKind.Local).AddTicks(5604));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 160, DateTimeKind.Local).AddTicks(5607));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 160, DateTimeKind.Local).AddTicks(5610));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 160, DateTimeKind.Local).AddTicks(5614));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 160, DateTimeKind.Local).AddTicks(5618));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 160, DateTimeKind.Local).AddTicks(5621));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 13,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 160, DateTimeKind.Local).AddTicks(5624));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 14,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 160, DateTimeKind.Local).AddTicks(5627));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 15,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 160, DateTimeKind.Local).AddTicks(5630));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 16,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 160, DateTimeKind.Local).AddTicks(5633));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 17,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 160, DateTimeKind.Local).AddTicks(5636));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 18,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 160, DateTimeKind.Local).AddTicks(5641));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 19,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 160, DateTimeKind.Local).AddTicks(5644));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 20,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 160, DateTimeKind.Local).AddTicks(5647));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 21,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 160, DateTimeKind.Local).AddTicks(5650));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 22,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 160, DateTimeKind.Local).AddTicks(5653));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 24,
                columns: new[] { "LastChangedDate", "MenuID" },
                values: new object[] { new DateTime(2022, 1, 15, 17, 22, 36, 160, DateTimeKind.Local).AddTicks(5659), 9994 });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 25,
                columns: new[] { "LastChangedDate", "MenuID" },
                values: new object[] { new DateTime(2022, 1, 15, 17, 22, 36, 160, DateTimeKind.Local).AddTicks(5662), 9995 });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 26,
                columns: new[] { "LastChangedDate", "MenuID" },
                values: new object[] { new DateTime(2022, 1, 15, 17, 22, 36, 160, DateTimeKind.Local).AddTicks(5665), 9996 });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 27,
                columns: new[] { "LastChangedDate", "MenuID" },
                values: new object[] { new DateTime(2022, 1, 15, 17, 22, 36, 160, DateTimeKind.Local).AddTicks(5668), 9997 });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 28,
                columns: new[] { "LastChangedDate", "MenuID" },
                values: new object[] { new DateTime(2022, 1, 15, 17, 22, 36, 160, DateTimeKind.Local).AddTicks(5671), 9998 });

            migrationBuilder.InsertData(
                table: "RoleMenus",
                columns: new[] { "RoleMenuID", "LastChangedBy", "LastChangedDate", "MenuID", "RoleID" },
                values: new object[] { 29, "SuperUser", new DateTime(2022, 1, 15, 17, 22, 36, 160, DateTimeKind.Local).AddTicks(5674), 9999, 1 });

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 121, DateTimeKind.Local).AddTicks(8610));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 121, DateTimeKind.Local).AddTicks(8793));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 121, DateTimeKind.Local).AddTicks(8799));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 121, DateTimeKind.Local).AddTicks(8802));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 121, DateTimeKind.Local).AddTicks(8805));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 121, DateTimeKind.Local).AddTicks(8810));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 121, DateTimeKind.Local).AddTicks(8814));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 121, DateTimeKind.Local).AddTicks(8817));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 121, DateTimeKind.Local).AddTicks(8820));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 121, DateTimeKind.Local).AddTicks(8825));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 121, DateTimeKind.Local).AddTicks(8828));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 121, DateTimeKind.Local).AddTicks(8831));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 13,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 121, DateTimeKind.Local).AddTicks(8834));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 14,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 121, DateTimeKind.Local).AddTicks(8837));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 15,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 121, DateTimeKind.Local).AddTicks(8841));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 16,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 121, DateTimeKind.Local).AddTicks(8844));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 17,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 121, DateTimeKind.Local).AddTicks(8847));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 18,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 121, DateTimeKind.Local).AddTicks(8851));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 19,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 121, DateTimeKind.Local).AddTicks(8854));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 20,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 121, DateTimeKind.Local).AddTicks(8858));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 21,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 121, DateTimeKind.Local).AddTicks(8861));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 22,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 121, DateTimeKind.Local).AddTicks(8864));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 23,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 121, DateTimeKind.Local).AddTicks(8867));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 24,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 121, DateTimeKind.Local).AddTicks(8870));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 25,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 121, DateTimeKind.Local).AddTicks(8873));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 26,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 121, DateTimeKind.Local).AddTicks(8876));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 27,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 121, DateTimeKind.Local).AddTicks(8879));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 28,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 121, DateTimeKind.Local).AddTicks(8883));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 29,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 121, DateTimeKind.Local).AddTicks(8886));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 30,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 121, DateTimeKind.Local).AddTicks(8889));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 31,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 121, DateTimeKind.Local).AddTicks(8892));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 32,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 121, DateTimeKind.Local).AddTicks(9154));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 33,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 121, DateTimeKind.Local).AddTicks(9159));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 34,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 121, DateTimeKind.Local).AddTicks(9163));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 35,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 121, DateTimeKind.Local).AddTicks(9166));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 36,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 121, DateTimeKind.Local).AddTicks(9170));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 37,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 121, DateTimeKind.Local).AddTicks(9173));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 38,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 121, DateTimeKind.Local).AddTicks(9176));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 39,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 121, DateTimeKind.Local).AddTicks(9179));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 40,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 121, DateTimeKind.Local).AddTicks(9182));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 41,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 121, DateTimeKind.Local).AddTicks(9185));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 42,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 121, DateTimeKind.Local).AddTicks(9188));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 43,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 121, DateTimeKind.Local).AddTicks(9192));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 44,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 121, DateTimeKind.Local).AddTicks(9195));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 45,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 121, DateTimeKind.Local).AddTicks(9198));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 46,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 121, DateTimeKind.Local).AddTicks(9202));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 47,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 121, DateTimeKind.Local).AddTicks(9205));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 48,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 121, DateTimeKind.Local).AddTicks(9208));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 49,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 121, DateTimeKind.Local).AddTicks(9211));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 50,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 121, DateTimeKind.Local).AddTicks(9214));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 51,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 121, DateTimeKind.Local).AddTicks(9218));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 52,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 121, DateTimeKind.Local).AddTicks(9221));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 53,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 121, DateTimeKind.Local).AddTicks(9224));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 54,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 121, DateTimeKind.Local).AddTicks(9227));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 55,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 121, DateTimeKind.Local).AddTicks(9230));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 56,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 121, DateTimeKind.Local).AddTicks(9233));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 57,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 121, DateTimeKind.Local).AddTicks(9236));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 58,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 121, DateTimeKind.Local).AddTicks(9240));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 59,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 121, DateTimeKind.Local).AddTicks(9243));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 60,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 121, DateTimeKind.Local).AddTicks(9246));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 61,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 121, DateTimeKind.Local).AddTicks(9249));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 62,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 121, DateTimeKind.Local).AddTicks(9252));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 63,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 121, DateTimeKind.Local).AddTicks(9255));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 64,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 121, DateTimeKind.Local).AddTicks(9259));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 65,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 121, DateTimeKind.Local).AddTicks(9262));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 66,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 121, DateTimeKind.Local).AddTicks(9266));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 67,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 121, DateTimeKind.Local).AddTicks(9269));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 68,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 121, DateTimeKind.Local).AddTicks(9272));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 69,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 121, DateTimeKind.Local).AddTicks(9276));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 70,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 121, DateTimeKind.Local).AddTicks(9279));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 71,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 121, DateTimeKind.Local).AddTicks(9282));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 72,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 121, DateTimeKind.Local).AddTicks(9285));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 73,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 121, DateTimeKind.Local).AddTicks(9288));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 74,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 121, DateTimeKind.Local).AddTicks(9291));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 75,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 121, DateTimeKind.Local).AddTicks(9294));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 76,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 121, DateTimeKind.Local).AddTicks(9298));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 77,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 121, DateTimeKind.Local).AddTicks(9301));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 78,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 121, DateTimeKind.Local).AddTicks(9304));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 79,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 121, DateTimeKind.Local).AddTicks(9307));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 80,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 121, DateTimeKind.Local).AddTicks(9310));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 81,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 121, DateTimeKind.Local).AddTicks(9313));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 82,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 121, DateTimeKind.Local).AddTicks(9317));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 83,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 121, DateTimeKind.Local).AddTicks(9320));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 84,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 121, DateTimeKind.Local).AddTicks(9323));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 85,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 121, DateTimeKind.Local).AddTicks(9326));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 86,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 121, DateTimeKind.Local).AddTicks(9329));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 87,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 121, DateTimeKind.Local).AddTicks(9332));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 88,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 121, DateTimeKind.Local).AddTicks(9335));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 89,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 121, DateTimeKind.Local).AddTicks(9339));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 90,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 121, DateTimeKind.Local).AddTicks(9342));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 91,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 121, DateTimeKind.Local).AddTicks(9345));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 92,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 121, DateTimeKind.Local).AddTicks(9348));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 93,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 121, DateTimeKind.Local).AddTicks(9352));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 94,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 121, DateTimeKind.Local).AddTicks(9355));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 95,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 121, DateTimeKind.Local).AddTicks(9358));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 96,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 121, DateTimeKind.Local).AddTicks(9361));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 97,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 121, DateTimeKind.Local).AddTicks(9365));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 98,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 121, DateTimeKind.Local).AddTicks(9368));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 99,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 121, DateTimeKind.Local).AddTicks(9371));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 100,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 121, DateTimeKind.Local).AddTicks(9374));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 101,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 121, DateTimeKind.Local).AddTicks(9377));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 102,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 121, DateTimeKind.Local).AddTicks(9380));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 103,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 121, DateTimeKind.Local).AddTicks(9383));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 104,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 121, DateTimeKind.Local).AddTicks(9386));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 105,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 121, DateTimeKind.Local).AddTicks(9390));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 106,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 121, DateTimeKind.Local).AddTicks(9393));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 107,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 121, DateTimeKind.Local).AddTicks(9396));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 108,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 121, DateTimeKind.Local).AddTicks(9400));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 109,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 121, DateTimeKind.Local).AddTicks(9403));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 110,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 121, DateTimeKind.Local).AddTicks(9406));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 111,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 121, DateTimeKind.Local).AddTicks(9409));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 112,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 121, DateTimeKind.Local).AddTicks(9412));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 113,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 121, DateTimeKind.Local).AddTicks(9415));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 114,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 121, DateTimeKind.Local).AddTicks(9418));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 115,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 121, DateTimeKind.Local).AddTicks(9421));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 116,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 121, DateTimeKind.Local).AddTicks(9425));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 117,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 121, DateTimeKind.Local).AddTicks(9428));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 118,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 121, DateTimeKind.Local).AddTicks(9431));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 119,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 121, DateTimeKind.Local).AddTicks(9434));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 120,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 121, DateTimeKind.Local).AddTicks(9437));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 121,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 121, DateTimeKind.Local).AddTicks(9440));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 122,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 121, DateTimeKind.Local).AddTicks(9443));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 123,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 121, DateTimeKind.Local).AddTicks(9446));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 124,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 121, DateTimeKind.Local).AddTicks(9449));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 125,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 121, DateTimeKind.Local).AddTicks(9453));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 126,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 121, DateTimeKind.Local).AddTicks(9456));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 127,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 121, DateTimeKind.Local).AddTicks(9459));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 128,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 121, DateTimeKind.Local).AddTicks(9462));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 129,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 121, DateTimeKind.Local).AddTicks(9465));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 130,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 121, DateTimeKind.Local).AddTicks(9734));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 131,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 121, DateTimeKind.Local).AddTicks(9738));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 132,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 121, DateTimeKind.Local).AddTicks(9741));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 133,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 121, DateTimeKind.Local).AddTicks(9744));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 134,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 121, DateTimeKind.Local).AddTicks(9747));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 135,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 121, DateTimeKind.Local).AddTicks(9750));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 136,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 121, DateTimeKind.Local).AddTicks(9754));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 137,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 121, DateTimeKind.Local).AddTicks(9757));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 138,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 121, DateTimeKind.Local).AddTicks(9761));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 139,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 121, DateTimeKind.Local).AddTicks(9764));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 140,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 121, DateTimeKind.Local).AddTicks(9768));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 141,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 121, DateTimeKind.Local).AddTicks(9771));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 142,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 121, DateTimeKind.Local).AddTicks(9774));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 143,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 121, DateTimeKind.Local).AddTicks(9777));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 144,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 121, DateTimeKind.Local).AddTicks(9781));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 145,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 121, DateTimeKind.Local).AddTicks(9784));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 146,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 121, DateTimeKind.Local).AddTicks(9787));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 147,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 121, DateTimeKind.Local).AddTicks(9790));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 148,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 121, DateTimeKind.Local).AddTicks(9793));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 149,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 121, DateTimeKind.Local).AddTicks(9796));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 150,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 121, DateTimeKind.Local).AddTicks(9800));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 151,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 121, DateTimeKind.Local).AddTicks(9803));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 152,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 121, DateTimeKind.Local).AddTicks(9810));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 153,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 121, DateTimeKind.Local).AddTicks(9815));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 154,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 121, DateTimeKind.Local).AddTicks(9821));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 114, DateTimeKind.Local).AddTicks(349));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 117, DateTimeKind.Local).AddTicks(2725));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 117, DateTimeKind.Local).AddTicks(2775));

            migrationBuilder.UpdateData(
                table: "StatementLists",
                keyColumn: "StatementID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 164, DateTimeKind.Local).AddTicks(7895));

            migrationBuilder.UpdateData(
                table: "StatementLists",
                keyColumn: "StatementID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 165, DateTimeKind.Local).AddTicks(873));

            migrationBuilder.UpdateData(
                table: "StatementLists",
                keyColumn: "StatementID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 165, DateTimeKind.Local).AddTicks(885));

            migrationBuilder.UpdateData(
                table: "StatementLists",
                keyColumn: "StatementID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 165, DateTimeKind.Local).AddTicks(891));

            migrationBuilder.UpdateData(
                table: "TechnicalSupport",
                keyColumn: "TechnicalSupportID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 184, DateTimeKind.Local).AddTicks(3178));

            migrationBuilder.UpdateData(
                table: "TechnicalSupport",
                keyColumn: "TechnicalSupportID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 184, DateTimeKind.Local).AddTicks(3496));

            migrationBuilder.UpdateData(
                table: "TechnicalSupport",
                keyColumn: "TechnicalSupportID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 184, DateTimeKind.Local).AddTicks(3510));

            migrationBuilder.UpdateData(
                table: "TechnicalSupport",
                keyColumn: "TechnicalSupportID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 184, DateTimeKind.Local).AddTicks(3516));

            migrationBuilder.UpdateData(
                table: "TechnicalSupport",
                keyColumn: "TechnicalSupportID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 184, DateTimeKind.Local).AddTicks(3523));

            migrationBuilder.UpdateData(
                table: "TechnicalSupport",
                keyColumn: "TechnicalSupportID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 184, DateTimeKind.Local).AddTicks(3534));

            migrationBuilder.UpdateData(
                table: "Titles",
                keyColumn: "TitleID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 166, DateTimeKind.Local).AddTicks(6506));

            migrationBuilder.UpdateData(
                table: "Titles",
                keyColumn: "TitleID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 166, DateTimeKind.Local).AddTicks(6768));

            migrationBuilder.UpdateData(
                table: "Titles",
                keyColumn: "TitleID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 166, DateTimeKind.Local).AddTicks(6777));

            migrationBuilder.UpdateData(
                table: "Titles",
                keyColumn: "TitleID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 166, DateTimeKind.Local).AddTicks(6782));

            migrationBuilder.UpdateData(
                table: "Titles",
                keyColumn: "TitleID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 166, DateTimeKind.Local).AddTicks(6786));

            migrationBuilder.UpdateData(
                table: "Titles",
                keyColumn: "TitleID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 166, DateTimeKind.Local).AddTicks(6793));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 127, DateTimeKind.Local).AddTicks(2625));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 127, DateTimeKind.Local).AddTicks(3163));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 127, DateTimeKind.Local).AddTicks(3350));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 127, DateTimeKind.Local).AddTicks(3429));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 127, DateTimeKind.Local).AddTicks(3569));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 127, DateTimeKind.Local).AddTicks(3627));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 127, DateTimeKind.Local).AddTicks(3675));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 127, DateTimeKind.Local).AddTicks(3722));

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumns: new[] { "UserID", "RoleID" },
                keyValues: new object[] { 1, 1 },
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 149, DateTimeKind.Local).AddTicks(6902));

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumns: new[] { "UserID", "RoleID" },
                keyValues: new object[] { 2, 3 },
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 149, DateTimeKind.Local).AddTicks(6956));

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "UserTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 136, DateTimeKind.Local).AddTicks(5752));

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "UserTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 136, DateTimeKind.Local).AddTicks(6036));

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "UserTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 136, DateTimeKind.Local).AddTicks(6048));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 144, DateTimeKind.Local).AddTicks(873));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 145, DateTimeKind.Local).AddTicks(401));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 145, DateTimeKind.Local).AddTicks(574));

            migrationBuilder.UpdateData(
                table: "VariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 140, DateTimeKind.Local).AddTicks(469));

            migrationBuilder.UpdateData(
                table: "VariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 140, DateTimeKind.Local).AddTicks(867));

            migrationBuilder.UpdateData(
                table: "VariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 140, DateTimeKind.Local).AddTicks(886));

            migrationBuilder.UpdateData(
                table: "VariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 140, DateTimeKind.Local).AddTicks(895));

            migrationBuilder.UpdateData(
                table: "VariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 140, DateTimeKind.Local).AddTicks(905));

            migrationBuilder.UpdateData(
                table: "VariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 140, DateTimeKind.Local).AddTicks(918));

            migrationBuilder.UpdateData(
                table: "VariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 140, DateTimeKind.Local).AddTicks(933));

            migrationBuilder.UpdateData(
                table: "VariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 140, DateTimeKind.Local).AddTicks(942));

            migrationBuilder.UpdateData(
                table: "VariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 17, 22, 36, 140, DateTimeKind.Local).AddTicks(951));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 23,
                columns: new[] { "LastChangedDate", "MenuID" },
                values: new object[] { new DateTime(2022, 1, 15, 17, 22, 36, 160, DateTimeKind.Local).AddTicks(5656), 24 });

            migrationBuilder.InsertData(
                table: "RolePermissions",
                columns: new[] { "RolePermissionID", "LastChangedBy", "LastChangedDate", "PermissionID", "RoleID" },
                values: new object[,]
                {
                    { 155, "SuperUser", new DateTime(2022, 1, 15, 17, 22, 36, 121, DateTimeKind.Local).AddTicks(9826), 155, 1 },
                    { 156, "SuperUser", new DateTime(2022, 1, 15, 17, 22, 36, 121, DateTimeKind.Local).AddTicks(9831), 156, 1 },
                    { 157, "SuperUser", new DateTime(2022, 1, 15, 17, 22, 36, 121, DateTimeKind.Local).AddTicks(9835), 157, 1 },
                    { 158, "SuperUser", new DateTime(2022, 1, 15, 17, 22, 36, 121, DateTimeKind.Local).AddTicks(9840), 158, 1 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 155);

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 156);

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 157);

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 158);

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 155);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 156);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 157);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 158);

            migrationBuilder.DropColumn(
                name: "KonapoRef",
                table: "KonapoFunds");

            migrationBuilder.UpdateData(
                table: "BankAccountTypes",
                keyColumn: "BankAccountTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 854, DateTimeKind.Local).AddTicks(3332));

            migrationBuilder.UpdateData(
                table: "BankAccountTypes",
                keyColumn: "BankAccountTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 854, DateTimeKind.Local).AddTicks(3618));

            migrationBuilder.UpdateData(
                table: "BankAccountTypes",
                keyColumn: "BankAccountTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 854, DateTimeKind.Local).AddTicks(3630));

            migrationBuilder.UpdateData(
                table: "BankAccountTypes",
                keyColumn: "BankAccountTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 854, DateTimeKind.Local).AddTicks(3683));

            migrationBuilder.UpdateData(
                table: "ClientAccountTypes",
                keyColumn: "ID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 891, DateTimeKind.Local).AddTicks(103));

            migrationBuilder.UpdateData(
                table: "ClientAccountTypes",
                keyColumn: "ID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 891, DateTimeKind.Local).AddTicks(316));

            migrationBuilder.UpdateData(
                table: "ClientGroups",
                keyColumn: "ClientGroupID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 894, DateTimeKind.Local).AddTicks(1157));

            migrationBuilder.UpdateData(
                table: "ClientGroups",
                keyColumn: "ClientGroupID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 894, DateTimeKind.Local).AddTicks(1463));

            migrationBuilder.UpdateData(
                table: "ContactTypes",
                keyColumn: "ContactTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 860, DateTimeKind.Local).AddTicks(757));

            migrationBuilder.UpdateData(
                table: "ContactTypes",
                keyColumn: "ContactTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 860, DateTimeKind.Local).AddTicks(751));

            migrationBuilder.UpdateData(
                table: "ContactTypes",
                keyColumn: "ContactTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 860, DateTimeKind.Local).AddTicks(743));

            migrationBuilder.UpdateData(
                table: "ContactTypes",
                keyColumn: "ContactTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 860, DateTimeKind.Local).AddTicks(667));

            migrationBuilder.UpdateData(
                table: "ContactTypes",
                keyColumn: "ContactTypeID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 860, DateTimeKind.Local).AddTicks(762));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(1169));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(1379));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(1389));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(1397));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(1402));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(1410));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(1415));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(1421));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(1425));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(1431));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(1436));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(1440));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 13,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(1444));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 14,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(1448));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 15,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(1453));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 16,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(1458));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 17,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(1462));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 18,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(1468));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 19,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(1472));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 20,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(1477));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 21,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(1481));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 22,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(1485));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 23,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(1489));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 24,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(1493));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 25,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(1497));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 26,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(1501));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 27,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(1507));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 28,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(1511));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 29,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(1515));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 30,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(1521));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 31,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(1525));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 32,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(1529));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 33,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(1534));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 34,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(1540));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 35,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(1544));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 36,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(1549));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 37,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(1553));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 38,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(1557));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 39,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(1562));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 40,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(1567));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 41,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(1572));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 42,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(1576));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 43,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(1580));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 44,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(1585));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 45,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(1589));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 46,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(1642));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 47,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(1648));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 48,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(1653));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 49,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(1658));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 50,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(1664));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 51,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(1668));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 52,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(1672));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 53,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(1676));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 54,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(1681));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 55,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(1686));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 56,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(1690));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 57,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(1694));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 58,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(1699));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 59,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(1704));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 60,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(1708));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 61,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(1713));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 62,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(1717));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 63,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(1722));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 64,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(1727));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 65,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(1731));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 66,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(1737));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 67,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(1741));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 68,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(1745));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 69,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(1749));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 70,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(1754));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 71,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(1758));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 72,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(1763));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 73,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(1768));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 74,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(1772));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 75,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(1777));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 76,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(1782));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 77,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(1786));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 78,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(1790));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 79,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(1794));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 80,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(1799));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 81,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(1803));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 82,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(1807));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 83,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(1811));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 84,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(1816));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 85,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(1820));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 86,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(1824));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 87,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(1828));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 88,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(1833));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 89,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(1838));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 90,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(1842));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 91,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(1846));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 92,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(1850));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 93,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(1855));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 94,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(1860));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 95,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(1864));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 96,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(1868));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 97,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(1873));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 98,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(1877));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 99,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(1881));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 100,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(1885));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 101,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(1891));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 102,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(1895));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 103,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(1899));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 104,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(1904));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 105,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(1908));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 106,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(1949));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 107,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(1954));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 108,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(1959));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 109,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(1963));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 110,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(1968));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 111,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(1973));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 112,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(1977));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 113,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(1982));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 114,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(1986));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 115,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(1990));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 116,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(1994));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 117,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(1999));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 118,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(2003));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 119,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(2007));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 120,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(2012));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 121,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(2016));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 122,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(2020));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 123,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(2025));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 124,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(2029));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 125,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(2033));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 126,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(2037));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 127,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(2041));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 128,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(2045));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 129,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(2050));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 130,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(2056));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 131,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(2060));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 132,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(2065));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 133,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(2070));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 134,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(2074));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 135,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(2078));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 136,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(2082));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 137,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(2086));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 138,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(2092));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 139,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(2096));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 140,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(2100));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 141,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(2104));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 142,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(2108));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 143,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(2113));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 144,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(2118));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 145,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(2122));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 146,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(2127));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 147,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(2131));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 148,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(2136));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 149,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(2141));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 150,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(2147));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 151,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(2151));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 152,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(2156));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 153,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(2160));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 154,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(2164));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 155,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(2170));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 156,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(2174));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 157,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(2178));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 158,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(2182));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 159,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(2186));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 160,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(2191));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 161,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(2287));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 162,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(2294));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 163,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(2298));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 164,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(2303));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 165,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(2307));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 166,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(2312));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 167,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(2317));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 168,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(2321));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 169,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(2325));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 170,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(2329));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 171,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(2333));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 172,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(2338));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 173,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(2343));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 174,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(2348));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 175,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(2353));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 176,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(2359));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 177,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(2365));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 178,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(2369));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 179,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(2374));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 180,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(2379));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 181,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(2384));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 182,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(2389));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 183,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(2394));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 184,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(2398));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 185,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(2403));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 186,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(2407));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 187,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(2412));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 188,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(2416));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 189,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(2421));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 190,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(2425));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 191,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(2429));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 192,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(2433));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 193,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(2439));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 194,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(2443));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 195,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(2447));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 196,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(2451));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 197,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(2455));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 198,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(2459));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 199,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(2464));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 200,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(2468));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 201,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(2472));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 202,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(2477));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 203,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(2481));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 204,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(2485));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 205,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(2489));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 206,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(2494));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 207,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(2499));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 208,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(2504));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 209,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(2508));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 210,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(2513));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 211,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(2518));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 212,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(2522));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 213,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(2526));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 214,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(2531));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 215,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(2536));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 216,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(2541));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 217,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(2545));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 218,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(2549));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 219,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(2553));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 220,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(2558));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 221,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(2562));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 222,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(2567));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 223,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(2572));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 224,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(2576));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 225,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(2581));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 226,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(2585));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 227,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(2620));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 228,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 864, DateTimeKind.Local).AddTicks(2625));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 856, DateTimeKind.Local).AddTicks(4142));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 856, DateTimeKind.Local).AddTicks(4421));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 856, DateTimeKind.Local).AddTicks(4432));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 856, DateTimeKind.Local).AddTicks(4437));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 856, DateTimeKind.Local).AddTicks(4441));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 856, DateTimeKind.Local).AddTicks(4449));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 856, DateTimeKind.Local).AddTicks(4453));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 856, DateTimeKind.Local).AddTicks(4458));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 856, DateTimeKind.Local).AddTicks(4463));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 856, DateTimeKind.Local).AddTicks(4468));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 856, DateTimeKind.Local).AddTicks(4473));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 856, DateTimeKind.Local).AddTicks(4477));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 13,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 856, DateTimeKind.Local).AddTicks(4515));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 14,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 856, DateTimeKind.Local).AddTicks(4521));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 15,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 856, DateTimeKind.Local).AddTicks(4525));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 16,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 856, DateTimeKind.Local).AddTicks(4530));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 17,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 856, DateTimeKind.Local).AddTicks(4534));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 18,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 856, DateTimeKind.Local).AddTicks(4539));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 19,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 856, DateTimeKind.Local).AddTicks(4543));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 20,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 856, DateTimeKind.Local).AddTicks(4547));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 21,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 856, DateTimeKind.Local).AddTicks(4552));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 22,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 856, DateTimeKind.Local).AddTicks(4556));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 23,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 856, DateTimeKind.Local).AddTicks(4560));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 24,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 856, DateTimeKind.Local).AddTicks(4564));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 25,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 856, DateTimeKind.Local).AddTicks(4569));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 26,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 856, DateTimeKind.Local).AddTicks(4573));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 27,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 856, DateTimeKind.Local).AddTicks(4577));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 28,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 856, DateTimeKind.Local).AddTicks(4582));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 29,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 856, DateTimeKind.Local).AddTicks(4585));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 30,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 856, DateTimeKind.Local).AddTicks(4589));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 31,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 856, DateTimeKind.Local).AddTicks(4594));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 32,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 856, DateTimeKind.Local).AddTicks(4598));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 33,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 856, DateTimeKind.Local).AddTicks(4602));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 34,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 856, DateTimeKind.Local).AddTicks(4608));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 35,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 856, DateTimeKind.Local).AddTicks(4612));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 36,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 856, DateTimeKind.Local).AddTicks(4616));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 37,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 856, DateTimeKind.Local).AddTicks(4620));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 38,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 856, DateTimeKind.Local).AddTicks(4625));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 39,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 856, DateTimeKind.Local).AddTicks(4629));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 40,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 856, DateTimeKind.Local).AddTicks(4633));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 41,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 856, DateTimeKind.Local).AddTicks(4637));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 42,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 856, DateTimeKind.Local).AddTicks(4642));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 43,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 856, DateTimeKind.Local).AddTicks(4646));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 44,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 856, DateTimeKind.Local).AddTicks(4650));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 45,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 856, DateTimeKind.Local).AddTicks(4654));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 46,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 856, DateTimeKind.Local).AddTicks(4659));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 47,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 856, DateTimeKind.Local).AddTicks(4663));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 48,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 856, DateTimeKind.Local).AddTicks(4667));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 49,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 856, DateTimeKind.Local).AddTicks(4671));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 50,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 856, DateTimeKind.Local).AddTicks(4675));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 51,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 856, DateTimeKind.Local).AddTicks(4679));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 52,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 856, DateTimeKind.Local).AddTicks(4683));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 53,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 856, DateTimeKind.Local).AddTicks(4687));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 54,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 856, DateTimeKind.Local).AddTicks(4691));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 55,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 856, DateTimeKind.Local).AddTicks(4695));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 56,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 856, DateTimeKind.Local).AddTicks(4700));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 57,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 856, DateTimeKind.Local).AddTicks(4704));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 58,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 856, DateTimeKind.Local).AddTicks(4708));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 59,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 856, DateTimeKind.Local).AddTicks(4713));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 60,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 856, DateTimeKind.Local).AddTicks(4717));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 61,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 856, DateTimeKind.Local).AddTicks(4721));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 62,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 856, DateTimeKind.Local).AddTicks(4725));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 63,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 856, DateTimeKind.Local).AddTicks(4729));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 64,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 856, DateTimeKind.Local).AddTicks(4733));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 65,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 856, DateTimeKind.Local).AddTicks(4737));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 66,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 856, DateTimeKind.Local).AddTicks(4743));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 67,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 856, DateTimeKind.Local).AddTicks(4747));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 68,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 856, DateTimeKind.Local).AddTicks(4751));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 69,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 856, DateTimeKind.Local).AddTicks(4755));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 70,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 856, DateTimeKind.Local).AddTicks(4759));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 71,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 856, DateTimeKind.Local).AddTicks(4763));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 72,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 856, DateTimeKind.Local).AddTicks(4767));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 73,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 856, DateTimeKind.Local).AddTicks(4801));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 74,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 856, DateTimeKind.Local).AddTicks(4806));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 75,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 856, DateTimeKind.Local).AddTicks(4810));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 76,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 856, DateTimeKind.Local).AddTicks(4815));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 77,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 856, DateTimeKind.Local).AddTicks(4819));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 78,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 856, DateTimeKind.Local).AddTicks(4823));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 79,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 856, DateTimeKind.Local).AddTicks(4827));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 80,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 856, DateTimeKind.Local).AddTicks(4831));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 81,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 856, DateTimeKind.Local).AddTicks(4835));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 82,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 856, DateTimeKind.Local).AddTicks(4840));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 83,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 856, DateTimeKind.Local).AddTicks(4844));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 84,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 856, DateTimeKind.Local).AddTicks(4848));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 85,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 856, DateTimeKind.Local).AddTicks(4852));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 86,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 856, DateTimeKind.Local).AddTicks(4856));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 87,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 856, DateTimeKind.Local).AddTicks(4860));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 88,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 856, DateTimeKind.Local).AddTicks(4864));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 89,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 856, DateTimeKind.Local).AddTicks(4868));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 90,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 856, DateTimeKind.Local).AddTicks(4872));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 91,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 856, DateTimeKind.Local).AddTicks(4876));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 92,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 856, DateTimeKind.Local).AddTicks(4880));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 93,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 856, DateTimeKind.Local).AddTicks(4884));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 94,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 856, DateTimeKind.Local).AddTicks(4888));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 95,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 856, DateTimeKind.Local).AddTicks(4892));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 96,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 856, DateTimeKind.Local).AddTicks(4896));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 97,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 856, DateTimeKind.Local).AddTicks(4900));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 98,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 856, DateTimeKind.Local).AddTicks(4904));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 99,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 856, DateTimeKind.Local).AddTicks(4908));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 100,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 856, DateTimeKind.Local).AddTicks(4911));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 101,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 856, DateTimeKind.Local).AddTicks(4915));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 102,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 856, DateTimeKind.Local).AddTicks(4920));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 103,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 856, DateTimeKind.Local).AddTicks(4923));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 104,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 856, DateTimeKind.Local).AddTicks(4928));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 105,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 856, DateTimeKind.Local).AddTicks(4932));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 106,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 856, DateTimeKind.Local).AddTicks(4936));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 107,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 856, DateTimeKind.Local).AddTicks(4940));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 108,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 856, DateTimeKind.Local).AddTicks(4944));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 109,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 856, DateTimeKind.Local).AddTicks(4948));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 110,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 856, DateTimeKind.Local).AddTicks(4952));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 111,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 856, DateTimeKind.Local).AddTicks(4956));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 112,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 856, DateTimeKind.Local).AddTicks(4960));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 113,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 856, DateTimeKind.Local).AddTicks(4964));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 114,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 856, DateTimeKind.Local).AddTicks(4968));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 115,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 856, DateTimeKind.Local).AddTicks(4972));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 116,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 856, DateTimeKind.Local).AddTicks(4976));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 117,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 856, DateTimeKind.Local).AddTicks(4980));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 118,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 856, DateTimeKind.Local).AddTicks(4984));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 119,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 856, DateTimeKind.Local).AddTicks(4988));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 120,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 856, DateTimeKind.Local).AddTicks(4992));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 121,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 856, DateTimeKind.Local).AddTicks(4996));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 122,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 856, DateTimeKind.Local).AddTicks(5000));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 123,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 856, DateTimeKind.Local).AddTicks(5004));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 124,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 856, DateTimeKind.Local).AddTicks(5008));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 125,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 856, DateTimeKind.Local).AddTicks(5012));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 126,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 856, DateTimeKind.Local).AddTicks(5016));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 127,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 856, DateTimeKind.Local).AddTicks(5020));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 128,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 856, DateTimeKind.Local).AddTicks(5024));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 129,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 856, DateTimeKind.Local).AddTicks(5028));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 130,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 856, DateTimeKind.Local).AddTicks(5034));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 131,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 856, DateTimeKind.Local).AddTicks(5038));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 132,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 856, DateTimeKind.Local).AddTicks(5090));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 133,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 856, DateTimeKind.Local).AddTicks(5095));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 134,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 856, DateTimeKind.Local).AddTicks(5100));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 135,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 856, DateTimeKind.Local).AddTicks(5104));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 136,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 856, DateTimeKind.Local).AddTicks(5108));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 137,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 856, DateTimeKind.Local).AddTicks(5112));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 138,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 856, DateTimeKind.Local).AddTicks(5116));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 139,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 856, DateTimeKind.Local).AddTicks(5120));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 140,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 856, DateTimeKind.Local).AddTicks(5124));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 141,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 856, DateTimeKind.Local).AddTicks(5128));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 142,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 856, DateTimeKind.Local).AddTicks(5132));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 143,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 856, DateTimeKind.Local).AddTicks(5136));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 144,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 856, DateTimeKind.Local).AddTicks(5140));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 145,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 856, DateTimeKind.Local).AddTicks(5144));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 146,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 856, DateTimeKind.Local).AddTicks(5148));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 147,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 856, DateTimeKind.Local).AddTicks(5152));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 148,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 856, DateTimeKind.Local).AddTicks(5156));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 149,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 856, DateTimeKind.Local).AddTicks(5160));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 150,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 856, DateTimeKind.Local).AddTicks(5164));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 151,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 856, DateTimeKind.Local).AddTicks(5168));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 152,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 856, DateTimeKind.Local).AddTicks(5173));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 153,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 856, DateTimeKind.Local).AddTicks(5177));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 154,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 856, DateTimeKind.Local).AddTicks(5181));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 155,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 856, DateTimeKind.Local).AddTicks(5185));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 156,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 856, DateTimeKind.Local).AddTicks(5189));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 157,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 856, DateTimeKind.Local).AddTicks(5193));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 158,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 856, DateTimeKind.Local).AddTicks(5197));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 159,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 856, DateTimeKind.Local).AddTicks(5201));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 160,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 856, DateTimeKind.Local).AddTicks(5205));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 161,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 856, DateTimeKind.Local).AddTicks(5209));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 162,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 856, DateTimeKind.Local).AddTicks(5213));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 884, DateTimeKind.Local).AddTicks(4500));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 884, DateTimeKind.Local).AddTicks(4640));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 884, DateTimeKind.Local).AddTicks(4670));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 884, DateTimeKind.Local).AddTicks(4649));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 884, DateTimeKind.Local).AddTicks(4676));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 884, DateTimeKind.Local).AddTicks(4692));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 884, DateTimeKind.Local).AddTicks(4701));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 884, DateTimeKind.Local).AddTicks(4709));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 884, DateTimeKind.Local).AddTicks(4717));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 884, DateTimeKind.Local).AddTicks(4725));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 884, DateTimeKind.Local).AddTicks(4767));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 884, DateTimeKind.Local).AddTicks(4776));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 13,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 884, DateTimeKind.Local).AddTicks(4783));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 14,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 884, DateTimeKind.Local).AddTicks(4791));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 15,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 884, DateTimeKind.Local).AddTicks(4657));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 16,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 884, DateTimeKind.Local).AddTicks(4630));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 17,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 884, DateTimeKind.Local).AddTicks(4801));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 18,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 884, DateTimeKind.Local).AddTicks(4809));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 19,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 884, DateTimeKind.Local).AddTicks(4816));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 20,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 884, DateTimeKind.Local).AddTicks(4824));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 22,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 884, DateTimeKind.Local).AddTicks(4925));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 23,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 884, DateTimeKind.Local).AddTicks(4907));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 24,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 884, DateTimeKind.Local).AddTicks(4832));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 25,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 884, DateTimeKind.Local).AddTicks(4917));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 26,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 884, DateTimeKind.Local).AddTicks(4933));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 27,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 884, DateTimeKind.Local).AddTicks(4941));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 28,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 884, DateTimeKind.Local).AddTicks(4948));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 30,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 884, DateTimeKind.Local).AddTicks(4957));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 31,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 884, DateTimeKind.Local).AddTicks(4965));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 32,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 884, DateTimeKind.Local).AddTicks(4973));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 33,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 884, DateTimeKind.Local).AddTicks(4981));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 34,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 884, DateTimeKind.Local).AddTicks(4989));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 36,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 884, DateTimeKind.Local).AddTicks(4999));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 37,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 884, DateTimeKind.Local).AddTicks(5007));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 38,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 884, DateTimeKind.Local).AddTicks(5017));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 39,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 884, DateTimeKind.Local).AddTicks(4684));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 40,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 884, DateTimeKind.Local).AddTicks(5025));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 41,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 884, DateTimeKind.Local).AddTicks(5033));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 42,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 884, DateTimeKind.Local).AddTicks(5040));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 43,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 884, DateTimeKind.Local).AddTicks(5047));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 44,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 884, DateTimeKind.Local).AddTicks(5054));

            migrationBuilder.UpdateData(
                table: "DeductionTypes",
                keyColumn: "DeductionTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 902, DateTimeKind.Local).AddTicks(5378));

            migrationBuilder.UpdateData(
                table: "DeductionTypes",
                keyColumn: "DeductionTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 902, DateTimeKind.Local).AddTicks(5611));

            migrationBuilder.UpdateData(
                table: "DeductionTypes",
                keyColumn: "DeductionTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 902, DateTimeKind.Local).AddTicks(5624));

            migrationBuilder.UpdateData(
                table: "DocumentFormats",
                keyColumn: "DocumentFormatID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 870, DateTimeKind.Local).AddTicks(3494));

            migrationBuilder.UpdateData(
                table: "DocumentFormats",
                keyColumn: "DocumentFormatID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 870, DateTimeKind.Local).AddTicks(3712));

            migrationBuilder.UpdateData(
                table: "DocumentFormats",
                keyColumn: "DocumentFormatID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 870, DateTimeKind.Local).AddTicks(3722));

            migrationBuilder.UpdateData(
                table: "DocumentFormats",
                keyColumn: "DocumentFormatID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 870, DateTimeKind.Local).AddTicks(3727));

            migrationBuilder.UpdateData(
                table: "DocumentFormats",
                keyColumn: "DocumentFormatID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 870, DateTimeKind.Local).AddTicks(3731));

            migrationBuilder.UpdateData(
                table: "DocumentFormats",
                keyColumn: "DocumentFormatID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 870, DateTimeKind.Local).AddTicks(3737));

            migrationBuilder.UpdateData(
                table: "DocumentTypes",
                keyColumn: "DocumentTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 871, DateTimeKind.Local).AddTicks(9871));

            migrationBuilder.UpdateData(
                table: "DocumentTypes",
                keyColumn: "DocumentTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 872, DateTimeKind.Local).AddTicks(268));

            migrationBuilder.UpdateData(
                table: "DocumentTypes",
                keyColumn: "DocumentTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 872, DateTimeKind.Local).AddTicks(292));

            migrationBuilder.UpdateData(
                table: "DocumentTypes",
                keyColumn: "DocumentTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 872, DateTimeKind.Local).AddTicks(298));

            migrationBuilder.UpdateData(
                table: "EmailTemplates",
                keyColumn: "EmailTemplateID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 880, DateTimeKind.Local).AddTicks(9623));

            migrationBuilder.UpdateData(
                table: "EmailTypes",
                keyColumn: "EmailTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 880, DateTimeKind.Local).AddTicks(4159));

            migrationBuilder.UpdateData(
                table: "EmailTypes",
                keyColumn: "EmailTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 880, DateTimeKind.Local).AddTicks(4725));

            migrationBuilder.UpdateData(
                table: "EmailTypes",
                keyColumn: "EmailTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 880, DateTimeKind.Local).AddTicks(4741));

            migrationBuilder.UpdateData(
                table: "EmailTypes",
                keyColumn: "EmailTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 880, DateTimeKind.Local).AddTicks(4800));

            migrationBuilder.UpdateData(
                table: "FeatureFlags",
                keyColumn: "FeatureFlagID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 868, DateTimeKind.Local).AddTicks(7015));

            migrationBuilder.UpdateData(
                table: "FeatureFlags",
                keyColumn: "FeatureFlagID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 868, DateTimeKind.Local).AddTicks(9329));

            migrationBuilder.UpdateData(
                table: "FeatureFlags",
                keyColumn: "FeatureFlagID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 868, DateTimeKind.Local).AddTicks(9340));

            migrationBuilder.UpdateData(
                table: "Frequencies",
                keyColumn: "FrequencyID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 858, DateTimeKind.Local).AddTicks(229));

            migrationBuilder.UpdateData(
                table: "Frequencies",
                keyColumn: "FrequencyID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 858, DateTimeKind.Local).AddTicks(446));

            migrationBuilder.UpdateData(
                table: "FundSources",
                keyColumn: "FundSourceID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 906, DateTimeKind.Local).AddTicks(4994));

            migrationBuilder.UpdateData(
                table: "FundSources",
                keyColumn: "FundSourceID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 906, DateTimeKind.Local).AddTicks(5440));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "GenderID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 862, DateTimeKind.Local).AddTicks(5038));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "GenderID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 862, DateTimeKind.Local).AddTicks(5110));

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "InvoiceStatusID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 896, DateTimeKind.Local).AddTicks(4413));

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "InvoiceStatusID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 896, DateTimeKind.Local).AddTicks(4726));

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "InvoiceStatusID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 896, DateTimeKind.Local).AddTicks(4739));

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "InvoiceStatusID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 896, DateTimeKind.Local).AddTicks(4746));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 899, DateTimeKind.Local).AddTicks(9151));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 899, DateTimeKind.Local).AddTicks(9314));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 899, DateTimeKind.Local).AddTicks(9326));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 899, DateTimeKind.Local).AddTicks(9334));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 899, DateTimeKind.Local).AddTicks(9343));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 899, DateTimeKind.Local).AddTicks(9354));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 899, DateTimeKind.Local).AddTicks(9362));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 899, DateTimeKind.Local).AddTicks(9369));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 899, DateTimeKind.Local).AddTicks(9377));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 899, DateTimeKind.Local).AddTicks(9387));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 899, DateTimeKind.Local).AddTicks(9395));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 899, DateTimeKind.Local).AddTicks(9403));

            migrationBuilder.UpdateData(
                table: "Layouts",
                keyColumn: "LayoutID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 898, DateTimeKind.Local).AddTicks(6037));

            migrationBuilder.UpdateData(
                table: "Layouts",
                keyColumn: "LayoutID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 898, DateTimeKind.Local).AddTicks(6356));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 873, DateTimeKind.Local).AddTicks(8587));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 873, DateTimeKind.Local).AddTicks(8710));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 873, DateTimeKind.Local).AddTicks(8723));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 873, DateTimeKind.Local).AddTicks(8730));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 873, DateTimeKind.Local).AddTicks(8736));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 873, DateTimeKind.Local).AddTicks(8774));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 873, DateTimeKind.Local).AddTicks(8746));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 8,
                columns: new[] { "CSSClass", "DisplayName", "LastChangedDate" },
                values: new object[] { "fa search-dollar", "Konapo Fund", new DateTime(2022, 1, 15, 14, 9, 18, 873, DateTimeKind.Local).AddTicks(8753) });

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 999,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 873, DateTimeKind.Local).AddTicks(8767));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 9998,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 873, DateTimeKind.Local).AddTicks(8760));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 876, DateTimeKind.Local).AddTicks(1771));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 876, DateTimeKind.Local).AddTicks(1980));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 876, DateTimeKind.Local).AddTicks(1993));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 876, DateTimeKind.Local).AddTicks(2002));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 876, DateTimeKind.Local).AddTicks(2010));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 876, DateTimeKind.Local).AddTicks(2024));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 876, DateTimeKind.Local).AddTicks(2033));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 876, DateTimeKind.Local).AddTicks(2041));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 876, DateTimeKind.Local).AddTicks(2050));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 876, DateTimeKind.Local).AddTicks(2060));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 876, DateTimeKind.Local).AddTicks(2070));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 13,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 876, DateTimeKind.Local).AddTicks(2078));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 14,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 876, DateTimeKind.Local).AddTicks(2087));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 15,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 876, DateTimeKind.Local).AddTicks(2101));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 16,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 876, DateTimeKind.Local).AddTicks(2110));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 17,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 876, DateTimeKind.Local).AddTicks(2119));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 18,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 876, DateTimeKind.Local).AddTicks(2127));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 19,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 876, DateTimeKind.Local).AddTicks(2140));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 20,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 876, DateTimeKind.Local).AddTicks(2148));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 21,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 876, DateTimeKind.Local).AddTicks(2157));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 22,
                columns: new[] { "CSSClass", "LastChangedDate" },
                values: new object[] { "fas fa-funnel-dollar", new DateTime(2022, 1, 15, 14, 9, 18, 876, DateTimeKind.Local).AddTicks(2166) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 23,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 876, DateTimeKind.Local).AddTicks(2174));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 9994,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 876, DateTimeKind.Local).AddTicks(2183));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 9995,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 876, DateTimeKind.Local).AddTicks(2191));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 9996,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 876, DateTimeKind.Local).AddTicks(2199));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 9997,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 876, DateTimeKind.Local).AddTicks(2208));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 9998,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 876, DateTimeKind.Local).AddTicks(2216));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 9999,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 876, DateTimeKind.Local).AddTicks(2225));

            migrationBuilder.UpdateData(
                table: "PaymentStatus",
                keyColumn: "PaymentStatusID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 849, DateTimeKind.Local).AddTicks(7428));

            migrationBuilder.UpdateData(
                table: "PaymentStatus",
                keyColumn: "PaymentStatusID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 849, DateTimeKind.Local).AddTicks(7759));

            migrationBuilder.UpdateData(
                table: "PaymentStatus",
                keyColumn: "PaymentStatusID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 849, DateTimeKind.Local).AddTicks(7770));

            migrationBuilder.UpdateData(
                table: "PaymentStatus",
                keyColumn: "PaymentStatusID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 849, DateTimeKind.Local).AddTicks(7776));

            migrationBuilder.UpdateData(
                table: "PaymentStatus",
                keyColumn: "PaymentStatusID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 849, DateTimeKind.Local).AddTicks(7782));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(361));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(746));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(761));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(767));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(775));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(786));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(794));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(800));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(806));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(815));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(822));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(829));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 13,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(835));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 14,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(841));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 15,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(848));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 16,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(854));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 17,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(860));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 18,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(868));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 19,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(874));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 20,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(880));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 21,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(899));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 22,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(906));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 23,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(913));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 24,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(920));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 25,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(926));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 26,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(932));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 27,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(939));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 28,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(945));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 29,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(952));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 30,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(958));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 31,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(966));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 32,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(974));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 33,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(980));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 34,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(989));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 35,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(995));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 36,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(1002));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 37,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(1008));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 38,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(1015));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 39,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(1105));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 40,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(1113));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 41,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(1120));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 42,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(1127));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 43,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(1134));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 44,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(1141));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 45,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(1147));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 46,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(1155));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 47,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(1161));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 48,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(1168));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 49,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(1174));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 50,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(1181));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 51,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(1188));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 52,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(1194));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 53,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(1201));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 54,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(1207));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 55,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(1213));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 56,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(1219));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 57,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(1225));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 58,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(1231));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 59,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(1239));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 60,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(1245));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 61,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(1252));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 62,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(1258));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 63,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(1265));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 64,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(1271));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 65,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(1277));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 66,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(1286));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 67,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(1291));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 68,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(1298));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 69,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(1304));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 70,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(1310));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 71,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(1317));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 72,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(1322));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 73,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(1329));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 74,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(1335));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 75,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(1341));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 76,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(1347));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 77,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(1353));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 78,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(1386));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 79,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(1405));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 80,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(1514));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 81,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(1521));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 82,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(1528));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 83,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(1535));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 84,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(1542));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 85,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(1548));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 86,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(1554));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 87,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(1561));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 88,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(1567));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 89,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(1573));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 90,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(1579));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 91,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(1585));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 92,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(1591));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 93,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(1598));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 94,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(1604));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 95,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(1610));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 96,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(1617));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 97,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(1623));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 98,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(1629));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 99,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(1635));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 100,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(1642));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 101,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(1649));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 102,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(1655));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 103,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(1661));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 104,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(1667));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 105,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(1673));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 106,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(1680));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 107,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(1687));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 108,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(1694));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 109,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(1701));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 110,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(1708));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 111,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(1715));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 112,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(1722));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 113,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(1728));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 114,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(1734));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 115,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(1742));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 116,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(1749));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 117,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(1756));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 118,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(1761));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 119,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(1767));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 120,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(1773));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 121,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(1780));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 122,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(1786));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 123,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(1793));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 124,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(1799));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 125,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(1850));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 126,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(1859));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 127,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(1866));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 128,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(1872));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 129,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(1892));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 130,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(1902));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 131,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(1908));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 132,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(1916));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 133,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(1923));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 134,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(1930));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 135,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(1937));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 136,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(1944));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 137,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(1950));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 138,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(1957));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 139,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(1963));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 140,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(1968));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 141,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(1976));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 142,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(1983));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 143,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(1989));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 144,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(1995));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 145,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(2001));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 146,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(2008));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 147,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(2014));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 148,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(2020));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 149,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(2026));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 150,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(2032));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 151,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(2039));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 152,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(2045));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 153,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(2051));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 154,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(2057));

            migrationBuilder.UpdateData(
                table: "PriorityRanks",
                keyColumn: "PriorityRankID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 865, DateTimeKind.Local).AddTicks(7306));

            migrationBuilder.UpdateData(
                table: "PriorityRanks",
                keyColumn: "PriorityRankID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 865, DateTimeKind.Local).AddTicks(7584));

            migrationBuilder.UpdateData(
                table: "PriorityRanks",
                keyColumn: "PriorityRankID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 865, DateTimeKind.Local).AddTicks(7594));

            migrationBuilder.UpdateData(
                table: "PriorityRanks",
                keyColumn: "PriorityRankID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 865, DateTimeKind.Local).AddTicks(7599));

            migrationBuilder.UpdateData(
                table: "RecordStatus",
                keyColumn: "RecordStatusID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 892, DateTimeKind.Local).AddTicks(3585));

            migrationBuilder.UpdateData(
                table: "RecordStatus",
                keyColumn: "RecordStatusID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 892, DateTimeKind.Local).AddTicks(4077));

            migrationBuilder.UpdateData(
                table: "RecordStatus",
                keyColumn: "RecordStatusID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 892, DateTimeKind.Local).AddTicks(4095));

            migrationBuilder.UpdateData(
                table: "RelationshipTypes",
                keyColumn: "RelationshipTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 860, DateTimeKind.Local).AddTicks(4927));

            migrationBuilder.UpdateData(
                table: "RelationshipTypes",
                keyColumn: "RelationshipTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 860, DateTimeKind.Local).AddTicks(5212));

            migrationBuilder.UpdateData(
                table: "RelationshipTypes",
                keyColumn: "RelationshipTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 860, DateTimeKind.Local).AddTicks(5253));

            migrationBuilder.UpdateData(
                table: "RelationshipTypes",
                keyColumn: "RelationshipTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 860, DateTimeKind.Local).AddTicks(5286));

            migrationBuilder.UpdateData(
                table: "RelationshipTypes",
                keyColumn: "RelationshipTypeID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 860, DateTimeKind.Local).AddTicks(5292));

            migrationBuilder.UpdateData(
                table: "RelationshipTypes",
                keyColumn: "RelationshipTypeID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 860, DateTimeKind.Local).AddTicks(5324));

            migrationBuilder.UpdateData(
                table: "RelationshipTypes",
                keyColumn: "RelationshipTypeID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 860, DateTimeKind.Local).AddTicks(5328));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 884, DateTimeKind.Local).AddTicks(9004));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 884, DateTimeKind.Local).AddTicks(9087));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 884, DateTimeKind.Local).AddTicks(9093));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 884, DateTimeKind.Local).AddTicks(9097));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 884, DateTimeKind.Local).AddTicks(9101));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 884, DateTimeKind.Local).AddTicks(9107));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 884, DateTimeKind.Local).AddTicks(9111));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 884, DateTimeKind.Local).AddTicks(9115));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 884, DateTimeKind.Local).AddTicks(9119));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 884, DateTimeKind.Local).AddTicks(9125));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 884, DateTimeKind.Local).AddTicks(9128));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 884, DateTimeKind.Local).AddTicks(9132));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 13,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 884, DateTimeKind.Local).AddTicks(9136));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 14,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 884, DateTimeKind.Local).AddTicks(9140));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 15,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 884, DateTimeKind.Local).AddTicks(9144));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 16,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 884, DateTimeKind.Local).AddTicks(9148));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 17,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 884, DateTimeKind.Local).AddTicks(9152));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 18,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 884, DateTimeKind.Local).AddTicks(9157));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 19,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 884, DateTimeKind.Local).AddTicks(9162));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 20,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 884, DateTimeKind.Local).AddTicks(9166));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 21,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 884, DateTimeKind.Local).AddTicks(9169));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 22,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 884, DateTimeKind.Local).AddTicks(9173));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 24,
                columns: new[] { "LastChangedDate", "MenuID" },
                values: new object[] { new DateTime(2022, 1, 15, 14, 9, 18, 884, DateTimeKind.Local).AddTicks(9181), 9995 });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 25,
                columns: new[] { "LastChangedDate", "MenuID" },
                values: new object[] { new DateTime(2022, 1, 15, 14, 9, 18, 884, DateTimeKind.Local).AddTicks(9185), 9996 });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 26,
                columns: new[] { "LastChangedDate", "MenuID" },
                values: new object[] { new DateTime(2022, 1, 15, 14, 9, 18, 884, DateTimeKind.Local).AddTicks(9189), 9997 });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 27,
                columns: new[] { "LastChangedDate", "MenuID" },
                values: new object[] { new DateTime(2022, 1, 15, 14, 9, 18, 884, DateTimeKind.Local).AddTicks(9193), 9998 });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 28,
                columns: new[] { "LastChangedDate", "MenuID" },
                values: new object[] { new DateTime(2022, 1, 15, 14, 9, 18, 884, DateTimeKind.Local).AddTicks(9197), 9999 });

            migrationBuilder.InsertData(
                table: "RoleMenus",
                columns: new[] { "RoleMenuID", "LastChangedBy", "LastChangedDate", "MenuID", "RoleID" },
                values: new object[] { 23, "SuperUser", new DateTime(2022, 1, 15, 14, 9, 18, 884, DateTimeKind.Local).AddTicks(9177), 9994, 1 });

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(7955));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(8052));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(8058));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(8062));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(8067));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(8073));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(8077));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(8082));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(8086));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(8091));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(8095));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(8099));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 13,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(8104));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 14,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(8108));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 15,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(8112));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 16,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(8116));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 17,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(8120));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 18,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(8125));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 19,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(8129));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 20,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(8133));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 21,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(8137));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 22,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(8142));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 23,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(8146));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 24,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(8150));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 25,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(8153));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 26,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(8157));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 27,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(8161));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 28,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(8165));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 29,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(8168));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 30,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(8172));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 31,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(8176));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 32,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(8180));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 33,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(8183));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 34,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(8189));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 35,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(8193));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 36,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(8197));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 37,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(8201));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 38,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(8205));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 39,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(8209));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 40,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(8213));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 41,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(8217));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 42,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(8221));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 43,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(8224));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 44,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(8228));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 45,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(8232));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 46,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(8236));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 47,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(8240));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 48,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(8243));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 49,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(8247));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 50,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(8250));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 51,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(8254));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 52,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(8258));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 53,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(8262));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 54,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(8265));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 55,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(8269));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 56,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(8273));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 57,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(8277));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 58,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(8281));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 59,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(8285));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 60,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(8288));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 61,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(8292));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 62,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(8296));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 63,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(8299));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 64,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(8303));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 65,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(8307));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 66,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(8312));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 67,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(8316));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 68,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(8320));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 69,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(8323));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 70,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(8374));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 71,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(8379));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 72,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(8384));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 73,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(8388));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 74,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(8392));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 75,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(8395));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 76,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(8399));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 77,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(8403));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 78,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(8407));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 79,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(8411));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 80,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(8414));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 81,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(8418));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 82,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(8422));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 83,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(8425));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 84,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(8429));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 85,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(8433));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 86,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(8437));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 87,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(8440));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 88,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(8444));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 89,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(8448));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 90,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(8451));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 91,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(8456));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 92,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(8460));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 93,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(8464));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 94,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(8468));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 95,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(8471));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 96,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(8475));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 97,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(8479));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 98,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(8483));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 99,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(8487));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 100,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(8491));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 101,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(8494));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 102,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(8498));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 103,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(8502));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 104,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(8506));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 105,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(8510));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 106,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(8514));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 107,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(8518));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 108,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(8522));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 109,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(8526));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 110,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(8530));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 111,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(8533));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 112,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(8537));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 113,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(8541));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 114,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(8545));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 115,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(8548));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 116,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(8552));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 117,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(8556));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 118,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(8560));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 119,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(8564));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 120,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(8567));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 121,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(8571));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 122,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(8575));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 123,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(8579));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 124,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(8582));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 125,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(8586));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 126,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(8590));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 127,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(8593));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 128,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(8597));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 129,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(8601));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 130,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(8607));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 131,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(8611));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 132,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(8614));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 133,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(8618));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 134,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(8622));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 135,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(8626));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 136,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(8629));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 137,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(8633));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 138,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(8637));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 139,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(8641));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 140,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(8644));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 141,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(8648));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 142,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(8652));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 143,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(8655));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 144,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(8659));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 145,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(8664));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 146,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(8667));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 147,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(8712));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 148,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(8716));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 149,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(8720));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 150,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(8724));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 151,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(8727));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 152,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(8731));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 153,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(8735));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 154,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 847, DateTimeKind.Local).AddTicks(8739));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 838, DateTimeKind.Local).AddTicks(1914));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 842, DateTimeKind.Local).AddTicks(6141));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 842, DateTimeKind.Local).AddTicks(6212));

            migrationBuilder.UpdateData(
                table: "StatementLists",
                keyColumn: "StatementID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 888, DateTimeKind.Local).AddTicks(1201));

            migrationBuilder.UpdateData(
                table: "StatementLists",
                keyColumn: "StatementID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 888, DateTimeKind.Local).AddTicks(1471));

            migrationBuilder.UpdateData(
                table: "StatementLists",
                keyColumn: "StatementID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 888, DateTimeKind.Local).AddTicks(1517));

            migrationBuilder.UpdateData(
                table: "StatementLists",
                keyColumn: "StatementID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 888, DateTimeKind.Local).AddTicks(1522));

            migrationBuilder.UpdateData(
                table: "TechnicalSupport",
                keyColumn: "TechnicalSupportID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 904, DateTimeKind.Local).AddTicks(5182));

            migrationBuilder.UpdateData(
                table: "TechnicalSupport",
                keyColumn: "TechnicalSupportID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 904, DateTimeKind.Local).AddTicks(5864));

            migrationBuilder.UpdateData(
                table: "TechnicalSupport",
                keyColumn: "TechnicalSupportID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 904, DateTimeKind.Local).AddTicks(5875));

            migrationBuilder.UpdateData(
                table: "TechnicalSupport",
                keyColumn: "TechnicalSupportID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 904, DateTimeKind.Local).AddTicks(5882));

            migrationBuilder.UpdateData(
                table: "TechnicalSupport",
                keyColumn: "TechnicalSupportID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 904, DateTimeKind.Local).AddTicks(5890));

            migrationBuilder.UpdateData(
                table: "TechnicalSupport",
                keyColumn: "TechnicalSupportID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 904, DateTimeKind.Local).AddTicks(5901));

            migrationBuilder.UpdateData(
                table: "Titles",
                keyColumn: "TitleID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 889, DateTimeKind.Local).AddTicks(5983));

            migrationBuilder.UpdateData(
                table: "Titles",
                keyColumn: "TitleID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 889, DateTimeKind.Local).AddTicks(6268));

            migrationBuilder.UpdateData(
                table: "Titles",
                keyColumn: "TitleID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 889, DateTimeKind.Local).AddTicks(6276));

            migrationBuilder.UpdateData(
                table: "Titles",
                keyColumn: "TitleID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 889, DateTimeKind.Local).AddTicks(6282));

            migrationBuilder.UpdateData(
                table: "Titles",
                keyColumn: "TitleID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 889, DateTimeKind.Local).AddTicks(6286));

            migrationBuilder.UpdateData(
                table: "Titles",
                keyColumn: "TitleID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 889, DateTimeKind.Local).AddTicks(6293));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 852, DateTimeKind.Local).AddTicks(3014));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 852, DateTimeKind.Local).AddTicks(3681));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 852, DateTimeKind.Local).AddTicks(3770));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 852, DateTimeKind.Local).AddTicks(3852));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 852, DateTimeKind.Local).AddTicks(3923));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 852, DateTimeKind.Local).AddTicks(3997));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 852, DateTimeKind.Local).AddTicks(4062));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 852, DateTimeKind.Local).AddTicks(4121));

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumns: new[] { "UserID", "RoleID" },
                keyValues: new object[] { 1, 1 },
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 872, DateTimeKind.Local).AddTicks(3009));

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumns: new[] { "UserID", "RoleID" },
                keyValues: new object[] { 2, 3 },
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 872, DateTimeKind.Local).AddTicks(3075));

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "UserTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 859, DateTimeKind.Local).AddTicks(4983));

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "UserTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 859, DateTimeKind.Local).AddTicks(5295));

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "UserTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 859, DateTimeKind.Local).AddTicks(5304));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 866, DateTimeKind.Local).AddTicks(2132));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 867, DateTimeKind.Local).AddTicks(2173));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 867, DateTimeKind.Local).AddTicks(2352));

            migrationBuilder.UpdateData(
                table: "VariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 862, DateTimeKind.Local).AddTicks(401));

            migrationBuilder.UpdateData(
                table: "VariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 862, DateTimeKind.Local).AddTicks(695));

            migrationBuilder.UpdateData(
                table: "VariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 862, DateTimeKind.Local).AddTicks(706));

            migrationBuilder.UpdateData(
                table: "VariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 862, DateTimeKind.Local).AddTicks(712));

            migrationBuilder.UpdateData(
                table: "VariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 862, DateTimeKind.Local).AddTicks(717));

            migrationBuilder.UpdateData(
                table: "VariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 862, DateTimeKind.Local).AddTicks(727));

            migrationBuilder.UpdateData(
                table: "VariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 862, DateTimeKind.Local).AddTicks(735));

            migrationBuilder.UpdateData(
                table: "VariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 862, DateTimeKind.Local).AddTicks(740));

            migrationBuilder.UpdateData(
                table: "VariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2022, 1, 15, 14, 9, 18, 862, DateTimeKind.Local).AddTicks(746));
        }
    }
}
