using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SmartDataAccess.Migrations
{
    public partial class DropPluginsFromProductComputation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Method",
                table: "ProductComputations");

            migrationBuilder.DropColumn(
                name: "PluginName",
                table: "ProductComputations");

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "Loans",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DateFinalised",
                table: "Loans",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "FinalisedBy",
                table: "Loans",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "BankAccountTypes",
                keyColumn: "BankAccountTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 220, DateTimeKind.Local).AddTicks(4112));

            migrationBuilder.UpdateData(
                table: "BankAccountTypes",
                keyColumn: "BankAccountTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 220, DateTimeKind.Local).AddTicks(4295));

            migrationBuilder.UpdateData(
                table: "BankAccountTypes",
                keyColumn: "BankAccountTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 220, DateTimeKind.Local).AddTicks(4303));

            migrationBuilder.UpdateData(
                table: "BankAccountTypes",
                keyColumn: "BankAccountTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 220, DateTimeKind.Local).AddTicks(4306));

            migrationBuilder.UpdateData(
                table: "CalculationTypes",
                keyColumn: "CalculationTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 264, DateTimeKind.Local).AddTicks(6508));

            migrationBuilder.UpdateData(
                table: "CalculationTypes",
                keyColumn: "CalculationTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 264, DateTimeKind.Local).AddTicks(6828));

            migrationBuilder.UpdateData(
                table: "ClientAccountTypes",
                keyColumn: "ID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 245, DateTimeKind.Local).AddTicks(4873));

            migrationBuilder.UpdateData(
                table: "ClientAccountTypes",
                keyColumn: "ID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 245, DateTimeKind.Local).AddTicks(5099));

            migrationBuilder.UpdateData(
                table: "ClientGroups",
                keyColumn: "ClientGroupID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 248, DateTimeKind.Local).AddTicks(2816));

            migrationBuilder.UpdateData(
                table: "ClientGroups",
                keyColumn: "ClientGroupID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 248, DateTimeKind.Local).AddTicks(3039));

            migrationBuilder.UpdateData(
                table: "ContactTypes",
                keyColumn: "ContactTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 223, DateTimeKind.Local).AddTicks(3430));

            migrationBuilder.UpdateData(
                table: "ContactTypes",
                keyColumn: "ContactTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 223, DateTimeKind.Local).AddTicks(3425));

            migrationBuilder.UpdateData(
                table: "ContactTypes",
                keyColumn: "ContactTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 223, DateTimeKind.Local).AddTicks(3420));

            migrationBuilder.UpdateData(
                table: "ContactTypes",
                keyColumn: "ContactTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 223, DateTimeKind.Local).AddTicks(3349));

            migrationBuilder.UpdateData(
                table: "ContactTypes",
                keyColumn: "ContactTypeID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 223, DateTimeKind.Local).AddTicks(3434));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 226, DateTimeKind.Local).AddTicks(7014));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 226, DateTimeKind.Local).AddTicks(7231));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 226, DateTimeKind.Local).AddTicks(7240));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 226, DateTimeKind.Local).AddTicks(7247));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 226, DateTimeKind.Local).AddTicks(7250));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 226, DateTimeKind.Local).AddTicks(7257));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 226, DateTimeKind.Local).AddTicks(7272));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 226, DateTimeKind.Local).AddTicks(7276));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 226, DateTimeKind.Local).AddTicks(7280));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 226, DateTimeKind.Local).AddTicks(7284));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 226, DateTimeKind.Local).AddTicks(7287));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 226, DateTimeKind.Local).AddTicks(7290));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 13,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 226, DateTimeKind.Local).AddTicks(7294));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 14,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 226, DateTimeKind.Local).AddTicks(7297));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 15,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 226, DateTimeKind.Local).AddTicks(7300));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 16,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 226, DateTimeKind.Local).AddTicks(7304));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 17,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 226, DateTimeKind.Local).AddTicks(7307));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 18,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 226, DateTimeKind.Local).AddTicks(7312));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 19,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 226, DateTimeKind.Local).AddTicks(7315));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 20,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 226, DateTimeKind.Local).AddTicks(7318));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 21,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 226, DateTimeKind.Local).AddTicks(7321));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 22,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 226, DateTimeKind.Local).AddTicks(7324));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 23,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 226, DateTimeKind.Local).AddTicks(7327));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 24,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 226, DateTimeKind.Local).AddTicks(7330));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 25,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 226, DateTimeKind.Local).AddTicks(7369));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 26,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 226, DateTimeKind.Local).AddTicks(7372));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 27,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 226, DateTimeKind.Local).AddTicks(7376));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 28,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 226, DateTimeKind.Local).AddTicks(7380));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 29,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 226, DateTimeKind.Local).AddTicks(7384));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 30,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 226, DateTimeKind.Local).AddTicks(7388));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 31,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 226, DateTimeKind.Local).AddTicks(7391));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 32,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 226, DateTimeKind.Local).AddTicks(7394));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 33,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 226, DateTimeKind.Local).AddTicks(7398));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 34,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 226, DateTimeKind.Local).AddTicks(7402));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 35,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 226, DateTimeKind.Local).AddTicks(7405));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 36,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 226, DateTimeKind.Local).AddTicks(7408));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 37,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 226, DateTimeKind.Local).AddTicks(7411));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 38,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 226, DateTimeKind.Local).AddTicks(7414));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 39,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 226, DateTimeKind.Local).AddTicks(7418));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 40,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 226, DateTimeKind.Local).AddTicks(7422));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 41,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 226, DateTimeKind.Local).AddTicks(7426));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 42,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 226, DateTimeKind.Local).AddTicks(7429));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 43,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 226, DateTimeKind.Local).AddTicks(7432));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 44,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 226, DateTimeKind.Local).AddTicks(7435));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 45,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 226, DateTimeKind.Local).AddTicks(7438));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 46,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 226, DateTimeKind.Local).AddTicks(7441));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 47,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 226, DateTimeKind.Local).AddTicks(7445));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 48,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 226, DateTimeKind.Local).AddTicks(7449));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 49,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 226, DateTimeKind.Local).AddTicks(7453));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 50,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 226, DateTimeKind.Local).AddTicks(7456));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 51,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 226, DateTimeKind.Local).AddTicks(7459));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 52,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 226, DateTimeKind.Local).AddTicks(7463));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 53,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 226, DateTimeKind.Local).AddTicks(7466));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 54,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 226, DateTimeKind.Local).AddTicks(7469));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 55,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 226, DateTimeKind.Local).AddTicks(7473));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 56,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 226, DateTimeKind.Local).AddTicks(7476));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 57,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 226, DateTimeKind.Local).AddTicks(7479));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 58,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 226, DateTimeKind.Local).AddTicks(7482));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 59,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 226, DateTimeKind.Local).AddTicks(7486));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 60,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 226, DateTimeKind.Local).AddTicks(7490));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 61,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 226, DateTimeKind.Local).AddTicks(7493));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 62,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 226, DateTimeKind.Local).AddTicks(7496));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 63,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 226, DateTimeKind.Local).AddTicks(7500));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 64,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 226, DateTimeKind.Local).AddTicks(7504));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 65,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 226, DateTimeKind.Local).AddTicks(7507));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 66,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 226, DateTimeKind.Local).AddTicks(7511));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 67,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 226, DateTimeKind.Local).AddTicks(7514));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 68,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 226, DateTimeKind.Local).AddTicks(7518));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 69,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 226, DateTimeKind.Local).AddTicks(7521));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 70,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 226, DateTimeKind.Local).AddTicks(7524));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 71,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 226, DateTimeKind.Local).AddTicks(7527));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 72,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 226, DateTimeKind.Local).AddTicks(7531));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 73,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 226, DateTimeKind.Local).AddTicks(7535));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 74,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 226, DateTimeKind.Local).AddTicks(7538));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 75,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 226, DateTimeKind.Local).AddTicks(7541));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 76,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 226, DateTimeKind.Local).AddTicks(7545));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 77,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 226, DateTimeKind.Local).AddTicks(7548));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 78,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 226, DateTimeKind.Local).AddTicks(7585));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 79,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 226, DateTimeKind.Local).AddTicks(7589));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 80,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 226, DateTimeKind.Local).AddTicks(7592));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 81,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 226, DateTimeKind.Local).AddTicks(7596));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 82,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 226, DateTimeKind.Local).AddTicks(7599));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 83,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 226, DateTimeKind.Local).AddTicks(7602));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 84,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 226, DateTimeKind.Local).AddTicks(7605));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 85,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 226, DateTimeKind.Local).AddTicks(7608));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 86,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 226, DateTimeKind.Local).AddTicks(7611));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 87,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 226, DateTimeKind.Local).AddTicks(7614));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 88,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 226, DateTimeKind.Local).AddTicks(7617));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 89,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 226, DateTimeKind.Local).AddTicks(7621));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 90,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 226, DateTimeKind.Local).AddTicks(7624));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 91,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 226, DateTimeKind.Local).AddTicks(7627));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 92,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 226, DateTimeKind.Local).AddTicks(7630));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 93,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 226, DateTimeKind.Local).AddTicks(7633));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 94,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 226, DateTimeKind.Local).AddTicks(7637));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 95,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 226, DateTimeKind.Local).AddTicks(7640));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 96,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 226, DateTimeKind.Local).AddTicks(7643));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 97,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 226, DateTimeKind.Local).AddTicks(7646));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 98,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 226, DateTimeKind.Local).AddTicks(7649));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 99,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 226, DateTimeKind.Local).AddTicks(7652));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 100,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 226, DateTimeKind.Local).AddTicks(7655));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 101,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 226, DateTimeKind.Local).AddTicks(7658));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 102,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 226, DateTimeKind.Local).AddTicks(7661));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 103,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 226, DateTimeKind.Local).AddTicks(7664));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 104,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 226, DateTimeKind.Local).AddTicks(7667));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 105,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 226, DateTimeKind.Local).AddTicks(7671));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 106,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 226, DateTimeKind.Local).AddTicks(7674));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 107,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 226, DateTimeKind.Local).AddTicks(7677));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 108,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 226, DateTimeKind.Local).AddTicks(7680));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 109,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 226, DateTimeKind.Local).AddTicks(7683));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 110,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 226, DateTimeKind.Local).AddTicks(7686));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 111,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 226, DateTimeKind.Local).AddTicks(7689));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 112,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 226, DateTimeKind.Local).AddTicks(7693));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 113,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 226, DateTimeKind.Local).AddTicks(7696));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 114,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 226, DateTimeKind.Local).AddTicks(7699));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 115,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 226, DateTimeKind.Local).AddTicks(7703));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 116,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 226, DateTimeKind.Local).AddTicks(7706));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 117,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 226, DateTimeKind.Local).AddTicks(7709));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 118,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 226, DateTimeKind.Local).AddTicks(7712));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 119,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 226, DateTimeKind.Local).AddTicks(7715));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 120,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 226, DateTimeKind.Local).AddTicks(7718));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 121,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 226, DateTimeKind.Local).AddTicks(7722));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 122,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 226, DateTimeKind.Local).AddTicks(7725));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 123,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 226, DateTimeKind.Local).AddTicks(7728));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 124,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 226, DateTimeKind.Local).AddTicks(7731));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 125,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 226, DateTimeKind.Local).AddTicks(7734));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 126,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 226, DateTimeKind.Local).AddTicks(7737));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 127,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 226, DateTimeKind.Local).AddTicks(7741));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 128,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 226, DateTimeKind.Local).AddTicks(7743));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 129,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 226, DateTimeKind.Local).AddTicks(7747));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 130,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 226, DateTimeKind.Local).AddTicks(7751));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 131,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 226, DateTimeKind.Local).AddTicks(7754));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 132,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 226, DateTimeKind.Local).AddTicks(7758));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 133,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 226, DateTimeKind.Local).AddTicks(7761));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 134,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 226, DateTimeKind.Local).AddTicks(7810));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 135,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 226, DateTimeKind.Local).AddTicks(7814));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 136,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 226, DateTimeKind.Local).AddTicks(7818));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 137,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 226, DateTimeKind.Local).AddTicks(7821));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 138,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 226, DateTimeKind.Local).AddTicks(7825));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 139,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 226, DateTimeKind.Local).AddTicks(7828));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 140,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 226, DateTimeKind.Local).AddTicks(7831));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 141,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 226, DateTimeKind.Local).AddTicks(7834));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 142,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 226, DateTimeKind.Local).AddTicks(7837));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 143,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 226, DateTimeKind.Local).AddTicks(7840));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 144,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 226, DateTimeKind.Local).AddTicks(7843));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 145,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 226, DateTimeKind.Local).AddTicks(7846));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 146,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 226, DateTimeKind.Local).AddTicks(7850));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 147,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 226, DateTimeKind.Local).AddTicks(7853));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 148,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 226, DateTimeKind.Local).AddTicks(7856));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 149,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 226, DateTimeKind.Local).AddTicks(7860));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 150,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 226, DateTimeKind.Local).AddTicks(7863));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 151,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 226, DateTimeKind.Local).AddTicks(7867));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 152,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 226, DateTimeKind.Local).AddTicks(7871));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 153,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 226, DateTimeKind.Local).AddTicks(7874));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 154,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 226, DateTimeKind.Local).AddTicks(7877));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 155,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 226, DateTimeKind.Local).AddTicks(7881));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 156,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 226, DateTimeKind.Local).AddTicks(7884));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 157,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 226, DateTimeKind.Local).AddTicks(7887));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 158,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 226, DateTimeKind.Local).AddTicks(7890));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 159,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 226, DateTimeKind.Local).AddTicks(7894));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 160,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 226, DateTimeKind.Local).AddTicks(7897));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 161,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 226, DateTimeKind.Local).AddTicks(7901));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 162,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 226, DateTimeKind.Local).AddTicks(7904));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 163,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 226, DateTimeKind.Local).AddTicks(7907));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 164,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 226, DateTimeKind.Local).AddTicks(7910));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 165,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 226, DateTimeKind.Local).AddTicks(7913));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 166,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 226, DateTimeKind.Local).AddTicks(7916));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 167,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 226, DateTimeKind.Local).AddTicks(7920));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 168,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 226, DateTimeKind.Local).AddTicks(7923));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 169,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 226, DateTimeKind.Local).AddTicks(7926));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 170,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 226, DateTimeKind.Local).AddTicks(7929));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 171,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 226, DateTimeKind.Local).AddTicks(7932));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 172,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 226, DateTimeKind.Local).AddTicks(7936));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 173,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 226, DateTimeKind.Local).AddTicks(7940));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 174,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 226, DateTimeKind.Local).AddTicks(7944));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 175,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 226, DateTimeKind.Local).AddTicks(7947));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 176,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 226, DateTimeKind.Local).AddTicks(7951));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 177,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 226, DateTimeKind.Local).AddTicks(7956));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 178,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 226, DateTimeKind.Local).AddTicks(7959));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 179,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 226, DateTimeKind.Local).AddTicks(7963));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 180,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 226, DateTimeKind.Local).AddTicks(7967));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 181,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 226, DateTimeKind.Local).AddTicks(7971));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 182,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 226, DateTimeKind.Local).AddTicks(7974));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 183,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 226, DateTimeKind.Local).AddTicks(7977));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 184,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 226, DateTimeKind.Local).AddTicks(7980));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 185,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 226, DateTimeKind.Local).AddTicks(7983));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 186,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 226, DateTimeKind.Local).AddTicks(7987));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 187,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 226, DateTimeKind.Local).AddTicks(7990));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 188,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 226, DateTimeKind.Local).AddTicks(7993));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 189,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 226, DateTimeKind.Local).AddTicks(7997));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 190,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 226, DateTimeKind.Local).AddTicks(8000));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 191,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 226, DateTimeKind.Local).AddTicks(8003));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 192,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 226, DateTimeKind.Local).AddTicks(8006));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 193,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 226, DateTimeKind.Local).AddTicks(8009));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 194,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 226, DateTimeKind.Local).AddTicks(8013));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 195,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 226, DateTimeKind.Local).AddTicks(8016));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 196,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 226, DateTimeKind.Local).AddTicks(8019));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 197,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 226, DateTimeKind.Local).AddTicks(8022));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 198,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 226, DateTimeKind.Local).AddTicks(8025));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 199,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 226, DateTimeKind.Local).AddTicks(8028));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 200,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 226, DateTimeKind.Local).AddTicks(8031));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 201,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 226, DateTimeKind.Local).AddTicks(8035));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 202,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 226, DateTimeKind.Local).AddTicks(8091));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 203,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 226, DateTimeKind.Local).AddTicks(8095));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 204,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 226, DateTimeKind.Local).AddTicks(8098));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 205,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 226, DateTimeKind.Local).AddTicks(8101));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 206,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 226, DateTimeKind.Local).AddTicks(8105));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 207,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 226, DateTimeKind.Local).AddTicks(8108));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 208,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 226, DateTimeKind.Local).AddTicks(8111));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 209,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 226, DateTimeKind.Local).AddTicks(8114));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 210,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 226, DateTimeKind.Local).AddTicks(8118));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 211,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 226, DateTimeKind.Local).AddTicks(8121));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 212,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 226, DateTimeKind.Local).AddTicks(8124));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 213,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 226, DateTimeKind.Local).AddTicks(8128));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 214,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 226, DateTimeKind.Local).AddTicks(8131));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 215,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 226, DateTimeKind.Local).AddTicks(8135));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 216,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 226, DateTimeKind.Local).AddTicks(8138));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 217,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 226, DateTimeKind.Local).AddTicks(8141));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 218,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 226, DateTimeKind.Local).AddTicks(8145));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 219,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 226, DateTimeKind.Local).AddTicks(8148));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 220,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 226, DateTimeKind.Local).AddTicks(8151));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 221,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 226, DateTimeKind.Local).AddTicks(8154));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 222,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 226, DateTimeKind.Local).AddTicks(8157));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 223,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 226, DateTimeKind.Local).AddTicks(8161));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 224,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 226, DateTimeKind.Local).AddTicks(8164));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 225,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 226, DateTimeKind.Local).AddTicks(8167));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 226,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 226, DateTimeKind.Local).AddTicks(8171));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 227,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 226, DateTimeKind.Local).AddTicks(8174));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 228,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 226, DateTimeKind.Local).AddTicks(8177));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 221, DateTimeKind.Local).AddTicks(6525));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 221, DateTimeKind.Local).AddTicks(6741));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 221, DateTimeKind.Local).AddTicks(6749));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 221, DateTimeKind.Local).AddTicks(6755));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 221, DateTimeKind.Local).AddTicks(6758));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 221, DateTimeKind.Local).AddTicks(6775));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 221, DateTimeKind.Local).AddTicks(6779));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 221, DateTimeKind.Local).AddTicks(6783));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 221, DateTimeKind.Local).AddTicks(6786));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 221, DateTimeKind.Local).AddTicks(6791));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 221, DateTimeKind.Local).AddTicks(6794));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 221, DateTimeKind.Local).AddTicks(6798));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 13,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 221, DateTimeKind.Local).AddTicks(6801));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 14,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 221, DateTimeKind.Local).AddTicks(6805));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 15,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 221, DateTimeKind.Local).AddTicks(6808));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 16,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 221, DateTimeKind.Local).AddTicks(6812));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 17,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 221, DateTimeKind.Local).AddTicks(6816));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 18,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 221, DateTimeKind.Local).AddTicks(6820));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 19,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 221, DateTimeKind.Local).AddTicks(6824));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 20,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 221, DateTimeKind.Local).AddTicks(6828));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 21,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 221, DateTimeKind.Local).AddTicks(6831));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 22,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 221, DateTimeKind.Local).AddTicks(6835));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 23,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 221, DateTimeKind.Local).AddTicks(6838));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 24,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 221, DateTimeKind.Local).AddTicks(6842));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 25,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 221, DateTimeKind.Local).AddTicks(6845));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 26,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 221, DateTimeKind.Local).AddTicks(6849));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 27,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 221, DateTimeKind.Local).AddTicks(6852));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 28,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 221, DateTimeKind.Local).AddTicks(6856));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 29,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 221, DateTimeKind.Local).AddTicks(6859));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 30,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 221, DateTimeKind.Local).AddTicks(6863));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 31,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 221, DateTimeKind.Local).AddTicks(6867));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 32,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 221, DateTimeKind.Local).AddTicks(6870));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 33,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 221, DateTimeKind.Local).AddTicks(6874));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 34,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 221, DateTimeKind.Local).AddTicks(6907));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 35,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 221, DateTimeKind.Local).AddTicks(6910));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 36,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 221, DateTimeKind.Local).AddTicks(6915));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 37,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 221, DateTimeKind.Local).AddTicks(6918));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 38,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 221, DateTimeKind.Local).AddTicks(6922));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 39,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 221, DateTimeKind.Local).AddTicks(6926));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 40,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 221, DateTimeKind.Local).AddTicks(6929));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 41,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 221, DateTimeKind.Local).AddTicks(6934));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 42,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 221, DateTimeKind.Local).AddTicks(6937));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 43,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 221, DateTimeKind.Local).AddTicks(6941));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 44,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 221, DateTimeKind.Local).AddTicks(6945));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 45,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 221, DateTimeKind.Local).AddTicks(6949));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 46,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 221, DateTimeKind.Local).AddTicks(6953));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 47,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 221, DateTimeKind.Local).AddTicks(6956));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 48,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 221, DateTimeKind.Local).AddTicks(6960));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 49,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 221, DateTimeKind.Local).AddTicks(6964));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 50,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 221, DateTimeKind.Local).AddTicks(6967));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 51,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 221, DateTimeKind.Local).AddTicks(6972));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 52,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 221, DateTimeKind.Local).AddTicks(6975));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 53,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 221, DateTimeKind.Local).AddTicks(6979));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 54,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 221, DateTimeKind.Local).AddTicks(6982));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 55,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 221, DateTimeKind.Local).AddTicks(6986));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 56,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 221, DateTimeKind.Local).AddTicks(6990));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 57,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 221, DateTimeKind.Local).AddTicks(6994));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 58,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 221, DateTimeKind.Local).AddTicks(6997));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 59,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 221, DateTimeKind.Local).AddTicks(7001));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 60,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 221, DateTimeKind.Local).AddTicks(7004));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 61,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 221, DateTimeKind.Local).AddTicks(7008));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 62,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 221, DateTimeKind.Local).AddTicks(7012));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 63,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 221, DateTimeKind.Local).AddTicks(7016));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 64,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 221, DateTimeKind.Local).AddTicks(7019));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 65,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 221, DateTimeKind.Local).AddTicks(7023));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 66,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 221, DateTimeKind.Local).AddTicks(7028));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 67,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 221, DateTimeKind.Local).AddTicks(7032));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 68,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 221, DateTimeKind.Local).AddTicks(7035));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 69,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 221, DateTimeKind.Local).AddTicks(7039));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 70,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 221, DateTimeKind.Local).AddTicks(7042));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 71,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 221, DateTimeKind.Local).AddTicks(7046));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 72,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 221, DateTimeKind.Local).AddTicks(7049));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 73,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 221, DateTimeKind.Local).AddTicks(7053));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 74,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 221, DateTimeKind.Local).AddTicks(7056));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 75,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 221, DateTimeKind.Local).AddTicks(7060));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 76,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 221, DateTimeKind.Local).AddTicks(7064));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 77,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 221, DateTimeKind.Local).AddTicks(7068));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 78,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 221, DateTimeKind.Local).AddTicks(7071));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 79,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 221, DateTimeKind.Local).AddTicks(7075));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 80,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 221, DateTimeKind.Local).AddTicks(7079));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 81,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 221, DateTimeKind.Local).AddTicks(7082));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 82,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 221, DateTimeKind.Local).AddTicks(7086));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 83,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 221, DateTimeKind.Local).AddTicks(7090));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 84,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 221, DateTimeKind.Local).AddTicks(7094));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 85,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 221, DateTimeKind.Local).AddTicks(7098));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 86,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 221, DateTimeKind.Local).AddTicks(7101));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 87,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 221, DateTimeKind.Local).AddTicks(7105));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 88,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 221, DateTimeKind.Local).AddTicks(7108));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 89,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 221, DateTimeKind.Local).AddTicks(7112));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 90,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 221, DateTimeKind.Local).AddTicks(7116));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 91,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 221, DateTimeKind.Local).AddTicks(7119));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 92,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 221, DateTimeKind.Local).AddTicks(7123));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 93,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 221, DateTimeKind.Local).AddTicks(7126));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 94,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 221, DateTimeKind.Local).AddTicks(7130));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 95,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 221, DateTimeKind.Local).AddTicks(7134));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 96,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 221, DateTimeKind.Local).AddTicks(7137));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 97,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 221, DateTimeKind.Local).AddTicks(7141));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 98,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 221, DateTimeKind.Local).AddTicks(7145));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 99,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 221, DateTimeKind.Local).AddTicks(7171));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 100,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 221, DateTimeKind.Local).AddTicks(7175));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 101,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 221, DateTimeKind.Local).AddTicks(7178));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 102,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 221, DateTimeKind.Local).AddTicks(7182));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 103,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 221, DateTimeKind.Local).AddTicks(7186));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 104,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 221, DateTimeKind.Local).AddTicks(7190));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 105,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 221, DateTimeKind.Local).AddTicks(7194));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 106,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 221, DateTimeKind.Local).AddTicks(7197));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 107,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 221, DateTimeKind.Local).AddTicks(7201));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 108,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 221, DateTimeKind.Local).AddTicks(7204));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 109,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 221, DateTimeKind.Local).AddTicks(7208));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 110,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 221, DateTimeKind.Local).AddTicks(7211));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 111,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 221, DateTimeKind.Local).AddTicks(7215));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 112,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 221, DateTimeKind.Local).AddTicks(7219));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 113,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 221, DateTimeKind.Local).AddTicks(7222));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 114,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 221, DateTimeKind.Local).AddTicks(7226));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 115,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 221, DateTimeKind.Local).AddTicks(7230));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 116,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 221, DateTimeKind.Local).AddTicks(7233));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 117,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 221, DateTimeKind.Local).AddTicks(7237));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 118,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 221, DateTimeKind.Local).AddTicks(7240));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 119,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 221, DateTimeKind.Local).AddTicks(7244));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 120,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 221, DateTimeKind.Local).AddTicks(7247));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 121,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 221, DateTimeKind.Local).AddTicks(7251));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 122,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 221, DateTimeKind.Local).AddTicks(7254));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 123,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 221, DateTimeKind.Local).AddTicks(7259));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 124,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 221, DateTimeKind.Local).AddTicks(7262));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 125,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 221, DateTimeKind.Local).AddTicks(7266));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 126,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 221, DateTimeKind.Local).AddTicks(7269));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 127,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 221, DateTimeKind.Local).AddTicks(7273));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 128,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 221, DateTimeKind.Local).AddTicks(7276));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 129,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 221, DateTimeKind.Local).AddTicks(7280));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 130,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 221, DateTimeKind.Local).AddTicks(7285));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 131,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 221, DateTimeKind.Local).AddTicks(7289));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 132,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 221, DateTimeKind.Local).AddTicks(7292));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 133,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 221, DateTimeKind.Local).AddTicks(7296));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 134,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 221, DateTimeKind.Local).AddTicks(7299));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 135,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 221, DateTimeKind.Local).AddTicks(7303));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 136,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 221, DateTimeKind.Local).AddTicks(7307));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 137,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 221, DateTimeKind.Local).AddTicks(7310));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 138,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 221, DateTimeKind.Local).AddTicks(7314));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 139,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 221, DateTimeKind.Local).AddTicks(7318));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 140,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 221, DateTimeKind.Local).AddTicks(7321));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 141,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 221, DateTimeKind.Local).AddTicks(7325));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 142,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 221, DateTimeKind.Local).AddTicks(7329));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 143,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 221, DateTimeKind.Local).AddTicks(7333));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 144,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 221, DateTimeKind.Local).AddTicks(7336));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 145,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 221, DateTimeKind.Local).AddTicks(7340));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 146,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 221, DateTimeKind.Local).AddTicks(7344));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 147,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 221, DateTimeKind.Local).AddTicks(7347));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 148,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 221, DateTimeKind.Local).AddTicks(7351));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 149,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 221, DateTimeKind.Local).AddTicks(7355));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 150,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 221, DateTimeKind.Local).AddTicks(7358));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 151,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 221, DateTimeKind.Local).AddTicks(7362));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 152,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 221, DateTimeKind.Local).AddTicks(7365));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 153,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 221, DateTimeKind.Local).AddTicks(7369));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 154,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 221, DateTimeKind.Local).AddTicks(7373));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 155,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 221, DateTimeKind.Local).AddTicks(7376));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 156,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 221, DateTimeKind.Local).AddTicks(7380));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 157,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 221, DateTimeKind.Local).AddTicks(7406));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 158,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 221, DateTimeKind.Local).AddTicks(7410));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 159,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 221, DateTimeKind.Local).AddTicks(7414));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 160,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 221, DateTimeKind.Local).AddTicks(7418));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 161,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 221, DateTimeKind.Local).AddTicks(7421));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 162,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 221, DateTimeKind.Local).AddTicks(7425));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 239, DateTimeKind.Local).AddTicks(9151));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 239, DateTimeKind.Local).AddTicks(9259));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 239, DateTimeKind.Local).AddTicks(9277));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 239, DateTimeKind.Local).AddTicks(9264));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 239, DateTimeKind.Local).AddTicks(9281));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 239, DateTimeKind.Local).AddTicks(9291));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 239, DateTimeKind.Local).AddTicks(9297));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 239, DateTimeKind.Local).AddTicks(9302));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 239, DateTimeKind.Local).AddTicks(9307));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 239, DateTimeKind.Local).AddTicks(9312));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 239, DateTimeKind.Local).AddTicks(9343));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 239, DateTimeKind.Local).AddTicks(9348));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 13,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 239, DateTimeKind.Local).AddTicks(9353));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 14,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 239, DateTimeKind.Local).AddTicks(9358));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 15,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 239, DateTimeKind.Local).AddTicks(9269));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 16,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 239, DateTimeKind.Local).AddTicks(9253));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 17,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 239, DateTimeKind.Local).AddTicks(9363));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 18,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 239, DateTimeKind.Local).AddTicks(9368));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 19,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 239, DateTimeKind.Local).AddTicks(9373));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 20,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 239, DateTimeKind.Local).AddTicks(9378));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 22,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 239, DateTimeKind.Local).AddTicks(9432));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 23,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 239, DateTimeKind.Local).AddTicks(9422));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 24,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 239, DateTimeKind.Local).AddTicks(9383));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 25,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 239, DateTimeKind.Local).AddTicks(9428));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 26,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 239, DateTimeKind.Local).AddTicks(9437));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 27,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 239, DateTimeKind.Local).AddTicks(9442));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 28,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 239, DateTimeKind.Local).AddTicks(9446));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 30,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 239, DateTimeKind.Local).AddTicks(9451));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 31,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 239, DateTimeKind.Local).AddTicks(9455));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 32,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 239, DateTimeKind.Local).AddTicks(9460));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 33,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 239, DateTimeKind.Local).AddTicks(9464));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 34,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 239, DateTimeKind.Local).AddTicks(9469));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 36,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 239, DateTimeKind.Local).AddTicks(9474));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 37,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 239, DateTimeKind.Local).AddTicks(9479));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 38,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 239, DateTimeKind.Local).AddTicks(9484));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 39,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 239, DateTimeKind.Local).AddTicks(9286));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 40,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 239, DateTimeKind.Local).AddTicks(9489));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 41,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 239, DateTimeKind.Local).AddTicks(9494));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 42,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 239, DateTimeKind.Local).AddTicks(9498));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 43,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 239, DateTimeKind.Local).AddTicks(9502));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 44,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 239, DateTimeKind.Local).AddTicks(9506));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 45,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 239, DateTimeKind.Local).AddTicks(9511));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 46,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 239, DateTimeKind.Local).AddTicks(9515));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 47,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 239, DateTimeKind.Local).AddTicks(9520));

            migrationBuilder.UpdateData(
                table: "DeductionTypes",
                keyColumn: "DeductionTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 254, DateTimeKind.Local).AddTicks(3154));

            migrationBuilder.UpdateData(
                table: "DeductionTypes",
                keyColumn: "DeductionTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 254, DateTimeKind.Local).AddTicks(3332));

            migrationBuilder.UpdateData(
                table: "DeductionTypes",
                keyColumn: "DeductionTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 254, DateTimeKind.Local).AddTicks(3343));

            migrationBuilder.UpdateData(
                table: "DocumentFormats",
                keyColumn: "DocumentFormatID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 231, DateTimeKind.Local).AddTicks(5466));

            migrationBuilder.UpdateData(
                table: "DocumentFormats",
                keyColumn: "DocumentFormatID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 231, DateTimeKind.Local).AddTicks(5640));

            migrationBuilder.UpdateData(
                table: "DocumentFormats",
                keyColumn: "DocumentFormatID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 231, DateTimeKind.Local).AddTicks(5647));

            migrationBuilder.UpdateData(
                table: "DocumentFormats",
                keyColumn: "DocumentFormatID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 231, DateTimeKind.Local).AddTicks(5652));

            migrationBuilder.UpdateData(
                table: "DocumentFormats",
                keyColumn: "DocumentFormatID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 231, DateTimeKind.Local).AddTicks(5655));

            migrationBuilder.UpdateData(
                table: "DocumentFormats",
                keyColumn: "DocumentFormatID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 231, DateTimeKind.Local).AddTicks(5662));

            migrationBuilder.UpdateData(
                table: "DocumentTypes",
                keyColumn: "DocumentTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 233, DateTimeKind.Local).AddTicks(88));

            migrationBuilder.UpdateData(
                table: "DocumentTypes",
                keyColumn: "DocumentTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 233, DateTimeKind.Local).AddTicks(407));

            migrationBuilder.UpdateData(
                table: "DocumentTypes",
                keyColumn: "DocumentTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 233, DateTimeKind.Local).AddTicks(424));

            migrationBuilder.UpdateData(
                table: "DocumentTypes",
                keyColumn: "DocumentTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 233, DateTimeKind.Local).AddTicks(429));

            migrationBuilder.UpdateData(
                table: "EmailTemplates",
                keyColumn: "EmailTemplateID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 237, DateTimeKind.Local).AddTicks(6153));

            migrationBuilder.UpdateData(
                table: "EmailTypes",
                keyColumn: "EmailTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 237, DateTimeKind.Local).AddTicks(3819));

            migrationBuilder.UpdateData(
                table: "EmailTypes",
                keyColumn: "EmailTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 237, DateTimeKind.Local).AddTicks(4009));

            migrationBuilder.UpdateData(
                table: "EmailTypes",
                keyColumn: "EmailTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 237, DateTimeKind.Local).AddTicks(4018));

            migrationBuilder.UpdateData(
                table: "EmailTypes",
                keyColumn: "EmailTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 237, DateTimeKind.Local).AddTicks(4023));

            migrationBuilder.UpdateData(
                table: "FeatureFlags",
                keyColumn: "FeatureFlagID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 230, DateTimeKind.Local).AddTicks(1799));

            migrationBuilder.UpdateData(
                table: "FeatureFlags",
                keyColumn: "FeatureFlagID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 230, DateTimeKind.Local).AddTicks(2010));

            migrationBuilder.UpdateData(
                table: "FeatureFlags",
                keyColumn: "FeatureFlagID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 230, DateTimeKind.Local).AddTicks(2020));

            migrationBuilder.UpdateData(
                table: "Fees",
                keyColumn: "FeeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 265, DateTimeKind.Local).AddTicks(9481));

            migrationBuilder.UpdateData(
                table: "Fees",
                keyColumn: "FeeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 265, DateTimeKind.Local).AddTicks(9869));

            migrationBuilder.UpdateData(
                table: "Fees",
                keyColumn: "FeeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 265, DateTimeKind.Local).AddTicks(9888));

            migrationBuilder.UpdateData(
                table: "Fees",
                keyColumn: "FeeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 265, DateTimeKind.Local).AddTicks(9894));

            migrationBuilder.UpdateData(
                table: "Fees",
                keyColumn: "FeeID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 265, DateTimeKind.Local).AddTicks(9899));

            migrationBuilder.UpdateData(
                table: "Fees",
                keyColumn: "FeeID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 265, DateTimeKind.Local).AddTicks(9906));

            migrationBuilder.UpdateData(
                table: "Fees",
                keyColumn: "FeeID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 265, DateTimeKind.Local).AddTicks(9910));

            migrationBuilder.UpdateData(
                table: "Fees",
                keyColumn: "FeeID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 265, DateTimeKind.Local).AddTicks(9915));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "GenderID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 225, DateTimeKind.Local).AddTicks(4179));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "GenderID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 225, DateTimeKind.Local).AddTicks(4241));

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "InvoiceStatusID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 249, DateTimeKind.Local).AddTicks(9051));

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "InvoiceStatusID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 249, DateTimeKind.Local).AddTicks(9266));

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "InvoiceStatusID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 249, DateTimeKind.Local).AddTicks(9273));

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "InvoiceStatusID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 249, DateTimeKind.Local).AddTicks(9278));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 252, DateTimeKind.Local).AddTicks(9480));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 252, DateTimeKind.Local).AddTicks(9573));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 252, DateTimeKind.Local).AddTicks(9578));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 252, DateTimeKind.Local).AddTicks(9583));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 252, DateTimeKind.Local).AddTicks(9586));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 252, DateTimeKind.Local).AddTicks(9593));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 252, DateTimeKind.Local).AddTicks(9597));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 252, DateTimeKind.Local).AddTicks(9601));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 252, DateTimeKind.Local).AddTicks(9605));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 252, DateTimeKind.Local).AddTicks(9750));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 252, DateTimeKind.Local).AddTicks(9901));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 13,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 252, DateTimeKind.Local).AddTicks(9905));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 14,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 252, DateTimeKind.Local).AddTicks(9909));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 15,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 252, DateTimeKind.Local).AddTicks(9913));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 16,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 252, DateTimeKind.Local).AddTicks(9917));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 17,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 252, DateTimeKind.Local).AddTicks(9922));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 18,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 252, DateTimeKind.Local).AddTicks(9925));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 19,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 252, DateTimeKind.Local).AddTicks(9931));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 20,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 252, DateTimeKind.Local).AddTicks(9935));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 21,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 252, DateTimeKind.Local).AddTicks(9939));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 22,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 252, DateTimeKind.Local).AddTicks(9943));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 23,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 252, DateTimeKind.Local).AddTicks(9947));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 24,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 252, DateTimeKind.Local).AddTicks(9951));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 25,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 252, DateTimeKind.Local).AddTicks(9955));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 26,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 252, DateTimeKind.Local).AddTicks(9959));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 27,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 252, DateTimeKind.Local).AddTicks(9963));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 28,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 252, DateTimeKind.Local).AddTicks(9967));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 29,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 252, DateTimeKind.Local).AddTicks(9971));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 30,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 252, DateTimeKind.Local).AddTicks(9975));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 31,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 252, DateTimeKind.Local).AddTicks(9979));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 32,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 252, DateTimeKind.Local).AddTicks(9982));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 33,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 252, DateTimeKind.Local).AddTicks(9986));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 34,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 252, DateTimeKind.Local).AddTicks(9990));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 35,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 252, DateTimeKind.Local).AddTicks(9995));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 36,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 253, DateTimeKind.Local).AddTicks(33));

            migrationBuilder.UpdateData(
                table: "Layouts",
                keyColumn: "LayoutID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 251, DateTimeKind.Local).AddTicks(2024));

            migrationBuilder.UpdateData(
                table: "Layouts",
                keyColumn: "LayoutID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 251, DateTimeKind.Local).AddTicks(2207));

            migrationBuilder.UpdateData(
                table: "Layouts",
                keyColumn: "LayoutID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 251, DateTimeKind.Local).AddTicks(2216));

            migrationBuilder.UpdateData(
                table: "Layouts",
                keyColumn: "LayoutID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 251, DateTimeKind.Local).AddTicks(2220));

            migrationBuilder.UpdateData(
                table: "Layouts",
                keyColumn: "LayoutID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 251, DateTimeKind.Local).AddTicks(2224));

            migrationBuilder.UpdateData(
                table: "Layouts",
                keyColumn: "LayoutID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 251, DateTimeKind.Local).AddTicks(2231));

            migrationBuilder.UpdateData(
                table: "Layouts",
                keyColumn: "LayoutID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 251, DateTimeKind.Local).AddTicks(2235));

            migrationBuilder.UpdateData(
                table: "LoanStatus",
                keyColumn: "LoanStatusID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 263, DateTimeKind.Local).AddTicks(2918));

            migrationBuilder.UpdateData(
                table: "LoanStatus",
                keyColumn: "LoanStatusID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 263, DateTimeKind.Local).AddTicks(3299));

            migrationBuilder.UpdateData(
                table: "LoanStatus",
                keyColumn: "LoanStatusID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 263, DateTimeKind.Local).AddTicks(3320));

            migrationBuilder.UpdateData(
                table: "LoanStatus",
                keyColumn: "LoanStatusID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 263, DateTimeKind.Local).AddTicks(3325));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 234, DateTimeKind.Local).AddTicks(929));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 234, DateTimeKind.Local).AddTicks(1020));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 234, DateTimeKind.Local).AddTicks(1026));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 234, DateTimeKind.Local).AddTicks(1030));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 234, DateTimeKind.Local).AddTicks(1034));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 234, DateTimeKind.Local).AddTicks(1056));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 234, DateTimeKind.Local).AddTicks(1041));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 999,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 234, DateTimeKind.Local).AddTicks(1052));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 9998,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 234, DateTimeKind.Local).AddTicks(1045));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 234, DateTimeKind.Local).AddTicks(7206));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 234, DateTimeKind.Local).AddTicks(7429));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 234, DateTimeKind.Local).AddTicks(7434));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 234, DateTimeKind.Local).AddTicks(7438));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 234, DateTimeKind.Local).AddTicks(7441));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 234, DateTimeKind.Local).AddTicks(7447));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 234, DateTimeKind.Local).AddTicks(7450));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 9994,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 234, DateTimeKind.Local).AddTicks(7453));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 9995,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 234, DateTimeKind.Local).AddTicks(7457));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 9996,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 234, DateTimeKind.Local).AddTicks(7461));

            migrationBuilder.UpdateData(
                table: "PaymentStatus",
                keyColumn: "PaymentStatusID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 217, DateTimeKind.Local).AddTicks(4547));

            migrationBuilder.UpdateData(
                table: "PaymentStatus",
                keyColumn: "PaymentStatusID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 217, DateTimeKind.Local).AddTicks(4763));

            migrationBuilder.UpdateData(
                table: "PaymentStatus",
                keyColumn: "PaymentStatusID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 217, DateTimeKind.Local).AddTicks(4771));

            migrationBuilder.UpdateData(
                table: "PaymentStatus",
                keyColumn: "PaymentStatusID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 217, DateTimeKind.Local).AddTicks(4774));

            migrationBuilder.UpdateData(
                table: "PaymentStatus",
                keyColumn: "PaymentStatusID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 217, DateTimeKind.Local).AddTicks(4778));

            migrationBuilder.UpdateData(
                table: "PenaltyTypes",
                keyColumn: "PenaltyTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 261, DateTimeKind.Local).AddTicks(7406));

            migrationBuilder.UpdateData(
                table: "PenaltyTypes",
                keyColumn: "PenaltyTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 261, DateTimeKind.Local).AddTicks(7768));

            migrationBuilder.UpdateData(
                table: "PenaltyTypes",
                keyColumn: "PenaltyTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 261, DateTimeKind.Local).AddTicks(7779));

            migrationBuilder.UpdateData(
                table: "PenaltyTypes",
                keyColumn: "PenaltyTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 261, DateTimeKind.Local).AddTicks(7785));

            migrationBuilder.UpdateData(
                table: "PenaltyTypes",
                keyColumn: "PenaltyTypeID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 261, DateTimeKind.Local).AddTicks(7790));

            migrationBuilder.UpdateData(
                table: "PenaltyTypes",
                keyColumn: "PenaltyTypeID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 261, DateTimeKind.Local).AddTicks(7799));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 215, DateTimeKind.Local).AddTicks(4396));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 215, DateTimeKind.Local).AddTicks(4791));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 215, DateTimeKind.Local).AddTicks(4837));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 215, DateTimeKind.Local).AddTicks(4843));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 215, DateTimeKind.Local).AddTicks(4850));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 215, DateTimeKind.Local).AddTicks(4861));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 215, DateTimeKind.Local).AddTicks(4866));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 215, DateTimeKind.Local).AddTicks(4871));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 215, DateTimeKind.Local).AddTicks(4876));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 215, DateTimeKind.Local).AddTicks(4883));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 215, DateTimeKind.Local).AddTicks(4890));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 215, DateTimeKind.Local).AddTicks(4895));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 13,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 215, DateTimeKind.Local).AddTicks(4900));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 14,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 215, DateTimeKind.Local).AddTicks(4905));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 15,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 215, DateTimeKind.Local).AddTicks(4911));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 16,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 215, DateTimeKind.Local).AddTicks(4916));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 17,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 215, DateTimeKind.Local).AddTicks(4921));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 18,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 215, DateTimeKind.Local).AddTicks(4927));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 19,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 215, DateTimeKind.Local).AddTicks(4933));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 20,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 215, DateTimeKind.Local).AddTicks(4938));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 21,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 215, DateTimeKind.Local).AddTicks(4944));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 22,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 215, DateTimeKind.Local).AddTicks(4949));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 23,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 215, DateTimeKind.Local).AddTicks(4955));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 24,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 215, DateTimeKind.Local).AddTicks(4960));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 25,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 215, DateTimeKind.Local).AddTicks(4966));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 26,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 215, DateTimeKind.Local).AddTicks(4971));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 27,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 215, DateTimeKind.Local).AddTicks(4976));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 28,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 215, DateTimeKind.Local).AddTicks(4982));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 29,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 215, DateTimeKind.Local).AddTicks(4988));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 30,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 215, DateTimeKind.Local).AddTicks(4994));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 31,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 215, DateTimeKind.Local).AddTicks(4999));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 32,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 215, DateTimeKind.Local).AddTicks(5004));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 33,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 215, DateTimeKind.Local).AddTicks(5010));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 34,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 215, DateTimeKind.Local).AddTicks(5016));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 35,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 215, DateTimeKind.Local).AddTicks(5022));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 36,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 215, DateTimeKind.Local).AddTicks(5027));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 37,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 215, DateTimeKind.Local).AddTicks(5033));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 38,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 215, DateTimeKind.Local).AddTicks(5039));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 39,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 215, DateTimeKind.Local).AddTicks(5045));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 40,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 215, DateTimeKind.Local).AddTicks(5050));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 41,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 215, DateTimeKind.Local).AddTicks(5056));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 42,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 215, DateTimeKind.Local).AddTicks(5061));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 43,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 215, DateTimeKind.Local).AddTicks(5100));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 44,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 215, DateTimeKind.Local).AddTicks(5105));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 45,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 215, DateTimeKind.Local).AddTicks(5111));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 46,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 215, DateTimeKind.Local).AddTicks(5115));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 47,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 215, DateTimeKind.Local).AddTicks(5121));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 48,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 215, DateTimeKind.Local).AddTicks(5126));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 49,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 215, DateTimeKind.Local).AddTicks(5131));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 50,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 215, DateTimeKind.Local).AddTicks(5137));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 51,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 215, DateTimeKind.Local).AddTicks(5143));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 52,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 215, DateTimeKind.Local).AddTicks(5148));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 53,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 215, DateTimeKind.Local).AddTicks(5154));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 54,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 215, DateTimeKind.Local).AddTicks(5159));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 55,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 215, DateTimeKind.Local).AddTicks(5165));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 56,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 215, DateTimeKind.Local).AddTicks(5170));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 57,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 215, DateTimeKind.Local).AddTicks(5175));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 58,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 215, DateTimeKind.Local).AddTicks(5180));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 59,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 215, DateTimeKind.Local).AddTicks(5186));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 60,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 215, DateTimeKind.Local).AddTicks(5190));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 61,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 215, DateTimeKind.Local).AddTicks(5196));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 62,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 215, DateTimeKind.Local).AddTicks(5201));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 63,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 215, DateTimeKind.Local).AddTicks(5206));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 64,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 215, DateTimeKind.Local).AddTicks(5211));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 65,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 215, DateTimeKind.Local).AddTicks(5216));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 66,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 215, DateTimeKind.Local).AddTicks(5224));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 67,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 215, DateTimeKind.Local).AddTicks(5229));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 68,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 215, DateTimeKind.Local).AddTicks(5235));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 69,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 215, DateTimeKind.Local).AddTicks(5241));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 70,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 215, DateTimeKind.Local).AddTicks(5245));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 71,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 215, DateTimeKind.Local).AddTicks(5251));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 72,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 215, DateTimeKind.Local).AddTicks(5256));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 73,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 215, DateTimeKind.Local).AddTicks(5262));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 74,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 215, DateTimeKind.Local).AddTicks(5267));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 75,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 215, DateTimeKind.Local).AddTicks(5272));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 76,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 215, DateTimeKind.Local).AddTicks(5278));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 77,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 215, DateTimeKind.Local).AddTicks(5283));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 78,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 215, DateTimeKind.Local).AddTicks(5289));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 79,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 215, DateTimeKind.Local).AddTicks(5294));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 80,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 215, DateTimeKind.Local).AddTicks(5299));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 81,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 215, DateTimeKind.Local).AddTicks(5305));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 82,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 215, DateTimeKind.Local).AddTicks(5310));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 83,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 215, DateTimeKind.Local).AddTicks(5484));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 84,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 215, DateTimeKind.Local).AddTicks(5489));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 85,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 215, DateTimeKind.Local).AddTicks(5495));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 86,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 215, DateTimeKind.Local).AddTicks(5500));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 87,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 215, DateTimeKind.Local).AddTicks(5505));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 88,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 215, DateTimeKind.Local).AddTicks(5510));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 89,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 215, DateTimeKind.Local).AddTicks(5515));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 90,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 215, DateTimeKind.Local).AddTicks(5521));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 91,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 215, DateTimeKind.Local).AddTicks(5527));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 92,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 215, DateTimeKind.Local).AddTicks(5532));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 93,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 215, DateTimeKind.Local).AddTicks(5539));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 94,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 215, DateTimeKind.Local).AddTicks(5544));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 95,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 215, DateTimeKind.Local).AddTicks(5550));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 96,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 215, DateTimeKind.Local).AddTicks(5556));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 97,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 215, DateTimeKind.Local).AddTicks(5562));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 98,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 215, DateTimeKind.Local).AddTicks(5567));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 99,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 215, DateTimeKind.Local).AddTicks(5574));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 100,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 215, DateTimeKind.Local).AddTicks(5579));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 101,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 215, DateTimeKind.Local).AddTicks(5586));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 102,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 215, DateTimeKind.Local).AddTicks(5591));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 103,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 215, DateTimeKind.Local).AddTicks(5597));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 104,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 215, DateTimeKind.Local).AddTicks(5602));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 105,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 215, DateTimeKind.Local).AddTicks(5608));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 106,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 215, DateTimeKind.Local).AddTicks(5613));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 107,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 215, DateTimeKind.Local).AddTicks(5618));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 108,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 215, DateTimeKind.Local).AddTicks(5623));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 109,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 215, DateTimeKind.Local).AddTicks(5630));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 110,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 215, DateTimeKind.Local).AddTicks(5635));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 111,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 215, DateTimeKind.Local).AddTicks(5641));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 112,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 215, DateTimeKind.Local).AddTicks(5646));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 113,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 215, DateTimeKind.Local).AddTicks(5651));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 114,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 215, DateTimeKind.Local).AddTicks(5657));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 115,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 215, DateTimeKind.Local).AddTicks(5663));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 116,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 215, DateTimeKind.Local).AddTicks(5668));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 117,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 215, DateTimeKind.Local).AddTicks(5674));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 118,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 215, DateTimeKind.Local).AddTicks(5679));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 119,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 215, DateTimeKind.Local).AddTicks(5684));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 120,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 215, DateTimeKind.Local).AddTicks(5690));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 121,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 215, DateTimeKind.Local).AddTicks(5695));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 122,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 215, DateTimeKind.Local).AddTicks(5701));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 123,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 215, DateTimeKind.Local).AddTicks(5706));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 124,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 215, DateTimeKind.Local).AddTicks(5712));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 125,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 215, DateTimeKind.Local).AddTicks(5717));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 126,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 215, DateTimeKind.Local).AddTicks(5722));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 127,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 215, DateTimeKind.Local).AddTicks(5727));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 128,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 215, DateTimeKind.Local).AddTicks(5732));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 129,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 215, DateTimeKind.Local).AddTicks(5924));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 130,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 215, DateTimeKind.Local).AddTicks(5931));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 131,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 215, DateTimeKind.Local).AddTicks(5936));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 132,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 215, DateTimeKind.Local).AddTicks(5941));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 133,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 215, DateTimeKind.Local).AddTicks(5947));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 134,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 215, DateTimeKind.Local).AddTicks(5953));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 135,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 215, DateTimeKind.Local).AddTicks(5959));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 136,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 215, DateTimeKind.Local).AddTicks(5964));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 137,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 215, DateTimeKind.Local).AddTicks(5969));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 138,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 215, DateTimeKind.Local).AddTicks(5975));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 139,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 215, DateTimeKind.Local).AddTicks(5981));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 140,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 215, DateTimeKind.Local).AddTicks(5986));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 141,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 215, DateTimeKind.Local).AddTicks(5992));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 142,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 215, DateTimeKind.Local).AddTicks(5997));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 143,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 215, DateTimeKind.Local).AddTicks(6003));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 144,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 215, DateTimeKind.Local).AddTicks(6008));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 145,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 215, DateTimeKind.Local).AddTicks(6013));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 146,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 215, DateTimeKind.Local).AddTicks(6018));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 147,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 215, DateTimeKind.Local).AddTicks(6024));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 148,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 215, DateTimeKind.Local).AddTicks(6029));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 149,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 215, DateTimeKind.Local).AddTicks(6035));

            migrationBuilder.UpdateData(
                table: "PinCodeTypes",
                keyColumn: "PinCodeTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 257, DateTimeKind.Local).AddTicks(6313));

            migrationBuilder.UpdateData(
                table: "PinCodeTypes",
                keyColumn: "PinCodeTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 257, DateTimeKind.Local).AddTicks(6566));

            migrationBuilder.UpdateData(
                table: "PinCodeTypes",
                keyColumn: "PinCodeTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 257, DateTimeKind.Local).AddTicks(6576));

            migrationBuilder.UpdateData(
                table: "PriorityRanks",
                keyColumn: "PriorityRankID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 228, DateTimeKind.Local).AddTicks(2034));

            migrationBuilder.UpdateData(
                table: "PriorityRanks",
                keyColumn: "PriorityRankID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 228, DateTimeKind.Local).AddTicks(2219));

            migrationBuilder.UpdateData(
                table: "PriorityRanks",
                keyColumn: "PriorityRankID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 228, DateTimeKind.Local).AddTicks(2228));

            migrationBuilder.UpdateData(
                table: "PriorityRanks",
                keyColumn: "PriorityRankID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 228, DateTimeKind.Local).AddTicks(2232));

            migrationBuilder.UpdateData(
                table: "ProductComputations",
                keyColumn: "ProductComputationID",
                keyValue: 1,
                columns: new[] { "DateCreated", "LastChangedDate" },
                values: new object[] { new DateTime(2022, 4, 18, 12, 26, 34, 267, DateTimeKind.Local).AddTicks(2338), new DateTime(2022, 4, 18, 12, 26, 34, 267, DateTimeKind.Local).AddTicks(2696) });

            migrationBuilder.UpdateData(
                table: "ProductComputations",
                keyColumn: "ProductComputationID",
                keyValue: 2,
                columns: new[] { "DateCreated", "LastChangedDate" },
                values: new object[] { new DateTime(2022, 4, 18, 12, 26, 34, 267, DateTimeKind.Local).AddTicks(3039), new DateTime(2022, 4, 18, 12, 26, 34, 267, DateTimeKind.Local).AddTicks(3058) });

            migrationBuilder.UpdateData(
                table: "RecordStatus",
                keyColumn: "RecordStatusID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 246, DateTimeKind.Local).AddTicks(7886));

            migrationBuilder.UpdateData(
                table: "RecordStatus",
                keyColumn: "RecordStatusID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 246, DateTimeKind.Local).AddTicks(8095));

            migrationBuilder.UpdateData(
                table: "RecordStatus",
                keyColumn: "RecordStatusID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 246, DateTimeKind.Local).AddTicks(8103));

            migrationBuilder.UpdateData(
                table: "RelationshipTypes",
                keyColumn: "RelationshipTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 223, DateTimeKind.Local).AddTicks(6648));

            migrationBuilder.UpdateData(
                table: "RelationshipTypes",
                keyColumn: "RelationshipTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 223, DateTimeKind.Local).AddTicks(6706));

            migrationBuilder.UpdateData(
                table: "RelationshipTypes",
                keyColumn: "RelationshipTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 223, DateTimeKind.Local).AddTicks(6709));

            migrationBuilder.UpdateData(
                table: "RelationshipTypes",
                keyColumn: "RelationshipTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 223, DateTimeKind.Local).AddTicks(6713));

            migrationBuilder.UpdateData(
                table: "RelationshipTypes",
                keyColumn: "RelationshipTypeID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 223, DateTimeKind.Local).AddTicks(6716));

            migrationBuilder.UpdateData(
                table: "RelationshipTypes",
                keyColumn: "RelationshipTypeID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 223, DateTimeKind.Local).AddTicks(6720));

            migrationBuilder.UpdateData(
                table: "RelationshipTypes",
                keyColumn: "RelationshipTypeID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 223, DateTimeKind.Local).AddTicks(6723));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 240, DateTimeKind.Local).AddTicks(1815));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 240, DateTimeKind.Local).AddTicks(1863));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 240, DateTimeKind.Local).AddTicks(1867));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 240, DateTimeKind.Local).AddTicks(1869));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 240, DateTimeKind.Local).AddTicks(1871));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 240, DateTimeKind.Local).AddTicks(1876));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 240, DateTimeKind.Local).AddTicks(1878));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 240, DateTimeKind.Local).AddTicks(1924));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 240, DateTimeKind.Local).AddTicks(1927));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 240, DateTimeKind.Local).AddTicks(1930));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 216, DateTimeKind.Local).AddTicks(1128));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 216, DateTimeKind.Local).AddTicks(1240));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 216, DateTimeKind.Local).AddTicks(1244));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 216, DateTimeKind.Local).AddTicks(1248));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 216, DateTimeKind.Local).AddTicks(1251));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 216, DateTimeKind.Local).AddTicks(1257));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 216, DateTimeKind.Local).AddTicks(1260));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 216, DateTimeKind.Local).AddTicks(1263));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 216, DateTimeKind.Local).AddTicks(1296));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 216, DateTimeKind.Local).AddTicks(1301));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 216, DateTimeKind.Local).AddTicks(1304));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 216, DateTimeKind.Local).AddTicks(1307));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 13,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 216, DateTimeKind.Local).AddTicks(1310));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 14,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 216, DateTimeKind.Local).AddTicks(1313));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 15,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 216, DateTimeKind.Local).AddTicks(1316));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 16,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 216, DateTimeKind.Local).AddTicks(1319));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 17,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 216, DateTimeKind.Local).AddTicks(1322));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 18,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 216, DateTimeKind.Local).AddTicks(1326));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 19,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 216, DateTimeKind.Local).AddTicks(1330));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 20,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 216, DateTimeKind.Local).AddTicks(1333));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 21,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 216, DateTimeKind.Local).AddTicks(1336));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 22,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 216, DateTimeKind.Local).AddTicks(1339));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 23,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 216, DateTimeKind.Local).AddTicks(1342));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 24,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 216, DateTimeKind.Local).AddTicks(1345));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 25,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 216, DateTimeKind.Local).AddTicks(1348));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 26,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 216, DateTimeKind.Local).AddTicks(1351));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 27,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 216, DateTimeKind.Local).AddTicks(1354));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 28,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 216, DateTimeKind.Local).AddTicks(1357));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 29,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 216, DateTimeKind.Local).AddTicks(1360));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 30,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 216, DateTimeKind.Local).AddTicks(1363));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 31,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 216, DateTimeKind.Local).AddTicks(1366));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 32,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 216, DateTimeKind.Local).AddTicks(1369));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 33,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 216, DateTimeKind.Local).AddTicks(1372));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 34,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 216, DateTimeKind.Local).AddTicks(1376));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 35,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 216, DateTimeKind.Local).AddTicks(1379));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 36,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 216, DateTimeKind.Local).AddTicks(1382));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 37,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 216, DateTimeKind.Local).AddTicks(1385));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 38,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 216, DateTimeKind.Local).AddTicks(1388));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 39,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 216, DateTimeKind.Local).AddTicks(1392));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 40,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 216, DateTimeKind.Local).AddTicks(1394));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 41,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 216, DateTimeKind.Local).AddTicks(1397));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 42,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 216, DateTimeKind.Local).AddTicks(1400));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 43,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 216, DateTimeKind.Local).AddTicks(1404));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 44,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 216, DateTimeKind.Local).AddTicks(1407));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 45,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 216, DateTimeKind.Local).AddTicks(1410));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 46,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 216, DateTimeKind.Local).AddTicks(1413));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 47,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 216, DateTimeKind.Local).AddTicks(1416));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 48,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 216, DateTimeKind.Local).AddTicks(1419));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 49,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 216, DateTimeKind.Local).AddTicks(1422));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 50,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 216, DateTimeKind.Local).AddTicks(1425));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 51,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 216, DateTimeKind.Local).AddTicks(1428));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 52,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 216, DateTimeKind.Local).AddTicks(1431));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 53,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 216, DateTimeKind.Local).AddTicks(1433));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 54,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 216, DateTimeKind.Local).AddTicks(1436));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 55,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 216, DateTimeKind.Local).AddTicks(1439));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 56,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 216, DateTimeKind.Local).AddTicks(1442));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 57,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 216, DateTimeKind.Local).AddTicks(1445));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 58,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 216, DateTimeKind.Local).AddTicks(1448));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 59,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 216, DateTimeKind.Local).AddTicks(1451));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 60,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 216, DateTimeKind.Local).AddTicks(1454));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 61,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 216, DateTimeKind.Local).AddTicks(1457));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 62,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 216, DateTimeKind.Local).AddTicks(1460));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 63,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 216, DateTimeKind.Local).AddTicks(1463));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 64,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 216, DateTimeKind.Local).AddTicks(1466));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 65,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 216, DateTimeKind.Local).AddTicks(1469));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 66,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 216, DateTimeKind.Local).AddTicks(1473));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 67,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 216, DateTimeKind.Local).AddTicks(1476));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 68,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 216, DateTimeKind.Local).AddTicks(1479));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 69,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 216, DateTimeKind.Local).AddTicks(1482));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 70,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 216, DateTimeKind.Local).AddTicks(1485));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 71,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 216, DateTimeKind.Local).AddTicks(1488));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 72,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 216, DateTimeKind.Local).AddTicks(1491));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 73,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 216, DateTimeKind.Local).AddTicks(1494));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 74,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 216, DateTimeKind.Local).AddTicks(1497));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 75,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 216, DateTimeKind.Local).AddTicks(1500));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 76,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 216, DateTimeKind.Local).AddTicks(1503));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 77,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 216, DateTimeKind.Local).AddTicks(1506));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 78,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 216, DateTimeKind.Local).AddTicks(1509));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 79,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 216, DateTimeKind.Local).AddTicks(1512));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 80,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 216, DateTimeKind.Local).AddTicks(1515));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 81,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 216, DateTimeKind.Local).AddTicks(1518));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 82,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 216, DateTimeKind.Local).AddTicks(1521));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 83,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 216, DateTimeKind.Local).AddTicks(1524));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 84,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 216, DateTimeKind.Local).AddTicks(1527));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 85,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 216, DateTimeKind.Local).AddTicks(1530));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 86,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 216, DateTimeKind.Local).AddTicks(1532));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 87,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 216, DateTimeKind.Local).AddTicks(1535));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 88,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 216, DateTimeKind.Local).AddTicks(1538));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 89,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 216, DateTimeKind.Local).AddTicks(1541));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 90,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 216, DateTimeKind.Local).AddTicks(1544));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 91,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 216, DateTimeKind.Local).AddTicks(1547));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 92,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 216, DateTimeKind.Local).AddTicks(1550));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 93,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 216, DateTimeKind.Local).AddTicks(1553));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 94,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 216, DateTimeKind.Local).AddTicks(1556));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 95,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 216, DateTimeKind.Local).AddTicks(1559));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 96,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 216, DateTimeKind.Local).AddTicks(1562));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 97,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 216, DateTimeKind.Local).AddTicks(1565));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 98,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 216, DateTimeKind.Local).AddTicks(1568));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 99,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 216, DateTimeKind.Local).AddTicks(1599));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 100,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 216, DateTimeKind.Local).AddTicks(1602));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 101,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 216, DateTimeKind.Local).AddTicks(1605));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 102,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 216, DateTimeKind.Local).AddTicks(1608));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 103,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 216, DateTimeKind.Local).AddTicks(1611));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 104,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 216, DateTimeKind.Local).AddTicks(1614));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 105,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 216, DateTimeKind.Local).AddTicks(1670));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 106,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 216, DateTimeKind.Local).AddTicks(1674));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 107,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 216, DateTimeKind.Local).AddTicks(1677));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 108,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 216, DateTimeKind.Local).AddTicks(1680));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 109,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 216, DateTimeKind.Local).AddTicks(1683));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 110,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 216, DateTimeKind.Local).AddTicks(1686));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 111,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 216, DateTimeKind.Local).AddTicks(1689));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 112,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 216, DateTimeKind.Local).AddTicks(1692));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 113,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 216, DateTimeKind.Local).AddTicks(1695));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 114,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 216, DateTimeKind.Local).AddTicks(1698));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 115,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 216, DateTimeKind.Local).AddTicks(1701));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 116,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 216, DateTimeKind.Local).AddTicks(1704));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 117,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 216, DateTimeKind.Local).AddTicks(1707));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 118,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 216, DateTimeKind.Local).AddTicks(1710));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 119,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 216, DateTimeKind.Local).AddTicks(1713));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 120,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 216, DateTimeKind.Local).AddTicks(1715));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 121,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 216, DateTimeKind.Local).AddTicks(1718));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 122,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 216, DateTimeKind.Local).AddTicks(1721));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 123,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 216, DateTimeKind.Local).AddTicks(1724));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 124,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 216, DateTimeKind.Local).AddTicks(1727));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 125,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 216, DateTimeKind.Local).AddTicks(1730));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 126,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 216, DateTimeKind.Local).AddTicks(1733));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 127,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 216, DateTimeKind.Local).AddTicks(1736));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 128,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 216, DateTimeKind.Local).AddTicks(1739));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 129,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 216, DateTimeKind.Local).AddTicks(1742));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 130,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 216, DateTimeKind.Local).AddTicks(1747));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 131,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 216, DateTimeKind.Local).AddTicks(1750));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 132,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 216, DateTimeKind.Local).AddTicks(1753));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 133,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 216, DateTimeKind.Local).AddTicks(1756));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 134,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 216, DateTimeKind.Local).AddTicks(1759));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 135,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 216, DateTimeKind.Local).AddTicks(1762));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 136,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 216, DateTimeKind.Local).AddTicks(1765));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 137,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 216, DateTimeKind.Local).AddTicks(1768));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 138,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 216, DateTimeKind.Local).AddTicks(1771));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 139,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 216, DateTimeKind.Local).AddTicks(1774));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 140,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 216, DateTimeKind.Local).AddTicks(1777));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 141,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 216, DateTimeKind.Local).AddTicks(1780));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 142,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 216, DateTimeKind.Local).AddTicks(1783));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 143,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 216, DateTimeKind.Local).AddTicks(1786));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 144,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 216, DateTimeKind.Local).AddTicks(1789));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 145,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 216, DateTimeKind.Local).AddTicks(1792));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 146,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 216, DateTimeKind.Local).AddTicks(1795));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 147,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 216, DateTimeKind.Local).AddTicks(1798));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 148,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 216, DateTimeKind.Local).AddTicks(1801));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 149,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 216, DateTimeKind.Local).AddTicks(1804));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 209, DateTimeKind.Local).AddTicks(4688));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 212, DateTimeKind.Local).AddTicks(641));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 212, DateTimeKind.Local).AddTicks(691));

            migrationBuilder.UpdateData(
                table: "StatementLists",
                keyColumn: "StatementID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 242, DateTimeKind.Local).AddTicks(8327));

            migrationBuilder.UpdateData(
                table: "StatementLists",
                keyColumn: "StatementID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 242, DateTimeKind.Local).AddTicks(8509));

            migrationBuilder.UpdateData(
                table: "StatementLists",
                keyColumn: "StatementID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 242, DateTimeKind.Local).AddTicks(8517));

            migrationBuilder.UpdateData(
                table: "StatementLists",
                keyColumn: "StatementID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 242, DateTimeKind.Local).AddTicks(8522));

            migrationBuilder.UpdateData(
                table: "TechnicalSupport",
                keyColumn: "TechnicalSupportID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 255, DateTimeKind.Local).AddTicks(9527));

            migrationBuilder.UpdateData(
                table: "TechnicalSupport",
                keyColumn: "TechnicalSupportID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 256, DateTimeKind.Local).AddTicks(1884));

            migrationBuilder.UpdateData(
                table: "TechnicalSupport",
                keyColumn: "TechnicalSupportID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 256, DateTimeKind.Local).AddTicks(1894));

            migrationBuilder.UpdateData(
                table: "TechnicalSupport",
                keyColumn: "TechnicalSupportID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 256, DateTimeKind.Local).AddTicks(1898));

            migrationBuilder.UpdateData(
                table: "TechnicalSupport",
                keyColumn: "TechnicalSupportID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 256, DateTimeKind.Local).AddTicks(1904));

            migrationBuilder.UpdateData(
                table: "TechnicalSupport",
                keyColumn: "TechnicalSupportID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 256, DateTimeKind.Local).AddTicks(1911));

            migrationBuilder.UpdateData(
                table: "TechnicalSupport",
                keyColumn: "TechnicalSupportID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 256, DateTimeKind.Local).AddTicks(1916));

            migrationBuilder.UpdateData(
                table: "Titles",
                keyColumn: "TitleID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 244, DateTimeKind.Local).AddTicks(1067));

            migrationBuilder.UpdateData(
                table: "Titles",
                keyColumn: "TitleID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 244, DateTimeKind.Local).AddTicks(1289));

            migrationBuilder.UpdateData(
                table: "Titles",
                keyColumn: "TitleID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 244, DateTimeKind.Local).AddTicks(1296));

            migrationBuilder.UpdateData(
                table: "Titles",
                keyColumn: "TitleID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 244, DateTimeKind.Local).AddTicks(1299));

            migrationBuilder.UpdateData(
                table: "Titles",
                keyColumn: "TitleID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 244, DateTimeKind.Local).AddTicks(1303));

            migrationBuilder.UpdateData(
                table: "Titles",
                keyColumn: "TitleID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 244, DateTimeKind.Local).AddTicks(1309));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 219, DateTimeKind.Local).AddTicks(273));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 219, DateTimeKind.Local).AddTicks(714));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 219, DateTimeKind.Local).AddTicks(842));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 219, DateTimeKind.Local).AddTicks(897));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 219, DateTimeKind.Local).AddTicks(945));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 219, DateTimeKind.Local).AddTicks(995));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 219, DateTimeKind.Local).AddTicks(1036));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 219, DateTimeKind.Local).AddTicks(1076));

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumns: new[] { "UserID", "RoleID" },
                keyValues: new object[] { 1, 1 },
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 233, DateTimeKind.Local).AddTicks(2751));

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumns: new[] { "UserID", "RoleID" },
                keyValues: new object[] { 2, 3 },
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 233, DateTimeKind.Local).AddTicks(2822));

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "UserTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 222, DateTimeKind.Local).AddTicks(9119));

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "UserTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 222, DateTimeKind.Local).AddTicks(9285));

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "UserTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 222, DateTimeKind.Local).AddTicks(9293));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 228, DateTimeKind.Local).AddTicks(5839));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 228, DateTimeKind.Local).AddTicks(8710));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 228, DateTimeKind.Local).AddTicks(8780));

            migrationBuilder.UpdateData(
                table: "VariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 225, DateTimeKind.Local).AddTicks(222));

            migrationBuilder.UpdateData(
                table: "VariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 225, DateTimeKind.Local).AddTicks(562));

            migrationBuilder.UpdateData(
                table: "VariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 225, DateTimeKind.Local).AddTicks(570));

            migrationBuilder.UpdateData(
                table: "VariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 225, DateTimeKind.Local).AddTicks(573));

            migrationBuilder.UpdateData(
                table: "VariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 225, DateTimeKind.Local).AddTicks(577));

            migrationBuilder.UpdateData(
                table: "VariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 225, DateTimeKind.Local).AddTicks(583));

            migrationBuilder.UpdateData(
                table: "VariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 225, DateTimeKind.Local).AddTicks(589));

            migrationBuilder.UpdateData(
                table: "VariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 225, DateTimeKind.Local).AddTicks(592));

            migrationBuilder.UpdateData(
                table: "VariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 18, 12, 26, 34, 225, DateTimeKind.Local).AddTicks(596));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Loans");

            migrationBuilder.DropColumn(
                name: "DateFinalised",
                table: "Loans");

            migrationBuilder.DropColumn(
                name: "FinalisedBy",
                table: "Loans");

            migrationBuilder.AddColumn<string>(
                name: "Method",
                table: "ProductComputations",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PluginName",
                table: "ProductComputations",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);

            migrationBuilder.UpdateData(
                table: "BankAccountTypes",
                keyColumn: "BankAccountTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 880, DateTimeKind.Local).AddTicks(1928));

            migrationBuilder.UpdateData(
                table: "BankAccountTypes",
                keyColumn: "BankAccountTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 880, DateTimeKind.Local).AddTicks(2167));

            migrationBuilder.UpdateData(
                table: "BankAccountTypes",
                keyColumn: "BankAccountTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 880, DateTimeKind.Local).AddTicks(2176));

            migrationBuilder.UpdateData(
                table: "BankAccountTypes",
                keyColumn: "BankAccountTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 880, DateTimeKind.Local).AddTicks(2180));

            migrationBuilder.UpdateData(
                table: "CalculationTypes",
                keyColumn: "CalculationTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 928, DateTimeKind.Local).AddTicks(5069));

            migrationBuilder.UpdateData(
                table: "CalculationTypes",
                keyColumn: "CalculationTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 928, DateTimeKind.Local).AddTicks(5423));

            migrationBuilder.UpdateData(
                table: "ClientAccountTypes",
                keyColumn: "ID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 908, DateTimeKind.Local).AddTicks(8865));

            migrationBuilder.UpdateData(
                table: "ClientAccountTypes",
                keyColumn: "ID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 908, DateTimeKind.Local).AddTicks(9596));

            migrationBuilder.UpdateData(
                table: "ClientGroups",
                keyColumn: "ClientGroupID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 912, DateTimeKind.Local).AddTicks(4610));

            migrationBuilder.UpdateData(
                table: "ClientGroups",
                keyColumn: "ClientGroupID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 912, DateTimeKind.Local).AddTicks(4858));

            migrationBuilder.UpdateData(
                table: "ContactTypes",
                keyColumn: "ContactTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 883, DateTimeKind.Local).AddTicks(7205));

            migrationBuilder.UpdateData(
                table: "ContactTypes",
                keyColumn: "ContactTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 883, DateTimeKind.Local).AddTicks(7200));

            migrationBuilder.UpdateData(
                table: "ContactTypes",
                keyColumn: "ContactTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 883, DateTimeKind.Local).AddTicks(7192));

            migrationBuilder.UpdateData(
                table: "ContactTypes",
                keyColumn: "ContactTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 883, DateTimeKind.Local).AddTicks(7109));

            migrationBuilder.UpdateData(
                table: "ContactTypes",
                keyColumn: "ContactTypeID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 883, DateTimeKind.Local).AddTicks(7210));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 887, DateTimeKind.Local).AddTicks(2987));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 887, DateTimeKind.Local).AddTicks(3228));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 887, DateTimeKind.Local).AddTicks(3239));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 887, DateTimeKind.Local).AddTicks(3287));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 887, DateTimeKind.Local).AddTicks(3292));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 887, DateTimeKind.Local).AddTicks(3330));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 887, DateTimeKind.Local).AddTicks(3335));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 887, DateTimeKind.Local).AddTicks(3340));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 887, DateTimeKind.Local).AddTicks(3345));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 887, DateTimeKind.Local).AddTicks(3351));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 887, DateTimeKind.Local).AddTicks(3355));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 887, DateTimeKind.Local).AddTicks(3359));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 13,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 887, DateTimeKind.Local).AddTicks(3364));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 14,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 887, DateTimeKind.Local).AddTicks(3368));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 15,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 887, DateTimeKind.Local).AddTicks(3372));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 16,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 887, DateTimeKind.Local).AddTicks(3377));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 17,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 887, DateTimeKind.Local).AddTicks(3381));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 18,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 887, DateTimeKind.Local).AddTicks(3388));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 19,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 887, DateTimeKind.Local).AddTicks(3392));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 20,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 887, DateTimeKind.Local).AddTicks(3397));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 21,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 887, DateTimeKind.Local).AddTicks(3401));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 22,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 887, DateTimeKind.Local).AddTicks(3405));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 23,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 887, DateTimeKind.Local).AddTicks(3409));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 24,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 887, DateTimeKind.Local).AddTicks(3413));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 25,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 887, DateTimeKind.Local).AddTicks(3417));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 26,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 887, DateTimeKind.Local).AddTicks(3421));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 27,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 887, DateTimeKind.Local).AddTicks(3427));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 28,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 887, DateTimeKind.Local).AddTicks(3431));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 29,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 887, DateTimeKind.Local).AddTicks(3435));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 30,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 887, DateTimeKind.Local).AddTicks(3441));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 31,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 887, DateTimeKind.Local).AddTicks(3445));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 32,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 887, DateTimeKind.Local).AddTicks(3449));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 33,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 887, DateTimeKind.Local).AddTicks(3454));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 34,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 887, DateTimeKind.Local).AddTicks(3460));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 35,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 887, DateTimeKind.Local).AddTicks(3465));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 36,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 887, DateTimeKind.Local).AddTicks(3469));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 37,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 887, DateTimeKind.Local).AddTicks(3473));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 38,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 887, DateTimeKind.Local).AddTicks(3477));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 39,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 887, DateTimeKind.Local).AddTicks(3483));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 40,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 887, DateTimeKind.Local).AddTicks(3489));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 41,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 887, DateTimeKind.Local).AddTicks(3496));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 42,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 887, DateTimeKind.Local).AddTicks(3501));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 43,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 887, DateTimeKind.Local).AddTicks(3506));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 44,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 887, DateTimeKind.Local).AddTicks(3510));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 45,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 887, DateTimeKind.Local).AddTicks(3514));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 46,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 887, DateTimeKind.Local).AddTicks(3518));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 47,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 887, DateTimeKind.Local).AddTicks(3523));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 48,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 887, DateTimeKind.Local).AddTicks(3529));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 49,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 887, DateTimeKind.Local).AddTicks(3533));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 50,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 887, DateTimeKind.Local).AddTicks(3538));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 51,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 887, DateTimeKind.Local).AddTicks(3543));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 52,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 887, DateTimeKind.Local).AddTicks(3547));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 53,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 887, DateTimeKind.Local).AddTicks(3552));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 54,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 887, DateTimeKind.Local).AddTicks(3587));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 55,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 887, DateTimeKind.Local).AddTicks(3593));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 56,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 887, DateTimeKind.Local).AddTicks(3597));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 57,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 887, DateTimeKind.Local).AddTicks(3601));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 58,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 887, DateTimeKind.Local).AddTicks(3605));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 59,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 887, DateTimeKind.Local).AddTicks(3610));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 60,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 887, DateTimeKind.Local).AddTicks(3615));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 61,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 887, DateTimeKind.Local).AddTicks(3619));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 62,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 887, DateTimeKind.Local).AddTicks(3623));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 63,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 887, DateTimeKind.Local).AddTicks(3628));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 64,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 887, DateTimeKind.Local).AddTicks(3633));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 65,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 887, DateTimeKind.Local).AddTicks(3637));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 66,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 887, DateTimeKind.Local).AddTicks(3644));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 67,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 887, DateTimeKind.Local).AddTicks(3648));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 68,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 887, DateTimeKind.Local).AddTicks(3653));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 69,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 887, DateTimeKind.Local).AddTicks(3657));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 70,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 887, DateTimeKind.Local).AddTicks(3662));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 71,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 887, DateTimeKind.Local).AddTicks(3666));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 72,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 887, DateTimeKind.Local).AddTicks(3670));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 73,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 887, DateTimeKind.Local).AddTicks(3675));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 74,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 887, DateTimeKind.Local).AddTicks(3680));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 75,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 887, DateTimeKind.Local).AddTicks(3684));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 76,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 887, DateTimeKind.Local).AddTicks(3689));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 77,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 887, DateTimeKind.Local).AddTicks(3693));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 78,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 887, DateTimeKind.Local).AddTicks(3697));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 79,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 887, DateTimeKind.Local).AddTicks(3702));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 80,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 887, DateTimeKind.Local).AddTicks(3706));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 81,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 887, DateTimeKind.Local).AddTicks(3711));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 82,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 887, DateTimeKind.Local).AddTicks(3715));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 83,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 887, DateTimeKind.Local).AddTicks(3719));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 84,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 887, DateTimeKind.Local).AddTicks(3723));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 85,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 887, DateTimeKind.Local).AddTicks(3727));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 86,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 887, DateTimeKind.Local).AddTicks(3732));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 87,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 887, DateTimeKind.Local).AddTicks(3736));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 88,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 887, DateTimeKind.Local).AddTicks(3740));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 89,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 887, DateTimeKind.Local).AddTicks(3745));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 90,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 887, DateTimeKind.Local).AddTicks(3749));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 91,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 887, DateTimeKind.Local).AddTicks(3753));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 92,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 887, DateTimeKind.Local).AddTicks(3757));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 93,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 887, DateTimeKind.Local).AddTicks(3762));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 94,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 887, DateTimeKind.Local).AddTicks(3766));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 95,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 887, DateTimeKind.Local).AddTicks(3770));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 96,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 887, DateTimeKind.Local).AddTicks(3775));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 97,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 887, DateTimeKind.Local).AddTicks(3779));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 98,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 887, DateTimeKind.Local).AddTicks(3783));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 99,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 887, DateTimeKind.Local).AddTicks(3788));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 100,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 887, DateTimeKind.Local).AddTicks(3792));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 101,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 887, DateTimeKind.Local).AddTicks(3797));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 102,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 887, DateTimeKind.Local).AddTicks(3801));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 103,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 887, DateTimeKind.Local).AddTicks(3805));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 104,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 887, DateTimeKind.Local).AddTicks(3809));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 105,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 887, DateTimeKind.Local).AddTicks(3813));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 106,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 887, DateTimeKind.Local).AddTicks(3818));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 107,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 887, DateTimeKind.Local).AddTicks(3822));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 108,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 887, DateTimeKind.Local).AddTicks(3826));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 109,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 887, DateTimeKind.Local).AddTicks(3831));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 110,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 887, DateTimeKind.Local).AddTicks(3835));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 111,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 887, DateTimeKind.Local).AddTicks(3840));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 112,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 887, DateTimeKind.Local).AddTicks(3844));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 113,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 887, DateTimeKind.Local).AddTicks(3849));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 114,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 887, DateTimeKind.Local).AddTicks(3853));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 115,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 887, DateTimeKind.Local).AddTicks(3906));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 116,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 887, DateTimeKind.Local).AddTicks(3912));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 117,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 887, DateTimeKind.Local).AddTicks(3917));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 118,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 887, DateTimeKind.Local).AddTicks(3921));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 119,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 887, DateTimeKind.Local).AddTicks(3925));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 120,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 887, DateTimeKind.Local).AddTicks(3929));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 121,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 887, DateTimeKind.Local).AddTicks(3934));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 122,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 887, DateTimeKind.Local).AddTicks(3939));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 123,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 887, DateTimeKind.Local).AddTicks(3943));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 124,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 887, DateTimeKind.Local).AddTicks(3947));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 125,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 887, DateTimeKind.Local).AddTicks(3951));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 126,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 887, DateTimeKind.Local).AddTicks(3956));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 127,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 887, DateTimeKind.Local).AddTicks(3960));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 128,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 887, DateTimeKind.Local).AddTicks(3964));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 129,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 887, DateTimeKind.Local).AddTicks(3968));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 130,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 887, DateTimeKind.Local).AddTicks(3975));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 131,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 887, DateTimeKind.Local).AddTicks(3979));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 132,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 887, DateTimeKind.Local).AddTicks(3984));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 133,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 887, DateTimeKind.Local).AddTicks(3988));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 134,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 887, DateTimeKind.Local).AddTicks(3993));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 135,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 887, DateTimeKind.Local).AddTicks(3997));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 136,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 887, DateTimeKind.Local).AddTicks(4002));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 137,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 887, DateTimeKind.Local).AddTicks(4006));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 138,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 887, DateTimeKind.Local).AddTicks(4011));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 139,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 887, DateTimeKind.Local).AddTicks(4015));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 140,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 887, DateTimeKind.Local).AddTicks(4019));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 141,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 887, DateTimeKind.Local).AddTicks(4023));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 142,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 887, DateTimeKind.Local).AddTicks(4027));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 143,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 887, DateTimeKind.Local).AddTicks(4032));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 144,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 887, DateTimeKind.Local).AddTicks(4036));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 145,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 887, DateTimeKind.Local).AddTicks(4040));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 146,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 887, DateTimeKind.Local).AddTicks(4044));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 147,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 887, DateTimeKind.Local).AddTicks(4048));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 148,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 887, DateTimeKind.Local).AddTicks(4053));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 149,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 887, DateTimeKind.Local).AddTicks(4058));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 150,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 887, DateTimeKind.Local).AddTicks(4063));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 151,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 887, DateTimeKind.Local).AddTicks(4068));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 152,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 887, DateTimeKind.Local).AddTicks(4072));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 153,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 887, DateTimeKind.Local).AddTicks(4077));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 154,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 887, DateTimeKind.Local).AddTicks(4081));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 155,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 887, DateTimeKind.Local).AddTicks(4086));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 156,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 887, DateTimeKind.Local).AddTicks(4090));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 157,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 887, DateTimeKind.Local).AddTicks(4094));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 158,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 887, DateTimeKind.Local).AddTicks(4099));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 159,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 887, DateTimeKind.Local).AddTicks(4103));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 160,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 887, DateTimeKind.Local).AddTicks(4107));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 161,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 887, DateTimeKind.Local).AddTicks(4112));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 162,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 887, DateTimeKind.Local).AddTicks(4116));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 163,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 887, DateTimeKind.Local).AddTicks(4120));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 164,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 887, DateTimeKind.Local).AddTicks(4125));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 165,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 887, DateTimeKind.Local).AddTicks(4129));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 166,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 887, DateTimeKind.Local).AddTicks(4133));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 167,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 887, DateTimeKind.Local).AddTicks(4138));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 168,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 887, DateTimeKind.Local).AddTicks(4142));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 169,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 887, DateTimeKind.Local).AddTicks(4170));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 170,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 887, DateTimeKind.Local).AddTicks(4175));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 171,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 887, DateTimeKind.Local).AddTicks(4179));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 172,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 887, DateTimeKind.Local).AddTicks(4184));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 173,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 887, DateTimeKind.Local).AddTicks(4189));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 174,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 887, DateTimeKind.Local).AddTicks(4194));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 175,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 887, DateTimeKind.Local).AddTicks(4198));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 176,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 887, DateTimeKind.Local).AddTicks(4203));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 177,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 887, DateTimeKind.Local).AddTicks(4210));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 178,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 887, DateTimeKind.Local).AddTicks(4214));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 179,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 887, DateTimeKind.Local).AddTicks(4219));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 180,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 887, DateTimeKind.Local).AddTicks(4224));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 181,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 887, DateTimeKind.Local).AddTicks(4229));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 182,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 887, DateTimeKind.Local).AddTicks(4233));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 183,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 887, DateTimeKind.Local).AddTicks(4237));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 184,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 887, DateTimeKind.Local).AddTicks(4241));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 185,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 887, DateTimeKind.Local).AddTicks(4246));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 186,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 887, DateTimeKind.Local).AddTicks(4250));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 187,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 887, DateTimeKind.Local).AddTicks(4255));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 188,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 887, DateTimeKind.Local).AddTicks(4259));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 189,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 887, DateTimeKind.Local).AddTicks(4264));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 190,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 887, DateTimeKind.Local).AddTicks(4268));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 191,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 887, DateTimeKind.Local).AddTicks(4273));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 192,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 887, DateTimeKind.Local).AddTicks(4277));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 193,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 887, DateTimeKind.Local).AddTicks(4281));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 194,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 887, DateTimeKind.Local).AddTicks(4286));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 195,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 887, DateTimeKind.Local).AddTicks(4290));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 196,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 887, DateTimeKind.Local).AddTicks(4294));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 197,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 887, DateTimeKind.Local).AddTicks(4298));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 198,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 887, DateTimeKind.Local).AddTicks(4302));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 199,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 887, DateTimeKind.Local).AddTicks(4306));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 200,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 887, DateTimeKind.Local).AddTicks(4310));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 201,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 887, DateTimeKind.Local).AddTicks(4315));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 202,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 887, DateTimeKind.Local).AddTicks(4319));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 203,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 887, DateTimeKind.Local).AddTicks(4323));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 204,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 887, DateTimeKind.Local).AddTicks(4328));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 205,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 887, DateTimeKind.Local).AddTicks(4332));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 206,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 887, DateTimeKind.Local).AddTicks(4337));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 207,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 887, DateTimeKind.Local).AddTicks(4341));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 208,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 887, DateTimeKind.Local).AddTicks(4345));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 209,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 887, DateTimeKind.Local).AddTicks(4349));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 210,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 887, DateTimeKind.Local).AddTicks(4354));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 211,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 887, DateTimeKind.Local).AddTicks(4358));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 212,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 887, DateTimeKind.Local).AddTicks(4362));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 213,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 887, DateTimeKind.Local).AddTicks(4366));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 214,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 887, DateTimeKind.Local).AddTicks(4371));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 215,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 887, DateTimeKind.Local).AddTicks(4376));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 216,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 887, DateTimeKind.Local).AddTicks(4381));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 217,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 887, DateTimeKind.Local).AddTicks(4385));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 218,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 887, DateTimeKind.Local).AddTicks(4389));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 219,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 887, DateTimeKind.Local).AddTicks(4393));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 220,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 887, DateTimeKind.Local).AddTicks(4398));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 221,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 887, DateTimeKind.Local).AddTicks(4402));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 222,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 887, DateTimeKind.Local).AddTicks(4406));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 223,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 887, DateTimeKind.Local).AddTicks(4411));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 224,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 887, DateTimeKind.Local).AddTicks(4416));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 225,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 887, DateTimeKind.Local).AddTicks(4420));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 226,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 887, DateTimeKind.Local).AddTicks(4424));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 227,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 887, DateTimeKind.Local).AddTicks(4429));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 228,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 887, DateTimeKind.Local).AddTicks(4433));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 881, DateTimeKind.Local).AddTicks(5382));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 881, DateTimeKind.Local).AddTicks(5732));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 881, DateTimeKind.Local).AddTicks(5749));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 881, DateTimeKind.Local).AddTicks(5755));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 881, DateTimeKind.Local).AddTicks(5760));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 881, DateTimeKind.Local).AddTicks(5770));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 881, DateTimeKind.Local).AddTicks(5775));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 881, DateTimeKind.Local).AddTicks(5780));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 881, DateTimeKind.Local).AddTicks(5784));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 881, DateTimeKind.Local).AddTicks(5791));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 881, DateTimeKind.Local).AddTicks(5796));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 881, DateTimeKind.Local).AddTicks(5800));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 13,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 881, DateTimeKind.Local).AddTicks(5804));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 14,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 881, DateTimeKind.Local).AddTicks(5808));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 15,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 881, DateTimeKind.Local).AddTicks(5813));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 16,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 881, DateTimeKind.Local).AddTicks(5817));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 17,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 881, DateTimeKind.Local).AddTicks(5821));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 18,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 881, DateTimeKind.Local).AddTicks(5828));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 19,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 881, DateTimeKind.Local).AddTicks(5833));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 20,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 881, DateTimeKind.Local).AddTicks(5837));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 21,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 881, DateTimeKind.Local).AddTicks(5842));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 22,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 881, DateTimeKind.Local).AddTicks(5846));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 23,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 881, DateTimeKind.Local).AddTicks(5851));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 24,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 881, DateTimeKind.Local).AddTicks(5856));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 25,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 881, DateTimeKind.Local).AddTicks(5860));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 26,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 881, DateTimeKind.Local).AddTicks(5865));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 27,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 881, DateTimeKind.Local).AddTicks(5870));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 28,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 881, DateTimeKind.Local).AddTicks(5875));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 29,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 881, DateTimeKind.Local).AddTicks(5880));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 30,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 881, DateTimeKind.Local).AddTicks(5885));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 31,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 881, DateTimeKind.Local).AddTicks(5890));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 32,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 881, DateTimeKind.Local).AddTicks(5895));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 33,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 881, DateTimeKind.Local).AddTicks(5900));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 34,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 881, DateTimeKind.Local).AddTicks(5906));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 35,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 881, DateTimeKind.Local).AddTicks(5911));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 36,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 881, DateTimeKind.Local).AddTicks(5916));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 37,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 881, DateTimeKind.Local).AddTicks(5921));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 38,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 881, DateTimeKind.Local).AddTicks(5926));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 39,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 881, DateTimeKind.Local).AddTicks(5931));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 40,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 881, DateTimeKind.Local).AddTicks(5936));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 41,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 881, DateTimeKind.Local).AddTicks(5941));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 42,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 881, DateTimeKind.Local).AddTicks(5946));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 43,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 881, DateTimeKind.Local).AddTicks(5951));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 44,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 881, DateTimeKind.Local).AddTicks(5956));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 45,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 881, DateTimeKind.Local).AddTicks(5961));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 46,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 881, DateTimeKind.Local).AddTicks(5966));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 47,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 881, DateTimeKind.Local).AddTicks(5971));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 48,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 881, DateTimeKind.Local).AddTicks(5976));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 49,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 881, DateTimeKind.Local).AddTicks(5980));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 50,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 881, DateTimeKind.Local).AddTicks(5985));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 51,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 881, DateTimeKind.Local).AddTicks(5991));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 52,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 881, DateTimeKind.Local).AddTicks(5995));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 53,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 881, DateTimeKind.Local).AddTicks(6000));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 54,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 881, DateTimeKind.Local).AddTicks(6005));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 55,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 881, DateTimeKind.Local).AddTicks(6010));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 56,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 881, DateTimeKind.Local).AddTicks(6015));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 57,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 881, DateTimeKind.Local).AddTicks(6020));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 58,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 881, DateTimeKind.Local).AddTicks(6025));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 59,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 881, DateTimeKind.Local).AddTicks(6030));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 60,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 881, DateTimeKind.Local).AddTicks(6035));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 61,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 881, DateTimeKind.Local).AddTicks(6040));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 62,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 881, DateTimeKind.Local).AddTicks(6045));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 63,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 881, DateTimeKind.Local).AddTicks(6050));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 64,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 881, DateTimeKind.Local).AddTicks(6055));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 65,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 881, DateTimeKind.Local).AddTicks(6060));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 66,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 881, DateTimeKind.Local).AddTicks(6136));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 67,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 881, DateTimeKind.Local).AddTicks(6142));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 68,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 881, DateTimeKind.Local).AddTicks(6147));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 69,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 881, DateTimeKind.Local).AddTicks(6153));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 70,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 881, DateTimeKind.Local).AddTicks(6157));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 71,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 881, DateTimeKind.Local).AddTicks(6164));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 72,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 881, DateTimeKind.Local).AddTicks(6168));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 73,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 881, DateTimeKind.Local).AddTicks(6174));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 74,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 881, DateTimeKind.Local).AddTicks(6178));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 75,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 881, DateTimeKind.Local).AddTicks(6183));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 76,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 881, DateTimeKind.Local).AddTicks(6188));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 77,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 881, DateTimeKind.Local).AddTicks(6193));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 78,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 881, DateTimeKind.Local).AddTicks(6199));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 79,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 881, DateTimeKind.Local).AddTicks(6204));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 80,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 881, DateTimeKind.Local).AddTicks(6210));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 81,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 881, DateTimeKind.Local).AddTicks(6215));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 82,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 881, DateTimeKind.Local).AddTicks(6220));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 83,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 881, DateTimeKind.Local).AddTicks(6225));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 84,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 881, DateTimeKind.Local).AddTicks(6230));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 85,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 881, DateTimeKind.Local).AddTicks(6235));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 86,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 881, DateTimeKind.Local).AddTicks(6240));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 87,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 881, DateTimeKind.Local).AddTicks(6245));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 88,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 881, DateTimeKind.Local).AddTicks(6249));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 89,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 881, DateTimeKind.Local).AddTicks(6254));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 90,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 881, DateTimeKind.Local).AddTicks(6259));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 91,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 881, DateTimeKind.Local).AddTicks(6264));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 92,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 881, DateTimeKind.Local).AddTicks(6269));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 93,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 881, DateTimeKind.Local).AddTicks(6275));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 94,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 881, DateTimeKind.Local).AddTicks(6280));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 95,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 881, DateTimeKind.Local).AddTicks(6311));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 96,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 881, DateTimeKind.Local).AddTicks(6316));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 97,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 881, DateTimeKind.Local).AddTicks(6321));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 98,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 881, DateTimeKind.Local).AddTicks(6326));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 99,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 881, DateTimeKind.Local).AddTicks(6331));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 100,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 881, DateTimeKind.Local).AddTicks(6336));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 101,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 881, DateTimeKind.Local).AddTicks(6341));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 102,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 881, DateTimeKind.Local).AddTicks(6346));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 103,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 881, DateTimeKind.Local).AddTicks(6351));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 104,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 881, DateTimeKind.Local).AddTicks(6356));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 105,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 881, DateTimeKind.Local).AddTicks(6361));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 106,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 881, DateTimeKind.Local).AddTicks(6365));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 107,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 881, DateTimeKind.Local).AddTicks(6370));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 108,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 881, DateTimeKind.Local).AddTicks(6375));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 109,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 881, DateTimeKind.Local).AddTicks(6380));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 110,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 881, DateTimeKind.Local).AddTicks(6385));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 111,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 881, DateTimeKind.Local).AddTicks(6390));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 112,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 881, DateTimeKind.Local).AddTicks(6395));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 113,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 881, DateTimeKind.Local).AddTicks(6400));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 114,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 881, DateTimeKind.Local).AddTicks(6405));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 115,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 881, DateTimeKind.Local).AddTicks(6410));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 116,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 881, DateTimeKind.Local).AddTicks(6415));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 117,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 881, DateTimeKind.Local).AddTicks(6420));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 118,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 881, DateTimeKind.Local).AddTicks(6425));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 119,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 881, DateTimeKind.Local).AddTicks(6430));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 120,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 881, DateTimeKind.Local).AddTicks(6435));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 121,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 881, DateTimeKind.Local).AddTicks(6440));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 122,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 881, DateTimeKind.Local).AddTicks(6445));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 123,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 881, DateTimeKind.Local).AddTicks(6451));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 124,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 881, DateTimeKind.Local).AddTicks(6456));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 125,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 881, DateTimeKind.Local).AddTicks(6461));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 126,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 881, DateTimeKind.Local).AddTicks(6466));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 127,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 881, DateTimeKind.Local).AddTicks(6471));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 128,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 881, DateTimeKind.Local).AddTicks(6476));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 129,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 881, DateTimeKind.Local).AddTicks(6481));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 130,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 881, DateTimeKind.Local).AddTicks(6514));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 131,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 881, DateTimeKind.Local).AddTicks(6520));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 132,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 881, DateTimeKind.Local).AddTicks(6524));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 133,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 881, DateTimeKind.Local).AddTicks(6530));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 134,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 881, DateTimeKind.Local).AddTicks(6534));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 135,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 881, DateTimeKind.Local).AddTicks(6539));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 136,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 881, DateTimeKind.Local).AddTicks(6544));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 137,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 881, DateTimeKind.Local).AddTicks(6550));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 138,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 881, DateTimeKind.Local).AddTicks(6555));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 139,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 881, DateTimeKind.Local).AddTicks(6561));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 140,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 881, DateTimeKind.Local).AddTicks(6566));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 141,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 881, DateTimeKind.Local).AddTicks(6571));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 142,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 881, DateTimeKind.Local).AddTicks(6576));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 143,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 881, DateTimeKind.Local).AddTicks(6582));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 144,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 881, DateTimeKind.Local).AddTicks(6587));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 145,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 881, DateTimeKind.Local).AddTicks(6592));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 146,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 881, DateTimeKind.Local).AddTicks(6599));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 147,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 881, DateTimeKind.Local).AddTicks(6604));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 148,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 881, DateTimeKind.Local).AddTicks(6609));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 149,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 881, DateTimeKind.Local).AddTicks(6614));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 150,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 881, DateTimeKind.Local).AddTicks(6619));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 151,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 881, DateTimeKind.Local).AddTicks(6624));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 152,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 881, DateTimeKind.Local).AddTicks(6629));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 153,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 881, DateTimeKind.Local).AddTicks(6635));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 154,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 881, DateTimeKind.Local).AddTicks(6639));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 155,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 881, DateTimeKind.Local).AddTicks(6644));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 156,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 881, DateTimeKind.Local).AddTicks(6649));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 157,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 881, DateTimeKind.Local).AddTicks(6654));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 158,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 881, DateTimeKind.Local).AddTicks(6660));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 159,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 881, DateTimeKind.Local).AddTicks(6665));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 160,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 881, DateTimeKind.Local).AddTicks(6670));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 161,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 881, DateTimeKind.Local).AddTicks(6675));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 162,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 881, DateTimeKind.Local).AddTicks(6680));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 902, DateTimeKind.Local).AddTicks(9748));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 902, DateTimeKind.Local).AddTicks(9937));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 902, DateTimeKind.Local).AddTicks(9997));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 902, DateTimeKind.Local).AddTicks(9979));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 903, DateTimeKind.Local).AddTicks(3));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 903, DateTimeKind.Local).AddTicks(15));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 903, DateTimeKind.Local).AddTicks(23));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 903, DateTimeKind.Local).AddTicks(29));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 903, DateTimeKind.Local).AddTicks(37));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 903, DateTimeKind.Local).AddTicks(43));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 903, DateTimeKind.Local).AddTicks(110));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 903, DateTimeKind.Local).AddTicks(116));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 13,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 903, DateTimeKind.Local).AddTicks(122));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 14,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 903, DateTimeKind.Local).AddTicks(130));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 15,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 902, DateTimeKind.Local).AddTicks(9985));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 16,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 902, DateTimeKind.Local).AddTicks(9928));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 17,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 903, DateTimeKind.Local).AddTicks(138));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 18,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 903, DateTimeKind.Local).AddTicks(145));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 19,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 903, DateTimeKind.Local).AddTicks(152));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 20,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 903, DateTimeKind.Local).AddTicks(158));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 22,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 903, DateTimeKind.Local).AddTicks(183));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 23,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 903, DateTimeKind.Local).AddTicks(170));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 24,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 903, DateTimeKind.Local).AddTicks(164));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 25,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 903, DateTimeKind.Local).AddTicks(177));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 26,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 903, DateTimeKind.Local).AddTicks(189));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 27,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 903, DateTimeKind.Local).AddTicks(195));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 28,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 903, DateTimeKind.Local).AddTicks(201));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 30,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 903, DateTimeKind.Local).AddTicks(207));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 31,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 903, DateTimeKind.Local).AddTicks(213));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 32,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 903, DateTimeKind.Local).AddTicks(220));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 33,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 903, DateTimeKind.Local).AddTicks(226));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 34,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 903, DateTimeKind.Local).AddTicks(233));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 36,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 903, DateTimeKind.Local).AddTicks(242));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 37,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 903, DateTimeKind.Local).AddTicks(249));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 38,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 903, DateTimeKind.Local).AddTicks(256));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 39,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 903, DateTimeKind.Local).AddTicks(10));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 40,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 903, DateTimeKind.Local).AddTicks(263));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 41,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 903, DateTimeKind.Local).AddTicks(270));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 42,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 903, DateTimeKind.Local).AddTicks(275));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 43,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 903, DateTimeKind.Local).AddTicks(281));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 44,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 903, DateTimeKind.Local).AddTicks(287));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 45,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 903, DateTimeKind.Local).AddTicks(294));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 46,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 903, DateTimeKind.Local).AddTicks(350));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 47,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 903, DateTimeKind.Local).AddTicks(358));

            migrationBuilder.UpdateData(
                table: "DeductionTypes",
                keyColumn: "DeductionTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 919, DateTimeKind.Local).AddTicks(1196));

            migrationBuilder.UpdateData(
                table: "DeductionTypes",
                keyColumn: "DeductionTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 919, DateTimeKind.Local).AddTicks(1538));

            migrationBuilder.UpdateData(
                table: "DeductionTypes",
                keyColumn: "DeductionTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 919, DateTimeKind.Local).AddTicks(1554));

            migrationBuilder.UpdateData(
                table: "DocumentFormats",
                keyColumn: "DocumentFormatID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 892, DateTimeKind.Local).AddTicks(218));

            migrationBuilder.UpdateData(
                table: "DocumentFormats",
                keyColumn: "DocumentFormatID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 892, DateTimeKind.Local).AddTicks(486));

            migrationBuilder.UpdateData(
                table: "DocumentFormats",
                keyColumn: "DocumentFormatID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 892, DateTimeKind.Local).AddTicks(500));

            migrationBuilder.UpdateData(
                table: "DocumentFormats",
                keyColumn: "DocumentFormatID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 892, DateTimeKind.Local).AddTicks(506));

            migrationBuilder.UpdateData(
                table: "DocumentFormats",
                keyColumn: "DocumentFormatID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 892, DateTimeKind.Local).AddTicks(512));

            migrationBuilder.UpdateData(
                table: "DocumentFormats",
                keyColumn: "DocumentFormatID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 892, DateTimeKind.Local).AddTicks(522));

            migrationBuilder.UpdateData(
                table: "DocumentTypes",
                keyColumn: "DocumentTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 893, DateTimeKind.Local).AddTicks(7196));

            migrationBuilder.UpdateData(
                table: "DocumentTypes",
                keyColumn: "DocumentTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 893, DateTimeKind.Local).AddTicks(7689));

            migrationBuilder.UpdateData(
                table: "DocumentTypes",
                keyColumn: "DocumentTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 893, DateTimeKind.Local).AddTicks(7768));

            migrationBuilder.UpdateData(
                table: "DocumentTypes",
                keyColumn: "DocumentTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 893, DateTimeKind.Local).AddTicks(7776));

            migrationBuilder.UpdateData(
                table: "EmailTemplates",
                keyColumn: "EmailTemplateID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 900, DateTimeKind.Local).AddTicks(739));

            migrationBuilder.UpdateData(
                table: "EmailTypes",
                keyColumn: "EmailTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 899, DateTimeKind.Local).AddTicks(7283));

            migrationBuilder.UpdateData(
                table: "EmailTypes",
                keyColumn: "EmailTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 899, DateTimeKind.Local).AddTicks(7630));

            migrationBuilder.UpdateData(
                table: "EmailTypes",
                keyColumn: "EmailTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 899, DateTimeKind.Local).AddTicks(7646));

            migrationBuilder.UpdateData(
                table: "EmailTypes",
                keyColumn: "EmailTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 899, DateTimeKind.Local).AddTicks(7654));

            migrationBuilder.UpdateData(
                table: "FeatureFlags",
                keyColumn: "FeatureFlagID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 890, DateTimeKind.Local).AddTicks(7366));

            migrationBuilder.UpdateData(
                table: "FeatureFlags",
                keyColumn: "FeatureFlagID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 890, DateTimeKind.Local).AddTicks(7572));

            migrationBuilder.UpdateData(
                table: "FeatureFlags",
                keyColumn: "FeatureFlagID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 890, DateTimeKind.Local).AddTicks(7581));

            migrationBuilder.UpdateData(
                table: "Fees",
                keyColumn: "FeeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 929, DateTimeKind.Local).AddTicks(7638));

            migrationBuilder.UpdateData(
                table: "Fees",
                keyColumn: "FeeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 929, DateTimeKind.Local).AddTicks(8080));

            migrationBuilder.UpdateData(
                table: "Fees",
                keyColumn: "FeeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 929, DateTimeKind.Local).AddTicks(8105));

            migrationBuilder.UpdateData(
                table: "Fees",
                keyColumn: "FeeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 929, DateTimeKind.Local).AddTicks(8111));

            migrationBuilder.UpdateData(
                table: "Fees",
                keyColumn: "FeeID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 929, DateTimeKind.Local).AddTicks(8116));

            migrationBuilder.UpdateData(
                table: "Fees",
                keyColumn: "FeeID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 929, DateTimeKind.Local).AddTicks(8126));

            migrationBuilder.UpdateData(
                table: "Fees",
                keyColumn: "FeeID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 929, DateTimeKind.Local).AddTicks(8131));

            migrationBuilder.UpdateData(
                table: "Fees",
                keyColumn: "FeeID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 929, DateTimeKind.Local).AddTicks(8137));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "GenderID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 885, DateTimeKind.Local).AddTicks(8486));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "GenderID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 885, DateTimeKind.Local).AddTicks(8559));

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "InvoiceStatusID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 913, DateTimeKind.Local).AddTicks(8895));

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "InvoiceStatusID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 913, DateTimeKind.Local).AddTicks(9108));

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "InvoiceStatusID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 913, DateTimeKind.Local).AddTicks(9117));

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "InvoiceStatusID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 913, DateTimeKind.Local).AddTicks(9122));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 917, DateTimeKind.Local).AddTicks(4571));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 917, DateTimeKind.Local).AddTicks(4695));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 917, DateTimeKind.Local).AddTicks(4702));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 917, DateTimeKind.Local).AddTicks(4706));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 917, DateTimeKind.Local).AddTicks(4710));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 917, DateTimeKind.Local).AddTicks(4719));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 917, DateTimeKind.Local).AddTicks(4723));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 917, DateTimeKind.Local).AddTicks(4727));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 917, DateTimeKind.Local).AddTicks(4731));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 917, DateTimeKind.Local).AddTicks(4896));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 917, DateTimeKind.Local).AddTicks(4914));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 13,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 917, DateTimeKind.Local).AddTicks(4919));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 14,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 917, DateTimeKind.Local).AddTicks(4924));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 15,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 917, DateTimeKind.Local).AddTicks(4929));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 16,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 917, DateTimeKind.Local).AddTicks(4933));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 17,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 917, DateTimeKind.Local).AddTicks(4938));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 18,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 917, DateTimeKind.Local).AddTicks(4943));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 19,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 917, DateTimeKind.Local).AddTicks(4949));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 20,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 917, DateTimeKind.Local).AddTicks(4953));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 21,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 917, DateTimeKind.Local).AddTicks(4958));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 22,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 917, DateTimeKind.Local).AddTicks(4963));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 23,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 917, DateTimeKind.Local).AddTicks(4968));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 24,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 917, DateTimeKind.Local).AddTicks(4972));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 25,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 917, DateTimeKind.Local).AddTicks(4976));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 26,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 917, DateTimeKind.Local).AddTicks(4980));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 27,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 917, DateTimeKind.Local).AddTicks(4985));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 28,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 917, DateTimeKind.Local).AddTicks(4989));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 29,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 917, DateTimeKind.Local).AddTicks(4993));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 30,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 917, DateTimeKind.Local).AddTicks(4997));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 31,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 917, DateTimeKind.Local).AddTicks(5001));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 32,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 917, DateTimeKind.Local).AddTicks(5005));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 33,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 917, DateTimeKind.Local).AddTicks(5009));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 34,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 917, DateTimeKind.Local).AddTicks(5013));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 35,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 917, DateTimeKind.Local).AddTicks(5018));

            migrationBuilder.UpdateData(
                table: "LayoutMenus",
                keyColumn: "LayoutMenuID",
                keyValue: 36,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 917, DateTimeKind.Local).AddTicks(5022));

            migrationBuilder.UpdateData(
                table: "Layouts",
                keyColumn: "LayoutID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 915, DateTimeKind.Local).AddTicks(2345));

            migrationBuilder.UpdateData(
                table: "Layouts",
                keyColumn: "LayoutID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 915, DateTimeKind.Local).AddTicks(4643));

            migrationBuilder.UpdateData(
                table: "Layouts",
                keyColumn: "LayoutID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 915, DateTimeKind.Local).AddTicks(4654));

            migrationBuilder.UpdateData(
                table: "Layouts",
                keyColumn: "LayoutID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 915, DateTimeKind.Local).AddTicks(4659));

            migrationBuilder.UpdateData(
                table: "Layouts",
                keyColumn: "LayoutID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 915, DateTimeKind.Local).AddTicks(4664));

            migrationBuilder.UpdateData(
                table: "Layouts",
                keyColumn: "LayoutID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 915, DateTimeKind.Local).AddTicks(4673));

            migrationBuilder.UpdateData(
                table: "Layouts",
                keyColumn: "LayoutID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 915, DateTimeKind.Local).AddTicks(4678));

            migrationBuilder.UpdateData(
                table: "LoanStatus",
                keyColumn: "LoanStatusID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 927, DateTimeKind.Local).AddTicks(2341));

            migrationBuilder.UpdateData(
                table: "LoanStatus",
                keyColumn: "LoanStatusID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 927, DateTimeKind.Local).AddTicks(2704));

            migrationBuilder.UpdateData(
                table: "LoanStatus",
                keyColumn: "LoanStatusID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 927, DateTimeKind.Local).AddTicks(2724));

            migrationBuilder.UpdateData(
                table: "LoanStatus",
                keyColumn: "LoanStatusID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 927, DateTimeKind.Local).AddTicks(2729));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 895, DateTimeKind.Local).AddTicks(3340));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 895, DateTimeKind.Local).AddTicks(3491));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 895, DateTimeKind.Local).AddTicks(3504));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 895, DateTimeKind.Local).AddTicks(3512));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 895, DateTimeKind.Local).AddTicks(3520));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 895, DateTimeKind.Local).AddTicks(3556));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 895, DateTimeKind.Local).AddTicks(3532));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 999,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 895, DateTimeKind.Local).AddTicks(3548));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 9998,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 895, DateTimeKind.Local).AddTicks(3539));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 896, DateTimeKind.Local).AddTicks(3339));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 896, DateTimeKind.Local).AddTicks(3466));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 896, DateTimeKind.Local).AddTicks(3475));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 896, DateTimeKind.Local).AddTicks(3480));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 896, DateTimeKind.Local).AddTicks(3485));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 896, DateTimeKind.Local).AddTicks(3494));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 896, DateTimeKind.Local).AddTicks(3500));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 9994,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 896, DateTimeKind.Local).AddTicks(3505));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 9995,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 896, DateTimeKind.Local).AddTicks(3510));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 9996,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 896, DateTimeKind.Local).AddTicks(3517));

            migrationBuilder.UpdateData(
                table: "PaymentStatus",
                keyColumn: "PaymentStatusID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 876, DateTimeKind.Local).AddTicks(6781));

            migrationBuilder.UpdateData(
                table: "PaymentStatus",
                keyColumn: "PaymentStatusID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 876, DateTimeKind.Local).AddTicks(7017));

            migrationBuilder.UpdateData(
                table: "PaymentStatus",
                keyColumn: "PaymentStatusID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 876, DateTimeKind.Local).AddTicks(7025));

            migrationBuilder.UpdateData(
                table: "PaymentStatus",
                keyColumn: "PaymentStatusID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 876, DateTimeKind.Local).AddTicks(7076));

            migrationBuilder.UpdateData(
                table: "PaymentStatus",
                keyColumn: "PaymentStatusID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 876, DateTimeKind.Local).AddTicks(7083));

            migrationBuilder.UpdateData(
                table: "PenaltyTypes",
                keyColumn: "PenaltyTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 925, DateTimeKind.Local).AddTicks(9975));

            migrationBuilder.UpdateData(
                table: "PenaltyTypes",
                keyColumn: "PenaltyTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 926, DateTimeKind.Local).AddTicks(222));

            migrationBuilder.UpdateData(
                table: "PenaltyTypes",
                keyColumn: "PenaltyTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 926, DateTimeKind.Local).AddTicks(233));

            migrationBuilder.UpdateData(
                table: "PenaltyTypes",
                keyColumn: "PenaltyTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 926, DateTimeKind.Local).AddTicks(238));

            migrationBuilder.UpdateData(
                table: "PenaltyTypes",
                keyColumn: "PenaltyTypeID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 926, DateTimeKind.Local).AddTicks(243));

            migrationBuilder.UpdateData(
                table: "PenaltyTypes",
                keyColumn: "PenaltyTypeID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 926, DateTimeKind.Local).AddTicks(252));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 874, DateTimeKind.Local).AddTicks(2897));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 874, DateTimeKind.Local).AddTicks(3214));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 874, DateTimeKind.Local).AddTicks(3228));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 874, DateTimeKind.Local).AddTicks(3234));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 874, DateTimeKind.Local).AddTicks(3243));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 874, DateTimeKind.Local).AddTicks(3253));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 874, DateTimeKind.Local).AddTicks(3290));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 874, DateTimeKind.Local).AddTicks(3296));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 874, DateTimeKind.Local).AddTicks(3302));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 874, DateTimeKind.Local).AddTicks(3310));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 874, DateTimeKind.Local).AddTicks(3317));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 874, DateTimeKind.Local).AddTicks(3324));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 13,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 874, DateTimeKind.Local).AddTicks(3330));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 14,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 874, DateTimeKind.Local).AddTicks(3337));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 15,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 874, DateTimeKind.Local).AddTicks(3343));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 16,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 874, DateTimeKind.Local).AddTicks(3350));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 17,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 874, DateTimeKind.Local).AddTicks(3356));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 18,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 874, DateTimeKind.Local).AddTicks(3364));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 19,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 874, DateTimeKind.Local).AddTicks(3371));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 20,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 874, DateTimeKind.Local).AddTicks(3377));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 21,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 874, DateTimeKind.Local).AddTicks(3383));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 22,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 874, DateTimeKind.Local).AddTicks(3389));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 23,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 874, DateTimeKind.Local).AddTicks(3440));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 24,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 874, DateTimeKind.Local).AddTicks(3447));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 25,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 874, DateTimeKind.Local).AddTicks(3453));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 26,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 874, DateTimeKind.Local).AddTicks(3459));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 27,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 874, DateTimeKind.Local).AddTicks(3465));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 28,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 874, DateTimeKind.Local).AddTicks(3472));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 29,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 874, DateTimeKind.Local).AddTicks(3479));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 30,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 874, DateTimeKind.Local).AddTicks(3486));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 31,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 874, DateTimeKind.Local).AddTicks(3492));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 32,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 874, DateTimeKind.Local).AddTicks(3498));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 33,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 874, DateTimeKind.Local).AddTicks(3504));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 34,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 874, DateTimeKind.Local).AddTicks(3512));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 35,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 874, DateTimeKind.Local).AddTicks(3518));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 36,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 874, DateTimeKind.Local).AddTicks(3524));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 37,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 874, DateTimeKind.Local).AddTicks(3531));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 38,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 874, DateTimeKind.Local).AddTicks(3539));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 39,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 874, DateTimeKind.Local).AddTicks(3545));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 40,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 874, DateTimeKind.Local).AddTicks(3551));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 41,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 874, DateTimeKind.Local).AddTicks(3558));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 42,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 874, DateTimeKind.Local).AddTicks(3563));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 43,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 874, DateTimeKind.Local).AddTicks(3569));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 44,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 874, DateTimeKind.Local).AddTicks(3575));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 45,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 874, DateTimeKind.Local).AddTicks(3581));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 46,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 874, DateTimeKind.Local).AddTicks(3587));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 47,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 874, DateTimeKind.Local).AddTicks(3594));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 48,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 874, DateTimeKind.Local).AddTicks(3600));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 49,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 874, DateTimeKind.Local).AddTicks(3605));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 50,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 874, DateTimeKind.Local).AddTicks(3611));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 51,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 874, DateTimeKind.Local).AddTicks(3619));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 52,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 874, DateTimeKind.Local).AddTicks(3626));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 53,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 874, DateTimeKind.Local).AddTicks(3633));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 54,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 874, DateTimeKind.Local).AddTicks(3639));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 55,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 874, DateTimeKind.Local).AddTicks(3646));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 56,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 874, DateTimeKind.Local).AddTicks(3651));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 57,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 874, DateTimeKind.Local).AddTicks(3657));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 58,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 874, DateTimeKind.Local).AddTicks(3663));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 59,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 874, DateTimeKind.Local).AddTicks(3669));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 60,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 874, DateTimeKind.Local).AddTicks(3675));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 61,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 874, DateTimeKind.Local).AddTicks(3681));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 62,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 874, DateTimeKind.Local).AddTicks(3687));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 63,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 874, DateTimeKind.Local).AddTicks(3693));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 64,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 874, DateTimeKind.Local).AddTicks(3699));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 65,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 874, DateTimeKind.Local).AddTicks(3705));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 66,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 874, DateTimeKind.Local).AddTicks(3744));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 67,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 874, DateTimeKind.Local).AddTicks(3750));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 68,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 874, DateTimeKind.Local).AddTicks(3757));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 69,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 874, DateTimeKind.Local).AddTicks(3764));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 70,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 874, DateTimeKind.Local).AddTicks(3770));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 71,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 874, DateTimeKind.Local).AddTicks(3776));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 72,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 874, DateTimeKind.Local).AddTicks(3782));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 73,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 874, DateTimeKind.Local).AddTicks(3789));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 74,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 874, DateTimeKind.Local).AddTicks(3794));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 75,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 874, DateTimeKind.Local).AddTicks(3801));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 76,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 874, DateTimeKind.Local).AddTicks(3809));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 77,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 874, DateTimeKind.Local).AddTicks(3816));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 78,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 874, DateTimeKind.Local).AddTicks(3822));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 79,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 874, DateTimeKind.Local).AddTicks(3829));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 80,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 874, DateTimeKind.Local).AddTicks(3835));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 81,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 874, DateTimeKind.Local).AddTicks(3840));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 82,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 874, DateTimeKind.Local).AddTicks(3846));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 83,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 874, DateTimeKind.Local).AddTicks(3852));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 84,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 874, DateTimeKind.Local).AddTicks(3858));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 85,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 874, DateTimeKind.Local).AddTicks(3863));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 86,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 874, DateTimeKind.Local).AddTicks(3869));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 87,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 874, DateTimeKind.Local).AddTicks(3875));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 88,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 874, DateTimeKind.Local).AddTicks(3881));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 89,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 874, DateTimeKind.Local).AddTicks(3887));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 90,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 874, DateTimeKind.Local).AddTicks(3894));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 91,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 874, DateTimeKind.Local).AddTicks(3900));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 92,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 874, DateTimeKind.Local).AddTicks(3907));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 93,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 874, DateTimeKind.Local).AddTicks(3913));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 94,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 874, DateTimeKind.Local).AddTicks(3919));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 95,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 874, DateTimeKind.Local).AddTicks(3926));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 96,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 874, DateTimeKind.Local).AddTicks(3932));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 97,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 874, DateTimeKind.Local).AddTicks(3938));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 98,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 874, DateTimeKind.Local).AddTicks(3944));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 99,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 874, DateTimeKind.Local).AddTicks(3951));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 100,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 874, DateTimeKind.Local).AddTicks(3957));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 101,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 874, DateTimeKind.Local).AddTicks(3964));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 102,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 874, DateTimeKind.Local).AddTicks(3971));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 103,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 874, DateTimeKind.Local).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 104,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 874, DateTimeKind.Local).AddTicks(3983));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 105,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 874, DateTimeKind.Local).AddTicks(4018));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 106,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 874, DateTimeKind.Local).AddTicks(4026));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 107,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 874, DateTimeKind.Local).AddTicks(4033));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 108,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 874, DateTimeKind.Local).AddTicks(4039));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 109,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 874, DateTimeKind.Local).AddTicks(4046));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 110,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 874, DateTimeKind.Local).AddTicks(4052));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 111,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 874, DateTimeKind.Local).AddTicks(4059));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 112,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 874, DateTimeKind.Local).AddTicks(4065));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 113,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 874, DateTimeKind.Local).AddTicks(4074));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 114,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 874, DateTimeKind.Local).AddTicks(4080));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 115,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 874, DateTimeKind.Local).AddTicks(4087));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 116,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 874, DateTimeKind.Local).AddTicks(4094));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 117,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 874, DateTimeKind.Local).AddTicks(4099));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 118,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 874, DateTimeKind.Local).AddTicks(4106));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 119,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 874, DateTimeKind.Local).AddTicks(4112));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 120,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 874, DateTimeKind.Local).AddTicks(4119));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 121,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 874, DateTimeKind.Local).AddTicks(4125));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 122,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 874, DateTimeKind.Local).AddTicks(4132));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 123,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 874, DateTimeKind.Local).AddTicks(4138));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 124,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 874, DateTimeKind.Local).AddTicks(4144));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 125,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 874, DateTimeKind.Local).AddTicks(4149));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 126,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 874, DateTimeKind.Local).AddTicks(4155));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 127,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 874, DateTimeKind.Local).AddTicks(4161));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 128,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 874, DateTimeKind.Local).AddTicks(4167));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 129,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 874, DateTimeKind.Local).AddTicks(4174));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 130,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 874, DateTimeKind.Local).AddTicks(4182));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 131,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 874, DateTimeKind.Local).AddTicks(4188));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 132,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 874, DateTimeKind.Local).AddTicks(4195));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 133,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 874, DateTimeKind.Local).AddTicks(4201));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 134,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 874, DateTimeKind.Local).AddTicks(4208));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 135,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 874, DateTimeKind.Local).AddTicks(4215));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 136,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 874, DateTimeKind.Local).AddTicks(4222));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 137,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 874, DateTimeKind.Local).AddTicks(4228));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 138,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 874, DateTimeKind.Local).AddTicks(4235));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 139,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 874, DateTimeKind.Local).AddTicks(4241));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 140,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 874, DateTimeKind.Local).AddTicks(4288));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 141,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 874, DateTimeKind.Local).AddTicks(4295));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 142,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 874, DateTimeKind.Local).AddTicks(4301));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 143,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 874, DateTimeKind.Local).AddTicks(4307));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 144,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 874, DateTimeKind.Local).AddTicks(4314));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 145,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 874, DateTimeKind.Local).AddTicks(4321));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 146,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 874, DateTimeKind.Local).AddTicks(4328));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 147,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 874, DateTimeKind.Local).AddTicks(4335));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 148,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 874, DateTimeKind.Local).AddTicks(4342));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 149,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 874, DateTimeKind.Local).AddTicks(4350));

            migrationBuilder.UpdateData(
                table: "PinCodeTypes",
                keyColumn: "PinCodeTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 922, DateTimeKind.Local).AddTicks(4607));

            migrationBuilder.UpdateData(
                table: "PinCodeTypes",
                keyColumn: "PinCodeTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 922, DateTimeKind.Local).AddTicks(4845));

            migrationBuilder.UpdateData(
                table: "PinCodeTypes",
                keyColumn: "PinCodeTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 922, DateTimeKind.Local).AddTicks(4859));

            migrationBuilder.UpdateData(
                table: "PriorityRanks",
                keyColumn: "PriorityRankID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 888, DateTimeKind.Local).AddTicks(7028));

            migrationBuilder.UpdateData(
                table: "PriorityRanks",
                keyColumn: "PriorityRankID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 888, DateTimeKind.Local).AddTicks(7245));

            migrationBuilder.UpdateData(
                table: "PriorityRanks",
                keyColumn: "PriorityRankID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 888, DateTimeKind.Local).AddTicks(7254));

            migrationBuilder.UpdateData(
                table: "PriorityRanks",
                keyColumn: "PriorityRankID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 888, DateTimeKind.Local).AddTicks(7258));

            migrationBuilder.UpdateData(
                table: "ProductComputations",
                keyColumn: "ProductComputationID",
                keyValue: 1,
                columns: new[] { "DateCreated", "LastChangedDate" },
                values: new object[] { new DateTime(2022, 4, 17, 22, 40, 17, 930, DateTimeKind.Local).AddTicks(9531), new DateTime(2022, 4, 17, 22, 40, 17, 930, DateTimeKind.Local).AddTicks(9842) });

            migrationBuilder.UpdateData(
                table: "ProductComputations",
                keyColumn: "ProductComputationID",
                keyValue: 2,
                columns: new[] { "DateCreated", "LastChangedDate" },
                values: new object[] { new DateTime(2022, 4, 17, 22, 40, 17, 931, DateTimeKind.Local).AddTicks(118), new DateTime(2022, 4, 17, 22, 40, 17, 931, DateTimeKind.Local).AddTicks(133) });

            migrationBuilder.UpdateData(
                table: "RecordStatus",
                keyColumn: "RecordStatusID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 910, DateTimeKind.Local).AddTicks(8260));

            migrationBuilder.UpdateData(
                table: "RecordStatus",
                keyColumn: "RecordStatusID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 910, DateTimeKind.Local).AddTicks(8634));

            migrationBuilder.UpdateData(
                table: "RecordStatus",
                keyColumn: "RecordStatusID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 910, DateTimeKind.Local).AddTicks(8648));

            migrationBuilder.UpdateData(
                table: "RelationshipTypes",
                keyColumn: "RelationshipTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 884, DateTimeKind.Local).AddTicks(1369));

            migrationBuilder.UpdateData(
                table: "RelationshipTypes",
                keyColumn: "RelationshipTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 884, DateTimeKind.Local).AddTicks(1437));

            migrationBuilder.UpdateData(
                table: "RelationshipTypes",
                keyColumn: "RelationshipTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 884, DateTimeKind.Local).AddTicks(1441));

            migrationBuilder.UpdateData(
                table: "RelationshipTypes",
                keyColumn: "RelationshipTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 884, DateTimeKind.Local).AddTicks(1445));

            migrationBuilder.UpdateData(
                table: "RelationshipTypes",
                keyColumn: "RelationshipTypeID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 884, DateTimeKind.Local).AddTicks(1448));

            migrationBuilder.UpdateData(
                table: "RelationshipTypes",
                keyColumn: "RelationshipTypeID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 884, DateTimeKind.Local).AddTicks(1454));

            migrationBuilder.UpdateData(
                table: "RelationshipTypes",
                keyColumn: "RelationshipTypeID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 884, DateTimeKind.Local).AddTicks(1457));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 903, DateTimeKind.Local).AddTicks(3798));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 903, DateTimeKind.Local).AddTicks(3872));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 903, DateTimeKind.Local).AddTicks(3877));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 903, DateTimeKind.Local).AddTicks(3880));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 903, DateTimeKind.Local).AddTicks(3883));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 903, DateTimeKind.Local).AddTicks(3888));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 903, DateTimeKind.Local).AddTicks(3892));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 903, DateTimeKind.Local).AddTicks(3896));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 903, DateTimeKind.Local).AddTicks(3899));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 903, DateTimeKind.Local).AddTicks(3904));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 874, DateTimeKind.Local).AddTicks(9121));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 874, DateTimeKind.Local).AddTicks(9191));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 874, DateTimeKind.Local).AddTicks(9195));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 874, DateTimeKind.Local).AddTicks(9198));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 874, DateTimeKind.Local).AddTicks(9200));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 874, DateTimeKind.Local).AddTicks(9204));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 874, DateTimeKind.Local).AddTicks(9207));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 874, DateTimeKind.Local).AddTicks(9209));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 874, DateTimeKind.Local).AddTicks(9211));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 874, DateTimeKind.Local).AddTicks(9215));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 874, DateTimeKind.Local).AddTicks(9217));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 874, DateTimeKind.Local).AddTicks(9220));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 13,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 874, DateTimeKind.Local).AddTicks(9222));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 14,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 874, DateTimeKind.Local).AddTicks(9224));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 15,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 874, DateTimeKind.Local).AddTicks(9227));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 16,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 874, DateTimeKind.Local).AddTicks(9229));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 17,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 874, DateTimeKind.Local).AddTicks(9231));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 18,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 874, DateTimeKind.Local).AddTicks(9235));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 19,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 874, DateTimeKind.Local).AddTicks(9237));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 20,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 874, DateTimeKind.Local).AddTicks(9240));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 21,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 874, DateTimeKind.Local).AddTicks(9242));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 22,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 874, DateTimeKind.Local).AddTicks(9244));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 23,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 874, DateTimeKind.Local).AddTicks(9247));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 24,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 874, DateTimeKind.Local).AddTicks(9249));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 25,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 874, DateTimeKind.Local).AddTicks(9251));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 26,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 874, DateTimeKind.Local).AddTicks(9254));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 27,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 874, DateTimeKind.Local).AddTicks(9256));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 28,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 874, DateTimeKind.Local).AddTicks(9258));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 29,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 874, DateTimeKind.Local).AddTicks(9260));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 30,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 874, DateTimeKind.Local).AddTicks(9263));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 31,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 874, DateTimeKind.Local).AddTicks(9265));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 32,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 874, DateTimeKind.Local).AddTicks(9267));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 33,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 874, DateTimeKind.Local).AddTicks(9270));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 34,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 874, DateTimeKind.Local).AddTicks(9273));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 35,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 874, DateTimeKind.Local).AddTicks(9275));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 36,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 874, DateTimeKind.Local).AddTicks(9278));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 37,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 874, DateTimeKind.Local).AddTicks(9280));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 38,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 874, DateTimeKind.Local).AddTicks(9282));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 39,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 874, DateTimeKind.Local).AddTicks(9285));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 40,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 874, DateTimeKind.Local).AddTicks(9287));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 41,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 874, DateTimeKind.Local).AddTicks(9289));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 42,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 874, DateTimeKind.Local).AddTicks(9292));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 43,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 874, DateTimeKind.Local).AddTicks(9294));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 44,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 874, DateTimeKind.Local).AddTicks(9296));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 45,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 874, DateTimeKind.Local).AddTicks(9299));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 46,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 874, DateTimeKind.Local).AddTicks(9301));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 47,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 874, DateTimeKind.Local).AddTicks(9303));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 48,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 874, DateTimeKind.Local).AddTicks(9305));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 49,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 874, DateTimeKind.Local).AddTicks(9308));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 50,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 874, DateTimeKind.Local).AddTicks(9310));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 51,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 874, DateTimeKind.Local).AddTicks(9312));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 52,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 874, DateTimeKind.Local).AddTicks(9315));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 53,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 874, DateTimeKind.Local).AddTicks(9317));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 54,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 874, DateTimeKind.Local).AddTicks(9319));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 55,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 874, DateTimeKind.Local).AddTicks(9322));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 56,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 874, DateTimeKind.Local).AddTicks(9324));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 57,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 874, DateTimeKind.Local).AddTicks(9352));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 58,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 874, DateTimeKind.Local).AddTicks(9355));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 59,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 874, DateTimeKind.Local).AddTicks(9357));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 60,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 874, DateTimeKind.Local).AddTicks(9360));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 61,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 874, DateTimeKind.Local).AddTicks(9363));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 62,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 874, DateTimeKind.Local).AddTicks(9365));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 63,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 874, DateTimeKind.Local).AddTicks(9367));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 64,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 874, DateTimeKind.Local).AddTicks(9370));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 65,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 874, DateTimeKind.Local).AddTicks(9372));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 66,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 874, DateTimeKind.Local).AddTicks(9375));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 67,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 874, DateTimeKind.Local).AddTicks(9378));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 68,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 874, DateTimeKind.Local).AddTicks(9380));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 69,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 874, DateTimeKind.Local).AddTicks(9382));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 70,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 874, DateTimeKind.Local).AddTicks(9385));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 71,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 874, DateTimeKind.Local).AddTicks(9387));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 72,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 874, DateTimeKind.Local).AddTicks(9389));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 73,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 874, DateTimeKind.Local).AddTicks(9391));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 74,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 874, DateTimeKind.Local).AddTicks(9394));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 75,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 874, DateTimeKind.Local).AddTicks(9396));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 76,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 874, DateTimeKind.Local).AddTicks(9399));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 77,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 874, DateTimeKind.Local).AddTicks(9401));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 78,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 874, DateTimeKind.Local).AddTicks(9403));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 79,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 874, DateTimeKind.Local).AddTicks(9406));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 80,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 874, DateTimeKind.Local).AddTicks(9408));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 81,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 874, DateTimeKind.Local).AddTicks(9410));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 82,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 874, DateTimeKind.Local).AddTicks(9413));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 83,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 874, DateTimeKind.Local).AddTicks(9415));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 84,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 874, DateTimeKind.Local).AddTicks(9418));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 85,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 874, DateTimeKind.Local).AddTicks(9420));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 86,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 874, DateTimeKind.Local).AddTicks(9423));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 87,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 874, DateTimeKind.Local).AddTicks(9425));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 88,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 874, DateTimeKind.Local).AddTicks(9427));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 89,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 874, DateTimeKind.Local).AddTicks(9430));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 90,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 874, DateTimeKind.Local).AddTicks(9432));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 91,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 874, DateTimeKind.Local).AddTicks(9434));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 92,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 874, DateTimeKind.Local).AddTicks(9437));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 93,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 874, DateTimeKind.Local).AddTicks(9439));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 94,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 874, DateTimeKind.Local).AddTicks(9442));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 95,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 874, DateTimeKind.Local).AddTicks(9444));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 96,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 874, DateTimeKind.Local).AddTicks(9446));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 97,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 874, DateTimeKind.Local).AddTicks(9449));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 98,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 874, DateTimeKind.Local).AddTicks(9451));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 99,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 874, DateTimeKind.Local).AddTicks(9453));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 100,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 874, DateTimeKind.Local).AddTicks(9455));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 101,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 874, DateTimeKind.Local).AddTicks(9458));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 102,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 874, DateTimeKind.Local).AddTicks(9460));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 103,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 874, DateTimeKind.Local).AddTicks(9462));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 104,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 874, DateTimeKind.Local).AddTicks(9465));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 105,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 874, DateTimeKind.Local).AddTicks(9467));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 106,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 874, DateTimeKind.Local).AddTicks(9469));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 107,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 874, DateTimeKind.Local).AddTicks(9473));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 108,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 874, DateTimeKind.Local).AddTicks(9475));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 109,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 874, DateTimeKind.Local).AddTicks(9477));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 110,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 874, DateTimeKind.Local).AddTicks(9480));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 111,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 874, DateTimeKind.Local).AddTicks(9482));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 112,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 874, DateTimeKind.Local).AddTicks(9484));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 113,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 874, DateTimeKind.Local).AddTicks(9487));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 114,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 874, DateTimeKind.Local).AddTicks(9489));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 115,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 874, DateTimeKind.Local).AddTicks(9491));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 116,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 874, DateTimeKind.Local).AddTicks(9493));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 117,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 874, DateTimeKind.Local).AddTicks(9496));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 118,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 874, DateTimeKind.Local).AddTicks(9498));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 119,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 874, DateTimeKind.Local).AddTicks(9500));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 120,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 874, DateTimeKind.Local).AddTicks(9503));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 121,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 874, DateTimeKind.Local).AddTicks(9505));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 122,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 874, DateTimeKind.Local).AddTicks(9507));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 123,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 874, DateTimeKind.Local).AddTicks(9510));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 124,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 874, DateTimeKind.Local).AddTicks(9512));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 125,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 874, DateTimeKind.Local).AddTicks(9514));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 126,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 874, DateTimeKind.Local).AddTicks(9517));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 127,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 874, DateTimeKind.Local).AddTicks(9519));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 128,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 874, DateTimeKind.Local).AddTicks(9521));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 129,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 874, DateTimeKind.Local).AddTicks(9524));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 130,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 874, DateTimeKind.Local).AddTicks(9528));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 131,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 874, DateTimeKind.Local).AddTicks(9531));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 132,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 874, DateTimeKind.Local).AddTicks(9534));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 133,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 874, DateTimeKind.Local).AddTicks(9537));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 134,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 874, DateTimeKind.Local).AddTicks(9539));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 135,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 874, DateTimeKind.Local).AddTicks(9541));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 136,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 874, DateTimeKind.Local).AddTicks(9565));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 137,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 874, DateTimeKind.Local).AddTicks(9568));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 138,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 874, DateTimeKind.Local).AddTicks(9571));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 139,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 874, DateTimeKind.Local).AddTicks(9573));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 140,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 874, DateTimeKind.Local).AddTicks(9576));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 141,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 874, DateTimeKind.Local).AddTicks(9578));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 142,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 874, DateTimeKind.Local).AddTicks(9581));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 143,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 874, DateTimeKind.Local).AddTicks(9583));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 144,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 874, DateTimeKind.Local).AddTicks(9585));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 145,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 874, DateTimeKind.Local).AddTicks(9587));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 146,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 874, DateTimeKind.Local).AddTicks(9590));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 147,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 874, DateTimeKind.Local).AddTicks(9592));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 148,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 874, DateTimeKind.Local).AddTicks(9594));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 149,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 874, DateTimeKind.Local).AddTicks(9596));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 868, DateTimeKind.Local).AddTicks(8942));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 871, DateTimeKind.Local).AddTicks(4331));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 871, DateTimeKind.Local).AddTicks(4405));

            migrationBuilder.UpdateData(
                table: "StatementLists",
                keyColumn: "StatementID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 906, DateTimeKind.Local).AddTicks(374));

            migrationBuilder.UpdateData(
                table: "StatementLists",
                keyColumn: "StatementID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 906, DateTimeKind.Local).AddTicks(615));

            migrationBuilder.UpdateData(
                table: "StatementLists",
                keyColumn: "StatementID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 906, DateTimeKind.Local).AddTicks(623));

            migrationBuilder.UpdateData(
                table: "StatementLists",
                keyColumn: "StatementID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 906, DateTimeKind.Local).AddTicks(628));

            migrationBuilder.UpdateData(
                table: "TechnicalSupport",
                keyColumn: "TechnicalSupportID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 920, DateTimeKind.Local).AddTicks(8293));

            migrationBuilder.UpdateData(
                table: "TechnicalSupport",
                keyColumn: "TechnicalSupportID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 920, DateTimeKind.Local).AddTicks(8595));

            migrationBuilder.UpdateData(
                table: "TechnicalSupport",
                keyColumn: "TechnicalSupportID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 920, DateTimeKind.Local).AddTicks(8609));

            migrationBuilder.UpdateData(
                table: "TechnicalSupport",
                keyColumn: "TechnicalSupportID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 920, DateTimeKind.Local).AddTicks(8615));

            migrationBuilder.UpdateData(
                table: "TechnicalSupport",
                keyColumn: "TechnicalSupportID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 920, DateTimeKind.Local).AddTicks(8623));

            migrationBuilder.UpdateData(
                table: "TechnicalSupport",
                keyColumn: "TechnicalSupportID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 920, DateTimeKind.Local).AddTicks(8634));

            migrationBuilder.UpdateData(
                table: "TechnicalSupport",
                keyColumn: "TechnicalSupportID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 920, DateTimeKind.Local).AddTicks(8641));

            migrationBuilder.UpdateData(
                table: "Titles",
                keyColumn: "TitleID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 907, DateTimeKind.Local).AddTicks(3429));

            migrationBuilder.UpdateData(
                table: "Titles",
                keyColumn: "TitleID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 907, DateTimeKind.Local).AddTicks(3607));

            migrationBuilder.UpdateData(
                table: "Titles",
                keyColumn: "TitleID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 907, DateTimeKind.Local).AddTicks(3615));

            migrationBuilder.UpdateData(
                table: "Titles",
                keyColumn: "TitleID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 907, DateTimeKind.Local).AddTicks(3618));

            migrationBuilder.UpdateData(
                table: "Titles",
                keyColumn: "TitleID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 907, DateTimeKind.Local).AddTicks(3621));

            migrationBuilder.UpdateData(
                table: "Titles",
                keyColumn: "TitleID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 907, DateTimeKind.Local).AddTicks(3627));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 878, DateTimeKind.Local).AddTicks(7979));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 878, DateTimeKind.Local).AddTicks(8435));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 878, DateTimeKind.Local).AddTicks(8491));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 878, DateTimeKind.Local).AddTicks(8545));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 878, DateTimeKind.Local).AddTicks(8595));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 878, DateTimeKind.Local).AddTicks(8647));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 878, DateTimeKind.Local).AddTicks(8692));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 878, DateTimeKind.Local).AddTicks(8737));

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumns: new[] { "UserID", "RoleID" },
                keyValues: new object[] { 1, 1 },
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 894, DateTimeKind.Local).AddTicks(672));

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumns: new[] { "UserID", "RoleID" },
                keyValues: new object[] { 2, 3 },
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 894, DateTimeKind.Local).AddTicks(759));

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "UserTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 883, DateTimeKind.Local).AddTicks(1847));

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "UserTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 883, DateTimeKind.Local).AddTicks(2072));

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "UserTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 883, DateTimeKind.Local).AddTicks(2081));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 889, DateTimeKind.Local).AddTicks(907));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 889, DateTimeKind.Local).AddTicks(4376));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 889, DateTimeKind.Local).AddTicks(4470));

            migrationBuilder.UpdateData(
                table: "VariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 885, DateTimeKind.Local).AddTicks(4647));

            migrationBuilder.UpdateData(
                table: "VariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 885, DateTimeKind.Local).AddTicks(4894));

            migrationBuilder.UpdateData(
                table: "VariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 885, DateTimeKind.Local).AddTicks(4904));

            migrationBuilder.UpdateData(
                table: "VariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 885, DateTimeKind.Local).AddTicks(4908));

            migrationBuilder.UpdateData(
                table: "VariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 885, DateTimeKind.Local).AddTicks(4912));

            migrationBuilder.UpdateData(
                table: "VariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 885, DateTimeKind.Local).AddTicks(4920));

            migrationBuilder.UpdateData(
                table: "VariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 885, DateTimeKind.Local).AddTicks(4928));

            migrationBuilder.UpdateData(
                table: "VariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 885, DateTimeKind.Local).AddTicks(4932));

            migrationBuilder.UpdateData(
                table: "VariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2022, 4, 17, 22, 40, 17, 885, DateTimeKind.Local).AddTicks(4937));
        }
    }
}
